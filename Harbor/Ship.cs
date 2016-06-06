using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harbor
{
    public class Ship : IShip
    {
        public string Name { get; set; }
        public Enums.ShipTypes ShipType { get; set; }
        public string Color { get; set; }
        public decimal Length { get; set; }

        public virtual string BeepSound()
        {
            return "Beep-beep!";
        }

        public virtual string IncomeBeep()
        {
            return BeepSound() + BeepSound() + BeepSound();
        }
    }
}
