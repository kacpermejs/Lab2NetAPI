using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using System.Data.Entity;

namespace WeatherWindowApp
{
    public class Weather
    {

        HttpClient client = new HttpClient();
        List<root> location;
        root weatherDetails;
        public WeatherDB context = new WeatherDB();
        DataBaseWeather  weatherDetailsForDb;


        public async void getLocationAndWeather(string cityName)
        {
            string url = "http://api.openweathermap.org/geo/1.0/direct?q=" + "Wrocław" + "&limit=1&appid=ea8898ceaf85ba0d50355fd8abae9a91";
            string response = await client.GetStringAsync(url);
            location = JsonConvert.DeserializeObject<List<root>>(response);
            if (response != "[]")

                Console.WriteLine(location[0].lon);
                url = "https://api.openweathermap.org/data/2.5/weather?lat=" + location[0].lat + "&lon=" + location[0].lon + "&units=metric" + "&appid=ea8898ceaf85ba0d50355fd8abae9a91";

                response = await client.GetStringAsync(url);

                weatherDetails = JsonConvert.DeserializeObject<root>(response);
                weatherDetailsForDb = JsonConvert.DeserializeObject<DataBaseWeather>(response);

                weatherDetailsForDb.weatherForDatabase =  weatherDetails.weather[0];


        }

        public void addToList()
        {
            if (weatherDetailsForDb != null && location != null)
            {
                bool isThere = false;
                foreach (var w in context.Weathers)
                {
                    if (w.name == weatherDetailsForDb.name)
                        isThere = true;
                }

                if (!isThere)
                {
                    context.Weathers.Add(weatherDetailsForDb);
                    context.SaveChanges();
                }
            }

        }
        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTime = dateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dateTime;
        }



        public class weather
        {
            //public string id { get; set; }  
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
        public class coord
        {
            public double lat { get; set; }
            public double lon { get; set; }
        }

        public class root
        {
            public coord coord { get; set; }    
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
            public long Id { get; set; }

            //public int cod { get; set; }

            
        }

       public class DataBaseWeather
        {
            public coord coord { get; set; }
            public string name { get; set; }
            public weather weatherForDatabase { get; set; }
            public main main { get; set; }
            public wind wind { get; set; }
            public clouds clouds { get; set; }
            public long dt { get; set; }
            public sys sys { get; set; }
            public int timezone { get; set; }
            public long Id { get; set; }

            public override string ToString()
            {
                return $"{name}\nDay Of Year: {UnixTimeStampToDateTime(dt).DayOfYear}\n" +
                    $"Date: {UnixTimeStampToDateTime(dt).Date:d}\n" +
                    $"Time: {UnixTimeStampToDateTime(dt).TimeOfDay}\n" +
                    $"{weatherForDatabase.description}\n\n" +
                    $"Temp: {main.temp} C\n" +
                    $"Temp min: {main.temp_min} - Temp max: {main.temp_max}\n\n" +
                    $"Wind: {wind.speed} m/s\n\n" +
                    $"Pressure: {main.pressure} hPa\n\n" +
                    $"UTC {timezone / 3600}\n\n" +
                    $"{sys.ToString()}\n\n";
            }
        }

        

    }

    
}
