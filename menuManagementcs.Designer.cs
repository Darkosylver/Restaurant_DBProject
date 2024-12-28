namespace Restaurant_DB
{
    partial class menuManagementcs
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
            this.welcome = new System.Windows.Forms.Label();
            this.dashBoard = new System.Windows.Forms.Panel();
            this.homeBox = new System.Windows.Forms.PictureBox();
            this.userName = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.PictureBox();
            this.menuManager = new System.Windows.Forms.PictureBox();
            this.itemName = new System.Windows.Forms.TextBox();
            this.cookingTime = new System.Windows.Forms.TextBox();
            this.itemAdd = new System.Windows.Forms.Button();
            this.nameitem = new System.Windows.Forms.Label();
            this.timecook = new System.Windows.Forms.Label();
            this.ssnchef = new System.Windows.Forms.Label();
            this.chefSN = new System.Windows.Forms.ComboBox();
            this.itemRemove = new System.Windows.Forms.Button();
            this.ingredientRemove = new System.Windows.Forms.Button();
            this.item = new System.Windows.Forms.Label();
            this.ingredient = new System.Windows.Forms.Label();
            this.nameingredient = new System.Windows.Forms.Label();
            this.stockingredient = new System.Windows.Forms.Label();
            this.priceingredient = new System.Windows.Forms.Label();
            this.ingredientName = new System.Windows.Forms.TextBox();
            this.ingredientCount = new System.Windows.Forms.TextBox();
            this.ingredientPrice = new System.Windows.Forms.TextBox();
            this.ingredientAdd = new System.Windows.Forms.Button();
            this.successMessage = new System.Windows.Forms.Label();
            this.dashBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuManager)).BeginInit();
            this.SuspendLayout();
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.ForeColor = System.Drawing.Color.White;
            this.welcome.Location = new System.Drawing.Point(100, 15);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(68, 16);
            this.welcome.TabIndex = 0;
            this.welcome.Text = "Welcome,";
            // 
            // dashBoard
            // 
            this.dashBoard.BackColor = System.Drawing.Color.Black;
            this.dashBoard.Controls.Add(this.menuManager);
            this.dashBoard.Controls.Add(this.logout);
            this.dashBoard.Controls.Add(this.homeBox);
            this.dashBoard.Controls.Add(this.userName);
            this.dashBoard.Controls.Add(this.welcome);
            this.dashBoard.Location = new System.Drawing.Point(1, 0);
            this.dashBoard.Name = "dashBoard";
            this.dashBoard.Size = new System.Drawing.Size(866, 62);
            this.dashBoard.TabIndex = 1;
            // 
            // homeBox
            // 
            this.homeBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeBox.Image = global::Restaurant_DB.Properties.Resources.home;
            this.homeBox.Location = new System.Drawing.Point(16, 9);
            this.homeBox.Name = "homeBox";
            this.homeBox.Size = new System.Drawing.Size(40, 40);
            this.homeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.homeBox.TabIndex = 2;
            this.homeBox.TabStop = false;
            this.homeBox.Click += new System.EventHandler(this.homeBox_Click);
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.ForeColor = System.Drawing.Color.White;
            this.userName.Location = new System.Drawing.Point(101, 31);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(67, 16);
            this.userName.TabIndex = 1;
            this.userName.Text = "username";
            // 
            // logout
            // 
            this.logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout.Image = global::Restaurant_DB.Properties.Resources.logout;
            this.logout.Location = new System.Drawing.Point(815, 9);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(40, 40);
            this.logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logout.TabIndex = 3;
            this.logout.TabStop = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // menuManager
            // 
            this.menuManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuManager.Image = global::Restaurant_DB.Properties.Resources.menu;
            this.menuManager.Location = new System.Drawing.Point(586, 9);
            this.menuManager.Name = "menuManager";
            this.menuManager.Size = new System.Drawing.Size(40, 40);
            this.menuManager.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuManager.TabIndex = 4;
            this.menuManager.TabStop = false;
            // 
            // itemName
            // 
            this.itemName.Location = new System.Drawing.Point(125, 131);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(100, 22);
            this.itemName.TabIndex = 2;
            this.itemName.TextChanged += new System.EventHandler(this.itemName_TextChanged);
            this.itemName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.itemName_KeyPress);
            // 
            // cookingTime
            // 
            this.cookingTime.Location = new System.Drawing.Point(125, 185);
            this.cookingTime.Name = "cookingTime";
            this.cookingTime.Size = new System.Drawing.Size(100, 22);
            this.cookingTime.TabIndex = 3;
            this.cookingTime.TextChanged += new System.EventHandler(this.cookingTime_TextChanged);
            this.cookingTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cookingTime_KeyPress);
            // 
            // itemAdd
            // 
            this.itemAdd.Enabled = false;
            this.itemAdd.Location = new System.Drawing.Point(125, 289);
            this.itemAdd.Name = "itemAdd";
            this.itemAdd.Size = new System.Drawing.Size(75, 23);
            this.itemAdd.TabIndex = 4;
            this.itemAdd.Text = "Add Item";
            this.itemAdd.UseVisualStyleBackColor = true;
            this.itemAdd.Click += new System.EventHandler(this.itemAdd_Click);
            // 
            // nameitem
            // 
            this.nameitem.AutoSize = true;
            this.nameitem.Location = new System.Drawing.Point(21, 134);
            this.nameitem.Name = "nameitem";
            this.nameitem.Size = new System.Drawing.Size(72, 16);
            this.nameitem.TabIndex = 5;
            this.nameitem.Text = "Item Name";
            // 
            // timecook
            // 
            this.timecook.AutoSize = true;
            this.timecook.Location = new System.Drawing.Point(21, 188);
            this.timecook.Name = "timecook";
            this.timecook.Size = new System.Drawing.Size(91, 16);
            this.timecook.TabIndex = 6;
            this.timecook.Text = "Cooking Time";
            // 
            // ssnchef
            // 
            this.ssnchef.AutoSize = true;
            this.ssnchef.Location = new System.Drawing.Point(21, 240);
            this.ssnchef.Name = "ssnchef";
            this.ssnchef.Size = new System.Drawing.Size(65, 16);
            this.ssnchef.TabIndex = 7;
            this.ssnchef.Text = "Chef SSN";
            // 
            // chefSN
            // 
            this.chefSN.FormattingEnabled = true;
            this.chefSN.Location = new System.Drawing.Point(125, 237);
            this.chefSN.Name = "chefSN";
            this.chefSN.Size = new System.Drawing.Size(121, 24);
            this.chefSN.TabIndex = 8;
            // 
            // itemRemove
            // 
            this.itemRemove.Location = new System.Drawing.Point(24, 395);
            this.itemRemove.Name = "itemRemove";
            this.itemRemove.Size = new System.Drawing.Size(145, 23);
            this.itemRemove.TabIndex = 9;
            this.itemRemove.Text = "Remove Items";
            this.itemRemove.UseVisualStyleBackColor = true;
            this.itemRemove.Click += new System.EventHandler(this.itemRemove_Click);
            // 
            // ingredientRemove
            // 
            this.ingredientRemove.Location = new System.Drawing.Point(227, 395);
            this.ingredientRemove.Name = "ingredientRemove";
            this.ingredientRemove.Size = new System.Drawing.Size(176, 23);
            this.ingredientRemove.TabIndex = 10;
            this.ingredientRemove.Text = "Remove Ingredients";
            this.ingredientRemove.UseVisualStyleBackColor = true;
            this.ingredientRemove.Click += new System.EventHandler(this.ingredientRemove_Click);
            // 
            // item
            // 
            this.item.AutoSize = true;
            this.item.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item.Location = new System.Drawing.Point(6, 86);
            this.item.Name = "item";
            this.item.Size = new System.Drawing.Size(165, 25);
            this.item.TabIndex = 11;
            this.item.Text = "Add Menu Item:";
            // 
            // ingredient
            // 
            this.ingredient.AutoSize = true;
            this.ingredient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredient.Location = new System.Drawing.Point(406, 86);
            this.ingredient.Name = "ingredient";
            this.ingredient.Size = new System.Drawing.Size(160, 25);
            this.ingredient.TabIndex = 12;
            this.ingredient.Text = "Add Ingredient:";
            // 
            // nameingredient
            // 
            this.nameingredient.AutoSize = true;
            this.nameingredient.Location = new System.Drawing.Point(445, 134);
            this.nameingredient.Name = "nameingredient";
            this.nameingredient.Size = new System.Drawing.Size(106, 16);
            this.nameingredient.TabIndex = 13;
            this.nameingredient.Text = "Ingredient Name";
            // 
            // stockingredient
            // 
            this.stockingredient.AutoSize = true;
            this.stockingredient.Location = new System.Drawing.Point(445, 188);
            this.stockingredient.Name = "stockingredient";
            this.stockingredient.Size = new System.Drawing.Size(103, 16);
            this.stockingredient.TabIndex = 14;
            this.stockingredient.Text = "Ingredient Stock";
            // 
            // priceingredient
            // 
            this.priceingredient.AutoSize = true;
            this.priceingredient.Location = new System.Drawing.Point(445, 240);
            this.priceingredient.Name = "priceingredient";
            this.priceingredient.Size = new System.Drawing.Size(100, 16);
            this.priceingredient.TabIndex = 15;
            this.priceingredient.Text = "Ingredient Price";
            // 
            // ingredientName
            // 
            this.ingredientName.Location = new System.Drawing.Point(587, 131);
            this.ingredientName.Name = "ingredientName";
            this.ingredientName.Size = new System.Drawing.Size(100, 22);
            this.ingredientName.TabIndex = 16;
            this.ingredientName.TextChanged += new System.EventHandler(this.ingredientName_TextChanged);
            this.ingredientName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ingredientName_KeyPress);
            // 
            // ingredientCount
            // 
            this.ingredientCount.Location = new System.Drawing.Point(587, 185);
            this.ingredientCount.Name = "ingredientCount";
            this.ingredientCount.Size = new System.Drawing.Size(100, 22);
            this.ingredientCount.TabIndex = 17;
            this.ingredientCount.TextChanged += new System.EventHandler(this.ingredientCount_TextChanged);
            this.ingredientCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ingredientCount_KeyPress);
            // 
            // ingredientPrice
            // 
            this.ingredientPrice.Location = new System.Drawing.Point(587, 237);
            this.ingredientPrice.Name = "ingredientPrice";
            this.ingredientPrice.Size = new System.Drawing.Size(100, 22);
            this.ingredientPrice.TabIndex = 18;
            this.ingredientPrice.TextChanged += new System.EventHandler(this.ingredientPrice_TextChanged);
            this.ingredientPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ingredientPrice_KeyPress);
            // 
            // ingredientAdd
            // 
            this.ingredientAdd.Enabled = false;
            this.ingredientAdd.Location = new System.Drawing.Point(587, 289);
            this.ingredientAdd.Name = "ingredientAdd";
            this.ingredientAdd.Size = new System.Drawing.Size(110, 23);
            this.ingredientAdd.TabIndex = 19;
            this.ingredientAdd.Text = "Add Ingredient";
            this.ingredientAdd.UseVisualStyleBackColor = true;
            this.ingredientAdd.Click += new System.EventHandler(this.ingredientAdd_Click);
            // 
            // successMessage
            // 
            this.successMessage.AutoSize = true;
            this.successMessage.Location = new System.Drawing.Point(584, 336);
            this.successMessage.Name = "successMessage";
            this.successMessage.Size = new System.Drawing.Size(181, 16);
            this.successMessage.TabIndex = 20;
            this.successMessage.Text = "Ingredient Added Succesfully";
            this.successMessage.Visible = false;
            // 
            // menuManagementcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 450);
            this.Controls.Add(this.successMessage);
            this.Controls.Add(this.ingredientAdd);
            this.Controls.Add(this.ingredientPrice);
            this.Controls.Add(this.ingredientCount);
            this.Controls.Add(this.ingredientName);
            this.Controls.Add(this.priceingredient);
            this.Controls.Add(this.stockingredient);
            this.Controls.Add(this.nameingredient);
            this.Controls.Add(this.ingredient);
            this.Controls.Add(this.item);
            this.Controls.Add(this.ingredientRemove);
            this.Controls.Add(this.itemRemove);
            this.Controls.Add(this.chefSN);
            this.Controls.Add(this.ssnchef);
            this.Controls.Add(this.timecook);
            this.Controls.Add(this.nameitem);
            this.Controls.Add(this.itemAdd);
            this.Controls.Add(this.cookingTime);
            this.Controls.Add(this.itemName);
            this.Controls.Add(this.dashBoard);
            this.Name = "menuManagementcs";
            this.Text = "menuManagementcs";
            this.dashBoard.ResumeLayout(false);
            this.dashBoard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Panel dashBoard;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.PictureBox homeBox;
        private System.Windows.Forms.PictureBox logout;
        private System.Windows.Forms.PictureBox menuManager;
        private System.Windows.Forms.TextBox itemName;
        private System.Windows.Forms.TextBox cookingTime;
        private System.Windows.Forms.Button itemAdd;
        private System.Windows.Forms.Label nameitem;
        private System.Windows.Forms.Label timecook;
        private System.Windows.Forms.Label ssnchef;
        private System.Windows.Forms.ComboBox chefSN;
        private System.Windows.Forms.Button itemRemove;
        private System.Windows.Forms.Button ingredientRemove;
        private System.Windows.Forms.Label item;
        private System.Windows.Forms.Label ingredient;
        private System.Windows.Forms.Label nameingredient;
        private System.Windows.Forms.Label stockingredient;
        private System.Windows.Forms.Label priceingredient;
        private System.Windows.Forms.TextBox ingredientName;
        private System.Windows.Forms.TextBox ingredientCount;
        private System.Windows.Forms.TextBox ingredientPrice;
        private System.Windows.Forms.Button ingredientAdd;
        private System.Windows.Forms.Label successMessage;
    }
}