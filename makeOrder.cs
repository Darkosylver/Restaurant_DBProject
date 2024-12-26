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
            populatePanel();
        }

        private void populatePanel()
        {
            foreach (DataRow dr in itemOrder.Rows)
            {
                cartItem item = new cartItem();
                item.itemNameSet = dr.Field<int>("itemCount").ToString() + "x" + dr.Field<string>("itemName");
                realCartItems.Controls.Add(item);
            }
        }

        private void Make_Order_Load(object sender, EventArgs e)
        { 
        }

        private void update_Click(object sender, EventArgs e)
        {
            Hide();
            menuForm menu = new menuForm(Phone, waiterSSN, itemOrder);
            menu.ShowDialog();
            Close();
        }
    }
}
