namespace Restaurant_DB
{
    partial class updateuser
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
            this.addresses = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.delete = new System.Windows.Forms.Button();
            this.building = new System.Windows.Forms.TextBox();
            this.street = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addresses
            // 
            this.addresses.AutoSize = true;
            this.addresses.Location = new System.Drawing.Point(404, 159);
            this.addresses.Name = "addresses";
            this.addresses.Size = new System.Drawing.Size(72, 16);
            this.addresses.TabIndex = 34;
            this.addresses.Text = "addresses";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(500, 155);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 33;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(626, 156);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(125, 23);
            this.delete.TabIndex = 32;
            this.delete.Text = "delete address";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // building
            // 
            this.building.Location = new System.Drawing.Point(500, 197);
            this.building.Name = "building";
            this.building.Size = new System.Drawing.Size(100, 22);
            this.building.TabIndex = 31;
            this.building.TextChanged += new System.EventHandler(this.building_TextChanged);
            // 
            // street
            // 
            this.street.Location = new System.Drawing.Point(500, 225);
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(100, 22);
            this.street.TabIndex = 30;
            this.street.TextChanged += new System.EventHandler(this.street_TextChanged);
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(500, 253);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(100, 22);
            this.city.TabIndex = 29;
            this.city.TextChanged += new System.EventHandler(this.city_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(422, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "building";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(436, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "street";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(449, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "city";
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(626, 223);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(125, 23);
            this.update.TabIndex = 25;
            this.update.Text = "insert address";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // updateuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addresses);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.building);
            this.Controls.Add(this.street);
            this.Controls.Add(this.city);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.update);
            this.Name = "updateuser";
            this.Text = "updateuser";
            this.Load += new System.EventHandler(this.updateuser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addresses;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TextBox building;
        private System.Windows.Forms.TextBox street;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button update;
    }
}