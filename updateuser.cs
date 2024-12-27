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
    public partial class updateuser : Form
    {
        Controller controllerobj = new Controller();
        string storedssn;
        string phone;
        public updateuser(string phone,string ssn)
        {
            InitializeComponent();
            storedssn = ssn;
            this.phone = phone;
            delete.Enabled = false;
            insert.Enabled = false;
            waiterName.Text = controllerobj.getEmployeeName(ssn);
        }
        public void putlocationsincombobox(string phone)
        {
            DataTable dt = controllerobj.getlocations(phone);
            if (dt == null)
            {
                comboBox1.DataSource = null;
                return;
            }
            // Create a new DataTable with two columns: LocationID and Address
            DataTable locationsTable = new DataTable();
            locationsTable.Columns.Add("LocationID", typeof(string));
            locationsTable.Columns.Add("Address", typeof(string));
            if (dt.Rows.Count == 0)
            {
                comboBox1.DataSource = null;
                return;
            }
            foreach (DataRow row in dt.Rows)
            {
                // Extract LocationID
                string locationId = row["LocationID"].ToString();

                // Merge City, Street, and Building into a single string
                string address = $"{row["City"]}, {row["Street"]}, {row["Building"]}";

                // Add a new row to the DataTable
                locationsTable.Rows.Add(locationId, address);
            }

            comboBox1.DataSource = locationsTable;
            comboBox1.DisplayMember = "address";
            comboBox1.ValueMember = "locationID";

        }
        private void updateuser_Load(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("please select a valid address");
                return;
            }
            controllerobj.deletelocationwid(phone, comboBox1.SelectedValue);
            MessageBox.Show("deleted successfully");
            putlocationsincombobox(phone);
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (city.Text == "" || street.Text == "" || building.Text == "")
            {
                MessageBox.Show("address cannot have empty input");
            }
            else if (city.Text.Any(char.IsDigit))
            {
                MessageBox.Show("enter valid city");
            }
            else if (controllerobj.checklocationexist(city.Text, street.Text, building.Text) == null)
            {
                controllerobj.insertlocationid(city.Text, street.Text, building.Text);
                controllerobj.insertlocation(phone, Convert.ToInt32(controllerobj.checklocationexist(city.Text, street.Text, building.Text)));
                putlocationsincombobox(phone);
                MessageBox.Show("location inserted successfully");
            }
            else if (Convert.ToInt32(controllerobj.checkassignedlocation(phone, Convert.ToInt32(controllerobj.checklocationexist(city.Text, street.Text, building.Text)))) != 0)
            {
                MessageBox.Show("customer already has that address");
            }
            else
            {
                controllerobj.insertlocation(phone, Convert.ToInt32(controllerobj.checklocationexist(city.Text, street.Text, building.Text)));
                putlocationsincombobox(phone);
                MessageBox.Show("location inserted successfully");
            }
        }

        private void building_TextChanged(object sender, EventArgs e)
        {
            if (building.Text != "" && city.Text != "" && street.Text != "")
            {
                insert.Enabled = true;

            }
            else
            {
                insert.Enabled = false;

            }
        }

        private void street_TextChanged(object sender, EventArgs e)
        {
            if (building.Text != "" && city.Text != "" && street.Text != "")
            {
                insert.Enabled = true;

            }
            else
            {
                insert.Enabled = false;

            }
        }

        private void city_TextChanged(object sender, EventArgs e)
        {
            if (building.Text != "" && city.Text != "" && street.Text != "")
            {
                insert.Enabled = true;

            }
            else
            {
                insert.Enabled = false;

            }
        }

        private void homePage_Click(object sender, EventArgs e)
        {
            Hide();
            waiter homepage = new waiter(storedssn);
            homepage.ShowDialog();
            Close();
        }

        private void orderhistory_Click(object sender, EventArgs e)
        {
            Hide();
            orderHistory orders = new orderHistory(null, storedssn);
            orders.ShowDialog();
            Close();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
