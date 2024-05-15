using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Virtual_Zoo_Management
{
    public partial class AnimalBehaviour : Form
    {

        List<Animal> animals;
        public AnimalBehaviour(List<Animal> animals)
        {
            InitializeComponent();
            this.animals = animals; // Use the passed animals list
            UpdateAnimalListBox();
        }

        public void UpdateAnimalListBox()
        {
            animalsListBox.Items.Clear();
            foreach (var animal in animals)
            {
                animalsListBox.Items.Add($"{animal.Name} ({animal.GetType().Name}), Age: {animal.Age}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (animalsListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an animal.");
                return;
            }

            Animal selectedAnimal = animals[animalsListBox.SelectedIndex];
            animals.Remove(selectedAnimal);
            UpdateAnimalListBox();
            MessageBox.Show($"{selectedAnimal.Name} has been removed.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void InvokeBehaviorButton_Click(object sender, EventArgs e)
        {
            if (animalsListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an animal.");
                return;
            }

            if (animalsListBox.SelectedIndex >= animals.Count)
            {
                throw new AnimalNotFoundException($"Animal at index {animalsListBox.SelectedIndex} not found.");
            }

            Animal selectedAnimal = animals[animalsListBox.SelectedIndex];
            selectedAnimal.Speak();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (animalsListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an animal.");
                return;
            }

            Animal selectedAnimal = animals[animalsListBox.SelectedIndex];

            // Check if the selected animal implements IFeedable
            if (selectedAnimal is IFeedable feedable)
            {
                feedable.Feed("food");
            }
            else
            {
                selectedAnimal.Eat("food");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (animalsListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an animal.");
                return;
            }

            Animal selectedAnimal = animals[animalsListBox.SelectedIndex];

            // Check if the selected animal implements IMovable
            if (selectedAnimal is IMovable movable)
            {
                movable.Move();
            }
            else
            {
                // Check if the selected animal implements other interfaces
                if (selectedAnimal is IClimbable climbable)
                {
                    climbable.Climb();
                }
                else if (selectedAnimal is ISwimmable swimmable)
                {
                    swimmable.Swim();
                }
                else if (selectedAnimal is IFlyable flyable)
                {
                    flyable.Fly();
                }
                else
                {
                    MessageBox.Show($"{selectedAnimal.Name} does not have any movement-related behavior.");
                }
            }
        }

        private void AnimalBehaviour_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (animalsListBox.SelectedIndex != -1)
            {
                Animal selectedAnimal = animals[animalsListBox.SelectedIndex];

                // Update the controls with the selected animal's information
                nameTextBox.Text = selectedAnimal.Name;
                ageTextBox.Text = selectedAnimal.Age.ToString();
                typeTextBox.Text = selectedAnimal.Type.ToString();
                habitatTextBox.Text = selectedAnimal.Habitat.ToString();

                // Display diet information
                dietTextBox.Text = "Food Type: " + selectedAnimal.Diet.FoodType + "\n" +
                    "Dietary Requirements: " + selectedAnimal.Diet.DietaryRequirements + "\n" +
                    "Feeding Schedule: " + selectedAnimal.Diet.FeedingSchedule;

            }
            else
            {
                // Clear the controls if no animal is selected
                nameTextBox.Clear();
                ageTextBox.Clear();
                typeTextBox.Clear();
                habitatTextBox.Clear();
                dietTextBox.Clear();
            }

            if (animalsListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an animal.");
                return;
            }
        }
    }
}
