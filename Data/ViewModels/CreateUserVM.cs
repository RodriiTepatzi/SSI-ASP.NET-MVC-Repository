using Microsoft.AspNetCore.Identity;
using SSI_WebApp.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SSI_WebApp.Models
{
    public class CreateUserVM : IdentityUser
    {
        [Display(Name = "Nombre completo")]
        public string FullName { get; set; }

        [Display(Name = "Calle")]
        public string StreetName { get; set; }

        [Display(Name = "Ciudad")]
        public string CityName { get; set; }

        [Display(Name = "Estado")]
        public string StateName { get; set; }

        [Display(Name = "Código Postal")]
        public string ZipCode { get; set; }

        [Required (ErrorMessage = "Contraseña.")]
        public string Password { get; set; }

        [Display(Name = "Imagen")]
        public string ProfilePicture { get; set; }
    }
}
