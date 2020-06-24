using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Employee personelDetail = new Employee();

        private void btnSetValue_Click(object sender, EventArgs e)
        {
            Employee personelDetail = new Employee();
            personelDetail.EmployeeID = Convert.ToInt32(txtEmployeeId.Text);
            personelDetail.Name = txtName.Text;
            personelDetail.Age = Convert.ToInt32(txtAge.Text);

            MessageBox.Show("Employee ID: " + personelDetail.EmployeeID + "\nName: " + personelDetail.Name + "\n Age: " + personelDetail.Age);

        }

        private void txtEmployeeId_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtEmployeeId_KeyPress(object sender, KeyPressEventArgs e)
        {
            //  Only allow numbers to be typed
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //  Only allow letters to be typed
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            //  Only allow numbers to be typed
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            personelDetail.EmployeeID = Convert.ToInt32(txtEmployeeId.Text);
            personelDetail.Name = txtName.Text;
            personelDetail.Age = Convert.ToInt32(txtAge.Text);

            //  Create a new Form2 object
            Form2 frm = new Form2();
            frm.personelDetail = personelDetail;
            frm.ShowDialog();
        }
    }
}
