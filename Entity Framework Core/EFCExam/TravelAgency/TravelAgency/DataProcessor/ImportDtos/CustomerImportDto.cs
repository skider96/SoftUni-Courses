using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TravelAgency.DataProcessor.ImportDtos
{
    [XmlType("Customer")]
    public class CustomerImportDto
    {
        [XmlElement("FullName")]
        [Required]
        [MinLength(4)]
        [MaxLength(60)]
        public string FullName { get; set; }

        [XmlElement("Email")]
        [Required]
        [MinLength(6)]
        [MaxLength(50)]
        public string Email { get; set; }

        [XmlAttribute("PhoneNumber")]
        [Required]
        [RegularExpression(@"^\+\d{12}$")]
        public string PhoneNumber { get; set; }

    }
}
