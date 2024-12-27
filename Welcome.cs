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
    public partial class Welcome : Form
    {
        Controller controllerobj = new Controller();
        string Phone;
        string waiterSSN = null;
        public Welcome(string phoneNumber)
        {
            InitializeComponent();
            if (phoneNumber == null)
            {
                CustomerNameLabel.Text = "Guest";
                UpdatePersonalInfoButton.Text = "LogIn";
            }
            else
            {
                CustomerNameLabel.Text = controllerobj.GetCustomerFName(phoneNumber);
                Phone = phoneNumber;
            } 
        }

        private void CustomerNameLabel_Click(object sender, EventArgs e)
        {
            //For Ziko: Add something to show the customer Data, thank you
        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }

        private void UpdatePersonalInfoButton_Click(object sender, EventArgs e)
        {
            if (Phone != null)
            {
                Hide();
                Update_Customer_Personal_Info update = new Update_Customer_Personal_Info(Phone);
                update.ShowDialog();
                Close();
            }
            else
            {
                Hide();
                loginScreen login = new loginScreen();
                login.ShowDialog();
                Close();
            }
        }

        private void homePicture_Click(object sender, EventArgs e)
        {
            
        }

        private void menuBox_Click(object sender, EventArgs e)
        {
            if (Phone != null)
            {
                Hide();
                DataTable itemOrder = new DataTable("orderedItems");
                itemOrder.Columns.Add("itemID", typeof(int));
                itemOrder.Columns.Add("itemName", typeof(string));
                itemOrder.Columns.Add("itemCount", typeof(int));
                itemOrder.Columns.Add("itemPrice", typeof(float));
                menuForm menu = new menuForm(Phone, waiterSSN, itemOrder);
                menu.ShowDialog();
                Show();
            }
            else
            {
                MessageBox.Show("Please Log in first");
            }
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void orderHistory_Click(object sender, EventArgs e)
        {
            if (Phone != null)
            {
                Hide();
                orderHistory orders = new orderHistory(Phone, waiterSSN);
                orders.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Please Log in first");
            }
        }

        private void welcomePic_Click(object sender, EventArgs e)
        {

        }
    }
}
