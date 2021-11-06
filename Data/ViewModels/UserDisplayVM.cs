using SSI_WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSI_WebApp.Data.ViewModels
{
    public class UserDisplayVM
    {
        public ApplicationUser ApplicationUser { get; }
        public IEnumerable<ApplicationUser> Users { get; set; }
        public IEnumerable<ApplicationUser> Admins { get; set; }
    }
}
