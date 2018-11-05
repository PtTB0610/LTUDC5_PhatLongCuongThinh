namespace ProjectC
{
    partial class ProductForm
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
            this.lvProductData = new System.Windows.Forms.ListView();
            this.clProductID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clProductPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clSupplier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnLoad = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lvProductData
            // 
            this.lvProductData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvProductData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clProductID,
            this.clProductName,
            this.clProductPrice,
            this.clCategory,
            this.clSupplier,
            this.clDesc});
            this.lvProductData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvProductData.GridLines = true;
            this.lvProductData.Location = new System.Drawing.Point(0, 266);
            this.lvProductData.Name = "lvProductData";
            this.lvProductData.Size = new System.Drawing.Size(1000, 353);
            this.lvProductData.TabIndex = 0;
            this.lvProductData.UseCompatibleStateImageBehavior = false;
            this.lvProductData.View = System.Windows.Forms.View.Details;
            this.lvProductData.SelectedIndexChanged += new System.EventHandler(this.lvProductData_SelectedIndexChanged);
            // 
            // clProductID
            // 
            this.clProductID.Text = "Product ID";
            this.clProductID.Width = 111;
            // 
            // clProductName
            // 
            this.clProductName.Text = "Product Name";
            this.clProductName.Width = 167;
            // 
            // clProductPrice
            // 
            this.clProductPrice.Text = "Product Price";
            this.clProductPrice.Width = 128;
            // 
            // clCategory
            // 
            this.clCategory.Text = "Category";
            this.clCategory.Width = 104;
            // 
            // clSupplier
            // 
            this.clSupplier.Text = "Supplier";
            this.clSupplier.Width = 145;
            // 
            // clDesc
            // 
            this.clDesc.Text = "Description";
            this.clDesc.Width = 291;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 214);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(108, 34);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(838, 29);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(150, 150);
            this.pbImage.TabIndex = 2;
            this.pbImage.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(146, 214);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 34);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(277, 214);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 34);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 619);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lvProductData);
            this.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductForm_FormClosing);
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvProductData;
        private System.Windows.Forms.ColumnHeader clProductID;
        private System.Windows.Forms.ColumnHeader clProductPrice;
        private System.Windows.Forms.ColumnHeader clCategory;
        private System.Windows.Forms.ColumnHeader clSupplier;
        private System.Windows.Forms.ColumnHeader clDesc;
        private System.Windows.Forms.ColumnHeader clProductName;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}