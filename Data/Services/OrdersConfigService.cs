using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using SSI_WebApp.Data.Base;
using SSI_WebApp.Data.ViewModels;
using SSI_WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSI_WebApp.Data.Services
{
    public class OrdersConfigService : EntityBaseRepository<RepairOrdersConfig>, IOrdersConfigService
    {
        private readonly AppDbContext _context;

        public OrdersConfigService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task CreateBrandAsync(ComputerBrand brand)
        {
            await _context.ComputerBrands.AddAsync(brand);
            await _context.SaveChangesAsync();
        }

        public async Task<ComputerBrand> GetBrandByIdAsync(int id) => await _context.ComputerBrands.FirstOrDefaultAsync(n => n.Id == id);
        
        

        public async Task DeleteBrandByIdAsync(int id)
        {
            var entity = await _context.ComputerBrands.FirstOrDefaultAsync(n => n.Id == id);
            EntityEntry entityEntry = _context.Entry<ComputerBrand>(entity);
            entityEntry.State = EntityState.Deleted;

            await _context.SaveChangesAsync();
        }
    }
}
