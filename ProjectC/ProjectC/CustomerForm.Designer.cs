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
            this.txtCusDate = new System.Windows.Forms.TextBox();
            this.txtCusAddress = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.clCusID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clCusName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clCusEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clCusPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clCusDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clCusAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCusCreate = new System.Windows.Forms.Button();
            this.btnCusUpdate = new System.Windows.Forms.Button();
            this.btnCusDelete = new System.Windows.Forms.Button();
            this.btnCusLoad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customber Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Customber Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Customer Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Customer Address";
            // 
            // txtCusID
            // 
            this.txtCusID.Location = new System.Drawing.Point(171, 23);
            this.txtCusID.Name = "txtCusID";
            this.txtCusID.Size = new System.Drawing.Size(276, 20);
            this.txtCusID.TabIndex = 6;
            // 
            // txtCusName
            // 
            this.txtCusName.Location = new System.Drawing.Point(171, 50);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Size = new System.Drawing.Size(276, 20);
            this.txtCusName.TabIndex = 7;
            // 
            // txtCusEmail
            // 
            this.txtCusEmail.Location = new System.Drawing.Point(171, 77);
            this.txtCusEmail.Name = "txtCusEmail";
            this.txtCusEmail.Size = new System.Drawing.Size(276, 20);
            this.txtCusEmail.TabIndex = 8;
            // 
            // txtCusPhone
            // 
            this.txtCusPhone.Location = new System.Drawing.Point(171, 108);
            this.txtCusPhone.Name = "txtCusPhone";
            this.txtCusPhone.Size = new System.Drawing.Size(276, 20);
            this.txtCusPhone.TabIndex = 9;
            // 
            // txtCusDate
            // 
            this.txtCusDate.Location = new System.Drawing.Point(171, 142);
            this.txtCusDate.Name = "txtCusDate";
            this.txtCusDate.Size = new System.Drawing.Size(276, 20);
            this.txtCusDate.TabIndex = 10;
            // 
            // txtCusAddress
            // 
            this.txtCusAddress.Location = new System.Drawing.Point(171, 169);
            this.txtCusAddress.Name = "txtCusAddress";
            this.txtCusAddress.Size = new System.Drawing.Size(276, 20);
            this.txtCusAddress.TabIndex = 11;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clCusID,
            this.clCusName,
            this.clCusEmail,
            this.clCusPhone,
            this.clCusDate,
            this.clCusAddress});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 201);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 237);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // clCusID
            // 
            this.clCusID.Text = "CUSTOMER ID";
            this.clCusID.Width = 83;
            // 
            // clCusName
            // 
            this.clCusName.Text = "CUSTOMER NAME";
            this.clCusName.Width = 117;
            // 
            // clCusEmail
            // 
            this.clCusEmail.Text = "CUSTOMER EMAIL";
            this.clCusEmail.Width = 123;
            // 
            // clCusPhone
            // 
            this.clCusPhone.Text = "CUSTOMER PHONE";
            this.clCusPhone.Width = 134;
            // 
            // clCusDate
            // 
            this.clCusDate.Text = "CUSTOMER DATE";
            this.clCusDate.Width = 122;
            // 
            // clCusAddress
            // 
            this.clCusAddress.Text = "CUSTOMER ADDRESS";
            this.clCusAddress.Width = 191;
            // 
            // btnCusCreate
            // 
            this.btnCusCreate.Location = new System.Drawing.Point(513, 19);
            this.btnCusCreate.Name = "btnCusCreate";
            this.btnCusCreate.Size = new System.Drawing.Size(87, 51);
            this.btnCusCreate.TabIndex = 13;
            this.btnCusCreate.Text = "Create";
            this.btnCusCreate.UseVisualStyleBackColor = true;
            // 
            // btnCusUpdate
            // 
            this.btnCusUpdate.Location = new System.Drawing.Point(632, 15);
            this.btnCusUpdate.Name = "btnCusUpdate";
            this.btnCusUpdate.Size = new System.Drawing.Size(87, 55);
            this.btnCusUpdate.TabIndex = 14;
            this.btnCusUpdate.Text = "Update";
            this.btnCusUpdate.UseVisualStyleBackColor = true;
            // 
            // btnCusDelete
            // 
            this.btnCusDelete.Location = new System.Drawing.Point(513, 106);
            this.btnCusDelete.Name = "btnCusDelete";
            this.btnCusDelete.Size = new System.Drawing.Size(87, 56);
            this.btnCusDelete.TabIndex = 15;
            this.btnCusDelete.Text = "Delete";
            this.btnCusDelete.UseVisualStyleBackColor = true;
            // 
            // btnCusLoad
            // 
            this.btnCusLoad.Location = new System.Drawing.Point(632, 105);
            this.btnCusLoad.Name = "btnCusLoad";
            this.btnCusLoad.Size = new System.Drawing.Size(87, 57);
            this.btnCusLoad.TabIndex = 16;
            this.btnCusLoad.Text = "Load";
            this.btnCusLoad.UseVisualStyleBackColor = true;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCusLoad);
            this.Controls.Add(this.btnCusDelete);
            this.Controls.Add(this.btnCusUpdate);
            this.Controls.Add(this.btnCusCreate);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txtCusAddress);
            this.Controls.Add(this.txtCusDate);
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
            this.Name = "CustomerForm";
            this.Text = "CUSTOMER";
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
        private System.Windows.Forms.TextBox txtCusDate;
        private System.Windows.Forms.TextBox txtCusAddress;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader clCusID;
        private System.Windows.Forms.ColumnHeader clCusName;
        private System.Windows.Forms.ColumnHeader clCusEmail;
        private System.Windows.Forms.ColumnHeader clCusPhone;
        private System.Windows.Forms.ColumnHeader clCusDate;
        private System.Windows.Forms.ColumnHeader clCusAddress;
        private System.Windows.Forms.Button btnCusCreate;
        private System.Windows.Forms.Button btnCusUpdate;
        private System.Windows.Forms.Button btnCusDelete;
        private System.Windows.Forms.Button btnCusLoad;
    }
}