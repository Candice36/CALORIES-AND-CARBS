
namespace CALORIES_AND_CARBS
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.fatTextBox = new System.Windows.Forms.Label();
            this.carbsTextBox = new System.Windows.Forms.Label();
            this.calFatTextBox = new System.Windows.Forms.Label();
            this.calCarbsTextBox = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(471, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fatTextBox
            // 
            this.fatTextBox.AutoSize = true;
            this.fatTextBox.Location = new System.Drawing.Point(156, 57);
            this.fatTextBox.Name = "fatTextBox";
            this.fatTextBox.Size = new System.Drawing.Size(85, 13);
            this.fatTextBox.TabIndex = 2;
            this.fatTextBox.Text = "Enter gram of fat";
            // 
            // carbsTextBox
            // 
            this.carbsTextBox.AutoSize = true;
            this.carbsTextBox.Location = new System.Drawing.Point(156, 110);
            this.carbsTextBox.Name = "carbsTextBox";
            this.carbsTextBox.Size = new System.Drawing.Size(99, 13);
            this.carbsTextBox.TabIndex = 3;
            this.carbsTextBox.Text = "Enter gram of carbs";
            // 
            // calFatTextBox
            // 
            this.calFatTextBox.AutoSize = true;
            this.calFatTextBox.Location = new System.Drawing.Point(156, 168);
            this.calFatTextBox.Name = "calFatTextBox";
            this.calFatTextBox.Size = new System.Drawing.Size(82, 13);
            this.calFatTextBox.TabIndex = 4;
            this.calFatTextBox.Text = "Calories from fat";
            // 
            // calCarbsTextBox
            // 
            this.calCarbsTextBox.AutoSize = true;
            this.calCarbsTextBox.Location = new System.Drawing.Point(156, 232);
            this.calCarbsTextBox.Name = "calCarbsTextBox";
            this.calCarbsTextBox.Size = new System.Drawing.Size(96, 13);
            this.calCarbsTextBox.TabIndex = 5;
            this.calCarbsTextBox.Text = "Calories from carbs";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(471, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(471, 110);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(471, 168);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(471, 225);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.calCarbsTextBox);
            this.Controls.Add(this.calFatTextBox);
            this.Controls.Add(this.carbsTextBox);
            this.Controls.Add(this.fatTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Calories from Fat and Carbs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label fatTextBox;
        private System.Windows.Forms.Label carbsTextBox;
        private System.Windows.Forms.Label calFatTextBox;
        private System.Windows.Forms.Label calCarbsTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}

