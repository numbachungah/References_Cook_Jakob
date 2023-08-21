using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References_Cook_Jakob
{

    // the truck specs, speed, and weight and allat
    internal class Truck : IAutomobile
    {
       

            public double Speed { get; private set; }


            public int Wheels { get; private set; }


            public string LicensePlate { get; private set; }
        
            public double Weight { get; private set; }
            public Truck(double speed, int wheels, string licensePlate)
            {
                
                Speed = 3;
                Wheels = wheels ;
                LicensePlate = licensePlate ;
            if (Weight <= 400) { Wheels = 8; } else { Wheels = 12; }
            }

            public void Stringify()
            {
                Console.WriteLine($"The Sedam is traveling at a speed of {Speed} on {Wheels} wheels, with a License Plate # of {LicensePlate}.");
            }

            public void IncreaseSpeed()
            {
                Speed -=3;
            }
        }






}
