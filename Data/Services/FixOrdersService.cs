using Microsoft.EntityFrameworkCore;
using SSI_WebApp.Data.Base;
using SSI_WebApp.Data.ViewModels;
using SSI_WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSI_WebApp.Data.Services
{
    public class FixOrdersService : EntityBaseRepository<FixOrder>, IFixOrdersService
    {
        private readonly AppDbContext _context;
        public FixOrdersService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task AddNewOrderAsync(NewOrderVM newOrderVM)
        {
            var fixOrder = new FixOrder()
            {
                ComputerModel = newOrderVM.ComputerModel,
                ComputerBrand = newOrderVM.ComputerBrand,
                SerialNumber = newOrderVM.SerialNumber,
                ReceptionDate = newOrderVM.ReceptionDate,
                Notes = newOrderVM.Notes,
                Price = newOrderVM.Price
            };

            await _context.FixOrders.AddAsync(fixOrder);
            await _context.SaveChangesAsync();
        }

        public Task<FixOrder> GetOrderByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(FixOrder fixOrder)
        {
            throw new NotImplementedException();
        }

        public async Task<OrderDropdownsVM> GetOrderDropdownsValues()
        {
            var response = new OrderDropdownsVM()
            {
                ComputerBrands = await _context.ComputerBrands.OrderBy(n => n.Name).ToListAsync(),
            };

            return response;
        }
    }
}
