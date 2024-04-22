using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Zoo_Management
{
    // Define IFeedable interface
    public interface IFeedable
    {
        void Feed(string food);
    }

    // Define IMovable interface
    public interface IMovable
    {
        void Move();
    }

    public class Animal
    {

        public string Name { get; set; }
        public int Age { get; set; }


        public Animal(string name, int age)
        {
            Name = name;
            Age = age;

        }


        public virtual void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }

        public virtual void Eat(string food)
        {
            Console.WriteLine($"{Name} is eating {food}.");
        }


        public virtual void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping.");
        }

        public virtual void Speak()
        {
            Console.WriteLine($"{Name} makes this sound");
        }

        public virtual void Move()
        {
            Console.WriteLine($"{Name} is moving.");
        }
    }

}
