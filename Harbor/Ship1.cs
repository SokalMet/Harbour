using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace Harbor
{
    public class Ship1:Ship
    {
        public Ship1(string name)
        {
            Name = name;
            ShipType = Enums.ShipTypes.SmallShip;
            Color = "Red";
            Length = 10.52m;
        }

        private string _incomeBeep()
        {
            return BeepSound() + BeepSound();
        }

        public override string IncomeBeep()
        {
            return _incomeBeep();
        }
    }
}
