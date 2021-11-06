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

        [Display(Name = "Modelo")]
        public string ComputerModel { get; set; }

        [Display(Name = "Marca")]
        public string ComputerBrand { get; set; }

        [Display(Name = "Número de serie")]
        public string SerialNumber { get; set; }

        [Display(Name = "Entrada")]
        public DateTime ReceptionDate { get; set; }

        [Display(Name = "Salida")]
        public DateTime PickDate { get; set; }

        [Display(Name = "¿Reparado?")]
        public bool Fixed { get; set; }

        [Display(Name = "Notas")]
        public string Notes { get; set; }

        [Display(Name = "Precio")]
        public string Price { get; set; }

        //Relationships
        public List<FixOrder_Picture> FixOrder_Pictures { get; set; }
    }
}
