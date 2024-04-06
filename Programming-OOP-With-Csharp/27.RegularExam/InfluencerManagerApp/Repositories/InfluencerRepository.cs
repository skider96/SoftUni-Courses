using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfluencerManagerApp.Models;
using InfluencerManagerApp.Models.Contracts;
using InfluencerManagerApp.Repositories.Contracts;

namespace InfluencerManagerApp.Repositories
{
    public class InfluencerRepository : IRepository<IInfluencer>
    {
        private readonly List<IInfluencer> models;

        public InfluencerRepository()
        {
            models = new List<IInfluencer>(); // by me
        }
        public IReadOnlyCollection<IInfluencer> Models => models;

        public void AddModel(IInfluencer influencer) => models.Add(influencer);

        public bool RemoveModel(IInfluencer influencer) => models.Remove(influencer);

        public IInfluencer FindByName(string username) 
            => models.FirstOrDefault(i => i.Username == username);
    }
}
