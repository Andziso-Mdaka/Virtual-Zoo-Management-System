namespace Virtual_Zoo_Management
{
    partial class AnimalBehaviour
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimalBehaviour));
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            animalsListBox = new ListBox();
            InvokeBehaviorButton = new Button();
            button4 = new Button();
            label6 = new Label();
            groupBox1 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dietTextBox = new TextBox();
            habitatTextBox = new TextBox();
            typeTextBox = new TextBox();
            ageTextBox = new TextBox();
            nameTextBox = new TextBox();
            button5 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Font = new Font("Impact", 7.8F);
            button3.Location = new Point(110, 469);
            button3.Name = "button3";
            button3.Size = new Size(94, 34);
            button3.TabIndex = 20;
            button3.Text = "Remove Animal";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Impact", 7.8F);
            button2.Location = new Point(110, 406);
            button2.Name = "button2";
            button2.Size = new Size(94, 39);
            button2.TabIndex = 19;
            button2.Text = "Move";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Impact", 7.8F);
            button1.Location = new Point(110, 340);
            button1.Name = "button1";
            button1.Size = new Size(94, 37);
            button1.TabIndex = 18;
            button1.Text = "Feed";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // animalsListBox
            // 
            animalsListBox.Font = new Font("Impact", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            animalsListBox.FormattingEnabled = true;
            animalsListBox.ItemHeight = 17;
            animalsListBox.Location = new Point(170, 112);
            animalsListBox.Name = "animalsListBox";
            animalsListBox.Size = new Size(797, 123);
            animalsListBox.TabIndex = 16;
            // 
            // InvokeBehaviorButton
            // 
            InvokeBehaviorButton.Font = new Font("Impact", 7.8F);
            InvokeBehaviorButton.Location = new Point(110, 279);
            InvokeBehaviorButton.Name = "InvokeBehaviorButton";
            InvokeBehaviorButton.Size = new Size(94, 37);
            InvokeBehaviorButton.TabIndex = 15;
            InvokeBehaviorButton.Text = "Speak";
            InvokeBehaviorButton.UseVisualStyleBackColor = true;
            InvokeBehaviorButton.Click += InvokeBehaviorButton_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(23, 26);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 21;
            button4.Text = "back";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.LightCyan;
            label6.Location = new Point(379, 57);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(368, 29);
            label6.TabIndex = 22;
            label6.Text = "Invole zoo animal behaviour";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dietTextBox);
            groupBox1.Controls.Add(habitatTextBox);
            groupBox1.Controls.Add(typeTextBox);
            groupBox1.Controls.Add(ageTextBox);
            groupBox1.Controls.Add(nameTextBox);
            groupBox1.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(253, 255);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(783, 321);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Animal Information";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Location = new Point(6, 47);
            label5.Name = "label5";
            label5.Size = new Size(82, 37);
            label5.TabIndex = 9;
            label5.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.WhiteSmoke;
            label4.Location = new Point(6, 182);
            label4.Name = "label4";
            label4.Size = new Size(72, 37);
            label4.TabIndex = 8;
            label4.Text = "Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.WhiteSmoke;
            label3.Location = new Point(18, 108);
            label3.Name = "label3";
            label3.Size = new Size(60, 37);
            label3.TabIndex = 7;
            label3.Text = "Age";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.WhiteSmoke;
            label2.Location = new Point(519, 42);
            label2.Name = "label2";
            label2.Size = new Size(60, 37);
            label2.TabIndex = 6;
            label2.Text = "Diet";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.WhiteSmoke;
            label1.Location = new Point(6, 250);
            label1.Name = "label1";
            label1.Size = new Size(92, 37);
            label1.TabIndex = 5;
            label1.Text = "Habitat";
            // 
            // dietTextBox
            // 
            dietTextBox.Location = new Point(353, 105);
            dietTextBox.Multiline = true;
            dietTextBox.Name = "dietTextBox";
            dietTextBox.ScrollBars = ScrollBars.Both;
            dietTextBox.Size = new Size(411, 186);
            dietTextBox.TabIndex = 4;
            // 
            // habitatTextBox
            // 
            habitatTextBox.Location = new Point(114, 243);
            habitatTextBox.Name = "habitatTextBox";
            habitatTextBox.Size = new Size(173, 44);
            habitatTextBox.TabIndex = 3;
            // 
            // typeTextBox
            // 
            typeTextBox.Location = new Point(114, 175);
            typeTextBox.Name = "typeTextBox";
            typeTextBox.Size = new Size(173, 44);
            typeTextBox.TabIndex = 2;
            // 
            // ageTextBox
            // 
            ageTextBox.Location = new Point(114, 108);
            ageTextBox.Name = "ageTextBox";
            ageTextBox.Size = new Size(173, 44);
            ageTextBox.TabIndex = 1;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(114, 42);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(173, 44);
            nameTextBox.TabIndex = 0;
            // 
            // button5
            // 
            button5.Font = new Font("Impact", 7.8F);
            button5.Location = new Point(110, 527);
            button5.Name = "button5";
            button5.Size = new Size(94, 35);
            button5.TabIndex = 24;
            button5.Text = "Display";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // AnimalBehaviour
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1150, 689);
            Controls.Add(button5);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(animalsListBox);
            Controls.Add(InvokeBehaviorButton);
            Name = "AnimalBehaviour";
            Text = "AnimalBehaviour";
            Load += AnimalBehaviour_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private ListBox animalsListBox;
        private Button InvokeBehaviorButton;
        private Button button4;
        private Label label6;
        private GroupBox groupBox1;
        private Button button5;
        private TextBox dietTextBox;
        private TextBox habitatTextBox;
        private TextBox typeTextBox;
        private TextBox ageTextBox;
        private TextBox nameTextBox;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}