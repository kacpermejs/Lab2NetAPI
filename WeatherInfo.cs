using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;

namespace WeatherWindowApp
{
    class WeatherInfo
    {

        HttpClient client = new HttpClient();
        List<City> location;

        public async void getLocation(string city)
        {
            string url = "http://api.openweathermap.org/geo/1.0/direct?q=" + city + "&limit=1&appid=ea8898ceaf85ba0d50355fd8abae9a91";
            Console.WriteLine(url);
            string response = await client.GetStringAsync(url);
            location = JsonConvert.DeserializeObject<List<City>>(response);
            Console.WriteLine(location[0].name);


        }

        public class City
        {
            public string name { get; set; }
            public double lat { get; set; }
            public double lon { get; set; }


            public override string ToString()
            {
                return name + " " + lat + " " + lon;
            }
        }
        public class coord
        {
            public double lon { get; set; }
            public double lat { get; set; }
        }

        public class weather
        {
            public string main { get; set; }
            public string description { get; set; }
            public string icon { get; set; }
        }

        public class main
        {
            public double temp { get; set; }
            public double feels_like { get; set; }
            public double temp_min { get; set; }
            public double temp_max { get; set; }
            public double pressure { get; set; }
            public double humidity { get; set; }
            public double sea_level { get; set; }
            public double grnd_level { get; set; }
        }

        public class wind
        {
            public double speed { get; set; }
            public double deg { get; set; }
            public double gust { get; set; }
        }
        public class clouds
        {
            public double all { get; set; }

        }

        public class sys
        {
            public long sunrise { get; set; }
            public long sunset { get; set; }
        }

        public class root
        {
            public coord coord { get; set; }
            public List<weather> weather { get; set; }
            public main main { get; set; }
            public long visibility { get; set; }
            public wind wind { get; set; }
            public clouds clouds { get; set; }
            public long dt { get; set; }
            public sys sys { get; set; }
            public int timezone { get; set; }
            public long id { get; set; }
            public string name { get; set; }
            public int cod { get; set; }


        }


        
    }
}
