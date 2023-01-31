using System.Collections.Generic;

namespace SlotsAutomationTesting.Core.Responses
{
    public class SpinResult
    {
        public int spinId { get; set; }
        public double balance { get; set; }
        public double winAmount { get; set; }
        public double odd { get; set; }
        public List<List<int>> result { get; set; }
        public int freeSpinCount { get; set; }
        public double oddMultiplayer { get; set; }
        public object bonusType { get; set; }
        public int validation { get; set; }
        
    }
}