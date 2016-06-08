using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShipInterface;

namespace Harbour.ShipTypes
{
    public abstract class Ship:IShip
    {
        public string Name { get; set; }
        public string Color{ get; set; }
        public string Length{ get; set; }
        public Enums.Enums.ShipTypes IncomeShipType { get; set; }
        public int IncomeBeepCount { get; set; }

        public virtual string GetBeep()
        {
            return "Din-Don";
        }
    }
}
