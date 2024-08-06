using Enums;
using Newtonsoft.Json;
using TravelAgency.Data;
using TravelAgency.DataProcessor.ExportDtos;
using TravelAgency.DataProcessor.ImportDtos;
using TravelAgency.Utilites;

namespace TravelAgency.DataProcessor
{
    public class Serializer
    {
        public static string ExportGuidesWithSpanishLanguageWithAllTheirTourPackages(TravelAgencyContext context)
        {
            XMLHelper xmlHelper = new XMLHelper();

            var guides = context.Guides
               .Where(g => g.Language == Language.Spanish)
               .Select(g => new GuideExportDto
               {
                   FullName = g.FullName,
                   TourPackages = g.TourPackagesGuides
                       .OrderByDescending(tpg => tpg.TourPackage.Price)
                       .ThenBy(tpg => tpg.TourPackage.PackageName)
                       .Select(tpg => new TourPackageExportDto
                       {
                           Name = tpg.TourPackage.PackageName,
                           Description = tpg.TourPackage.Description,
                           Price = tpg.TourPackage.Price
                       })
                       .ToList()
               })
               .OrderByDescending(g => g.TourPackages.Count)
               .ThenBy(g => g.FullName)
               .ToList();

            return xmlHelper.Serialize(guides.ToArray(), "Guides");
        }

        public static string ExportCustomersThatHaveBookedHorseRidingTourPackage(TravelAgencyContext context)
        {
            var customers = context.Customers
                  .Where(c => c.Bookings.Any(b => b.TourPackage.PackageName == "Horse Riding Tour"))
                  .Select(c => new CustomerExportDto
                  {
                      FullName = c.FullName,
                      PhoneNumber = c.PhoneNumber,
                      Bookings = c.Bookings
                          .Where(b => b.TourPackage.PackageName == "Horse Riding Tour")
                          .OrderBy(b => b.BookingDate)
                          .Select(b => new BookingExportDto
                          {
                              TourPackageName = b.TourPackage.PackageName,
                              Date = b.BookingDate.ToString("yyyy-MM-dd")
                              //   Date = b.BookingDate.ToString("yyyy-MM-dd"),
                          })
                          .ToList()
                  })
                  .OrderByDescending(c => c.Bookings.Count)
                  .ThenBy(c => c.FullName)
                  .ToList();

            return JsonConvert.SerializeObject(customers, Formatting.Indented);
        }
    }
}
