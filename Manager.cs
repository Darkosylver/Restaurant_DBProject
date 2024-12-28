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

        private void RestaurantIncomeButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controllerobj.GetRestaurantIncome();
        }

        private void RestaurantSpendingButton_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Restaurant Spending", typeof(decimal));
            float spending = controllerobj.GetRestaurantSpendingOnIngredients() + controllerobj.GetTotalSalaries();
            dt.Rows.Add(spending);
            dataGridView1.DataSource = dt;
        }

        private void RevenueButton_Click(object sender, EventArgs e)
        {
            //we first calculate total income
            DataTable incomeDt = controllerobj.GetRestaurantIncome();
            float totalIncome = Convert.ToSingle(incomeDt.Rows[0].ItemArray[0]);

            //we then calculate total spending
            float spending = controllerobj.GetRestaurantSpendingOnIngredients() + controllerobj.GetTotalSalaries();

            //calculate profit
            float profit = totalIncome - spending;

            //create new data table to show profit
            DataTable dt = new DataTable();
            dt.Columns.Add("Profit", typeof(decimal));
            dt.Rows.Add(profit);
            dataGridView1.DataSource = dt;
        }

        private void top3ItemsButton_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerobj.GetTopThreeMostOrderedItems();
            dataGridView1.DataSource = dt;
        }

        private void employeesWorkingHoursButton_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerobj.GetEmployeesByWorkingHours();
            dataGridView1.DataSource = dt;
        }
    }
}
