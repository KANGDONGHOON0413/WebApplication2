using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Controllers
{
    public class NewpageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Newpage()
        {
            return View();
        }

        public IActionResult Newpage2()
        {
            return View();
        }
    }
}
