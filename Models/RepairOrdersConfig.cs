using SSI_WebApp.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SSI_WebApp.Models
{
    public class RepairOrdersConfig : IEntityBase
    {
        public int Id { get; set; }
        //Ordenes
        [Display(Name = "Notificar por email")]
        public Boolean NotifyClientEmail { get; set; }
    }
}
