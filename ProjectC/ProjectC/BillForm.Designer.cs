namespace ProjectC
{
    partial class BillForm
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
            this.txtTimMaHoaDon = new System.Windows.Forms.TextBox();
            this.btnTimMaHoaDon = new System.Windows.Forms.Button();
            this.lblTimMaHoaDon = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMaHoaDon = new System.Windows.Forms.Label();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.dtgDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaThanhToan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRef = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTimMaHoaDon
            // 
            this.txtTimMaHoaDon.Location = new System.Drawing.Point(125, 11);
            this.txtTimMaHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimMaHoaDon.Name = "txtTimMaHoaDon";
            this.txtTimMaHoaDon.Size = new System.Drawing.Size(459, 22);
            this.txtTimMaHoaDon.TabIndex = 8;
            this.txtTimMaHoaDon.TextChanged += new System.EventHandler(this.txtTimMaHoaDon_TextChanged);
            // 
            // btnTimMaHoaDon
            // 
            this.btnTimMaHoaDon.ForeColor = System.Drawing.Color.Blue;
            this.btnTimMaHoaDon.Location = new System.Drawing.Point(619, 6);
            this.btnTimMaHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimMaHoaDon.Name = "btnTimMaHoaDon";
            this.btnTimMaHoaDon.Size = new System.Drawing.Size(92, 28);
            this.btnTimMaHoaDon.TabIndex = 9;
            this.btnTimMaHoaDon.Text = "Search";
            this.btnTimMaHoaDon.UseVisualStyleBackColor = true;
            // 
            // lblTimMaHoaDon
            // 
            this.lblTimMaHoaDon.AutoSize = true;
            this.lblTimMaHoaDon.ForeColor = System.Drawing.Color.Blue;
            this.lblTimMaHoaDon.Location = new System.Drawing.Point(66, 14);
            this.lblTimMaHoaDon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimMaHoaDon.Name = "lblTimMaHoaDon";
            this.lblTimMaHoaDon.Size = new System.Drawing.Size(43, 17);
            this.lblTimMaHoaDon.TabIndex = 10;
            this.lblTimMaHoaDon.Text = "Bill ID";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblTimMaHoaDon);
            this.panel3.Controls.Add(this.btnTimMaHoaDon);
            this.panel3.Controls.Add(this.txtTimMaHoaDon);
            this.panel3.Location = new System.Drawing.Point(24, 892);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(786, 44);
            this.panel3.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 52);
            this.label1.TabIndex = 12;
            this.label1.Text = "BILL OF PRODUCT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMaHoaDon
            // 
            this.lblMaHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHoaDon.Location = new System.Drawing.Point(25, 76);
            this.lblMaHoaDon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaHoaDon.Name = "lblMaHoaDon";
            this.lblMaHoaDon.Size = new System.Drawing.Size(132, 25);
            this.lblMaHoaDon.TabIndex = 13;
            this.lblMaHoaDon.Text = "BILL ID";
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.Enabled = false;
            this.txtMaHoaDon.Location = new System.Drawing.Point(198, 80);
            this.txtMaHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(572, 22);
            this.txtMaHoaDon.TabIndex = 14;
            this.txtMaHoaDon.TextChanged += new System.EventHandler(this.txtMaHoaDon_TextChanged);
            this.txtMaHoaDon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaHoaDon_KeyPress);
            // 
            // dtgDate
            // 
            this.dtgDate.CustomFormat = "";
            this.dtgDate.Enabled = false;
            this.dtgDate.Location = new System.Drawing.Point(198, 120);
            this.dtgDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtgDate.Name = "dtgDate";
            this.dtgDate.Size = new System.Drawing.Size(572, 22);
            this.dtgDate.TabIndex = 15;
            this.dtgDate.Value = new System.DateTime(2018, 11, 22, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "DATE";
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.Enabled = false;
            this.txtMaKhachHang.Location = new System.Drawing.Point(198, 167);
            this.txtMaKhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(572, 22);
            this.txtMaKhachHang.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "CUSTOMER ID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Enabled = false;
            this.txtMaNhanVien.Location = new System.Drawing.Point(198, 216);
            this.txtMaNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(572, 22);
            this.txtMaNhanVien.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 212);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "EMPLOYEE ID";
            // 
            // txtMaThanhToan
            // 
            this.txtMaThanhToan.Enabled = false;
            this.txtMaThanhToan.Location = new System.Drawing.Point(198, 260);
            this.txtMaThanhToan.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaThanhToan.Name = "txtMaThanhToan";
            this.txtMaThanhToan.Size = new System.Drawing.Size(572, 22);
            this.txtMaThanhToan.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 260);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "PAYMENT ID";
            // 
            // txtMaHang
            // 
            this.txtMaHang.Enabled = false;
            this.txtMaHang.Location = new System.Drawing.Point(198, 302);
            this.txtMaHang.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(572, 22);
            this.txtMaHang.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 302);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 25);
            this.label6.TabIndex = 24;
            this.label6.Text = "PRODUCT ID";
            // 
            // dgvBill
            // 
            this.dgvBill.AllowUserToAddRows = false;
            this.dgvBill.AllowUserToDeleteRows = false;
            this.dgvBill.AllowUserToResizeColumns = false;
            this.dgvBill.AllowUserToResizeRows = false;
            this.dgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Location = new System.Drawing.Point(30, 353);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.RowTemplate.Height = 24;
            this.dgvBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBill.Size = new System.Drawing.Size(940, 301);
            this.dgvBill.TabIndex = 25;
            this.dgvBill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBill_CellContentClick);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(836, 76);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(100, 50);
            this.btnCreate.TabIndex = 26;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(836, 277);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 50);
            this.btnClose.TabIndex = 27;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRef
            // 
            this.btnRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRef.Location = new System.Drawing.Point(836, 212);
            this.btnRef.Name = "btnRef";
            this.btnRef.Size = new System.Drawing.Size(100, 50);
            this.btnRef.TabIndex = 28;
            this.btnRef.Text = "Refesh";
            this.btnRef.UseVisualStyleBackColor = true;
            this.btnRef.Click += new System.EventHandler(this.btnRef_Click);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(836, 139);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(100, 50);
            this.btnDel.TabIndex = 29;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // BillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.ControlBox = false;
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnRef);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.dgvBill);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMaHang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMaThanhToan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaKhachHang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgDate);
            this.Controls.Add(this.txtMaHoaDon);
            this.Controls.Add(this.lblMaHoaDon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BillForm";
            this.Text = "Bill";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BillForm_FormClosing);
            this.Load += new System.EventHandler(this.BillForm_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTimMaHoaDon;
        private System.Windows.Forms.Button btnTimMaHoaDon;
        private System.Windows.Forms.Label lblTimMaHoaDon;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMaHoaDon;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.DateTimePicker dtgDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaKhachHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaThanhToan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRef;
        private System.Windows.Forms.Button btnDel;
    }
}