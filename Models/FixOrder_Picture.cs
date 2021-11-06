using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSI_WebApp.Models
{
    public class FixOrder_Picture
    {
        public int FixOrderId { get; set; }
        public FixOrder FixOrder { get; set; }

        public int PictureId { get; set; }
        public Picture Picture { get; set; }
    }
}
