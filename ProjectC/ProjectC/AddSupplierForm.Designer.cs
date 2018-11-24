namespace ProjectC
{
    partial class AddSupplierForm
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
            this.txtSupID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSupName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSupPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSupMail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSupAddress = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cboSupStatus = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtSupID
            // 
            this.txtSupID.Location = new System.Drawing.Point(147, 23);
            this.txtSupID.Name = "txtSupID";
            this.txtSupID.Size = new System.Drawing.Size(257, 20);
            this.txtSupID.TabIndex = 0;
            this.txtSupID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSupID_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Supplier ID : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Supplier Name : ";
            // 
            // txtSupName
            // 
            this.txtSupName.Location = new System.Drawing.Point(147, 58);
            this.txtSupName.Name = "txtSupName";
            this.txtSupName.Size = new System.Drawing.Size(257, 20);
            this.txtSupName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Supplier Phone : ";
            // 
            // txtSupPhone
            // 
            this.txtSupPhone.Location = new System.Drawing.Point(147, 91);
            this.txtSupPhone.MaxLength = 11;
            this.txtSupPhone.Name = "txtSupPhone";
            this.txtSupPhone.Size = new System.Drawing.Size(257, 20);
            this.txtSupPhone.TabIndex = 4;
            this.txtSupPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSupPhone_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Supplier Email : ";
            // 
            // txtSupMail
            // 
            this.txtSupMail.Location = new System.Drawing.Point(147, 125);
            this.txtSupMail.Name = "txtSupMail";
            this.txtSupMail.Size = new System.Drawing.Size(257, 20);
            this.txtSupMail.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Supplier Address : ";
            // 
            // txtSupAddress
            // 
            this.txtSupAddress.Location = new System.Drawing.Point(147, 162);
            this.txtSupAddress.Name = "txtSupAddress";
            this.txtSupAddress.Size = new System.Drawing.Size(257, 20);
            this.txtSupAddress.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(328, 253);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(247, 253);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Supplier Status : ";
            // 
            // cboSupStatus
            // 
            this.cboSupStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSupStatus.FormattingEnabled = true;
            this.cboSupStatus.Items.AddRange(new object[] {
            "active",
            "inactive"});
            this.cboSupStatus.Location = new System.Drawing.Point(147, 198);
            this.cboSupStatus.Name = "cboSupStatus";
            this.cboSupStatus.Size = new System.Drawing.Size(257, 21);
            this.cboSupStatus.TabIndex = 15;
            // 
            // AddSupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 288);
            this.ControlBox = false;
            this.Controls.Add(this.cboSupStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSupAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSupMail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSupPhone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSupName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSupID);
            this.Name = "AddSupplierForm";
            this.Text = "AddSupplierForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSupID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSupName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSupPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSupMail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSupAddress;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboSupStatus;
    }
}