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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PAYMENT_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAYMENT_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DISCOUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnaddNew = new System.Windows.Forms.Button();
            this.btnPayUp = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PAYMENT ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "PAYMENT NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "DISCOUNT";
            // 
            // txtPayID
            // 
            this.txtPayID.Location = new System.Drawing.Point(163, 66);
            this.txtPayID.Name = "txtPayID";
            this.txtPayID.Size = new System.Drawing.Size(282, 20);
            this.txtPayID.TabIndex = 4;
            // 
            // txtPayName
            // 
            this.txtPayName.Location = new System.Drawing.Point(163, 104);
            this.txtPayName.Name = "txtPayName";
            this.txtPayName.Size = new System.Drawing.Size(282, 20);
            this.txtPayName.TabIndex = 5;
            // 
            // txtPayDis
            // 
            this.txtPayDis.Location = new System.Drawing.Point(163, 140);
            this.txtPayDis.Name = "txtPayDis";
            this.txtPayDis.Size = new System.Drawing.Size(282, 20);
            this.txtPayDis.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PAYMENT_ID,
            this.PAYMENT_NAME,
            this.DISCOUNT});
            this.dataGridView1.Location = new System.Drawing.Point(12, 206);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(448, 292);
            this.dataGridView1.TabIndex = 7;
            // 
            // PAYMENT_ID
            // 
            this.PAYMENT_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PAYMENT_ID.HeaderText = "PAYMENT_ID";
            this.PAYMENT_ID.Name = "PAYMENT_ID";
            // 
            // PAYMENT_NAME
            // 
            this.PAYMENT_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PAYMENT_NAME.HeaderText = "PAYMENT_NAME";
            this.PAYMENT_NAME.Name = "PAYMENT_NAME";
            // 
            // DISCOUNT
            // 
            this.DISCOUNT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DISCOUNT.HeaderText = "DISCOUNT";
            this.DISCOUNT.Name = "DISCOUNT";
            // 
            // btnaddNew
            // 
            this.btnaddNew.Location = new System.Drawing.Point(37, 174);
            this.btnaddNew.Name = "btnaddNew";
            this.btnaddNew.Size = new System.Drawing.Size(75, 23);
            this.btnaddNew.TabIndex = 8;
            this.btnaddNew.Text = "add New";
            this.btnaddNew.UseVisualStyleBackColor = true;
            // 
            // btnPayUp
            // 
            this.btnPayUp.Location = new System.Drawing.Point(199, 174);
            this.btnPayUp.Name = "btnPayUp";
            this.btnPayUp.Size = new System.Drawing.Size(75, 23);
            this.btnPayUp.TabIndex = 9;
            this.btnPayUp.Text = "Update";
            this.btnPayUp.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(364, 174);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label7.Location = new System.Drawing.Point(48, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(364, 31);
            this.label7.TabIndex = 31;
            this.label7.Text = "PAYMENT MANAGEMENT";
            // 
            // PAYMENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 510);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPayUp);
            this.Controls.Add(this.btnaddNew);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtPayDis);
            this.Controls.Add(this.txtPayName);
            this.Controls.Add(this.txtPayID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PAYMENT";
            this.Text = "PAYMENT";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAYMENT_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAYMENT_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn DISCOUNT;
        private System.Windows.Forms.Button btnaddNew;
        private System.Windows.Forms.Button btnPayUp;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label7;
    }
}