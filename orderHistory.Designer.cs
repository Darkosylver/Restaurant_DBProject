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
            this.userName = new System.Windows.Forms.Label();
            this.welcome = new System.Windows.Forms.Label();
            this.logOut = new System.Windows.Forms.PictureBox();
            this.homeBox = new System.Windows.Forms.PictureBox();
            this.orderCurrent = new System.Windows.Forms.Label();
            this.currentOrders = new System.Windows.Forms.DataGridView();
            this.orderPrev = new System.Windows.Forms.Label();
            this.previousOrders = new System.Windows.Forms.DataGridView();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dashBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previousOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dashBoard
            // 
            this.dashBoard.BackColor = System.Drawing.Color.Black;
            this.dashBoard.Controls.Add(this.userName);
            this.dashBoard.Controls.Add(this.welcome);
            this.dashBoard.Controls.Add(this.logOut);
            this.dashBoard.Controls.Add(this.homeBox);
            this.dashBoard.Location = new System.Drawing.Point(2, 1);
            this.dashBoard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dashBoard.Name = "dashBoard";
            this.dashBoard.Size = new System.Drawing.Size(966, 78);
            this.dashBoard.TabIndex = 0;
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.ForeColor = System.Drawing.Color.White;
            this.userName.Location = new System.Drawing.Point(112, 42);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(80, 20);
            this.userName.TabIndex = 3;
            this.userName.Text = "username";
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.ForeColor = System.Drawing.Color.White;
            this.welcome.Location = new System.Drawing.Point(112, 19);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(79, 20);
            this.welcome.TabIndex = 2;
            this.welcome.Text = "Welcome,";
            // 
            // logOut
            // 
            this.logOut.Image = global::Restaurant_DB.Properties.Resources.logout;
            this.logOut.Location = new System.Drawing.Point(908, 11);
            this.logOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(45, 50);
            this.logOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logOut.TabIndex = 1;
            this.logOut.TabStop = false;
            // 
            // homeBox
            // 
            this.homeBox.Image = global::Restaurant_DB.Properties.Resources.home;
            this.homeBox.Location = new System.Drawing.Point(18, 11);
            this.homeBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.homeBox.Name = "homeBox";
            this.homeBox.Size = new System.Drawing.Size(45, 50);
            this.homeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.homeBox.TabIndex = 0;
            this.homeBox.TabStop = false;
            // 
            // orderCurrent
            // 
            this.orderCurrent.AutoSize = true;
            this.orderCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderCurrent.Location = new System.Drawing.Point(14, 96);
            this.orderCurrent.Name = "orderCurrent";
            this.orderCurrent.Size = new System.Drawing.Size(209, 32);
            this.orderCurrent.TabIndex = 1;
            this.orderCurrent.Text = "Current Orders:";
            // 
            // currentOrders
            // 
            this.currentOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.currentOrders.Location = new System.Drawing.Point(20, 136);
            this.currentOrders.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.currentOrders.Name = "currentOrders";
            this.currentOrders.RowHeadersWidth = 51;
            this.currentOrders.RowTemplate.Height = 24;
            this.currentOrders.Size = new System.Drawing.Size(935, 156);
            this.currentOrders.TabIndex = 2;
            // 
            // orderPrev
            // 
            this.orderPrev.AutoSize = true;
            this.orderPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderPrev.Location = new System.Drawing.Point(15, 308);
            this.orderPrev.Name = "orderPrev";
            this.orderPrev.Size = new System.Drawing.Size(226, 32);
            this.orderPrev.TabIndex = 3;
            this.orderPrev.Text = "Previous Orders:";
            // 
            // previousOrders
            // 
            this.previousOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.previousOrders.Location = new System.Drawing.Point(20, 360);
            this.previousOrders.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.previousOrders.Name = "previousOrders";
            this.previousOrders.RowHeadersWidth = 51;
            this.previousOrders.RowTemplate.Height = 24;
            this.previousOrders.Size = new System.Drawing.Size(935, 169);
            this.previousOrders.TabIndex = 4;
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Restaurant_DB.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(222, 547);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 224);
            this.reportViewer1.TabIndex = 5;
            this.reportViewer1.Visible = false;
            // 
            // orderHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 805);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.previousOrders);
            this.Controls.Add(this.orderPrev);
            this.Controls.Add(this.currentOrders);
            this.Controls.Add(this.orderCurrent);
            this.Controls.Add(this.dashBoard);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "orderHistory";
            this.Text = "orderHistory";
            this.Load += new System.EventHandler(this.orderHistory_Load);
            this.dashBoard.ResumeLayout(false);
            this.dashBoard.PerformLayout();
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
    }
}