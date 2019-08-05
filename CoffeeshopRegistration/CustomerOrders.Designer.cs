namespace CoffeeshopRegistration
{
    partial class CustomerOrders
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
            this.lbxcustomerNotDelivered = new System.Windows.Forms.ListBox();
            this.lbxOrderlist = new System.Windows.Forms.ListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxcustomerNotDelivered
            // 
            this.lbxcustomerNotDelivered.FormattingEnabled = true;
            this.lbxcustomerNotDelivered.Location = new System.Drawing.Point(33, 25);
            this.lbxcustomerNotDelivered.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbxcustomerNotDelivered.Name = "lbxcustomerNotDelivered";
            this.lbxcustomerNotDelivered.Size = new System.Drawing.Size(669, 134);
            this.lbxcustomerNotDelivered.TabIndex = 0;
            this.lbxcustomerNotDelivered.SelectedIndexChanged += new System.EventHandler(this.lbxcustomerNotDelivered_SelectedIndexChanged);
            // 
            // lbxOrderlist
            // 
            this.lbxOrderlist.FormattingEnabled = true;
            this.lbxOrderlist.Location = new System.Drawing.Point(33, 216);
            this.lbxOrderlist.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbxOrderlist.Name = "lbxOrderlist";
            this.lbxOrderlist.Size = new System.Drawing.Size(669, 160);
            this.lbxOrderlist.TabIndex = 1;
            
            // 
            // btnBack
            // 
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnBack.Location = new System.Drawing.Point(306, 394);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(113, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
           
            // 
            // CustomerOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 448);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lbxOrderlist);
            this.Controls.Add(this.lbxcustomerNotDelivered);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CustomerOrders";
            this.Text = "CustomerOrders";
            
            this.Load += new System.EventHandler(this.CustomerOrders_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxcustomerNotDelivered;
        private System.Windows.Forms.ListBox lbxOrderlist;
        private System.Windows.Forms.Button btnBack;
    }
}