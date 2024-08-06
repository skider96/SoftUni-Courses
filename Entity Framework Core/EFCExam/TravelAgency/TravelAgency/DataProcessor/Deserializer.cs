using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using TravelAgency.Data;
using TravelAgency.Data.Models;
using TravelAgency.DataProcessor.ImportDtos;

namespace TravelAgency.DataProcessor
{
    public class Deserializer
    {
        private const string ErrorMessage = "Invalid data format!";
        private const string DuplicationDataMessage = "Error! Data duplicated.";
        private const string SuccessfullyImportedCustomer = "Successfully imported customer - {0}";
        private const string SuccessfullyImportedBooking = "Successfully imported booking. TourPackage: {0}, Date: {1}";

        public static string ImportCustomers(TravelAgencyContext context, string xmlString)
        {

            var sb = new StringBuilder();
            var xmlDoc = XDocument.Parse(xmlString);

            var customerDtos = xmlDoc.Root.Elements("Customer")
                .Select(c => new CustomerImportDto
                {
                    FullName = c.Element("FullName").Value,
                    Email = c.Element("Email").Value,
                    PhoneNumber = c.Attribute("phoneNumber").Value
                })
                .ToList();

            foreach (var customerDto in customerDtos)
            {
                if (!IsValidCustomer(customerDto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                if (IsDuplicateCustomer(context, customerDto))
                {
                    sb.AppendLine(DuplicationDataMessage);
                    continue;
                }

                var customer = new Customer
                {
                    FullName = customerDto.FullName,
                    Email = customerDto.Email,
                    PhoneNumber = customerDto.PhoneNumber
                };

                context.Customers.Add(customer);
                context.SaveChanges();
                sb.AppendLine(string.Format(SuccessfullyImportedCustomer, customerDto.FullName));
            }

            return sb.ToString().Trim();
        }

        public static string ImportBookings(TravelAgencyContext context, string jsonString)
        {
            var sb = new StringBuilder();

            List<BookingImportDto> bookings;
            try
            {
                bookings = JsonConvert.DeserializeObject<List<BookingImportDto>>(jsonString);
                if (bookings == null)
                {
                    return ErrorMessage;
                }
            }
            catch (JsonException)
            {
                return ErrorMessage;
            }

            foreach (var bookingDto in bookings)
            {
                if (!IsValid(bookingDto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                if (!DateTime.TryParseExact(bookingDto.BookingDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out var bookingDate))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var customer = context.Customers.SingleOrDefault(c => c.FullName == bookingDto.CustomerName);
                var tourPackage = context.TourPackages.SingleOrDefault(tp => tp.PackageName == bookingDto.TourPackageName);

                if (customer == null || tourPackage == null)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                if (context.Bookings.Any(b => b.CustomerId == customer.Id && b.TourPackageId == tourPackage.Id && b.BookingDate == bookingDate))
                {
                    sb.AppendLine(DuplicationDataMessage);
                    continue;
                }

                var booking = new Booking
                {
                    BookingDate = bookingDate,
                    CustomerId = customer.Id,
                    TourPackageId = tourPackage.Id
                };

                context.Bookings.Add(booking);
                context.SaveChanges();
                sb.AppendLine(string.Format(SuccessfullyImportedBooking, bookingDto.TourPackageName, bookingDate.ToString("yyyy-MM-dd")));
            }

            return sb.ToString().Trim();
        }

        public static bool IsValid(object dto)
        {
            var validateContext = new ValidationContext(dto);
            var validationResults = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(dto, validateContext, validationResults, true);

            foreach (var validationResult in validationResults)
            {
                string currValidationMessage = validationResult.ErrorMessage;
            }

            return isValid;
        }


        private static bool IsValidCustomer(CustomerImportDto dto)
        {
            return !string.IsNullOrWhiteSpace(dto.FullName) &&
                   dto.FullName.Length >= 4 && dto.FullName.Length <= 60 &&
                   !string.IsNullOrWhiteSpace(dto.Email) &&
                   dto.Email.Length >= 6 && dto.Email.Length <= 50 &&
                   Regex.IsMatch(dto.PhoneNumber, @"^\+\d{12}$");
        }

        private static bool IsDuplicateCustomer(TravelAgencyContext context, CustomerImportDto dto)
        {
            return context.Customers.Any(c => c.FullName == dto.FullName || c.Email == dto.Email || c.PhoneNumber == dto.PhoneNumber);
        }
    }
}
