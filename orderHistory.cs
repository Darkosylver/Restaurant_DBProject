﻿using System;
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
    public partial class orderHistory : Form
    {
        Controller controllerobj = new Controller();
        string phoneNumber;
        string waiterSSN;
        public orderHistory(string Phone, string waiterN)
        {
            InitializeComponent();
            phoneNumber = Phone;
            waiterSSN = waiterN;
            currentOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            previousOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (waiterSSN != null)
            {
                userName.Text = controllerobj.getEmployeeName(waiterSSN);
            }
            else
            {
                userName.Text = controllerobj.GetCustomerFName(Phone);
                delivered.Visible = false;
                delivered.Enabled = false;
                totalSpendingButton.Visible = false;
                SpendingPerItemButton.Visible = false;
                MostBoughtItemButton.Visible = false;

            }
        }

        private void orderHistory_Load(object sender, EventArgs e)
        {
            if (phoneNumber != null)
            { //user stuff
                currentOrders.DataSource = controllerobj.LoadCustomerOrdersCurret(phoneNumber);
                previousOrders.DataSource = controllerobj.loadCustomerOrdersPrevious(phoneNumber);
                TotalSpendings.Visible = true;
                SpendingPerItemButton.Visible = true;
                MostBoughtItemButton.Visible = true;
                totalSpendingButton.Visible = true;
                
            }
            else
            { //waiter stuff
                currentOrders.DataSource = controllerobj.LoadWaiterOrdersCurret(waiterSSN);
                previousOrders.DataSource = controllerobj.loadWaiterOrdersPrevious(waiterSSN);
                search.Visible = true;
                userPhone.Visible = true;
                userPhone.Enabled = true;
                searchConfirm.Visible = true;
            }
        }

        private void historyRefresh_Click(object sender, EventArgs e)
        {
            if (phoneNumber != null)
            {
                currentOrders.DataSource = controllerobj.LoadCustomerOrdersCurret(phoneNumber);
                previousOrders.DataSource = controllerobj.loadCustomerOrdersPrevious(phoneNumber);
            }
            else
            {
                currentOrders.DataSource = controllerobj.LoadWaiterOrdersCurret(waiterSSN);
                previousOrders.DataSource = controllerobj.loadWaiterOrdersPrevious(waiterSSN);
                search.Visible = true;
                userPhone.Visible = true;
                userPhone.Enabled = true;
                searchConfirm.Visible = true;
            }
        }

        private void menu_Click(object sender, EventArgs e)
        {
            DataTable itemOrder = new DataTable("orderedItems");
            itemOrder.Columns.Add("itemID", typeof(int));
            itemOrder.Columns.Add("itemName", typeof(string));
            itemOrder.Columns.Add("itemCount", typeof(int));
            itemOrder.Columns.Add("itemPrice", typeof(float));
            menuForm menu = new menuForm(phoneNumber, waiterSSN,null,0, 0, itemOrder);
            menu.Show();
            Close();
        }

        private void searchConfirm_Click(object sender, EventArgs e)
        {
            currentOrders.DataSource = controllerobj.LoadCustomerOrdersCurret(userPhone.Text);
            previousOrders.DataSource = controllerobj.loadCustomerOrdersPrevious(userPhone.Text);
            
        }

        private void userPhone_TextChanged(object sender, EventArgs e)
        {
            if (userPhone.Text == "" && userPhone.TextLength != 11)
            {
                searchConfirm.Enabled = false;
                return;
                
            }
            else if (Convert.ToInt32(controllerobj.checkcustomerexist(phoneNumber)) == 1)
            {
                searchConfirm.Enabled=true;
            }
            else
            {
                searchConfirm.Enabled=false;
            }
        }

        private void userPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {

                e.Handled = true;
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
                if (currentOrders.SelectedRows.Count == 1)
                {
                    DataGridViewRow selectedRow = currentOrders.SelectedRows[0];
                    int orderid = Convert.ToInt32(selectedRow.Cells[0].Value);
                    controllerobj.cancelorder(orderid);
                    MessageBox.Show("Order Cancelled Successfully");
                }
                else
                {
                    MessageBox.Show("Please select exactly one row.");
                }
            
        }

        private void currentOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void delivered_Click(object sender, EventArgs e)
        {
            if (currentOrders.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = currentOrders.SelectedRows[0];
                int orderid = Convert.ToInt32(selectedRow.Cells[0].Value);
                controllerobj.deliverorder(orderid);
                MessageBox.Show("Order Marked as Delivered");
            }
            else
            {
                MessageBox.Show("Please select exactly one row.");
            }
        }

        private void totalSpendingButton_Click(object sender, EventArgs e)
        {
            if (phoneNumber != null)
            { 
                TotalSpendings.DataSource = controllerobj.GetTotalSpendings(phoneNumber);
            }
        }

        private void SpendingPerItemButton_Click(object sender, EventArgs e)
        {

            if (phoneNumber != null)
            {
                TotalSpendings.DataSource = controllerobj.GetSpendingPerItem(phoneNumber);
            }

        }

        private void MostBoughtItemButton_Click(object sender, EventArgs e)
        {

            if (phoneNumber != null)
            {
                TotalSpendings.DataSource = controllerobj.GetMostBoughtItem(phoneNumber);
            }
        }

        private void homeBox_Click(object sender, EventArgs e)
        {
            Hide();
            if (phoneNumber != null)
            {
                Welcome homePage = new Welcome(phoneNumber);
                homePage.ShowDialog();
            }
            else
            {
                waiter homePage = new waiter(waiterSSN);
                homePage.ShowDialog();
            }
            Close();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
