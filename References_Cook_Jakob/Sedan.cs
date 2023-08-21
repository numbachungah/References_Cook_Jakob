using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References_Cook_Jakob
{

    // the code showing how the Sedan class works
    internal class Sedan : IAutomobile
    {

        public double Speed { get; private set; }


        public int Wheels { get; private set; }


        public string LicensePlate { get; private set; }

        public Sedan(double speed,  string licensePlate)
        {
            Speed = speed;
            Wheels = 4;
            LicensePlate = licensePlate;
        }

        public void Stringify()
        { 
            Console.WriteLine($"The Sedam is traveling at a speed of {Speed} on {Wheels} wheels, with a License Plate # of {LicensePlate}."); 
        }

        public void IncreaseSpeed() 
        {
            Speed -= 5;
        }
    }
}
