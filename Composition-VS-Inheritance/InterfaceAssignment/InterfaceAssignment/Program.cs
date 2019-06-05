using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet cat = new Pet(new IsAMammal(), new DoesNotFly());
            Pet bird = new Pet(new IsNotAMammal(), new DoesFly());

            System.Threading.Thread.Sleep(5000);

        }
    }
}
