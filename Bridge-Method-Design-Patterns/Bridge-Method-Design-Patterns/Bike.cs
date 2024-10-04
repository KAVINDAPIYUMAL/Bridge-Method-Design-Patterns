using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Method_Design_Patterns
{
    class Bike : Vehicle
    {
        public Bike(IWorkshop workShop1, IWorkshop workShop2) : base(workShop1, workShop2)
        {
        }

        public override void Manufacture()
        {
            Console.Write("Bike ");
            workShop1.Work();
            workShop2.Work();
        }
    }
}
