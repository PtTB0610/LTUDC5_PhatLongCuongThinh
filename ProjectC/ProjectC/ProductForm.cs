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
            if (((MainForm)this.MdiParent).getUserType() == "User") {
                cboProductStatus.Visible = false;
                label9.Visible = false;
            }
            cboCategory.DataSource = getCategoryTable();
            cboCategory.DisplayMember = "CATEGORY_NAME";
            cboCategory.ValueMember = "CATEGORY_ID";

            cboSupplier.DataSource = getSupplierTable();
            cboSupplier.DisplayMember = "SUPPLIER_NAME";
            cboSupplier.ValueMember = "SUPPLIER_ID";


            if (clsFormProvider.mainF.getUserType() == "User")
            {
                getProductData();
                dgvProduct.Columns[2].Visible = false;
                dgvProduct.Columns[3].Visible = false;
                dgvProduct.Columns[5].Visible = false;
                dgvProduct.Columns[6].Visible = false;
                dgvProduct.Columns[8].Visible = false;
            }
            else {
                getProductDataForAdmin();
                dgvProduct.Columns[2].Visible = false;
                dgvProduct.Columns[3].Visible = false;
                dgvProduct.Columns[5].Visible = false;
                dgvProduct.Columns[6].Visible = false;
                dgvProduct.Columns[8].Visible = false;
            }
        }
        //Đóng form
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Thêm mới product
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (txtProductID.Text != "" && txtProductName.Text != "")
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SP_THEMDSPRODUCT", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@P_ID", txtProductID.Text));
                    cmd.Parameters.Add(new SqlParameter("@P_NAME", txtProductName.Text));
                    cmd.Parameters.Add(new SqlParameter("@P_PRICE", txtProductPrice.Text));
                    cmd.Parameters.Add(new SqlParameter("@C_ID", cboCategory.SelectedValue));
                    cmd.Parameters.Add(new SqlParameter("@P_IMAGE", filePath));
                    cmd.Parameters.Add(new SqlParameter("@P_DESC", rtfDesc.Text));
                    cmd.Parameters.Add(new SqlParameter("@S_ID", cboSupplier.SelectedValue));
                    cmd.Parameters.Add(new SqlParameter("@P_STATUS", cboProductStatus.Text));
                    cmd.Parameters.Add(new SqlParameter("@INSTOCK", txtInStock.Text));
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Add product successful");
                        txtProductID.Clear();
                        txtProductName.Clear();
                        cboCategory.SelectedValue = 1;
                        pbImage.Image = null;
                        txtProductPrice.Clear();
                        cboSupplier.SelectedValue = 1;
                        txtInStock.Clear();
                        rtfDesc.Clear();
                        cboProductStatus.SelectedText = "";
                        if (clsFormProvider.mainF.getUserType() == "User")
                        {
                            getProductData();
                        }
                        else if (clsFormProvider.mainF.getUserType() == "Admin" || clsFormProvider.mainF.getUserType() == "Manager")
                        {
                            getProductDataForAdmin();
                        }
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else {
                MessageBox.Show("Product ID or Product name is blank!!! Can not add new product!!!");
            }
        }
        //Lấy dữ liệu từ database
        public void getProductDataForAdmin()
        {
            try
            {
                con.Close();
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_LAYTATCAPRODUCT", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();
                dgvProduct.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Lấy dữ liệu từ database
        public void getProductData()
        {
            try
            {
                con.Close();
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_LAYDSPRODUCT", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();
                dgvProduct.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        string filePath = "";//đường dẫn file hình ảnh
        //Upload hình ảnh
        private void btnUpload_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;
                pbImage.Image = Image.FromFile(@"" + filePath);
            }
        }

        private void dgvProduct_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAddNew.Enabled = false;
            txtProductID.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
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
            btnAddNew.Enabled = false;
            btnUpdate.Enabled = true;
            txtProductID.Enabled = false;
            pbImage.Image = null;
            bool flag = false;
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_searchProductbyID", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@P_ID", txtIDtoSearch.Text));
            if ((string)cmd.ExecuteScalar() == txtIDtoSearch.Text)
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
            if (txtProductID.Text != "" && cboProductStatus.Text != "inactive")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_XOAPRODUCT", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@P_ID", txtProductID.Text));
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Product delete successful!!");
                    txtProductID.Clear();
                    txtProductName.Clear();
                    cboCategory.SelectedValue = 1;
                    pbImage.Image = null;
                    txtProductPrice.Clear();
                    cboSupplier.SelectedValue = 1;
                    txtInStock.Clear();
                    rtfDesc.Clear();
                    cboProductStatus.SelectedText = "";
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    txtProductID.Enabled = true;
                    btnAddNew.Enabled = true;
                    if (clsFormProvider.mainF.getUserType() == "User")
                    {
                        getProductData();
                    }
                    else
                    {
                        getProductDataForAdmin();
                    }
                }
                con.Close();
            }
            else if (txtProductID.Text != "" && cboProductStatus.Text == "inactive")
            {
                MessageBox.Show("Product is already inactive!!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want update the product info?", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) {
                if (txtProductName.Text != "")
                {
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("SP_SUAPRODUCT", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@P_ID", txtProductID.Text));
                        cmd.Parameters.Add(new SqlParameter("@P_NAME", txtProductName.Text));
                        cmd.Parameters.Add(new SqlParameter("@C_ID", cboCategory.SelectedValue));
                        cmd.Parameters.Add(new SqlParameter("@P_IMAGE", filePath));
                        cmd.Parameters.Add(new SqlParameter("@P_PRICE", txtProductPrice.Text));
                        cmd.Parameters.Add(new SqlParameter("@S_ID", cboSupplier.SelectedValue));
                        cmd.Parameters.Add(new SqlParameter("@INSTOCK", Convert.ToInt32(txtInStock.Text)));
                        cmd.Parameters.Add(new SqlParameter("@P_DESC", rtfDesc.Text));
                        cmd.Parameters.Add(new SqlParameter("@P_STATUS", cboProductStatus.Text));
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Product updated successful!!!");
                            txtProductID.Clear();
                            txtProductName.Clear();
                            cboCategory.SelectedValue = 1;
                            pbImage.Image = null;
                            txtProductPrice.Clear();
                            cboSupplier.SelectedValue = 1;
                            txtInStock.Clear();
                            rtfDesc.Clear();
                            cboProductStatus.SelectedText = "";
                            btnUpdate.Enabled = false;
                            btnDelete.Enabled = false;
                            txtProductID.Enabled = true;
                            if (clsFormProvider.mainF.getUserType() == "User")
                            {
                                getProductData();
                            }
                            else if (clsFormProvider.mainF.getUserType() == "Admin" || clsFormProvider.mainF.getUserType() == "Manager")
                            {
                                getProductDataForAdmin();
                            }
                        }
                        btnAddNew.Enabled = true;
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Product name is blank!!! Can not update product infomation!!!");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            btnAddNew.Enabled = true;
            txtProductID.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            txtProductID.Clear();
            txtProductName.Clear();
            txtProductPrice.Clear();
            cboCategory.SelectedValue = 1;
            cboSupplier.SelectedValue = 1;
            txtInStock.Clear();
            cboProductStatus.Text = "";
            rtfDesc.Clear();
            pbImage.Image = null;
            txtProductID.Focus();
        }

        private void txtProductID_Leave(object sender, EventArgs e)
        {
            if (txtProductID.Text != "")
            {
                try
                {
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
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
                finally
                {
                    con.Close();
                }
            }
        }

        private DataTable getCategoryTable() {
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("SP_LAYDSCATEGORY", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            return dt;
        }

        private DataTable getSupplierTable()
        {
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("SP_LAYDSSUPPLIER", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            return dt;
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
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '\b'))
            {
                e.Handled = true;
            }
        }
    }
}
