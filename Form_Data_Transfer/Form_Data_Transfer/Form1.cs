using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Data_Transfer
{
    public partial class frmGetData : Form
    {
        public frmGetData()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtNAme.Text;
            string surname = txtSurname.Text;
            string nameSurname = name + surname;

            //Create a new frmShowData object
            frmShowData frmShow = new frmShowData();

            frmShow.lblNameSurname.Text = nameSurname;
            //Allow access to both forms
            //frmShow.Show();

            //Allow acces to only Show Form
            frmShow.ShowDialog();
        }
    }
}
