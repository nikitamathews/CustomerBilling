namespace customer_billing
{
    partial class CustomerBilling
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtBillAmount = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBillAmount = new System.Windows.Forms.Button();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtItemsPurchased = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BillingDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtCustomerCellNumber = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerGridView = new System.Windows.Forms.DataGridView();
            this.btnView = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.txtBillAmount);
            this.panel1.Controls.Add(this.txtDiscount);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnBillAmount);
            this.panel1.Controls.Add(this.txtRate);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtQuantity);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtItemsPurchased);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.BillingDateTimePicker);
            this.panel1.Controls.Add(this.txtCustomerCellNumber);
            this.panel1.Controls.Add(this.txtCustomerName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 747);
            this.panel1.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClear.Location = new System.Drawing.Point(167, 442);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 30);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Location = new System.Drawing.Point(14, 442);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 30);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtBillAmount
            // 
            this.txtBillAmount.Location = new System.Drawing.Point(128, 333);
            this.txtBillAmount.Name = "txtBillAmount";
            this.txtBillAmount.Size = new System.Drawing.Size(94, 20);
            this.txtBillAmount.TabIndex = 15;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(128, 271);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(94, 20);
            this.txtDiscount.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Discount % :";
            // 
            // btnBillAmount
            // 
            this.btnBillAmount.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBillAmount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBillAmount.Location = new System.Drawing.Point(14, 333);
            this.btnBillAmount.Name = "btnBillAmount";
            this.btnBillAmount.Size = new System.Drawing.Size(97, 23);
            this.btnBillAmount.TabIndex = 12;
            this.btnBillAmount.Text = "Total Bill Amount";
            this.btnBillAmount.UseVisualStyleBackColor = false;
            this.btnBillAmount.Click += new System.EventHandler(this.btnBillAmount_Click);
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(128, 225);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(94, 20);
            this.txtRate.TabIndex = 11;
            this.txtRate.Leave += new System.EventHandler(this.txtRate_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Item Rate :";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(128, 186);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(94, 20);
            this.txtQuantity.TabIndex = 9;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            this.txtQuantity.Leave += new System.EventHandler(this.txtQuantity_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Item Quantity :";
            // 
            // txtItemsPurchased
            // 
            this.txtItemsPurchased.Location = new System.Drawing.Point(128, 146);
            this.txtItemsPurchased.Name = "txtItemsPurchased";
            this.txtItemsPurchased.Size = new System.Drawing.Size(300, 20);
            this.txtItemsPurchased.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Items Purchased :";
            // 
            // BillingDateTimePicker
            // 
            this.BillingDateTimePicker.Location = new System.Drawing.Point(128, 107);
            this.BillingDateTimePicker.Name = "BillingDateTimePicker";
            this.BillingDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.BillingDateTimePicker.TabIndex = 5;
            // 
            // txtCustomerCellNumber
            // 
            this.txtCustomerCellNumber.Location = new System.Drawing.Point(128, 73);
            this.txtCustomerCellNumber.Name = "txtCustomerCellNumber";
            this.txtCustomerCellNumber.Size = new System.Drawing.Size(300, 20);
            this.txtCustomerCellNumber.TabIndex = 4;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(128, 36);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(300, 20);
            this.txtCustomerName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Billing Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Cell Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name:";
            // 
            // CustomerGridView
            // 
            this.CustomerGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.CustomerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerGridView.Location = new System.Drawing.Point(518, 31);
            this.CustomerGridView.Name = "CustomerGridView";
            this.CustomerGridView.Size = new System.Drawing.Size(840, 659);
            this.CustomerGridView.TabIndex = 1;
            this.CustomerGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerGridView_CellContentClick);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnView.Location = new System.Drawing.Point(518, 1);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(97, 30);
            this.btnView.TabIndex = 18;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // CustomerBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.CustomerGridView);
            this.Controls.Add(this.panel1);
            this.Name = "CustomerBilling";
            this.Text = "Customer Billing";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker BillingDateTimePicker;
        private System.Windows.Forms.TextBox txtCustomerCellNumber;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBillAmount;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtItemsPurchased;
        private System.Windows.Forms.TextBox txtBillAmount;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView CustomerGridView;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnView;
    }
}

