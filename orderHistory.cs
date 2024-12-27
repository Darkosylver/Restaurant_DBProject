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
            if (waiterSSN != null)
            {
                userName.Text = controllerobj.getEmployeeName(waiterSSN);
            }
            else
            {
                userName.Text = controllerobj.GetCustomerFName(Phone);
            }
        }

        private void orderHistory_Load(object sender, EventArgs e)
        {
            if (phoneNumber != null)
            { //user stuff
                currentOrders.DataSource = controllerobj.LoadCustomerOrdersCurret(phoneNumber);
                previousOrders.DataSource = controllerobj.loadCustomerOrdersPrevious(phoneNumber);
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
            menuForm menu = new menuForm(phoneNumber, waiterSSN, itemOrder);
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
            if (userPhone.Text != "" && userPhone.TextLength >= 11)
            {
                searchConfirm.Enabled = true;
            }
        }

        private void userPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {

                e.Handled = true;
            }
        }
    }
}
