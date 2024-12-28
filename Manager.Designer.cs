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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ReviewOrderDetails = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.Insert_Employee = new System.Windows.Forms.Button();
            this.Delete_Employee = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RestaurantIncomeButton = new System.Windows.Forms.Button();
            this.RestaurantSpendingButton = new System.Windows.Forms.Button();
            this.RevenueButton = new System.Windows.Forms.Button();
            this.top3ItemsButton = new System.Windows.Forms.Button();
            this.employeesWorkingHoursButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.ReviewOrderDetails);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 433);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Menu;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(825, 24);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(1, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Employee Details";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "FName";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "LastName";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "WorkingHours";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Salary";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Street";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "City";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 241);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Building";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 267);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 16);
            this.label11.TabIndex = 11;
            this.label11.Text = "EPassword";
            // 
            // FName_Man
            // 
            this.FName_Man.Location = new System.Drawing.Point(90, 93);
            this.FName_Man.Name = "FName_Man";
            this.FName_Man.Size = new System.Drawing.Size(136, 22);
            this.FName_Man.TabIndex = 14;
            // 
            // LName_Man
            // 
            this.LName_Man.Location = new System.Drawing.Point(90, 121);
            this.LName_Man.Name = "LName_Man";
            this.LName_Man.Size = new System.Drawing.Size(136, 22);
            this.LName_Man.TabIndex = 15;
            this.LName_Man.TextChanged += new System.EventHandler(this.LName_Man_TextChanged);
            // 
            // Salary_Man
            // 
            this.Salary_Man.Location = new System.Drawing.Point(90, 149);
            this.Salary_Man.Name = "Salary_Man";
            this.Salary_Man.Size = new System.Drawing.Size(136, 22);
            this.Salary_Man.TabIndex = 16;
            this.Salary_Man.TextChanged += new System.EventHandler(this.Salary_Man_TextChanged);
            // 
            // City_Man
            // 
            this.City_Man.Location = new System.Drawing.Point(90, 177);
            this.City_Man.Name = "City_Man";
            this.City_Man.Size = new System.Drawing.Size(136, 22);
            this.City_Man.TabIndex = 17;
            // 
            // Street_Man
            // 
            this.Street_Man.Location = new System.Drawing.Point(90, 205);
            this.Street_Man.Name = "Street_Man";
            this.Street_Man.Size = new System.Drawing.Size(136, 22);
            this.Street_Man.TabIndex = 18;
            // 
            // Building_Man
            // 
            this.Building_Man.Location = new System.Drawing.Point(90, 233);
            this.Building_Man.Name = "Building_Man";
            this.Building_Man.Size = new System.Drawing.Size(136, 22);
            this.Building_Man.TabIndex = 19;
            // 
            // EPass_Man
            // 
            this.EPass_Man.Location = new System.Drawing.Point(90, 261);
            this.EPass_Man.Name = "EPass_Man";
            this.EPass_Man.Size = new System.Drawing.Size(136, 22);
            this.EPass_Man.TabIndex = 20;
            // 
            // Working_Hours_Man
            // 
            this.Working_Hours_Man.Location = new System.Drawing.Point(102, 292);
            this.Working_Hours_Man.Name = "Working_Hours_Man";
            this.Working_Hours_Man.Size = new System.Drawing.Size(124, 22);
            this.Working_Hours_Man.TabIndex = 21;
            this.Working_Hours_Man.TextChanged += new System.EventHandler(this.Working_Hours_Man_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 403);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1190, 192);
            this.dataGridView1.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(242, 155);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 16);
            this.label13.TabIndex = 23;
            this.label13.Text = "Invalid-Format ";
            this.label13.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(242, 292);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 16);
            this.label14.TabIndex = 24;
            this.label14.Text = "Invalid-Format";
            this.label14.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 16);
            this.label12.TabIndex = 25;
            this.label12.Text = "EMployee-SSN";
            // 
            // EMPLOYEE_SNN
            // 
            this.EMPLOYEE_SNN.Location = new System.Drawing.Point(113, 60);
            this.EMPLOYEE_SNN.Name = "EMPLOYEE_SNN";
            this.EMPLOYEE_SNN.Size = new System.Drawing.Size(113, 22);
            this.EMPLOYEE_SNN.TabIndex = 26;
            this.EMPLOYEE_SNN.TextChanged += new System.EventHandler(this.EMPLOYEE_SNN_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(166, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 35);
            this.button1.TabIndex = 28;
            this.button1.Text = "Update Employee";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 331);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 16);
            this.label16.TabIndex = 29;
            this.label16.Text = "Poistion";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(102, 320);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 30;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);

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
            // RestaurantIncomeButton
            // 
            this.RestaurantIncomeButton.Location = new System.Drawing.Point(476, 307);
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
            this.RestaurantSpendingButton.Location = new System.Drawing.Point(645, 306);
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
            this.RevenueButton.Location = new System.Drawing.Point(814, 306);
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
            this.top3ItemsButton.Location = new System.Drawing.Point(941, 307);
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
            this.employeesWorkingHoursButton.Location = new System.Drawing.Point(1069, 284);
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.Delete_Employee);
            this.Controls.Add(this.Insert_Employee);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.PendingOrders);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EMPLOYEE_SNN);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button Insert_Employee;
        private System.Windows.Forms.Button Delete_Employee;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RestaurantIncomeButton;
        private System.Windows.Forms.Button RestaurantSpendingButton;
        private System.Windows.Forms.Button RevenueButton;
        private System.Windows.Forms.Button top3ItemsButton;
        private System.Windows.Forms.Button employeesWorkingHoursButton;
    }
}