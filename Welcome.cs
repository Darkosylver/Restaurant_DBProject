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

        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }

        private void MenuButton_Click(object sender, EventArgs e)
        {

        }

        private void ShowOrdersButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controllerobj.LoadCustomerOrders(Phone);
        }

        private void MakeOrderButton_Click(object sender, EventArgs e)
        {
            Make_Order order = new Make_Order(Phone, waiterSSN);
            order.Show();
        }
    }
}
