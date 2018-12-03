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
            ((MainForm)this.MdiParent).enableViewProductControls();
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
                dgvProduct.Columns[7].Visible = false;
            }
            else {
                dgvProduct.DataSource = getProductData();
                dgvProduct.Columns[2].Visible = false;
                dgvProduct.Columns[3].Visible = false;
                dgvProduct.Columns[5].Visible = false;
                dgvProduct.Columns[7].Visible = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddProductForm addPro = new AddProductForm();
            addPro.Show();
            addPro.MdiParent = clsFormProvider.mainF;
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
            }
        }

        private void dgvProduct_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pbImage.Image = null;
            if (dgvProduct.SelectedCells.Count > 0) {
                txtProductID.Text = dgvProduct.SelectedCells[0].Value.ToString();
                txtProductName.Text = dgvProduct.SelectedCells[1].Value.ToString();
                txtProductPrice.Text = dgvProduct.SelectedCells[4].Value.ToString();
                cboCategory.SelectedValue = dgvProduct.SelectedCells[2].Value.ToString();
                cboSupplier.SelectedValue = dgvProduct.SelectedCells[5].Value.ToString();
                txtInStock.Text = getInstock(dgvProduct.SelectedCells[0].Value.ToString()) + "";
                rtfDesc.Text = dgvProduct.SelectedCells[6].Value.ToString();
                cboProductStatus.Text = dgvProduct.SelectedCells[7].Value.ToString();
                if (dgvProduct.SelectedCells[3].Value.ToString() != "") {
                    pbImage.Image = Image.FromFile(@"" + dgvProduct.SelectedCells[3].Value.ToString() + "");
                }
            }
        }

        public int getInstock(string productID) {
            DataTable wareHouse = db.getTableData("WAREHOUSE");
            int kQ = 0;
            for (int i = 0; i < wareHouse.Rows.Count; i++)
            {
                DataRow dr = wareHouse.Rows[i];
                if (dr["PRODUCT_ID"].ToString() == productID)
                {
                    kQ = Convert.ToInt32(dr["INSTOCK_QUANTITY"].ToString());
                    break;
                }
            }
            return kQ;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            pbImage.Image = null;
            bool flag = false;
            DataTable dt = db.getTableData("PRODUCT");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                if (dr["PRODUCT_ID"].ToString() == txtIDtoSearch.Text)
                {
                    txtProductID.Text = dr["PRODUCT_ID"].ToString();
                    txtProductName.Text = dr["PRODUCT_NAME"].ToString();
                    txtProductPrice.Text = dr["PRODUCT_PRICE"].ToString();
                    cboCategory.SelectedValue = dr["CATEGORY_ID"].ToString();
                    cboSupplier.SelectedValue = dr["SUPPLIER_ID"].ToString();
                    txtInStock.Text = getInstock(dr["PRODUCT_ID"].ToString()) + "";
                    cboProductStatus.Text = dr["PRODUCT_STATUS"].ToString();
                    rtfDesc.Text = dr["PRODUCT_DESC"].ToString();
                    if (dr["PRODUCT_IMAGE"].ToString() != "") {
                        pbImage.Image = Image.FromFile(@"" + dr["PRODUCT_IMAGE"].ToString() + "");
                    }
                    flag = true;
                    break;
                }
            }
            if (!flag) {
                MessageBox.Show("Invalid product ID!");
                txtIDtoSearch.Focus();
            }
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
                    dgvProduct.DataSource = getProductDataForAdmin();
                }
                con.Close();
            }
        }
    }
}
