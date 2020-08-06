using System;
using System.Collections.Generic;
using System.Text;

namespace Critter
{
    class Critter
    {
        private string name;
        private int baseAttack;
        private int basedefense;
        private int moveset;
        private int hp;

        private Critter critter;

        public string Name { get => name; }
        public int BaseAttack { get => baseAttack; set => baseAttack = value; }
        public int BaseDefense { get => basedefense; set => basedefense = value; }
        public int Moveset { get => moveset; set => moveset = value; }
        public int Hp { get => hp; set => hp = value; }

    }
}
