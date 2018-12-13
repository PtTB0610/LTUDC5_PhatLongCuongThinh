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
            this.dgvCus = new System.Windows.Forms.DataGridView();
            this.dtbCus = new System.Windows.Forms.DateTimePicker();
            this.btnEmpCan = new System.Windows.Forms.Button();
            this.btnCusRef = new System.Windows.Forms.Button();
            this.btnCusSearch = new System.Windows.Forms.Button();
            this.txtCusSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCus)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 136);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 172);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 209);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customber Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(554, 144);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Customber Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(588, 174);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date of Birth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(551, 209);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Customer Address";
            // 
            // txtCusID
            // 
            this.txtCusID.Location = new System.Drawing.Point(134, 136);
            this.txtCusID.Margin = new System.Windows.Forms.Padding(4);
            this.txtCusID.Name = "txtCusID";
            this.txtCusID.Size = new System.Drawing.Size(367, 22);
            this.txtCusID.TabIndex = 6;
            // 
            // txtCusName
            // 
            this.txtCusName.Location = new System.Drawing.Point(134, 169);
            this.txtCusName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Size = new System.Drawing.Size(367, 22);
            this.txtCusName.TabIndex = 7;
            this.txtCusName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCusName_KeyPress);
            // 
            // txtCusEmail
            // 
            this.txtCusEmail.Location = new System.Drawing.Point(134, 206);
            this.txtCusEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtCusEmail.Name = "txtCusEmail";
            this.txtCusEmail.Size = new System.Drawing.Size(367, 22);
            this.txtCusEmail.TabIndex = 8;
            // 
            // txtCusPhone
            // 
            this.txtCusPhone.Location = new System.Drawing.Point(683, 141);
            this.txtCusPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtCusPhone.Name = "txtCusPhone";
            this.txtCusPhone.Size = new System.Drawing.Size(286, 22);
            this.txtCusPhone.TabIndex = 9;
            this.txtCusPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCusPhone_KeyPress);
            // 
            // txtCusAddress
            // 
            this.txtCusAddress.Location = new System.Drawing.Point(683, 209);
            this.txtCusAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtCusAddress.Name = "txtCusAddress";
            this.txtCusAddress.Size = new System.Drawing.Size(286, 22);
            this.txtCusAddress.TabIndex = 11;
            // 
            // btnCusCreate
            // 
            this.btnCusCreate.Location = new System.Drawing.Point(1015, 22);
            this.btnCusCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCusCreate.Name = "btnCusCreate";
            this.btnCusCreate.Size = new System.Drawing.Size(116, 63);
            this.btnCusCreate.TabIndex = 13;
            this.btnCusCreate.Text = "Create";
            this.btnCusCreate.UseVisualStyleBackColor = true;
            this.btnCusCreate.Click += new System.EventHandler(this.btnCusCreate_Click);
            // 
            // btnCusUpdate
            // 
            this.btnCusUpdate.Location = new System.Drawing.Point(1015, 110);
            this.btnCusUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCusUpdate.Name = "btnCusUpdate";
            this.btnCusUpdate.Size = new System.Drawing.Size(116, 68);
            this.btnCusUpdate.TabIndex = 14;
            this.btnCusUpdate.Text = "Update";
            this.btnCusUpdate.UseVisualStyleBackColor = true;
            this.btnCusUpdate.Click += new System.EventHandler(this.btnCusUpdate_Click);
            // 
            // btnCusDelete
            // 
            this.btnCusDelete.Location = new System.Drawing.Point(1166, 109);
            this.btnCusDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnCusDelete.Name = "btnCusDelete";
            this.btnCusDelete.Size = new System.Drawing.Size(133, 69);
            this.btnCusDelete.TabIndex = 15;
            this.btnCusDelete.Text = "Delete";
            this.btnCusDelete.UseVisualStyleBackColor = true;
            this.btnCusDelete.Click += new System.EventHandler(this.btnCusDelete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label7.Location = new System.Drawing.Point(195, 22);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(659, 54);
            this.label7.TabIndex = 30;
            this.label7.Text = "CUSTOMER MANAGEMENT";
            // 
            // dgvCus
            // 
            this.dgvCus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCus.Location = new System.Drawing.Point(16, 306);
            this.dgvCus.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCus.Name = "dgvCus";
            this.dgvCus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCus.Size = new System.Drawing.Size(1304, 509);
            this.dgvCus.TabIndex = 31;
            this.dgvCus.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCus_CellClick);
            this.dgvCus.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCus_CellContentClick);
            // 
            // dtbCus
            // 
            this.dtbCus.Location = new System.Drawing.Point(683, 172);
            this.dtbCus.Margin = new System.Windows.Forms.Padding(4);
            this.dtbCus.Name = "dtbCus";
            this.dtbCus.Size = new System.Drawing.Size(286, 22);
            this.dtbCus.TabIndex = 32;
            this.dtbCus.Value = new System.DateTime(2014, 11, 22, 16, 39, 0, 0);
            // 
            // btnEmpCan
            // 
            this.btnEmpCan.Location = new System.Drawing.Point(1166, 208);
            this.btnEmpCan.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmpCan.Name = "btnEmpCan";
            this.btnEmpCan.Size = new System.Drawing.Size(133, 66);
            this.btnEmpCan.TabIndex = 33;
            this.btnEmpCan.Text = "Cancel";
            this.btnEmpCan.UseVisualStyleBackColor = true;
            this.btnEmpCan.Click += new System.EventHandler(this.btnEmpCan_Click);
            // 
            // btnCusRef
            // 
            this.btnCusRef.Location = new System.Drawing.Point(1166, 27);
            this.btnCusRef.Margin = new System.Windows.Forms.Padding(4);
            this.btnCusRef.Name = "btnCusRef";
            this.btnCusRef.Size = new System.Drawing.Size(133, 66);
            this.btnCusRef.TabIndex = 34;
            this.btnCusRef.Text = "Refesh";
            this.btnCusRef.UseVisualStyleBackColor = true;
            this.btnCusRef.Click += new System.EventHandler(this.btnCusRef_Click);
            // 
            // btnCusSearch
            // 
            this.btnCusSearch.Location = new System.Drawing.Point(1015, 205);
            this.btnCusSearch.Name = "btnCusSearch";
            this.btnCusSearch.Size = new System.Drawing.Size(115, 71);
            this.btnCusSearch.TabIndex = 35;
            this.btnCusSearch.Text = "Search";
            this.btnCusSearch.UseVisualStyleBackColor = true;
            this.btnCusSearch.Click += new System.EventHandler(this.btnCusSearch_Click);
            // 
            // txtCusSearch
            // 
            this.txtCusSearch.Location = new System.Drawing.Point(310, 252);
            this.txtCusSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtCusSearch.Name = "txtCusSearch";
            this.txtCusSearch.Size = new System.Drawing.Size(577, 22);
            this.txtCusSearch.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(185, 255);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 17);
            this.label8.TabIndex = 36;
            this.label8.Text = "Customer Search";
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 828);
            this.Controls.Add(this.txtCusSearch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCusSearch);
            this.Controls.Add(this.btnCusRef);
            this.Controls.Add(this.btnEmpCan);
            this.Controls.Add(this.dtbCus);
            this.Controls.Add(this.dgvCus);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomerForm";
            this.Text = "CUSTOMER";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomerForm_FormClosing);
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCus)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvCus;
        private System.Windows.Forms.DateTimePicker dtbCus;
        private System.Windows.Forms.Button btnEmpCan;
        private System.Windows.Forms.Button btnCusRef;
        private System.Windows.Forms.Button btnCusSearch;
        private System.Windows.Forms.TextBox txtCusSearch;
        private System.Windows.Forms.Label label8;
    }
}