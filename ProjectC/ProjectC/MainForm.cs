using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectC
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        string userType = clsFormProvider.loginF.getUserType();
        string userID = clsFormProvider.loginF.getUserID();

        public string  getUserType() {
            return userType;
        }

        public string getUserID()
        {
            return userID;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        public void disableViewProductControls()
        {
            mnuViewProduct.Enabled = false;
        }
        public void enableViewProductControls()
        {
            mnuViewProduct.Enabled = true;
        }

        private void mneLogout_Click(object sender, EventArgs e) {
            Application.Restart();
            //this.Hide();
            //clsFormProvider.loginF.ShowDialog();
            //lbUserType.Text = "";
            //lbUserType.Text = clsFormProvider.loginF.getUserType();
        }

        private void mnuAccountInfo_Click(object sender, EventArgs e)
        {
            UserInfoForm UIForm = new UserInfoForm();
            UIForm.MdiParent = this;
            UIForm.Show();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuViewProduct_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.MdiParent = this;
            productForm.TopLevel = false;
            productForm.Dock = DockStyle.Fill;
            productForm.Show();
            disableViewProductControls();
        }
    }
}
