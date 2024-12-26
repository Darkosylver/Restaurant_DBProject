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
    public partial class menuItem : UserControl
    {
        public menuItem()
        {
            InitializeComponent();
        }

        public string itemNameWrite
        {
            get { return itemName.Text; }
            set { itemName.Text = value; }
        }

        public string itemDescriptionWrite
        {
            get { return itemDescription.Text; }
            set { itemDescription.Text = value; }
        }

        public string itemCountRead
        {
            get { return itemCount.Text; }
            set { itemCount.Text = value; }
        }

        public string itemIDRead
        {
            get { return itemID.Text; }
            set { itemID.Text = value; }
        }

        public string itemCookWrite
        {
            get { return timeCook.Text; }
            set { timeCook.Text = value; }
        }

        public string itemPriceSet
        {
            get { return itemPrice.Text; }
            set { itemPrice.Text = value; }
        }
        private void itemCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {

                e.Handled = true;
            }
        }

        private void itemAdd_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(itemCount.Text);
            count++;
            itemCount.Text = count.ToString();
        }

        private void itemSub_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(itemCount.Text);
            if (count > 0)
            {
                count--;
            }
            itemCount.Text = count.ToString();
        }
    }
}
