using System.Xml.Serialization;

namespace TravelAgency.DataProcessor.ExportDtos
{
    //[XmlType("Booking")]
    //public class BookingExportDto
    //{
    //    [XmlElement("CustomerFullName")]
    //    public string CustomerFullName { get; set; }

    //    [XmlElement("TourPackageName")]
    //    public string TourPackageName { get; set; }

    //    [XmlElement("Date")]
    //    public DateTime Date { get; set; }
    //}


    public class BookingExportDto
    {
        public string TourPackageName { get; set; }
        public string Date { get; set; }
    }
}
