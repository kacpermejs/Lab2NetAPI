using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class WeatherInfo
    {
        public class coord
        {
            double lon { get; set; }
            double lat { get; set; }
        }

        public class weather
        {
            string main { get; set; }
            string description { get; set; }
            string icon { get; set; }
        }

        public class main
        {
            double temp { get; set; }
            double feels_like { get; set; }
            double temp_min { get; set; }
            double temp_max { get; set; }
            double pressure { get; set; }
            double humidity { get; set; }
            double sea_level { get; set; }
            double grnd_level { get; set; }
        }




    }
}
