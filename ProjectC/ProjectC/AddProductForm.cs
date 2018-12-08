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

namespace ProjectC
{
    public partial class AddProductForm : Form
    {    
        public AddProductForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ElectronicSupermarket;Integrated Security=True");
        clsDatabase db = new clsDatabase();
        private void AddForm_Load(object sender, EventArgs e)
        {
            cboCategory.DataSource = db.getTableData("CATEGORY");
            cboCategory.DisplayMember = "CATEGORY_NAME";
            cboCategory.ValueMember = "CATEGORY_ID";

            cboSupplier.DataSource = db.getTableData("SUPPLIER");
            cboSupplier.DisplayMember = "SUPPLIER_NAME";
            cboSupplier.ValueMember = "SUPPLIER_ID";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtProductID_Leave(object sender, EventArgs e)
        {
            if (txtProductID.Text != "") {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_searchProductbyID", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@P_ID", txtProductID.Text));
                if ((string)cmd.ExecuteScalar() == txtProductID.Text)
                {
                    MessageBox.Show("This ID is already used!!! Please try different ID!!!");
                    txtProductID.Clear();
                    txtProductID.Focus();
                }
                con.Close();
            }
        }

        private void txtProductName_Leave(object sender, EventArgs e)
        {
            if (txtProductName.Text != "")
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_searchProductbyName", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@P_NAME", txtProductName.Text));
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        if (txtProductName.Text == reader["PRODUCT_NAME"].ToString())
                        {
                            MessageBox.Show("This product name is already used!!! Please try different product name!!!");
                            txtProductName.Clear();
                            txtProductName.Focus();
                            break;
                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally {
                    con.Close();
                }              
            }
        }

        private void txtProductPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.' || e.KeyChar == '\b'))
            {
                e.Handled = true;
            }
            TextBox txtDecimal = sender as TextBox;
            if (e.KeyChar == '.' && txtDecimal.Text.Contains("."))
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
            cmd.Parameters.Add(new SqlParameter("@INSTOCK", txtInStock.Text));
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
                picUploadImg.Image = Image.FromFile(@"" + filePath);
            }
        }

        private void AddProductForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
