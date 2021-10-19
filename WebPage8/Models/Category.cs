using System.Collections.Generic;

namespace LexiconProject_ComputerWebShop.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public ICollection<Computer> Computers { get; set; }
    }
}