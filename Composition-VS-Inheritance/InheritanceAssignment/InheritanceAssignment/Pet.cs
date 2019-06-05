using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
   abstract class Pet
    {

        public abstract bool canFly();
        public abstract string makeNoise();
        public abstract bool isMammal();
        public abstract int getBodyTemp(); 
    }
}
