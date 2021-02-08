using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TP_Vues_Controller.Models;
using TP_Vues_Controller.ViewModel;

namespace TP_Vues_Controller.Controllers
{
    public class HomeController : Controller
    {
       
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [Route("")]
        [Route("home")]
        [Route("home/index")]
       
       
        public IActionResult Index()
        {
            ViewData["Title"] = "Accueil";
            
            return View();
        }
        [HttpGet]
        [Route("home/Privacy")]
        public IActionResult Privacy()
        {
            return View();
        }
       /* [HttpGet]
        [Route("home/Clients")]
        public IActionResult Client()
        {
            return View();
        }*/

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
