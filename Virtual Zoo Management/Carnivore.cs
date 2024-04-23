using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Virtual_Zoo_Management
{
    // animal subclass
    public class Carnivore : Animal, IFeedable, IMovable
    {

        public Carnivore(string name, int age) : base(name, age)
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
            MessageBox.Show($"the {Name} is sleeping in the shade.");
        }
        //animal sound method
        public override void Speak()
        {
            MessageBox.Show($"the {Name} yells");
        }
        // move animal method
        public override void Move()
        {
            MessageBox.Show($"{Name} walks on the ground.");
        }
    }
}
