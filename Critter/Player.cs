using System;
using System.Collections.Generic;
using System.Text;

namespace Critter
{
    class Player
    {
        private List<Critter> critter;
        public string Name { get; private set; }
        internal List<Critter> Critter { get => critter; set => critter = value; }

        /*public Player(string name)
        {
            Name = name;
        }*/

        Critter critter1 = new Critter();
        Critter critter2 = new Critter();
        Critter critter3 = new Critter();

        public void FillCritter()
        {
            critter1.CalculatedStats();
            critter2.CalculatedStats();
            critter3.CalculatedStats();
            critter.Add(critter1);
            critter.Add(critter2);
            critter.Add(critter3);
        }
    }
}
