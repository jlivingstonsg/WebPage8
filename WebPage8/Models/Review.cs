using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LexiconProject_ComputerWebShop.Models
{
    public class Review
    {
        public int ReviewId { get; set; }  
        public string Text { get; set; }
        public string Rating { get; set; }
        //public Computer ComputerId { get; set; }
        //[JsonIgnore]
        [ForeignKey("ComputerId")]
        public Computer? Computer { get; set; }
        //public Customer CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public Customer? Customer { get; set; }
        //[JsonIgnore]
        
        
    }
}
