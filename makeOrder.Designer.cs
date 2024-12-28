namespace Restaurant_DB
{
    partial class makeOrder
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
            this.update = new System.Windows.Forms.Button();
            this.confirm = new System.Windows.Forms.Button();
            this.total = new System.Windows.Forms.Label();
            this.totalPrice = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.orders = new System.Windows.Forms.PictureBox();
            this.logout = new System.Windows.Forms.PictureBox();
            this.menuBox = new System.Windows.Forms.PictureBox();
            this.userName = new System.Windows.Forms.Label();
            this.welcome = new System.Windows.Forms.Label();
            this.homePage = new System.Windows.Forms.PictureBox();
            this.realCartItems = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homePage)).BeginInit();
            this.SuspendLayout();
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(83, 309);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(104, 23);
            this.update.TabIndex = 5;
            this.update.Text = "Update Cart";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(399, 309);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(75, 23);
            this.confirm.TabIndex = 6;
            this.confirm.Text = "Confirm";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(396, 276);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(41, 16);
            this.total.TabIndex = 9;
            this.total.Text = "Total:";
            this.total.Visible = false;
            // 
            // totalPrice
            // 
            this.totalPrice.AutoSize = true;
            this.totalPrice.Location = new System.Drawing.Point(443, 276);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(44, 16);
            this.totalPrice.TabIndex = 10;
            this.totalPrice.Text = "label2";
            this.totalPrice.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.orders);
            this.panel1.Controls.Add(this.logout);
            this.panel1.Controls.Add(this.menuBox);
            this.panel1.Controls.Add(this.userName);
            this.panel1.Controls.Add(this.welcome);
            this.panel1.Controls.Add(this.homePage);
            this.panel1.Location = new System.Drawing.Point(14, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 60);
            this.panel1.TabIndex = 11;
            // 
            // orders
            // 
            this.orders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orders.Image = global::Restaurant_DB.Properties.Resources.history;
            this.orders.Location = new System.Drawing.Point(657, 9);
            this.orders.Name = "orders";
            this.orders.Size = new System.Drawing.Size(45, 40);
            this.orders.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.orders.TabIndex = 5;
            this.orders.TabStop = false;
            this.orders.Click += new System.EventHandler(this.orders_Click);
            // 
            // logout
            // 
            this.logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout.Image = global::Restaurant_DB.Properties.Resources.logout;
            this.logout.Location = new System.Drawing.Point(763, 9);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(40, 40);
            this.logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logout.TabIndex = 4;
            this.logout.TabStop = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // menuBox
            // 
            this.menuBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuBox.Image = global::Restaurant_DB.Properties.Resources.menu;
            this.menuBox.Location = new System.Drawing.Point(599, 6);
            this.menuBox.Name = "menuBox";
            this.menuBox.Size = new System.Drawing.Size(40, 40);
            this.menuBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuBox.TabIndex = 3;
            this.menuBox.TabStop = false;
            this.menuBox.Click += new System.EventHandler(this.menuBox_Click);
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.BackColor = System.Drawing.Color.Black;
            this.userName.ForeColor = System.Drawing.Color.White;
            this.userName.Location = new System.Drawing.Point(100, 34);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(67, 16);
            this.userName.TabIndex = 2;
            this.userName.Text = "username";
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.ForeColor = System.Drawing.Color.White;
            this.welcome.Location = new System.Drawing.Point(100, 15);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(68, 16);
            this.welcome.TabIndex = 1;
            this.welcome.Text = "Welcome,";
            // 
            // homePage
            // 
            this.homePage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homePage.Image = global::Restaurant_DB.Properties.Resources.home;
            this.homePage.Location = new System.Drawing.Point(16, 9);
            this.homePage.Name = "homePage";
            this.homePage.Size = new System.Drawing.Size(40, 40);
            this.homePage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.homePage.TabIndex = 0;
            this.homePage.TabStop = false;
            this.homePage.Click += new System.EventHandler(this.homePage_Click);
            // 
            // realCartItems
            // 
            this.realCartItems.AutoScroll = true;
            this.realCartItems.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.realCartItems.Location = new System.Drawing.Point(14, 74);
            this.realCartItems.Name = "realCartItems";
            this.realCartItems.Size = new System.Drawing.Size(831, 187);
            this.realCartItems.TabIndex = 8;
            // 
            // makeOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(855, 360);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.totalPrice);
            this.Controls.Add(this.total);
            this.Controls.Add(this.realCartItems);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.update);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "makeOrder";
            this.Text = "makeOrder";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homePage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label totalPrice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox homePage;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.PictureBox menuBox;
        private System.Windows.Forms.PictureBox logout;
        private System.Windows.Forms.PictureBox orders;
        private System.Windows.Forms.FlowLayoutPanel realCartItems;
    }
}