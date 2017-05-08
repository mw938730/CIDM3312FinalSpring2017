using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace Q400Calculator.Models
{
    public class Landing5Data
    {
        public int Id { get; set; }

        public int Weight { get; set; }

        [Display(Name = "V app Flaps 5")]
        public int Vapp { get; set; }

        [Display(Name = "V ref Flaps 5")]
        public int Vref { get; set; }

        [Display(Name = "V ga Flaps 5")]
        public int Vga { get; set; }
        
    }
}
