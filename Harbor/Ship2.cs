using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace Harbor
{
    public class Ship2:Ship
    {
        public Ship2(string name)
        {
            Name = name;
            ShipType = Enums.ShipTypes.Tanker;
            Color = "Blue";
            Length = 10m;
        }

    }
}
