using Papa_s_Jhons_v2.Factory;
using Papa_s_Jhons_v2.FactoryMethod;
using Papa_s_Jhons_v2.Grater;
using Papa_s_Jhons_v2.Ovens;
using System;

namespace Papa_s_Jhons_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            IKitchenAppliancesAbstractFactory kitchenAppliancesFactory = new ChineseKirchenAppliancesFactory();

            Display(kitchenAppliancesFactory);

            kitchenAppliancesFactory = new GermanKirchenAppliancesFactory();

            Display(kitchenAppliancesFactory);
        }

        static void Display(IKitchenAppliancesAbstractFactory factory)
        {
            IOven oven = factory.GetOven();
            IGrater grater = factory.GetGrater();
            grater.GrateCheese();
            oven.CreatePizza();
        }
    }
}
