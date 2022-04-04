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
using Timer = System.Windows.Forms.Timer;
using System.Drawing.Imaging;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Weather w = new Weather();
        string city;
        public Form1()
        {
            InitializeComponent();
            //button1.Enabled = false;
            //buttonGo.Enabled = false;
        }
        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            getWeather();
            w.getLocationAndWeather(cityNameBox.Text);
            Console.WriteLine(cityNameBox.Text + Environment.NewLine);


            //Image image = Image.FromFile("C:\\Users\\piotr\\source\\repos\\Lab2NetAPI\\Resources\\300Logo.png");
            //this.weatherIcon.Image = image;// new Bitmap("C:\\Users\\piotr\\source\\repos\\Lab2NetAPI\\Resources\\300Logo.png");
           

            //weatherIcon.Load();
            //weatherIcon.Height = image.Height;
            //weatherIcon.Width = image.Width;
            //this.weatherIcon.Image =; //new Bitmap("/Resources/300Logo.png");

            //buttonGo.Enabled = true;

        }

        async void ReadStudentsJson(HttpClient client, string call, List<Student> students)
        {
            string response = await client.GetStringAsync(call);
            cityNameBox.Text = "Working";
            students = JsonConvert.DeserializeObject<List<Student>>(response);
            cityNameBox.Text = "Finished";
            foreach (var s in students)
                bigEkran.Items.Add(s.ToString());
        }
        string APIkey = "b4330f2b107a8cfbff56d85ec0b1ea03";
        async void getWeather()
        {
            HttpClient client = new HttpClient();
            string call = "https://api.openweathermap.org/data/2.5/weather?q=" + "London" + "&appid=" + APIkey;
            string json = await client.GetStringAsync(call);
            WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);
            bigEkran.Items.Add("Temperature: " + (Info.main.temp - 272.15) + " Pressure: " + Info.main.pressure);


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

        private void button2_Click(object sender, EventArgs e)
        {
            cityNameBox.Clear();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void showWeather_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            w.addToList();
            showItems();
            

        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (showCities.SelectedItems.Count > 0)
                w.l.RemoveAt(showCities.SelectedIndex);
            else
                Console.WriteLine("ERRROR");
            showItems();
        }

        private void showItems()
        {
            showCities.Items.Clear();
            if (w.l.Count > 0)
            {
                foreach (var s in w.l)
                {
                    showCities.Items.Add(s.name);
                }
            }
        }

        private void showCities_Click(object sender, EventArgs e)
        {
            Console.WriteLine(showCities.SelectedIndex);
            showWeatherInBox(showCities.SelectedIndex);
            

        }
        void showWeatherInBox(int whichItem)
        {
            //showWeather.();
            //showWeather.Text = w.l[whichItem].main.temp;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            showWeather.Text = w.l[0].ToString();
            this.weatherIcon.ImageLocation = "http://openweathermap.org/img/wn/" + w.l[0].weather[0].icon + "@2x.png";//"C:\\Users\\piotr\\source\\repos\\Lab2NetAPI\\Resources\\300Logo.png";
            this.weatherIcon.Load();
        }

        private void weatherIcon_Click(object sender, EventArgs e)
        {

        }

    }
}
