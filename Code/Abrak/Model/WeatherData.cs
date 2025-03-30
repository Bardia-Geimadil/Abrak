using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAPI;

    public class WeatherData
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public double TemperatureC { get; set; }
        public string Condition { get; set; }
        public int Humidity { get; set; }
        public double WindSpeedKph { get; set; }
        public string WindDirection { get; set; }
        public string LocalTime { get; set; }
    }


