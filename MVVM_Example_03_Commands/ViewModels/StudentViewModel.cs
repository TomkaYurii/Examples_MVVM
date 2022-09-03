using MVVM_Example_04_Commands.Commands;
using MVVM_Example_04_Commands.Models;
using System.Collections.ObjectModel;

namespace MVVM_Example_04_Commands.ViewModels
{
    public class StudentViewModel
    {
        public MyCommand DeleteCommand { get; set; }

        public StudentViewModel()
        {
            LoadStudents();
            DeleteCommand = new MyCommand(OnDelete, CanDelete);
        }

        public ObservableCollection<Student> Students { get; set; }

        public void LoadStudents()
        {
            ObservableCollection<Student> students = new ObservableCollection<Student>();

            students.Add(new Student { FirstName = "SS", LastName = "DD"});
            students.Add(new Student { FirstName = "AA", LastName = "XX" });
            students.Add(new Student { FirstName = "ZZ", LastName = "MM" });

            Students = students;
        }


        private Student _selectedStudent;
        public Student SelectedStudent
        {
            get { return _selectedStudent; }
            set { _selectedStudent = value;
                DeleteCommand.RaiseCanExecuteChanged();
            }
        }


        private void OnDelete()
        {
            Students.Remove(SelectedStudent);
        }

        private bool CanDelete()
        {
            return SelectedStudent != null;
        }
    }
}
