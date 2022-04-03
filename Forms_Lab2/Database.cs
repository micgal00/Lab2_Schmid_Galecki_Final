using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Lab2_api;

namespace Forms_Lab2
{
    internal class Database : DbContext
    {
        public virtual DbSet<Dataset_Weather> WeatherData { get; set; }
    }
}
