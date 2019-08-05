namespace CoffeeshopRegistration
{
    partial class MainForm
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
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.CustomersList = new System.Windows.Forms.ListBox();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.listOrder = new System.Windows.Forms.ListBox();
            this.btn_customersNotDelivered = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOrdersTime = new System.Windows.Forms.Button();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(858, 35);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(149, 42);
            this.btnAddCustomer.TabIndex = 0;
            this.btnAddCustomer.Text = "AddCustomer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // CustomersList
            // 
            this.CustomersList.FormattingEnabled = true;
            this.CustomersList.ItemHeight = 20;
            this.CustomersList.Location = new System.Drawing.Point(32, 35);
            this.CustomersList.Name = "CustomersList";
            this.CustomersList.Size = new System.Drawing.Size(708, 344);
            this.CustomersList.TabIndex = 1;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(858, 173);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(149, 45);
            this.btnAddOrder.TabIndex = 2;
            this.btnAddOrder.Text = "Add Order";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(858, 246);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(149, 45);
            this.btnsave.TabIndex = 3;
            this.btnsave.Text = "Save Customer";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(858, 99);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(149, 50);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit Customer";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // listOrder
            // 
            this.listOrder.FormattingEnabled = true;
            this.listOrder.ItemHeight = 20;
            this.listOrder.Location = new System.Drawing.Point(32, 428);
            this.listOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listOrder.Name = "listOrder";
            this.listOrder.Size = new System.Drawing.Size(708, 224);
            this.listOrder.TabIndex = 5;
            // 
            // btn_customersNotDelivered
            // 
            this.btn_customersNotDelivered.Location = new System.Drawing.Point(858, 314);
            this.btn_customersNotDelivered.Name = "btn_customersNotDelivered";
            this.btn_customersNotDelivered.Size = new System.Drawing.Size(149, 76);
            this.btn_customersNotDelivered.TabIndex = 6;
            this.btn_customersNotDelivered.Text = "Customers_Not Delivered";
            this.btn_customersNotDelivered.UseVisualStyleBackColor = true;
            this.btn_customersNotDelivered.Click += new System.EventHandler(this.btn_customersNotDelivered_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(766, 462);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "From";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1069, 468);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "To";
            // 
            // btnOrdersTime
            // 
            this.btnOrdersTime.Location = new System.Drawing.Point(976, 522);
            this.btnOrdersTime.Name = "btnOrdersTime";
            this.btnOrdersTime.Size = new System.Drawing.Size(155, 64);
            this.btnOrdersTime.TabIndex = 12;
            this.btnOrdersTime.Text = "Get CustomersList";
            this.btnOrdersTime.UseVisualStyleBackColor = true;
            this.btnOrdersTime.Click += new System.EventHandler(this.btnOrdersTime_Click);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(818, 462);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(205, 26);
            this.dtpFrom.TabIndex = 15;
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(1102, 462);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 26);
            this.dtpTo.TabIndex = 16;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 751);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.btnOrdersTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_customersNotDelivered);
            this.Controls.Add(this.listOrder);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.CustomersList);
            this.Controls.Add(this.btnAddCustomer);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.ListBox CustomersList;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ListBox listOrder;
        private System.Windows.Forms.Button btn_customersNotDelivered;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOrdersTime;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
    }
}

