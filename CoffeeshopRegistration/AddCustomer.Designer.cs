namespace CoffeeshopRegistration
{
    partial class AddCustomer
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
            this.bx_Customer = new System.Windows.Forms.GroupBox();
            this.btnAdd_customer = new System.Windows.Forms.Button();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.txtPhoneno = new System.Windows.Forms.TextBox();
            this.lbl_postalcode = new System.Windows.Forms.Label();
            this.lbl_province = new System.Windows.Forms.Label();
            this.lbl_city = new System.Windows.Forms.Label();
            this.lbl_street = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.bx_Customer.SuspendLayout();
            this.SuspendLayout();
            // 
            // bx_Customer
            // 
            this.bx_Customer.Controls.Add(this.btnAdd_customer);
            this.bx_Customer.Controls.Add(this.lbl_phone);
            this.bx_Customer.Controls.Add(this.txtPhoneno);
            this.bx_Customer.Controls.Add(this.lbl_postalcode);
            this.bx_Customer.Controls.Add(this.lbl_province);
            this.bx_Customer.Controls.Add(this.lbl_city);
            this.bx_Customer.Controls.Add(this.lbl_street);
            this.bx_Customer.Controls.Add(this.lbl_name);
            this.bx_Customer.Controls.Add(this.txtName);
            this.bx_Customer.Controls.Add(this.txtStreet);
            this.bx_Customer.Controls.Add(this.txtPostalCode);
            this.bx_Customer.Controls.Add(this.txtProvince);
            this.bx_Customer.Controls.Add(this.txtCity);
            this.bx_Customer.Location = new System.Drawing.Point(82, 8);
            this.bx_Customer.Margin = new System.Windows.Forms.Padding(2);
            this.bx_Customer.Name = "bx_Customer";
            this.bx_Customer.Padding = new System.Windows.Forms.Padding(2);
            this.bx_Customer.Size = new System.Drawing.Size(369, 277);
            this.bx_Customer.TabIndex = 0;
            this.bx_Customer.TabStop = false;
            this.bx_Customer.Text = "Customer";
            // 
            // btnAdd_customer
            // 
            this.btnAdd_customer.Location = new System.Drawing.Point(178, 240);
            this.btnAdd_customer.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd_customer.Name = "btnAdd_customer";
            this.btnAdd_customer.Size = new System.Drawing.Size(82, 22);
            this.btnAdd_customer.TabIndex = 16;
            this.btnAdd_customer.Text = "Add/Update";
            this.btnAdd_customer.UseVisualStyleBackColor = true;
            this.btnAdd_customer.Click += new System.EventHandler(this.btnAdd_customer_Click);
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Location = new System.Drawing.Point(59, 207);
            this.lbl_phone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(55, 13);
            this.lbl_phone.TabIndex = 15;
            this.lbl_phone.Text = "Phone No";
            // 
            // txtPhoneno
            // 
            this.txtPhoneno.Location = new System.Drawing.Point(161, 200);
            this.txtPhoneno.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhoneno.Name = "txtPhoneno";
            this.txtPhoneno.Size = new System.Drawing.Size(179, 20);
            this.txtPhoneno.TabIndex = 14;
            // 
            // lbl_postalcode
            // 
            this.lbl_postalcode.AutoSize = true;
            this.lbl_postalcode.Location = new System.Drawing.Point(59, 177);
            this.lbl_postalcode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_postalcode.Name = "lbl_postalcode";
            this.lbl_postalcode.Size = new System.Drawing.Size(61, 13);
            this.lbl_postalcode.TabIndex = 13;
            this.lbl_postalcode.Text = "PostalCode";
            // 
            // lbl_province
            // 
            this.lbl_province.AutoSize = true;
            this.lbl_province.Location = new System.Drawing.Point(59, 139);
            this.lbl_province.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_province.Name = "lbl_province";
            this.lbl_province.Size = new System.Drawing.Size(49, 13);
            this.lbl_province.TabIndex = 12;
            this.lbl_province.Text = "Province";
            // 
            // lbl_city
            // 
            this.lbl_city.AutoSize = true;
            this.lbl_city.Location = new System.Drawing.Point(59, 101);
            this.lbl_city.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_city.Name = "lbl_city";
            this.lbl_city.Size = new System.Drawing.Size(24, 13);
            this.lbl_city.TabIndex = 11;
            this.lbl_city.Text = "City";
            // 
            // lbl_street
            // 
            this.lbl_street.AutoSize = true;
            this.lbl_street.Location = new System.Drawing.Point(59, 75);
            this.lbl_street.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_street.Name = "lbl_street";
            this.lbl_street.Size = new System.Drawing.Size(76, 13);
            this.lbl_street.TabIndex = 10;
            this.lbl_street.Text = "Street Address";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(59, 37);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_name.TabIndex = 9;
            this.lbl_name.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(161, 34);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(179, 20);
            this.txtName.TabIndex = 7;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(161, 68);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(2);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(179, 20);
            this.txtStreet.TabIndex = 6;
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(161, 170);
            this.txtPostalCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(179, 20);
            this.txtPostalCode.TabIndex = 5;
            // 
            // txtProvince
            // 
            this.txtProvince.Location = new System.Drawing.Point(161, 132);
            this.txtProvince.Margin = new System.Windows.Forms.Padding(2);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(179, 20);
            this.txtProvince.TabIndex = 4;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(161, 98);
            this.txtCity.Margin = new System.Windows.Forms.Padding(2);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(179, 20);
            this.txtCity.TabIndex = 3;
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 400);
            this.Controls.Add(this.bx_Customer);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddCustomer";
            this.Text = "Add_Customer";
            this.bx_Customer.ResumeLayout(false);
            this.bx_Customer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox bx_Customer;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.TextBox txtProvince;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lbl_postalcode;
        private System.Windows.Forms.Label lbl_province;
        private System.Windows.Forms.Label lbl_city;
        private System.Windows.Forms.Label lbl_street;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button btnAdd_customer;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.TextBox txtPhoneno;
    }
}