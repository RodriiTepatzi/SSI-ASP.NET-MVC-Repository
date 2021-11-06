using SSI_WebApp.Data.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSI_WebApp.Models
{
    public class ComputerBrand : IEntityBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
    }
}
