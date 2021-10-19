using System.ComponentModel.DataAnnotations;

namespace LexiconProject_ComputerWebShop.Models
{
    public class Address
    {
        [Key]
        public int AdressId { get; set; }
        public string PostalCode { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}