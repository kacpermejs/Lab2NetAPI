﻿using System;
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
using System.Data.Entity;



namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        WeatherReadingsDB db = new WeatherReadingsDB();

        public Form1()
        {
            InitializeComponent();
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





        }

        async void ReadStudentsJson(HttpClient client, string call, List<Student> students)
        {
            string response = await client.GetStringAsync(call);
            textBox1.Text = "Working";
            students = JsonConvert.DeserializeObject<List<Student>>(response);
            textBox1.Text = "Finished";
            foreach (var s in students)
                listBox1.Items.Add(s.ToString());
        }
        string APIkey = "b4330f2b107a8cfbff56d85ec0b1ea03";

        public class WeatherReadingsDB : DbContext
        {
            public virtual DbSet<Reading> Readings { get; set; }
        }

        public class Reading
        {
            public int ID { get; set; }
            public double tempreature { get; set; }
            public double preasure { get; set; }
            public double humidity { get; set; }

            public override string ToString()
            {
                return "Id: "+ ID +"Temperature: " + tempreature + " Preasure: " + preasure + " Humidity: " + humidity;
            }

        }

        public async void getWeather()
        {
            HttpClient client = new HttpClient();
            string call = "https://api.openweathermap.org/data/2.5/weather?q=" + "London" + "&appid=" + APIkey;
            string json = await client.GetStringAsync(call);
            var info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

            var reading = new Reading();

            reading.tempreature = info.main.temp;
            reading.preasure = info.main.pressure;
            reading.humidity = info.main.humidity;

            

            db.Readings.Add(reading);
            db.SaveChanges();
            
            listBox1.DataSource = db.Readings.ToList();








        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
