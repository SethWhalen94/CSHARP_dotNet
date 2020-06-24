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
    public partial class Form_comboBox : Form
    {
        public Form_comboBox()
        {
            InitializeComponent();
        }

        private void Form_comboBox_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Today");
            comboBox1.Items.Add("Yesterday");
            //comboBox1.SelectedIndex = 0;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selected_item = comboBox1.SelectedItem.ToString();
            MessageBox.Show(selected_item);


            int value_order = comboBox1.SelectedIndex;
            MessageBox.Show(value_order.ToString());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = "Combo box selected index changed";
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            label2.Text = "Combo box selected value has changed";
        }
    }
}
