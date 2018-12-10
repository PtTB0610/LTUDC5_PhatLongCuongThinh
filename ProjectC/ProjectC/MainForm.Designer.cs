﻿namespace ProjectC
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAccountInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewSupplier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewBill = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewStatistic = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddBill = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddStatistic = new System.Windows.Forms.ToolStripMenuItem();
            this.managementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddCate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddSupplier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUser = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMenu,
            this.viewToolStripMenuItem,
            this.addToolStripMenuItem,
            this.managementToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuMenu
            // 
            this.mnuMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAccountInfo,
            this.mnuLogout,
            this.mnuExit});
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Size = new System.Drawing.Size(50, 20);
            this.mnuMenu.Text = "Menu";
            // 
            // mnuAccountInfo
            // 
            this.mnuAccountInfo.Name = "mnuAccountInfo";
            this.mnuAccountInfo.Size = new System.Drawing.Size(180, 22);
            this.mnuAccountInfo.Text = "Account Info";
            this.mnuAccountInfo.Click += new System.EventHandler(this.mnuAccountInfo_Click);
            // 
            // mnuLogout
            // 
            this.mnuLogout.Name = "mnuLogout";
            this.mnuLogout.Size = new System.Drawing.Size(180, 22);
            this.mnuLogout.Text = "Logout";
            this.mnuLogout.Click += new System.EventHandler(this.mnuLogout_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(180, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuViewProduct,
            this.mnuViewSupplier,
            this.mnuViewEmployee,
            this.mnuViewCustomer,
            this.mnuViewBill,
            this.mnuViewStatistic});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // mnuViewProduct
            // 
            this.mnuViewProduct.Name = "mnuViewProduct";
            this.mnuViewProduct.Size = new System.Drawing.Size(126, 22);
            this.mnuViewProduct.Text = "Product";
            this.mnuViewProduct.Click += new System.EventHandler(this.mnuViewProduct_Click);
            // 
            // mnuViewSupplier
            // 
            this.mnuViewSupplier.Name = "mnuViewSupplier";
            this.mnuViewSupplier.Size = new System.Drawing.Size(126, 22);
            this.mnuViewSupplier.Text = "Supplier";
            // 
            // mnuViewEmployee
            // 
            this.mnuViewEmployee.Name = "mnuViewEmployee";
            this.mnuViewEmployee.Size = new System.Drawing.Size(126, 22);
            this.mnuViewEmployee.Text = "Employee";
            this.mnuViewEmployee.Click += new System.EventHandler(this.mnuViewEmployee_Click);
            // 
            // mnuViewCustomer
            // 
            this.mnuViewCustomer.Name = "mnuViewCustomer";
            this.mnuViewCustomer.Size = new System.Drawing.Size(126, 22);
            this.mnuViewCustomer.Text = "Customer";
            // 
            // mnuViewBill
            // 
            this.mnuViewBill.Name = "mnuViewBill";
            this.mnuViewBill.Size = new System.Drawing.Size(126, 22);
            this.mnuViewBill.Text = "Bill";
            // 
            // mnuViewStatistic
            // 
            this.mnuViewStatistic.Name = "mnuViewStatistic";
            this.mnuViewStatistic.Size = new System.Drawing.Size(126, 22);
            this.mnuViewStatistic.Text = "Statistic";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddEmployee,
            this.mnuAddCustomer,
            this.mnuAddBill,
            this.mnuAddStatistic});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // mnuAddEmployee
            // 
            this.mnuAddEmployee.Name = "mnuAddEmployee";
            this.mnuAddEmployee.Size = new System.Drawing.Size(126, 22);
            this.mnuAddEmployee.Text = "Employee";
            // 
            // mnuAddCustomer
            // 
            this.mnuAddCustomer.Name = "mnuAddCustomer";
            this.mnuAddCustomer.Size = new System.Drawing.Size(126, 22);
            this.mnuAddCustomer.Text = "Customer";
            // 
            // mnuAddBill
            // 
            this.mnuAddBill.Name = "mnuAddBill";
            this.mnuAddBill.Size = new System.Drawing.Size(126, 22);
            this.mnuAddBill.Text = "Bill";
            // 
            // mnuAddStatistic
            // 
            this.mnuAddStatistic.Name = "mnuAddStatistic";
            this.mnuAddStatistic.Size = new System.Drawing.Size(126, 22);
            this.mnuAddStatistic.Text = "Statistic";
            // 
            // managementToolStripMenuItem
            // 
            this.managementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddCate,
            this.mnuAddSupplier,
            this.mnuUser});
            this.managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            this.managementToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.managementToolStripMenuItem.Text = "Management";
            // 
            // mnuAddCate
            // 
            this.mnuAddCate.Name = "mnuAddCate";
            this.mnuAddCate.Size = new System.Drawing.Size(122, 22);
            this.mnuAddCate.Text = "Category";
            this.mnuAddCate.Click += new System.EventHandler(this.mnuAddCate_Click);
            // 
            // mnuAddSupplier
            // 
            this.mnuAddSupplier.Name = "mnuAddSupplier";
            this.mnuAddSupplier.Size = new System.Drawing.Size(122, 22);
            this.mnuAddSupplier.Text = "Supplier";
            this.mnuAddSupplier.Click += new System.EventHandler(this.mnuAddSupplier_Click);
            // 
            // mnuUser
            // 
            this.mnuUser.Name = "mnuUser";
            this.mnuUser.Size = new System.Drawing.Size(122, 22);
            this.mnuUser.Text = "User";
            this.mnuUser.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 623);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuAccountInfo;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuViewProduct;
        private System.Windows.Forms.ToolStripMenuItem mnuViewSupplier;
        private System.Windows.Forms.ToolStripMenuItem mnuViewEmployee;
        private System.Windows.Forms.ToolStripMenuItem mnuViewCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnuViewBill;
        private System.Windows.Forms.ToolStripMenuItem mnuViewStatistic;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAddEmployee;
        private System.Windows.Forms.ToolStripMenuItem mnuAddCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnuAddBill;
        private System.Windows.Forms.ToolStripMenuItem mnuAddStatistic;
        private System.Windows.Forms.ToolStripMenuItem mnuLogout;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem managementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAddCate;
        private System.Windows.Forms.ToolStripMenuItem mnuAddSupplier;
        private System.Windows.Forms.ToolStripMenuItem mnuUser;
    }
}