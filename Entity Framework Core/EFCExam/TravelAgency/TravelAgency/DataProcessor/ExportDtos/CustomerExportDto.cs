using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.DataProcessor.ImportDtos;

namespace TravelAgency.DataProcessor.ExportDtos
{
    public class CustomerExportDto
    {
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public List<BookingExportDto> Bookings { get; set; }
    }
}
