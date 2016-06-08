using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harbour
{
    class HydrometeorologicalСentre
    {
        public delegate void WeatherInTown();

        public event WeatherInTown goodEnought;
        public Enums.Enums.WeatherType Weather(string nameOfTown)
        {
            var values = Enum.GetValues(typeof(Enums.Enums.WeatherType));
            var random = new Random();
            var randomWeather = (Enums.Enums.WeatherType)values.GetValue(random.Next(values.Length));
            if (randomWeather == Enums.Enums.WeatherType.Good)
            {
                Console.WriteLine("The weather in " + nameOfTown + " is good for " + DateTime.Today);
                goodEnought();
            }
            return randomWeather;
        }
    }
}
