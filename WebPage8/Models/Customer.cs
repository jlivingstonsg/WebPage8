﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebPage8.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string PostalCode { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        //[JsonIgnore]
        //public Address Address { get; set; }
        //[JsonIgnore]
        public ICollection<Order> Orders { get; set; }
        //[JsonIgnore]
        public ICollection<Review> Reviews { get; set; }
    }
}
