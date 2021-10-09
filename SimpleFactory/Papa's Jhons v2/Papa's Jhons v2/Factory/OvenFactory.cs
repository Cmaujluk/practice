using Papa_s_Jhons_v2.Ovens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papa_s_Jhons_v2.Factory
{
    class OvenFactory : IOvenFactory
    {
        public IOven CreateOven(OvenType type) => (type) switch
        {
            (OvenType.Electric) => new ElectricOven(),
            (OvenType.Gas) => new GasOven(),
            _ => throw new NotImplementedException()
        };
    }
}
