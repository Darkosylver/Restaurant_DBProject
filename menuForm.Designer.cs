namespace Restaurant_DB
{
    partial class menuForm
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
            this.menuItems = new System.Windows.Forms.FlowLayoutPanel();
            this.checkOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menuItems
            // 
            this.menuItems.AutoScroll = true;
            this.menuItems.Location = new System.Drawing.Point(12, 74);
            this.menuItems.Name = "menuItems";
            this.menuItems.Size = new System.Drawing.Size(755, 335);
            this.menuItems.TabIndex = 0;
            // 
            // checkOut
            // 
            this.checkOut.Location = new System.Drawing.Point(591, 415);
            this.checkOut.Name = "checkOut";
            this.checkOut.Size = new System.Drawing.Size(176, 23);
            this.checkOut.TabIndex = 1;
            this.checkOut.Text = "Proceed to Checkout";
            this.checkOut.UseVisualStyleBackColor = true;
            this.checkOut.Click += new System.EventHandler(this.checkOut_Click);
            // 
            // menuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkOut);
            this.Controls.Add(this.menuItems);
            this.Name = "menuForm";
            this.Text = "menuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel menuItems;
        private System.Windows.Forms.Button checkOut;
    }
}