using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Bird : Animal
    {
        public Bird()
        {
        
        }
      

        public bool CanFly { get; set; } = true;
        public int WingSpan { get; set; }

        public string SoundMade { get; set; }   
        public bool Raptor { get; set; }

    }
}
