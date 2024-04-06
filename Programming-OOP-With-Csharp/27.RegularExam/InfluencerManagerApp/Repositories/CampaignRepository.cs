using InfluencerManagerApp.Models.Contracts;
using InfluencerManagerApp.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfluencerManagerApp.Repositories
{
    public class CampaignRepository : IRepository<ICampaign>
    {
        private readonly List<ICampaign> models;

        public CampaignRepository()
        {
            models = new List<ICampaign>(); // by me
        }
        public IReadOnlyCollection<ICampaign> Models => models;

        public void AddModel(ICampaign campaign) => models.Add(campaign);

        public bool RemoveModel(ICampaign campaign) => models.Remove(campaign);

        public ICampaign FindByName(string brand) => models.FirstOrDefault(i => i.Brand == brand);
    }
}
