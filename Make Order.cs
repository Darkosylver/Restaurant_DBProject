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
    public partial class Make_Order : Form
    {
        Controller controllerobj = new Controller();
        public Make_Order(string phoneNumber, string WaiterSSN)
        {
            InitializeComponent();
        }

        private void Make_Order_Load(object sender, EventArgs e)
        {
            DataTable dt = controllerobj.GetMenuItems();
            MenuItemsComboBox.DataSource = dt;
            MenuItemsComboBox.DisplayMember = "ItemName";
            MenuItemsComboBox.ValueMember = "ItemStatus";
            dataGridView1.DataSource = controllerobj.GetMenuItemPrice();
        }

        private void MenuItemsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ItemStatusTextBox.Text = MenuItemsComboBox.SelectedValue.ToString();
        }
    }
}
