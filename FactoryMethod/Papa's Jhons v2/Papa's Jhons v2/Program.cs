using Papa_s_Jhons_v2.Factory;
using Papa_s_Jhons_v2.FactoryMethod;
using Papa_s_Jhons_v2.Ovens;
using System;

namespace Papa_s_Jhons_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            IOvenFactory ovenFactory= new ElecticOvenFactory();

            Display(ovenFactory);

            ovenFactory = new GasOvenFactory();

            Display(ovenFactory);
        }

        static void Display(IOvenFactory factory)
        {
            IOven oven = factory.CreateOven();
            oven.CreatePizza();
        }
    }
}
