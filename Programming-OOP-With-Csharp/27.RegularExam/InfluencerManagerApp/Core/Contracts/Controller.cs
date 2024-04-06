using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfluencerManagerApp.Models;
using InfluencerManagerApp.Models.Contracts;
using InfluencerManagerApp.Repositories;
using InfluencerManagerApp.Repositories.Contracts;

namespace InfluencerManagerApp.Core.Contracts
{
    public class Controller : IController
    {
        private IRepository<IInfluencer> influencers;
        private IRepository<ICampaign> campaigns;

        public Controller()
        {
            influencers = new InfluencerRepository();
            campaigns = new CampaignRepository();
        }

        public string RegisterInfluencer(string typeName, string username, int followers)
        {
            if (typeName != "BusinessInfluencer" && typeName != "FashionInfluencer" && typeName != "BloggerInfluencer")
            {
                return $"{typeName} has not passed validation.";
            }

            if (influencers.Models.Any(i => i.Username == username))
            {
                return $"{username} is already registered in {typeName}.";
            }

            Type influencerType = Type.GetType($"InfluencerManagerApp.Models.{typeName}");

            Influencer influencer = (Influencer)Activator.CreateInstance(influencerType, username, followers);

            influencers.AddModel(influencer);

            return $"{username} registered successfully to the application.";
        }

        public string BeginCampaign(string typeName, string brand)
        {
            Type campaignType = Type.GetType($"InfluencerManagerApp.Models.{typeName}");
            if (campaignType == null || !typeof(Campaign).IsAssignableFrom(campaignType))
            {
                return $"{typeName} is not a valid campaign in the application.";
            }

            if (campaigns.Models.Any(c => c.Brand == brand))
            {
                return $"{brand} campaign cannot be duplicated.";
            }

            Campaign campaign = (Campaign)Activator.CreateInstance(campaignType, brand);
            campaigns.AddModel(campaign);

            return $"{brand} started a {typeName}.";
        }

        public string AttractInfluencer(string brand, string username)
        {
            IInfluencer influencer = influencers.FindByName(username);
            if (influencer == null)
            {
                return $"{nameof(InfluencerRepository)} has no {username} registered in the application.";
            }

            ICampaign campaign = campaigns.FindByName(brand);
            if (campaign == null)
            {
                return $"There is no campaign from {brand} in the application.";
            }

            if (campaign.Contributors.Contains(username))
            {
                return $"{username} is already engaged for the {brand} campaign.";
            }

            if (campaign is ProductCampaign && !(influencer is BusinessInfluencer || influencer is FashionInfluencer))
            {
                return $"{username} is not eligible for the {brand} campaign.";
            }
            if (campaign is ServiceCampaign && !(influencer is BusinessInfluencer || influencer is BloggerInfluencer))
            {
                return $"{username} is not eligible for the {brand} campaign.";
            }

            int campaignPrice = influencer.CalculateCampaignPrice();
            if (campaign.Budget < campaignPrice)
            {
                return $"The budget for {brand} is insufficient to engage {username}.";
            }

            campaign.Engage(influencer);

            return $"{username} has been successfully attracted to the {brand} campaign.";
        }

        public string FundCampaign(string brand, double amount)
        {
            var foundCampaign = campaigns.FindByName(brand);
            if (foundCampaign == null)
            {
                return "Trying to close an invalid campaign.";
            }

            if (amount < 0)
            {
                return "Funding amount must be greater than zero.";
            }

            foundCampaign.Gain(amount);

            return $"{brand} campaign has been successfully funded with {amount} $";
        }

        public string CloseCampaign(string brand)
        {
            var foundCampaign = campaigns.FindByName(brand);
            if (foundCampaign == null)
            {
                return "Trying to close an invalid campaign.";
            }

            if (foundCampaign.Budget <= 10000)
            {
                return $"{brand} campaign cannot be closed as it has not met its financial targets.";
            }

            foreach (string contributor in foundCampaign.Contributors)
            {
                IInfluencer influencer = influencers.FindByName(contributor);
                influencer.EarnFee(2000);
                influencer.EndParticipation(brand);
            }
            campaigns.RemoveModel(foundCampaign);

            return $"{brand} campaign has reached its target.";
        }

        public string ConcludeAppContract(string username)
        {
            IInfluencer foundinfluencer = influencers.FindByName(username);
            if (foundinfluencer == null)
            {
                return $"{username} has still not signed a contract.";
            }

            if (foundinfluencer.Participations.Any())
            {
                return $"{username} cannot conclude the contract while enrolled in active campaigns.";
            }

            influencers.RemoveModel(foundinfluencer);

            return $"{username} concluded their contract.";
        }

        public string ApplicationReport()
        {
            var orderedInfluencers =
                influencers.Models.OrderByDescending(i => i.Income)
                    .ThenByDescending(i => i.Followers);

            StringBuilder sb = new StringBuilder();
            foreach (var influencer in orderedInfluencers)
            {
                sb.AppendLine(influencer.ToString());
                if (influencer.Participations.Any())
                {
                    sb.AppendLine("Active Campaigns:");
                    foreach (var brand in influencer.Participations.OrderBy(b => b))
                    {
                        sb.AppendLine($"--{brand}");
                        sb.Append(brand.ToString());
                    }
                }

                sb.AppendLine();
            }

            return sb.ToString().TrimEnd();
        }
    }
}
