using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Functions;

namespace MyCalc
{
    public partial class Form1 : Form
    {
        
        private Operations operations = new Operations();

        private Values values = new Values();

        public bool CleanText = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void one_Click(object sender, EventArgs e)
        {
            MainBox.Text = Keyboard.KeyboardEntries("1", MainBox.Text);
           
        }

        private void two_Click(object sender, EventArgs e)
        {
            MainBox.Text = Keyboard.KeyboardEntries("2", MainBox.Text);
            values.SetValue(double.Parse(MainBox.Text));
        }

        private void three_Click(object sender, EventArgs e)
        {
            MainBox.Text = Keyboard.KeyboardEntries("3", MainBox.Text);
        }

        private void four_Click(object sender, EventArgs e)
        {
            MainBox.Text = Keyboard.KeyboardEntries("4", MainBox.Text);
        }

        private void five_Click(object sender, EventArgs e)
        {
            MainBox.Text = Keyboard.KeyboardEntries("5", MainBox.Text);
        }

        private void six_Click(object sender, EventArgs e)
        {
            MainBox.Text = Keyboard.KeyboardEntries("6", MainBox.Text);
        }

        private void seven_Click(object sender, EventArgs e)
        {
            MainBox.Text = Keyboard.KeyboardEntries("7", MainBox.Text);
        }

        private void eight_Click(object sender, EventArgs e)
        {
            MainBox.Text = Keyboard.KeyboardEntries("8", MainBox.Text);
        }

        private void nine_Click(object sender, EventArgs e)
        {
            MainBox.Text = Keyboard.KeyboardEntries("9", MainBox.Text);
        }

        private void zero_Click(object sender, EventArgs e)
        {
            MainBox.Text = Keyboard.KeyboardEntries("0", MainBox.Text);
        }

        private void plus_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(MainBox.Text))
            {
                MainBox.Text = Keyboard.KeyboardEntries("+", MainBox.Text);
            }
            else
            {
                values.SetValue(double.Parse(MainBox.Text));
                MainBox.Clear();
                values.Operator = "+";
            }
            
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(MainBox.Text))
            {
                MainBox.Text = Keyboard.KeyboardEntries("-", MainBox.Text);
            }
            else
            {
                values.SetValue(double.Parse(MainBox.Text));
                MainBox.Clear();
                values.Operator = "-";
            }
        }

        private void times_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(MainBox.Text))
            {
                MessageBox.Show("Por favor, digite os valores a serem multiplicados.") ;
            }
            else
            {
                values.SetValue(double.Parse(MainBox.Text));
                MainBox.Clear();
                values.Operator = "*";
            }
        }

        private void division_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(MainBox.Text))
            {
                MessageBox.Show("Por favor, digite os valores a serem divididos.");
            }
            else
            {
                values.SetValue(double.Parse(MainBox.Text));
                MainBox.Clear();
                values.Operator = "/";
            }
        }

        private void equals_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(MainBox.Text))
            {
                MainBox.Text = String.Empty;
            }
            else
            {
                values.SetValue(double.Parse(MainBox.Text));
                MainBox.Clear();
                try
                {
                    values = operations.Calculate(values);
                    MainBox.Text = values.Result.ToString();
                }
                catch (DivideByZeroException)
                {
                    MessageBox.Show("Não é possível dividir por zero");
                }

                values.Operator = String.Empty;
            }

            
        }

        private void delete_Click(object sender, EventArgs e)
        {
            MainBox.Clear();
            values.FirstNumber = 0;
            values.SecondNumber = 0;
            values.Operator = String.Empty;

        }

        private void Comma_Click(object sender, EventArgs e)
        {
            MainBox.Text = Keyboard.KeyboardEntries(",", MainBox.Text);
        }
    }
}
