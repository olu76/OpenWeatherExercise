using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace OpenWeatherExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = File.ReadAllText("appsettings.json");
            string APIkey = JObject.Parse(key).GetValue("DefaultKey").ToString();

            Console.WriteLine("Please enter your zipcode:");
            var zipcode = Console.ReadLine();
            Console.WriteLine();

            var apiCall = $"https://api.openweathermap.org/data/2.5/weather?zip={zipcode}&units=imperial$appid={APIkey}";

            Console.WriteLine($"It is currently {WeatherMap.GetTemp(apiCall)} degrees F in your location.");
        }
    }
}
