using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Data.Models
{
    public class TourPackageGuide
    {
        public int TourPackageId { get; set; }
        public TourPackage TourPackage { get; set; }

        public int GuideId { get; set; }    
        public Guide Guide { get; set; }    
    }
}
