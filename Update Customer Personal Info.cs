using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Restaurant_DB
{
    public partial class Update_Customer_Personal_Info : Form
    {
        Controller controllerobj = new Controller();
        //phone number
        String phone;
        int addressId = -1;

        public void putlocationsincombobox()
        {
            DataTable dt = controllerobj.getlocations(phone);
            if (dt == null)
            {
                AddressComboBox.DataSource = null;
                return;
            }
            // Create a new DataTable with two columns: LocationID and Address
            DataTable locationsTable = new DataTable();
            locationsTable.Columns.Add("LocationID", typeof(string));
            locationsTable.Columns.Add("Address", typeof(string));
            if (dt.Rows.Count == 0)
            {
                AddressComboBox.DataSource = null;
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

            AddressComboBox.DataSource = locationsTable;
            AddressComboBox.DisplayMember = "address";
            AddressComboBox.ValueMember = "locationID";

        }
        public Update_Customer_Personal_Info(string phone)
        {
            InitializeComponent();
            this.phone = phone;

            DataTable dt = controllerobj.getcustomerinfo(phone);
            DataRow dr = dt.Rows[0];
            FNameTextBox.Text = dr["FName"].ToString();
            LNameTextBox.Text = dr["LName"].ToString();
            putlocationsincombobox();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CityTextBox.Text) || string.IsNullOrWhiteSpace(StreetTextBox.Text) || string.IsNullOrWhiteSpace(BuildingTextBox.Text))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            string specialCharPattern = @"[^a-zA-Z0-9\s]";

            if (System.Text.RegularExpressions.Regex.IsMatch(CityTextBox.Text, specialCharPattern))
            {
                MessageBox.Show("Please enter a valid city.");
                return;
            }

            if (System.Text.RegularExpressions.Regex.IsMatch(StreetTextBox.Text, specialCharPattern))
            {
                MessageBox.Show("Please enter a valid street.");
                return;
            }

            if (System.Text.RegularExpressions.Regex.IsMatch(BuildingTextBox.Text, specialCharPattern))
            {
                MessageBox.Show("Please enter a valid building.");
                return;
            }
            //if the new location already exists, update old addressId to new LocationID
            //if not, create a new location, and get its LocationID, and then update old addressId to new LocationID
            object LocationID = controllerobj.checklocationexist(CityTextBox.Text, StreetTextBox.Text, BuildingTextBox.Text);
            //check if the location already exists
            if (LocationID != null)
            {
                try
                {
                    //update the addressId
                    controllerobj.UpdateAddress(this.phone, addressId, Convert.ToInt32(LocationID));
                    putlocationsincombobox();
                    //once updated, restart this form window
                   // Update_Customer_Personal_Info update_Customer_Personal_Info = new Update_Customer_Personal_Info(this.phone);
                    //update_Customer_Personal_Info.Show();
                    //hide this form
                    //this.Hide();
                }
                catch (Exception ex)
                {
                    //if the update fails, then that means the user inserted the same address twice
                    MessageBox.Show("Error updating address, you may have this address already added to your acccount!");
                }
            }
            else
            {
                //create a new location
                controllerobj.insertlocationid(CityTextBox.Text, StreetTextBox.Text, BuildingTextBox.Text);
                //get the LocationID of the new location
                LocationID = controllerobj.checklocationexist(CityTextBox.Text, StreetTextBox.Text, BuildingTextBox.Text);
                //update the addressId
                controllerobj.UpdateAddress(this.phone, addressId, Convert.ToInt32(LocationID));
                putlocationsincombobox();
                //Update_Customer_Personal_Info update_Customer_Personal_Info = new Update_Customer_Personal_Info(this.phone);
                //update_Customer_Personal_Info.Show();
                //hide this form
                //this.Hide();
            }


        }

        private void Update_Customer_Personal_Info_Load(object sender, EventArgs e)
        {   
        }

        private void AddressComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            //try parse
            try
            {
                addressId = Convert.ToInt32(AddressComboBox.SelectedValue.ToString());
                //console the id for debugging
                //Console.WriteLine(addressId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void UpdateButton2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FNameTextBox.Text) || string.IsNullOrWhiteSpace(LNameTextBox.Text))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            string validNamePattern = @"^[a-zA-Z]+$";

            if (!System.Text.RegularExpressions.Regex.IsMatch(FNameTextBox.Text, validNamePattern))
            {
                MessageBox.Show("Please enter a valid first name with letters only.");
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(LNameTextBox.Text, validNamePattern))
            {
                MessageBox.Show("Please enter a valid last name with letters only.");
                return;
            }

                controllerobj.UpdateCustomerName(this.phone, FNameTextBox.Text, LNameTextBox.Text);
                return;
        }

        private void DoneEditingButton_Click(object sender, EventArgs e)
        {
            //open welcome screen and hide this one
            Welcome welcome = new Welcome(this.phone);
            welcome.Show();

            this.Hide();
        }

        private void InsertAddressButton_Click(object sender, EventArgs e)
        {
             if (controllerobj.checklocationexist(CityTextBox.Text, StreetTextBox.Text, BuildingTextBox.Text) == null)
            {
                controllerobj.insertlocationid(CityTextBox.Text, StreetTextBox.Text,BuildingTextBox.Text);
                controllerobj.insertlocation(phone, Convert.ToInt32(controllerobj.checklocationexist(CityTextBox.Text, StreetTextBox.Text, BuildingTextBox.Text)));
                putlocationsincombobox();
                MessageBox.Show("location inserted successfully");
            }
            else if (Convert.ToInt32(controllerobj.checkassignedlocation(phone, Convert.ToInt32(controllerobj.checklocationexist(CityTextBox.Text, StreetTextBox.Text, BuildingTextBox.Text)))) != 0)
            {
                MessageBox.Show("customer already has that address");
            }
            else
            {
                controllerobj.insertlocation(phone, Convert.ToInt32(controllerobj.checklocationexist(CityTextBox.Text, StreetTextBox.Text, BuildingTextBox.Text)));
                putlocationsincombobox();
                MessageBox.Show("location inserted successfully");
            }
        }
    }
}
