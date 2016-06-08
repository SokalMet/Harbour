using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShipInterface;

namespace Harbour.ShipTypes
{
    public class IncomingShip:Ship
    {
        public IncomingShip(string name, Enums.Enums.ShipTypes incomeShipType, string color, string length)
        {
            Name = name;
            Color = color;
            Length = length;
            IncomeShipType = incomeShipType;
        }
       
        //public int IncomeBeepCount {
        //    get { return 3; }
        //    set {}
        //}

        public override string GetBeep()
        {
            return "Beeep";
        }
    }
}
