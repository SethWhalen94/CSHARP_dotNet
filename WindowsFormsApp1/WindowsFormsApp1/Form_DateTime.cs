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
    public partial class Form_DateTime : Form
    {
        public Form_DateTime()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime birthday = dateTimePicker1.Value;
            //MessageBox.Show(birthday.ToString());

            label1.Text = birthday.AddYears(2).ToShortDateString();
            label2.Text = birthday.AddYears(-2).ToShortDateString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToShortDateString());
        }
    }
}
