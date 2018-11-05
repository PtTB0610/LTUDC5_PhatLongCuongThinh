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

        private void ProductForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((MainForm)this.MdiParent).enableControls();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=ElectronicSupermarket;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT PRODUCT.*, WAREHOUSE.*, SUPPLIER.*, CATEGORY.* FROM [PRODUCT] JOIN [WAREHOUSE] ON (PRODUCT.PRODUCT_ID = WAREHOUSE.PRODUCT_ID)" +
                "JOIN [SUPPLIER] ON (PRODUCT.SUPPLIER_ID = SUPPLIER.SUPPLIER_ID) JOIN [CATEGORY] ON (PRODUCT.CATEGORY_ID = CATEGORY.CATEGORY_ID)", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++) {
                DataRow dr = dt.Rows[i];
                ListViewItem item = new ListViewItem(dr["PRODUCT_ID"].ToString());
                item.SubItems.Add(dr["PRODUCT_NAME"].ToString());
                item.SubItems.Add(dr["PRODUCT_PRICE"].ToString());
                item.SubItems.Add(dr["CATEGORY_NAME"].ToString());
                item.SubItems.Add(dr["SUPPLIER_NAME"].ToString());
                item.SubItems.Add(dr["PRODUCT_DESC"].ToString());
                lvProductData.Items.Add(item);
            }           
        }       
        private void lvProductData_SelectedIndexChanged(object sender, EventArgs e)
        {
            String temp;
            if (lvProductData.SelectedItems.Count > 0) {
                ListViewItem item = lvProductData.SelectedItems[0];
                temp = item.SubItems[0].Text;
                SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=ElectronicSupermarket;Integrated Security=True");
                con.Open();
                SqlCommand myCommand = new SqlCommand("SELECT * FROM [PRODUCT] WHERE PRODUCT_ID ='" + temp + "'", con);
                SqlDataReader reader = myCommand.ExecuteReader();
                reader.Read();
                Byte[] imageData = (Byte[])reader["PRODUCT_IMAGE"];
                MemoryStream stmBLOBData = new MemoryStream(imageData);
                pbImage.Image = Image.FromStream(stmBLOBData);
                con.Close();
            }           
        }
        public void closeForm() {
            this.Close();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            if (((MainForm)this.MdiParent).Controls["lbUserType"].Text != "Admin") {
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
        }
    }
}
