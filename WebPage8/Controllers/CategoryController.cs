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
        private readonly IComputerService _computerService;
        public CategoryController(ICategoryService categoryService, IComputerService computerService)
        {
            _categoryService = categoryService;
            _computerService = computerService;
        }
        public IActionResult Index(CategoryViewModel categoryViewModel)
        {
            if (!string.IsNullOrEmpty(categoryViewModel.Search))
            {
                return View("ViewItems", _categoryService.FindBy(categoryViewModel));
            }
            else
            {
                return View(_categoryService.All());
            }          
        }

        public IActionResult Details(ComputerViewModel category)
        {
            return View("Details", _computerService.FindBy(category));
        }
    }
}
