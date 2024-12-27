namespace Restaurant_DB
{
    partial class menuForm
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
            this.menuItems = new System.Windows.Forms.FlowLayoutPanel();
            this.checkOut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.orders = new System.Windows.Forms.PictureBox();
            this.menuBox = new System.Windows.Forms.PictureBox();
            this.logout = new System.Windows.Forms.PictureBox();
            this.userName = new System.Windows.Forms.Label();
            this.welcomeText = new System.Windows.Forms.Label();
            this.homeButton = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // menuItems
            // 
            this.menuItems.AutoScroll = true;
            this.menuItems.Location = new System.Drawing.Point(12, 74);
            this.menuItems.Name = "menuItems";
            this.menuItems.Size = new System.Drawing.Size(821, 335);
            this.menuItems.TabIndex = 0;
            // 
            // checkOut
            // 
            this.checkOut.Location = new System.Drawing.Point(591, 415);
            this.checkOut.Name = "checkOut";
            this.checkOut.Size = new System.Drawing.Size(176, 23);
            this.checkOut.TabIndex = 1;
            this.checkOut.Text = "Proceed to Checkout";
            this.checkOut.UseVisualStyleBackColor = true;
            this.checkOut.Click += new System.EventHandler(this.checkOut_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.orders);
            this.panel1.Controls.Add(this.menuBox);
            this.panel1.Controls.Add(this.logout);
            this.panel1.Controls.Add(this.userName);
            this.panel1.Controls.Add(this.welcomeText);
            this.panel1.Controls.Add(this.homeButton);
            this.panel1.Location = new System.Drawing.Point(12, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 64);
            this.panel1.TabIndex = 2;
            // 
            // orders
            // 
            this.orders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orders.Image = global::Restaurant_DB.Properties.Resources.history;
            this.orders.Location = new System.Drawing.Point(661, 9);
            this.orders.Name = "orders";
            this.orders.Size = new System.Drawing.Size(45, 40);
            this.orders.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.orders.TabIndex = 5;
            this.orders.TabStop = false;
            this.orders.Click += new System.EventHandler(this.orders_Click);
            // 
            // menuBox
            // 
            this.menuBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuBox.Image = global::Restaurant_DB.Properties.Resources.menu;
            this.menuBox.Location = new System.Drawing.Point(599, 9);
            this.menuBox.Name = "menuBox";
            this.menuBox.Size = new System.Drawing.Size(40, 40);
            this.menuBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuBox.TabIndex = 4;
            this.menuBox.TabStop = false;
            // 
            // logout
            // 
            this.logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout.Image = global::Restaurant_DB.Properties.Resources.logout;
            this.logout.Location = new System.Drawing.Point(763, 9);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(40, 40);
            this.logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logout.TabIndex = 3;
            this.logout.TabStop = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.ForeColor = System.Drawing.Color.White;
            this.userName.Location = new System.Drawing.Point(100, 36);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(67, 16);
            this.userName.TabIndex = 2;
            this.userName.Text = "username";
            // 
            // welcomeText
            // 
            this.welcomeText.AutoSize = true;
            this.welcomeText.BackColor = System.Drawing.Color.Black;
            this.welcomeText.ForeColor = System.Drawing.Color.White;
            this.welcomeText.Location = new System.Drawing.Point(100, 15);
            this.welcomeText.Name = "welcomeText";
            this.welcomeText.Size = new System.Drawing.Size(68, 16);
            this.welcomeText.TabIndex = 1;
            this.welcomeText.Text = "Welcome,";
            // 
            // homeButton
            // 
            this.homeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeButton.Image = global::Restaurant_DB.Properties.Resources.home;
            this.homeButton.Location = new System.Drawing.Point(16, 9);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(40, 40);
            this.homeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.homeButton.TabIndex = 0;
            this.homeButton.TabStop = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // menuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkOut);
            this.Controls.Add(this.menuItems);
            this.Name = "menuForm";
            this.Text = "menuForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel menuItems;
        private System.Windows.Forms.Button checkOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox homeButton;
        private System.Windows.Forms.Label welcomeText;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.PictureBox logout;
        private System.Windows.Forms.PictureBox menuBox;
        private System.Windows.Forms.PictureBox orders;
    }
}