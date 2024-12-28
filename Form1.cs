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
            encryptor encrypt = new encryptor();
            string encryptedpassword = encrypt.HashText(passWord.Text);
            if (controller.findPassword(userName.Text) == null)
            {
                label3.Text = "Incorrect Credentials, Please check username";
                label3.Visible = true;
            }
            else
            {
                if (controller.findPassword(userName.Text).ToString() !=  encryptedpassword)
                {
                    label3.Text = "Incorrect Password, Please try again";
                    label3.Visible = true;
                }
                else if (controller.VerifyCustomer(userName.Text) != "" && controller.findPassword(userName.Text).ToString() == encryptedpassword)
                {
                    Hide();
                    Form newform = new Welcome((userName.Text));
                    newform.ShowDialog();
                    Show();
                    passWord.Text = "";
                    label3.Visible=false;
                }
                else
                {
                    string position = controller.findPosition(userName.Text).ToString();
                    if (position == "Waiter")
                    {
                        Hide();
                        Form newform = new waiter(userName.Text);
                        newform.ShowDialog();
                        Show();
                        passWord.Text = "";
                        label3.Visible = false;
                    }
                    
                    if(position == "Manager")
                    {
                        //open manager form
                        Form fman = new Manager(userName.Text);
                        fman.ShowDialog();
                    }
                    if (position== "Chef")
                    {
                        Form chef = new Chef(userName.Text);
                        chef.ShowDialog();
                    
                    }
                }
            }               
        }

        private void signUp_MouseClick(object sender, MouseEventArgs e)
        {
            Hide();
            SignUp sign = new SignUp(null);
            sign.ShowDialog();
            Show();
        }

        private void logIn_MouseEnter(object sender, EventArgs e)
        {
            logIn.BackColor = Color.SpringGreen;
        }

        private void logIn_MouseLeave(object sender, EventArgs e)
        {
            logIn.BackColor = Color.Cyan;
        }

        private void guestLogin_Click(object sender, EventArgs e)
        {
            Hide();
            Welcome homePage = new Welcome(null);
            homePage.ShowDialog();
            Close();
        }
    }
}
