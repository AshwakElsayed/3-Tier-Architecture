using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Core.Models
{
    public class Address
    {
        public int Id { get; set; }
        public Country Country { get; set; }
        public int CountryId { get; set; }
        public Governate Governate { get; set; }
        public int GovernateId { get; set; }
        public City City { get; set; }
        public int CityId { get; set; }
        public string StreetAddress { get; set; }
        public int ZipCode { get; set; }
        public string PhoneNumber { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
    }
}
