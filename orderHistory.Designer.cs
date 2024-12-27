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
            this.homeBox = new System.Windows.Forms.PictureBox();
            this.logOut = new System.Windows.Forms.PictureBox();
            this.welcome = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.orderCurrent = new System.Windows.Forms.Label();
            this.currentOrders = new System.Windows.Forms.DataGridView();
            this.orderPrev = new System.Windows.Forms.Label();
            this.previousOrders = new System.Windows.Forms.DataGridView();
            this.dashBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logOut)).BeginInit();
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
            this.dashBoard.Name = "dashBoard";
            this.dashBoard.Size = new System.Drawing.Size(859, 62);
            this.dashBoard.TabIndex = 0;
            // 
            // homeBox
            // 
            this.homeBox.Image = global::Restaurant_DB.Properties.Resources.home;
            this.homeBox.Location = new System.Drawing.Point(16, 9);
            this.homeBox.Name = "homeBox";
            this.homeBox.Size = new System.Drawing.Size(40, 40);
            this.homeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.homeBox.TabIndex = 0;
            this.homeBox.TabStop = false;
            // 
            // logOut
            // 
            this.logOut.Image = global::Restaurant_DB.Properties.Resources.logout;
            this.logOut.Location = new System.Drawing.Point(807, 9);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(40, 40);
            this.logOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logOut.TabIndex = 1;
            this.logOut.TabStop = false;
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
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.ForeColor = System.Drawing.Color.White;
            this.userName.Location = new System.Drawing.Point(100, 34);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(67, 16);
            this.userName.TabIndex = 3;
            this.userName.Text = "username";
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
            // orderHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 644);
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
            ((System.ComponentModel.ISupportInitialize)(this.homeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logOut)).EndInit();
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
    }
}