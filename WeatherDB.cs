using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherWindowApp
{


    public class WeatherDB : DbContext
    {
        public DbSet<Weather.DataBaseWeather> Weathers { get; set; }

    }
}
