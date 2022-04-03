using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Net.Http;

namespace Lab2_api
{
    class Program
    {
        public class GetWeather
        {
            public Cord Coord { get; set; }
            public Weather[] Weather { get; set; }
            public Main_part Main { get; set; }
            public Wind Wind { get; set; }
        }
        static void Main(string[] args)
        {
            Load();
            Console.Read();
        }

        public static async void Load()
        {
            string call = "https://api.openweathermap.org/data/2.5/weather?lat=35&lon=139&appid=6a54ad3554c744c9e365b3e7858658dd";
            HttpClient client = new HttpClient();
            string json = await client.GetStringAsync(call);
            //Console.WriteLine(json);

            GetWeather pogoda = JsonConvert.DeserializeObject<GetWeather>(json);
            //Console.WriteLine(pogoda.Main.dt);    
        }
    }
}
