using System;
using System.Collections.Generic;
using System.Text;

namespace GameRPG
{
    abstract class Stats
    {
        public string name { get; set; }
        public string profession { get; set; }
        public int health { get; set; }
        public int strenght { get; set; }
        public int accuracy { get; set; }
        public int magicpower { get; set; }
        public int armor { get; set; }
        public int magicarmor { get; set; }
        public int armorpenetration { get; set; }
        public int magicpenetration { get; set; }
    }
}
