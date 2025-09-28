using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNo3iii
{
    // Define delegate for the event
    public delegate void TemperatureExceededHandler(int temperature);

    // Publisher class
    class WeatherStation
    {
        public event TemperatureExceededHandler TemperatureExceeded;

        private int threshold;

        public WeatherStation(int limit)
        {
            threshold = limit;
        }

        public void CheckTemperature(int currentTemp)
        {
            Console.WriteLine("Checking temperature: " + currentTemp + "°C");

            if (currentTemp > threshold)
            {
                Console.WriteLine("Temperature exceeded limit!");
                OnTemperatureExceeded(currentTemp); // Raise the event
            }
            else
            {
                Console.WriteLine("Temperature is within safe limit.");
            }
        }

        // Method to raise the event
        protected virtual void OnTemperatureExceeded(int temp)
        {
            if (TemperatureExceeded != null)
            {
                TemperatureExceeded(temp);
            }
        }
    }

    // Subscriber class or method
    class TemperatureAlert
    {
        public void Alert(int temp)
        {
            Console.WriteLine("ALERT! Temperature is too high: " + temp + "°C");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            WeatherStation station = new WeatherStation(40);
            TemperatureAlert alert = new TemperatureAlert();

            // Subscribe to the event
            station.TemperatureExceeded += alert.Alert;

            // Simulate temperature readings
            int[] readings = { 35, 42, 38, 45, 13 };

            foreach (int temp in readings)
            {
                station.CheckTemperature(temp);
                Console.WriteLine();
            }
        }
    }
}
