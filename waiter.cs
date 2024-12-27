using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_DB // okay so before we start let's agree on smth.. if you find any bugs leave me alone
{
    public partial class waiter : Form
    {
        
        Controller controllerobj = new Controller(); 
        string storedssn;
        public waiter(string ssn)
        {
            InitializeComponent();
            storedssn = ssn;
            customerinfo.Enabled = false;
            tablemanagement.Enabled = false;
            order.Enabled = false;
            waiterName.Text = controllerobj.getEmployeeName(ssn);
        }

        private void waiter_Load(object sender, EventArgs e)
        {

        }    
        private void phoneno_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(controllerobj.checkcustomerexist(phoneno.Text)) == 1)
            {
                customerinfo.Enabled = true;
                tablemanagement.Enabled = true;
                order.Enabled = true;
            }
            else
            {
                customerinfo.Enabled = false;
                tablemanagement.Enabled = false;
                order.Enabled = false;
            }
        }
        private void order_Click(object sender, EventArgs e)
        {
            Hide();
            DataTable itemOrder = new DataTable("orderedItems");
            itemOrder.Columns.Add("itemID", typeof(int));
            itemOrder.Columns.Add("itemName", typeof(string));
            itemOrder.Columns.Add("itemCount", typeof(int));
            itemOrder.Columns.Add("itemPrice", typeof(float));
            menuForm menu = new menuForm(phoneno.Text, storedssn, itemOrder);
            menu.ShowDialog();
            Close();
        }

        private void tablemanagement_Click(object sender, EventArgs e)
        {
            Form form = new tablemanagement(phoneno.Text,storedssn);
        }

        private void customerinfo_Click(object sender, EventArgs e)
        {
            Form form = new updateuser(phoneno.Text,storedssn);
        }

        private void orderLog_Click(object sender, EventArgs e)
        {
            Hide();
            orderHistory orders = new orderHistory(null,storedssn);
            orders.ShowDialog();
            Close();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
