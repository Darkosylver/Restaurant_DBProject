namespace Restaurant_DB
{
    partial class Welcome
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
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.UpdatePersonalInfoButton = new System.Windows.Forms.Button();
            this.toolBar = new System.Windows.Forms.Panel();
            this.welcomePanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.orderHistory = new System.Windows.Forms.PictureBox();
            this.logOut = new System.Windows.Forms.PictureBox();
            this.menuBox = new System.Windows.Forms.PictureBox();
            this.homePicture = new System.Windows.Forms.PictureBox();
            this.toolBar.SuspendLayout();
            this.welcomePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(100, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome,";
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CustomerNameLabel.ForeColor = System.Drawing.Color.White;
            this.CustomerNameLabel.Location = new System.Drawing.Point(100, 34);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(104, 16);
            this.CustomerNameLabel.TabIndex = 1;
            this.CustomerNameLabel.Text = "Customer Name";
            this.CustomerNameLabel.Click += new System.EventHandler(this.CustomerNameLabel_Click);
            // 
            // UpdatePersonalInfoButton
            // 
            this.UpdatePersonalInfoButton.ForeColor = System.Drawing.Color.Black;
            this.UpdatePersonalInfoButton.Location = new System.Drawing.Point(223, 17);
            this.UpdatePersonalInfoButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdatePersonalInfoButton.Name = "UpdatePersonalInfoButton";
            this.UpdatePersonalInfoButton.Size = new System.Drawing.Size(89, 24);
            this.UpdatePersonalInfoButton.TabIndex = 6;
            this.UpdatePersonalInfoButton.Text = "Update Info";
            this.UpdatePersonalInfoButton.UseVisualStyleBackColor = true;
            this.UpdatePersonalInfoButton.Click += new System.EventHandler(this.UpdatePersonalInfoButton_Click);
            // 
            // toolBar
            // 
            this.toolBar.BackColor = System.Drawing.Color.Black;
            this.toolBar.Controls.Add(this.orderHistory);
            this.toolBar.Controls.Add(this.logOut);
            this.toolBar.Controls.Add(this.menuBox);
            this.toolBar.Controls.Add(this.homePicture);
            this.toolBar.Controls.Add(this.label1);
            this.toolBar.Controls.Add(this.UpdatePersonalInfoButton);
            this.toolBar.Controls.Add(this.CustomerNameLabel);
            this.toolBar.Location = new System.Drawing.Point(11, 2);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(826, 68);
            this.toolBar.TabIndex = 7;
            // 
            // welcomePanel
            // 
            this.welcomePanel.Controls.Add(this.pictureBox1);
            this.welcomePanel.Location = new System.Drawing.Point(11, 67);
            this.welcomePanel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.welcomePanel.Name = "welcomePanel";
            this.welcomePanel.Size = new System.Drawing.Size(790, 364);
            this.welcomePanel.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Restaurant_DB.Properties.Resources.welcome2;
            this.pictureBox1.Location = new System.Drawing.Point(76, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(750, 376);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // orderHistory
            // 
            this.orderHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orderHistory.Image = global::Restaurant_DB.Properties.Resources.history;
            this.orderHistory.Location = new System.Drawing.Point(654, 10);
            this.orderHistory.Name = "orderHistory";
            this.orderHistory.Size = new System.Drawing.Size(45, 40);
            this.orderHistory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.orderHistory.TabIndex = 8;
            this.orderHistory.TabStop = false;
            this.orderHistory.Click += new System.EventHandler(this.orderHistory_Click);
            // 
            // logOut
            // 
            this.logOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logOut.Image = global::Restaurant_DB.Properties.Resources.logout;
            this.logOut.Location = new System.Drawing.Point(772, 9);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(40, 40);
            this.logOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logOut.TabIndex = 8;
            this.logOut.TabStop = false;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // menuBox
            // 
            this.menuBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuBox.Image = global::Restaurant_DB.Properties.Resources.menu;
            this.menuBox.Location = new System.Drawing.Point(599, 9);
            this.menuBox.Name = "menuBox";
            this.menuBox.Size = new System.Drawing.Size(40, 40);
            this.menuBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuBox.TabIndex = 7;
            this.menuBox.TabStop = false;
            this.menuBox.Click += new System.EventHandler(this.menuBox_Click);
            // 
            // homePicture
            // 
            this.homePicture.Image = global::Restaurant_DB.Properties.Resources.home;
            this.homePicture.Location = new System.Drawing.Point(16, 9);
            this.homePicture.Name = "homePicture";
            this.homePicture.Size = new System.Drawing.Size(40, 40);
            this.homePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.homePicture.TabIndex = 0;
            this.homePicture.TabStop = false;
            this.homePicture.Click += new System.EventHandler(this.homePicture_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 442);
            this.Controls.Add(this.welcomePanel);
            this.Controls.Add(this.toolBar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Welcome";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            this.welcomePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CustomerNameLabel;
        private System.Windows.Forms.Button UpdatePersonalInfoButton;
        private System.Windows.Forms.Panel toolBar;
        private System.Windows.Forms.PictureBox homePicture;
        private System.Windows.Forms.PictureBox menuBox;
        private System.Windows.Forms.PictureBox logOut;
        private System.Windows.Forms.PictureBox orderHistory;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel welcomePanel;
    }
}