using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Restaurant_DB
{
    public partial class Modify_Customer : Form
    {
        Controller controllerobj = new Controller();
        string storedssn;
        public Modify_Customer(string ssn)
        {
            InitializeComponent();
            storedssn = ssn;
            DataTable dt = controllerobj.selectPosition();
            Poistion.DataSource = dt;
            Poistion.DisplayMember = "Position";

            putingredientsincombobox();
            putEmployeeSSnincombobox();


           

        }
        public void putingredientsincombobox()
        {
            DataTable itemname = controllerobj.selectitempending();
            if (itemname.Rows.Count == 0)
            {
                comboBox1.DataSource = null;
            }
            else
            {
                comboBox1.DataSource = itemname;
                comboBox1.DisplayMember = "IngredientName";
                comboBox1.ValueMember = "ID";
            }

        }
        public void putEmployeeSSnincombobox()
        {
            DataTable EmpSSN = controllerobj.GetEmpSSN();
            if (EmpSSN != null && EmpSSN.Rows.Count > 0)
            {

                EXIST_SSN.DataSource = EmpSSN;
                EXIST_SSN.DisplayMember = "SSN";
            }
            else
            {
                EXIST_SSN.DataSource = null;

            }
        }
        private void InsertEmployee_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FName.Text))

            {
                MessageBox.Show("FirstName cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FName.Focus();
                return;

            }
            else if (string.IsNullOrWhiteSpace(LName.Text))
            {
                MessageBox.Show("LastName cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LName.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(Salary.Text))
            {
                MessageBox.Show("salary cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Salary.Focus();
                return;

            }
            else if (string.IsNullOrWhiteSpace(City.Text))
            {
                MessageBox.Show("city cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                City.Focus();
                return;

            }
            else if (string.IsNullOrWhiteSpace(Street.Text))
            {
                MessageBox.Show("Streetcannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Street.Focus();
                return;

            }
            else if (string.IsNullOrWhiteSpace(Building.Text))
            {
                MessageBox.Show("building  cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Building.Focus();
                return;

            }
            else if (string.IsNullOrWhiteSpace(EPassword.Text))
            {
                MessageBox.Show("password cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EPassword.Focus();
                return;

            }
            else if (string.IsNullOrWhiteSpace(WorkingHour.Text))
            {
                MessageBox.Show("Working hours cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                WorkingHour.Focus();
                return;

            }
            /*FirstName_EMP,LastName_EMP,WorkingHours_Emp,Salary_Emp, City_Emp,Street_Emp,Building_Emp,Epassword_Emp*/
            long Insert_ssn = long.Parse(EMPLOYEE_SNN.Text);
            string FirstName = FName.Text;
            string LastName = LName.Text;
            string pos = Poistion.SelectedText;
            long workinghour = long.Parse(WorkingHour.Text);
            decimal salary = Decimal.Parse(Salary.Text);
            string city = City.Text;
            string street = Street.Text;
            string building = Building.Text;
            string password = EPassword.Text;
            int result = controllerobj.insertEmployee(Insert_ssn, FirstName, LastName, pos, workinghour, salary, storedssn, city, street, building, password);
        }

    private void UpdatePendingOrder_Click(object sender,EventArgs e)
        {
            controllerobj.approvepending(Convert.ToInt32(comboBox1.SelectedValue));
                         putingredientsincombobox();
                         MessageBox.Show("approved successfully");
        }
        private void Update_Employee_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FName.Text))

            {
                MessageBox.Show("FirstName cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FName.Focus();
                return;

            }
            else if (string.IsNullOrWhiteSpace(LName.Text))
            {
                MessageBox.Show("LastName cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LName.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(Salary.Text))
            {
                MessageBox.Show("salary cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Salary.Focus();
                return;

            }
            else if (string.IsNullOrWhiteSpace(City.Text))
            {
                MessageBox.Show("city cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                City.Focus();
                return;

            }
            else if (string.IsNullOrWhiteSpace(Street.Text))
            {
                MessageBox.Show("Streetcannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Street.Focus();
                return;

            }
            else if (string.IsNullOrWhiteSpace(Building.Text))
            {
                MessageBox.Show("building  cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Building.Focus();
                return;

            }
            else if (string.IsNullOrWhiteSpace(EPassword.Text))
            {
                MessageBox.Show("password cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EPassword.Focus();
                return;

            }
            else if (string.IsNullOrWhiteSpace(WorkingHour.Text))
            {
                MessageBox.Show("Working hours cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                WorkingHour.Focus();
                return;

            }
            /*FirstName_EMP,LastName_EMP,WorkingHours_Emp,Salary_Emp, City_Emp,Street_Emp,Building_Emp,Epassword_Emp*/
            long Insert_ssn = long.Parse(EMPLOYEE_SNN.Text);
            string FirstName = FName.Text;
            string LastName = LName.Text;
            string pos = Poistion.SelectedText;
            long workinghour = long.Parse(WorkingHour.Text);
            decimal salary = Decimal.Parse(Salary.Text);
            string city = City.Text;
            string street = Street.Text;
            string building = Building.Text;
            string password = EPassword.Text;
            int result = controllerobj.UpdateEmployee(Insert_ssn, FirstName, LastName, pos, workinghour, salary, city, street, building, password);

        }

        private void EXIST_SSN_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable empData = controllerobj.GetEmployeeDetails(EXIST_SSN.Text);
            if (empData!=null)
            {
                DataRow dr = empData.Rows[0];

                if (empData.Rows.Count > 0)
                {
                    EMPLOYEE_SNN.Text = dr["SSN"].ToString();
                    FName.Text = dr["FName"].ToString();
                    LName.Text = dr["LName"].ToString();
                    Poistion.Text = dr["Position"].ToString();
                    WorkingHour.Text = dr["WorkingHours"].ToString();
                    Salary.Text = dr["Salary"].ToString();
                    City.Text = dr["City"].ToString();
                    Street.Text = dr["Street"].ToString();
                    Building.Text = dr["Building"].ToString();
                    EPassword.Text = "";
                    long Insert_ssn = long.Parse(EMPLOYEE_SNN.Text);
                    string FirstName = FName.Text;
                    string LastName = LName.Text;
                    string pos = Poistion.SelectedText;
                    long workinghour = long.Parse(WorkingHour.Text);
                    decimal salary = Decimal.Parse(Salary.Text);
                    string city = City.Text;
                    string street = Street.Text;
                    string building = Building.Text;
                    string password = EPassword.Text;

                }
            }
        }
    }

} 
    
