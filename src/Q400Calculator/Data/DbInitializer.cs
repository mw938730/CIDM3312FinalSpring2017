using Q400Calculator.Models;
using System;
using System.Linq;

namespace Q400Calculator.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.ClimbData.Any())
            {

            }

            var climbtable = new ClimbData[]
            {
                new ClimbData { Weight = 18000, Vfri5 = 116, Vfri10 = 110, Vfri15 = 107, Vclmb = 130 },
                new ClimbData { Weight = 20000, Vfri5 = 120, Vfri10 = 112, Vfri15 = 109, Vclmb = 131 },
                new ClimbData { Weight = 22000, Vfri5 = 126, Vfri10 = 118, Vfri15 = 115, Vclmb = 137 },
                new ClimbData { Weight = 24000, Vfri5 = 132, Vfri10 = 123, Vfri15 = 120, Vclmb = 143 },
                new ClimbData { Weight = 26000, Vfri5 = 137, Vfri10 = 128, Vfri15 = 125, Vclmb = 148 },
                new ClimbData { Weight = 28000, Vfri5 = 142, Vfri10 = 134, Vfri15 = 130, Vclmb = 154 },
                new ClimbData { Weight = 29000, Vfri5 = 146, Vfri10 = 137, Vfri15 = 133, Vclmb = 158 },

            };
            foreach (ClimbData cd in climbtable)
            {
                context.ClimbData.Add(cd);
            }

            context.SaveChanges();
            return;
        }

        public static void InitializeLand5(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Landing5Data.Any())
            {

            }

            var flap5landingtable = new Landing5Data[]
            {
                new Landing5Data { Weight = 18000, Vapp = 115, Vref = 109, Vga = 109},
                new Landing5Data { Weight = 20000, Vapp = 120, Vref = 110, Vga = 110},
                new Landing5Data { Weight = 22000, Vapp = 126, Vref = 110, Vga = 110},
                new Landing5Data { Weight = 24000, Vapp = 131, Vref = 120, Vga = 120},
                new Landing5Data { Weight = 26000, Vapp = 137, Vref = 125, Vga = 125},
                new Landing5Data { Weight = 28000, Vapp = 142, Vref = 130, Vga = 130},
                new Landing5Data { Weight = 29000, Vapp = 146, Vref = 134, Vga = 134},

            };
            foreach (Landing5Data cd in flap5landingtable)
            {
                context.Landing5Data.Add(cd);
            }

            context.SaveChanges();
            return;
        }//end initialize flap5landing

        public static void InitializeLand10(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Landing10Data.Any())
            {

            }

            var flap10landingtable = new Landing10Data[]
            {
                new Landing10Data { Weight = 18000, Vapp = 109, Vref = 108, Vga = 108},
                new Landing10Data { Weight = 20000, Vapp = 112, Vref = 112, Vga = 108},
                new Landing10Data { Weight = 22000, Vapp = 117, Vref = 117, Vga = 108},
                new Landing10Data { Weight = 24000, Vapp = 122, Vref = 122, Vga = 112},
                new Landing10Data { Weight = 26000, Vapp = 127, Vref = 127, Vga = 117},
                new Landing10Data { Weight = 28000, Vapp = 132, Vref = 132, Vga = 122},
                new Landing10Data { Weight = 29000, Vapp = 136, Vref = 136, Vga = 135},
            };
            foreach (Landing10Data cd in flap10landingtable)
            {
                context.Landing10Data.Add(cd);
            }

            context.SaveChanges();
            return;
        }//end initialize flap10landing

        public static void InitializeLand15(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Landing15Data.Any())
            {

            }

            var flap15landingtable = new Landing15Data[]
            {
                new Landing15Data { Weight = 18000, Vapp = 106, Vref = 105, Vga = 105},
                new Landing15Data { Weight = 20000, Vapp = 106, Vref = 106, Vga = 105},
                new Landing15Data { Weight = 22000, Vapp = 112, Vref = 112, Vga = 105},
                new Landing15Data { Weight = 24000, Vapp = 117, Vref = 117, Vga = 107},
                new Landing15Data { Weight = 26000, Vapp = 122, Vref = 121, Vga = 111},
                new Landing15Data { Weight = 28000, Vapp = 126, Vref = 126, Vga = 116},
                new Landing15Data { Weight = 29000, Vapp = 129, Vref = 129, Vga = 119},
            };
            foreach (Landing15Data cd in flap15landingtable)
            {
                context.Landing15Data.Add(cd);
            }

            context.SaveChanges();
            return;
        }//end initialize flap15landing

        public static void InitializeLand35(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Landing35Data.Any())
            {

            }

            var flap35landingtable = new Landing35Data[]
            {
                new Landing35Data { Weight = 18000, Vapp = 101, Vref = 101, Vga = 101},
                new Landing35Data { Weight = 20000, Vapp = 102, Vref = 102, Vga = 102},
                new Landing35Data { Weight = 22000, Vapp = 107, Vref = 107, Vga = 107},
                new Landing35Data { Weight = 24000, Vapp = 112, Vref = 112, Vga = 112},
                new Landing35Data { Weight = 26000, Vapp = 116, Vref = 116, Vga = 116},
                new Landing35Data { Weight = 28000, Vapp = 120, Vref = 120, Vga = 120},
                new Landing35Data { Weight = 29000, Vapp = 123, Vref = 123, Vga = 123},
            };
            foreach (Landing35Data cd in flap35landingtable)
            {
                context.Landing35Data.Add(cd);
            }

            context.SaveChanges();
            return;
        }//end initialize flap35landing

        public static void InitializeFlap5(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Flap5Data.Any())
            {
                // DB has been seeded with flap 5
                return;
            }
            else
            {

                var Flap5Takeofftable = new FlapData[]
{
                new FlapData { Weight = 18000, Cold0Vr = 102, Cold0V2 = 116, Cold2000Vr = 102,
                                Cold2000V2 = 115, Cold4000Vr = 102, Cold4000V2 = 114, Cold6000Vr = 102, Cold6000V2 = 113,
                                Cold8000Vr = 102, Cold8000V2 = 112, Cold10000Vr = 103, Cold10000V2 = 111, Hot0Vr = 102,
                                Hot0V2 = 114, Hot2000Vr = 102, Hot2000V2 = 113, Hot4000Vr = 102, Hot4000V2 = 112, Hot6000Vr = 103,
                                Hot6000V2 = 111, Hot8000Vr = 103, Hot8000V2 = 110, Hot10000Vr = 105, Hot10000V2 = 109},
                new FlapData { Weight = 20000, Cold0Vr = 105, Cold0V2 = 115, Cold2000Vr = 106,
                                Cold2000V2 = 114, Cold4000Vr = 107, Cold4000V2 = 113, Cold6000Vr = 107, Cold6000V2 = 112,
                                Cold8000Vr = 108, Cold8000V2 = 112, Cold10000Vr = 110, Cold10000V2 = 111, Hot0Vr = 107,
                                Hot0V2 = 113, Hot2000Vr = 108, Hot2000V2 = 112, Hot4000Vr = 108, Hot4000V2 = 112, Hot6000Vr = 110,
                                Hot6000V2 = 111, Hot8000Vr = 110, Hot8000V2 = 111, Hot10000Vr = 112, Hot10000V2 = 111},
                new FlapData { Weight = 22000, Cold0Vr = 112, Cold0V2 = 117, Cold2000Vr = 113,
                                Cold2000V2 = 117, Cold4000Vr = 113, Cold4000V2 = 117, Cold6000Vr = 114, Cold6000V2 = 117,
                                Cold8000Vr = 115, Cold8000V2 = 117, Cold10000Vr = 116, Cold10000V2 = 117, Hot0Vr = 113,
                                Hot0V2 = 117, Hot2000Vr = 114, Hot2000V2 = 117, Hot4000Vr = 115, Hot4000V2 = 117, Hot6000Vr = 116,
                                Hot6000V2 = 117, Hot8000Vr = 117, Hot8000V2 = 117, Hot10000Vr = 118, Hot10000V2 = 117},
                new FlapData { Weight = 24000, Cold0Vr = 118, Cold0V2 = 122, Cold2000Vr = 119,
                                Cold2000V2 = 122, Cold4000Vr = 120, Cold4000V2 = 122, Cold6000Vr = 120, Cold6000V2 = 122,
                                Cold8000Vr = 121, Cold8000V2 = 122, Cold10000Vr = 122, Cold10000V2 = 122, Hot0Vr = 120,
                                Hot0V2 = 122, Hot2000Vr = 120, Hot2000V2 = 122, Hot4000Vr = 121, Hot4000V2 = 122, Hot6000Vr = 122,
                                Hot6000V2 = 122, Hot8000Vr = 123, Hot8000V2 = 122, Hot10000Vr = 124, Hot10000V2 = 122},
                new FlapData { Weight = 26000, Cold0Vr = 124, Cold0V2 = 127, Cold2000Vr = 125,
                                Cold2000V2 = 127, Cold4000Vr = 126, Cold4000V2 = 127, Cold6000Vr = 126, Cold6000V2 = 127,
                                Cold8000Vr = 127, Cold8000V2 = 127, Cold10000Vr = 128, Cold10000V2 = 127, Hot0Vr = 126,
                                Hot0V2 = 127, Hot2000Vr = 126, Hot2000V2 = 127, Hot4000Vr = 127, Hot4000V2 = 127, Hot6000Vr = 128,
                                Hot6000V2 = 127, Hot8000Vr = 129, Hot8000V2 = 127, Hot10000Vr = 130, Hot10000V2 = 127},
                new FlapData { Weight = 28000, Cold0Vr = 130, Cold0V2 = 132, Cold2000Vr = 131,
                                Cold2000V2 = 132, Cold4000Vr = 131, Cold4000V2 = 132, Cold6000Vr = 132, Cold6000V2 = 132,
                                Cold8000Vr = 133, Cold8000V2 = 132, Cold10000Vr = 134, Cold10000V2 = 132, Hot0Vr = 131,
                                Hot0V2 = 132, Hot2000Vr = 132, Hot2000V2 = 132, Hot4000Vr = 133, Hot4000V2 = 132, Hot6000Vr = 134,
                                Hot6000V2 = 132, Hot8000Vr = 135, Hot8000V2 = 132, Hot10000Vr = 136, Hot10000V2 = 132},
                new FlapData { Weight = 29000, Cold0Vr = 133, Cold0V2 = 135, Cold2000Vr = 134,
                                Cold2000V2 = 135, Cold4000Vr = 135, Cold4000V2 = 135, Cold6000Vr = 136, Cold6000V2 = 135,
                                Cold8000Vr = 137, Cold8000V2 = 135, Cold10000Vr = 138, Cold10000V2 = 135, Hot0Vr = 135,
                                Hot0V2 = 135, Hot2000Vr = 136, Hot2000V2 = 135, Hot4000Vr = 137, Hot4000V2 = 135, Hot6000Vr = 138,
                                Hot6000V2 = 135, Hot8000Vr = 138, Hot8000V2 = 135, Hot10000Vr = 140, Hot10000V2 = 135},
};
                foreach (FlapData fd in Flap5Takeofftable)
                {
                    context.Flap5Data.Add(fd);
                }
                context.SaveChanges();
                return;

            };// end flap5takeoff else 
        }//end flap5

        public static void InitializeFlap10(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Flap10Data.Any())
            {
                // DB has been seeded with flap 10
                return;
            }
            else
            {

                var Flap10Takeofftable = new Flap10Data[]
{
                new Flap10Data { Weight = 18000, Cold0Vr = 100, Cold0V2 = 111, Cold2000Vr = 100,
                                Cold2000V2 = 110, Cold4000Vr = 100, Cold4000V2 = 110, Cold6000Vr = 100, Cold6000V2 = 109,
                                Cold8000Vr = 100, Cold8000V2 = 108, Cold10000Vr = 100, Cold10000V2 = 107, Hot0Vr = 100,
                                Hot0V2 = 109, Hot2000Vr = 100, Hot2000V2 = 109, Hot4000Vr = 100, Hot4000V2 = 109, Hot6000Vr = 100,
                                Hot6000V2 = 107, Hot8000Vr = 0, Hot8000V2 = 106, Hot10000Vr = 0, Hot10000V2 = 105},
                new Flap10Data { Weight = 20000, Cold0Vr = 100, Cold0V2 = 110, Cold2000Vr = 100,
                                Cold2000V2 = 109, Cold4000Vr = 100, Cold4000V2 = 109, Cold6000Vr = 100, Cold6000V2 = 108,
                                Cold8000Vr = 100, Cold8000V2 = 107, Cold10000Vr = 101, Cold10000V2 = 106, Hot0Vr = 100,
                                Hot0V2 = 108, Hot2000Vr = 100, Hot2000V2 = 108, Hot4000Vr = 100, Hot4000V2 = 107, Hot6000Vr = 100,
                                Hot6000V2 = 106, Hot8000Vr = 0, Hot8000V2 = 105, Hot10000Vr = 0, Hot10000V2 = 105},
                new Flap10Data { Weight = 22000, Cold0Vr = 103, Cold0V2 = 109, Cold2000Vr = 105,
                                Cold2000V2 = 109, Cold4000Vr = 105, Cold4000V2 = 108, Cold6000Vr = 105, Cold6000V2 = 108,
                                Cold8000Vr = 106, Cold8000V2 = 108, Cold10000Vr = 108, Cold10000V2 = 108, Hot0Vr = 104,
                                Hot0V2 = 108, Hot2000Vr = 106, Hot2000V2 = 108, Hot4000Vr = 106, Hot4000V2 = 108, Hot6000Vr = 106,
                                Hot6000V2 = 108, Hot8000Vr = 0, Hot8000V2 = 108, Hot10000Vr = 0, Hot10000V2 = 108},
                new Flap10Data { Weight = 24000, Cold0Vr = 109, Cold0V2 = 113, Cold2000Vr = 110,
                                Cold2000V2 = 113, Cold4000Vr = 111, Cold4000V2 = 113, Cold6000Vr = 111, Cold6000V2 = 113,
                                Cold8000Vr = 112, Cold8000V2 = 113, Cold10000Vr = 113, Cold10000V2 = 113, Hot0Vr = 110,
                                Hot0V2 = 113, Hot2000Vr = 111, Hot2000V2 = 113, Hot4000Vr = 112, Hot4000V2 = 113, Hot6000Vr = 112,
                                Hot6000V2 = 113, Hot8000Vr = 0, Hot8000V2 = 113, Hot10000Vr = 0, Hot10000V2 = 113},
                new Flap10Data { Weight = 26000, Cold0Vr = 115, Cold0V2 = 118, Cold2000Vr = 116,
                                Cold2000V2 = 118, Cold4000Vr = 116, Cold4000V2 = 118, Cold6000Vr = 117, Cold6000V2 = 118,
                                Cold8000Vr = 118, Cold8000V2 = 118, Cold10000Vr = 119, Cold10000V2 = 118, Hot0Vr = 116,
                                Hot0V2 = 118, Hot2000Vr = 117, Hot2000V2 = 118, Hot4000Vr = 117, Hot4000V2 = 118, Hot6000Vr = 118,
                                Hot6000V2 = 118, Hot8000Vr = 0, Hot8000V2 = 118, Hot10000Vr = 0, Hot10000V2 = 118},
                new Flap10Data { Weight = 28000, Cold0Vr = 120, Cold0V2 = 122, Cold2000Vr = 121,
                                Cold2000V2 = 122, Cold4000Vr = 122, Cold4000V2 = 122, Cold6000Vr = 122, Cold6000V2 = 122,
                                Cold8000Vr = 123, Cold8000V2 = 122, Cold10000Vr = 124, Cold10000V2 = 122, Hot0Vr = 121,
                                Hot0V2 = 122, Hot2000Vr = 122, Hot2000V2 = 122, Hot4000Vr = 123, Hot4000V2 = 122, Hot6000Vr = 123,
                                Hot6000V2 = 122, Hot8000Vr = 0, Hot8000V2 = 122, Hot10000Vr = 0, Hot10000V2 = 122},
                new Flap10Data { Weight = 29000, Cold0Vr = 124, Cold0V2 = 125, Cold2000Vr = 125,
                                Cold2000V2 = 125, Cold4000Vr = 125, Cold4000V2 = 125, Cold6000Vr = 126, Cold6000V2 = 125,
                                Cold8000Vr = 127, Cold8000V2 = 125, Cold10000Vr = 128, Cold10000V2 = 125, Hot0Vr = 125,
                                Hot0V2 = 125, Hot2000Vr = 125, Hot2000V2 = 125, Hot4000Vr = 126, Hot4000V2 = 125, Hot6000Vr = 127,
                                Hot6000V2 = 125, Hot8000Vr = 10, Hot8000V2 = 125, Hot10000Vr = 0, Hot10000V2 = 125},
};
                foreach (Flap10Data fd in Flap10Takeofftable)
                {
                    context.Flap10Data.Add(fd);
                }
                context.SaveChanges();
                return;

            };// end flap10takeoff else 
        }//end flap10

        public static void InitializeFlap15(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Flap15Data.Any())
            {
                // DB has been seeded with flap 15
                return;
            }
            else
            {

                var Flap15Takeofftable = new Flap15Data[]
{
                new Flap15Data { Weight = 18000, Cold0Vr = 98, Cold0V2 = 106, Cold2000Vr = 98,
                                Cold2000V2 = 106, Cold4000Vr = 98, Cold4000V2 = 105, Cold6000Vr = 98, Cold6000V2 = 104,
                                Cold8000Vr = 98, Cold8000V2 = 103, Cold10000Vr = 98, Cold10000V2 = 102, Hot0Vr = 98,
                                Hot0V2 = 105, Hot2000Vr = 98, Hot2000V2 = 104, Hot4000Vr = 98, Hot4000V2 = 103, Hot6000Vr = 98,
                                Hot6000V2 = 102, Hot8000Vr = 98, Hot8000V2 = 102, Hot10000Vr = 98, Hot10000V2 = 102},
                new Flap15Data { Weight = 20000, Cold0Vr = 98, Cold0V2 = 105, Cold2000Vr = 98,
                                Cold2000V2 = 105, Cold4000Vr = 98, Cold4000V2 = 104, Cold6000Vr = 98, Cold6000V2 = 103,
                                Cold8000Vr = 98, Cold8000V2 = 102, Cold10000Vr = 98, Cold10000V2 = 102, Hot0Vr = 98,
                                Hot0V2 = 103, Hot2000Vr = 98, Hot2000V2 = 103, Hot4000Vr = 98, Hot4000V2 = 102, Hot6000Vr = 98,
                                Hot6000V2 = 102, Hot8000Vr = 99, Hot8000V2 = 102, Hot10000Vr = 99, Hot10000V2 = 102},
                new Flap15Data { Weight = 22000, Cold0Vr = 100, Cold0V2 = 104, Cold2000Vr = 101,
                                Cold2000V2 = 104, Cold4000Vr = 101, Cold4000V2 = 104, Cold6000Vr = 102, Cold6000V2 = 104,
                                Cold8000Vr = 103, Cold8000V2 = 104, Cold10000Vr = 104, Cold10000V2 = 104, Hot0Vr = 101,
                                Hot0V2 = 104, Hot2000Vr = 102, Hot2000V2 = 104, Hot4000Vr = 103, Hot4000V2 = 104, Hot6000Vr = 104,
                                Hot6000V2 = 104, Hot8000Vr = 104, Hot8000V2 = 104, Hot10000Vr = 104, Hot10000V2 = 104},
                new Flap15Data { Weight = 24000, Cold0Vr = 106, Cold0V2 = 109, Cold2000Vr = 106,
                                Cold2000V2 = 109, Cold4000Vr = 107, Cold4000V2 = 109, Cold6000Vr = 108, Cold6000V2 = 109,
                                Cold8000Vr = 108, Cold8000V2 = 109, Cold10000Vr = 109, Cold10000V2 = 109, Hot0Vr = 107,
                                Hot0V2 = 109, Hot2000Vr = 108, Hot2000V2 = 109, Hot4000Vr = 108, Hot4000V2 = 109, Hot6000Vr = 109,
                                Hot6000V2 = 109, Hot8000Vr = 110, Hot8000V2 = 109, Hot10000Vr = 110, Hot10000V2 = 109},
                new Flap15Data { Weight = 26000, Cold0Vr = 111, Cold0V2 = 113, Cold2000Vr = 112,
                                Cold2000V2 = 113, Cold4000Vr = 112, Cold4000V2 = 113, Cold6000Vr = 113, Cold6000V2 = 113,
                                Cold8000Vr = 114, Cold8000V2 = 113, Cold10000Vr = 114, Cold10000V2 = 113, Hot0Vr = 112,
                                Hot0V2 = 113, Hot2000Vr = 113, Hot2000V2 = 113, Hot4000Vr = 114, Hot4000V2 = 113, Hot6000Vr = 114,
                                Hot6000V2 = 113, Hot8000Vr = 115, Hot8000V2 = 113, Hot10000Vr = 115, Hot10000V2 = 113},
                new Flap15Data { Weight = 28000, Cold0Vr = 116, Cold0V2 = 118, Cold2000Vr = 117,
                                Cold2000V2 = 118, Cold4000Vr = 117, Cold4000V2 = 118, Cold6000Vr = 118, Cold6000V2 = 118,
                                Cold8000Vr = 118, Cold8000V2 = 118, Cold10000Vr = 119, Cold10000V2 = 118, Hot0Vr = 117,
                                Hot0V2 = 118, Hot2000Vr = 118, Hot2000V2 = 118, Hot4000Vr = 119, Hot4000V2 = 118, Hot6000Vr = 119,
                                Hot6000V2 = 118, Hot8000Vr = 120, Hot8000V2 = 118, Hot10000Vr = 120, Hot10000V2 = 118},
                new Flap15Data { Weight = 29000, Cold0Vr = 119, Cold0V2 = 120, Cold2000Vr = 120,
                                Cold2000V2 = 120, Cold4000Vr = 120, Cold4000V2 = 120, Cold6000Vr = 121, Cold6000V2 = 120,
                                Cold8000Vr = 122, Cold8000V2 = 120, Cold10000Vr = 122, Cold10000V2 = 120, Hot0Vr = 120,
                                Hot0V2 = 120, Hot2000Vr = 121, Hot2000V2 = 120, Hot4000Vr = 121, Hot4000V2 = 120, Hot6000Vr = 122,
                                Hot6000V2 = 120, Hot8000Vr = 123, Hot8000V2 = 120, Hot10000Vr = 123, Hot10000V2 = 120},
};
                foreach (Flap15Data fd in Flap15Takeofftable)
                {
                    context.Flap15Data.Add(fd);
                }
                context.SaveChanges();
                return;

            };// end flap15takeoff else 
        }//end flap15

    }//end initializer
}//end namespace