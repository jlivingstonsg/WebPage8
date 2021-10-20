using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPage8.Data;
using WebPage8.Services;

namespace WebPage8.Controllers
{
    public class ComputerController : Controller
    {
        private readonly IComputerService _computerService;
        public ComputerController(IComputerService computerService)
        {
            _computerService = computerService;
        }
        public IActionResult Index()
        {
            return View(_computerService.All());
        }
    }
}
