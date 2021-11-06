using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
    public class RepairController : Controller
    {
        private readonly IFixOrdersService _service;
        public RepairController(IFixOrdersService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Create()
        {
            var dropdowns = await _service.GetOrderDropdownsValues();
            ViewBag.Brands = new SelectList(dropdowns.ComputerBrands, "Id", "Name");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(NewOrderVM order)
        {
            if (!ModelState.IsValid) return View(order);
            await _service.AddNewOrderAsync(order);

            var dropdowns = await _service.GetOrderDropdownsValues();
            ViewBag.Brands = new SelectList(dropdowns.ComputerBrands, "Id", "Name");

            return RedirectToAction("Orders");
        }

        public async Task<IActionResult> Orders()
        {
            var data = await _service.GetAllAsync();

            return View(data);
        }

        public async Task<IActionResult> Details(int id)
        {
            var order = await _service.GetByIdAsync(id);

            return View(order);
        }

        public IActionResult Config()
        {
            return View();
        }
    }
}
