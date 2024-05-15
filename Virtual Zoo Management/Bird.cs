using static Virtual_Zoo_Management.Animal;
using System.Xml.Linq;
using Virtual_Zoo_Management;

public class Bird : Animal, IFeedable,IFlyable
{
    public Bird(string name, int age, AnimalType type, HabitatType habitat, DietInfo diet)
        : base(name, age, type, habitat, diet)
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
        MessageBox.Show($"The {Name} is sleeping in the tree.");
    }

    // animal sound method
    public override void Speak()
    {
        MessageBox.Show($"The {Name} tweets.");
    }

    public void Fly()
    {
        MessageBox.Show($"{Name} is flying.");
    }
}