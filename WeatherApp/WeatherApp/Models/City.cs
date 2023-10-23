using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Client.Models
{
    public class City
    {
        public int Version { get; set; }
        public string Key { get; set; }
        public string Type { get; set; }
        public int Rank { get; set; }
        public string LocalizedName { get; set; }
        public Country Country { get; set; }
        public AdministrativeArea AdministrativeArea { get; set; }
        public string EnglishName { get; set; }
    }
}
