using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class WeatherProcessor
    {
        //public static WeatherTypeModel weatherType;
        public static async Task<WeatherModel> LoadWeather()
        {
            string url = "https://api.openweathermap.org/data/2.5/weather?zip=32909&units=imperial&appid=54f6c246c5feb590514d34c40fe93754";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url)) 
            {
                if (response.IsSuccessStatusCode)
                {
                    WeatherResultModel weather = await response.Content.ReadAsAsync<WeatherResultModel>();

                    //weatherType = weather.Weather;
                    return weather.Main;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public static async Task<WeatherTypeModel[]> LoadWeatherType()
        {
            string url = "https://api.openweathermap.org/data/2.5/weather?zip=32909&units=imperial&appid=54f6c246c5feb590514d34c40fe93754";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    WeatherTypeResultModel weather = await response.Content.ReadAsAsync<WeatherTypeResultModel>();

                    return weather.Weather;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
