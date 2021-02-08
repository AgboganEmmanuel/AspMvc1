using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TP_Vues_Controller.Controllers
{
    public class VoituresController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
