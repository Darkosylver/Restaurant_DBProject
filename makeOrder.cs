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
    public partial class makeOrder : Form
    {
        Controller controllerobj = new Controller();
        string Phone;
        string waiterSSN;
        DataTable itemOrder;
        public makeOrder(string phoneNumber, string waiterN, DataTable dataTable)
        {
            InitializeComponent();
            Phone = phoneNumber;
            waiterSSN = waiterN;
            itemOrder = dataTable;
            if (waiterSSN != null)
            {
                userName.Text = controllerobj.getEmployeeName(waiterSSN);
            }
            else
            {
                userName.Text = controllerobj.GetCustomerFName(Phone);
            }
            populatePanel();
        }

        private void populatePanel()
        {
            if (itemOrder.Rows.Count > 0)
            {
                float sumPrice = 0;
                foreach (DataRow dr in itemOrder.Rows)
                {
                    cartItem item = new cartItem();
                    item.itemNameSet = dr.Field<int>("itemCount").ToString() + "x" + dr.Field<string>("itemName");
                    sumPrice += dr.Field<float>("itemPrice");
                    item.itemPriceGet = dr.Field<Object>("itemPrice").ToString();
                    realCartItems.Controls.Add(item);
                }
                total.Visible = true;
                totalPrice.Visible = true;
                totalPrice.Text = sumPrice.ToString();
            }
            else
            {
                confirm.Enabled = false;
                total.Visible = false;
                totalPrice.Visible=false;
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            menuForm menu = new menuForm(Phone, waiterSSN, itemOrder);
            menu.Show();
            Close();
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            int orderID;
            if (waiterSSN != null)
            {
                orderID = Convert.ToInt32(controllerobj.MakeOrder("Pending", date, Phone, waiterSSN));
            }
            else
            {
                orderID = Convert.ToInt32(controllerobj.makeOrderOnline(date, Phone).ToString());
            }
            foreach (DataRow dr in itemOrder.Rows)
            {
                int itemID = dr.Field<int>("itemID");
                int itemCount = dr.Field<int>("itemCount");
                controllerobj.addToOrder(orderID, itemID, itemCount);   
            }
            itemOrder.Clear();
            realCartItems.Controls.Clear();
            populatePanel();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            loginScreen logIn = new loginScreen();
            logIn.Show();
            Close();
        }

        private void menuBox_Click(object sender, EventArgs e)
        {
            menuForm menu = new menuForm(Phone, waiterSSN, itemOrder);
            menu.Show();
            Close();
        }

        private void homePage_Click(object sender, EventArgs e)
        {
            if (waiterSSN != null)
            {
                waiter Waiter = new waiter(waiterSSN);
                Waiter.Show();
                Close();
            }
            else
            {
                Welcome homePage = new Welcome(Phone);
                homePage.Show();
                Close();
            }
        }
    }
}