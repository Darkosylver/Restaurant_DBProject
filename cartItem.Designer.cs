﻿namespace Restaurant_DB
{
    partial class cartItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cartItemName = new System.Windows.Forms.Label();
            this.cartItemPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cartItemName
            // 
            this.cartItemName.AutoSize = true;
            this.cartItemName.Location = new System.Drawing.Point(15, 14);
            this.cartItemName.Name = "cartItemName";
            this.cartItemName.Size = new System.Drawing.Size(44, 16);
            this.cartItemName.TabIndex = 0;
            this.cartItemName.Text = "label1";
            // 
            // cartItemPrice
            // 
            this.cartItemPrice.AutoSize = true;
            this.cartItemPrice.Location = new System.Drawing.Point(279, 14);
            this.cartItemPrice.Name = "cartItemPrice";
            this.cartItemPrice.Size = new System.Drawing.Size(44, 16);
            this.cartItemPrice.TabIndex = 1;
            this.cartItemPrice.Text = "label1";
            // 
            // cartItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cartItemPrice);
            this.Controls.Add(this.cartItemName);
            this.Name = "cartItem";
            this.Size = new System.Drawing.Size(349, 43);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cartItemName;
        private System.Windows.Forms.Label cartItemPrice;
    }
}
