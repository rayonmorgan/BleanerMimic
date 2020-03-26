using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using GleanerMimic.Domain.Abstract;
using GleanerMimic.WebUi.Models;


namespace GleanerMimic.WebUi.Controllers
{
    public class WeatherServiceController : Controller
    {
        private IWeatherRepositry weatherRepositry;
        public WeatherServiceController(IWeatherRepositry weatherRepositry)
        {
            this.weatherRepositry = weatherRepositry;
        }

        public ActionResult ShowWeather()
        {
            decimal fahrenheit = Convert.ToDecimal(weatherRepositry.watherService.temperatureFahrenheit );
            WeatherModel weatherModel = new WeatherModel
            {
                weatherServices = weatherRepositry.watherService                

            };

            return PartialView("ShowWeather", weatherModel);
        }
       

    }
}
