using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Virtual_Zoo_Management
{

    public class Aquatic : Animal, IFeedable, IMovable
    {

        public Aquatic(string name, int age) : base(name, age)
        {

        }

        public void Feed(string food)
        {
            MessageBox.Show($"{Name} is eating {food}.");
        }

        public override void Sleep()
        {
            MessageBox.Show($"the {Name} is sleeping in the water");
        }

        public override void Speak()
        {
            MessageBox.Show($"the {Name} is speaking");
        }

        public override void Move()
        {
            MessageBox.Show($"{Name} is swimming");
        }
    }
}
