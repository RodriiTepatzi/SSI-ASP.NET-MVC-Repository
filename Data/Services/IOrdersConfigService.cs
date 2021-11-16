using SSI_WebApp.Data.Base;
using SSI_WebApp.Data.ViewModels;
using SSI_WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSI_WebApp.Data.Services
{
    public interface IOrdersConfigService : IEntityBaseRepository<RepairOrdersConfig>
    {
        Task CreateBrandAsync(ComputerBrand brand);
        Task<ComputerBrand> GetBrandByIdAsync(int id);
        Task DeleteBrandByIdAsync(int id);
    }
}
