using System;
using System.Globalization;
using System.Threading;
using ObserverPatternDemo.Implemantation.Observable;
using ObserverPatternDemo.Implemantation.Observers;

namespace WeatherStation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var weatherStation = new WeatherData();
            var currentInfo = new CurrentConditionsReport();
            var statisticInfo = new StatisticReport();

            currentInfo.Subscribe(weatherStation);
            statisticInfo.Subscribe(weatherStation);

            while (true)
            {
                Thread.Sleep(2000);
                weatherStation.GenerateWeather();
                Console.WriteLine("Current info: " + currentInfo);
                Console.WriteLine("Statistic: " + statisticInfo);
            }
        }
    }
}
