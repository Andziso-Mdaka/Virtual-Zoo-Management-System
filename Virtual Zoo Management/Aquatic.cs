using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Virtual_Zoo_Management
{
    //animal subclass
    public class Aquatic : Animal, IFeedable, IMovable
    {

        public Aquatic(string name, int age) : base(name, age)
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
            MessageBox.Show($"the {Name} is sleeping in the water");
        }

        //animal sound method
        public override void Speak()
        {
            MessageBox.Show($"the {Name} is speaking");
        }

        // move animal method
        public override void Move()
        {
            MessageBox.Show($"{Name} is swimming");
        }
    }
}
