using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPage8.Services;
using WebPage8.ViewModels;

namespace WebPage8.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public IActionResult Index(CategoryViewModel categoryViewModel)
        {
            if (!string.IsNullOrEmpty(categoryViewModel.Search))
            {
                return View(_categoryService.FindBy(categoryViewModel));
            }
            else
            {
                return View(_categoryService.All());
            }          
        }
    }
}
