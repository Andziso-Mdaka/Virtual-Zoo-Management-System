using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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


    public abstract class Animal
    {
        private string _name;
        private int _age;
        private AnimalType _type;
        private HabitatType _habitat;
        private DietInfo _diet;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                try
                {
                    if (value <= 0)
                    {
                        throw new InvalidAnimalAgeException($"Age cannot be zero or less than zero.");
                    }
                    _age = value;
                }
                catch (InvalidAnimalAgeException e)
                {
                    MessageBox.Show(e.Message);
                }

            }
        }


        public AnimalType Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public HabitatType Habitat
        {
            get { return _habitat; }
            set { _habitat = value; }
        }

        public DietInfo Diet
        {
            get { return _diet; }
            set { _diet = value; }
        }

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
        public abstract void Eat(string food);
        

        public virtual void Sleep()
        {
            MessageBox.Show($"{Name} is sleeping.");
        }

        // animal sound method
        public abstract void Speak();


        // move animal method
        public abstract void Move();
       

        public struct DietInfo
        {
            private FoodType _foodType;
            private string _dietaryRequirements;
            private string _feedingSchedule;

            public FoodType FoodType
            {
                get { return _foodType; }
                set { _foodType = value; }
            }

            public string DietaryRequirements
            {
                get { return _dietaryRequirements; }
                set { _dietaryRequirements = value; }
            }

            public string FeedingSchedule
            {
                get { return _feedingSchedule; }
                set { _feedingSchedule = value; }
            }

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