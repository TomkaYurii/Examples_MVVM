using DataContextExamples.Models;

namespace DataContextExamples.ViewModels
{
    public class EnvironmentViewModel
    {
        public EnvironmentData EnviroData { get; set; }

        public EnvironmentViewModel(EnvironmentData environmentData)
        {
            EnviroData = environmentData;
        }
    }
}