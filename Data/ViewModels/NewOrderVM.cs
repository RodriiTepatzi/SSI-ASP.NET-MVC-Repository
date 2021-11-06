using SSI_WebApp.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SSI_WebApp.Data.ViewModels
{
    public class NewOrderVM
    {
        public int Id { get; set; }

        [Display(Name = Messages.ES.ComputerModel)]
        [Required(ErrorMessage = Messages.ES.ComputerModelEmpty)]
        public string ComputerModel { get; set; }

        [Display(Name = Messages.ES.ComputerBrand)]
        [Required(ErrorMessage = Messages.ES.ComputerBrandEmpty)]
        public string ComputerBrand { get; set; }

        [Display(Name = Messages.ES.SerialNumber)]
        [Required(ErrorMessage = Messages.ES.SerialNumberEmpty)]
        public string SerialNumber { get; set; }

        [Display(Name = Messages.ES.ReceptionDate)]
        [Required(ErrorMessage = Messages.ES.ReceptionDateEmpty)]
        public DateTime ReceptionDate { get; set; }

        [Display(Name = Messages.ES.Notes)]
        public string Notes { get; set; }

        [Display(Name = Messages.ES.Price)]
        public string Price { get; set; }
    }
}
