using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_DB // okay so before we start let's agree on smth.. if you find any bugs leave me alone
{
    public partial class waiter : Form
    {
        
        Controller controllerobj = new Controller(); 
        string storedssn;
        public waiter(string ssn)
        {
            InitializeComponent();
            storedssn = ssn;
            restauranttables.DataSource = controllerobj.gettables();
            order.Enabled = false;
            update.Enabled = false;
            delete.Enabled = false;
            deletetable.Enabled = false;
            freetable.Enabled = false;
            reserve.Enabled = false;
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

            comboBox1.DataSource=locationsTable;
            comboBox1.DisplayMember= "address";
            comboBox1.ValueMember= "locationID";

        }
        public void refreshtables()
        {
            restauranttables.DataSource = controllerobj.gettables();
        }
        private void reserve_Click(object sender, EventArgs e)
        {
            //if (tableno.Text == "")
            //{
            //    MessageBox.Show("table number cannot be empty");
            //}
            //else if (!tableno.Text.All(char.IsDigit))
            //{
            //    MessageBox.Show("table number cant be negative or have letters");
            //}
            //else if (!phoneno.Text.All(char.IsDigit) || phoneno.Text.Length != 11 || (Convert.ToInt32(controllerobj.checkcustomerexist(phoneno.Text))) == 0)
            //{
            //    MessageBox.Show("enter a valid phone number");
            //}
            //else if (Convert.ToInt32(controllerobj.checktableexists(Convert.ToInt32(tableno.Text))) != 1)
            //{
            //    MessageBox.Show("No table with the following number");
            //}
            //else if (Convert.ToString(controllerobj.checktable(Convert.ToInt32(tableno.Text))) != "")
            //{
            //    MessageBox.Show("table already reserved");
            //}
            //else if (Convert.ToInt32(controllerobj.checkphonenumber(phoneno.Text)) != 1)
            //{
            //    MessageBox.Show("no customer with the following phone number");
            //}
            //else
            //{ }
            controllerobj.reservetable(Convert.ToInt32(tableno.Text), phoneno.Text);
            reserve.Enabled = false;
            deletetable.Enabled=false;
            freetable.Enabled = false;
            refreshtables();
            MessageBox.Show("added successfully");
            
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
            else if (!phoneno.Text.All(char.IsDigit) || phoneno.Text.Length != 11 || (Convert.ToInt32(controllerobj.checkcustomerexist(phoneno.Text))) == 0)
            {
                MessageBox.Show("enter a valid phone number");
            }
            else if(controllerobj.checklocationexist(city.Text,street.Text,building.Text)==null)
            {
                controllerobj.insertlocationid(phoneno.Text,city.Text,street.Text,building.Text);
                controllerobj.insertlocation(phoneno.Text,Convert.ToInt32(controllerobj.checklocationexist(city.Text,street.Text,building.Text)));
                MessageBox.Show("location updated successfully");
            }
            else if (Convert.ToInt32(controllerobj.checkassignedlocation(phoneno.Text,Convert.ToInt32(controllerobj.checklocationexist(city.Text, street.Text, building.Text))))!=0)
            {
                MessageBox.Show("customer already has that address");
            }
            else
            {
                controllerobj.insertlocation(phoneno.Text, Convert.ToInt32(controllerobj.checklocationexist(city.Text, street.Text, building.Text)));
                putlocationsincombobox(phoneno.Text);
                MessageBox.Show("location updated successfully");
            }
        }

        private void waiter_Load(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {

            //if (Convert.ToInt32(controllerobj.checkassignedlocation(phoneno.Text, Convert.ToInt32(controllerobj.checklocationexist(city.Text, street.Text, building.Text)))) == 0)
            //{
            //    MessageBox.Show("customer doesn't have that address");
            //}
            //else
            //{
            //    controllerobj.deletelocation(phoneno.Text, Convert.ToInt32(controllerobj.checklocationexist(city.Text, street.Text, building.Text)));
            //    MessageBox.Show("removed successfully");
            //}
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("please select a valid address");
                return;
            }
            else if (Convert.ToInt32(controllerobj.checkcustomerexist(phoneno.Text)) != 1)
            {
                MessageBox.Show("customer doesnt exist");
                return;
            }
            controllerobj.deletelocationwid(phoneno.Text,comboBox1.SelectedValue);
            MessageBox.Show("deleted successfully");
            putlocationsincombobox(phoneno.Text);
        }

        private void freetable_Click(object sender, EventArgs e)
        {
                controllerobj.freetable(Convert.ToInt32(tableno.Text));
            if (Convert.ToInt32(controllerobj.checkphonenumber(phoneno.Text))==1)
            {
                reserve.Enabled= true;
            }
                refreshtables();
                MessageBox.Show("Table is now available");
            
        }

        private void tableno_TextChanged(object sender, EventArgs e)
        {
            if ((Convert.ToInt32(controllerobj.checkcustomerexist(phoneno.Text))) == 1 && tableno.Text!="" && Convert.ToInt32(controllerobj.checktableexists(Convert.ToInt32(tableno.Text))) == 1 && Convert.ToInt32(controllerobj.checktablereserved(Convert.ToInt32(tableno.Text)))==1)
            {
                tablelabel.Text = "already reserved";
                reserve.Enabled = false;
                freetable.Enabled = true;
                deletetable.Enabled = false;
            }
            else if ((Convert.ToInt32(controllerobj.checkcustomerexist(phoneno.Text))) == 1 && tableno.Text != "" && Convert.ToInt32(controllerobj.checktableexists(Convert.ToInt32(tableno.Text))) == 1)
            {
                tablelabel.Text = "";
                reserve.Enabled = true;
                freetable.Enabled = true;
                deletetable.Enabled = true;
            }
            else if (tableno.Text!="" && Convert.ToInt32(controllerobj.checktableexists(Convert.ToInt32(tableno.Text))) == 1 && Convert.ToInt32(controllerobj.checktablereserved(Convert.ToInt32(tableno.Text))) == 1)
            {
                tablelabel.Text = "already reserved";
                reserve.Enabled = false;
                freetable.Enabled = true;
                deletetable.Enabled = false;
            }
            else if (tableno.Text != "" && Convert.ToInt32(controllerobj.checktableexists(Convert.ToInt32(tableno.Text))) == 1 && Convert.ToInt32(controllerobj.checktablereserved(Convert.ToInt32(tableno.Text))) != 1)
            {
                tablelabel.Text = "";
                reserve.Enabled = false;
                freetable.Enabled = true;
                deletetable.Enabled = true;
            }
            else if (tableno.Text != "" && Convert.ToInt32(controllerobj.checktableexists(Convert.ToInt32(tableno.Text))) == 1)
            {
                tablelabel.Text = "";
                reserve.Enabled = false;
                freetable.Enabled = true;
                deletetable.Enabled = true;
            }
            else if (tableno.Text=="")
            {
                tablelabel.Text = "";
                reserve.Enabled = false;
                freetable.Enabled = false;
                deletetable.Enabled = false;
            }
            else if (Convert.ToInt32(controllerobj.checktableexists(Convert.ToInt32(tableno.Text))) != 1)
            {
                tablelabel.Text = "No table with the following number";
                reserve.Enabled = false;
                freetable.Enabled = false;
                deletetable.Enabled = false;
            }
        }

        
        private void refresh_Click(object sender, EventArgs e)
        {
            refreshtables();
        }

        private void addtable_Click(object sender, EventArgs e)
        {
            controllerobj.inserttable();
            refreshtables();
            if ((Convert.ToInt32(controllerobj.checkcustomerexist(phoneno.Text))) == 1 && tableno.Text != "" && Convert.ToInt32(controllerobj.checktableexists(Convert.ToInt32(tableno.Text))) == 1)
            {
                tablelabel.Text = "";
                reserve.Enabled = true;
                freetable.Enabled = true;
                deletetable.Enabled = true;
            }
            else if ((Convert.ToInt32(controllerobj.checkcustomerexist(phoneno.Text))) != 1 || tableno.Text == "")
            {
                reserve.Enabled = false;
                freetable.Enabled = false;
                deletetable.Enabled = false;
            }
            else if (Convert.ToInt32(controllerobj.checktableexists(Convert.ToInt32(tableno.Text))) != 1)
            {
                tablelabel.Text = "No table with the following number";
                reserve.Enabled = false;
                freetable.Enabled = false;
                deletetable.Enabled = false;
            }
        }

        private void phoneno_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(controllerobj.checkcustomerexist(phoneno.Text)) == 1 && tableno.Text!="" && Convert.ToInt32(controllerobj.checktablereserved(Convert.ToInt32(tableno.Text))) == 1 && Convert.ToInt32(controllerobj.checktableexists(Convert.ToInt32(tableno.Text))) == 1 && (building.Text != "" && city.Text != "" && street.Text != ""))
            {
                phonelabel.Text = "";
                tablelabel.Text = "already reserved";
                reserve.Enabled = false;
                deletetable.Enabled=false;

                update.Enabled = true;
                delete.Enabled = true;
                putlocationsincombobox(phoneno.Text);
                order.Enabled = true;
                
            }
            
            else if (Convert.ToInt32(controllerobj.checkcustomerexist(phoneno.Text)) == 1 && tableno.Text != "" && Convert.ToInt32(controllerobj.checktablereserved(Convert.ToInt32(tableno.Text))) == 1 && (building.Text != "" && city.Text != "" && street.Text != ""))
            {
                phonelabel.Text = "";
                reserve.Enabled = true;
                deletetable.Enabled = true;
                update.Enabled = true;
                delete.Enabled = true;
                putlocationsincombobox(phoneno.Text);
                order.Enabled = true;

            }
            
            else if (Convert.ToInt32(controllerobj.checkcustomerexist(phoneno.Text)) == 1 && tableno.Text != "" && Convert.ToInt32(controllerobj.checktableexists(Convert.ToInt32(tableno.Text)))==1 && Convert.ToInt32(controllerobj.checktablereserved(Convert.ToInt32(tableno.Text))) == 1)
            {
                phonelabel.Text = "";
                tablelabel.Text = "already reserved";
                reserve.Enabled=false;
                delete.Enabled=true;
                putlocationsincombobox(phoneno.Text);
                deletetable.Enabled=false;
                order.Enabled=true;
            }
           
            else if (Convert.ToInt32(controllerobj.checkcustomerexist(phoneno.Text)) == 1 && (building.Text != "" && city.Text != "" && street.Text != ""))
            {
                phonelabel.Text = "";
                update.Enabled = true;
                delete.Enabled = true;
                putlocationsincombobox(phoneno.Text);
                order.Enabled=true;
                
            }
            
            else if (phoneno.Text=="")
            {
                phonelabel.Text = "";
                update.Enabled = false;
                delete.Enabled = false;
                putlocationsincombobox(phoneno.Text);
                reserve.Enabled = false;
                order.Enabled = false;
            }
            else if((Convert.ToInt32(controllerobj.checkcustomerexist(phoneno.Text))) == 1)
            {
                phonelabel.Text = "";
                order.Enabled = true;
                delete.Enabled= true;
                putlocationsincombobox(phoneno.Text);
            }
            else if ((Convert.ToInt32(controllerobj.checkcustomerexist(phoneno.Text))) == 1)
            {
                phonelabel.Text = "";
                order.Enabled = true;
                delete.Enabled = true;
                putlocationsincombobox(phoneno.Text);
            }
            else if (!phoneno.Text.All(char.IsDigit) || phoneno.Text.Length != 11 || (Convert.ToInt32(controllerobj.checkcustomerexist(phoneno.Text))) == 0)
            {
                phonelabel.Text = "enter a valid phone number";
                order.Enabled = false;
                update.Enabled = false;
                delete.Enabled = false;
                putlocationsincombobox(phoneno.Text);
                reserve.Enabled = false;
                order.Enabled = false;
            }
        }

        private void building_TextChanged(object sender, EventArgs e)
        {
            if(building.Text!="" && city.Text!="" && street.Text != "" && (Convert.ToInt32(controllerobj.checkcustomerexist(phoneno.Text))) == 1)
            {
                update.Enabled = true;
                
            }
            else
            {
                update.Enabled = false;
               
            }
        }

        private void street_TextChanged(object sender, EventArgs e)
        {
            if (building.Text != "" && city.Text != "" && street.Text != "" && (Convert.ToInt32(controllerobj.checkcustomerexist(phoneno.Text))) == 1)
            {
                update.Enabled = true;
                
            }
            else
            {
                update.Enabled = false;
                
            }
        }

        private void city_TextChanged(object sender, EventArgs e)
        {
            if (building.Text != "" && city.Text != "" && street.Text != "" && (Convert.ToInt32(controllerobj.checkcustomerexist(phoneno.Text))) == 1)
            {
                update.Enabled = true;
                
            }
            else
            {
                update.Enabled = false;
                
            }
        }

        private void deletetable_Click(object sender, EventArgs e)
        {
            
            
            controllerobj.deletetable(Convert.ToInt32(tableno.Text));
            deletetable.Enabled = false;
            freetable.Enabled = false;
            reserve.Enabled = false;
            refreshtables();
            MessageBox.Show("Table Deleted Successfully");
        }

        private void order_Click(object sender, EventArgs e)
        {
            //kindly add the new form and remove the message box
            MessageBox.Show("under development thanks for supporting our restaurant");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
