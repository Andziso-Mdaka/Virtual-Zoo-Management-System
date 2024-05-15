using static Virtual_Zoo_Management.Animal;
using Virtual_Zoo_Management;

public class Mammal : Animal, IMovable
{
    public Mammal(string name, int age, AnimalType type, HabitatType habitat, DietInfo diet)
        : base(name, age, type, habitat, diet)
    {
    }

    public override void Eat()
    {
        MessageBox.Show($"{Name} is eating.");
    }

    public override void Eat(string food)
    {
        throw new NotImplementedException();
    }

    public override void Move()
    {
        MessageBox.Show($"{Name} is walking.");
    }

    public override void Speak()
    {
        MessageBox.Show($"{Name} is making a sound.");
    }

}