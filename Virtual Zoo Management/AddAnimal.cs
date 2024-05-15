using static Virtual_Zoo_Management.Animal;

namespace Virtual_Zoo_Management
{
    public partial class AddAnimal : Form
    {
        public List<Animal> animals = new List<Animal>();

        public AddAnimal(List<Animal> animals)
        {
            InitializeComponent();
            this.animals = animals; // Use the passed animals list

            // Fill the habitatComboBox with HabitatType enum values
            habitatComboBox.DataSource = Enum.GetValues(typeof(HabitatType));

            // Fill the foodTypeComboBox with FoodType enum values
            foodTypeComboBox.DataSource = Enum.GetValues(typeof(FoodType));
        }
        private bool IsCarnivoreWithVegetationDiet(AnimalType type, FoodType foodType)
        {
            return (type == AnimalType.Carnivore || type == AnimalType.Lion) && foodType == FoodType.Vegetation;
        }

        private bool IsIncompatibleHabitat(AnimalType type, HabitatType habitat)
        {
            switch (type)
            {
                case AnimalType.Amphibian:
                    return habitat == HabitatType.Arctic || habitat == HabitatType.Desert;
                case AnimalType.Fish:
                    return habitat == HabitatType.Savanna || habitat == HabitatType.Desert;
                // Add more cases for other animal types and habitats as needed
                default:
                    return false;
            }
        }

        private void AddAnimalButton_Click_1(object sender, EventArgs e)
        {
            // Receive user input
            string name = animalNameTextBox.Text;
            int age = (int)ageNumericUpDown.Value;
            AnimalType type = (AnimalType)animalTypeComboBox.SelectedIndex;
            HabitatType habitat = (HabitatType)habitatComboBox.SelectedIndex;
            FoodType foodType = (FoodType)foodTypeComboBox.SelectedIndex;
            string dietaryRequirements = dietaryComboBox.Text;
            string feedingSchedule = feedingTextBox.Text;

            // Adding the new animal
            Animal animal;

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter a name!");
                return;
            }

            if (habitat == HabitatType.Desert && habitatComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a habitat!");
                return;
            }

            if (foodType == FoodType.Meat && foodTypeComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a food type!");
                return;
            }

            if (string.IsNullOrWhiteSpace(dietaryRequirements))
            {
                MessageBox.Show("Please enter dietary requirements!");
                return;
            }

            if (string.IsNullOrWhiteSpace(feedingSchedule))
            {
                MessageBox.Show("Please enter a feeding schedule!");
                return;
            }

            try
            {
                // Check for invalid age
                if (age <= 0)
                {
                    throw new InvalidAnimalAgeException($"Age cannot be zero or less than zero.");
                }
                // Check for invalid diet based on animal type
                if (IsCarnivoreWithVegetationDiet(type, foodType))
                {
                    throw new InvalidDietException($"Carnivores cannot have a {FoodType.Vegetation} diet.");
                }

                if (IsIncompatibleHabitat(type, habitat))
                {
                    throw new IncompatibleHabitatException($"{type} cannot live in {habitat} habitat.");
                }

                switch (type)
                {
                    case AnimalType.Mammal:
                        animal = new Mammal(name, age, type, habitat, new DietInfo(foodType, dietaryRequirements, feedingSchedule));
                        break;
                    case AnimalType.Bird:
                        animal = new Bird(name, age, type, habitat, new DietInfo(foodType, dietaryRequirements, feedingSchedule));
                        break;
                    case AnimalType.Reptile:
                        animal = new Reptile(name, age, type, habitat, new DietInfo(foodType, dietaryRequirements, feedingSchedule));
                        break;
                    case AnimalType.Amphibian:
                        animal = new Amphibian(name, age, type, habitat, new DietInfo(foodType, dietaryRequirements, feedingSchedule));
                        break;
                    case AnimalType.Fish:
                        animal = new Fish(name, age, type, habitat, new DietInfo(foodType, dietaryRequirements, feedingSchedule));
                        break;
                    case AnimalType.Lion:
                        animal = new Lion(name, age, type, habitat, new DietInfo(foodType, dietaryRequirements, feedingSchedule));
                        break;
                    case AnimalType.Parrot:
                        animal = new Parrot(name, age, type, habitat, new DietInfo(foodType, dietaryRequirements, feedingSchedule));
                        break;
                    case AnimalType.Invertebrate:
                        animal = new Invertebrate(name, age, type, habitat, new DietInfo(foodType, dietaryRequirements, feedingSchedule));
                        break;
                    case AnimalType.Turtle:
                        animal = new Turtle
                            (name, age, type, habitat, new DietInfo(foodType, dietaryRequirements, feedingSchedule));
                        break;
                    default:
                        MessageBox.Show("Invalid animal type.");
                        return;
                }

                animals.Add(animal);
                MessageBox.Show($"{name} has been added");

                // Clear the text boxes
                animalNameTextBox.Clear();
                ageNumericUpDown.Value = ageNumericUpDown.Minimum;
                animalTypeComboBox.SelectedIndex = -1;
                habitatComboBox.SelectedIndex = -1;
                foodTypeComboBox.SelectedIndex = -1;
                dietaryComboBox.Clear();
                feedingTextBox.Clear();
            }
            catch (InvalidDietException ex)
            {
                MessageBox.Show(ex.Message, "Invalid Diet", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IncompatibleHabitatException ex)
            {
                MessageBox.Show(ex.Message, "Incompatible Habitat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidAnimalAgeException ex)
            {
                MessageBox.Show(ex.Message, "Invalid Age", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<Animal> GetAnimalsList()
        {
            return animals;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}