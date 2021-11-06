using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSI_WebApp.Areas.Admin.Controllers
{
    public class Repair : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Orders()
        {
            return View();
        }
    }
}
