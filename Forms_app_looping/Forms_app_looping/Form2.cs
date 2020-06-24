using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_app_looping
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnForLoop_Click(object sender, EventArgs e)
        {
            string iValue = "";

            for (int i=0; i<10; i++)
            {
                for (int k = 0; k < 8; k++)
                {
                    richTextBox1.Text += "i= " + i + "k= " + k + Environment.NewLine;
                }

                iValue += " " + i + " ";
            }

            MessageBox.Show(iValue);
        }
    }
}
