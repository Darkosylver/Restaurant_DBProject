namespace Restaurant_DB
{
    partial class Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ReviewOrderDetails = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RestaurantIncomeButton = new System.Windows.Forms.Button();
            this.RestaurantSpendingButton = new System.Windows.Forms.Button();
            this.RevenueButton = new System.Windows.Forms.Button();
            this.top3ItemsButton = new System.Windows.Forms.Button();
            this.employeesWorkingHoursButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.ReviewOrderDetails);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 607);
            this.panel1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(0, 158);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 58);
            this.button3.TabIndex = 2;
            this.button3.Text = "Modify Employee";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(-3, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 56);
            this.button2.TabIndex = 1;
            this.button2.Text = "Pending Ingredients";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ReviewOrderDetails
            // 
            this.ReviewOrderDetails.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ReviewOrderDetails.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ReviewOrderDetails.Location = new System.Drawing.Point(0, 39);
            this.ReviewOrderDetails.Name = "ReviewOrderDetails";
            this.ReviewOrderDetails.Size = new System.Drawing.Size(200, 59);
            this.ReviewOrderDetails.TabIndex = 0;
            this.ReviewOrderDetails.Text = "Review Order Details";
            this.ReviewOrderDetails.UseVisualStyleBackColor = false;
            this.ReviewOrderDetails.Click += new System.EventHandler(this.ReviewOrderDetails_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Menu;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1014, 24);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Location = new System.Drawing.Point(261, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(117, 110);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Beige;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(398, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(615, 373);
            this.dataGridView1.TabIndex = 3;
            // 
            // RestaurantIncomeButton
            // 
            this.RestaurantIncomeButton.Location = new System.Drawing.Point(261, 504);
            this.RestaurantIncomeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RestaurantIncomeButton.Name = "RestaurantIncomeButton";
            this.RestaurantIncomeButton.Size = new System.Drawing.Size(147, 35);
            this.RestaurantIncomeButton.TabIndex = 69;
            this.RestaurantIncomeButton.Text = "Restaurant Income";
            this.RestaurantIncomeButton.UseVisualStyleBackColor = true;
            this.RestaurantIncomeButton.Click += new System.EventHandler(this.RestaurantIncomeButton_Click);
            // 
            // RestaurantSpendingButton
            // 
            this.RestaurantSpendingButton.Location = new System.Drawing.Point(458, 504);
            this.RestaurantSpendingButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RestaurantSpendingButton.Name = "RestaurantSpendingButton";
            this.RestaurantSpendingButton.Size = new System.Drawing.Size(156, 36);
            this.RestaurantSpendingButton.TabIndex = 70;
            this.RestaurantSpendingButton.Text = "Restaurant Spending";
            this.RestaurantSpendingButton.UseVisualStyleBackColor = true;
            this.RestaurantSpendingButton.Click += new System.EventHandler(this.RestaurantSpendingButton_Click);
            // 
            // RevenueButton
            // 
            this.RevenueButton.Location = new System.Drawing.Point(681, 505);
            this.RevenueButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RevenueButton.Name = "RevenueButton";
            this.RevenueButton.Size = new System.Drawing.Size(104, 35);
            this.RevenueButton.TabIndex = 71;
            this.RevenueButton.Text = "Revenue";
            this.RevenueButton.UseVisualStyleBackColor = true;
            this.RevenueButton.Click += new System.EventHandler(this.RevenueButton_Click);
            // 
            // top3ItemsButton
            // 
            this.top3ItemsButton.Location = new System.Drawing.Point(840, 504);
            this.top3ItemsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.top3ItemsButton.Name = "top3ItemsButton";
            this.top3ItemsButton.Size = new System.Drawing.Size(104, 35);
            this.top3ItemsButton.TabIndex = 72;
            this.top3ItemsButton.Text = "Top 3 Items";
            this.top3ItemsButton.UseVisualStyleBackColor = true;
            this.top3ItemsButton.Click += new System.EventHandler(this.top3ItemsButton_Click);
            // 
            // employeesWorkingHoursButton
            // 
            this.employeesWorkingHoursButton.Location = new System.Drawing.Point(986, 493);
            this.employeesWorkingHoursButton.Name = "employeesWorkingHoursButton";
            this.employeesWorkingHoursButton.Size = new System.Drawing.Size(121, 58);
            this.employeesWorkingHoursButton.TabIndex = 73;
            this.employeesWorkingHoursButton.Text = "Employees Working Hours";
            this.employeesWorkingHoursButton.UseVisualStyleBackColor = true;
            this.employeesWorkingHoursButton.Click += new System.EventHandler(this.employeesWorkingHoursButton_Click);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1214, 607);
            this.Controls.Add(this.employeesWorkingHoursButton);
            this.Controls.Add(this.top3ItemsButton);
            this.Controls.Add(this.RevenueButton);
            this.Controls.Add(this.RestaurantSpendingButton);
            this.Controls.Add(this.RestaurantIncomeButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Manager";
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.Manager_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ReviewOrderDetails;
        private System.Windows.Forms.Button button3;

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button RestaurantIncomeButton;
        private System.Windows.Forms.Button RestaurantSpendingButton;
        private System.Windows.Forms.Button RevenueButton;
        private System.Windows.Forms.Button top3ItemsButton;
        private System.Windows.Forms.Button employeesWorkingHoursButton;
    }
}