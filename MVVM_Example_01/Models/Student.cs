using System.ComponentModel;

namespace MVVM_Example_01.Models
{
    public class Student : INotifyPropertyChanged
    {
        private string firstname;
        private string lastname;

        public string FirstName
        {
            get { return firstname; }
            set { 
                if (firstname != value)
                {
                    firstname = value;
                    RaisePropertyChanged("FirstName");
                    RaisePropertyChanged("FullName");
                }
            }
        }

        public string LastName
        {
            get { return lastname; }
            set
            {
                if (lastname != value)
                {
                    lastname = value;
                    RaisePropertyChanged("FirstName");
                    RaisePropertyChanged("FullName");
                }
            }
        }

        public string FullName
        {
            get
            {
                return firstname + " " + lastname;
            }
        }


        public event PropertyChangedEventHandler? PropertyChanged;
        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
