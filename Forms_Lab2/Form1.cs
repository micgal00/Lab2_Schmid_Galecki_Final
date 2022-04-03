using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http;
using Lab2_api;
using System.Data.Entity;

namespace Forms_Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            var json = GetDataAsync();
        }
        private async Task<string> GetDataAsync()
        {
            string Miasto = getCity.Text;
            string call = "https://api.openweathermap.org/data/2.5/weather?q=" + Miasto + "&appid=6a54ad3554c744c9e365b3e7858658dd&units=metric";
            HttpClient client = new HttpClient();
            string json = await client.GetStringAsync(call);
            GetWeather pogoda = JsonConvert.DeserializeObject<GetWeather>(json);

            AktualnaPogoda.Items.Add(Miasto);
            AktualnaPogoda.Items.Add("Temperatura: " + pogoda.Main.temp + "'C\tTemperatura odczuwalna: " + pogoda.Main.feels_like + "'C\tPredkosc wiatru: " + pogoda.Wind.speed + "km/h ");
            
            return json;
        }

        public async void Database_addRecord()
        {
            string Miasto = getCity.Text;
            string call = "https://api.openweathermap.org/data/2.5/weather?q=" + Miasto + "&appid=6a54ad3554c744c9e365b3e7858658dd&units=metric";
            HttpClient client = new HttpClient();
            string json = await client.GetStringAsync(call);
            GetWeather pogoda = JsonConvert.DeserializeObject<GetWeather>(json);

            var context = new Database();
            context.WeatherData.Add(new Dataset_Weather { city = Miasto, temp = pogoda.Main.temp, feels_like = pogoda.Main.feels_like, wind_speed = pogoda.Wind.speed });
            context.SaveChanges();
            var weather = (from s in context.WeatherData select s).ToList();
            AktualnaPogoda.Items.Clear();
            foreach (var wt in weather)
            {
                string data = "ID: " + wt.ID + ", miasto: " + wt.city + ", temp.: " + wt.temp + "'C, temp. odczuwalna: " + wt.feels_like + "'C, pr. wiatru: " + wt.wind_speed + "km/h";
                AktualnaPogoda.Items.Add(data);
            }
        }
           
        private void button1_Click(object sender, EventArgs e)
        {
           Database_addRecord();
        }

        private void deleteRecord_Click_1(object sender, EventArgs e)
        {
            var context = new Database();
            int nr = Int16.Parse(IDToDelete.Text);
            var s = context.WeatherData.First(x => x.ID == nr);
            context.WeatherData.Remove(s);
            context.SaveChanges();
        }

        private void showQuery_Click(object sender, EventArgs e)
        {
            var context = new Database();

            var cities = (from s in context.WeatherData where s.temp > 10 select s).ToList();
            AktualnaPogoda.Items.Clear();
            foreach (var ct in cities)
            {
                string data = ct.city + ", temp.: " + ct.temp + "'C";
                AktualnaPogoda.Items.Add(data);
            }
        }

        private void showData_Click(object sender, EventArgs e)
        {
            var context = new Database();

            var weather = (from s in context.WeatherData select s).ToList();
            AktualnaPogoda.Items.Clear();
            foreach (var wt in weather)
            {
                string data = "ID: " + wt.ID + ", miasto: " + wt.city + ", temp.: " + wt.temp + "'C, temp. odczuwalna: " + wt.feels_like + "'C, pr. wiatru: " + wt.wind_speed + "km/h";
                AktualnaPogoda.Items.Add(data);
            }
        }
    }
    
}
