﻿namespace Restaurant_DB
{
    partial class menuItem
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
            this.itemName = new System.Windows.Forms.Label();
            this.itemDescription = new System.Windows.Forms.Label();
            this.itemCount = new System.Windows.Forms.TextBox();
            this.itemSub = new System.Windows.Forms.Button();
            this.itemAdd = new System.Windows.Forms.Button();
            this.itemID = new System.Windows.Forms.Label();
            this.cook = new System.Windows.Forms.Label();
            this.timeCook = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // itemName
            // 
            this.itemName.AutoSize = true;
            this.itemName.Location = new System.Drawing.Point(171, 24);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(44, 16);
            this.itemName.TabIndex = 0;
            this.itemName.Text = "Name";
            // 
            // itemDescription
            // 
            this.itemDescription.AutoSize = true;
            this.itemDescription.Location = new System.Drawing.Point(204, 55);
            this.itemDescription.Name = "itemDescription";
            this.itemDescription.Size = new System.Drawing.Size(75, 16);
            this.itemDescription.TabIndex = 1;
            this.itemDescription.Text = "Description";
            // 
            // itemCount
            // 
            this.itemCount.Location = new System.Drawing.Point(569, 55);
            this.itemCount.Name = "itemCount";
            this.itemCount.Size = new System.Drawing.Size(16, 22);
            this.itemCount.TabIndex = 2;
            this.itemCount.Text = "0";
            this.itemCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.itemCount_KeyPress);
            // 
            // itemSub
            // 
            this.itemSub.Location = new System.Drawing.Point(532, 55);
            this.itemSub.Name = "itemSub";
            this.itemSub.Size = new System.Drawing.Size(22, 23);
            this.itemSub.TabIndex = 3;
            this.itemSub.Text = "-";
            this.itemSub.UseVisualStyleBackColor = true;
            this.itemSub.Click += new System.EventHandler(this.itemSub_Click);
            // 
            // itemAdd
            // 
            this.itemAdd.Location = new System.Drawing.Point(601, 55);
            this.itemAdd.Name = "itemAdd";
            this.itemAdd.Size = new System.Drawing.Size(21, 23);
            this.itemAdd.TabIndex = 4;
            this.itemAdd.Text = "+";
            this.itemAdd.UseVisualStyleBackColor = true;
            this.itemAdd.Click += new System.EventHandler(this.itemAdd_Click);
            // 
            // itemID
            // 
            this.itemID.AutoSize = true;
            this.itemID.Location = new System.Drawing.Point(3, 0);
            this.itemID.Name = "itemID";
            this.itemID.Size = new System.Drawing.Size(20, 16);
            this.itemID.TabIndex = 5;
            this.itemID.Text = "ID";
            this.itemID.Visible = false;
            // 
            // cook
            // 
            this.cook.AutoSize = true;
            this.cook.Location = new System.Drawing.Point(264, 122);
            this.cook.Name = "cook";
            this.cook.Size = new System.Drawing.Size(94, 16);
            this.cook.TabIndex = 6;
            this.cook.Text = "Cooking Time:";
            // 
            // timeCook
            // 
            this.timeCook.AutoSize = true;
            this.timeCook.Location = new System.Drawing.Point(364, 122);
            this.timeCook.Name = "timeCook";
            this.timeCook.Size = new System.Drawing.Size(79, 16);
            this.timeCook.TabIndex = 7;
            this.timeCook.Text = "time to cook";
            // 
            // menuItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.timeCook);
            this.Controls.Add(this.cook);
            this.Controls.Add(this.itemID);
            this.Controls.Add(this.itemAdd);
            this.Controls.Add(this.itemSub);
            this.Controls.Add(this.itemCount);
            this.Controls.Add(this.itemDescription);
            this.Controls.Add(this.itemName);
            this.Name = "menuItem";
            this.Size = new System.Drawing.Size(676, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label itemName;
        private System.Windows.Forms.Label itemDescription;
        private System.Windows.Forms.TextBox itemCount;
        private System.Windows.Forms.Button itemSub;
        private System.Windows.Forms.Button itemAdd;
        private System.Windows.Forms.Label itemID;
        private System.Windows.Forms.Label cook;
        private System.Windows.Forms.Label timeCook;
    }
}
