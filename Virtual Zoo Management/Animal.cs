using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Zoo_Management
{
    // Define IFeedable interface
    public interface IFeedable
    {
        void Feed(string food);
    }

    // Define IMovable interface
    public interface IMovable
    {
        void Move();
    }

    public interface IClimbable
    {
        void Climb();
    }

    public interface ISwimmable
    {
        void Swim();
    }

    public interface IFlyable
    {
        void Fly();
    }

    // Custom exception for handling invalid food types
    public class InvalidFoodException : Exception
    {
        public InvalidFoodException(string message) : base(message)
        {
        }
    }

    public class Animal
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public AnimalType Type { get; set; }
        public HabitatType Habitat { get; set; }
        public DietInfo Diet { get; set; }

        // Constructor
        public Animal(string name, int age, AnimalType type, HabitatType habitat, DietInfo diet)
        {
            Name = name;
            Age = age;
            Type = type;
            Habitat = habitat;
            Diet = diet;
        }



        //Eat method
        public virtual void Eat()
        {
            MessageBox.Show($"{Name} is eating.");
        }

        // Overloaded Eat method
        public virtual void Eat(string food)
        {
            MessageBox.Show($"{Name} is eating {food}.");
        }


        public virtual void Sleep()
        {
            MessageBox.Show($"{Name} is sleeping.");
        }
        // animal sound method

        public virtual void Speak()
        {
            MessageBox.Show($"{Name} makes this sound");
        }

        // move animal method
        public virtual void Move()
        {
            MessageBox.Show($"{Name} is moving.");
        }



        public struct DietInfo
        {
            public FoodType FoodType;
            public string DietaryRequirements;
            public string FeedingSchedule;

            public DietInfo(FoodType foodType, string dietaryRequirements, string feedingSchedule)
            {
                FoodType = foodType;
                DietaryRequirements = dietaryRequirements;
                FeedingSchedule = feedingSchedule;
            }
        }

        public enum AnimalType
        {
            Mammal,
            Bird,
            Reptile,
            Amphibian,
            Fish,
            Invertebrate,
            Lion,
            Parrot,
            Carnivore,
            Turtle

        }

        public enum FoodType
        {
            Meat,
            Vegetation,
            Mixed
        }

        public enum HabitatType
        {
            Desert,
            Forest,
            Aquatic,
            Savanna,
            Arctic,
            Tropical
        }
    }

}
