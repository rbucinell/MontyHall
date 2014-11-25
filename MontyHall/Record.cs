using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MontyHall
{
    public class Record
    {
        public int pick, show, decide;
        public bool win;

        public Record(int pick, int show, int decide, bool win)
        {
            this.pick = pick;
            this.show = show;
            this.decide = decide;
            this.win = win;
        }

        public string[] GetItems()
        {
            return new[]{"#", pick.ToString(), show.ToString(), decide.ToString(), win.ToString()};
        }
    }
}
