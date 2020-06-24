using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingLists
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> numberList = new List<int>();
        List<string> textList = new List<string>();
        List<Employee> employeeList = new List<Employee>();
        List<Days> comboList = new List<Days>();

        //void fillList()
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        numberList.Add(i+1);
        //    }

        //}

        public List<Employee> fillList()
        {
            employeeList.Clear();

            Employee employee1 = new Employee();
            employee1.ID = 1;
            employee1.Name = "Charles";
            employee1.Surname = "Dickens";

            Employee employee2 = new Employee();
            employee2.ID = 2;
            employee2.Name = "Sam";
            employee2.Surname = "Dickens";

            Employee employee3 = new Employee();
            employee3.ID = 3;
            employee3.Name = "Adam";
            employee3.Surname = "Dickens";

            employeeList.Add(employee1);
            employeeList.Add(employee2);
            employeeList.Add(employee3);

            return employeeList;

        }


        private void Form1_Load(object sender, EventArgs e)
        {

            comboList.Add(new Days() {ID= 1, textValue= "Monday" });
            comboList.Add(new Days() { ID = 2, textValue = "Tuesday"});
            comboList.Add(new Days() { ID = 3, textValue = "Wednesday" });
            comboList.Add(new Days() { ID = 4, textValue = "Thursday" });
            comboList.Add(new Days() { ID = 5, textValue = "Friday" });
            comboList.Add(new Days() { ID = 6, textValue = "Saturday" });
            comboList.Add(new Days() { ID = 7, textValue = "Sunday" });
            
            //  Give days list to combo box for data
            cmbDays.DataSource = comboList;
            cmbDays.ValueMember = "ID";
            cmbDays.DisplayMember = "textValue";

            dayList.DataSource = comboList;


        }

        private void btnFillList_Click(object sender, EventArgs e)
        {
            fillList();

            //foreach (var num in numberList)
            //{
            //    txtNumber.Text += num.ToString() + Environment.NewLine;
            //}

            foreach (var item in employeeList)
            {
                txtNumber.Text += item.Name + " " + item.Surname + " " + item.ID + Environment.NewLine;
            }

            //MessageBox.Show("List was filled");
        }

        private void cmbDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cmbDays.SelectedValue.ToString());
        }
    }
}
