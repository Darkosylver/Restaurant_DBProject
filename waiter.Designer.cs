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
            this.label1.Location = new System.Drawing.Point(29, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "phone number";
            // 
            // phoneno
            // 
            this.phoneno.Location = new System.Drawing.Point(168, 60);
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
            // waiter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customerinfo);
            this.Controls.Add(this.tablemanagement);
            this.Controls.Add(this.phonelabel);
            this.Controls.Add(this.phoneno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.order);
            this.Name = "waiter";
            this.Text = "waiter";
            this.Load += new System.EventHandler(this.waiter_Load);
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
    }
}