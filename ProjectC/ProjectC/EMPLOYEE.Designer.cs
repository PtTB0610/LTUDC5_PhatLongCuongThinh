﻿namespace ProjectC
{
    partial class EmployeeFORM
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.txtEmpEmail = new System.Windows.Forms.TextBox();
            this.txtEmpPhone = new System.Windows.Forms.TextBox();
            this.txtEmpAdd = new System.Windows.Forms.TextBox();
            this.btnEmpDel = new System.Windows.Forms.Button();
            this.btnEmpUpdate = new System.Windows.Forms.Button();
            this.btnEmpCreate = new System.Windows.Forms.Button();
            this.txtUserPass = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.USER_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USER_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USER_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USER_STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMPLOYEE_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMPLOYEE_EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMPLOYEE_PHONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMPLOYEE_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMPLOYEE_ADDRESS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEmpCan = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(554, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(554, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Employee Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(554, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Employee Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(554, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date of Birth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(554, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Employee Address";
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(675, 94);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(308, 20);
            this.txtEmpName.TabIndex = 7;
            this.txtEmpName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmpName_KeyPress);
            // 
            // txtEmpEmail
            // 
            this.txtEmpEmail.Location = new System.Drawing.Point(675, 127);
            this.txtEmpEmail.Name = "txtEmpEmail";
            this.txtEmpEmail.Size = new System.Drawing.Size(308, 20);
            this.txtEmpEmail.TabIndex = 8;
            // 
            // txtEmpPhone
            // 
            this.txtEmpPhone.Location = new System.Drawing.Point(675, 161);
            this.txtEmpPhone.Name = "txtEmpPhone";
            this.txtEmpPhone.Size = new System.Drawing.Size(308, 20);
            this.txtEmpPhone.TabIndex = 9;
            this.txtEmpPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmpPhone_KeyPress);
            // 
            // txtEmpAdd
            // 
            this.txtEmpAdd.Location = new System.Drawing.Point(675, 228);
            this.txtEmpAdd.Name = "txtEmpAdd";
            this.txtEmpAdd.Size = new System.Drawing.Size(308, 20);
            this.txtEmpAdd.TabIndex = 11;
            // 
            // btnEmpDel
            // 
            this.btnEmpDel.Location = new System.Drawing.Point(1028, 24);
            this.btnEmpDel.Name = "btnEmpDel";
            this.btnEmpDel.Size = new System.Drawing.Size(98, 40);
            this.btnEmpDel.TabIndex = 12;
            this.btnEmpDel.Text = "Delete";
            this.btnEmpDel.UseVisualStyleBackColor = true;
            // 
            // btnEmpUpdate
            // 
            this.btnEmpUpdate.Location = new System.Drawing.Point(1028, 88);
            this.btnEmpUpdate.Name = "btnEmpUpdate";
            this.btnEmpUpdate.Size = new System.Drawing.Size(98, 44);
            this.btnEmpUpdate.TabIndex = 13;
            this.btnEmpUpdate.Text = "Update";
            this.btnEmpUpdate.UseVisualStyleBackColor = true;
            // 
            // btnEmpCreate
            // 
            this.btnEmpCreate.Location = new System.Drawing.Point(1028, 148);
            this.btnEmpCreate.Name = "btnEmpCreate";
            this.btnEmpCreate.Size = new System.Drawing.Size(100, 45);
            this.btnEmpCreate.TabIndex = 14;
            this.btnEmpCreate.Text = "Create";
            this.btnEmpCreate.UseVisualStyleBackColor = true;
            this.btnEmpCreate.Click += new System.EventHandler(this.btnEmpCreate_Click);
            // 
            // txtUserPass
            // 
            this.txtUserPass.Location = new System.Drawing.Point(160, 153);
            this.txtUserPass.Name = "txtUserPass";
            this.txtUserPass.PasswordChar = '*';
            this.txtUserPass.Size = new System.Drawing.Size(308, 20);
            this.txtUserPass.TabIndex = 24;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(160, 120);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(308, 20);
            this.txtUserName.TabIndex = 23;
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(160, 88);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(308, 20);
            this.txtUserID.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "USER STATUS";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Password";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "User Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(39, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "USER ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "USER TYPE";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.comboBox1.Location = new System.Drawing.Point(160, 191);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(308, 21);
            this.comboBox1.TabIndex = 27;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "active",
            "inactive"});
            this.comboBox2.Location = new System.Drawing.Point(160, 225);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(308, 21);
            this.comboBox2.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label7.Location = new System.Drawing.Point(354, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(521, 42);
            this.label7.TabIndex = 29;
            this.label7.Text = "EMPLOYEE MANAGEMENT";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.USER_ID,
            this.USER_NAME,
            this.USER_TYPE,
            this.USER_STATUS,
            this.EMPLOYEE_NAME,
            this.EMPLOYEE_EMAIL,
            this.EMPLOYEE_PHONE,
            this.EMPLOYEE_DATE,
            this.EMPLOYEE_ADDRESS});
            this.dataGridView1.Location = new System.Drawing.Point(12, 291);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1240, 645);
            this.dataGridView1.TabIndex = 30;
            // 
            // USER_ID
            // 
            this.USER_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.USER_ID.HeaderText = "USER_ID";
            this.USER_ID.Name = "USER_ID";
            // 
            // USER_NAME
            // 
            this.USER_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.USER_NAME.HeaderText = "USER_NAME";
            this.USER_NAME.Name = "USER_NAME";
            // 
            // USER_TYPE
            // 
            this.USER_TYPE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.USER_TYPE.HeaderText = "USER_TYPE";
            this.USER_TYPE.Name = "USER_TYPE";
            // 
            // USER_STATUS
            // 
            this.USER_STATUS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.USER_STATUS.HeaderText = "USER_STATUS";
            this.USER_STATUS.Name = "USER_STATUS";
            // 
            // EMPLOYEE_NAME
            // 
            this.EMPLOYEE_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EMPLOYEE_NAME.HeaderText = "EMPLOYEE_NAME";
            this.EMPLOYEE_NAME.Name = "EMPLOYEE_NAME";
            // 
            // EMPLOYEE_EMAIL
            // 
            this.EMPLOYEE_EMAIL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EMPLOYEE_EMAIL.HeaderText = "EMPLOYEE_EMAIL";
            this.EMPLOYEE_EMAIL.Name = "EMPLOYEE_EMAIL";
            // 
            // EMPLOYEE_PHONE
            // 
            this.EMPLOYEE_PHONE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EMPLOYEE_PHONE.HeaderText = "EMPLOYEE_PHONE";
            this.EMPLOYEE_PHONE.Name = "EMPLOYEE_PHONE";
            // 
            // EMPLOYEE_DATE
            // 
            this.EMPLOYEE_DATE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EMPLOYEE_DATE.HeaderText = "EMPLOYEE_DATE";
            this.EMPLOYEE_DATE.Name = "EMPLOYEE_DATE";
            // 
            // EMPLOYEE_ADDRESS
            // 
            this.EMPLOYEE_ADDRESS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EMPLOYEE_ADDRESS.HeaderText = "EMPLOYEE_ADDRESS";
            this.EMPLOYEE_ADDRESS.Name = "EMPLOYEE_ADDRESS";
            // 
            // btnEmpCan
            // 
            this.btnEmpCan.Location = new System.Drawing.Point(1028, 202);
            this.btnEmpCan.Name = "btnEmpCan";
            this.btnEmpCan.Size = new System.Drawing.Size(100, 54);
            this.btnEmpCan.TabIndex = 15;
            this.btnEmpCan.Text = "Cancel";
            this.btnEmpCan.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(675, 191);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(308, 20);
            this.dateTimePicker1.TabIndex = 31;
            this.dateTimePicker1.Value = new System.DateTime(2000, 11, 22, 16, 38, 0, 0);
            // 
            // EmployeeFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 948);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUserPass);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnEmpCan);
            this.Controls.Add(this.btnEmpCreate);
            this.Controls.Add(this.btnEmpUpdate);
            this.Controls.Add(this.btnEmpDel);
            this.Controls.Add(this.txtEmpAdd);
            this.Controls.Add(this.txtEmpPhone);
            this.Controls.Add(this.txtEmpEmail);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "EmployeeFORM";
            this.Text = "EMPLOYEE";
            this.Load += new System.EventHandler(this.EmployeeFORM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.TextBox txtEmpEmail;
        private System.Windows.Forms.TextBox txtEmpPhone;
        private System.Windows.Forms.TextBox txtEmpAdd;
        private System.Windows.Forms.Button btnEmpDel;
        private System.Windows.Forms.Button btnEmpUpdate;
        private System.Windows.Forms.Button btnEmpCreate;
        private System.Windows.Forms.TextBox txtUserPass;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn USER_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn USER_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn USER_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn USER_STATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPLOYEE_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPLOYEE_EMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPLOYEE_PHONE;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPLOYEE_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPLOYEE_ADDRESS;
        private System.Windows.Forms.Button btnEmpCan;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}