using Papa_s_Jhons_v2.Factory;
using Papa_s_Jhons_v2.Ovens;
using System;

namespace Papa_s_Jhons_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            IOvenFactory simpleFactory = new OvenFactory();

            IOven oven = simpleFactory.CreateOven(OvenType.Gas);
            oven.CreatePizza();

            oven = simpleFactory.CreateOven(OvenType.Electric);
            oven.CreatePizza();
        }
    }
}
