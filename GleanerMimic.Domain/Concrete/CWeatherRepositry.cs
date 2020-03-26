using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GleanerMimic.Domain.Abstract;
using GleanerMimic.Domain.Entities;

namespace GleanerMimic.Domain.Concrete
{
    public class CWeatherRepositry : IWeatherRepositry
    {
        WeatherService localWeather = new WeatherService{
            city = "Kingston",
            day = DateTime.Now.Day,
            daysWeek = DateTime.Now.DayOfWeek.ToString(),
            dayType = "Cloudy",
            month = DateTime.Now.ToString("MMM"),
            temperatureFahrenheit = 67.4M, 
            temperatureDegree = (decimal)34.3,
            year = DateTime.Now.Year

           };

        public WeatherService watherService
        {
            get {
                return localWeather;
            }
        }
    }
}
