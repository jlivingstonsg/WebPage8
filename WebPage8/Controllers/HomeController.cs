using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebPage8.Services;
using WebPage8.ViewModels;

namespace WebPage8.Controllers
{
    public class HomeController : Controller
    {

        private readonly ICategoryService _categoryService;
        public HomeController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public IActionResult Index(CategoryViewModel categoryViewModel)
        {
            if (!string.IsNullOrEmpty(categoryViewModel.Search))
            {
                return View("BrandItems", _categoryService.FindBy(categoryViewModel));
            }
            else
            {
                return View(_categoryService.All());
            }
        }
    }
}
