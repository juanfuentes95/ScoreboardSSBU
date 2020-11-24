using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreboardSSBU
{
    class Player
    {
        string name;
        string team;

        public Player()
        {
            this.name = "";
            this.team = "";
        }

        public Player(string name)
        {
            this.name = name;
            this.team = "";
        }

        public Player(string name, string team)
        {
            this.name = name;
            this.team = team;
        }

        public string Name { get; set; }
        public string Team { get; set; }
    }
}
