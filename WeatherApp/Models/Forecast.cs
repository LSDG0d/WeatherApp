using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Models
{
    internal class Forecast
    {
        public int? id { get; set; }
        public int? Cityid { get; set; }
        public string DateFrom { get; set; }
        public string DateTo { get; set; }
        public int? Temperature {  get; set; }
        public int? Pressure { get; set;}
    }
}
