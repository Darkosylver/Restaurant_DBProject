using Microsoft.Reporting.Map.WebForms.BingMaps;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Restaurant_DB
{
   // inline   string storedssn;
    public partial class Chef : Form
    {
        Controller controllerobj = new Controller();
        string storedssn;
        public Chef(string ssn)
        {

            InitializeComponent();
            storedssn = ssn;
            putingredientsincombobox();
            putstocksincombobox();
            ssnchefcombobox();
        }
        public void putingredientsincombobox()
        {
            DataTable pendingid = controllerobj.SelectedPendingID();
            if (pendingid != null && pendingid.Rows.Count > 0)
            {
                
                comboBox1.DataSource = pendingid;
                comboBox1.DisplayMember = "OrderID";
            }
            else
            {
                comboBox1.DataSource = null;
              
            }

        }
        public void putstocksincombobox()
        {
            DataTable stock = controllerobj.showstock();
            if (stock != null && stock.Rows.Count > 0)
            {
                comboBox2.DataSource = stock;
                comboBox2.DisplayMember = "IngredientName";

            }
            else
            {
                comboBox2.DataSource = null;

            }
        }
        public void ssnchefcombobox()
        {
           // DataTable ssnchef = controllerobj.SlectChefSSN();
            //DataTable ssnchef2 = controllerobj.SlectChefSSN();
            DataTable ssnchef = controllerobj.SlectChefSSN();
            if (ssnchef != null && ssnchef.Rows.Count > 0)
            {
                comboBox3.DataSource = ssnchef;
                comboBox3.DisplayMember = "SSN";
            }
            else
            {
                comboBox3.DataSource = null;
            }

        }

        private void Chef_Load(object sender, EventArgs e)
        {

          
        }

        private void PendingOrders_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerobj.OrdersToBeMade();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Served_Click(object sender, EventArgs e)
        { 
           // long out1= long.Parse(comboBox1.SelectedItem.ToString());
               string order =comboBox1.Text;
                controllerobj.ServedOrder(order);
                MessageBox.Show("order will be served successfully");
            
        }

        private void Cancelled_Click(object sender, EventArgs e)
        {
           
           
                int order = int.Parse(comboBox1.Text);
                controllerobj.CancelledOrder(order);
                MessageBox.Show("order is cancelled"); 
        }

        private void Request_Click(object sender, EventArgs e)
        {

            int result = controllerobj.MakeRequest(comboBox2.Text,storedssn);
            MessageBox.Show("Ingredient item is requested successfully!");

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuManager_Click(object sender, EventArgs e)
        {
            // // Regular expression to match the format HH:MM:SS
            // public static bool IsValidCookingTime(string cookingTime)
            // {
    
            //     string pattern = @"^(?:[01]\d|2[0-3]):[0-5]\d:[0-5]\d$";
            //     return Regex.IsMatch(cookingTime, pattern);
            // }
            // private void Insert_item_Click(object sender, EventArgs e)
            // {
            //     if (string.IsNullOrWhiteSpace(ItemName.Text))
            //     {
            //         MessageBox.Show("ItemName cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //         ItemName.Focus();
            //         return;
            //     }
            //     else if (IsValidCookingTime(CookingTime.Text))
            //     {
            //         MessageBox.Show("cooking formats is invalid.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //         CookingTime.Focus();
            //         return;
            //     }
            //     int result=controllerobj.insertMenuItem(ItemName.Text, CookingTime.Text, comboBox4.Text);
            //     MessageBox.Show("New menu item added");
            //     int itemID = Convert.ToInt32(controllerobj.getMenuItemID(ItemName.Text));
            Hide();
            menuManagementcs menu = new menuManagementcs(storedssn);
            menu.ShowDialog();
            Close();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void homeBox_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerobj.OrdersToBeMade();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
