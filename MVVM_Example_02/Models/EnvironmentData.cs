using System;
using System.Timers;

namespace DataContextExamples.Models
{
    public class EnvironmentData : DataBaseClass
    {
        private int _temperature;
        private int _humidity;

        public int Temperature
        {
            get => _temperature;
            set
            {
                _temperature = value;
                NotifyPropertyChanged();
            }
        }

        public int Humidity
        {
            get => _humidity;
            set
            {
                _humidity = value;
                NotifyPropertyChanged();
            }
        }


        public EnvironmentData()
        {
            Temperature = 70;
            Humidity = 50;
            // Create a timer with a two second interval.
            var aTimer = new Timer(2000);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;
            aTimer.Enabled = true;
        }
        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Random rnd = new Random();
            Temperature = rnd.Next(Temperature - 10, Temperature + 10);
            Humidity = rnd.Next(Humidity - 5, Humidity + 5);
        }

    }
}