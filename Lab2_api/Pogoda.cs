using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_api
{
    public class Cord
    {
        public float lon;
        public float lat;
    }

    public class Weather
    {
        public int id;
        public string desc;
    }

    public class Main_part
    {
        public float temp;
        public float feels_like;
    }
    
    public class Wind
    {
        public float speed;
    }

    public class GetWeather
    {
        public Cord Coord { get; set; }
        public Weather[] Weather { get; set; }
        public Main_part Main { get; set; }
        public Wind Wind { get; set; }
    }

    public class Dataset_Weather
    {
        public int ID { get; set; }
        public string city { get; set; }
        public float temp { get; set; }
        public float feels_like { get; set; }
        public float wind_speed { get; set; }
    }
}
