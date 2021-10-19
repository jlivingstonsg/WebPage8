using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LexiconProject_ComputerWebShop.Models
{
    public class ComputerOrder
    {
        public int ComputerOrderId { get; set; }
        public int Quantity { get; set; }
        public int ComputerId { get; set; }
        public int OrderId { get; set; }
        //[JsonIgnore]
        public Computer Computer { get; set; }
        //[JsonIgnore]
        public Order Order { get; set; }
    }
}
