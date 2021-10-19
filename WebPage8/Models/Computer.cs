using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LexiconProject_ComputerWebShop.Models
{
    public class Computer
    {
        public int ComputerId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Processor { get; set; }
        public string RAM { get; set; }
        public string HardDisk { get; set; }
        public string SystemType { get; set; }
        public string PenAndTouch { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
        //[JsonIgnore]
        public Category Category { get; set; }
        //[JsonIgnore]
        public ICollection<Review> Reviews { get; set; }
        //[JsonIgnore]
        public ICollection<ComputerOrder> ComputerOrders { get; set; }


    }
}
