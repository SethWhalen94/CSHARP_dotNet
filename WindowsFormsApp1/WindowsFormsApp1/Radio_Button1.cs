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
    public partial class Radio_Button1 : Form
    {
        public Radio_Button1()
        {
            InitializeComponent();
        }

        private void Radio_Button1_Load(object sender, EventArgs e)
        {
            //radioButton1.Checked = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("'Checked' Changed");
        }
    }
}
