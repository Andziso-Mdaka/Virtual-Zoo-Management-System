using static Virtual_Zoo_Management.Animal;
using Virtual_Zoo_Management;

public class Reptile : Animal, IClimbable
{
    public Reptile(string name, int age, AnimalType type, HabitatType habitat, DietInfo diet)
        : base(name, age, type, habitat, diet)
    {
    }

    public override void Eat()
    {
        MessageBox.Show($"{Name} is eating.");
    }

    public override void Move()
    {
        MessageBox.Show($"{Name} is slithering.");
    }

    public override void Speak()
    {
       MessageBox.Show($"{Name} is hissing.");
    }

    public void Climb()
    {
        MessageBox.Show($"{Name} is climbing.");
    }
}