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
    public partial class loginScreen : Form
    {
        Controller controller = new Controller();
        public loginScreen()
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
                label3.Text = "Incorrect Credentials, Please check username";
            }
            else
            {
                if (controller.findPassword(userName.Text).ToString() != passWord.Text)
                {
                    label3.Text = "Incorrect Password, Please try again";
                }
                else
                {
                    label3.Text = "Welcome";
                    string position = controller.findPosition(userName.Text).ToString();
                    //use this to know which form to load after the login
                }
            }
            label3.Visible = true;
                           
        }
    }
}
