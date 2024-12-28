namespace Restaurant_DB
{
    partial class waiter
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
            this.order = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.phoneno = new System.Windows.Forms.TextBox();
            this.phonelabel = new System.Windows.Forms.Label();
            this.tablemanagement = new System.Windows.Forms.Button();
            this.customerinfo = new System.Windows.Forms.Button();
            this.dashBoard = new System.Windows.Forms.Panel();
            this.orderLog = new System.Windows.Forms.PictureBox();
            this.logOut = new System.Windows.Forms.PictureBox();
            this.waiterName = new System.Windows.Forms.Label();
            this.welcome = new System.Windows.Forms.Label();
            this.homeBox = new System.Windows.Forms.PictureBox();
            this.dashBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // order
            // 
            this.order.Location = new System.Drawing.Point(597, 210);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(134, 23);
            this.order.TabIndex = 0;
            this.order.Text = "make an order";
            this.order.UseVisualStyleBackColor = true;
            this.order.Click += new System.EventHandler(this.order_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "phone number";
            // 
            // phoneno
            // 
            this.phoneno.Location = new System.Drawing.Point(169, 90);
            this.phoneno.Name = "phoneno";
            this.phoneno.Size = new System.Drawing.Size(126, 22);
            this.phoneno.TabIndex = 5;
            this.phoneno.TextChanged += new System.EventHandler(this.phoneno_TextChanged);
            // 
            // phonelabel
            // 
            this.phonelabel.AutoSize = true;
            this.phonelabel.Location = new System.Drawing.Point(87, 129);
            this.phonelabel.Name = "phonelabel";
            this.phonelabel.Size = new System.Drawing.Size(0, 16);
            this.phonelabel.TabIndex = 21;
            // 
            // tablemanagement
            // 
            this.tablemanagement.Location = new System.Drawing.Point(102, 210);
            this.tablemanagement.Name = "tablemanagement";
            this.tablemanagement.Size = new System.Drawing.Size(137, 23);
            this.tablemanagement.TabIndex = 22;
            this.tablemanagement.Text = "Table Management";
            this.tablemanagement.UseVisualStyleBackColor = true;
            this.tablemanagement.Click += new System.EventHandler(this.tablemanagement_Click);
            // 
            // customerinfo
            // 
            this.customerinfo.Location = new System.Drawing.Point(345, 210);
            this.customerinfo.Name = "customerinfo";
            this.customerinfo.Size = new System.Drawing.Size(132, 23);
            this.customerinfo.TabIndex = 23;
            this.customerinfo.Text = "Update Customer Info";
            this.customerinfo.UseVisualStyleBackColor = true;
            this.customerinfo.Click += new System.EventHandler(this.customerinfo_Click);
            // 
            // dashBoard
            // 
            this.dashBoard.BackColor = System.Drawing.Color.Black;
            this.dashBoard.Controls.Add(this.orderLog);
            this.dashBoard.Controls.Add(this.logOut);
            this.dashBoard.Controls.Add(this.waiterName);
            this.dashBoard.Controls.Add(this.welcome);
            this.dashBoard.Controls.Add(this.homeBox);
            this.dashBoard.Location = new System.Drawing.Point(-1, -2);
            this.dashBoard.Name = "dashBoard";
            this.dashBoard.Size = new System.Drawing.Size(847, 67);
            this.dashBoard.TabIndex = 24;
            // 
            // orderLog
            // 
            this.orderLog.Image = global::Restaurant_DB.Properties.Resources.history;
            this.orderLog.Location = new System.Drawing.Point(644, 14);
            this.orderLog.Name = "orderLog";
            this.orderLog.Size = new System.Drawing.Size(45, 40);
            this.orderLog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.orderLog.TabIndex = 4;
            this.orderLog.TabStop = false;
            this.orderLog.Click += new System.EventHandler(this.orderLog_Click);
            // 
            // logOut
            // 
            this.logOut.Image = global::Restaurant_DB.Properties.Resources.logout;
            this.logOut.Location = new System.Drawing.Point(794, 14);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(40, 40);
            this.logOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logOut.TabIndex = 3;
            this.logOut.TabStop = false;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // waiterName
            // 
            this.waiterName.AutoSize = true;
            this.waiterName.ForeColor = System.Drawing.Color.White;
            this.waiterName.Location = new System.Drawing.Point(100, 34);
            this.waiterName.Name = "waiterName";
            this.waiterName.Size = new System.Drawing.Size(76, 16);
            this.waiterName.TabIndex = 2;
            this.waiterName.Text = "waitername";
            this.waiterName.Click += new System.EventHandler(this.waiterName_Click);
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
            // homeBox
            // 
            this.homeBox.Image = global::Restaurant_DB.Properties.Resources.home;
            this.homeBox.Location = new System.Drawing.Point(13, 14);
            this.homeBox.Name = "homeBox";
            this.homeBox.Size = new System.Drawing.Size(40, 40);
            this.homeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.homeBox.TabIndex = 0;
            this.homeBox.TabStop = false;
            // 
            // waiter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 450);
            this.Controls.Add(this.dashBoard);
            this.Controls.Add(this.customerinfo);
            this.Controls.Add(this.tablemanagement);
            this.Controls.Add(this.phonelabel);
            this.Controls.Add(this.phoneno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.order);
            this.Name = "waiter";
            this.Text = "waiter";
            this.Load += new System.EventHandler(this.waiter_Load);
            this.dashBoard.ResumeLayout(false);
            this.dashBoard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button order;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox phoneno;
        private System.Windows.Forms.Label phonelabel;
        private System.Windows.Forms.Button tablemanagement;
        private System.Windows.Forms.Button customerinfo;
        private System.Windows.Forms.Panel dashBoard;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.PictureBox homeBox;
        private System.Windows.Forms.Label waiterName;
        private System.Windows.Forms.PictureBox logOut;
        private System.Windows.Forms.PictureBox orderLog;
    }
}