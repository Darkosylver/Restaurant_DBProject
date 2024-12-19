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
        public Welcome(string phoneNumber)
        {
            InitializeComponent();
            CustomerNameLabel.Text = controllerobj.GetCustomerFName(phoneNumber);
        }

        private void CustomerNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }
    }
}
