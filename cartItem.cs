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
    public partial class cartItem : UserControl
    {
        public cartItem()
        {
            InitializeComponent();
        }

        public string itemNameSet
        {
            get { return cartItemName.Text; }
            set { cartItemName.Text = value; }
        }

        public string itemPriceGet
        {
            get { return cartItemPrice.Text; }
            set { cartItemPrice.Text = value; }
        }
    }
}
