using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet dog = new Dog();
            Pet cat = new Cat();
            Pet bird = new Bird();

             System.Console.WriteLine(dog.canFly());
             System.Console.WriteLine(dog.makeNoise());
             System.Console.WriteLine(dog.isMammal());
             System.Console.WriteLine(dog.getBodyTemp());

             System.Console.WriteLine(cat.canFly());
             System.Console.WriteLine(cat.makeNoise());
             System.Console.WriteLine(cat.isMammal());
             System.Console.WriteLine(cat.getBodyTemp());

             System.Console.WriteLine(bird.canFly());
             System.Console.WriteLine(bird.makeNoise());
             System.Console.WriteLine(bird.isMammal());
             System.Console.WriteLine(bird.getBodyTemp()); 
            
            System.Threading.Thread.Sleep(5000);
        }
    }
}
