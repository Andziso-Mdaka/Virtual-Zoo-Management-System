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

        //contructor
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;

        }

        //Eat method
        public virtual void Eat()
        {
            MessageBox.Show($"{Name} is eating.");
        }

        // Overloaded Eat method
        public virtual void Eat(string food)
        {
            MessageBox.Show($"{Name} is eating {food}.");
        }


        public virtual void Sleep()
        {
            MessageBox.Show($"{Name} is sleeping.");
        }
        // animal sound method

        public virtual void Speak()
        {
            MessageBox.Show($"{Name} makes this sound");
        }

        // move animal method
        public virtual void Move()
        {
            MessageBox.Show($"{Name} is moving.");
        }
    }

}
