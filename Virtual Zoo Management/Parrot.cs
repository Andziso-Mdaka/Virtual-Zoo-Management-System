using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Zoo_Management
{
    public class Parrot : Animal, IFeedable ,IFlyable
    {

        public Parrot(string name, int age, AnimalType type, HabitatType habitat, DietInfo diet) : base(name, age, type, habitat, diet)
        {

        }
        // Feed animals method
        public void Feed(string food)
        {
            MessageBox.Show($"{Name} is eating {food}.");
        }
        // animal sleep method
        public override void Sleep()
        {
            MessageBox.Show($"{Name} is sleeping in the tree.");
        }
        //animal sound method
        public override void Speak()
        {
            MessageBox.Show($"{Name} tweets");
        }
        // move animal method

        public void Fly()
        {
            MessageBox.Show($"{Name} flies.");
        }

        public override void Eat(string food)
        {
            throw new NotImplementedException();
        }

        public override void Move()
        {
            throw new NotImplementedException();
        }
    }
}
