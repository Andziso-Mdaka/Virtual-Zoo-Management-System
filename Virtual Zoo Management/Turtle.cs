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
        // Feed animals method
        public void Feed(string food)
        {
            MessageBox.Show($"{Name} is eating {food}.");
        }
        // animal sleep method
        public override void Sleep()
        {
            MessageBox.Show($"{Name} is sleeping in the water.");
        }
        //animal sound method
        public override void Speak()
        {
            MessageBox.Show($"{Name} yells");
        }
        // move animal method
        public override void Move()
        {
            MessageBox.Show($"{Name} is swimming.");
        }


    }
}
