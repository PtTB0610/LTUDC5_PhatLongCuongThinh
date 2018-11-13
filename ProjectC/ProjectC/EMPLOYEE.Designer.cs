namespace ProjectC
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.txtEmpEmail = new System.Windows.Forms.TextBox();
            this.txtEmpPhone = new System.Windows.Forms.TextBox();
            this.txtEmpDate = new System.Windows.Forms.TextBox();
            this.txtEmpAdd = new System.Windows.Forms.TextBox();
            this.btnEmpDel = new System.Windows.Forms.Button();
            this.btnEmpUpdate = new System.Windows.Forms.Button();
            this.btnEmpCreate = new System.Windows.Forms.Button();
            this.btnEmpLoad = new System.Windows.Forms.Button();
            this.lvEmp = new System.Windows.Forms.ListView();
            this.clEmpID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clEmpName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clEmpEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clEmpPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clEmpDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clEmpAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Employee Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Employee Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Employee Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Employee Address";
            // 
            // txtEmpID
            // 
            this.txtEmpID.Location = new System.Drawing.Point(149, 24);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(308, 20);
            this.txtEmpID.TabIndex = 6;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(149, 56);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(308, 20);
            this.txtEmpName.TabIndex = 7;
            // 
            // txtEmpEmail
            // 
            this.txtEmpEmail.Location = new System.Drawing.Point(149, 89);
            this.txtEmpEmail.Name = "txtEmpEmail";
            this.txtEmpEmail.Size = new System.Drawing.Size(308, 20);
            this.txtEmpEmail.TabIndex = 8;
            // 
            // txtEmpPhone
            // 
            this.txtEmpPhone.Location = new System.Drawing.Point(149, 131);
            this.txtEmpPhone.Name = "txtEmpPhone";
            this.txtEmpPhone.Size = new System.Drawing.Size(308, 20);
            this.txtEmpPhone.TabIndex = 9;
            // 
            // txtEmpDate
            // 
            this.txtEmpDate.Location = new System.Drawing.Point(149, 158);
            this.txtEmpDate.Name = "txtEmpDate";
            this.txtEmpDate.Size = new System.Drawing.Size(308, 20);
            this.txtEmpDate.TabIndex = 10;
            // 
            // txtEmpAdd
            // 
            this.txtEmpAdd.Location = new System.Drawing.Point(149, 190);
            this.txtEmpAdd.Name = "txtEmpAdd";
            this.txtEmpAdd.Size = new System.Drawing.Size(308, 20);
            this.txtEmpAdd.TabIndex = 11;
            // 
            // btnEmpDel
            // 
            this.btnEmpDel.Location = new System.Drawing.Point(672, 24);
            this.btnEmpDel.Name = "btnEmpDel";
            this.btnEmpDel.Size = new System.Drawing.Size(98, 40);
            this.btnEmpDel.TabIndex = 12;
            this.btnEmpDel.Text = "Delete";
            this.btnEmpDel.UseVisualStyleBackColor = true;
            // 
            // btnEmpUpdate
            // 
            this.btnEmpUpdate.Location = new System.Drawing.Point(672, 88);
            this.btnEmpUpdate.Name = "btnEmpUpdate";
            this.btnEmpUpdate.Size = new System.Drawing.Size(98, 44);
            this.btnEmpUpdate.TabIndex = 13;
            this.btnEmpUpdate.Text = "Update";
            this.btnEmpUpdate.UseVisualStyleBackColor = true;
            // 
            // btnEmpCreate
            // 
            this.btnEmpCreate.Location = new System.Drawing.Point(498, 24);
            this.btnEmpCreate.Name = "btnEmpCreate";
            this.btnEmpCreate.Size = new System.Drawing.Size(100, 45);
            this.btnEmpCreate.TabIndex = 14;
            this.btnEmpCreate.Text = "Create";
            this.btnEmpCreate.UseVisualStyleBackColor = true;
            // 
            // btnEmpLoad
            // 
            this.btnEmpLoad.Location = new System.Drawing.Point(498, 78);
            this.btnEmpLoad.Name = "btnEmpLoad";
            this.btnEmpLoad.Size = new System.Drawing.Size(100, 54);
            this.btnEmpLoad.TabIndex = 15;
            this.btnEmpLoad.Text = "Load";
            this.btnEmpLoad.UseVisualStyleBackColor = true;
            // 
            // lvEmp
            // 
            this.lvEmp.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clEmpID,
            this.clEmpName,
            this.clEmpEmail,
            this.clEmpPhone,
            this.clEmpDate,
            this.clEmpAddress});
            this.lvEmp.GridLines = true;
            this.lvEmp.Location = new System.Drawing.Point(13, 232);
            this.lvEmp.Name = "lvEmp";
            this.lvEmp.Size = new System.Drawing.Size(775, 206);
            this.lvEmp.TabIndex = 16;
            this.lvEmp.UseCompatibleStateImageBehavior = false;
            this.lvEmp.View = System.Windows.Forms.View.Details;
            // 
            // clEmpID
            // 
            this.clEmpID.Text = "EMPLOYEE ID";
            this.clEmpID.Width = 90;
            // 
            // clEmpName
            // 
            this.clEmpName.Text = "EMPLOYEE NAME";
            this.clEmpName.Width = 121;
            // 
            // clEmpEmail
            // 
            this.clEmpEmail.Text = "EMPLOYEE EMAIL";
            this.clEmpEmail.Width = 114;
            // 
            // clEmpPhone
            // 
            this.clEmpPhone.Text = "EMPLOYEE PHONE";
            this.clEmpPhone.Width = 134;
            // 
            // clEmpDate
            // 
            this.clEmpDate.Text = "EMPLOYEE DATE";
            this.clEmpDate.Width = 102;
            // 
            // clEmpAddress
            // 
            this.clEmpAddress.Text = "EMPLOYEE ADDRESS";
            this.clEmpAddress.Width = 183;
            // 
            // EmployeeFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvEmp);
            this.Controls.Add(this.btnEmpLoad);
            this.Controls.Add(this.btnEmpCreate);
            this.Controls.Add(this.btnEmpUpdate);
            this.Controls.Add(this.btnEmpDel);
            this.Controls.Add(this.txtEmpAdd);
            this.Controls.Add(this.txtEmpDate);
            this.Controls.Add(this.txtEmpPhone);
            this.Controls.Add(this.txtEmpEmail);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EmployeeFORM";
            this.Text = "EMPLOYEE";
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
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.TextBox txtEmpEmail;
        private System.Windows.Forms.TextBox txtEmpPhone;
        private System.Windows.Forms.TextBox txtEmpDate;
        private System.Windows.Forms.TextBox txtEmpAdd;
        private System.Windows.Forms.Button btnEmpDel;
        private System.Windows.Forms.Button btnEmpUpdate;
        private System.Windows.Forms.Button btnEmpCreate;
        private System.Windows.Forms.Button btnEmpLoad;
        private System.Windows.Forms.ListView lvEmp;
        private System.Windows.Forms.ColumnHeader clEmpID;
        private System.Windows.Forms.ColumnHeader clEmpName;
        private System.Windows.Forms.ColumnHeader clEmpEmail;
        private System.Windows.Forms.ColumnHeader clEmpPhone;
        private System.Windows.Forms.ColumnHeader clEmpDate;
        private System.Windows.Forms.ColumnHeader clEmpAddress;
    }
}