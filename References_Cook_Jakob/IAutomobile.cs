using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// showcases the innerworkings of the auto mobile
namespace References_Cook_Jakob
{
    internal interface IAutomobile
    {

        public double Speed { get; }

        public int Wheels { get; }
        public string LicensePlate { get; }

        public void Stringify();

    }
}
