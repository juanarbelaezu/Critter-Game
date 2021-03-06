﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Critter
{
    class Skill : Affinity
    {
        private bool supportSkill;
        private int skilltype;
        private float power;
        private string affinitySkill;

        public bool SupportSkill { get => supportSkill; }
        public float Power { get => power; set => power = value; }
        public int Skilltype { get => skilltype; set => skilltype = value; }
        public string AffinitySkill { get => affinitySkill; set => affinitySkill = value; }

        public void Givepowe()
        {                  
            Random rnd = new Random();
            supportSkill = rnd.Next(2) == 1;

            if (supportSkill == false)
            {
                power = rnd.Next(1, 10);
                Console.WriteLine("Poder = " + power);
            }
            else if(supportSkill)
            {
                power = 0;
                skilltype = rnd.Next(1, 3);
                Console.WriteLine("Critter de soporte, poder es " + power);
            }
        }

        public void Affinitycal()
        {
            Array value = Etype.GetValues(typeof(Etype));
            Random random = new Random();
            int i = (int)value.GetValue(random.Next(value.Length));
            affinitySkill = i.ToString();
        }
    }
}
