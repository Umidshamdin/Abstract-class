using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_1
{
    public abstract class Plant
    {
        public int Age { get; set; }
        public string Type { get; set; }
        public string Trunk { get; set; }


        public abstract void Breathe();
        
        



    }
}
