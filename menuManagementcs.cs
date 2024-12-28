using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Restaurant_DB
{
    public partial class menuManagementcs : Form
    {
        Controller controllerobj = new Controller();
        string chefSSN;
        public menuManagementcs(string chefN)
        {
            InitializeComponent();
            chefSSN = chefN;
            userName.Text = controllerobj.getEmployeeName(chefSSN);
            DataTable ssnchef = controllerobj.SlectChefSSN();
            DataTable ssnchef2 = controllerobj.SlectChefSSN();
            if (ssnchef != null && ssnchef.Rows.Count > 0)
            {
                chefSN.DataSource = ssnchef;
                chefSN.DisplayMember = "SSN";
            }
            else
            {
                chefSN.DataSource = null;
            }
        }

        private void homeBox_Click(object sender, EventArgs e)
        {
            Hide();
            Chef homePage = new Chef(chefSSN);
            homePage.ShowDialog();
            Close();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void itemName_TextChanged(object sender, EventArgs e)
        {
            if (itemName.Text == "" || cookingTime.Text == "" || controllerobj.getMenuItemID(itemName.Text) != null || !validateTime(cookingTime.Text))
            {
                itemAdd.Enabled = false;
            }
            else
            {
                itemAdd.Enabled = true;
            }
        }

        private void cookingTime_TextChanged(object sender, EventArgs e)
        {
            if (itemName.Text == "" || cookingTime.Text == "" || controllerobj.getMenuItemID(itemName.Text) != null || !validateTime(cookingTime.Text))
            {
                itemAdd.Enabled = false;
            }
            else
            {
                itemAdd.Enabled = true;
            }
        }

        private void itemName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar!=' ')
            {
                e.Handled = true;
            }
        }

        private void cookingTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar == ':'))
            {
                e.Handled = true;
            }
            if (e.KeyChar == ':' && cookingTime.Text.IndexOf(":") != cookingTime.Text.LastIndexOf(":"))
            {
                e.Handled = true;
            }
        }
        public static bool validateTime(string cookingTime)
        {

            string pattern = @"^(?:[01]\d|2[0-3]):[0-5]\d:[0-5]\d$";
            return Regex.IsMatch(cookingTime, pattern);
        }
        //private bool validateTime(string input)
        //{
        //    // Regular expression to match the format HH:MM:SS
            
        //    //Checking there are 2 colons, not 1
        //    if (input.IndexOf(":") == -1 || input.LastIndexOf(":") == input.IndexOf(":"))
        //    {
        //        return false;
        //    }
        //    //Checking that each entry is there
        //    if (input.IndexOf(":") == 0 || input.LastIndexOf(":") == input.IndexOf(":") + 1 || input.LastIndexOf(":") == input.Length - 1)
        //    {
        //        return false;
        //    }
        //    return true;
        //}

        private void itemAdd_Click(object sender, EventArgs e)
        {
            int result = controllerobj.insertMenuItem(itemName.Text, cookingTime.Text, chefSN.Text);
            MessageBox.Show("New menu item added");
            int itemID = Convert.ToInt32(controllerobj.getMenuItemID(itemName.Text));
            Hide();
            DataTable dt = new DataTable("Dummy");
            menuForm addToItem = new menuForm(null, null, chefSSN, 1, itemID, dt);
            addToItem.ShowDialog();
            Close();
        }

        private void itemRemove_Click(object sender, EventArgs e)
        {
            Hide();
            DataTable dt = new DataTable("Dummy");
            menuForm addToItem = new menuForm(null, null, chefSSN, 2, 0, dt);
            addToItem.ShowDialog();
            Close();
        }

        private void ingredientRemove_Click(object sender, EventArgs e)
        {
            Hide();
            DataTable dt = new DataTable("Dummy");
            menuForm addToItem = new menuForm(null, null, chefSSN, 0, 0, dt);
            addToItem.ShowDialog();
            Close();
        }

        private void ingredientName_TextChanged(object sender, EventArgs e)
        {
            if (ingredientName.Text != "" && ingredientCount.Text != "" && ingredientPrice.Text != "" && controllerobj.getMenuItemID(ingredientName.Text) == null)
            {
                ingredientAdd.Enabled = true;
            }
            else
            {
                ingredientAdd.Enabled = false;
            }
        }

        private void ingredientCount_TextChanged(object sender, EventArgs e)
        {
            if (ingredientName.Text != "" && ingredientCount.Text != "" && ingredientPrice.Text != "" && controllerobj.getMenuItemID(ingredientName.Text) == null)
            {
                ingredientAdd.Enabled = true;
            }
            else
            {
                ingredientAdd.Enabled = false;
            }
        }

        private void ingredientPrice_TextChanged(object sender, EventArgs e)
        {
            if (ingredientName.Text != "" && ingredientCount.Text != "" && ingredientPrice.Text != "" && controllerobj.getMenuItemID(ingredientName.Text) == null)
            {
                ingredientAdd.Enabled = true;
            }
            else
            {
                ingredientAdd.Enabled = false;
            }
        }

        private void ingredientName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ingredientCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ingredientPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && ingredientPrice.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
            }
        }

        private void ingredientAdd_Click(object sender, EventArgs e)
        {
            controllerobj.addIngredient(ingredientName.Text, Convert.ToInt32(ingredientCount.Text), Convert.ToDecimal(ingredientPrice.Text));
            successMessage.Visible = true;
        }

        private void menuManagementcs_Load(object sender, EventArgs e)
        {

        }
    }
}
