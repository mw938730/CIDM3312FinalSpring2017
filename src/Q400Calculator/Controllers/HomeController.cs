using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Q400Calculator.Data;
using Q400Calculator.Models;
using System.Diagnostics;

namespace Q400Calculator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Indexx()
        {

            return View();
        }
        public async Task<IActionResult> Index()
        {

            FlightViewModel fvm = new FlightViewModel();
            fvm.RealAltitude = 0;
            fvm.RealWeight = 18000;
            fvm.Icing = "No";
            fvm.Rain = "No";
            fvm.Snow = "No";
            fvm.RunwayDirection = 0;
            fvm.WindDirection = 0;
            fvm.WindSpeed = 0;
            fvm.OutsideAirTemp = 0;
            
            fvm.FlapData = await _context.Flap5Data.ToListAsync();
            fvm.Flap10Data = await _context.Flap10Data.ToListAsync();
            fvm.Flap15Data = await _context.Flap15Data.ToListAsync();
            fvm.Landing5Data = await _context.Landing5Data.ToListAsync();
            fvm.Landing10Data = await _context.Landing10Data.ToListAsync();

            return View(fvm);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }


        public async Task<IActionResult> SaveResults(FlightViewModel fvm)
        {
            //if (ModelState.IsValid)
            //{
            //    //_context.Add(movie);  Comment for now the vm isnt in database
            //    //await _context.SaveChangesAsync();
            //    return RedirectToAction("Index");
            //}
            fvm.LandingWeight = fvm.RealWeight - ((fvm.RealDistance / 600) * 2163);
            fvm.ClimbData = await _context.ClimbData.ToListAsync();
            fvm.FlapData = await _context.Flap5Data.ToListAsync();
            fvm.Flap10Data = await _context.Flap10Data.ToListAsync();
            fvm.Flap15Data = await _context.Flap15Data.ToListAsync();
            fvm.Landing5Data = await _context.Landing5Data.ToListAsync();
            fvm.Landing10Data = await _context.Landing10Data.ToListAsync();
            fvm.Landing15Data = await _context.Landing15Data.ToListAsync();
            fvm.Landing35Data = await _context.Landing35Data.ToListAsync();

            int WeightRounded = fvm.RealWeight;
            if (WeightRounded < 19000)
            {
                WeightRounded = 18000;
                goto done;

            }
            else if (WeightRounded < 21000)
            {
                WeightRounded = 20000;
                goto done;
            }
            else if (WeightRounded < 23000)
            {
                WeightRounded = 22000;
                goto done;
            }
            else if (WeightRounded < 25000)
            {
                WeightRounded = 24000;
                goto done;
            }
            else if (WeightRounded < 27000)
            {
                WeightRounded = 26000;
                goto done;
            }
            else if (WeightRounded < 28500)
            {
                WeightRounded = 27000;
                goto done;
            }
            else
            {
                WeightRounded = 29000;
            }
        done:;
            fvm.RealWeight = WeightRounded;


            //Dig through the table to find the right Row
            for (int i = 0; i < fvm.ClimbData.Count - 1; i++)
            {
                if (fvm.ClimbData[i].Weight == fvm.RealWeight)
                {
                    fvm.SelectedWeightNumber = i; //current iteration (i) 
                                                  //is equal to the row number for the table
                    break;
                }
            }
            if (fvm.TakeoffFlaps == "5")
            {
                fvm.VClimb = fvm.ClimbData[fvm.SelectedWeightNumber].Vclmb;
                fvm.VFri = fvm.ClimbData[fvm.SelectedWeightNumber].Vfri5;
                if (fvm.OutsideAirTemp < 21)
                {
                    if (fvm.RealAltitude < 1000)
                    {
                        fvm.Vr = fvm.FlapData[fvm.SelectedWeightNumber].Cold0Vr;
                        fvm.V2 = fvm.FlapData[fvm.SelectedWeightNumber].Cold0V2;
                        goto donedone;
                    }
                    else if (fvm.RealAltitude < 3000)
                    {
                        fvm.Vr = fvm.FlapData[fvm.SelectedWeightNumber].Cold2000Vr;
                        fvm.V2 = fvm.FlapData[fvm.SelectedWeightNumber].Cold2000V2;
                        goto donedone;
                    }
                    else if (fvm.RealAltitude < 5000)
                    {
                        fvm.Vr = fvm.FlapData[fvm.SelectedWeightNumber].Cold4000Vr;
                        fvm.V2 = fvm.FlapData[fvm.SelectedWeightNumber].Cold4000V2;
                        goto donedone;
                    }
                    else if (fvm.RealAltitude < 7000)
                    {
                        fvm.Vr = fvm.FlapData[fvm.SelectedWeightNumber].Cold6000Vr;
                        fvm.V2 = fvm.FlapData[fvm.SelectedWeightNumber].Cold6000V2;
                        goto donedone;
                    }
                    else if (fvm.RealAltitude < 9000)
                    {
                        fvm.Vr = fvm.FlapData[fvm.SelectedWeightNumber].Cold8000Vr;
                        fvm.V2 = fvm.FlapData[fvm.SelectedWeightNumber].Cold8000V2;
                        goto donedone;
                    }
                    else
                    {
                        fvm.Vr = fvm.FlapData[fvm.SelectedWeightNumber].Cold10000Vr;
                        fvm.V2 = fvm.FlapData[fvm.SelectedWeightNumber].Cold10000V2;
                        goto donedone;
                    }
                }//end if cold
                else //not cold its HOT
                {
                    if (fvm.RealAltitude < 1000)
                    {
                        fvm.Vr = fvm.FlapData[fvm.SelectedWeightNumber].Hot0Vr;
                        fvm.V2 = fvm.FlapData[fvm.SelectedWeightNumber].Hot0V2;
                        goto donedone;
                    }
                    else if (fvm.RealAltitude < 3000)
                    {
                        fvm.Vr = fvm.FlapData[fvm.SelectedWeightNumber].Hot2000Vr;
                        fvm.V2 = fvm.FlapData[fvm.SelectedWeightNumber].Hot2000V2;
                        goto donedone;
                    }
                    else if (fvm.RealAltitude < 5000)
                    {
                        fvm.Vr = fvm.FlapData[fvm.SelectedWeightNumber].Hot4000Vr;
                        fvm.V2 = fvm.FlapData[fvm.SelectedWeightNumber].Hot4000V2;
                        goto donedone;
                    }
                    else if (fvm.RealAltitude < 7000)
                    {
                        fvm.Vr = fvm.FlapData[fvm.SelectedWeightNumber].Hot6000Vr;
                        fvm.V2 = fvm.FlapData[fvm.SelectedWeightNumber].Hot6000V2;
                        goto donedone;
                    }
                    else if (fvm.RealAltitude < 9000)
                    {
                        fvm.Vr = fvm.FlapData[fvm.SelectedWeightNumber].Hot8000Vr;
                        fvm.V2 = fvm.FlapData[fvm.SelectedWeightNumber].Hot8000V2;
                        goto donedone;
                    }
                    else
                    {
                        fvm.Vr = fvm.FlapData[fvm.SelectedWeightNumber].Hot10000Vr;
                        fvm.V2 = fvm.FlapData[fvm.SelectedWeightNumber].Hot10000V2;
                        goto donedone;
                    }
                }//end if cold --- end flapdata selection method

            }
            if (fvm.TakeoffFlaps == "10")
            {
                fvm.VClimb = fvm.ClimbData[fvm.SelectedWeightNumber].Vclmb;
                fvm.VFri = fvm.ClimbData[fvm.SelectedWeightNumber].Vfri10;
                if (fvm.OutsideAirTemp < 21)
                {
                    if (fvm.RealAltitude < 1000)
                    {
                        fvm.Vr = fvm.Flap10Data[fvm.SelectedWeightNumber].Cold0Vr;
                        fvm.V2 = fvm.Flap10Data[fvm.SelectedWeightNumber].Cold0V2;
                        goto donedone;
                    }
                    else if (fvm.RealAltitude < 3000)
                    {
                        fvm.Vr = fvm.Flap10Data[fvm.SelectedWeightNumber].Cold2000Vr;
                        fvm.V2 = fvm.Flap10Data[fvm.SelectedWeightNumber].Cold2000V2;
                        goto donedone;
                    }
                    else if (fvm.RealAltitude < 5000)
                    {
                        fvm.Vr = fvm.Flap10Data[fvm.SelectedWeightNumber].Cold4000Vr;
                        fvm.V2 = fvm.Flap10Data[fvm.SelectedWeightNumber].Cold4000V2;
                        goto donedone;
                    }
                    else if (fvm.RealAltitude < 7000)
                    {
                        fvm.Vr = fvm.Flap10Data[fvm.SelectedWeightNumber].Cold6000Vr;
                        fvm.V2 = fvm.Flap10Data[fvm.SelectedWeightNumber].Cold6000V2;
                        goto donedone;
                    }
                    else if (fvm.RealAltitude < 9000)
                    {
                        fvm.Vr = fvm.Flap10Data[fvm.SelectedWeightNumber].Cold8000Vr;
                        fvm.V2 = fvm.Flap10Data[fvm.SelectedWeightNumber].Cold8000V2;
                        goto donedone;
                    }
                    else
                    {
                        fvm.Vr = fvm.Flap10Data[fvm.SelectedWeightNumber].Cold10000Vr;
                        fvm.V2 = fvm.Flap10Data[fvm.SelectedWeightNumber].Cold10000V2;
                        goto donedone;
                    }
                }//end if cold
                else //not cold its HOT
                {
                    if (fvm.RealAltitude < 1000)
                    {
                        fvm.Vr = fvm.Flap10Data[fvm.SelectedWeightNumber].Hot0Vr;
                        fvm.V2 = fvm.Flap10Data[fvm.SelectedWeightNumber].Hot0V2;
                        goto donedone;
                    }
                    else if (fvm.RealAltitude < 3000)
                    {
                        fvm.Vr = fvm.Flap10Data[fvm.SelectedWeightNumber].Hot2000Vr;
                        fvm.V2 = fvm.Flap10Data[fvm.SelectedWeightNumber].Hot2000V2;
                        goto donedone;
                    }
                    else if (fvm.RealAltitude < 5000)
                    {
                        fvm.Vr = fvm.Flap10Data[fvm.SelectedWeightNumber].Hot4000Vr;
                        fvm.V2 = fvm.Flap10Data[fvm.SelectedWeightNumber].Hot4000V2;
                        goto donedone;
                    }
                    else if (fvm.RealAltitude < 7000)
                    {
                        fvm.Vr = fvm.Flap10Data[fvm.SelectedWeightNumber].Hot6000Vr;
                        fvm.V2 = fvm.Flap10Data[fvm.SelectedWeightNumber].Hot6000V2;
                        goto donedone;
                    }
                    else if (fvm.RealAltitude < 9000)
                    {
                        fvm.Vr = fvm.Flap10Data[fvm.SelectedWeightNumber].Hot8000Vr;
                        fvm.V2 = fvm.Flap10Data[fvm.SelectedWeightNumber].Hot8000V2;
                        goto donedone;
                    }
                    else
                    {
                        fvm.Vr = fvm.Flap10Data[fvm.SelectedWeightNumber].Hot10000Vr;
                        fvm.V2 = fvm.Flap10Data[fvm.SelectedWeightNumber].Hot10000V2;
                        goto donedone;
                    }
                }//end if cold --- end flapdata selection method
            }
            if (fvm.TakeoffFlaps == "15")
            {
                fvm.VClimb = fvm.ClimbData[fvm.SelectedWeightNumber].Vclmb;
                fvm.VFri = fvm.ClimbData[fvm.SelectedWeightNumber].Vfri15;
                if (fvm.OutsideAirTemp < 21)
                {
                    if (fvm.RealAltitude < 1000)
                    {
                        fvm.Vr = fvm.Flap15Data[fvm.SelectedWeightNumber].Cold0Vr;
                        fvm.V2 = fvm.Flap15Data[fvm.SelectedWeightNumber].Cold0V2;
                        goto donedone;
                    }
                    else if (fvm.RealAltitude < 3000)
                    {
                        fvm.Vr = fvm.Flap15Data[fvm.SelectedWeightNumber].Cold2000Vr;
                        fvm.V2 = fvm.Flap15Data[fvm.SelectedWeightNumber].Cold2000V2;
                        goto donedone;
                    }
                    else if (fvm.RealAltitude < 5000)
                    {
                        fvm.Vr = fvm.Flap15Data[fvm.SelectedWeightNumber].Cold4000Vr;
                        fvm.V2 = fvm.Flap15Data[fvm.SelectedWeightNumber].Cold4000V2;
                        goto donedone;
                    }
                    else if (fvm.RealAltitude < 7000)
                    {
                        fvm.Vr = fvm.Flap15Data[fvm.SelectedWeightNumber].Cold6000Vr;
                        fvm.V2 = fvm.Flap15Data[fvm.SelectedWeightNumber].Cold6000V2;
                        goto donedone;
                    }
                    else if (fvm.RealAltitude < 9000)
                    {
                        fvm.Vr = fvm.Flap15Data[fvm.SelectedWeightNumber].Cold8000Vr;
                        fvm.V2 = fvm.Flap15Data[fvm.SelectedWeightNumber].Cold8000V2;
                        goto donedone;
                    }
                    else
                    {
                        fvm.Vr = fvm.Flap15Data[fvm.SelectedWeightNumber].Cold10000Vr;
                        fvm.V2 = fvm.Flap15Data[fvm.SelectedWeightNumber].Cold10000V2;
                        goto donedone;
                    }
                }//end if cold
                else //not cold its HOT
                {
                    if (fvm.RealAltitude < 1000)
                    {
                        fvm.Vr = fvm.Flap15Data[fvm.SelectedWeightNumber].Hot0Vr;
                        fvm.V2 = fvm.Flap15Data[fvm.SelectedWeightNumber].Hot0V2;
                        goto donedone;
                    }
                    else if (fvm.RealAltitude < 3000)
                    {
                        fvm.Vr = fvm.Flap15Data[fvm.SelectedWeightNumber].Hot2000Vr;
                        fvm.V2 = fvm.Flap15Data[fvm.SelectedWeightNumber].Hot2000V2;
                        goto donedone;
                    }
                    else if (fvm.RealAltitude < 5000)
                    {
                        fvm.Vr = fvm.Flap15Data[fvm.SelectedWeightNumber].Hot4000Vr;
                        fvm.V2 = fvm.Flap15Data[fvm.SelectedWeightNumber].Hot4000V2;
                        goto donedone;
                    }
                    else if (fvm.RealAltitude < 7000)
                    {
                        fvm.Vr = fvm.Flap15Data[fvm.SelectedWeightNumber].Hot6000Vr;
                        fvm.V2 = fvm.Flap15Data[fvm.SelectedWeightNumber].Hot6000V2;
                        goto donedone;
                    }
                    else if (fvm.RealAltitude < 9000)
                    {
                        fvm.Vr = fvm.Flap15Data[fvm.SelectedWeightNumber].Hot8000Vr;
                        fvm.V2 = fvm.Flap15Data[fvm.SelectedWeightNumber].Hot8000V2;
                        goto donedone;
                    }
                    else
                    {
                        fvm.Vr = fvm.Flap15Data[fvm.SelectedWeightNumber].Hot10000Vr;
                        fvm.V2 = fvm.Flap15Data[fvm.SelectedWeightNumber].Hot10000V2;
                        goto donedone;
                    }
                }//end if cold --- end flapdata selection method

                }//end root if

        
        donedone:;//////////////////////////////////END TAKEOFF LOGIC


            int LandingWeightRounded = fvm.RealWeight;
            if (LandingWeightRounded < 19000)
            {
                LandingWeightRounded = 18000;
                goto doone;

            }
            else if (LandingWeightRounded < 21000)
            {
                LandingWeightRounded = 20000;
                goto doone;
            }
            else if (LandingWeightRounded < 23000)
            {
                LandingWeightRounded = 22000;
                goto doone;
            }
            else if (LandingWeightRounded < 25000)
            {
                LandingWeightRounded = 24000;
                goto doone;
            }
            else if (LandingWeightRounded < 27000)
            {
                LandingWeightRounded = 26000;
                goto doone;
            }
            else if (LandingWeightRounded < 28500)
            {
                LandingWeightRounded = 27000;
                goto doone;
            }
            else
            {
                LandingWeightRounded = 29000;
            }
        doone:;

            fvm.RealWeight = LandingWeightRounded;

            for (int i = 0; i < fvm.ClimbData.Count - 1; i++)
            {
                if (fvm.ClimbData[i].Weight == fvm.RealWeight)
                {
                    fvm.SelectedWeightNumber = i; //current iteration (i) 
                                                  //is equal to the row number for the table
                    break;
                }
            }

            if (fvm.LandingFlaps == "5")
            {
                fvm.Vapp = fvm.Landing5Data[fvm.SelectedWeightNumber].Vapp;
                fvm.Vref = fvm.Landing5Data[fvm.SelectedWeightNumber].Vref;
                fvm.Vga = fvm.Landing5Data[fvm.SelectedWeightNumber].Vga;


            }//end Landing Flap 10 if
            if (fvm.LandingFlaps == "10")
            {
                fvm.Vapp = fvm.Landing10Data[fvm.SelectedWeightNumber].Vapp;
                fvm.Vref = fvm.Landing10Data[fvm.SelectedWeightNumber].Vref;
                fvm.Vga = fvm.Landing10Data[fvm.SelectedWeightNumber].Vga;


            }//end Landing Flap 10 if
            if (fvm.LandingFlaps == "15")
            {
                fvm.Vapp = fvm.Landing15Data[fvm.SelectedWeightNumber].Vapp;
                fvm.Vref = fvm.Landing15Data[fvm.SelectedWeightNumber].Vref;
                fvm.Vga = fvm.Landing15Data[fvm.SelectedWeightNumber].Vga;



            }//end Landing Flap 15 if
            if (fvm.LandingFlaps == "35")
            {
                fvm.Vapp = fvm.Landing35Data[fvm.SelectedWeightNumber].Vapp;
                fvm.Vref = fvm.Landing35Data[fvm.SelectedWeightNumber].Vref;
                fvm.Vga = fvm.Landing35Data[fvm.SelectedWeightNumber].Vga;


            }//end Landing Flap 35 if

            //assume v1 is = vr (which we just found in the above elseif monster)
            fvm.V1 = fvm.Vr;
            Random rand = new Random();
            if (rand.Next(1, 10) == 1) //trying to do the 10 % for tailwind
            {
                fvm.IsTailwind = true;
            }

            //Wind time
            if (fvm.WindDirection - fvm.RunwayDirection > 0)
            { fvm.WindComponent = fvm.WindDirection - fvm.RunwayDirection; }
            else { fvm.WindComponent = fvm.WindSpeed * (Math.Cos(359 + (fvm.WindDirection - fvm.RunwayDirection)));
                //below code rounding is automatically done by Convert.ToInt32()
                //fvm.WindComponent = Math.Round(fvm.WindComponent, 0, MidpointRounding.AwayFromZero);
            }
            if (fvm.Rain == "Yes")
                if (fvm.IsTailwind)
                {//Reduce V1 by 8 kts + 0.3 ktsfor every knot of tailwind
                    //I let the convert class take care of the rounding after the doubles are multiplied
                    fvm.V1 = (fvm.V1 - 8 + Convert.ToInt32(.3 * fvm.WindComponent));
                }
                else
                {
                   // Reduce V1 by 8 kts - 0.1 kts for every knot of headwind
                    fvm.V1 = (fvm.V1 - 8 - Convert.ToInt32(.1 * fvm.WindComponent));
                }

            if (fvm.Vr > fvm.V2)
            {
                fvm.V2 = fvm.Vr;
            }
            //If the OAT is 10C or below in rain, assume icing
            //precip type correction
            if (fvm.Rain == "Yes")
            {
                if (fvm.OutsideAirTemp < 11)
                {
                    fvm.Icing = "Yes";
                    fvm.Rain = "No";
                }
                else
                {
                    fvm.Icing = "No";
                    fvm.Snow = "No";
                }
                //If OAT is 0C, it is snowing, which causes no icing
                if (fvm.OutsideAirTemp < 1)
                {
                    fvm.Icing = "No";
                    fvm.Rain = "No";
                    fvm.Snow = "Yes";
                }
            }//end rain if for precip correction


            return View(fvm);
        }
    }
}
