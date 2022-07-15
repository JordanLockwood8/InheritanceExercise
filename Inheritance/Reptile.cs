using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public Reptile(bool IsAlive, int NumberLegs,int Age, string Name, bool venomous, double length, bool haveLegs, bool removeableTail)
        {
            Venomous = venomous;
            Length = length;
            HaveLegs = haveLegs;
            RemoveableTail = removeableTail;
        }

        public bool Venomous { get; set; }
        public double Length { get; set; }
        public bool HaveLegs { get; set; }
        public bool RemoveableTail { get; set; }
    }
}
