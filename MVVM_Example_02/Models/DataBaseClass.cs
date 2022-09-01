using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DataContextExamples.Models
{
    public class DataBaseClass : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged([CallerMemberName] string propName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

    }
}