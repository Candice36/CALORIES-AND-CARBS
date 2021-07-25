using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALORIES_AND_CARBS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double fatCalories(double fatGrams)
        {
            return fatGrams * 9;
        }

        private double carbCalories(double carbGrams)
        {
            return carbGrams * 4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double calFromFat, fatGrams, calFromCarbs, carbsGrams;
            if(double.TryParse(fatTextBox.Text, out fatGrams))
            {
                calFromFat = fatGrams * 9;
                calFatTextBox.Text = calFromFat.ToString("n1");
            }
            else
            {
                MessageBox.Show("Enter a valid numbers for Fat Grams");
            }
            if(double.TryParse(carbsTextBox.Text, out carbsGrams))
            {
                calFromCarbs = carbsGrams * 4;
                calCarbsTextBox.Text = calFromCarbs.ToString("n1");
            }
            else
            {
                MessageBox.Show("Enter a valid for Carb Grams");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
