using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LexiconProject_ComputerWebShop.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderPlaced { get; set; }
        public DateTime OrderFullfilled { get; set; }
        public int CustomerId { get; set; }        
        //[JsonIgnore]
        public Customer Customer { get; set; }
        //[JsonIgnore]
        public ICollection<ComputerOrder> ComputerOrders { get; set; }        
        
    }
}
