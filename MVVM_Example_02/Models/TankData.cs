using System;
using System.Timers;

namespace DataContextExamples.Models
{
    public class TankData : DataBaseClass
    {
        private string _name;
        private int _dataValue;
        private int _minimum;
        private int _maximum;

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                NotifyPropertyChanged("Name");
            }
        }

        public int Minimum
        {
            get => _minimum;
            set
            {
                _minimum = value;
                NotifyPropertyChanged();
            }
        }

        public int Maximum
        {
            get => _maximum;
            set
            {
                _maximum = value;
                NotifyPropertyChanged();
            }

        }

        public int DataValue
        {
            get => _dataValue;
            set
            {
                if (value < Minimum || value > Maximum)
                    return;
                _dataValue = value;
                NotifyPropertyChanged();
            }
        }

        
        public void Initialize(string name, int min = -100, int max= 100)
        {
            Name = name;
            Minimum = min;
            Maximum = max;

            // Create a timer with a one second interval.
            var aTimer = new System.Timers.Timer(1000);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;
            aTimer.Enabled = true;

        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Random rnd = new Random();
            DataValue = rnd.Next(DataValue-10, DataValue+10);
        }
    }
}
