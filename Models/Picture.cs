using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SSI_WebApp.Models
{
    public class Picture
    {
        [Key]
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }

        public List<FixOrder_Picture> FixOrder_Pictures { get; set; }
    }
}
