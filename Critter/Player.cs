using System;
using System.Collections.Generic;
using System.Text;

namespace Critter
{
    class Player
    {
        private List<Critter> critter;
        public string Name { get; private set; }

        public Player(string name)
        {
            Name = name;
        }

        public void FillCritter(Critter newcritter)
        {
            critter.Add(newcritter);
        }
    }
}
