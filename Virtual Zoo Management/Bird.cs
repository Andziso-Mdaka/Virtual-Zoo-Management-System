using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Virtual_Zoo_Management
{
    // Animal 
    public class Bird : Animal, IFeedable, IMovable
    {

       
        public Bird(string name, int age) : base(name, age)
        {

        }

        // feed animal method
        public void Feed(string food)
        {
            MessageBox.Show($"{Name} is eating {food}.");
        }

        // animal sleep method
        public override void Sleep()
        {
            MessageBox.Show($"the {Name} is sleeping in the tree");
        }

        //animal sound method
        public override void Speak()
        {
            MessageBox.Show($"the {Name} tweets");
        }


        // animla move method
        public override void Move()
        {
            MessageBox.Show($"{Name} is flyng");
        }
    }
}
