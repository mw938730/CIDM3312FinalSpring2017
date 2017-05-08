using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace Q400Calculator.Models
{
    public class FlightViewModel
    {
        public int Id { get; set; }
        public string PilotName { get; set; }
        public int SelectedWeightNumber { get; set; }
        public List<ClimbData> ClimbData { get; set; }
        public List<FlapData> FlapData { get; set; }
        public List<Flap10Data> Flap10Data { get; set; }
        public List<Flap15Data> Flap15Data { get; set; }
        public List<Landing5Data> Landing5Data { get; set; }

        public List<Landing10Data> Landing10Data { get; set; }
        public List<Landing15Data> Landing15Data { get; set; }
        public List<Landing35Data> Landing35Data { get; set; }

        [Range(18000, 29000)]
        [Required]
        public int RealWeight { get; set; }

        public int LandingWeight { get; set; }

        [Range(0,10000)]
        [Required]
        public int RealAltitude { get; set; }

        [Range(0,1114)]
        [Required]
        public int RealDistance { get; set; }
        public string TakeoffFlaps { get; set; }
        public string LandingFlaps { get; set; }

        [Range(0, 359)]
        [Required]
        public int RunwayDirection { get; set; }

        [Range(-30,50)]
        [Required]
        public int OutsideAirTemp { get; set; }
        public string Icing { get; set; }
        public string Rain { get; set; }
        public string Snow { get; set; }

        [Range (0,359)]
        public int WindDirection { get; set; }

        [Range(0,50)]
        [Required]
        public double WindSpeed { get; set; }

        public int VClimb { get; set; }
        public int VFri { get; set; }
        public int Vr { get; set;}
        public int V2 { get; set; }
        public int V1 { get; set; }
        public int Vapp { get; set; }
        public int Vref { get; set; }
        public int Vga { get; set; }

        public bool IsTailwind { get; set; }

        public double WindComponent { get; set; }
        




    }
}
