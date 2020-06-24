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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //textBox1 Key press event
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Key Press event, digit only
            //if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            //{
            //    e.Handled = true;
            //}

            ////  only allow one decimal point
            //if((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') >-1 ) )
            //{
            //    e.Handled = true;
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string label_text = textBox1.Text;
            label1.Text = label_text;
        }
    }
}
