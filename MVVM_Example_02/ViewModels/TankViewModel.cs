using DataContextExamples.Models;

namespace DataContextExamples.ViewModels
{
    public class TankViewModel
    {
        public TankData Tank1 { get; set; }

        public TankData Tank2 { get; set; }
        public TankViewModel(TankData tankData1, TankData tankData2)
        {
            Tank1 = tankData1;
            Tank1.Initialize("Tank1");
            Tank2 = tankData2;
            Tank2.Initialize("Tank2");

        }
    }
}
