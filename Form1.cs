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
                if (controller.findPassword(userName.Text).ToString() != passWord.Text && controller.VerifyCustonmer(userName.Text,passWord.Text)=="")
                {
                    label3.Text = "Incorrect Password, Please try again";
                }
                else if (controller.VerifyCustonmer(userName.Text, passWord.Text) != "")
                {
                    Form newform = new Welcome((userName.Text));
                    newform.ShowDialog();
                }
                else
                {
                    string position = controller.findPosition(userName.Text).ToString();
                    label3.ForeColor = Color.RoyalBlue;
                    label3.Text = "Welcome, " + position;
                    if (position == "Waiter")
                    {
                        Form newform = new waiter(userName.Text);
                        newform.ShowDialog();
                    }
                    //use this to know which form to load after the login
                }
            }
            label3.Visible = true;
                           
        }

        private void signUp_MouseClick(object sender, MouseEventArgs e)
        {
            Hide();
            SignUp sign = new SignUp();
            sign.ShowDialog();
            Show();
        }


    }
}
