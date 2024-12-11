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
            this.freetable = new System.Windows.Forms.Button();
            this.tablelabel = new System.Windows.Forms.Label();
            this.restauranttables = new System.Windows.Forms.DataGridView();
            this.refresh = new System.Windows.Forms.Button();
            this.addtable = new System.Windows.Forms.Button();
            this.phonelabel = new System.Windows.Forms.Label();
            this.deletetable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.restauranttables)).BeginInit();
            this.SuspendLayout();
            // 
            // order
            // 
            this.order.Location = new System.Drawing.Point(503, 86);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(134, 23);
            this.order.TabIndex = 0;
            this.order.Text = "make an order";
            this.order.UseVisualStyleBackColor = true;
            this.order.Click += new System.EventHandler(this.order_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(663, 202);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(125, 23);
            this.update.TabIndex = 1;
            this.update.Text = "update address";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click_1);
            // 
            // reserve
            // 
            this.reserve.Location = new System.Drawing.Point(663, 347);
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
            this.label1.Location = new System.Drawing.Point(86, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "phone number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(522, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "table number";
            // 
            // phoneno
            // 
            this.phoneno.Location = new System.Drawing.Point(185, 91);
            this.phoneno.Name = "phoneno";
            this.phoneno.Size = new System.Drawing.Size(126, 22);
            this.phoneno.TabIndex = 5;
            this.phoneno.TextChanged += new System.EventHandler(this.phoneno_TextChanged);
            // 
            // tableno
            // 
            this.tableno.Location = new System.Drawing.Point(517, 377);
            this.tableno.Name = "tableno";
            this.tableno.Size = new System.Drawing.Size(134, 22);
            this.tableno.TabIndex = 6;
            this.tableno.TextChanged += new System.EventHandler(this.tableno_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(459, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "building";
            // 
            // building
            // 
            this.building.Location = new System.Drawing.Point(537, 186);
            this.building.Name = "building";
            this.building.Size = new System.Drawing.Size(100, 22);
            this.building.TabIndex = 12;
            this.building.TextChanged += new System.EventHandler(this.building_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(473, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "street";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(486, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "city";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // street
            // 
            this.street.Location = new System.Drawing.Point(537, 214);
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(100, 22);
            this.street.TabIndex = 11;
            this.street.TextChanged += new System.EventHandler(this.street_TextChanged);
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(537, 242);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(100, 22);
            this.city.TabIndex = 10;
            this.city.TextChanged += new System.EventHandler(this.city_TextChanged);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(663, 231);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(125, 23);
            this.delete.TabIndex = 13;
            this.delete.Text = "delete address";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // freetable
            // 
            this.freetable.Location = new System.Drawing.Point(663, 376);
            this.freetable.Name = "freetable";
            this.freetable.Size = new System.Drawing.Size(125, 23);
            this.freetable.TabIndex = 16;
            this.freetable.Text = "free table";
            this.freetable.UseVisualStyleBackColor = true;
            this.freetable.Click += new System.EventHandler(this.freetable_Click);
            // 
            // tablelabel
            // 
            this.tablelabel.AutoSize = true;
            this.tablelabel.Location = new System.Drawing.Point(500, 406);
            this.tablelabel.Name = "tablelabel";
            this.tablelabel.Size = new System.Drawing.Size(0, 16);
            this.tablelabel.TabIndex = 17;
            // 
            // restauranttables
            // 
            this.restauranttables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.restauranttables.Location = new System.Drawing.Point(12, 257);
            this.restauranttables.Name = "restauranttables";
            this.restauranttables.RowHeadersWidth = 51;
            this.restauranttables.RowTemplate.Height = 24;
            this.restauranttables.Size = new System.Drawing.Size(403, 181);
            this.restauranttables.TabIndex = 18;
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(12, 212);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(75, 23);
            this.refresh.TabIndex = 19;
            this.refresh.Text = "refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // addtable
            // 
            this.addtable.Location = new System.Drawing.Point(322, 212);
            this.addtable.Name = "addtable";
            this.addtable.Size = new System.Drawing.Size(75, 23);
            this.addtable.TabIndex = 20;
            this.addtable.Text = "add table";
            this.addtable.UseVisualStyleBackColor = true;
            this.addtable.Click += new System.EventHandler(this.addtable_Click);
            // 
            // phonelabel
            // 
            this.phonelabel.AutoSize = true;
            this.phonelabel.Location = new System.Drawing.Point(87, 129);
            this.phonelabel.Name = "phonelabel";
            this.phonelabel.Size = new System.Drawing.Size(0, 16);
            this.phonelabel.TabIndex = 21;
            // 
            // deletetable
            // 
            this.deletetable.Location = new System.Drawing.Point(663, 406);
            this.deletetable.Name = "deletetable";
            this.deletetable.Size = new System.Drawing.Size(125, 23);
            this.deletetable.TabIndex = 22;
            this.deletetable.Text = "delete table";
            this.deletetable.UseVisualStyleBackColor = true;
            this.deletetable.Click += new System.EventHandler(this.deletetable_Click);
            // 
            // waiter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deletetable);
            this.Controls.Add(this.phonelabel);
            this.Controls.Add(this.addtable);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.restauranttables);
            this.Controls.Add(this.tablelabel);
            this.Controls.Add(this.freetable);
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
            ((System.ComponentModel.ISupportInitialize)(this.restauranttables)).EndInit();
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
        private System.Windows.Forms.Button freetable;
        private System.Windows.Forms.Label tablelabel;
        private System.Windows.Forms.DataGridView restauranttables;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button addtable;
        private System.Windows.Forms.Label phonelabel;
        private System.Windows.Forms.Button deletetable;
    }
}