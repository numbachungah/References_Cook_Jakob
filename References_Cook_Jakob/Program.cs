using System;

namespace References_Cook_Jakob
{
    class Program
    {
        static void Main(string[] args)
        {
            Sedan myFirstSedan = new Sedan(0, "GABA-GL");
            IAutomobile myAutomobile = myFirstSedan;

            Sedan myOtherSedan = new Sedan(0, "BOOGR");

            myFirstSedan.IncreaseSpeed();
            Console.WriteLine(myFirstSedan.Speed);
            Console.WriteLine(myAutomobile.Speed);
            Console.WriteLine(myFirstSedan.Equals(myAutomobile));

            myOtherSedan.IncreaseSpeed();
            Console.WriteLine(myFirstSedan.Speed);
            Console.WriteLine(myOtherSedan.Speed);
            Console.WriteLine(myFirstSedan.Equals(myOtherSedan));


            Truck myTruck = new Truck(50, 500, "MyTruck");

            // Calls stringify method and describes automobiles
            myFirstSedan.Stringify();
            myAutomobile.Stringify();
            myOtherSedan.Stringify();
            myTruck.Stringify();

           


        }
    }
}
