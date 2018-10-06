namespace PlayerInventory
{
    partial class Form1
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
            this.lblInventory = new System.Windows.Forms.Label();
            this.lstInventory = new System.Windows.Forms.ListBox();
            this.lstItems = new System.Windows.Forms.ListBox();
            this.lblAllItems = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lstInventoryItems = new System.Windows.Forms.ListBox();
            this.lblInventoryItems = new System.Windows.Forms.Label();
            this.lstQuantities = new System.Windows.Forms.ListBox();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInventory
            // 
            this.lblInventory.AutoSize = true;
            this.lblInventory.Location = new System.Drawing.Point(18, 11);
            this.lblInventory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(71, 16);
            this.lblInventory.TabIndex = 0;
            this.lblInventory.Text = "Inventory";
            // 
            // lstInventory
            // 
            this.lstInventory.FormattingEnabled = true;
            this.lstInventory.ItemHeight = 16;
            this.lstInventory.Location = new System.Drawing.Point(18, 42);
            this.lstInventory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstInventory.Name = "lstInventory";
            this.lstInventory.Size = new System.Drawing.Size(223, 164);
            this.lstInventory.TabIndex = 1;
            this.lstInventory.SelectedIndexChanged += new System.EventHandler(this.lstInventory_SelectedIndexChanged);
            // 
            // lstItems
            // 
            this.lstItems.FormattingEnabled = true;
            this.lstItems.ItemHeight = 16;
            this.lstItems.Location = new System.Drawing.Point(252, 42);
            this.lstItems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(226, 164);
            this.lstItems.TabIndex = 3;
            // 
            // lblAllItems
            // 
            this.lblAllItems.AutoSize = true;
            this.lblAllItems.Location = new System.Drawing.Point(252, 11);
            this.lblAllItems.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAllItems.Name = "lblAllItems";
            this.lblAllItems.Size = new System.Drawing.Size(67, 16);
            this.lblAllItems.TabIndex = 2;
            this.lblAllItems.Text = "All Items";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(18, 463);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(140, 28);
            this.btnAddItem.TabIndex = 4;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(140, 430);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(104, 22);
            this.txtQuantity.TabIndex = 5;
            this.txtQuantity.Text = "Quantity";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(18, 427);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 28);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lstInventoryItems
            // 
            this.lstInventoryItems.FormattingEnabled = true;
            this.lstInventoryItems.ItemHeight = 16;
            this.lstInventoryItems.Location = new System.Drawing.Point(18, 253);
            this.lstInventoryItems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstInventoryItems.Name = "lstInventoryItems";
            this.lstInventoryItems.Size = new System.Drawing.Size(223, 164);
            this.lstInventoryItems.TabIndex = 8;
            // 
            // lblInventoryItems
            // 
            this.lblInventoryItems.AutoSize = true;
            this.lblInventoryItems.Location = new System.Drawing.Point(18, 222);
            this.lblInventoryItems.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInventoryItems.Name = "lblInventoryItems";
            this.lblInventoryItems.Size = new System.Drawing.Size(112, 16);
            this.lblInventoryItems.TabIndex = 7;
            this.lblInventoryItems.Text = "Inventory Items";
            // 
            // lstQuantities
            // 
            this.lstQuantities.FormattingEnabled = true;
            this.lstQuantities.ItemHeight = 16;
            this.lstQuantities.Location = new System.Drawing.Point(252, 253);
            this.lstQuantities.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstQuantities.Name = "lstQuantities";
            this.lstQuantities.Size = new System.Drawing.Size(223, 164);
            this.lstQuantities.TabIndex = 9;
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(18, 498);
            this.btnRemoveItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(140, 28);
            this.btnRemoveItem.TabIndex = 10;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 533);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.lstQuantities);
            this.Controls.Add(this.lstInventoryItems);
            this.Controls.Add(this.lblInventoryItems);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.lstItems);
            this.Controls.Add(this.lblAllItems);
            this.Controls.Add(this.lstInventory);
            this.Controls.Add(this.lblInventory);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Player InventorySystem";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.ListBox lstInventory;
        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.Label lblAllItems;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ListBox lstInventoryItems;
        private System.Windows.Forms.Label lblInventoryItems;
        private System.Windows.Forms.ListBox lstQuantities;
        private System.Windows.Forms.Button btnRemoveItem;
    }
}

