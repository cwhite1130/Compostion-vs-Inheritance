using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAssignment
{
    class IsNotAMammal: IAmMammal
    {
        public bool IsMammal() { return false; }
    }
}
