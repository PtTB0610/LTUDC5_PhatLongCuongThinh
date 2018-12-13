/*
Name: Bui Tien Phat
*/
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
        string userName;
        string userPass;
        public string getUserType()
        {
            return userType;
        }

        public void setUserType(string userType)
        {
            this.userType = userType;
        }

        public string getUserName()
        {
            return this.userName;
        }

        public string getUserPass()
        {
            return this.userPass;
        }

        public void setUserPass(string userPass)
        {
            this.userPass = userPass;
        }

        public void setUserName(string userName)
        {
            this.userName = userName;
        }
        //Thông báo hỏi trước khi thoát
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        //CHức năng thoát
        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Chỉ cho phép tạo 1 form Product
        ProductForm productForm;
        private void mnuViewProduct_Click(object sender, EventArgs e)
        {
            if (productForm != null)
            {
                productForm.Show();
            }
            else
            {
                productForm = new ProductForm();
                productForm.MdiParent = this;
                productForm.Dock = DockStyle.Fill;
                productForm.Show();
                productForm.FormClosing += productForm_FormClosing;
            }
        }
        public void productForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            productForm = null;
        }

        private void mnuViewEmployee_Click(object sender, EventArgs e)
        {
            EmployeeFORM employeeform = new EmployeeFORM();
            employeeform.MdiParent = this;
            employeeform.TopLevel = false;
            employeeform.Dock = DockStyle.Fill;
            employeeform.Show();

        }
        //Chỉ cho phép tạo 1 Form UserInfoForm
        UserInfoForm userInfoForm;
        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (userInfoForm != null)
            {
                userInfoForm.Show();
            }
            else
            {
                userInfoForm = new UserInfoForm();
                userInfoForm.MdiParent = clsFormProvider.mainF;
                userInfoForm.Show();
                userInfoForm.FormClosing += userInfoForm_FormClosing;
            }
        }
        public void userInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            userInfoForm = null;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (getUserType() == "User") {
                managementToolStripMenuItem.Visible = false;
            }
        }

        //Chỉ cho phép tạo 1 Form AddCategory
        AddCategory addCate;
        private void mnuAddCate_Click(object sender, EventArgs e)
        {
            if (addCate != null)
            {
                addCate.Show();
            }
            else
            {
                addCate = new AddCategory();
                addCate.MdiParent = clsFormProvider.mainF;
                addCate.Show();
                addCate.FormClosing += addCate_FormClosing;
            }
        }
        public void addCate_FormClosing(object sender, FormClosingEventArgs e)
        {
            addCate = null;
        }

        //Chỉ cho phép tạo 1 Supplier Form
        SupplierForm supForm;
        private void mnuAddSupplier_Click(object sender, EventArgs e)
        {
            if (supForm != null)
            {
                supForm.Show();
            }
            else
            {
                supForm = new SupplierForm();
                supForm.MdiParent = clsFormProvider.mainF;
                supForm.Show();
                supForm.FormClosing += supForm_FormClosing;
            }
        }
        public void supForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            supForm = null;
        }

        private void mnuLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        //Chỉ cho phép tạo 1 User Form
        UserForm userForm;
        private void mnuAccountInfo_Click(object sender, EventArgs e)
        {
            if (userForm != null)
            {
                userForm.Show();
            }
            else
            {
                userForm = new UserForm();
                userForm.MdiParent = clsFormProvider.mainF;
                userForm.Show();
                userForm.FormClosing += userForm_FormClosing;
            }
        }
        public void userForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            supForm = null;
        }

        //Xem trang chiếu Payment
        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PAYMENT payform = new PAYMENT();
            payform.MdiParent = this;
            payform.TopLevel = false;
            payform.Dock = DockStyle.Fill;
            payform.Show();
        }

        //Xem trang chiếu Customer
        private void mnuViewCustomer_Click(object sender, EventArgs e)
        {
            CustomerForm cusform = new CustomerForm();
            cusform.MdiParent = this;
            cusform.TopLevel = false;
            cusform.Dock = DockStyle.Fill;
            cusform.Show();
        }

        //Xem trang chiếu Statistic
        StatisticForm statisForm;
        private void mnuViewStatistic_Click(object sender, EventArgs e)
        {
            if(statisForm != null)
            {
                statisForm.Show();
            }
            else
            {
                statisForm = new StatisticForm();
                statisForm.MdiParent = this;
                statisForm.TopLevel = false;
                statisForm.Dock = DockStyle.Fill;
                statisForm.Show();
            } 
        }

        //Xem trang chiếu Bill
        BillForm billForm;
        private void mnuViewBill_Click(object sender, EventArgs e)
        {
            if(billForm != null)
            {
                billForm.Show();
            }
            else
            {
                billForm = new BillForm();
                billForm.MdiParent = this;
                billForm.TopLevel = false;
                billForm.Dock = DockStyle.Fill;
                billForm.Show();
            }
        }
    }
}
