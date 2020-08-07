using System;
using System.Collections.Generic;
using System.Text;

namespace Critter
{
    class Critter : Affinity
    {
        private string name;
        private float baseAttack;
        private float basedefense;
        private float attack;
        private float defense;
        private float speed;
        private float baseSpeed;
        private int moveset;
        private string affinitycritter;
        private float hp;
        private int counterA;
        private int counterD;
        private int counterS;

        private Skill skill;

        public string Name { get => name; }
        public float BaseAttack { get => baseAttack; set => baseAttack = value; }
        public float BaseDefense { get => basedefense; set => basedefense = value; }
        public int Moveset { get => moveset; set => moveset = value; }
        public string Affinitycritter { get => affinitycritter; set => affinitycritter = value; }
        public float Hp { get => hp; set => hp = value; }
        public float BaseSpeed { get => baseSpeed; set => baseSpeed = value; }
        public float Attack { get => attack; set => attack = value; }
        public float Defense { get => defense; set => defense = value; }
        public float Speed { get => speed; set => speed = value; }
        public int CounterS { get => counterS; set => counterS = value; }
        public int CounterD { get => counterD; set => counterD = value; }
        public int CounterA { get => counterA; set => counterA = value; }
        internal Skill Skill { get => skill;}
        /*internal Affinity Affinity { get => affinity;}*/

        public void CalculatedStats()
        {
            Random rnd = new Random();
            baseAttack = rnd.Next(10, 100);
            basedefense = rnd.Next(10, 100);
            baseSpeed = rnd.Next(1, 50);
            attack = baseAttack;
            defense = basedefense;
            speed = baseSpeed;

            Array value = Etype.GetValues(typeof(Etype));
            Random random = new Random();
            int i = (int)value.GetValue(random.Next(value.Length));
            affinitycritter = i.ToString();
            Console.WriteLine("Affinidad del Critter" + affinitycritter);

            skill = new Skill();
            skill.Affinitycal();
            skill.Givepowe();
        }


    }
}
