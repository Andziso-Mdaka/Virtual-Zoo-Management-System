using static Virtual_Zoo_Management.Animal;
using Virtual_Zoo_Management;

public class Amphibian : Animal, IClimbable, IFeedable
{
    public Amphibian(string name, int age, AnimalType type, HabitatType habitat, DietInfo diet)
        : base(name, age, type, habitat, diet)
    {
    }

    public override void Speak()
    {

        MessageBox.Show($"{Name} clicks and hisses");
        
    }

    public void Climb()
    {
        MessageBox.Show($"{Name} climbs");
    }

    public void Feed(string food)
    {
        MessageBox.Show($"{Name} is eating bugs");
    }

    public override void Eat(string food)
    {
        throw new NotImplementedException();
    }

    public override void Move()
    {
        throw new NotImplementedException();
    }
}