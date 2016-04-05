using System;
using System.Windows.Forms;

namespace Calculator_UI
{
    public partial class Calc : Form
    {
        private string calculation;
        private Python_Accessor.Python_Script script = new Python_Accessor.Python_Script("calc_interface.py");
        public Calc()
        {
            InitializeComponent();
            calculation = "";
        }

        private void One_Click(object sender, EventArgs e)
        {
            calculation += "1";
            MainTextBox.Text = calculation;
        }

        private void Two_Click(object sender, EventArgs e)
        {
            calculation += "2";
            MainTextBox.Text = calculation;
        }

        private void Three_Click(object sender, EventArgs e)
        {
            calculation +=  "3";
            MainTextBox.Text = calculation;
        }

        private void Four_Click(object sender, EventArgs e)
        {
            calculation += "4";
            MainTextBox.Text = calculation;
        }

        private void Five_Click(object sender, EventArgs e)
        {
            calculation +=  "5";
            MainTextBox.Text = calculation;
        }

        private void Siz_Click(object sender, EventArgs e)
        {
            calculation += "6";
            MainTextBox.Text = calculation;
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            calculation += "7";
            MainTextBox.Text = calculation;
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            calculation += "8";
            MainTextBox.Text = calculation;
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            calculation += "9";
            MainTextBox.Text = calculation;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            calculation += " + ";
            MainTextBox.Text = calculation;
        }

        private void Subtract_Click(object sender, EventArgs e)
        {
            calculation += " - ";
            MainTextBox.Text = calculation;
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            calculation += " * ";
            MainTextBox.Text = calculation;
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            calculation += " / ";
            MainTextBox.Text = calculation;
        }

        //Deletes one line from the string
        private void delete_Click(object sender, EventArgs e)
        {
            if (calculation != "")
            {
                calculation = calculation.Substring(0, calculation.Length - 1);
                MainTextBox.Text = calculation;
            }
        }

        private void Check_Click(object sender, EventArgs e)
        {
            MainTextBox.Text = script.Run("test_verify", calculation);
        }

        private void Eval_Click(object sender, EventArgs e)
        {
            
            MainTextBox.Text = script.Call_Function("calc_pure_string", calculation, true);
        }

        private void space_Click(object sender, EventArgs e)
        {
            calculation += " ";
            MainTextBox.Text = calculation;
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            calculation += "0";
            MainTextBox.Text = calculation;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            calculation = " ";
            MainTextBox.Text = calculation;
        }
    }
}
