using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Restaurant_DB
{
    public partial class menuForm : Form
    {
        Controller controllerobj = new Controller();
        string Phone;
        string waiterSSN;
        DataTable itemOrder;
        public menuForm(string phoneNumber, string waiterN, DataTable dataTable)
        {
            InitializeComponent();
            Phone = phoneNumber;
            waiterSSN = waiterN;
            itemOrder = dataTable;
            populatePanel();
            if (waiterSSN != null)
            {
                userName.Text = controllerobj.getEmployeeName(waiterSSN);
            }
            else
            {
                userName.Text = controllerobj.GetCustomerFName(Phone);
            }
        }

        private void populatePanel()
        {
            DataTable dt = controllerobj.GetMenuItemPrice();
            int rowCount = 0;
            foreach (DataRow dr in dt.Rows)
            {
                if (dr.Field<string>("ItemStatus") == "Available")
                {
                    menuItem Item = new menuItem();
                    Item.itemNameWrite = dr.Field<string>("ItemName");
                    Item.itemIDRead = dr.Field<int>("ItemID").ToString();
                    Item.itemCookWrite = dr.Field<Object>("CookingTime").ToString();
                    Item.itemPriceSet = dr.Field<decimal>("TotalPrice").ToString();
                    if (itemOrder.Rows.Count > 0)
                    {
                        if (itemOrder.Rows[rowCount].Field<int>("itemID") == dr.Field<int>("itemID"))
                        {
                            int count = (itemOrder.Rows[rowCount].Field<int>("itemCount"));
                            Item.itemCountRead = count.ToString();
                            if (itemOrder.Rows.Count > rowCount + 1)
                            {
                                rowCount++;
                            }
                        }
                    }
                    menuItems.Controls.Add(Item);
                }
            }
        }

        private void checkOut_Click(object sender, EventArgs e)
        {
            itemOrder.Clear();
            foreach (menuItem item in menuItems.Controls)
            {
                if (Convert.ToInt32(item.itemCountRead) > 0)
                {
                    DataRow row = itemOrder.NewRow();
                    row["itemID"] = Convert.ToInt32(item.itemIDRead);
                    row["itemName"] = item.itemNameWrite;
                    row["itemCount"] = Convert.ToInt32(item.itemCountRead);
                    row["itemPrice"] = decimal.Parse(item.itemPriceSet) * decimal.Parse(item.itemCountRead);
                    itemOrder.Rows.Add(row);
                }
                
            }
            makeOrder Order = new makeOrder(Phone, waiterSSN, itemOrder);
            Order.Show();
            Close();
        }

        private void homeButton_Click(object sender, EventArgs e)
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

        private void logout_Click(object sender, EventArgs e)
        {
            loginScreen logIn = new loginScreen();
            logIn.Show();
            Close();
        }

        private void orders_Click(object sender, EventArgs e)
        {
            orderHistory orders = new orderHistory(Phone, waiterSSN);
            orders.Show();
            Close();
        }
    }
}
