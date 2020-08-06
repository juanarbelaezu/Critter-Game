using System;
using System.Collections.Generic;
using System.Text;

namespace Critter
{
    class Skill
    {
        private string name;
        private Affinity affinity;
        private bool supportSkill;
        private int power;

        public string Name { get => name; }
        public bool SupportSkill { get => supportSkill; }
        public int Power { get => power; set => power = value; }
    }
}
