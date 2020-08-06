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
        private string affinitycritter;
        private int hp;

        private Critter critter;
        private Skill skill;

        public string Name { get => name; }
        public int BaseAttack { get => baseAttack; set => baseAttack = value; }
        public int BaseDefense { get => basedefense; set => basedefense = value; }
        public int Moveset { get => moveset; set => moveset = value; }
        public string Affinitycritter { get => affinitycritter; set => affinitycritter = value; }
        public int Hp { get => hp; set => hp = value; }

        private void setSkill()
        {
            
        }

    }
}
