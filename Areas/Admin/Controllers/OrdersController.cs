using Microsoft.AspNetCore.Mvc;
using SSI_WebApp.Data.Services;
using SSI_WebApp.Data.ViewModels;
using SSI_WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSI_WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OrdersController : Controller
    {
        private readonly IFixOrdersService _service;
        public OrdersController(IFixOrdersService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            ViewData["ViewName"] = "Orders";
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(NewOrderVM newOrderVM)
        {
            if (!ModelState.IsValid) return View(newOrderVM);

            await _service.AddNewOrderAsync(newOrderVM);

            return View();
        }
    }
}
