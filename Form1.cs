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
    public partial class Form1 : Form
    {
        Controller controller = new Controller();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void userName_TextChanged(object sender, EventArgs e)
        {
            if (userName.Text != "" && passWord.Text != "")
            {
                logIn.Enabled = true;
            }
        }

        private void passWord_TextChanged(object sender, EventArgs e)
        {
            if (userName.Text != "" && passWord.Text != "")
            {
                logIn.Enabled = true;
            }
        }

        private void logIn_Click(object sender, EventArgs e)
        {
            
            if (controller.findPassword(userName.Text) == null)
            {
                label3.Visible = true;
            }
            else
            {
                if (controller.findPassword(userName.Text).ToString() == passWord.Text)
                {
                    label3.Text = "Welcome";
                }
                label3.Visible = true;
            }
        }
    }
}
