using System;
using System.Collections.Generic;
using System.Text;

namespace Critter
{
    class Critter
    {
        private string name;
        private float baseAttack;
        private float basedefense;
        private float baseSpeed;
        private int moveset;
        private string affinitycritter;
        private float hp;

        private Skill skill;
        private Affinity affinity;

        public string Name { get => name; }
        public float BaseAttack { get => baseAttack; set => baseAttack = value; }
        public float BaseDefense { get => basedefense; set => basedefense = value; }
        public int Moveset { get => moveset; set => moveset = value; }
        public string Affinitycritter { get => affinitycritter; set => affinitycritter = value; }
        public float Hp { get => hp; set => hp = value; }
        public float BaseSpeed { get => baseSpeed; set => baseSpeed = value; }
        internal Skill Skill { get => skill;}
        internal Affinity Affinity { get => affinity;}

        private void Calculatedam()
        {
            Random rnd = new Random();
            baseAttack = rnd.Next(10, 100);
            basedefense = rnd.Next(10, 100);
            baseSpeed = rnd.Next(1, 50);
        }


    }
}
