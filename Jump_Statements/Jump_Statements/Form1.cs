﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jump_Statements
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBreak_Click(object sender, EventArgs e)
        {
            string ivalue = "";

            for (int i = 0; i < 5; i++)
            {
                if (i == 4)
                    break;
                ivalue += " " + i + " ";
            }
            MessageBox.Show(ivalue);
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            string ivalue = "";

            for (int i = 0; i < 5; i++)
            {
                if (i == 1)
                    continue;
                ivalue += " " + i + " ";
            }
            MessageBox.Show(ivalue);
        }

        private void btnGoTo_Click(object sender, EventArgs e)
        {
            string messageText = "";
            int x;
            
            if(int.TryParse(textBox1.Text, out x))  //Check if textbox1 contains a integer or not
            //x = Convert.ToInt32(textBox1.Text);

            switch (x)
            {
                case 1:
                    messageText = "You entered 1";
                    break;
                case 2:
                    messageText = "You entered 2";
                    break;
                case 3:
                    messageText = "You entered 3";
                    goto case 2;
                default:
                    messageText = "you entered 4";
                    break;
            }
            MessageBox.Show(messageText);
        }
    }
}
