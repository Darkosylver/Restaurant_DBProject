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
            this.submit.Location = new System.Drawing.Point(101, 437);
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
            // 
            // address2
            // 
            this.address2.Location = new System.Drawing.Point(496, 133);
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
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 519);
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
            this.Text = "SignUp";
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
    }
}