using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Virtual_Zoo_Management
{

    public class Bird : Animal, IFeedable, IMovable
    {

        public Bird(string name, int age) : base(name, age)
        {

        }

        public void Feed(string food)
        {
            Console.WriteLine($"{Name} is eating {food}.");
        }

        public override void Sleep()
        {
            Console.WriteLine($"the {Name} is sleeping in the shade.");
        }

        public override void Speak()
        {
            Console.WriteLine($"the {Name} roars");
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} walks majestically.");
        }
    }
}
