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
            this.update = new System.Windows.Forms.Button();
            this.reserve = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.phoneno = new System.Windows.Forms.TextBox();
            this.tableno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.building = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.street = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.items = new System.Windows.Forms.ComboBox();
            this.quantity = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // order
            // 
            this.order.Location = new System.Drawing.Point(663, 113);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(125, 23);
            this.order.TabIndex = 0;
            this.order.Text = "set order";
            this.order.UseVisualStyleBackColor = true;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(663, 201);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(125, 23);
            this.update.TabIndex = 1;
            this.update.Text = "update address";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click_1);
            // 
            // reserve
            // 
            this.reserve.Location = new System.Drawing.Point(663, 361);
            this.reserve.Name = "reserve";
            this.reserve.Size = new System.Drawing.Size(125, 23);
            this.reserve.TabIndex = 2;
            this.reserve.Text = "reserve table";
            this.reserve.UseVisualStyleBackColor = true;
            this.reserve.Click += new System.EventHandler(this.reserve_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "phone number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(526, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "table number";
            // 
            // phoneno
            // 
            this.phoneno.Location = new System.Drawing.Point(36, 57);
            this.phoneno.Name = "phoneno";
            this.phoneno.Size = new System.Drawing.Size(126, 22);
            this.phoneno.TabIndex = 5;
            // 
            // tableno
            // 
            this.tableno.Location = new System.Drawing.Point(503, 361);
            this.tableno.Name = "tableno";
            this.tableno.Size = new System.Drawing.Size(134, 22);
            this.tableno.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(557, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "building";
            // 
            // building
            // 
            this.building.Location = new System.Drawing.Point(541, 213);
            this.building.Name = "building";
            this.building.Size = new System.Drawing.Size(100, 22);
            this.building.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(425, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "street";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "city";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // street
            // 
            this.street.Location = new System.Drawing.Point(400, 213);
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(100, 22);
            this.street.TabIndex = 11;
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(256, 214);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(100, 22);
            this.city.TabIndex = 10;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(663, 230);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(125, 23);
            this.delete.TabIndex = 13;
            this.delete.Text = "delete address";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // items
            // 
            this.items.FormattingEnabled = true;
            this.items.Location = new System.Drawing.Point(256, 113);
            this.items.Name = "items";
            this.items.Size = new System.Drawing.Size(121, 24);
            this.items.TabIndex = 14;
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(400, 114);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(100, 22);
            this.quantity.TabIndex = 15;
            // 
            // waiter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.items);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.building);
            this.Controls.Add(this.street);
            this.Controls.Add(this.city);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tableno);
            this.Controls.Add(this.phoneno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reserve);
            this.Controls.Add(this.update);
            this.Controls.Add(this.order);
            this.Name = "waiter";
            this.Text = "waiter";
            this.Load += new System.EventHandler(this.waiter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button order;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button reserve;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox phoneno;
        private System.Windows.Forms.TextBox tableno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox building;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox street;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.ComboBox items;
        private System.Windows.Forms.TextBox quantity;
    }
}