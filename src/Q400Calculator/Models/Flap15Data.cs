using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace Q400Calculator.Models
{
    public class Flap15Data
    {
        public int Id { get; set; }

        public int Weight { get; set; }

        [Display(Name = "5 Vr AT OR BELOW 20 @ 0alt")]
        public int Cold0Vr { get; set; }

        [Display(Name = "5 V2 AT OR BELOW 20 @ 0alt")]
        public int Cold0V2 { get; set; }

        [Display(Name = "5 Vr AT OR BELOW 20 @ 2000alt")]
        public int Cold2000Vr { get; set; }

        [Display(Name = "5 V2 AT OR BELOW 20 @ 2000alt")]
        public int Cold2000V2 { get; set; }

        [Display(Name = "5 Vr AT OR BELOW 20 @ 4000alt")]
        public int Cold4000Vr { get; set; }

        [Display(Name = "5 V2 AT OR BELOW 20 @ 4000alt")]
        public int Cold4000V2 { get; set; }

        [Display(Name = "5 Vr AT OR BELOW 20 @ 6000alt")]
        public int Cold6000Vr { get; set; }

        [Display(Name = "5 V2 AT OR BELOW 20 @ 6000alt")]
        public int Cold6000V2 { get; set; }

        [Display(Name = "5 Vr AT OR BELOW 20 @ 8000alt")]
        public int Cold8000Vr { get; set; }

        [Display(Name = "5 V2 AT OR BELOW 20 @ 8000alt")]
        public int Cold8000V2 { get; set; }

        [Display(Name = "5 Vr AT OR BELOW 20 @ 10000alt")]
        public int Cold10000Vr { get; set; }

        [Display(Name = "5 V2 AT OR BELOW 20 @ 10000alt")]
        public int Cold10000V2 { get; set; }

        [Display(Name = "5 Vr Above 20 @ 0alt")]
        public int Hot0Vr { get; set; }

        [Display(Name = "5 V2 Above 20 @ 0alt")]
        public int Hot0V2 { get; set; }

        [Display(Name = "5 Vr Above 20 @ 2000alt")]
        public int Hot2000Vr { get; set; }

        [Display(Name = "5 V2 Above 20 @ 2000alt")]
        public int Hot2000V2 { get; set; }

        [Display(Name = "5 Vr Above 20 @ 4000alt")]
        public int Hot4000Vr { get; set; }

        [Display(Name = "5 V2 Above 20 @ 4000alt")]
        public int Hot4000V2 { get; set; }

        [Display(Name = "5 Vr Above 20 @ 6000alt")]
        public int Hot6000Vr { get; set; }

        [Display(Name = "5 V2 Above 20 @ 6000alt")]
        public int Hot6000V2 { get; set; }

        [Display(Name = "5 Vr Above 20 @ 8000alt")]
        public int Hot8000Vr { get; set; }

        [Display(Name = "5 V2 Above 20 @ 8000alt")]
        public int Hot8000V2 { get; set; }

        [Display(Name = "5 Vr Above 20 @ 10000alt")]
        public int Hot10000Vr { get; set; }

        [Display(Name = "5 V2 Above 20 @ 10000alt")]
        public int Hot10000V2 { get; set; }

    }
}