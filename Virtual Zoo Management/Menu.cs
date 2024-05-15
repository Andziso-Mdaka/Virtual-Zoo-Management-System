using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Virtual_Zoo_Management.Animal;

namespace Virtual_Zoo_Management
{
    public partial class Menu : Form
    {
        public List<Animal> Animals { get; set; } = new List<Animal>();
        public Menu()
        {
            InitializeComponent();

            // Initialize the Animals list with default animals
            DietInfo diet = new DietInfo(FoodType.Meat, "Requires fresh meat", "Twice a day");
            Lion lion = new Lion("Simba", 5, AnimalType.Mammal, HabitatType.Savanna, diet);
            Animals.Add(lion);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddAnimal addAnimal = new AddAnimal(Animals);
            addAnimal.ShowDialog();
            // No need to hide the Menu form
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AnimalBehaviour animalBehaviour = new AnimalBehaviour(Animals);
            animalBehaviour.Show();
            // No need to hide the Menu form
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
