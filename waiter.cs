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
    public partial class waiter : Form
    {
        Controller controllerobj = new Controller();
        string storedssn;
        public waiter(string ssn)
        {
            InitializeComponent();
            storedssn = ssn;
        }

        private void reserve_Click(object sender, EventArgs e)
        {
            if (tableno.Text=="")
            {
                MessageBox.Show("table number cannot be empty");
            }
            else if (!tableno.Text.All(char.IsDigit))
            {
                MessageBox.Show("table number cant be negative or have letters");
            }
            else if (!phoneno.Text.All(char.IsDigit) || phoneno.Text.Length!=11)
            {
                MessageBox.Show("enter a valid phone number");
            }
            else if(Convert.ToInt32(controllerobj.checktableexists(Convert.ToInt32(tableno.Text)))!=1)
            {
                MessageBox.Show("No table with the following number");
            }
            else if(Convert.ToString(controllerobj.checktable(Convert.ToInt32(tableno.Text)))!="")
            {
                MessageBox.Show("table already reserved");
            }
            else if (Convert.ToInt32(controllerobj.checkphonenumber(phoneno.Text)) != 1)
            {
                MessageBox.Show("no customer with the following phone number");
            }
            else
            {
                controllerobj.reservetable(Convert.ToInt32(tableno.Text), phoneno.Text);
                MessageBox.Show("added successfully");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {

        }

        private void update_Click_1(object sender, EventArgs e)
        {
            if(city.Text=="" || street.Text=="" || building.Text == "")
            {
                MessageBox.Show("address cannot have empty input");
            }
            else if (city.Text.Any(char.IsDigit))
            {
                MessageBox.Show("enter valid city");
            }
            else
            {
                controllerobj.insertlocation(phoneno.Text, city.Text,street.Text,building.Text);
                MessageBox.Show("location updated successfully");
            }
        }

        private void waiter_Load(object sender, EventArgs e)
        {

        }
    }
}
