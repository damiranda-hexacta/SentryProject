using System;
namespace Sentry.Framework.Models
{
    public class DataInjection
    {

        private string companyName, phoneNumber, fullName, email, requestorName,
            address, zipCode;

        public DataInjection()
        {
            this.companyName = Faker.Company.Name();
            this.phoneNumber = Faker.Identification.SocialSecurityNumber();
            this.fullName = Faker.Name.FullName();
            this.email = Faker.Internet.Email();
            this.requestorName = Faker.Internet.DomainName();
            this.address = "OLD CLUB";
            this.zipCode = "37215";
        }

        public string CompanyName { get => companyName; set => companyName = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string Email { get => email; set => email = value; }
        public string RequestorName { get => requestorName; set => requestorName = value; }
        public string Address { get => address; set => address = value; }
        public string ZipCode { get => zipCode; set => zipCode = value; }

    }
}

