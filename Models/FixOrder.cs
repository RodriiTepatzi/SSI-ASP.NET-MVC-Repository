using SSI_WebApp.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SSI_WebApp.Models
{
    public class FixOrder : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public string ComputerModel { get; set; }
        public string ComputerBrand { get; set; }
        public string SerialNumber { get; set; }
        public DateTime ReceptionDate { get; set; }
        public DateTime PickDate { get; set; }
        public bool Fixed { get; set; }
        public string Notes { get; set; }
        public string Price { get; set; }

        //Relationships
        public List<FixOrder_Picture> FixOrder_Pictures { get; set; }
    }
}
