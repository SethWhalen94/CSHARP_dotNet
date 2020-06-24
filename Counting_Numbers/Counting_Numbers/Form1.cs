using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Counting_Numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        int firstNumber = 0, lastNumber = 0;

        int divisibleTerm = 1;
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbDivisibleTerm.Items.Add("2");
            cmbDivisibleTerm.Items.Add("3");
            cmbDivisibleTerm.Items.Add("4");
            cmbDivisibleTerm.Items.Add("5");
            cmbDivisibleTerm.Items.Add("6");
            cmbDivisibleTerm.Items.Add("7");
            cmbDivisibleTerm.Items.Add("8");
            cmbDivisibleTerm.Items.Add("9");
            cmbDivisibleTerm.Items.Add("10");
        }

        private void cmbDivisibleTerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            divisibleTerm = Convert.ToInt32(cmbDivisibleTerm.SelectedItem);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //  Variables for Count Button event
        int controlNumber = 1;

        private void txtStartFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void rbBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBlack.Checked)
            {
                rbRed.Checked = false;
                rbBlue.Checked = false;
                rbGreen.Checked = false;
                txtDivisibleNumbers.ForeColor = Color.Black;
            }
        }

        private void rbRed_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRed.Checked)
            {
                rbBlack.Checked = false;
                rbBlue.Checked = false;
                rbGreen.Checked = false;
                txtDivisibleNumbers.ForeColor = Color.Red;
            }
        }

        private void rbGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGreen.Checked)
            {
                rbRed.Checked = false;
                rbBlue.Checked = false;
                rbBlack.Checked = false;
                txtDivisibleNumbers.ForeColor = Color.Green;
            }
        }

        private void rbBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBlue.Checked)
            {
                rbRed.Checked = false;
                rbBlack.Checked = false;
                rbGreen.Checked = false;
                txtDivisibleNumbers.ForeColor = Color.Blue;
            }
        }

        private void chBold_CheckedChanged(object sender, EventArgs e)
        {
            if (chBold.Checked)
            {
                txtDivisibleNumbers.Font = new Font(txtDivisibleNumbers.Font.FontFamily, txtDivisibleNumbers.Font.Size, FontStyle.Bold);
                chUnderline.Checked = false;
                chItalic.Checked = false;
            }
            else
                txtDivisibleNumbers.Font = new Font(txtDivisibleNumbers.Font.FontFamily, txtDivisibleNumbers.Font.Size, FontStyle.Regular);
        }

        private void chUnderline_CheckedChanged(object sender, EventArgs e)
        {
            if (chUnderline.Checked)
            {
                txtDivisibleNumbers.Font = new Font(txtDivisibleNumbers.Font.FontFamily, txtDivisibleNumbers.Font.Size, FontStyle.Underline);
                chBold.Checked = false;
                chItalic.Checked = false;
            }
            else
                txtDivisibleNumbers.Font = new Font(txtDivisibleNumbers.Font.FontFamily, txtDivisibleNumbers.Font.Size, FontStyle.Regular);
        }

        private void chItalic_CheckedChanged(object sender, EventArgs e)
        {
            if (chItalic.Checked)
            {
                txtDivisibleNumbers.Font = new Font(txtDivisibleNumbers.Font.FontFamily, txtDivisibleNumbers.Font.Size, FontStyle.Italic);
                chBold.Checked = false;
                chUnderline.Checked = false;
            }
            else
                txtDivisibleNumbers.Font = new Font(txtDivisibleNumbers.Font.FontFamily, txtDivisibleNumbers.Font.Size, FontStyle.Regular);
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            string divisibleNumber = "";

            //  Check If text boxes are empty
            if (txtStartFrom.Text.Trim() == "" || txtTo.Text.Trim() == "")
            {
                MessageBox.Show("Please fill the neccessary fields");
            }
            //  Check if combo box has a selected item
            else if (cmbDivisibleTerm.SelectedIndex==-1)
            {
                MessageBox.Show("Please select a divisible term");
            }

            //  Else run the code
            else
            {

                //if (!int.TryParse(txtStartFrom.Text, out firstNumber))
                //    MessageBox.Show("Please enter an integer in 'Start From' Text box");
                //if (!int.TryParse(txtTo.Text, out lastNumber))
                //    MessageBox.Show("Please enter an integer in 'To' Text box");

                firstNumber = Convert.ToInt32(txtStartFrom.Text);
                lastNumber = Convert.ToInt32(txtTo.Text);
                

                for (int i = firstNumber; i < lastNumber; i++)
                {
                    if (i % divisibleTerm == 0)
                    {
                        divisibleNumber += i.ToString() + " ";

                        if (controlNumber % 10 == 0)
                            divisibleNumber += Environment.NewLine;
                        controlNumber++;
                    }

                }

                txtDivisibleNumbers.Text = divisibleNumber;

                //MessageBox.Show("Divisible "+ divisibleTerm + " From " + firstNumber + " To " + lastNumber);
            }
        }
    }
}
