namespace ProjectC
{
    partial class addPayment
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
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPayID = new System.Windows.Forms.TextBox();
            this.txtPayName = new System.Windows.Forms.TextBox();
            this.txtPayDis = new System.Windows.Forms.TextBox();
            this.btnPayCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label7.Location = new System.Drawing.Point(160, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(317, 39);
            this.label7.TabIndex = 43;
            this.label7.Text = "Create PAYMENT ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 44;
            this.label1.Text = "PAYMENT ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 45;
            this.label2.Text = "PAYMENT NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 46;
            this.label3.Text = "DISCOUNT";
            // 
            // txtPayID
            // 
            this.txtPayID.Location = new System.Drawing.Point(167, 81);
            this.txtPayID.Margin = new System.Windows.Forms.Padding(4);
            this.txtPayID.Name = "txtPayID";
            this.txtPayID.Size = new System.Drawing.Size(375, 22);
            this.txtPayID.TabIndex = 47;
            this.txtPayID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPayID_KeyPress);
            // 
            // txtPayName
            // 
            this.txtPayName.Location = new System.Drawing.Point(167, 124);
            this.txtPayName.Margin = new System.Windows.Forms.Padding(4);
            this.txtPayName.Name = "txtPayName";
            this.txtPayName.Size = new System.Drawing.Size(375, 22);
            this.txtPayName.TabIndex = 48;
            // 
            // txtPayDis
            // 
            this.txtPayDis.Location = new System.Drawing.Point(167, 168);
            this.txtPayDis.Margin = new System.Windows.Forms.Padding(4);
            this.txtPayDis.Name = "txtPayDis";
            this.txtPayDis.Size = new System.Drawing.Size(375, 22);
            this.txtPayDis.TabIndex = 49;
            // 
            // btnPayCreate
            // 
            this.btnPayCreate.Location = new System.Drawing.Point(278, 215);
            this.btnPayCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnPayCreate.Name = "btnPayCreate";
            this.btnPayCreate.Size = new System.Drawing.Size(100, 28);
            this.btnPayCreate.TabIndex = 50;
            this.btnPayCreate.Text = "Create";
            this.btnPayCreate.UseVisualStyleBackColor = true;
            this.btnPayCreate.Click += new System.EventHandler(this.btnPayCreate_Click);
            // 
            // addPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 295);
            this.Controls.Add(this.btnPayCreate);
            this.Controls.Add(this.txtPayDis);
            this.Controls.Add(this.txtPayName);
            this.Controls.Add(this.txtPayID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Name = "addPayment";
            this.Text = "addPayment";
            this.Load += new System.EventHandler(this.addPayment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPayID;
        private System.Windows.Forms.TextBox txtPayName;
        private System.Windows.Forms.TextBox txtPayDis;
        private System.Windows.Forms.Button btnPayCreate;
    }
}