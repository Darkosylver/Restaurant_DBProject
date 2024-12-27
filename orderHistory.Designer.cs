namespace Restaurant_DB
{
    partial class orderHistory
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
            this.dashBoard = new System.Windows.Forms.Panel();
            this.historyRefresh = new System.Windows.Forms.PictureBox();
            this.menu = new System.Windows.Forms.PictureBox();
            this.userName = new System.Windows.Forms.Label();
            this.welcome = new System.Windows.Forms.Label();
            this.logOut = new System.Windows.Forms.PictureBox();
            this.homeBox = new System.Windows.Forms.PictureBox();
            this.orderCurrent = new System.Windows.Forms.Label();
            this.currentOrders = new System.Windows.Forms.DataGridView();
            this.orderPrev = new System.Windows.Forms.Label();
            this.previousOrders = new System.Windows.Forms.DataGridView();
            this.search = new System.Windows.Forms.Label();
            this.userPhone = new System.Windows.Forms.TextBox();
            this.searchConfirm = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.delivered = new System.Windows.Forms.Button();
            this.dashBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historyRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previousOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dashBoard
            // 
            this.dashBoard.BackColor = System.Drawing.Color.Black;
            this.dashBoard.Controls.Add(this.historyRefresh);
            this.dashBoard.Controls.Add(this.menu);
            this.dashBoard.Controls.Add(this.userName);
            this.dashBoard.Controls.Add(this.welcome);
            this.dashBoard.Controls.Add(this.logOut);
            this.dashBoard.Controls.Add(this.homeBox);
            this.dashBoard.Location = new System.Drawing.Point(2, 1);
            this.dashBoard.Name = "dashBoard";
            this.dashBoard.Size = new System.Drawing.Size(889, 62);
            this.dashBoard.TabIndex = 0;
            // 
            // historyRefresh
            // 
            this.historyRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.historyRefresh.Image = global::Restaurant_DB.Properties.Resources.history;
            this.historyRefresh.Location = new System.Drawing.Point(607, 9);
            this.historyRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.historyRefresh.Name = "historyRefresh";
            this.historyRefresh.Size = new System.Drawing.Size(45, 40);
            this.historyRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.historyRefresh.TabIndex = 5;
            this.historyRefresh.TabStop = false;
            this.historyRefresh.Click += new System.EventHandler(this.historyRefresh_Click);
            // 
            // menu
            // 
            this.menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menu.Image = global::Restaurant_DB.Properties.Resources.menu;
            this.menu.Location = new System.Drawing.Point(550, 9);
            this.menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(40, 40);
            this.menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menu.TabIndex = 4;
            this.menu.TabStop = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.ForeColor = System.Drawing.Color.White;
            this.userName.Location = new System.Drawing.Point(100, 33);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(67, 16);
            this.userName.TabIndex = 3;
            this.userName.Text = "username";
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.ForeColor = System.Drawing.Color.White;
            this.welcome.Location = new System.Drawing.Point(100, 15);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(68, 16);
            this.welcome.TabIndex = 2;
            this.welcome.Text = "Welcome,";
            // 
            // logOut
            // 
            this.logOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logOut.Image = global::Restaurant_DB.Properties.Resources.logout;
            this.logOut.Location = new System.Drawing.Point(838, 9);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(40, 40);
            this.logOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logOut.TabIndex = 1;
            this.logOut.TabStop = false;
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
            // 
            // orderCurrent
            // 
            this.orderCurrent.AutoSize = true;
            this.orderCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderCurrent.Location = new System.Drawing.Point(12, 77);
            this.orderCurrent.Name = "orderCurrent";
            this.orderCurrent.Size = new System.Drawing.Size(179, 29);
            this.orderCurrent.TabIndex = 1;
            this.orderCurrent.Text = "Current Orders:";
            // 
            // currentOrders
            // 
            this.currentOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.currentOrders.Location = new System.Drawing.Point(18, 109);
            this.currentOrders.Name = "currentOrders";
            this.currentOrders.RowHeadersWidth = 51;
            this.currentOrders.RowTemplate.Height = 24;
            this.currentOrders.Size = new System.Drawing.Size(831, 125);
            this.currentOrders.TabIndex = 2;
            this.currentOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.currentOrders_CellContentClick);
            // 
            // orderPrev
            // 
            this.orderPrev.AutoSize = true;
            this.orderPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderPrev.Location = new System.Drawing.Point(13, 246);
            this.orderPrev.Name = "orderPrev";
            this.orderPrev.Size = new System.Drawing.Size(194, 29);
            this.orderPrev.TabIndex = 3;
            this.orderPrev.Text = "Previous Orders:";
            // 
            // previousOrders
            // 
            this.previousOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.previousOrders.Location = new System.Drawing.Point(18, 288);
            this.previousOrders.Name = "previousOrders";
            this.previousOrders.RowHeadersWidth = 51;
            this.previousOrders.RowTemplate.Height = 24;
            this.previousOrders.Size = new System.Drawing.Size(831, 135);
            this.previousOrders.TabIndex = 4;
            // 
            // search
            // 
            this.search.AutoSize = true;
            this.search.Location = new System.Drawing.Point(232, 70);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(97, 16);
            this.search.TabIndex = 5;
            this.search.Text = "Search by user";
            this.search.Visible = false;
            // 
            // userPhone
            // 
            this.userPhone.Enabled = false;
            this.userPhone.Location = new System.Drawing.Point(336, 67);
            this.userPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userPhone.Name = "userPhone";
            this.userPhone.Size = new System.Drawing.Size(117, 22);
            this.userPhone.TabIndex = 6;
            this.userPhone.Visible = false;
            this.userPhone.TextChanged += new System.EventHandler(this.userPhone_TextChanged);
            this.userPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.userPhone_KeyPress);
            // 
            // searchConfirm
            // 
            this.searchConfirm.Enabled = false;
            this.searchConfirm.Location = new System.Drawing.Point(470, 67);
            this.searchConfirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchConfirm.Name = "searchConfirm";
            this.searchConfirm.Size = new System.Drawing.Size(72, 22);
            this.searchConfirm.TabIndex = 7;
            this.searchConfirm.Text = "Search";
            this.searchConfirm.UseVisualStyleBackColor = true;
            this.searchConfirm.Visible = false;
            this.searchConfirm.Click += new System.EventHandler(this.searchConfirm_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(132, 449);
            this.cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(114, 26);
            this.cancel.TabIndex = 8;
            this.cancel.Text = "Cancel Order";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // delivered
            // 
            this.delivered.Location = new System.Drawing.Point(380, 449);
            this.delivered.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delivered.Name = "delivered";
            this.delivered.Size = new System.Drawing.Size(128, 26);
            this.delivered.TabIndex = 9;
            this.delivered.Text = "Mark as Delivered";
            this.delivered.UseVisualStyleBackColor = true;
            this.delivered.Click += new System.EventHandler(this.delivered_Click);
            // 
            // orderHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 515);
            this.Controls.Add(this.delivered);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.searchConfirm);
            this.Controls.Add(this.userPhone);
            this.Controls.Add(this.search);
            this.Controls.Add(this.previousOrders);
            this.Controls.Add(this.orderPrev);
            this.Controls.Add(this.currentOrders);
            this.Controls.Add(this.orderCurrent);
            this.Controls.Add(this.dashBoard);
            this.Name = "orderHistory";
            this.Text = "orderHistory";
            this.Load += new System.EventHandler(this.orderHistory_Load);
            this.dashBoard.ResumeLayout(false);
            this.dashBoard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historyRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previousOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel dashBoard;
        private System.Windows.Forms.PictureBox homeBox;
        private System.Windows.Forms.PictureBox logOut;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Label orderCurrent;
        private System.Windows.Forms.DataGridView currentOrders;
        private System.Windows.Forms.Label orderPrev;
        private System.Windows.Forms.DataGridView previousOrders;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.PictureBox historyRefresh;
        private System.Windows.Forms.PictureBox menu;
        private System.Windows.Forms.Label search;
        private System.Windows.Forms.TextBox userPhone;
        private System.Windows.Forms.Button searchConfirm;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button delivered;
    }
}