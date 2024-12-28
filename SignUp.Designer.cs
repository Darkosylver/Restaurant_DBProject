namespace Restaurant_DB
{
    partial class SignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.firstName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.phoneNumber = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.passWord = new System.Windows.Forms.TextBox();
            this.confirmPassword = new System.Windows.Forms.TextBox();
            this.address1 = new System.Windows.Forms.TextBox();
            this.address2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.Label();
            this.pnumber = new System.Windows.Forms.Label();
            this.pword = new System.Windows.Forms.Label();
            this.cpword = new System.Windows.Forms.Label();
            this.add1 = new System.Windows.Forms.Label();
            this.add2 = new System.Windows.Forms.Label();
            this.addressExample = new System.Windows.Forms.Label();
            this.errorText = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(101, 66);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(189, 22);
            this.firstName.TabIndex = 0;
            this.firstName.TextChanged += new System.EventHandler(this.firstName_TextChanged);
            this.firstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstName_KeyPress);
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(101, 133);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(189, 22);
            this.lastName.TabIndex = 1;
            this.lastName.TextChanged += new System.EventHandler(this.lastName_TextChanged);
            this.lastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lastName_KeyPress);
            // 
            // phoneNumber
            // 
            this.phoneNumber.Location = new System.Drawing.Point(101, 205);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(189, 22);
            this.phoneNumber.TabIndex = 6;
            this.phoneNumber.TextChanged += new System.EventHandler(this.phoneNumber_TextChanged);
            this.phoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneNumber_KeyPress);
            // 
            // submit
            // 
            this.submit.Enabled = false;
            this.submit.Location = new System.Drawing.Point(80, 415);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 7;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // passWord
            // 
            this.passWord.Location = new System.Drawing.Point(101, 270);
            this.passWord.Name = "passWord";
            this.passWord.Size = new System.Drawing.Size(189, 22);
            this.passWord.TabIndex = 8;
            this.passWord.TextChanged += new System.EventHandler(this.passWord_TextChanged);
            // 
            // confirmPassword
            // 
            this.confirmPassword.Location = new System.Drawing.Point(101, 343);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.Size = new System.Drawing.Size(189, 22);
            this.confirmPassword.TabIndex = 9;
            this.confirmPassword.TextChanged += new System.EventHandler(this.confirmPassword_TextChanged);
            // 
            // address1
            // 
            this.address1.Location = new System.Drawing.Point(496, 66);
            this.address1.Name = "address1";
            this.address1.Size = new System.Drawing.Size(359, 22);
            this.address1.TabIndex = 10;
            this.address1.TextChanged += new System.EventHandler(this.address1_TextChanged);
            this.address1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.address1_KeyPress);
            // 
            // address2
            // 
            this.address2.Location = new System.Drawing.Point(496, 178);
            this.address2.Name = "address2";
            this.address2.Size = new System.Drawing.Size(359, 22);
            this.address2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(359, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 13;
            // 
            // fname
            // 
            this.fname.AutoSize = true;
            this.fname.Location = new System.Drawing.Point(40, 36);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(139, 16);
            this.fname.TabIndex = 14;
            this.fname.Text = "First Name (Required)";
            // 
            // lname
            // 
            this.lname.AutoSize = true;
            this.lname.Location = new System.Drawing.Point(40, 107);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(139, 16);
            this.lname.TabIndex = 15;
            this.lname.Text = "Last Name (Required)";
            // 
            // pnumber
            // 
            this.pnumber.AutoSize = true;
            this.pnumber.Location = new System.Drawing.Point(40, 178);
            this.pnumber.Name = "pnumber";
            this.pnumber.Size = new System.Drawing.Size(164, 16);
            this.pnumber.TabIndex = 16;
            this.pnumber.Text = "Phone Number (Required)";
            // 
            // pword
            // 
            this.pword.AutoSize = true;
            this.pword.Location = new System.Drawing.Point(40, 244);
            this.pword.Name = "pword";
            this.pword.Size = new System.Drawing.Size(134, 16);
            this.pword.TabIndex = 17;
            this.pword.Text = "Password (Required)";
            // 
            // cpword
            // 
            this.cpword.AutoSize = true;
            this.cpword.Location = new System.Drawing.Point(40, 321);
            this.cpword.Name = "cpword";
            this.cpword.Size = new System.Drawing.Size(115, 16);
            this.cpword.TabIndex = 18;
            this.cpword.Text = "Confirm Password";
            // 
            // add1
            // 
            this.add1.AutoSize = true;
            this.add1.Location = new System.Drawing.Point(432, 36);
            this.add1.Name = "add1";
            this.add1.Size = new System.Drawing.Size(132, 16);
            this.add1.TabIndex = 19;
            this.add1.Text = "Address1 (Required)";
            // 
            // add2
            // 
            this.add2.AutoSize = true;
            this.add2.Location = new System.Drawing.Point(432, 149);
            this.add2.Name = "add2";
            this.add2.Size = new System.Drawing.Size(126, 16);
            this.add2.TabIndex = 20;
            this.add2.Text = "Address2 (Optional)";
            // 
            // addressExample
            // 
            this.addressExample.AutoSize = true;
            this.addressExample.Location = new System.Drawing.Point(493, 107);
            this.addressExample.Name = "addressExample";
            this.addressExample.Size = new System.Drawing.Size(143, 16);
            this.addressExample.TabIndex = 21;
            this.addressExample.Text = "e.g: City,Street,Building";
            // 
            // errorText
            // 
            this.errorText.AutoSize = true;
            this.errorText.ForeColor = System.Drawing.Color.Red;
            this.errorText.Location = new System.Drawing.Point(98, 456);
            this.errorText.Name = "errorText";
            this.errorText.Size = new System.Drawing.Size(35, 16);
            this.errorText.TabIndex = 22;
            this.errorText.Text = "error";
            this.errorText.Visible = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(215, 415);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 23;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(960, 519);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.errorText);
            this.Controls.Add(this.addressExample);
            this.Controls.Add(this.add2);
            this.Controls.Add(this.add1);
            this.Controls.Add(this.cpword);
            this.Controls.Add(this.pword);
            this.Controls.Add(this.pnumber);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.address2);
            this.Controls.Add(this.address1);
            this.Controls.Add(this.confirmPassword);
            this.Controls.Add(this.passWord);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Name = "SignUp";
            this.Text = "Sign up";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox phoneNumber;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox passWord;
        private System.Windows.Forms.TextBox confirmPassword;
        private System.Windows.Forms.TextBox address1;
        private System.Windows.Forms.TextBox address2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label fname;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.Label pnumber;
        private System.Windows.Forms.Label pword;
        private System.Windows.Forms.Label cpword;
        private System.Windows.Forms.Label add1;
        private System.Windows.Forms.Label add2;
        private System.Windows.Forms.Label addressExample;
        private System.Windows.Forms.Label errorText;
        private System.Windows.Forms.Button cancelButton;
    }
}