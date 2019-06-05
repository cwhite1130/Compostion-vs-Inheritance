using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAssignment
{
    class DoesNotFly : ICanFly
    {
        public bool CanFly() { return false; }
    }
}
