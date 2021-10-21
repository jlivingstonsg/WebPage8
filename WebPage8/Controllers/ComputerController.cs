using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPage8.Data;
using WebPage8.Services;
using WebPage8.ViewModels;

namespace WebPage8.Controllers
{
    public class ComputerController : Controller
    {
        private readonly IComputerService _computerService;
        public ComputerController(IComputerService computerService)
        {
            _computerService = computerService;
        }
        public IActionResult Index(ComputerViewModel computerViewModel)
        {
            if(!string.IsNullOrEmpty(computerViewModel.Search))
            {
                return View(_computerService.FindBy(computerViewModel));
            }
            else
            {
                return View(_computerService.All());
            }            
        }
        public IActionResult Details(int id)
        {
            return View("Details",_computerService.FindBy(id));
        }
    }
}
