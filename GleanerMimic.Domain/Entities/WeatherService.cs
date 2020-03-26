using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GleanerMimic.Domain.Entities
{
    public class WeatherService
    {
        public string month { get; set; }
        public int day { get; set; }
        public string daysWeek { get; set; }
        public int year { get; set; }

        public string city { get; set; }
        public decimal temperatureDegree { get; set; }
        public decimal temperatureFahrenheit { get; set; }
        public string dayType { get; set; } //type of day, sunny,cloudy, overcast etc
    }
}
