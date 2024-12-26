namespace Restaurant_DB
{
    partial class tablemanagement
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
            this.deletetable = new System.Windows.Forms.Button();
            this.tablelabel = new System.Windows.Forms.Label();
            this.freetable = new System.Windows.Forms.Button();
            this.tableno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.reserve = new System.Windows.Forms.Button();
            this.addtable = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.restauranttables = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.restauranttables)).BeginInit();
            this.SuspendLayout();
            // 
            // deletetable
            // 
            this.deletetable.Location = new System.Drawing.Point(646, 372);
            this.deletetable.Name = "deletetable";
            this.deletetable.Size = new System.Drawing.Size(125, 23);
            this.deletetable.TabIndex = 28;
            this.deletetable.Text = "delete table";
            this.deletetable.UseVisualStyleBackColor = true;
            this.deletetable.Click += new System.EventHandler(this.deletetable_Click_1);
            // 
            // tablelabel
            // 
            this.tablelabel.AutoSize = true;
            this.tablelabel.Location = new System.Drawing.Point(483, 372);
            this.tablelabel.Name = "tablelabel";
            this.tablelabel.Size = new System.Drawing.Size(0, 16);
            this.tablelabel.TabIndex = 27;
            // 
            // freetable
            // 
            this.freetable.Location = new System.Drawing.Point(646, 342);
            this.freetable.Name = "freetable";
            this.freetable.Size = new System.Drawing.Size(125, 23);
            this.freetable.TabIndex = 26;
            this.freetable.Text = "free table";
            this.freetable.UseVisualStyleBackColor = true;
            this.freetable.Click += new System.EventHandler(this.freetable_Click_1);
            // 
            // tableno
            // 
            this.tableno.Location = new System.Drawing.Point(500, 343);
            this.tableno.Name = "tableno";
            this.tableno.Size = new System.Drawing.Size(134, 22);
            this.tableno.TabIndex = 25;
            this.tableno.TextChanged += new System.EventHandler(this.tableno_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(505, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "table number";
            // 
            // reserve
            // 
            this.reserve.Location = new System.Drawing.Point(646, 313);
            this.reserve.Name = "reserve";
            this.reserve.Size = new System.Drawing.Size(125, 23);
            this.reserve.TabIndex = 23;
            this.reserve.Text = "reserve table";
            this.reserve.UseVisualStyleBackColor = true;
            this.reserve.Click += new System.EventHandler(this.reserve_Click_1);
            // 
            // addtable
            // 
            this.addtable.Location = new System.Drawing.Point(322, 212);
            this.addtable.Name = "addtable";
            this.addtable.Size = new System.Drawing.Size(75, 23);
            this.addtable.TabIndex = 31;
            this.addtable.Text = "add table";
            this.addtable.UseVisualStyleBackColor = true;
            this.addtable.Click += new System.EventHandler(this.addtable_Click);
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(12, 212);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(75, 23);
            this.refresh.TabIndex = 30;
            this.refresh.Text = "refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // restauranttables
            // 
            this.restauranttables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.restauranttables.Location = new System.Drawing.Point(12, 257);
            this.restauranttables.Name = "restauranttables";
            this.restauranttables.RowHeadersWidth = 51;
            this.restauranttables.RowTemplate.Height = 24;
            this.restauranttables.Size = new System.Drawing.Size(403, 181);
            this.restauranttables.TabIndex = 29;
            // 
            // tablemanagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addtable);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.restauranttables);
            this.Controls.Add(this.deletetable);
            this.Controls.Add(this.tablelabel);
            this.Controls.Add(this.freetable);
            this.Controls.Add(this.tableno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reserve);
            this.Name = "tablemanagement";
            this.Text = "tablemanagement";
            this.Load += new System.EventHandler(this.tablemanagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restauranttables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deletetable;
        private System.Windows.Forms.Label tablelabel;
        private System.Windows.Forms.Button freetable;
        private System.Windows.Forms.TextBox tableno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button reserve;
        private System.Windows.Forms.Button addtable;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.DataGridView restauranttables;
    }
}