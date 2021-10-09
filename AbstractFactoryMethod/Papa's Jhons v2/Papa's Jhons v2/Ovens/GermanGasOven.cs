using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papa_s_Jhons_v2.Ovens
{
    class GermanGasOven : IOven
    {
        public void CreatePizza()
        {
            Console.WriteLine("Bake pizza on german gas oven.");
        }
    }
}
