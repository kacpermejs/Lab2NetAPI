using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{


    public class WeatherDB : DbContext
    {
        public DbSet<Weather.root> Weathers { get; set; }
    }
}
