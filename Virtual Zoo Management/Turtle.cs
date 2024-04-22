using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Zoo_Management
{
    public class Turtle : Animal, IFeedable, IMovable
    {

        public Turtle(string name, int age) : base(name, age)
        {

        }

        public void Feed(string food)
        {
            Console.WriteLine($"{Name} is eating {food}.");
        }


        public override void Sleep()
        {
            Console.WriteLine($"The {Name} is sleeping underwater.");
        }

        public override void Speak()
        {
            Console.WriteLine($"the {Name} squirts");
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} crawls slowly.");
        }


    }
}
