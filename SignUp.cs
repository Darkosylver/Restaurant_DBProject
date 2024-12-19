﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public SignUp()
        {
            InitializeComponent();
        }

        private void firstName_TextChanged(object sender, EventArgs e)
        {
            if (firstName.Text != "" && lastName.Text != "" && address1.Text != "" && phoneNumber.Text != "" && passWord.Text != "" && confirmPassword.Text != "" && passWord.Text == confirmPassword.Text && ValidatePassword(passWord.Text))
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
            if (firstName.Text != "" && lastName.Text != "" && address1.Text != "" && phoneNumber.Text != "" && passWord.Text != "" && confirmPassword.Text != "" && passWord.Text == confirmPassword.Text && ValidatePassword(passWord.Text))
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
            if (firstName.Text != "" && lastName.Text != "" && address1.Text != "" && phoneNumber.Text != "" && passWord.Text != "" && confirmPassword.Text != "" && passWord.Text == confirmPassword.Text && ValidatePassword(passWord.Text))
            {
                submit.Enabled = true;
            }
            else
            {
                submit.Enabled = false;
            }
        }

        private void phoneNumber_TextChanged(object sender, EventArgs e)
        {
            if (firstName.Text != "" && lastName.Text != "" && address1.Text != "" && phoneNumber.Text != "" && passWord.Text != "" && confirmPassword.Text != "" && passWord.Text == confirmPassword.Text && ValidatePassword(passWord.Text))
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
            if (firstName.Text != "" && lastName.Text != "" && address1.Text != "" && phoneNumber.Text != "" && passWord.Text != "" && confirmPassword.Text != "" && passWord.Text == confirmPassword.Text && ValidatePassword(passWord.Text))
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
            if (firstName.Text != "" && lastName.Text != "" && address1.Text != "" && phoneNumber.Text != "" && passWord.Text != "" && confirmPassword.Text != "" && passWord.Text == confirmPassword.Text && ValidatePassword(passWord.Text))
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
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled= true;
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

        private void submit_Click(object sender, EventArgs e)
        {

        }
    }
}