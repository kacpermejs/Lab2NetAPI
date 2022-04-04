using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading;
using System.Data.Entity;

namespace WeatherWindowApp
{
    public partial class WeatherWindow : Form
    {
        Weather weather = new Weather();
        string imieINazwisko= $"Kacper Mejsner [nrindexu]\nPiotr Markiewicz 252940";
        public WeatherWindow()
        {
            InitializeComponent();
            weather.context.Weathers.Load();
            showItems();
            labelName.Text = imieINazwisko;
            //button1.Enabled = false;
            //buttonGo.Enabled = false;
        }
        

        private void searchButton_Click(object sender, EventArgs e)
        {
            weather.getLocationAndWeather(cityNameBox.Text);
            //Console.WriteLine(cityNameBox.Text + Environment.NewLine);
        }


        private void cityNameBox_TextChanged(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(cityNameBox.Text))
            {
               // button1.Enabled = false;
                //buttonGo.Enabled = false;
            }
            else
            {
                searchButton.Enabled = true;
                //city = textBox1.Text;
            }
           
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            weather.addToList();
            showItems();

        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            var w = weather.context.Weathers.Find(showCities.SelectedIndex+1);
            weather.context.Weathers.Remove(w);
            weather.context.SaveChanges();
            showItems();
        }

        private void showItems()
        {
            showCities.Items.Clear();

            if (weather.context.Weathers.Local.Count > 0)
            {
                foreach (var w in weather.context.Weathers)
                {
                    showCities.Items.Add(w.name);
                }
            }
        }
        private void updateWeather()
        {
            if (showCities.SelectedIndex >= 0)
            {
                showWeather.Text = weather.context.Weathers.Local[showCities.SelectedIndex].ToString();
                this.weatherIcon.ImageLocation = "http://openweathermap.org/img/wn/" + weather.context.Weathers.Local[showCities.SelectedIndex].weatherForDatabase.icon + "@2x.png";
                this.weatherIcon.Load();
            }
        }

        private void showCities_Click(object sender, EventArgs e)
        {
            Console.WriteLine(weather.context.Weathers.Local[0].Id);
            if (showCities.SelectedIndex >=0 )
            {
                updateWeather();
            }
        }

        private async void label1_Click(object sender, EventArgs e)
        {
            if (showCities.SelectedIndex > -1)
            {
                HttpClient client = new HttpClient();
                Weather.DataBaseWeather weatherr;
                Weather.root root;

                var w = weather.context.Weathers.Find(showCities.SelectedIndex + 1);

                string url = "https://api.openweathermap.org/data/2.5/weather?lat=" + w.coord.lat + "&lon=" + w.coord.lon + "&units=metric" + "&appid=ea8898ceaf85ba0d50355fd8abae9a91";
                string response = await client.GetStringAsync(url);
                weatherr = JsonConvert.DeserializeObject<Weather.DataBaseWeather>(response);
                root = JsonConvert.DeserializeObject<Weather.root>(response);
                weatherr.weatherForDatabase = root.weather[0];

                w.clouds = weatherr.clouds;
                w.sys = weatherr.sys;
                w.main = weatherr.main;
                w.weatherForDatabase = weatherr.weatherForDatabase;
                w.dt = weatherr.dt;

                weather.context.SaveChanges();
                updateWeather();
                showItems();
            }
        }



        private void weatherIcon_Click(object sender, EventArgs e)
        {

        }
    }
}
