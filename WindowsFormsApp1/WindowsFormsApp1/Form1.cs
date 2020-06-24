using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }

        private void mainform_Load(object sender, EventArgs e)
        {
            //========Message Box=============
            string message1 = "Do you want to close this window?";
            string message_title1 = "Close window";

            //Adding Yes/No buttons to message box
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            //MessageBox.Show(message1, message_title1);
            DialogResult result = MessageBox.Show(message1, message_title1, buttons, MessageBoxIcon.Information);

            if(result == DialogResult.Yes)      //Check if 'Yes' was clicked
            {
                this.Close();
            }
            else if(result == DialogResult.No)  //Check if 'No' was clicked
            {
                //Do nothing
            }

            //First button functionality

            //first_button.Text = "changed";
        }

        //================= First Button Functions =====================//
        private void first_button_Click(object sender, EventArgs e)
        {
            first_button.Text = "Clicked";
            //MessageBox.Show("Hello");
        }

        private void first_button_KeyPress(object sender, KeyPressEventArgs e)
        {
            first_button.Text = "Enter";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "First Label";
            label1.BackColor = Color.Red;
            label1.ForeColor = Color.White;
        }
    }
}
