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
            comboBox1.DisplayMember = "Position";

            DataTable dt2 = controllerobj.selectitempending();
            comboBox2.DataSource = dt2;
            comboBox2.DisplayMember = "IngredientName";
            Salary_Man.KeyPress += new KeyPressEventHandler(Salary_Man_KeyPress);
            Working_Hours_Man.KeyPress += new KeyPressEventHandler(Working_Hours_Man_KeyPress);

            DataTable dt3 = controllerobj.(phone);
            if (dt == null)
            {
                comboBox1.DataSource = null;
                return;
            }
            // Create a new DataTable with two columns: LocationID and Address
            DataTable locationsTable = new DataTable();
            locationsTable.Columns.Add("SSN", typeof(string));
            locationsTable.Columns.Add("FullName", typeof(string));
            if (dt.Rows.Count == 0)
            {
                comboBox1.DataSource = null;
                return;
            }
            foreach (DataRow row in dt.Rows)
            {
                
            }

            comboBox1.DataSource = locationsTable;
            comboBox1.DisplayMember = "SSN";
            comboBox1.ValueMember = "FullName";

        }
        
        
        private void Update_Manager_Click(object sender, EventArgs e)
        {
          
           
            if (string.IsNullOrWhiteSpace(FName_Man.Text))
            {
                MessageBox.Show("FirstName cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FName_Man.Focus();
                return ;
                
            }else if (string.IsNullOrWhiteSpace(LName_Man.Text))
            {
                MessageBox.Show("LastName cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LName_Man.Focus();
                return;
            }
           else if (string.IsNullOrWhiteSpace(Salary_Man.Text))
            {
                MessageBox.Show("salary cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Salary_Man.Focus();
                return;

            }
            else if (string.IsNullOrWhiteSpace(City_Man.Text))
            {
                MessageBox.Show("city cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                City_Man.Focus();
                return;

            }
            else if (string.IsNullOrWhiteSpace(Street_Man.Text))
            {
                MessageBox.Show("Streetcannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Street_Man.Focus();
                return;

            }else if (string.IsNullOrWhiteSpace(Building_Man.Text))
            {
                MessageBox.Show("building  cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Building_Man.Focus();
                return;

            }
            else if (string.IsNullOrWhiteSpace(EPass_Man.Text))
            {
                MessageBox.Show("password cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EPass_Man.Focus();
                return;

            }
            else if (string.IsNullOrWhiteSpace(Working_Hours_Man.Text))
            {
                MessageBox.Show("Working hours cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Working_Hours_Man.Focus();
                return;

            }
            long Man_ssn = long.Parse(EMPLOYEE_SNN.Text);
            string FName = FName_Man.Text;
            string LName = LName_Man.Text;
            string pos = comboBox1.SelectedText;
            long workinghour = long.Parse(Working_Hours_Man.Text);
            decimal salary = Decimal.Parse(Salary_Man.Text);
            string city = City_Man.Text;
            string street = Street_Man.Text;
            string building = Building_Man.Text;
            string password = EPass_Man.Text;
            int result = controllerobj.UpdateEmployee(Man_ssn, FName, LName, pos, workinghour, salary, city, street, building, password);
        }
        //--------------------------------------------------Validate Data input Functions------------------------------------------------------
       private  void Salary_Man_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                label13.Visible = true;
                e.Handled = true;
            }

            // Allow only one decimal point
            if (e.KeyChar == '.' && Salary_Man.Text.Contains(".") && !char.IsControl(e.KeyChar))
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
        private void Salary_Emp_KeyPress(object sender, KeyPressEventArgs e)
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
        private void WorkingHours_Emp_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Check if the key pressed is a digit
            if (!char.IsDigit(e.KeyChar))
            {
                label14.Visible = true;
                e.Handled = true;
            }


        }
        //-------------------------------------------------------End of validation functions----------------------------------------------------------
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
            if (string.IsNullOrWhiteSpace(EMPLOYEE_SNN.Text))
            {
                MessageBox.Show("Employee SNN cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                City_Man.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(FName_Man.Text))
            {
                MessageBox.Show("FirstName cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FName_Man.Focus();
                return;

            }
            else if (string.IsNullOrWhiteSpace(LName_Man.Text))
            {
                MessageBox.Show("LastName cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LName_Man.Focus();
                return;
            }
            
            else if (string.IsNullOrWhiteSpace(Salary_Man.Text))
            {
                MessageBox.Show("salary cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Salary_Man.Focus();
                return;

            }
            else if (string.IsNullOrWhiteSpace(City_Man.Text))
            {
                MessageBox.Show("city cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                City_Man.Focus();
                return;

            }
            else if (string.IsNullOrWhiteSpace(Street_Man.Text))
            {
                MessageBox.Show("Streetcannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Street_Man.Focus();
                return;

            }
            else if (string.IsNullOrWhiteSpace(Building_Man.Text))
            {
                MessageBox.Show("building  cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Building_Man.Focus();
                return;

            }
            else if (string.IsNullOrWhiteSpace(EPass_Man.Text))
            {
                MessageBox.Show("password cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EPass_Man.Focus();
                return;

            }
            else if (string.IsNullOrWhiteSpace(Working_Hours_Man.Text))
            {
                MessageBox.Show("Working hours cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Working_Hours_Man.Focus();
                return;

            }
            long Man_ssn = long.Parse(EMPLOYEE_SNN.Text);
            string FName = FName_Man.Text;
            string LName = LName_Man.Text;
            string pos = comboBox1.SelectedText;
            long workinghour = long.Parse(Working_Hours_Man.Text);
            decimal salary = Decimal.Parse(Salary_Man.Text);
            string city = City_Man.Text;
            string street = Street_Man.Text;
            string building = Building_Man.Text;
            string password = EPass_Man.Text;
            int result = controllerobj.UpdateEmployee(Man_ssn, FName, LName, pos, workinghour, salary, city, street, building, password);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerobj.ReviewOrder();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            //DataTable dt = controllerobj.ReviewOrder();
            //dataGridView1.DataSource = dt;
            //dataGridView1.Refresh();
        }

        private void PendingOrders_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerobj.viewPendingOrder();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void Insert_Employee_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FName_Man.Text))

            {
                MessageBox.Show("FirstName cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FName_Man.Focus();
                return;

            }
            else if (string.IsNullOrWhiteSpace(LName_Man.Text))
            {
                MessageBox.Show("LastName cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LName_Man.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(Salary_Man.Text))
            {
                MessageBox.Show("salary cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Salary_Man.Focus();
                return;

            }
            else if (string.IsNullOrWhiteSpace(City_Man.Text))
            {
                MessageBox.Show("city cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                City_Man.Focus();
                return;

            }
            else if (string.IsNullOrWhiteSpace(Street_Man.Text))
            {
                MessageBox.Show("Streetcannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Street_Man.Focus();
                return;

            }
            else if (string.IsNullOrWhiteSpace(Building_Man.Text))
            {
                MessageBox.Show("building  cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Building_Man.Focus();
                return;

            }
            else if (string.IsNullOrWhiteSpace(EPass_Man.Text))
            {
                MessageBox.Show("password cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EPass_Man.Focus();
                return;

            }
            else if (string.IsNullOrWhiteSpace(Working_Hours_Man.Text))
            {
                MessageBox.Show("Working hours cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Working_Hours_Man.Focus();
                return;

            }
            /*FirstName_EMP,LastName_EMP,WorkingHours_Emp,Salary_Emp, City_Emp,Street_Emp,Building_Emp,Epassword_Emp*/
            long Insert_ssn = long.Parse(EMPLOYEE_SNN.Text);
            string FName = FName_Man.Text;
            string LName = LName_Man.Text;
            string pos = comboBox1.SelectedText;
            long workinghour = long.Parse(Working_Hours_Man.Text);
            decimal salary = Decimal.Parse(Salary_Man.Text);
            string city = City_Man.Text;
            string street = Street_Man.Text;
            string building = Building_Man.Text;
            string password = EPass_Man.Text;
            int result = controllerobj.insertEmployee(Insert_ssn, FName, LName, pos, workinghour, salary, SuperSnn, city, street, building, password);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Employee_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EMPLOYEE_SNN.Text))
            {
                MessageBox.Show("Empployee SNN be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EMPLOYEE_SNN.Focus();
                return;
            }
            long Emp = long.Parse(EMPLOYEE_SNN.Text);
            controllerobj.deleteEmployee(Emp);
            MessageBox.Show("deleted successfully");
        }

        private void Salary_Emp_TextChanged(object sender, EventArgs e)
        {

        }

        private void Salary_Emp_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                label13.Visible = true;
                e.Handled = true;
            }

            // Allow only one decimal point
            if (e.KeyChar == '.' && Salary_Man.Text.Contains(".") && !char.IsControl(e.KeyChar))
            {
                label13.Visible = true;
                e.Handled = true;
            }
        }

        private void WorkingHours_Emp_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                label14.Visible = true;
                e.Handled = true;
            }
        }

        private void EMPLOYEE_SNN_TextChanged(object sender, EventArgs e)
        {

        }

        private void LName_Man_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
