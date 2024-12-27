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
                reportViewer1.Visible = true;
            }
        }

        private void orderHistory_Load(object sender, EventArgs e)
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
            }
            this.reportViewer1.RefreshReport();
        }
    }
}
