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
            this.MenuButton = new System.Windows.Forms.Button();
            this.ShowOrdersButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MakeOrderButton = new System.Windows.Forms.Button();
            this.UpdatePersonalInfoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome,";
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Location = new System.Drawing.Point(120, 42);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(124, 20);
            this.CustomerNameLabel.TabIndex = 1;
            this.CustomerNameLabel.Text = "Customer Name";
            this.CustomerNameLabel.Click += new System.EventHandler(this.CustomerNameLabel_Click);
            // 
            // MenuButton
            // 
            this.MenuButton.Location = new System.Drawing.Point(70, 173);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(75, 47);
            this.MenuButton.TabIndex = 2;
            this.MenuButton.Text = "Menu";
            this.MenuButton.UseVisualStyleBackColor = true;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // ShowOrdersButton
            // 
            this.ShowOrdersButton.Location = new System.Drawing.Point(405, 173);
            this.ShowOrdersButton.Name = "ShowOrdersButton";
            this.ShowOrdersButton.Size = new System.Drawing.Size(114, 47);
            this.ShowOrdersButton.TabIndex = 3;
            this.ShowOrdersButton.Text = "Show Orders";
            this.ShowOrdersButton.UseVisualStyleBackColor = true;
            this.ShowOrdersButton.Click += new System.EventHandler(this.ShowOrdersButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 271);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(776, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // MakeOrderButton
            // 
            this.MakeOrderButton.Location = new System.Drawing.Point(224, 173);
            this.MakeOrderButton.Name = "MakeOrderButton";
            this.MakeOrderButton.Size = new System.Drawing.Size(109, 47);
            this.MakeOrderButton.TabIndex = 5;
            this.MakeOrderButton.Text = "Make Order";
            this.MakeOrderButton.UseVisualStyleBackColor = true;
            this.MakeOrderButton.Click += new System.EventHandler(this.MakeOrderButton_Click);
            // 
            // UpdatePersonalInfoButton
            // 
            this.UpdatePersonalInfoButton.Location = new System.Drawing.Point(582, 158);
            this.UpdatePersonalInfoButton.Name = "UpdatePersonalInfoButton";
            this.UpdatePersonalInfoButton.Size = new System.Drawing.Size(100, 80);
            this.UpdatePersonalInfoButton.TabIndex = 6;
            this.UpdatePersonalInfoButton.Text = "Update Personal Info";
            this.UpdatePersonalInfoButton.UseVisualStyleBackColor = true;
            this.UpdatePersonalInfoButton.Click += new System.EventHandler(this.UpdatePersonalInfoButton_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UpdatePersonalInfoButton);
            this.Controls.Add(this.MakeOrderButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ShowOrdersButton);
            this.Controls.Add(this.MenuButton);
            this.Controls.Add(this.CustomerNameLabel);
            this.Controls.Add(this.label1);
            this.Name = "Welcome";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Welcome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CustomerNameLabel;
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.Button ShowOrdersButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button MakeOrderButton;
        private System.Windows.Forms.Button UpdatePersonalInfoButton;
    }
}