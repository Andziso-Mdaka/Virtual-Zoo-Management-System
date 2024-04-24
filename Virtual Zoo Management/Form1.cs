namespace Virtual_Zoo_Management
{
    public partial class Form1 : Form
    {
        private List<Animal> animals = new List<Animal>();
        public Form1()
        {

            InitializeComponent();
        }

        // method to update animal list into the ListBox
        private void UpdateAnimalListBox()
        {
            animalsListBox.Items.Clear();
            foreach (var animal in animals)
            {
                animalsListBox.Items.Add($"{animal.Name} ({animal.GetType().Name}), Age: {animal.Age}");
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // add default animals into the ListBox when the form loads 
            Lion lion = new Lion("Simba", 5);
            Parrot parrot = new Parrot("Polly", 2);
            Turtle turtle = new Turtle("Bulbasuar", 10);

            animals.Add(lion);
            animals.Add(parrot);
            animals.Add(turtle);
            foreach (var animal in animals)
            {
                animalsListBox.Items.Add($"{animal.Name} ({animal.GetType().Name}), Age: {animal.Age}");
            }

            ageNumericUpDown.Value = 0;
            animalTypeComboBox.SelectedIndex = 0;

        }

        private void AddAnimalButton_Click_1(object sender, EventArgs e)
        {
            // recieve user input
            string name = animalNameTextBox.Text;
            int age = (int)ageNumericUpDown.Value;
            string type = animalTypeComboBox.SelectedItem.ToString();


            // adding the new animal
            Animal animal;
            if (name == "")
            {
                MessageBox.Show("enter a name!");
            }
            else
            {
                switch (type)
                {
                    case "Carnivore":
                        animal = new Carnivore(name, age);
                        break;
                    case "Bird":
                        animal = new Bird(name, age);
                        break;
                    case "Aquatic":
                        animal = new Aquatic(name, age);
                        break;
                    default:
                        MessageBox.Show("Invalid animal type.");
                        return;
                }

                animals.Add(animal);
                UpdateAnimalListBox();
                MessageBox.Show($"{name} has been added");
            }



        }

        // function to invoke the behaviour of different animals

        private void InvokeBehaviorButton_Click_1(object sender, EventArgs e)
        {

            if (animalsListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an animal.");
                return;
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
            selectedAnimal.Eat("food");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (animalsListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an animal.");
                return;
            }

            Animal selectedAnimal = animals[animalsListBox.SelectedIndex];
            selectedAnimal.Move();


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
    }
}
