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
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.txtEmpSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtBirth = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmpAdd = new System.Windows.Forms.TextBox();
            this.txtEmpPhone = new System.Windows.Forms.TextBox();
            this.txtEmpEmail = new System.Windows.Forms.TextBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnEmpSearch = new System.Windows.Forms.Button();
            this.btnEmpCreate = new System.Windows.Forms.Button();
            this.btnEmpUpdate = new System.Windows.Forms.Button();
            this.btnEmpDel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(4, 399);
            this.dgvEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployee.Size = new System.Drawing.Size(1333, 394);
            this.dgvEmployee.TabIndex = 30;
            this.dgvEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellClick);
            // 
            // txtEmpID
            // 
            this.txtEmpID.Location = new System.Drawing.Point(181, 90);
            this.txtEmpID.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(621, 22);
            this.txtEmpID.TabIndex = 49;
            // 
            // txtEmpSearch
            // 
            this.txtEmpSearch.Location = new System.Drawing.Point(181, 315);
            this.txtEmpSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmpSearch.Name = "txtEmpSearch";
            this.txtEmpSearch.Size = new System.Drawing.Size(621, 22);
            this.txtEmpSearch.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 319);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 17);
            this.label8.TabIndex = 47;
            this.label8.Text = "Employee Find";
            // 
            // dtBirth
            // 
            this.dtBirth.Location = new System.Drawing.Point(181, 241);
            this.dtBirth.Margin = new System.Windows.Forms.Padding(4);
            this.dtBirth.Name = "dtBirth";
            this.dtBirth.Size = new System.Drawing.Size(621, 22);
            this.dtBirth.TabIndex = 46;
            this.dtBirth.Value = new System.DateTime(2000, 11, 22, 16, 38, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label7.Location = new System.Drawing.Point(440, 24);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(647, 54);
            this.label7.TabIndex = 45;
            this.label7.Text = "EMPLOYEE MANAGEMENT";
            // 
            // txtEmpAdd
            // 
            this.txtEmpAdd.Location = new System.Drawing.Point(181, 287);
            this.txtEmpAdd.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmpAdd.Name = "txtEmpAdd";
            this.txtEmpAdd.Size = new System.Drawing.Size(621, 22);
            this.txtEmpAdd.TabIndex = 44;
            // 
            // txtEmpPhone
            // 
            this.txtEmpPhone.Location = new System.Drawing.Point(181, 204);
            this.txtEmpPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmpPhone.Name = "txtEmpPhone";
            this.txtEmpPhone.Size = new System.Drawing.Size(621, 22);
            this.txtEmpPhone.TabIndex = 43;
            this.txtEmpPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmpPhone_KeyPress);
            // 
            // txtEmpEmail
            // 
            this.txtEmpEmail.Location = new System.Drawing.Point(181, 163);
            this.txtEmpEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmpEmail.Name = "txtEmpEmail";
            this.txtEmpEmail.Size = new System.Drawing.Size(621, 22);
            this.txtEmpEmail.TabIndex = 42;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(181, 122);
            this.txtEmpName.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(621, 22);
            this.txtEmpName.TabIndex = 41;
            this.txtEmpName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmpName_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 287);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 17);
            this.label6.TabIndex = 40;
            this.label6.Text = "Employee Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 202);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 39;
            this.label4.Text = "Employee Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 163);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "Employee Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Employee Name";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1086, 241);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(133, 62);
            this.btnThoat.TabIndex = 55;
            this.btnThoat.Text = "E&XIT";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(885, 244);
            this.btnrefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(133, 59);
            this.btnrefresh.TabIndex = 54;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btnEmpSearch
            // 
            this.btnEmpSearch.Location = new System.Drawing.Point(885, 319);
            this.btnEmpSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmpSearch.Name = "btnEmpSearch";
            this.btnEmpSearch.Size = new System.Drawing.Size(133, 54);
            this.btnEmpSearch.TabIndex = 53;
            this.btnEmpSearch.Text = "Search";
            this.btnEmpSearch.UseVisualStyleBackColor = true;
            this.btnEmpSearch.Click += new System.EventHandler(this.btnEmpSearch_Click);
            // 
            // btnEmpCreate
            // 
            this.btnEmpCreate.Location = new System.Drawing.Point(885, 90);
            this.btnEmpCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmpCreate.Name = "btnEmpCreate";
            this.btnEmpCreate.Size = new System.Drawing.Size(133, 64);
            this.btnEmpCreate.TabIndex = 52;
            this.btnEmpCreate.Text = "Create";
            this.btnEmpCreate.UseVisualStyleBackColor = true;
            this.btnEmpCreate.Click += new System.EventHandler(this.btnEmpCreate_Click);
            // 
            // btnEmpUpdate
            // 
            this.btnEmpUpdate.Location = new System.Drawing.Point(1086, 90);
            this.btnEmpUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmpUpdate.Name = "btnEmpUpdate";
            this.btnEmpUpdate.Size = new System.Drawing.Size(133, 64);
            this.btnEmpUpdate.TabIndex = 51;
            this.btnEmpUpdate.Text = "Update";
            this.btnEmpUpdate.UseVisualStyleBackColor = true;
            this.btnEmpUpdate.Click += new System.EventHandler(this.btnEmpUpdate_Click);
            // 
            // btnEmpDel
            // 
            this.btnEmpDel.Location = new System.Drawing.Point(885, 163);
            this.btnEmpDel.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmpDel.Name = "btnEmpDel";
            this.btnEmpDel.Size = new System.Drawing.Size(133, 65);
            this.btnEmpDel.TabIndex = 50;
            this.btnEmpDel.Text = "Delete";
            this.btnEmpDel.UseVisualStyleBackColor = true;
            this.btnEmpDel.Click += new System.EventHandler(this.btnEmpDel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 244);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 56;
            this.label5.Text = "Date of Birth";
            // 
            // EmployeeFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 828);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btnEmpSearch);
            this.Controls.Add(this.btnEmpCreate);
            this.Controls.Add(this.btnEmpUpdate);
            this.Controls.Add(this.btnEmpDel);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.txtEmpSearch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtBirth);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEmpAdd);
            this.Controls.Add(this.txtEmpPhone);
            this.Controls.Add(this.txtEmpEmail);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvEmployee);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeeFORM";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "EMPLOYEE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmployeeFORM_FormClosing);
            this.Load += new System.EventHandler(this.EmployeeFORM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.TextBox txtEmpSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtBirth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmpAdd;
        private System.Windows.Forms.TextBox txtEmpPhone;
        private System.Windows.Forms.TextBox txtEmpEmail;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btnEmpSearch;
        private System.Windows.Forms.Button btnEmpCreate;
        private System.Windows.Forms.Button btnEmpUpdate;
        private System.Windows.Forms.Button btnEmpDel;
        private System.Windows.Forms.Label label5;
    }
}