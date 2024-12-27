namespace Restaurant_DB
{
    partial class updateuser
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
            this.addresses = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.delete = new System.Windows.Forms.Button();
            this.building = new System.Windows.Forms.TextBox();
            this.street = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.insert = new System.Windows.Forms.Button();
            this.dashBoard = new System.Windows.Forms.Panel();
            this.logout = new System.Windows.Forms.PictureBox();
            this.orderhistory = new System.Windows.Forms.PictureBox();
            this.waiterName = new System.Windows.Forms.Label();
            this.welcome = new System.Windows.Forms.Label();
            this.homePage = new System.Windows.Forms.PictureBox();
            this.dashBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderhistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homePage)).BeginInit();
            this.SuspendLayout();
            // 
            // addresses
            // 
            this.addresses.AutoSize = true;
            this.addresses.Location = new System.Drawing.Point(404, 159);
            this.addresses.Name = "addresses";
            this.addresses.Size = new System.Drawing.Size(72, 16);
            this.addresses.TabIndex = 34;
            this.addresses.Text = "addresses";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(500, 155);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 33;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(626, 156);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(125, 23);
            this.delete.TabIndex = 32;
            this.delete.Text = "delete address";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // building
            // 
            this.building.Location = new System.Drawing.Point(500, 197);
            this.building.Name = "building";
            this.building.Size = new System.Drawing.Size(100, 22);
            this.building.TabIndex = 31;
            this.building.TextChanged += new System.EventHandler(this.building_TextChanged);
            // 
            // street
            // 
            this.street.Location = new System.Drawing.Point(500, 225);
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(100, 22);
            this.street.TabIndex = 30;
            this.street.TextChanged += new System.EventHandler(this.street_TextChanged);
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(500, 253);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(100, 22);
            this.city.TabIndex = 29;
            this.city.TextChanged += new System.EventHandler(this.city_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(422, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "building";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(436, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "street";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(449, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "city";
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(626, 223);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(125, 23);
            this.insert.TabIndex = 25;
            this.insert.Text = "insert address";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.update_Click);
            // 
            // dashBoard
            // 
            this.dashBoard.BackColor = System.Drawing.Color.Black;
            this.dashBoard.Controls.Add(this.logout);
            this.dashBoard.Controls.Add(this.orderhistory);
            this.dashBoard.Controls.Add(this.waiterName);
            this.dashBoard.Controls.Add(this.welcome);
            this.dashBoard.Controls.Add(this.homePage);
            this.dashBoard.Location = new System.Drawing.Point(0, 1);
            this.dashBoard.Name = "dashBoard";
            this.dashBoard.Size = new System.Drawing.Size(848, 65);
            this.dashBoard.TabIndex = 35;
            // 
            // logout
            // 
            this.logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout.Image = global::Restaurant_DB.Properties.Resources.logout;
            this.logout.Location = new System.Drawing.Point(795, 11);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(40, 40);
            this.logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logout.TabIndex = 4;
            this.logout.TabStop = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // orderhistory
            // 
            this.orderhistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orderhistory.Image = global::Restaurant_DB.Properties.Resources.history;
            this.orderhistory.Location = new System.Drawing.Point(655, 11);
            this.orderhistory.Name = "orderhistory";
            this.orderhistory.Size = new System.Drawing.Size(45, 40);
            this.orderhistory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.orderhistory.TabIndex = 3;
            this.orderhistory.TabStop = false;
            this.orderhistory.Click += new System.EventHandler(this.orderhistory_Click);
            // 
            // waiterName
            // 
            this.waiterName.AutoSize = true;
            this.waiterName.BackColor = System.Drawing.Color.Black;
            this.waiterName.ForeColor = System.Drawing.Color.White;
            this.waiterName.Location = new System.Drawing.Point(100, 35);
            this.waiterName.Name = "waiterName";
            this.waiterName.Size = new System.Drawing.Size(76, 16);
            this.waiterName.TabIndex = 2;
            this.waiterName.Text = "waitername";
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
            this.homePage.Location = new System.Drawing.Point(12, 11);
            this.homePage.Name = "homePage";
            this.homePage.Size = new System.Drawing.Size(40, 40);
            this.homePage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.homePage.TabIndex = 0;
            this.homePage.TabStop = false;
            this.homePage.Click += new System.EventHandler(this.homePage_Click);
            // 
            // updateuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 450);
            this.Controls.Add(this.dashBoard);
            this.Controls.Add(this.addresses);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.building);
            this.Controls.Add(this.street);
            this.Controls.Add(this.city);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.insert);
            this.Name = "updateuser";
            this.Text = "updateuser";
            this.Load += new System.EventHandler(this.updateuser_Load);
            this.dashBoard.ResumeLayout(false);
            this.dashBoard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderhistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homePage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addresses;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TextBox building;
        private System.Windows.Forms.TextBox street;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Panel dashBoard;
        private System.Windows.Forms.PictureBox homePage;
        private System.Windows.Forms.Label waiterName;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.PictureBox orderhistory;
        private System.Windows.Forms.PictureBox logout;
    }
}