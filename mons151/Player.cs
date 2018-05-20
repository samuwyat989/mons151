using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mons151
{
    public class Player
    {
        public int score, mins, sec;
        public string name;
        public Player(string _name, int _score, int _mins, int _sec)
        {
            name = _name;
            score = _score;
            mins = _mins;
            sec = _sec;
        }
    }
}
