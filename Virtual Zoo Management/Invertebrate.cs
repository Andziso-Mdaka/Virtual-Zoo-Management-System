using static Virtual_Zoo_Management.Animal;
using Virtual_Zoo_Management;

public class Invertebrate : Animal, IMovable, IFeedable
{
    public Invertebrate(string name, int age, AnimalType type, HabitatType habitat, DietInfo diet)
        : base(name, age, type, habitat, diet)
    {
    }

    public override void Move()
    {
        MessageBox.Show($"{Name} is crawling.");
    }

    public override void Speak()
    {
        MessageBox.Show($"{Name} is making a clicking sound.");
    }



    public void Feed(string food)
    {
        MessageBox.Show($"{Name} is eating leafy algae.");
    }
}