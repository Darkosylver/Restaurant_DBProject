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
    public partial class tablemanagement : Form
    {
        Controller controllerobj = new Controller();
        string storedssn;
        string phone;
        public tablemanagement(string phone, string ssn)
        {
            InitializeComponent();
            storedssn = ssn;
            this.phone = phone;
            waiterName.Text = controllerobj.getEmployeeName(ssn);
        }

        private void tableno_TextChanged(object sender, EventArgs e)
        {

        }
        public void refreshtables()
        {
            restauranttables.DataSource = controllerobj.gettables();
        }
        private void reserve_Click(object sender, EventArgs e)
        {
            controllerobj.reservetable(Convert.ToInt32(tableno.Text), phone);
            reserve.Enabled = false;
            deletetable.Enabled = false;
            freetable.Enabled = false;
            refreshtables();
            MessageBox.Show("added successfully");
        }

        private void deletetable_Click(object sender, EventArgs e)
        {

        }

        private void freetable_Click(object sender, EventArgs e)
        {

        }

        private void tablemanagement_Load(object sender, EventArgs e)
        {

        }

        private void reserve_Click_1(object sender, EventArgs e)
        {
            controllerobj.reservetable(Convert.ToInt32(tableno.Text), phone);
            reserve.Enabled = false;
            deletetable.Enabled = false;
            freetable.Enabled = false;
            refreshtables();
            MessageBox.Show("added successfully");
        }

        private void tableno_TextChanged_1(object sender, EventArgs e)
        {
            if (tableno.Text != "" && Convert.ToInt32(controllerobj.checktableexists(Convert.ToInt32(tableno.Text))) == 1 && Convert.ToInt32(controllerobj.checktablereserved(Convert.ToInt32(tableno.Text))) == 1)
            {
                tablelabel.Text = "already reserved";
                reserve.Enabled = false;
                freetable.Enabled = true;
                deletetable.Enabled = false;
            }
            else if (tableno.Text != "" && Convert.ToInt32(controllerobj.checktableexists(Convert.ToInt32(tableno.Text))) == 1)
            {
                tablelabel.Text = "";
                reserve.Enabled = true;
                freetable.Enabled = true;
                deletetable.Enabled = true;
            }
            else if (tableno.Text != "" && Convert.ToInt32(controllerobj.checktableexists(Convert.ToInt32(tableno.Text))) == 1)
            {
                tablelabel.Text = "";
                reserve.Enabled = false;
                freetable.Enabled = true;
                deletetable.Enabled = true;
            }
            else if (tableno.Text == "")
            {
                tablelabel.Text = "";
                reserve.Enabled = false;
                freetable.Enabled = false;
                deletetable.Enabled = false;
            }
            else if (Convert.ToInt32(controllerobj.checktableexists(Convert.ToInt32(tableno.Text))) != 1)
            {
                tablelabel.Text = "No table with the following number";
                reserve.Enabled = false;
                freetable.Enabled = false;
                deletetable.Enabled = false;
            }
        }

        private void freetable_Click_1(object sender, EventArgs e)
        {
            controllerobj.freetable(Convert.ToInt32(tableno.Text));
            reserve.Enabled = true;
            deletetable.Enabled = true;    
            refreshtables();
            MessageBox.Show("Table is now available");
        }

        private void deletetable_Click_1(object sender, EventArgs e)
        {
            controllerobj.deletetable(Convert.ToInt32(tableno.Text));
            deletetable.Enabled = false;
            freetable.Enabled = false;
            reserve.Enabled = false;
            refreshtables();
            MessageBox.Show("Table Deleted Successfully");
        }

        private void addtable_Click(object sender, EventArgs e)
        {
            controllerobj.inserttable();
            refreshtables();
            if (tableno.Text != "" && Convert.ToInt32(controllerobj.checktableexists(Convert.ToInt32(tableno.Text))) == 1)
            {
                tablelabel.Text = "";
                reserve.Enabled = true;
                freetable.Enabled = true;
                deletetable.Enabled = true;
            }
            else if (tableno.Text == "")
            {
                reserve.Enabled = false;
                freetable.Enabled = false;
                deletetable.Enabled = false;
            }
            else if (Convert.ToInt32(controllerobj.checktableexists(Convert.ToInt32(tableno.Text))) != 1)
            {
                tablelabel.Text = "No table with the following number";
                reserve.Enabled = false;
                freetable.Enabled = false;
                deletetable.Enabled = false;
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            refreshtables();
        }

        private void homeBox_Click(object sender, EventArgs e)
        {
            Hide();
            waiter homepage = new waiter(storedssn);
            homepage.ShowDialog();
            Close();
        }

        private void orderhistory_Click(object sender, EventArgs e)
        {
            Hide();
            orderHistory orders = new orderHistory(null, storedssn);
            orders.ShowDialog();
            Close();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
