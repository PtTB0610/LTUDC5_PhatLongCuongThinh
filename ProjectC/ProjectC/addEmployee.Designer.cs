namespace ProjectC
{
    partial class addEmployee
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
            this.btnEmpCreate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dtBirth = new System.Windows.Forms.DateTimePicker();
            this.txtEmpAdd = new System.Windows.Forms.TextBox();
            this.txtEmpPhone = new System.Windows.Forms.TextBox();
            this.txtEmpEmail = new System.Windows.Forms.TextBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEmpCreate
            // 
            this.btnEmpCreate.Location = new System.Drawing.Point(241, 535);
            this.btnEmpCreate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEmpCreate.Name = "btnEmpCreate";
            this.btnEmpCreate.Size = new System.Drawing.Size(133, 55);
            this.btnEmpCreate.TabIndex = 49;
            this.btnEmpCreate.Text = "Create";
            this.btnEmpCreate.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label7.Location = new System.Drawing.Point(119, 27);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(377, 39);
            this.label7.TabIndex = 64;
            this.label7.Text = "Employee Create New";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 360);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 55);
            this.button1.TabIndex = 63;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtBirth
            // 
            this.dtBirth.Location = new System.Drawing.Point(208, 243);
            this.dtBirth.Margin = new System.Windows.Forms.Padding(4);
            this.dtBirth.MaxDate = new System.DateTime(2018, 12, 10, 0, 0, 0, 0);
            this.dtBirth.Name = "dtBirth";
            this.dtBirth.Size = new System.Drawing.Size(409, 22);
            this.dtBirth.TabIndex = 62;
            this.dtBirth.Value = new System.DateTime(2000, 11, 22, 16, 38, 0, 0);
            // 
            // txtEmpAdd
            // 
            this.txtEmpAdd.Location = new System.Drawing.Point(208, 288);
            this.txtEmpAdd.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmpAdd.Name = "txtEmpAdd";
            this.txtEmpAdd.Size = new System.Drawing.Size(409, 22);
            this.txtEmpAdd.TabIndex = 61;
            // 
            // txtEmpPhone
            // 
            this.txtEmpPhone.Location = new System.Drawing.Point(208, 206);
            this.txtEmpPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmpPhone.Name = "txtEmpPhone";
            this.txtEmpPhone.Size = new System.Drawing.Size(409, 22);
            this.txtEmpPhone.TabIndex = 60;
            this.txtEmpPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmpPhone_KeyPress);
            // 
            // txtEmpEmail
            // 
            this.txtEmpEmail.Location = new System.Drawing.Point(208, 164);
            this.txtEmpEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmpEmail.Name = "txtEmpEmail";
            this.txtEmpEmail.Size = new System.Drawing.Size(409, 22);
            this.txtEmpEmail.TabIndex = 59;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(208, 123);
            this.txtEmpName.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(409, 22);
            this.txtEmpName.TabIndex = 58;
            this.txtEmpName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmpName_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 288);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 17);
            this.label6.TabIndex = 57;
            this.label6.Text = "Employee Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 243);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 56;
            this.label5.Text = "Date of Birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 203);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 55;
            this.label4.Text = "Employee Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 54;
            this.label3.Text = "Employee Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 53;
            this.label2.Text = "Employee Name";
            // 
            // txtEmpID
            // 
            this.txtEmpID.Location = new System.Drawing.Point(208, 84);
            this.txtEmpID.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(409, 22);
            this.txtEmpID.TabIndex = 52;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(47, 84);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 17);
            this.label12.TabIndex = 51;
            this.label12.Text = "Employee ID";
            // 
            // addEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 607);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtBirth);
            this.Controls.Add(this.txtEmpAdd);
            this.Controls.Add(this.txtEmpPhone);
            this.Controls.Add(this.txtEmpEmail);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnEmpCreate);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "addEmployee";
            this.Text = "addEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEmpCreate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtBirth;
        private System.Windows.Forms.TextBox txtEmpAdd;
        private System.Windows.Forms.TextBox txtEmpPhone;
        private System.Windows.Forms.TextBox txtEmpEmail;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.Label label12;
    }
}