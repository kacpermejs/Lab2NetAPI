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



namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Weather w = new Weather();
        string city;
        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
            buttonGo.Enabled = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            /*
            //string call = "http://radoslaw.idzikowski.staff.iiar.pwr.wroc.pl/instruction/students.json";
            string call = "https://api.openweathermap.org/data/2.5/weather?lat=0&lon=0&appid=b4330f2b107a8cfbff56d85ec0b1ea03";
            HttpClient client = new HttpClient();
            List<Student> students = new List<Student>();
            ReadStudentsJson(client, call, students);
            */

            /*
            var json = File.ReadAllText(@"C:\Users\kacpe\source\repos\WindowsFormsApp1\students.json");
            List<Student> students = JsonConvert.DeserializeObject<List<Student>>(json);
            foreach (var s in students)
                listBox1.Items.Add(s.ToString());

            */
            getWeather();
            w.getLocation(city);
            buttonGo.Enabled = true;
            


        }

        async void ReadStudentsJson(HttpClient client, string call, List<Student> students)
        {
            string response = await client.GetStringAsync(call);
            textBox1.Text = "Working";
            students = JsonConvert.DeserializeObject<List<Student>>(response);
            textBox1.Text = "Finished";
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                button1.Enabled = false;
                buttonGo.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
                city = textBox1.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            w.getWeather();
            textBox1.Clear();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
