using System;
using System.Collections.Generic;
using System.Text;

namespace Critter
{
    class Affinity
    {
        public enum Etype
        {
            Fire,
            Wind,
            Water,
            Earth,
            Dark,
            Light
        }

        private Etype typecritter;

        public Etype Typecritter { get => typecritter; }
    }
}
