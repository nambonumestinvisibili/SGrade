using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGrade.Controllers
{
    public class MajorsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
