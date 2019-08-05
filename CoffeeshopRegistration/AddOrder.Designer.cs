namespace CoffeeshopRegistration
{
    partial class AddOrder
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.listMenu = new System.Windows.Forms.ListBox();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbxMenuAdditions = new System.Windows.Forms.ListBox();
            this.btnAddAdditions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(751, 613);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(105, 48);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(921, 613);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 48);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseMnemonic = false;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(760, 414);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(158, 58);
            this.btnAddItem.TabIndex = 2;
            this.btnAddItem.Text = "AddItem";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // listMenu
            // 
            this.listMenu.FormattingEnabled = true;
            this.listMenu.ItemHeight = 20;
            this.listMenu.Location = new System.Drawing.Point(16, 32);
            this.listMenu.Name = "listMenu";
            this.listMenu.Size = new System.Drawing.Size(748, 324);
            this.listMenu.TabIndex = 3;
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Location = new System.Drawing.Point(903, 515);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.Size = new System.Drawing.Size(100, 26);
            this.txtTotalCost.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(756, 521);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Total Cost";
            // 
            // lbxMenuAdditions
            // 
            this.lbxMenuAdditions.FormattingEnabled = true;
            this.lbxMenuAdditions.ItemHeight = 20;
            this.lbxMenuAdditions.Items.AddRange(new object[] {
            "Milk",
            "Sugar",
            "Sweetener",
            "Cheese",
            "Mayo",
            "lettuce",
            "Tomato"});
            this.lbxMenuAdditions.Location = new System.Drawing.Point(903, 32);
            this.lbxMenuAdditions.Name = "lbxMenuAdditions";
            this.lbxMenuAdditions.Size = new System.Drawing.Size(511, 244);
            this.lbxMenuAdditions.TabIndex = 10;
            // 
            // btnAddAdditions
            // 
            this.btnAddAdditions.Location = new System.Drawing.Point(903, 296);
            this.btnAddAdditions.Name = "btnAddAdditions";
            this.btnAddAdditions.Size = new System.Drawing.Size(124, 51);
            this.btnAddAdditions.TabIndex = 11;
            this.btnAddAdditions.Text = "Add Additions";
            this.btnAddAdditions.UseVisualStyleBackColor = true;
            this.btnAddAdditions.Click += new System.EventHandler(this.btnAddAdditions_Click_1);
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 806);
            this.Controls.Add(this.btnAddAdditions);
            this.Controls.Add(this.lbxMenuAdditions);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTotalCost);
            this.Controls.Add(this.listMenu);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Name = "AddOrder";
            this.Text = "AddOrder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.ListBox listMenu;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lbxMenuAdditions;
        private System.Windows.Forms.Button btnAddAdditions;
    }
}