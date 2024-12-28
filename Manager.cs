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
    public partial class Manager : Form
    {
        Controller controllerobj = new Controller();
        string storedssn;
        public Manager(string ssn)
        {
            InitializeComponent();
            
            storedssn = ssn;
        }

        private void ReviewOrderDetails_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerobj.ReviewOrder();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerobj.viewPendingOrder();
            dataGridView1.DataSource = dt;
             dataGridView1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form customer= new Modify_Customer(storedssn);
            customer.ShowDialog();
        }

        private void Manager_Load(object sender, EventArgs e)
        {

        }
    }
}
