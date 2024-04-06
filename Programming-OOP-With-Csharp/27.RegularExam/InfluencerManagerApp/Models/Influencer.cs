using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfluencerManagerApp.Models.Contracts;

namespace InfluencerManagerApp.Models
{
    public abstract class Influencer : IInfluencer
    {
        private string username;
        private int followers;
        private double engagementRate;
        private readonly List<string> participations;

        public Influencer(string username, int followers, double engagementRate)
        {
            Username = username;
            Followers = followers;
            EngagementRate = engagementRate;
            Income = 0;
            participations = new List<string>();
        }

        public string Username
        {
            get => username;

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Username is required.");
                }

                username = value;
            }
        }

        public int Followers
        {
            get => followers;

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Followers count cannot be a negative number.");
                }

                followers = value;
            }
        }

        public double EngagementRate
        {
            get => engagementRate;
            private set => engagementRate = value;
        }
        public double Income { get; private set; } //to be reviewed

        public IReadOnlyCollection<string> Participations => participations;

        public void EarnFee(double amount)
        {
            Income += amount;
        }

        public void EnrollCampaign(string brand) => participations.Add(brand);

        public void EndParticipation(string brand) => participations.Remove(brand);

        public abstract int CalculateCampaignPrice();

        public override string ToString() 
            => $"{Username} - Followers: {Followers}, Total Income: {Income}";
    }
}
