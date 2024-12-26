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
            CustomerNameLabel.Text = controllerobj.GetCustomerFName(phoneNumber);
            Phone=phoneNumber;
        }

        private void CustomerNameLabel_Click(object sender, EventArgs e)
        {
            //For Ziko: Add something to show the customer Data, thank you
        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }

        private void MenuButton_Click(object sender, EventArgs e)
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

        private void UpdatePersonalInfoButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update_Customer_Personal_Info update = new Update_Customer_Personal_Info(Phone);
            update.ShowDialog();
            this.Show();
        }

        private void homePicture_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Visible=false;
            welcomePanel.Visible=true;
        }

        private void menuBox_Click(object sender, EventArgs e)
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

        private void logOut_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void orderHistory_Click(object sender, EventArgs e)
        {
            welcomePanel.Visible = false;
            dataGridView1.DataSource = controllerobj.LoadCustomerOrders(Phone);
            dataGridView1.Visible = true;
        }
    }
}
