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
        private readonly IOrdersConfigService _ordersService;
        public RepairController(IFixOrdersService service, IOrdersConfigService ordersService)
        {
            _service = service;
            _ordersService = ordersService;
        }

        public async Task<IActionResult> Create()
        {
            var dropdowns = await _service.GetOrderDropdownsValues();
            ViewBag.Brands = new SelectList(dropdowns.ComputerBrands, "Id", "Name");
            ViewData["ViewName"] = "Computo-orders";
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(NewOrderVM order)
        {
            var dropdowns = await _service.GetOrderDropdownsValues();
            ViewBag.Brands = new SelectList(dropdowns.ComputerBrands, "Id", "Name");

            if (!ModelState.IsValid) return View(order);
            await _service.AddNewOrderAsync(order);

            return RedirectToAction("Orders");
        }

        public async Task<IActionResult> Orders()
        {
            var data = await _service.GetAllAsync();
            ViewData["ViewName"] = "Computo-orders";

            return View(data);
        }

        public async Task<IActionResult> Details(int id)
        {
            var order = await _service.GetByIdAsync(id);

            ViewData["ViewName"] = "Computo-orders";
            return View(order);
        }

        public async Task<IActionResult> Config()
        {
            var dropwdowns = await _service.GetOrderDropdownsValues();

            ViewBag.Brands = new SelectList(dropwdowns.ComputerBrands, "Id", "Name");
            ViewData["ViewName"] = "Computo-config";

            var config = await _ordersService.GetAllAsync();

            if (config.Count() > 0) 
            {
                var data = config.ToList().ElementAt(0);
                return View(data);
            }

            return View();
            
        }

        [HttpPost]
        public async Task<IActionResult> CreateBrand(ComputerBrand brand)
        {
            await _ordersService.CreateBrandAsync(brand);

            return RedirectToAction("Config");
        }

        public async Task<IActionResult> DeleteBrand(DeleteBrandVM delete)
        {
            var data = await _ordersService.GetBrandByIdAsync(delete.Id);

            if (data == null) return RedirectToAction("Config");

            await _ordersService.DeleteBrandByIdAsync(delete.Id);

            return RedirectToAction("Config");
        }
    }
}
