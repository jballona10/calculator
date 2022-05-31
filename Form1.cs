using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bonk
{
    public partial class Form1 : Form
    {

        int firstNum = 0;

        public Form1()
        {
            InitializeComponent();

         
        }




        private void numButton_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (resultsTextBox.TextLength > 8)
            {
                return;
            }
            else
            {
                if (resultsTextBox.Text == "0" && button.Text != "0")
                {
                    resultsTextBox.Text = button.Text;
                }
                else
                {
                    resultsTextBox.Text += button.Text;
                }
            }

        }

        private void addButton_Click(object sender, EventArgs e)
        { 
            firstNum = Int32.Parse(resultsTextBox.Text);
            resultsTextBox.Text = "0";
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
          
            resultsTextBox.Text = (firstNum + Int32.Parse(resultsTextBox.Text)).ToString();
            firstNum = 0;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            firstNum = 0;
            resultsTextBox.Text = "0";
        }
    }


}
