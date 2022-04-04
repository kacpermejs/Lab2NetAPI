using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;

namespace WindowsFormsApp1
{
    public class Weather
    {

        HttpClient client = new HttpClient();
        List<root> location;
        public List<root> l = new List<root>();
        root w;
        int nr = 0;  

        public async void getLocationAndWeather(string city)
        {
            string url = "http://api.openweathermap.org/geo/1.0/direct?q=" + "Wrocław" + "&limit=1&appid=ea8898ceaf85ba0d50355fd8abae9a91";
            Console.WriteLine(url);
            string response = await client.GetStringAsync(url);
            if (response == "[]")
                Console.WriteLine("Pusty");
            else
            {
                location = JsonConvert.DeserializeObject<List<root>>(response);
                Console.WriteLine(l.Count);

                url = "https://api.openweathermap.org/data/2.5/weather?lat=" + location[0].lat + "&lon=" + location[0].lon + "&units=metric" + "&appid=ea8898ceaf85ba0d50355fd8abae9a91";
                Console.WriteLine(url);
                response = await client.GetStringAsync(url);
                w = JsonConvert.DeserializeObject<root>(response);

                foreach (root c in l)
                {
                    Console.WriteLine(c);
                }
            }
        }

        public void addToList()
        {
            if (location != null)
            {
                l.Add(w);
            }
            else
                Console.WriteLine("ERRROR");
        }

  

        public class weather
        {
            public string id { get; set; }  
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

        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTime = dateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dateTime ;
        }

        public class sys
        {
            public long sunrise { get; set; }
            public long sunset { get; set; }

            public override string ToString()

            {
                DateTime rise = UnixTimeStampToDateTime(sunrise);
                DateTime set = UnixTimeStampToDateTime(sunset);
                return  $"Sunrise: {rise.TimeOfDay}\nSunset: {set.TimeOfDay}";
            }
        }
        

        public class root
        {
            public string name { get; set; }
            public double lat { get; set; }
            public double lon { get; set; }
            public List<weather> weather { get; set; }
            public main main { get; set; }
            //public long visibility { get; set; }
            public wind wind { get; set; }
            public clouds clouds { get; set; }
            public long dt { get; set; }
            public sys sys { get; set; }
            public int timezone { get; set; }
            public long id { get; set; }

            //public int cod { get; set; }

            public override string ToString()
            {
                return $"{name}\nDay Of Year: {UnixTimeStampToDateTime(dt).DayOfYear}\n" +
                    $"Date: {UnixTimeStampToDateTime(dt).Date:d}\n" +
                    $"Time: {UnixTimeStampToDateTime(dt).TimeOfDay}\n" +
                    $"{weather[0].description}\n\n" +
                    $"Temp: {main.temp} C\n\n" +
                    $"Wind: {wind.speed} m/s\n\n" +
                    $"Pressure: {main.pressure} hPa\n\n" +
                    $"UTC {timezone/3600}\n\n" +
                    $"{sys.ToString()}\n\n";
            }
        }

        public string wet(int nr)
        {
            return $"{l[nr].main.temp}";
        }


    }
}
