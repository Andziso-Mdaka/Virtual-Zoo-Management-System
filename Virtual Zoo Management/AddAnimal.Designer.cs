namespace Virtual_Zoo_Management
{
    partial class AddAnimal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAnimal));
            animalNameTextBox = new TextBox();
            AddAnimalButton = new Button();
            ageNumericUpDown = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            animalTypeComboBox = new ComboBox();
            button4 = new Button();
            habitatComboBox = new ComboBox();
            foodTypeComboBox = new ComboBox();
            dietaryComboBox = new TextBox();
            feedingTextBox = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)ageNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // animalNameTextBox
            // 
            animalNameTextBox.Font = new Font("Stencil", 7.8F);
            animalNameTextBox.Location = new Point(592, 200);
            animalNameTextBox.Name = "animalNameTextBox";
            animalNameTextBox.Size = new Size(172, 23);
            animalNameTextBox.TabIndex = 1;
            // 
            // AddAnimalButton
            // 
            AddAnimalButton.Font = new Font("Stencil", 7.8F);
            AddAnimalButton.Location = new Point(386, 398);
            AddAnimalButton.Name = "AddAnimalButton";
            AddAnimalButton.Size = new Size(291, 47);
            AddAnimalButton.TabIndex = 2;
            AddAnimalButton.Text = "Add";
            AddAnimalButton.UseVisualStyleBackColor = true;
            AddAnimalButton.Click += AddAnimalButton_Click_1;
            // 
            // ageNumericUpDown
            // 
            ageNumericUpDown.Font = new Font("Stencil", 7.8F);
            ageNumericUpDown.Location = new Point(592, 269);
            ageNumericUpDown.Name = "ageNumericUpDown";
            ageNumericUpDown.Size = new Size(172, 23);
            ageNumericUpDown.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Stencil", 7.8F);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(461, 203);
            label1.Name = "label1";
            label1.Size = new Size(92, 16);
            label1.TabIndex = 4;
            label1.Text = "Animal Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Stencil", 7.8F);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(469, 268);
            label2.Name = "label2";
            label2.Size = new Size(81, 16);
            label2.TabIndex = 5;
            label2.Text = "Animal Age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Stencil", 7.8F);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(461, 144);
            label3.Name = "label3";
            label3.Size = new Size(89, 16);
            label3.TabIndex = 6;
            label3.Text = "Animal Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Stencil", 7.8F);
            label4.Location = new Point(844, 339);
            label4.Name = "label4";
            label4.Size = new Size(0, 16);
            label4.TabIndex = 7;
            // 
            // animalTypeComboBox
            // 
            animalTypeComboBox.Font = new Font("Stencil", 7.8F);
            animalTypeComboBox.FormattingEnabled = true;
            animalTypeComboBox.Items.AddRange(new object[] { "Mammal", "Bird", "Reptile", "Amphibian", "Fish", "Invertebrate", "Lion", "Parrot", "Carnivore", "Turtle" });
            animalTypeComboBox.Location = new Point(592, 141);
            animalTypeComboBox.Name = "animalTypeComboBox";
            animalTypeComboBox.Size = new Size(170, 24);
            animalTypeComboBox.TabIndex = 8;
            // 
            // button4
            // 
            button4.Font = new Font("Stencil", 7.8F);
            button4.Location = new Point(21, 27);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 15;
            button4.Text = "back";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // habitatComboBox
            // 
            habitatComboBox.Font = new Font("Stencil", 7.8F);
            habitatComboBox.FormattingEnabled = true;
            habitatComboBox.Location = new Point(240, 144);
            habitatComboBox.Name = "habitatComboBox";
            habitatComboBox.Size = new Size(151, 24);
            habitatComboBox.TabIndex = 16;
            // 
            // foodTypeComboBox
            // 
            foodTypeComboBox.Font = new Font("Stencil", 7.8F);
            foodTypeComboBox.FormattingEnabled = true;
            foodTypeComboBox.Location = new Point(240, 203);
            foodTypeComboBox.Name = "foodTypeComboBox";
            foodTypeComboBox.Size = new Size(151, 24);
            foodTypeComboBox.TabIndex = 17;
            // 
            // dietaryComboBox
            // 
            dietaryComboBox.Font = new Font("Stencil", 7.8F);
            dietaryComboBox.Location = new Point(240, 261);
            dietaryComboBox.Name = "dietaryComboBox";
            dietaryComboBox.Size = new Size(151, 23);
            dietaryComboBox.TabIndex = 18;
            // 
            // feedingTextBox
            // 
            feedingTextBox.Font = new Font("Stencil", 7.8F);
            feedingTextBox.Location = new Point(240, 315);
            feedingTextBox.Name = "feedingTextBox";
            feedingTextBox.Size = new Size(151, 23);
            feedingTextBox.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Stencil", 7.8F);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(50, 144);
            label5.Name = "label5";
            label5.Size = new Size(63, 16);
            label5.TabIndex = 21;
            label5.Text = "habitat";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Stencil", 7.8F);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(50, 211);
            label6.Name = "label6";
            label6.Size = new Size(73, 16);
            label6.TabIndex = 22;
            label6.Text = "food type";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Stencil", 7.8F);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(50, 268);
            label7.Name = "label7";
            label7.Size = new Size(162, 16);
            label7.TabIndex = 23;
            label7.Text = "Dietary Requirements";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Stencil", 7.8F);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(50, 322);
            label8.Name = "label8";
            label8.Size = new Size(128, 16);
            label8.TabIndex = 24;
            label8.Text = "Feeding Schedule";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.RoyalBlue;
            label9.Location = new Point(419, 61);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(222, 29);
            label9.TabIndex = 25;
            label9.Text = "Add a new Animal";
            // 
            // AddAnimal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1094, 539);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(feedingTextBox);
            Controls.Add(dietaryComboBox);
            Controls.Add(foodTypeComboBox);
            Controls.Add(habitatComboBox);
            Controls.Add(button4);
            Controls.Add(animalTypeComboBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ageNumericUpDown);
            Controls.Add(AddAnimalButton);
            Controls.Add(animalNameTextBox);
            Name = "AddAnimal";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)ageNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox animalNameTextBox;
        private Button AddAnimalButton;
        private NumericUpDown ageNumericUpDown;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox animalTypeComboBox;
        private Button button4;
        private ComboBox habitatComboBox;
        private ComboBox foodTypeComboBox;
        private TextBox dietaryComboBox;
        private TextBox feedingTextBox;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}
