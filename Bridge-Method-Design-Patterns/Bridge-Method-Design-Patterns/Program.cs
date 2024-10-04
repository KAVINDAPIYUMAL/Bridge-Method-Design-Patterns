using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Method_Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle1 = new Car(new Produce(), new Assemble());
            vehicle1.Manufacture();

            Vehicle vehicle2 = new Bike(new Produce(), new Assemble());
            vehicle2.Manufacture();

            Console.ReadLine();
        }
    }
}
