using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    class Cat: Pet
    {
        public override bool canFly() { return false; }

        public override string makeNoise() { return "Meow"; }

        public override bool isMammal() { return true; }

        public override int getBodyTemp() { return 99; }
    }
}
