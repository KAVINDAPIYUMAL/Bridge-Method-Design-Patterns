﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Method_Design_Patterns
{
    class Assemble : IWorkshop
    {
        public void Work()
        {
            Console.Write(" And");
            Console.WriteLine(" Assembled.");
        }
    }
}