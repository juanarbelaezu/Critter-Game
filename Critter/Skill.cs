using System;
using System.Collections.Generic;
using System.Text;

namespace Critter
{
    class Skill
    {
        private string name;
        private Affinity affinity;
        private bool supportSkill = true;
        private float power;

        public string Name { get => name; }
        public bool SupportSkill { get => supportSkill; }
        public float Power { get => power; set => power = value; }

        public void Givepowe()
        {                  
            Random rnd = new Random();

            if(supportSkill == false)
            {
                power = rnd.Next(1, 10);
            }
            else if(supportSkill)
            {
                power = 0;
            }
        }


    }
}
