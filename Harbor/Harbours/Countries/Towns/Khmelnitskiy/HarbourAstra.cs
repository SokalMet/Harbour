using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Harbour.ShipTypes;

namespace Harbour.Harbours.Countries.Towns.Khmelnitskiy
{
    public class Astra:Harbour
    {
        public Astra()
        {
            Name = "Astra";
            Country = "Ukraine";
            Town ="(Khmelnitskiy)";
            ShipsInHarbour = new List<Ship>();
        }

        public Enums.Enums.WeatherType Weather()
        {
            var values = Enum.GetValues(typeof(Enums.Enums.WeatherType));
            var random = new Random();
            var randomWeather = (Enums.Enums.WeatherType)values.GetValue(random.Next(values.Length));
            return randomWeather;
        }

        public List<Enums.Enums.ShipTypes> AdoptShipTypes=new List<Enums.Enums.ShipTypes>
        {
            Enums.Enums.ShipTypes.SmallShip,
            Enums.Enums.ShipTypes.Tanker
        };

        public List<Ship> ShipsInHarbour { get; set; } 

       public override decimal MaxShipSize{
            get { return 11m; }
        }

       public override int MaxShipsIn{
           get { return 3; }
       }
    }
}
