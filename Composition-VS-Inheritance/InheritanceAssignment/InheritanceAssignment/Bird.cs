using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    class Bird: Pet
    {
        public override bool canFly() { return true; }

        public override string makeNoise() { return "Chirp"; }

        public override bool isMammal() { return false; }

        public override int getBodyTemp() { return 105; }

    }
}
