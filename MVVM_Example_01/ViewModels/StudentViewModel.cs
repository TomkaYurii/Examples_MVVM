using MVVM_Example_01.Models;
using System.Collections.ObjectModel;

namespace MVVM_Example_01.ViewModels
{
    public class StudentViewModel
    {
        public ObservableCollection<Student> Students { get; set; }
        public void LoadStudents()
        {
            ObservableCollection<Student> students = new ObservableCollection<Student>();

            students.Add(new Student { FirstName = "SS", LastName = "DD"});
            students.Add(new Student { FirstName = "AA", LastName = "XX" });
            students.Add(new Student { FirstName = "ZZ", LastName = "MM" });

            Students = students;

        }
    }
}
