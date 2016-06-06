using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace Harbor
{
    public class Ship3:Ship
    {
        public Ship3(string name)
        {
            Name = name;
            //ShipType = Enums.ShipTypes.TooBigShip;
            Color = "Black";
            Length = 12m;

        }

        public Enums.ShipTypes ShipType {
            get { return Enums.ShipTypes.TooBigShip; }
        }
    }
}
