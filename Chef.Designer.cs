namespace Restaurant_DB
{
    partial class Chef
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PendingOrders = new System.Windows.Forms.Button();
            this.Served = new System.Windows.Forms.Button();
            this.Cancelled = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Request = new System.Windows.Forms.Button();
            this.dashBoard = new System.Windows.Forms.Panel();
            this.userName = new System.Windows.Forms.Label();
            this.welcome = new System.Windows.Forms.Label();
            this.menuManager = new System.Windows.Forms.PictureBox();
            this.logout = new System.Windows.Forms.PictureBox();
            this.homeBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.dashBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(695, 166);
            this.dataGridView1.TabIndex = 0;
            // 
            // PendingOrders
            // 
            this.PendingOrders.Location = new System.Drawing.Point(12, 85);
            this.PendingOrders.Name = "PendingOrders";
            this.PendingOrders.Size = new System.Drawing.Size(164, 27);
            this.PendingOrders.TabIndex = 1;
            this.PendingOrders.Text = "PendingOrders";
            this.PendingOrders.UseVisualStyleBackColor = true;
            this.PendingOrders.Click += new System.EventHandler(this.PendingOrders_Click);
            // 
            // Served
            // 
            this.Served.Location = new System.Drawing.Point(25, 427);
            this.Served.Name = "Served";
            this.Served.Size = new System.Drawing.Size(75, 23);
            this.Served.TabIndex = 2;
            this.Served.Text = "Served";
            this.Served.UseVisualStyleBackColor = true;
            this.Served.Click += new System.EventHandler(this.Served_Click);
            // 
            // Cancelled
            // 
            this.Cancelled.Location = new System.Drawing.Point(136, 427);
            this.Cancelled.Name = "Cancelled";
            this.Cancelled.Size = new System.Drawing.Size(85, 23);
            this.Cancelled.TabIndex = 3;
            this.Cancelled.Text = "Cancelled";
            this.Cancelled.UseVisualStyleBackColor = true;
            this.Cancelled.Click += new System.EventHandler(this.Cancelled_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(136, 378);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "OrderID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Show items that is not in stock";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(563, 314);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Click here if you make stock request";
            // 
            // Request
            // 
            this.Request.Location = new System.Drawing.Point(577, 427);
            this.Request.Name = "Request";
            this.Request.Size = new System.Drawing.Size(75, 23);
            this.Request.TabIndex = 9;
            this.Request.Text = "Request";
            this.Request.UseVisualStyleBackColor = true;
            this.Request.Click += new System.EventHandler(this.Request_Click);
            // 
            // dashBoard
            // 
            this.dashBoard.BackColor = System.Drawing.Color.Black;
            this.dashBoard.Controls.Add(this.userName);
            this.dashBoard.Controls.Add(this.welcome);
            this.dashBoard.Controls.Add(this.menuManager);
            this.dashBoard.Controls.Add(this.logout);
            this.dashBoard.Controls.Add(this.homeBox);
            this.dashBoard.Location = new System.Drawing.Point(-1, 0);
            this.dashBoard.Name = "dashBoard";
            this.dashBoard.Size = new System.Drawing.Size(1023, 60);
            this.dashBoard.TabIndex = 22;
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.ForeColor = System.Drawing.Color.White;
            this.userName.Location = new System.Drawing.Point(100, 35);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(67, 16);
            this.userName.TabIndex = 4;
            this.userName.Text = "username";
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.ForeColor = System.Drawing.Color.White;
            this.welcome.Location = new System.Drawing.Point(100, 15);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(68, 16);
            this.welcome.TabIndex = 3;
            this.welcome.Text = "Welcome,";
            // 
            // menuManager
            // 
            this.menuManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuManager.Image = global::Restaurant_DB.Properties.Resources.menu;
            this.menuManager.Location = new System.Drawing.Point(750, 9);
            this.menuManager.Name = "menuManager";
            this.menuManager.Size = new System.Drawing.Size(40, 40);
            this.menuManager.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuManager.TabIndex = 2;
            this.menuManager.TabStop = false;
            this.menuManager.Click += new System.EventHandler(this.menuManager_Click);
            // 
            // logout
            // 
            this.logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout.Image = global::Restaurant_DB.Properties.Resources.logout;
            this.logout.Location = new System.Drawing.Point(972, 9);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(40, 40);
            this.logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logout.TabIndex = 1;
            this.logout.TabStop = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // homeBox
            // 
            this.homeBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeBox.Image = global::Restaurant_DB.Properties.Resources.home;
            this.homeBox.Location = new System.Drawing.Point(16, 9);
            this.homeBox.Name = "homeBox";
            this.homeBox.Size = new System.Drawing.Size(40, 40);
            this.homeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.homeBox.TabIndex = 0;
            this.homeBox.TabStop = false;
            this.homeBox.Click += new System.EventHandler(this.homeBox_Click);
            // 
            // Chef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1023, 517);
            this.Controls.Add(this.dashBoard);
            this.Controls.Add(this.Request);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Cancelled);
            this.Controls.Add(this.Served);
            this.Controls.Add(this.PendingOrders);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Chef";
            this.Text = "Chef";
            this.Load += new System.EventHandler(this.Chef_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.dashBoard.ResumeLayout(false);
            this.dashBoard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button PendingOrders;
        private System.Windows.Forms.Button Served;
        private System.Windows.Forms.Button Cancelled;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Request;
        private System.Windows.Forms.Panel dashBoard;
        private System.Windows.Forms.PictureBox homeBox;
        private System.Windows.Forms.PictureBox logout;
        private System.Windows.Forms.PictureBox menuManager;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Label userName;
    }
}