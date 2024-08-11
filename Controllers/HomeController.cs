using DependencyInjectionExercise.Models;
using DependencyInjectionExercise.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DependencyInjectionExercise.Controllers
{
    public class HomeController : Controller
    {
        ITransientService _productService;
        public HomeController(ITransientService productService)
        {
            _productService = productService;

        }

        public IActionResult Index()
        {
            return View(_productService.GetAll());
        }


    }
}
