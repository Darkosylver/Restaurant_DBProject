﻿namespace Restaurant_DB
{
    partial class Make_Order
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
            this.MenuItemsComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ItemStatusTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu Items";
            // 
            // MenuItemsComboBox
            // 
            this.MenuItemsComboBox.FormattingEnabled = true;
            this.MenuItemsComboBox.Location = new System.Drawing.Point(152, 63);
            this.MenuItemsComboBox.Name = "MenuItemsComboBox";
            this.MenuItemsComboBox.Size = new System.Drawing.Size(121, 28);
            this.MenuItemsComboBox.TabIndex = 1;
            this.MenuItemsComboBox.SelectedIndexChanged += new System.EventHandler(this.MenuItemsComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Item Status:";
            // 
            // ItemStatusTextBox
            // 
            this.ItemStatusTextBox.Location = new System.Drawing.Point(152, 117);
            this.ItemStatusTextBox.Name = "ItemStatusTextBox";
            this.ItemStatusTextBox.Size = new System.Drawing.Size(100, 26);
            this.ItemStatusTextBox.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(776, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // Make_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ItemStatusTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MenuItemsComboBox);
            this.Controls.Add(this.label1);
            this.Name = "Make_Order";
            this.Text = "Make_Order";
            this.Load += new System.EventHandler(this.Make_Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox MenuItemsComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ItemStatusTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}