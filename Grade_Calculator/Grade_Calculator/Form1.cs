using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grade_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (txtFinal.Text != null && txtMidterm != null)
            {
                double midtermGrade = Convert.ToDouble(txtMidterm.Text);
                double finalGrade = Convert.ToDouble(txtFinal.Text);

                double gpa = midtermGrade * 0.4 + finalGrade * 0.6;

                txtGpa.Text = gpa.ToString();

            }
        }
    }
}
