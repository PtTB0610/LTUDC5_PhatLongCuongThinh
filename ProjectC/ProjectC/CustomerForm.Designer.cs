namespace ProjectC
{
    partial class CustomerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCusID = new System.Windows.Forms.TextBox();
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.txtCusEmail = new System.Windows.Forms.TextBox();
            this.txtCusPhone = new System.Windows.Forms.TextBox();
            this.txtCusAddress = new System.Windows.Forms.TextBox();
            this.btnCusCreate = new System.Windows.Forms.Button();
            this.btnCusUpdate = new System.Windows.Forms.Button();
            this.btnCusDelete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CUSTOMER_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUSTOMER_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUSTOMER_EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUSTOMER_PHONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUSTOMER_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUSTOMER_ADDRESS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtbCus = new System.Windows.Forms.DateTimePicker();
            this.btnEmpCan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customber Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(575, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Customber Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(575, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date of Birth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(575, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Customer Address";
            // 
            // txtCusID
            // 
            this.txtCusID.Location = new System.Drawing.Point(172, 113);
            this.txtCusID.Name = "txtCusID";
            this.txtCusID.Size = new System.Drawing.Size(276, 20);
            this.txtCusID.TabIndex = 6;
            // 
            // txtCusName
            // 
            this.txtCusName.Location = new System.Drawing.Point(172, 140);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Size = new System.Drawing.Size(276, 20);
            this.txtCusName.TabIndex = 7;
            this.txtCusName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCusName_KeyPress);
            // 
            // txtCusEmail
            // 
            this.txtCusEmail.Location = new System.Drawing.Point(172, 167);
            this.txtCusEmail.Name = "txtCusEmail";
            this.txtCusEmail.Size = new System.Drawing.Size(276, 20);
            this.txtCusEmail.TabIndex = 8;
            // 
            // txtCusPhone
            // 
            this.txtCusPhone.Location = new System.Drawing.Point(706, 113);
            this.txtCusPhone.Name = "txtCusPhone";
            this.txtCusPhone.Size = new System.Drawing.Size(276, 20);
            this.txtCusPhone.TabIndex = 9;
            this.txtCusPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCusPhone_KeyPress);
            // 
            // txtCusAddress
            // 
            this.txtCusAddress.Location = new System.Drawing.Point(706, 174);
            this.txtCusAddress.Name = "txtCusAddress";
            this.txtCusAddress.Size = new System.Drawing.Size(276, 20);
            this.txtCusAddress.TabIndex = 11;
            // 
            // btnCusCreate
            // 
            this.btnCusCreate.Location = new System.Drawing.Point(1150, 23);
            this.btnCusCreate.Name = "btnCusCreate";
            this.btnCusCreate.Size = new System.Drawing.Size(87, 51);
            this.btnCusCreate.TabIndex = 13;
            this.btnCusCreate.Text = "Create";
            this.btnCusCreate.UseVisualStyleBackColor = true;
            this.btnCusCreate.Click += new System.EventHandler(this.btnCusCreate_Click);
            // 
            // btnCusUpdate
            // 
            this.btnCusUpdate.Location = new System.Drawing.Point(1150, 85);
            this.btnCusUpdate.Name = "btnCusUpdate";
            this.btnCusUpdate.Size = new System.Drawing.Size(87, 55);
            this.btnCusUpdate.TabIndex = 14;
            this.btnCusUpdate.Text = "Update";
            this.btnCusUpdate.UseVisualStyleBackColor = true;
            // 
            // btnCusDelete
            // 
            this.btnCusDelete.Location = new System.Drawing.Point(1150, 154);
            this.btnCusDelete.Name = "btnCusDelete";
            this.btnCusDelete.Size = new System.Drawing.Size(87, 56);
            this.btnCusDelete.TabIndex = 15;
            this.btnCusDelete.Text = "Delete";
            this.btnCusDelete.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label7.Location = new System.Drawing.Point(146, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(529, 42);
            this.label7.TabIndex = 30;
            this.label7.Text = "CUSTOMER MANAGEMENT";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CUSTOMER_ID,
            this.CUSTOMER_NAME,
            this.CUSTOMER_EMAIL,
            this.CUSTOMER_PHONE,
            this.CUSTOMER_DATE,
            this.CUSTOMER_ADDRESS});
            this.dataGridView1.Location = new System.Drawing.Point(12, 248);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1240, 688);
            this.dataGridView1.TabIndex = 31;
            // 
            // CUSTOMER_ID
            // 
            this.CUSTOMER_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CUSTOMER_ID.HeaderText = "CUSTOMER_ID";
            this.CUSTOMER_ID.Name = "CUSTOMER_ID";
            // 
            // CUSTOMER_NAME
            // 
            this.CUSTOMER_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CUSTOMER_NAME.HeaderText = "CUSTOMER_NAME";
            this.CUSTOMER_NAME.Name = "CUSTOMER_NAME";
            // 
            // CUSTOMER_EMAIL
            // 
            this.CUSTOMER_EMAIL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CUSTOMER_EMAIL.HeaderText = "CUSTOMER_EMAIL";
            this.CUSTOMER_EMAIL.Name = "CUSTOMER_EMAIL";
            // 
            // CUSTOMER_PHONE
            // 
            this.CUSTOMER_PHONE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CUSTOMER_PHONE.HeaderText = "CUSTOMER_PHONE";
            this.CUSTOMER_PHONE.Name = "CUSTOMER_PHONE";
            // 
            // CUSTOMER_DATE
            // 
            this.CUSTOMER_DATE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CUSTOMER_DATE.HeaderText = "CUSTOMER_DATE";
            this.CUSTOMER_DATE.Name = "CUSTOMER_DATE";
            // 
            // CUSTOMER_ADDRESS
            // 
            this.CUSTOMER_ADDRESS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CUSTOMER_ADDRESS.HeaderText = "CUSTOMER_ADDRESS";
            this.CUSTOMER_ADDRESS.Name = "CUSTOMER_ADDRESS";
            // 
            // dtbCus
            // 
            this.dtbCus.Location = new System.Drawing.Point(706, 147);
            this.dtbCus.Name = "dtbCus";
            this.dtbCus.Size = new System.Drawing.Size(276, 20);
            this.dtbCus.TabIndex = 32;
            this.dtbCus.Value = new System.DateTime(2014, 11, 22, 16, 39, 0, 0);
            // 
            // btnEmpCan
            // 
            this.btnEmpCan.Location = new System.Drawing.Point(1029, 23);
            this.btnEmpCan.Name = "btnEmpCan";
            this.btnEmpCan.Size = new System.Drawing.Size(100, 54);
            this.btnEmpCan.TabIndex = 33;
            this.btnEmpCan.Text = "Cancel";
            this.btnEmpCan.UseVisualStyleBackColor = true;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 948);
            this.Controls.Add(this.btnEmpCan);
            this.Controls.Add(this.dtbCus);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCusDelete);
            this.Controls.Add(this.btnCusUpdate);
            this.Controls.Add(this.btnCusCreate);
            this.Controls.Add(this.txtCusAddress);
            this.Controls.Add(this.txtCusPhone);
            this.Controls.Add(this.txtCusEmail);
            this.Controls.Add(this.txtCusName);
            this.Controls.Add(this.txtCusID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CustomerForm";
            this.Text = "CUSTOMER";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCusID;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.TextBox txtCusEmail;
        private System.Windows.Forms.TextBox txtCusPhone;
        private System.Windows.Forms.TextBox txtCusAddress;
        private System.Windows.Forms.Button btnCusCreate;
        private System.Windows.Forms.Button btnCusUpdate;
        private System.Windows.Forms.Button btnCusDelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUSTOMER_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUSTOMER_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUSTOMER_EMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUSTOMER_PHONE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUSTOMER_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUSTOMER_ADDRESS;
        private System.Windows.Forms.DateTimePicker dtbCus;
        private System.Windows.Forms.Button btnEmpCan;
    }
}