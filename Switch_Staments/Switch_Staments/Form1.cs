using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch_Staments
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            //int x = 6;
            string messageText = "";

            switch (Convert.ToInt32(textBox1.Text))
            {
                case 2:
                    messageText = "x = 2";
                    break;
                case 4:
                    messageText = "x = 4";
                    break;
                case 6:
                    messageText = "x = 6";
                    switch(Convert.ToInt32(textBox2.Text))
                    {
                        case 1:
                            messageText += " y = 1 ";
                            break;
                        case 2:
                            messageText += " y = 2 ";
                            break;
                        case 3:
                            messageText += " y = 3 ";
                            break;
                        default:
                            messageText += " y = ? ";
                            break;
                    }
                    break;
                case 8:
                    messageText = "x = 8";
                    break;
                default:
                    messageText = "x = ?";
                    break;

            }

            MessageBox.Show(messageText);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
