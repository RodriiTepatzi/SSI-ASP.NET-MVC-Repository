using SSI_WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSI_WebApp.Data.ViewModels
{
    public class OrderDropdownsVM
    {
        public OrderDropdownsVM()
        {
            ComputerBrands = new List<ComputerBrand>();
        }

        public List<ComputerBrand> ComputerBrands { get; set; }
    }
}
