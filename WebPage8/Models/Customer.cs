using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LexiconProject_ComputerWebShop.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        [JsonIgnore]
        public Address Address { get; set; }
        //[JsonIgnore]
        public ICollection<Order> Orders { get; set; }
        //[JsonIgnore]
        public ICollection<Review> Reviews { get; set; }
    }
}
