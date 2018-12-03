using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Collections;
namespace ProjectC
{
    public partial class AddProductForm : Form
    {

        
        public AddProductForm()
        {
            InitializeComponent();
        }

        ArrayList arrID = new ArrayList();
        ArrayList arrName = new ArrayList();
        clsDatabase db = new clsDatabase();
        private void AddForm_Load(object sender, EventArgs e)
        {
            cboCategory.DataSource = db.getTableData("CATEGORY");
            cboCategory.DisplayMember = "CATEGORY_NAME";
            cboCategory.ValueMember = "CATEGORY_ID";

            cboSupplier.DataSource = db.getTableData("SUPPLIER");
            cboSupplier.DisplayMember = "SUPPLIER_NAME";
            cboSupplier.ValueMember = "SUPPLIER_ID";

            DataTable dt = db.getTableData("PRODUCT");
            for (int i = 0; i < dt.Rows.Count; i++) {
                DataRow dr = dt.Rows[i];
                arrID.Add(dr["PRODUCT_ID"].ToString());
                arrName.Add(dr["PRODUCT_NAME"].ToString());
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtProductID_Leave(object sender, EventArgs e)
        {
            foreach (string s in arrID) {
                if (txtProductID.Text == s) {
                    MessageBox.Show("This ID is already used! Please input a different ID");
                    txtProductID.Clear();
                    txtProductID.Focus();
                    break;
                }
            }
        }

        private void txtProductName_Leave(object sender, EventArgs e)
        {
            foreach (string s in arrID)
            {
                if (txtProductID.Text == s)
                {
                    MessageBox.Show("This name is already used! Please input a different Name");
                    txtProductID.Clear();
                    txtProductID.Focus();
                    break;
                }
            }
        }

        private void txtProductPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtInStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ElectronicSupermarket;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SP_THEMDSPRODUCT", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@P_ID", txtProductID.Text));
            cmd.Parameters.Add(new SqlParameter("@P_NAME", txtProductName.Text));
            cmd.Parameters.Add(new SqlParameter("@P_PRICE", txtProductPrice.Text));
            cmd.Parameters.Add(new SqlParameter("@C_ID", cboCategory.SelectedValue));
            cmd.Parameters.Add(new SqlParameter("@P_IMAGE", filePath));
            cmd.Parameters.Add(new SqlParameter("@P_DESC", rtfAddDesc.Text));
            cmd.Parameters.Add(new SqlParameter("@S_ID", cboSupplier.SelectedValue));
            cmd.Parameters.Add(new SqlParameter("@P_STATUS", cboProductStatus.Text));
            SqlCommand cmd2 = new SqlCommand("SP_THEMDSWAREHOUSE", con);
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Parameters.Add(new SqlParameter("@P_ID", txtProductID.Text));
            cmd2.Parameters.Add(new SqlParameter("@SLUONG", txtInStock.Text));
            cmd2.ExecuteNonQuery();
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Add product successful");
            }
            else
            {
                MessageBox.Show("Product not added");
            }
            con.Close();
        }
        string filePath = "";
        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) {
                filePath = openFileDialog1.FileName;
            }
        }
    }
}
