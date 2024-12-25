using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Restaurant_DB
{
    public partial class Manager : Form
    {
        Controller controllerobj = new Controller();
        string storedssn;
        public Manager(string ssn)
        {
            InitializeComponent();
            storedssn = ssn;
            DataTable dt = controllerobj.selectPosition();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember="Position";
            Salary_Man.KeyPress += new KeyPressEventHandler(Salary_Man_KeyPress);
            Working_Hours_Man.KeyPress += new KeyPressEventHandler(Working_Hours_Man_KeyPress);
        }
        
        
        private void Update_Manager_Click(object sender, EventArgs e)
        {
            int result = controllerobj.UpdateEmployee(Convert.ToInt16(MANAGER_SSN.Text), FName_Man.Text,LName_Man.Text,comboBox1.SelectedText,Convert.ToInt16( Working_Hours_Man.Text),Convert.ToDecimal(Salary_Man.Text),City_Man.Text,Street_Man.Text,Building_Man.Text,EPass_Man.Text);
            if (string.IsNullOrWhiteSpace(FName_Man.Text))
            {
                MessageBox.Show("This field cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FName_Man.Focus(); 
                
            }else if (string.IsNullOrWhiteSpace(LName_Man.Text))
            {
                MessageBox.Show("This field cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LName_Man.Focus();
            }
            else if (string.IsNullOrWhiteSpace(Working_Hours_Man.Text))
            {
                MessageBox.Show("This field cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Working_Hours_Man.Focus();

            }else if (string.IsNullOrWhiteSpace(Salary_Man.Text))
            {
                MessageBox.Show("This field cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Salary_Man.Focus();

            }
            else if (string.IsNullOrWhiteSpace(City_Man.Text))
            {
                MessageBox.Show("This field cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                City_Man.Focus();

            }
            else if (string.IsNullOrWhiteSpace(Street_Man.Text))
            {
                MessageBox.Show("This field cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Street_Man.Focus();

            }else if (string.IsNullOrWhiteSpace(Building_Man.Text))
            {
                MessageBox.Show("This field cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Building_Man.Focus();

            }
            else if (string.IsNullOrWhiteSpace(EPass_Man.Text))
            {
                MessageBox.Show("This field cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EPass_Man.Focus();

            }
        }
       private  void Salary_Man_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                label13.Visible = true;
                e.Handled = true;
            }

            // Allow only one decimal point
            if (e.KeyChar == '.' && Salary_Man.Text.Contains("."))
            {
                label13.Visible = true;
                e.Handled = true;
            }
        }
        private void Working_Hours_Man_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Check if the key pressed is a digit
            if (!char.IsDigit(e.KeyChar))
            {
                label14.Visible = true;
                e.Handled = true;
            }

            
        }
        private void Salary_Man_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Working_Hours_Man_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = controllerobj.UpdateEmployee(Convert.ToInt16(EMPLOYEE_SNN.Text), FName_Man.Text, LName_Man.Text, comboBox1.SelectedText, Convert.ToInt16(Working_Hours_Man.Text), Convert.ToDecimal(Salary_Man.Text), City_Man.Text, Street_Man.Text, Building_Man.Text, EPass_Man.Text);
            if (string.IsNullOrWhiteSpace(FName_Man.Text))
            {
                MessageBox.Show("First Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FName_Man.Focus();

            }
            else if (string.IsNullOrWhiteSpace(LName_Man.Text))
            {
                MessageBox.Show("Last Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LName_Man.Focus();
            }
            else if (string.IsNullOrWhiteSpace(Working_Hours_Man.Text))
            {
                MessageBox.Show(" working Hours cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Working_Hours_Man.Focus();

            }
            else if (string.IsNullOrWhiteSpace(Salary_Man.Text))
            {
                MessageBox.Show("Salary field cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Salary_Man.Focus();

            }
            else if (string.IsNullOrWhiteSpace(City_Man.Text))
            {
                MessageBox.Show("City field cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                City_Man.Focus();

            }
            else if (string.IsNullOrWhiteSpace(Street_Man.Text))
            {
                MessageBox.Show("This field cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Street_Man.Focus();

            }
            else if (string.IsNullOrWhiteSpace(Building_Man.Text))
            {
                MessageBox.Show("This field cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Building_Man.Focus();

            }
            else if (string.IsNullOrWhiteSpace(EPass_Man.Text))
            {
                MessageBox.Show("This field cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EPass_Man.Focus();

            }
        }
    }
}
