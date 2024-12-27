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
        string chefSSN;
        int menuItem;
        DataTable itemOrder;
        int function; //0 for Remove Ingredient, 1 for Add Ingredients to menu item, 2 for Remove menu item
        public menuForm(string phoneNumber, string waiterN, string chefN,int whatDo,int itemID, DataTable dataTable)
        {
            InitializeComponent();
            Phone = phoneNumber;
            waiterSSN = waiterN;
            chefSSN = chefN;
            function = whatDo;
            menuItem = itemID;
            itemOrder = dataTable;
            if (function == 0 || function == 2 && chefSSN != null)
            {
                checkOut.Text = "Confirm Remove";
            }
            else if (function == 1 && chefSSN != null)
            {
                checkOut.Text = "Confirm";
            }
            populatePanel();
            if (waiterSSN != null)
            {
                userName.Text = controllerobj.getEmployeeName(waiterSSN);
                orders.Enabled = false;
                orders.Visible = false;
            }
            else if (chefSSN != null)
            {
                userName.Text = controllerobj.getEmployeeName(chefSSN);
            }
            else
            {
                userName.Text = controllerobj.GetCustomerFName(Phone);
            }
        }

        private void populatePanel()
        {
            if (chefSSN == null)
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
            else
            {
                DataTable dt;
                if (function == 0 || function == 1)
                {
                    dt = controllerobj.getIngredients();
                }
                else
                {
                    dt = controllerobj.GetMenuItemPrice();
                }
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        menuItem Item = new menuItem();
                        if (function == 0 || function == 2)
                        {
                            Item.baggageControl = false;
                        }
                        if (function == 0 || function == 1)
                        {
                            {
                                Item.itemNameWrite = dr.Field<string>("IngredientName");
                                Item.itemIDRead = dr.Field<int>("IngredientID").ToString();
                                Item.cookWrite = "Available Stock:";
                                Item.itemCookWrite = dr.Field<int>("IngredientStock").ToString();
                                Item.itemPriceSet = dr.Field<decimal>("IngredientPrice").ToString();
                                menuItems.Controls.Add(Item);
                            }
                        }
                        else
                        {
                            Item.itemNameWrite = dr.Field<string>("ItemName");
                            Item.itemIDRead = dr.Field<int>("ItemID").ToString();
                            Item.itemCookWrite = dr.Field<Object>("CookingTime").ToString();
                            Item.itemPriceSet = dr.Field<decimal>("TotalPrice").ToString();
                            menuItems.Controls.Add(Item);
                        }
                    }
                }
            }
        }

        private void checkOut_Click(object sender, EventArgs e)
        {
            if (chefSSN == null)
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
                Hide();
                makeOrder Order = new makeOrder(Phone, waiterSSN, itemOrder);
                Order.ShowDialog();
                Close();
            }
            else
            {
                if (function == 0 || function == 2)
                {
                    foreach (menuItem item in menuItems.Controls)
                    {
                        if (item.getItemColor == Color.DarkRed)
                        {
                            if (function == 0)
                            {
                                controllerobj.deleteIngredient(Convert.ToInt32(item.itemIDRead));
                            }
                            else
                            {
                                controllerobj.deleteMenuItem(Convert.ToInt32(item.itemIDRead));
                            }
                        }
                    }
                }
                else
                {
                    foreach (menuItem item in menuItems.Controls)
                    {
                        if (Convert.ToInt32(item.itemCountRead) > 0)
                        {
                            controllerobj.addIngredientToItem(Convert.ToInt32(item.itemIDRead), menuItem, Convert.ToInt32(item.itemCountRead));
                        }
                    }
                }
                Hide();
                Chef chef = new Chef(chefSSN);
                chef.ShowDialog();
                Close();
            }
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            if (waiterSSN != null)
            {
                Hide();
                waiter Waiter = new waiter(waiterSSN);
                Waiter.ShowDialog();
                Close();
            }
            else if (Phone != null)
            {
                Hide();
                Welcome homePage = new Welcome(Phone);
                homePage.ShowDialog();
                Close();
            }
            else
            {
                Hide();
                Chef chefPage = new Chef(chefSSN);
                chefPage.ShowDialog();
                Close();
            }
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void orders_Click(object sender, EventArgs e)
        {
            Hide();
            orderHistory orders = new orderHistory(Phone, waiterSSN);
            orders.ShowDialog();
            Close();
        }
    }
}
