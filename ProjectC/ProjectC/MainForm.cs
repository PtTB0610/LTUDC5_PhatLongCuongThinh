﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjectC
{
    public partial class MainForm : Form
    {
        public MainForm(/*string userType*/)
        {
            InitializeComponent();
            lbUserType.Text = clsFormProvider.loginF.getUserType();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                foreach (Form form in this.MdiChildren)
                {
                    form.Close();
                }
                Environment.Exit(0);
                //Application.Exit();
            }
            else e.Cancel = true;
        }
        
        private void mnuProduct_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.MdiParent = this;
            productForm.TopLevel = false;
            productForm.Dock = DockStyle.Fill;
            productForm.Show();
            disableControls();
        }
        public void disableControls() {
            mnuProduct.Enabled = false;
        }
        public void enableControls() {
            mnuProduct.Enabled = true;
        }

        private void mneLogout_Click(object sender, EventArgs e) {
            this.Hide();
            clsFormProvider.loginF.ShowDialog();
            lbUserType.Text = "";
            lbUserType.Text = clsFormProvider.loginF.getUserType();
        }
    }
}
