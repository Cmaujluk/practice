using Papa_s_Jhons_v2.Factory;
using Papa_s_Jhons_v2.Grater;
using Papa_s_Jhons_v2.Ovens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papa_s_Jhons_v2.FactoryMethod
{
    class GermanKirchenAppliancesFactory : IKitchenAppliancesAbstractFactory
    {
        public IGrater GetGrater()
        {
            return new GermanMechanicalGrater();
        }

        public IOven GetOven()
        {
            return new GermanGasOven();
        }
    }
}
