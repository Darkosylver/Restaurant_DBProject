using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_DB
{
    public partial class SignUp : Form
    {
        string waiterSSN;
        Controller controllerobj = new Controller();
        encryptor encryptorobj = new encryptor();
        public SignUp(string waiterSSN)
        {
            InitializeComponent();
            this.waiterSSN = waiterSSN;
        }

        private void firstName_TextChanged(object sender, EventArgs e)
        {
            if (validateSubmit())
            {
                submit.Enabled = true;
            }
            else
            {
                submit.Enabled = false; 
            }
        }

        private void lastName_TextChanged(object sender, EventArgs e)
        {
            if (validateSubmit())
            {
                submit.Enabled = true;
            }
            else
            {
                submit.Enabled = false;
            }
        }

        private void address1_TextChanged(object sender, EventArgs e)
        {
            if (validateSubmit())
            {
                submit.Enabled = true;
            }
            else
            {
                if (!validateAddress(address1.Text))
                {
                    //Add a label to show user the correct way to input the address
                }
                submit.Enabled = false;
            }
        }

        private void phoneNumber_TextChanged(object sender, EventArgs e)
        {
            if (validateSubmit())
            {
                submit.Enabled = true;
            }
            else
            {
                submit.Enabled = false;
            }
        }

        private void passWord_TextChanged(object sender, EventArgs e)
        {
            ValidatePassword(passWord.Text);
            if(validateSubmit())
            {
                submit.Enabled = true;
            }
            else
            {
                submit.Enabled = false;
            }
        }

        private void confirmPassword_TextChanged(object sender, EventArgs e)
        {
            if(validateSubmit())
            {
                label2.Text = "";
                submit.Enabled = true;
            }
            else
            {
                if (passWord.Text != confirmPassword.Text)
                {
                    label2.Text = "Passwords should be an exact match";
                    label2.ForeColor = Color.Red;
                }
                else
                {
                    label2.Text = "";
                }
                submit.Enabled = false;
            }
        }

        private void firstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void lastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void phoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (phoneNumber.TextLength == 11 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                
                e.Handled= true;
            }
        }

        private void address1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',' && address1.Text.IndexOf(",") != address1.Text.LastIndexOf(","))
            {
                e.Handled = true;
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            string fName = firstName.Text;
            string lName = lastName.Text;
            string pWord = encryptorobj.HashText(passWord.Text);
            string address = address1.Text;
            int cityLength = address.IndexOf(",");
            int streetLength = address.LastIndexOf(",") - (address.IndexOf(",") + 1);
            int buildingLength = address.Length - (address.LastIndexOf(",") + 1);
            string city = address1.Text.Substring(0, cityLength);
            string street = address1.Text.Substring((address.IndexOf(",") + 1), streetLength);
            string building = address1.Text.Substring((address.LastIndexOf(",") + 1), buildingLength);
            
            int locationID = 0;
            if (controllerobj.checklocationexist(city,street,building) == null)
            {
                controllerobj.insertlocationid(city,street,building);
                locationID = int.Parse(controllerobj.checklocationexist(city, street, building).ToString());
            }
            else
            {
                locationID = int.Parse(controllerobj.checklocationexist(city, street, building).ToString());
            }

            string ssnCheck = controllerobj.VerifyCustomer(phoneNumber.Text);
            if (ssnCheck == "")
            {
                
                controllerobj.addCustomer(phoneNumber.Text, fName, lName, pWord);
                controllerobj.insertlocation(phoneNumber.Text, locationID);
                Hide();
                if (waiterSSN == null)
                {
                    Welcome homePage = new Welcome(phoneNumber.Text);
                    homePage.ShowDialog();
                    
                }
                else
                {
                    waiter homePage = new waiter(waiterSSN);
                    homePage.ShowDialog();
                }
                Close();
            }
            else if (ssnCheck == fName)
            {
                errorText.Text = "This account already exists";
                errorText.Visible = true;
            }
            else
            {
                errorText.Text = "There already exists an account with the same number";
                errorText.Visible = true;
            }
        }

        private bool ValidatePassword(string password)
        {
            var input = password;

            if (string.IsNullOrWhiteSpace(input))
            {
                label1.Text = "Password should not be empty";
            }

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMiniMaxChars = new Regex(@".{8,15}");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (!hasLowerChar.IsMatch(input))
            {
                label1.Text = "Password should contain at least one lower case letter.";
                label1.ForeColor = Color.Red;
                return false;
            }
            else if (!hasUpperChar.IsMatch(input))
            {
                label1.Text = "Password should contain at least one upper case letter.";
                label1.ForeColor = Color.Red;
                return false;
            }
            else if (!hasMiniMaxChars.IsMatch(input))
            {
                label1.Text = "Password should not be lesser than 8 or greater than 15 characters.";
                label1.ForeColor = Color.Red;
                return false;
            }
            else if (!hasNumber.IsMatch(input))
            {
                label1.Text = "Password should contain at least one numeric value.";
                label1.ForeColor = Color.Red;
                return false;
            }

            else if (!hasSymbols.IsMatch(input))
            {
                label1.Text = "Password should contain at least one special case character.";
                label1.ForeColor = Color.Red;
                return false;
            }
            else
            {
                label1.Text = "Password Accepted";
                label1.ForeColor = Color.RoyalBlue;
                return true;
            }
        }

        private bool validateAddress(string input)
        {
            //Checking there are 2 commas, not 1
            if (input.IndexOf(",") == -1 || input.LastIndexOf(",") == input.IndexOf(",")) 
            {
                return false;
            }
            //Checking that each entry is there
            if (input.IndexOf(",") == 0 || input.LastIndexOf(",") == input.IndexOf(",") + 1 || input.LastIndexOf(",") == input.Length-1) 
            {
                return false;
            }
            return true;
        }

        private bool validateAddressOptional(string input)
        {
            if (input == "")
            {
                return true;
            }
            else
            {
                //Checking there are 2 commas, not 1
                if (input.IndexOf(",") == -1 || input.LastIndexOf(",") == input.IndexOf(",")) 
                {
                    return false;
                }
                //Checking that each entry is there
                if (input.IndexOf(",") == 0 || input.LastIndexOf(",") == input.IndexOf(",") + 1 || input.LastIndexOf(",") == input.Length - 1) 
                {
                    return false;
                }
                return true;
            }
        }

        private bool validateSubmit()
        {
            if (firstName.Text != "" && lastName.Text != "" && address1.Text != "" && phoneNumber.Text != "" && passWord.Text != "" && confirmPassword.Text != "" && passWord.Text == confirmPassword.Text && ValidatePassword(passWord.Text) && validateAddress(address1.Text))
            {
                return true;
            }
            return false;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Hide();
            if (waiterSSN == null)
            {
                Welcome homePage = new Welcome(null);
                homePage.ShowDialog();
            }
            else
            {
                Welcome homePage = new Welcome(waiterSSN);
                homePage.ShowDialog();
            }
            Close();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
