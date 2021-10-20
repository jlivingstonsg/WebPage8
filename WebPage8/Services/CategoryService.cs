using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPage8.Data;
using WebPage8.Models;
using WebPage8.ViewModels;

namespace WebPage8.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepo _categoryRepo;
        public CategoryService(ICategoryRepo categoryRepo)
        {
            _categoryRepo = categoryRepo;
        }
        public Category Add(CreateCategoryViewModel person)
        {
            throw new NotImplementedException();
        }

        public CategoryViewModel All()
        {
            throw new NotImplementedException(); ;
        }

        public Category Edit(int id, Category person)
        {
            throw new NotImplementedException();
        }

        public CategoryViewModel FindBy(CategoryViewModel search)
        {
            throw new NotImplementedException();
        }

        public Category FindBy(int id)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
