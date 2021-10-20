﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebPage8.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public ICollection<Computer> Computers { get; set; }
    }
}