namespace ProjectC
{
    partial class UserInfoForm
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
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtUserPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cboUserType = new System.Windows.Forms.ComboBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password :";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(136, 20);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(261, 20);
            this.txtUserName.TabIndex = 2;
            this.txtUserName.Leave += new System.EventHandler(this.txtUserName_Leave);
            // 
            // txtUserPass
            // 
            this.txtUserPass.Location = new System.Drawing.Point(136, 58);
            this.txtUserPass.Name = "txtUserPass";
            this.txtUserPass.Size = new System.Drawing.Size(261, 20);
            this.txtUserPass.TabIndex = 3;
            this.txtUserPass.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "User Type :";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(47, 123);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 23);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cboUserType
            // 
            this.cboUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUserType.FormattingEnabled = true;
            this.cboUserType.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "User"});
            this.cboUserType.Location = new System.Drawing.Point(136, 96);
            this.cboUserType.Name = "cboUserType";
            this.cboUserType.Size = new System.Drawing.Size(261, 21);
            this.cboUserType.TabIndex = 21;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToResizeColumns = false;
            this.dgvData.AllowUserToResizeRows = false;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvData.Location = new System.Drawing.Point(0, 181);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(506, 216);
            this.dgvData.TabIndex = 22;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(314, 123);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(83, 23);
            this.btnExit.TabIndex = 23;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(136, 123);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(83, 23);
            this.btnAddNew.TabIndex = 24;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(225, 123);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(83, 23);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // UserInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 397);
            this.ControlBox = false;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.cboUserType);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUserPass);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "UserInfoForm";
            this.Text = "UserInfoForm";
            this.Load += new System.EventHandler(this.UserInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtUserPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cboUserType;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnClear;
    }
}