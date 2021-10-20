using WebPage8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebPage8.Data
{
    interface ICategoryRepo
    {
        public List<Category> Read();
    }
}
