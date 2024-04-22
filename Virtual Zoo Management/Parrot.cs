using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Zoo_Management
{
    public class Parrot : Animal, IFeedable, IMovable
    {

        public Parrot(string name, int age) : base(name, age)
        {

        }

        public void Feed(string food)
        {
            Console.WriteLine($"{Name} is eating {food}.");
        }

        public override void Sleep()
        {
            Console.WriteLine($"the {Name} is sleeping on its perch.");
        }

        public override void Speak()
        {
            Console.WriteLine($"the {Name} tweets");
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} flies gracefully.");
        }



    }
}
