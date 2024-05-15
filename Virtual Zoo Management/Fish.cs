using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Virtual_Zoo_Management
{
    //animal subclass
    public class Fish : Animal, IFeedable, ISwimmable
    {

        public Fish(string name, int age, AnimalType type, HabitatType habitat, DietInfo diet)
       : base(name, age, type, habitat, diet) { }
        

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

        public void Swim()
        {
            MessageBox.Show($"{Name} is swimming");
        }
    }
}
