namespace Restaurant_DB
{
    partial class makeOrder
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
            this.update = new System.Windows.Forms.Button();
            this.confirm = new System.Windows.Forms.Button();
            this.realCartItems = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(83, 241);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(104, 23);
            this.update.TabIndex = 5;
            this.update.Text = "Update Cart";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(398, 241);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(75, 23);
            this.confirm.TabIndex = 6;
            this.confirm.Text = "Confirm";
            this.confirm.UseVisualStyleBackColor = true;
            // 
            // realCartItems
            // 
            this.realCartItems.AutoScroll = true;
            this.realCartItems.Location = new System.Drawing.Point(12, 63);
            this.realCartItems.Name = "realCartItems";
            this.realCartItems.Size = new System.Drawing.Size(687, 172);
            this.realCartItems.TabIndex = 8;
            // 
            // makeOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.realCartItems);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.update);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "makeOrder";
            this.Text = "makeOrder";
            this.Load += new System.EventHandler(this.Make_Order_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.FlowLayoutPanel realCartItems;
    }
}