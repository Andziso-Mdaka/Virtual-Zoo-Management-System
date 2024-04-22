using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Virtual_Zoo_Management
{

    public class Lion : Animal, IFeedable, IMovable
    {

        public Lion(string name, int age) : base(name, age)
        {

        }

        public void Feed(string food)
        {
            MessageBox.Show($"{Name} is eating {food}.");
        }

        public override void Sleep()
        {
            MessageBox.Show($"the {Name} is sleeping in the shade.");
        }

        public override void Speak()
        {
            MessageBox.Show($"the {Name} roars");
        }

        public override void Move()
        {
            MessageBox.Show($"{Name} walks majestically.");
        }
    }
}
