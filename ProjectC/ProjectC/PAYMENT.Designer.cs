namespace ProjectC
{
    partial class PAYMENT
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
            this.txtPayID = new System.Windows.Forms.TextBox();
            this.txtPayName = new System.Windows.Forms.TextBox();
            this.txtPayDis = new System.Windows.Forms.TextBox();
            this.dgvPay = new System.Windows.Forms.DataGridView();
            this.btnPayCreate = new System.Windows.Forms.Button();
            this.btnPayUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPayDel = new System.Windows.Forms.Button();
            this.btnPayRef = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "PAYMENT ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "PAYMENT NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "DISCOUNT";
            // 
            // txtPayID
            // 
            this.txtPayID.Location = new System.Drawing.Point(217, 81);
            this.txtPayID.Margin = new System.Windows.Forms.Padding(4);
            this.txtPayID.Name = "txtPayID";
            this.txtPayID.Size = new System.Drawing.Size(375, 22);
            this.txtPayID.TabIndex = 4;
            // 
            // txtPayName
            // 
            this.txtPayName.Location = new System.Drawing.Point(217, 128);
            this.txtPayName.Margin = new System.Windows.Forms.Padding(4);
            this.txtPayName.Name = "txtPayName";
            this.txtPayName.Size = new System.Drawing.Size(375, 22);
            this.txtPayName.TabIndex = 5;
            // 
            // txtPayDis
            // 
            this.txtPayDis.Location = new System.Drawing.Point(217, 172);
            this.txtPayDis.Margin = new System.Windows.Forms.Padding(4);
            this.txtPayDis.Name = "txtPayDis";
            this.txtPayDis.Size = new System.Drawing.Size(375, 22);
            this.txtPayDis.TabIndex = 6;
            this.txtPayDis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPayDis_KeyPress);
            // 
            // dgvPay
            // 
            this.dgvPay.AllowUserToAddRows = false;
            this.dgvPay.AllowUserToDeleteRows = false;
            this.dgvPay.AllowUserToResizeColumns = false;
            this.dgvPay.AllowUserToResizeRows = false;
            this.dgvPay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPay.Location = new System.Drawing.Point(16, 254);
            this.dgvPay.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPay.Name = "dgvPay";
            this.dgvPay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPay.Size = new System.Drawing.Size(597, 359);
            this.dgvPay.TabIndex = 7;
            this.dgvPay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPay_CellClick);
            this.dgvPay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPay_CellContentClick);
            // 
            // btnPayCreate
            // 
            this.btnPayCreate.Location = new System.Drawing.Point(49, 214);
            this.btnPayCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnPayCreate.Name = "btnPayCreate";
            this.btnPayCreate.Size = new System.Drawing.Size(100, 28);
            this.btnPayCreate.TabIndex = 8;
            this.btnPayCreate.Text = "Create";
            this.btnPayCreate.UseVisualStyleBackColor = true;
            this.btnPayCreate.Click += new System.EventHandler(this.btnPayCreate_Click);
            // 
            // btnPayUpdate
            // 
            this.btnPayUpdate.Location = new System.Drawing.Point(157, 214);
            this.btnPayUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnPayUpdate.Name = "btnPayUpdate";
            this.btnPayUpdate.Size = new System.Drawing.Size(100, 28);
            this.btnPayUpdate.TabIndex = 9;
            this.btnPayUpdate.Text = "Update";
            this.btnPayUpdate.UseVisualStyleBackColor = true;
            this.btnPayUpdate.Click += new System.EventHandler(this.btnPayUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(485, 214);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label7.Location = new System.Drawing.Point(64, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(454, 39);
            this.label7.TabIndex = 31;
            this.label7.Text = "PAYMENT MANAGEMENT";
            // 
            // btnPayDel
            // 
            this.btnPayDel.Location = new System.Drawing.Point(265, 214);
            this.btnPayDel.Margin = new System.Windows.Forms.Padding(4);
            this.btnPayDel.Name = "btnPayDel";
            this.btnPayDel.Size = new System.Drawing.Size(100, 28);
            this.btnPayDel.TabIndex = 32;
            this.btnPayDel.Text = "Delete";
            this.btnPayDel.UseVisualStyleBackColor = true;
            this.btnPayDel.Click += new System.EventHandler(this.btnPayDel_Click);
            // 
            // btnPayRef
            // 
            this.btnPayRef.Location = new System.Drawing.Point(377, 214);
            this.btnPayRef.Margin = new System.Windows.Forms.Padding(4);
            this.btnPayRef.Name = "btnPayRef";
            this.btnPayRef.Size = new System.Drawing.Size(100, 28);
            this.btnPayRef.TabIndex = 33;
            this.btnPayRef.Text = "Refesh";
            this.btnPayRef.UseVisualStyleBackColor = true;
            this.btnPayRef.Click += new System.EventHandler(this.btnPayRef_Click);
            // 
            // PAYMENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 628);
            this.Controls.Add(this.btnPayRef);
            this.Controls.Add(this.btnPayDel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPayUpdate);
            this.Controls.Add(this.btnPayCreate);
            this.Controls.Add(this.dgvPay);
            this.Controls.Add(this.txtPayDis);
            this.Controls.Add(this.txtPayName);
            this.Controls.Add(this.txtPayID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PAYMENT";
            this.Text = "PAYMENT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PAYMENT_FormClosing);
            this.Load += new System.EventHandler(this.PAYMENT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPayID;
        private System.Windows.Forms.TextBox txtPayName;
        private System.Windows.Forms.TextBox txtPayDis;
        private System.Windows.Forms.DataGridView dgvPay;
        private System.Windows.Forms.Button btnPayCreate;
        private System.Windows.Forms.Button btnPayUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPayDel;
        private System.Windows.Forms.Button btnPayRef;
    }
}