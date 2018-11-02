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
            this.clProductPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clSupplier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnLoad = new System.Windows.Forms.Button();
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
            this.lvProductData.GridLines = true;
            this.lvProductData.Location = new System.Drawing.Point(12, 254);
            this.lvProductData.Name = "lvProductData";
            this.lvProductData.Size = new System.Drawing.Size(976, 353);
            this.lvProductData.TabIndex = 0;
            this.lvProductData.UseCompatibleStateImageBehavior = false;
            this.lvProductData.View = System.Windows.Forms.View.Details;
            // 
            // clProductID
            // 
            this.clProductID.Text = "Product ID";
            this.clProductID.Width = 111;
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
            // clProductName
            // 
            this.clProductName.Text = "Product Name";
            this.clProductName.Width = 167;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(337, 58);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(108, 34);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 619);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lvProductData);
            this.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductForm_FormClosing);
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
    }
}