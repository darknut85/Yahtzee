using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    public class Settings
    {
        public bool Y1 { get; set; }
        public bool Y2 { get; set; }
        public bool Y3 { get; set; }
        public bool Y4 { get; set; }

        public bool Lock1 { get; set; }
        public bool Lock2 { get; set; }
        public bool Lock3 { get; set; }
        public bool Lock4 { get; set; }
        public bool Lock5 { get; set; }

        public int D1 { get; set; }
        public int D2 { get; set; }
        public int D3 { get; set; }
        public int D4 { get; set; }
        public int D5 { get; set; }

        public int TurnCount { get; set; }
        public int Players { get; set; }
        public int PlayerNumber { get; set; }
    }
}
