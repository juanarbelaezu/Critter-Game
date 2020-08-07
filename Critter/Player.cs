using System;
using System.Collections.Generic;
using System.Text;

namespace Critter
{
    class Player
    {
        private List<Critter> critterList = new List<Critter>();
        internal List<Critter> CritterList { get => critterList; set => critterList = value; }

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
            critterList.Add(critter1);
            critterList.Add(critter2);
            critterList.Add(critter3);
        }
    }
}
