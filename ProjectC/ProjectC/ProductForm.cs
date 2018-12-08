using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace ProjectC
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ElectronicSupermarket;Integrated Security=True");
        private void ProductForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        clsDatabase db = new clsDatabase();
        private void ProductForm_Load(object sender, EventArgs e)
        {
            if (((MainForm)this.MdiParent).getUserType() != "Admin") {
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                cboProductStatus.Visible = false;
                label9.Visible = false;
                btnUpload.Enabled = false;
                txtProductName.Enabled = false;
                txtProductPrice.Enabled = false;
                txtProductPrice.Enabled = false;
                cboCategory.Enabled = false;
                cboSupplier.Enabled = false;
                txtInStock.Enabled = false;
            }
            cboCategory.DataSource = db.getTableData("CATEGORY");
            cboCategory.DisplayMember = "CATEGORY_NAME";
            cboCategory.ValueMember = "CATEGORY_ID";

            cboSupplier.DataSource = db.getTableData("SUPPLIER");
            cboSupplier.DisplayMember = "SUPPLIER_NAME";
            cboSupplier.ValueMember = "SUPPLIER_ID";


            if (clsFormProvider.mainF.getUserType() == "Admin")
            {
                dgvProduct.DataSource = getProductDataForAdmin();
                dgvProduct.Columns[2].Visible = false;
                dgvProduct.Columns[3].Visible = false;
                dgvProduct.Columns[5].Visible = false;
                dgvProduct.Columns[6].Visible = false;
                dgvProduct.Columns[8].Visible = false;
            }
            else {
                dgvProduct.DataSource = getProductData();
                dgvProduct.Columns[2].Visible = false;
                dgvProduct.Columns[3].Visible = false;
                dgvProduct.Columns[5].Visible = false;
                dgvProduct.Columns[6].Visible = false;
                dgvProduct.Columns[8].Visible = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        AddProductForm addPro;
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            this.Close();
            //AddProductForm addPro = new AddProductForm();
            //addPro.Show();
            //addPro.MdiParent = clsFormProvider.mainF;
            if (addPro != null)
            {
                addPro.Show();
            }
            else
            {
                addPro = new AddProductForm();
                addPro.MdiParent = clsFormProvider.mainF;
                addPro.Show();
                addPro.FormClosing += addPro_FormClosing;
            }
        }

        public void addPro_FormClosing(object sender, FormClosingEventArgs e)
        {
            addPro = null;
        }

        public DataTable getProductDataForAdmin() {
            SqlCommand cmd = new SqlCommand("SP_LAYTATCAPRODUCT", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataTable getProductData()
        {
            SqlCommand cmd = new SqlCommand("SP_LAYDSPRODUCT", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        string filePath = "";
        private void btnUpload_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) {
                filePath = openFileDialog1.FileName;
                pbImage.Image = Image.FromFile(@"" + filePath);
            }
        }

        private void dgvProduct_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {           
            if (!dgvProduct.Rows[dgvProduct.CurrentCell.RowIndex].IsNewRow)
            {
                pbImage.Image = null;
                if (dgvProduct.SelectedRows.Count > 0)
                {
                    txtProductID.Text = dgvProduct.SelectedCells[0].Value.ToString();
                    txtProductName.Text = dgvProduct.SelectedCells[1].Value.ToString();
                    txtProductPrice.Text = dgvProduct.SelectedCells[4].Value.ToString();
                    cboCategory.SelectedValue = dgvProduct.SelectedCells[2].Value.ToString();
                    cboSupplier.SelectedValue = dgvProduct.SelectedCells[5].Value.ToString();
                    txtInStock.Text = dgvProduct.SelectedCells[6].Value.ToString();
                    rtfDesc.Text = dgvProduct.SelectedCells[7].Value.ToString();
                    cboProductStatus.Text = dgvProduct.SelectedCells[8].Value.ToString();
                    if (dgvProduct.SelectedCells[3].Value.ToString() != "")
                    {
                        pbImage.Image = Image.FromFile(@"" + dgvProduct.SelectedCells[3].Value.ToString() + "");
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            pbImage.Image = null;
            bool flag = false;
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_searchProductbyID",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@P_ID",txtIDtoSearch.Text));
            if((string)cmd.ExecuteScalar() == txtIDtoSearch.Text)
            {
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                txtProductID.Text = dt.Rows[0]["PRODUCT_ID"].ToString();
                txtProductName.Text = dt.Rows[0]["PRODUCT_NAME"].ToString();
                txtProductPrice.Text = dt.Rows[0]["PRODUCT_PRICE"].ToString();
                cboCategory.SelectedValue = dt.Rows[0]["CATEGORY_ID"].ToString();
                cboSupplier.SelectedValue = dt.Rows[0]["SUPPLIER_ID"].ToString();
                txtInStock.Text = dt.Rows[0]["INSTOCK"].ToString();
                cboProductStatus.Text = dt.Rows[0]["PRODUCT_STATUS"].ToString();
                rtfDesc.Text = dt.Rows[0]["PRODUCT_DESC"].ToString();
                if (dt.Rows[0]["PRODUCT_IMAGE"].ToString() != "")
                {
                    pbImage.Image = Image.FromFile(@"" + dt.Rows[0]["PRODUCT_IMAGE"].ToString() + "");
                }
                flag = true;
            }
            if (!flag)
            {
                MessageBox.Show("Invalid product ID!");
                txtIDtoSearch.Focus();
            }
            con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtProductID.Text != "" && cboProductStatus.Text != "inactive") {
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_XOAPRODUCT", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@P_ID", txtProductID.Text));
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Product delete successful!!");
                    if (clsFormProvider.mainF.getUserType() == "User")
                    {
                        dgvProduct.DataSource = getProductData();
                    }
                    else {
                        dgvProduct.DataSource = getProductDataForAdmin();
                    }
                }
                con.Close();
            } else if (txtProductID.Text != "" && cboProductStatus.Text == "inactive") {
                MessageBox.Show("Product is already inactive!!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_SUAPRODUCT",con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@P_ID", txtProductID.Text));
                cmd.Parameters.Add(new SqlParameter("@P_NAME", txtProductName.Text));
                cmd.Parameters.Add(new SqlParameter("@C_ID", cboCategory.SelectedValue));
                cmd.Parameters.Add(new SqlParameter("@P_IMAGE", filePath));
                cmd.Parameters.Add(new SqlParameter("@P_PRICE", txtProductPrice.Text));
                cmd.Parameters.Add(new SqlParameter("@S_ID", cboSupplier.SelectedValue));
                cmd.Parameters.Add(new SqlParameter("@INSTOCK", txtInStock.Text));
                cmd.Parameters.Add(new SqlParameter("@P_DESC", rtfDesc.Text));
                cmd.Parameters.Add(new SqlParameter("@P_STATUS", cboProductStatus.Text));
                if (cmd.ExecuteNonQuery() > 0) {
                    MessageBox.Show("Product updated successful!!!");
                    if (clsFormProvider.mainF.getUserType() == "User")
                    {
                        dgvProduct.DataSource = getProductData();
                    }
                    else {
                        dgvProduct.DataSource = getProductDataForAdmin();
                    }
                    txtProductID.Clear();
                    txtProductName.Clear();
                    cboCategory.SelectedValue = 1;
                    pbImage.Image = null;
                    txtProductPrice.Clear();
                    cboSupplier.SelectedValue = 1;
                    txtInStock.Clear();
                    rtfDesc.Clear();
                    cboProductStatus.SelectedText = "";
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
}
