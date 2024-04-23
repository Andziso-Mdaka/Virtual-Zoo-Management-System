namespace Virtual_Zoo_Management
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            InvokeBehaviorButton = new Button();
            animalNameTextBox = new TextBox();
            AddAnimalButton = new Button();
            ageNumericUpDown = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            animalTypeComboBox = new ComboBox();
            animalsListBox = new ListBox();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)ageNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // InvokeBehaviorButton
            // 
            InvokeBehaviorButton.Location = new Point(796, 274);
            InvokeBehaviorButton.Name = "InvokeBehaviorButton";
            InvokeBehaviorButton.Size = new Size(163, 29);
            InvokeBehaviorButton.TabIndex = 0;
            InvokeBehaviorButton.Text = "Invoke Behaviour";
            InvokeBehaviorButton.UseVisualStyleBackColor = true;
            InvokeBehaviorButton.Click += InvokeBehaviorButton_Click_1;
            // 
            // animalNameTextBox
            // 
            animalNameTextBox.Location = new Point(177, 184);
            animalNameTextBox.Name = "animalNameTextBox";
            animalNameTextBox.Size = new Size(125, 27);
            animalNameTextBox.TabIndex = 1;
            // 
            // AddAnimalButton
            // 
            AddAnimalButton.Location = new Point(176, 302);
            AddAnimalButton.Name = "AddAnimalButton";
            AddAnimalButton.Size = new Size(94, 29);
            AddAnimalButton.TabIndex = 2;
            AddAnimalButton.Text = "Add";
            AddAnimalButton.UseVisualStyleBackColor = true;
            AddAnimalButton.Click += AddAnimalButton_Click_1;
            // 
            // ageNumericUpDown
            // 
            ageNumericUpDown.Location = new Point(177, 241);
            ageNumericUpDown.Name = "ageNumericUpDown";
            ageNumericUpDown.Size = new Size(150, 27);
            ageNumericUpDown.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(71, 184);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 4;
            label1.Text = "Animal Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(71, 248);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 5;
            label2.Text = "Animal Age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(71, 137);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 6;
            label3.Text = "Animal Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(177, 81);
            label4.Name = "label4";
            label4.Size = new Size(131, 20);
            label4.TabIndex = 7;
            label4.Text = "Add a new Animal";
            // 
            // animalTypeComboBox
            // 
            animalTypeComboBox.FormattingEnabled = true;
            animalTypeComboBox.Items.AddRange(new object[] { "Carnivore", "Bird", "Aquatic" });
            animalTypeComboBox.Location = new Point(176, 137);
            animalTypeComboBox.Name = "animalTypeComboBox";
            animalTypeComboBox.Size = new Size(151, 28);
            animalTypeComboBox.TabIndex = 8;
            // 
            // animalsListBox
            // 
            animalsListBox.FormattingEnabled = true;
            animalsListBox.Location = new Point(764, 124);
            animalsListBox.Name = "animalsListBox";
            animalsListBox.Size = new Size(233, 144);
            animalsListBox.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(796, 81);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 10;
            label5.Text = "Animals";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FloralWhite;
            label6.Location = new Point(255, 23);
            label6.Name = "label6";
            label6.Size = new Size(620, 29);
            label6.TabIndex = 11;
            label6.Text = "Welcome to the Virtual Zoo Management System!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1062, 483);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(animalsListBox);
            Controls.Add(animalTypeComboBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ageNumericUpDown);
            Controls.Add(AddAnimalButton);
            Controls.Add(animalNameTextBox);
            Controls.Add(InvokeBehaviorButton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)ageNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button InvokeBehaviorButton;
        private TextBox animalNameTextBox;
        private Button AddAnimalButton;
        private NumericUpDown ageNumericUpDown;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox animalTypeComboBox;
        private ListBox animalsListBox;
        private Label label5;
        private Label label6;
    }
}
