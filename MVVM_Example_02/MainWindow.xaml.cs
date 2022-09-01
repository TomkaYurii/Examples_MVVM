using System.Windows;
using DataContextExamples.ViewModels;

namespace DataContextExamples
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly TankViewModel _tankViewModel;
        private readonly EnvironmentViewModel _enviroViewModel;
        public MainWindow(TankViewModel tankvm, EnvironmentViewModel envirovm)
        {
            _tankViewModel = tankvm;
            _enviroViewModel = envirovm;

            InitializeComponent();
            Tank1StackPanel.DataContext = _tankViewModel.Tank1;
            Tank2StackPanel.DataContext = _tankViewModel.Tank2;
            EnviroStackPanel.DataContext = _enviroViewModel;
        }
    }
}
