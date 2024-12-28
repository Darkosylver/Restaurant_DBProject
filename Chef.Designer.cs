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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.ItemName = new System.Windows.Forms.TextBox();
            this.CookingTime = new System.Windows.Forms.TextBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.Insert_item = new System.Windows.Forms.Button();
            this.itemRemove = new System.Windows.Forms.Button();
            this.removeIngredient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(695, 166);
            this.dataGridView1.TabIndex = 0;
            // 
            // PendingOrders
            // 
            this.PendingOrders.Location = new System.Drawing.Point(12, 12);
            this.PendingOrders.Name = "PendingOrders";
            this.PendingOrders.Size = new System.Drawing.Size(164, 27);
            this.PendingOrders.TabIndex = 1;
            this.PendingOrders.Text = "PendingOrders";
            this.PendingOrders.UseVisualStyleBackColor = true;
            this.PendingOrders.Click += new System.EventHandler(this.PendingOrders_Click);
            // 
            // Served
            // 
            this.Served.Location = new System.Drawing.Point(27, 286);
            this.Served.Name = "Served";
            this.Served.Size = new System.Drawing.Size(75, 23);
            this.Served.TabIndex = 2;
            this.Served.Text = "Served";
            this.Served.UseVisualStyleBackColor = true;
            this.Served.Click += new System.EventHandler(this.Served_Click);
            // 
            // Cancelled
            // 
            this.Cancelled.Location = new System.Drawing.Point(124, 286);
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
            this.comboBox1.Location = new System.Drawing.Point(100, 241);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "OrderID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Show items that is not in stock";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(534, 244);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Click here if you make stock request";
            // 
            // Request
            // 
            this.Request.Location = new System.Drawing.Point(577, 304);
            this.Request.Name = "Request";
            this.Request.Size = new System.Drawing.Size(75, 23);
            this.Request.TabIndex = 9;
            this.Request.Text = "Request";
            this.Request.UseVisualStyleBackColor = true;
            this.Request.Click += new System.EventHandler(this.Request_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Add New Item to Menu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "ItemName";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "CookingTime";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(249, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "ChefSSN";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(407, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Enter Your SSN";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(534, 275);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 24);
            this.comboBox3.TabIndex = 15;
            // 
            // ItemName
            // 
            this.ItemName.Location = new System.Drawing.Point(12, 392);
            this.ItemName.Name = "ItemName";
            this.ItemName.Size = new System.Drawing.Size(90, 22);
            this.ItemName.TabIndex = 16;
            this.ItemName.TextChanged += new System.EventHandler(this.ItemName_TextChanged);
            this.ItemName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ItemName_KeyPress);
            // 
            // CookingTime
            // 
            this.CookingTime.Location = new System.Drawing.Point(112, 392);
            this.CookingTime.Name = "CookingTime";
            this.CookingTime.Size = new System.Drawing.Size(100, 22);
            this.CookingTime.TabIndex = 17;
            this.CookingTime.TextChanged += new System.EventHandler(this.CookingTime_TextChanged);
            this.CookingTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CookingTime_KeyPress);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(233, 390);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 24);
            this.comboBox4.TabIndex = 18;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // Insert_item
            // 
            this.Insert_item.Location = new System.Drawing.Point(703, 451);
            this.Insert_item.Name = "Insert_item";
            this.Insert_item.Size = new System.Drawing.Size(86, 24);
            this.Insert_item.TabIndex = 19;
            this.Insert_item.Text = "Insert Item";
            this.Insert_item.UseVisualStyleBackColor = true;
            this.Insert_item.Click += new System.EventHandler(this.Insert_item_Click);
            // 
            // itemRemove
            // 
            this.itemRemove.Location = new System.Drawing.Point(785, 80);
            this.itemRemove.Name = "itemRemove";
            this.itemRemove.Size = new System.Drawing.Size(150, 23);
            this.itemRemove.TabIndex = 20;
            this.itemRemove.Text = "Remove Itens";
            this.itemRemove.UseVisualStyleBackColor = true;
            this.itemRemove.Click += new System.EventHandler(this.itemRemove_Click);
            // 
            // removeIngredient
            // 
            this.removeIngredient.Location = new System.Drawing.Point(790, 137);
            this.removeIngredient.Name = "removeIngredient";
            this.removeIngredient.Size = new System.Drawing.Size(145, 23);
            this.removeIngredient.TabIndex = 21;
            this.removeIngredient.Text = "Remove Ingredients";
            this.removeIngredient.UseVisualStyleBackColor = true;
            this.removeIngredient.Click += new System.EventHandler(this.removeIngredient_Click);
            // 
            // Chef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1023, 517);
            this.Controls.Add(this.removeIngredient);
            this.Controls.Add(this.itemRemove);
            this.Controls.Add(this.Insert_item);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.CookingTime);
            this.Controls.Add(this.ItemName);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox ItemName;
        private System.Windows.Forms.TextBox CookingTime;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button Insert_item;
        private System.Windows.Forms.Button itemRemove;
        private System.Windows.Forms.Button removeIngredient;
    }
}