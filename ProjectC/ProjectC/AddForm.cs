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
    public partial class AddForm : Form
    {

        private Byte[] byteBLOBData;
        public AddForm()
        {
            InitializeComponent();
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) {
                FileStream fsBLOBFile = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                byteBLOBData = new Byte[fsBLOBFile.Length];
                fsBLOBFile.Read(byteBLOBData,0,byteBLOBData.Length);
                fsBLOBFile.Close();
                MemoryStream stmBLOBData = new MemoryStream(byteBLOBData);
                pbUploadImg.Image = Image.FromStream(stmBLOBData);
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=ElectronicSupermarket;Integrated Security=True");
            SqlCommand myCommand = new SqlCommand("INSERT INTO [PRODUCT] (PRODUCT_ID, PRODUCT_NAME,PRODUCT_PRICE,CATEGORY_ID,PRODUCT_IMAGE,SUPPLIER_ID,PRODUCT_DESC) VALUES (@Param1, @Param2,@Param3,@Param4,@Param5,@Param6,@Param7)", con);
            SqlCommand insertWareHouse = new SqlCommand("INSERT INTO [WAREHOUSE] (PRODUCT_ID, INSTOCK_QUANTITY) VALUES (@Param1, @Param2)", con);
            con.Open();
            insertWareHouse.Parameters.AddWithValue("@Param1", txtProductID.Text);
            insertWareHouse.Parameters.AddWithValue("@Param2", txtInStock.Text);
            insertWareHouse.ExecuteNonQuery();
            myCommand.Parameters.AddWithValue("@Param1", txtProductID.Text);
            myCommand.Parameters.AddWithValue("@Param2", txtProductName.Text);
            myCommand.Parameters.AddWithValue("@Param3", txtProductPrice.Text);
            myCommand.Parameters.AddWithValue("@Param4", txtCategory.Text);
            myCommand.Parameters.AddWithValue("@Param5", byteBLOBData);
            myCommand.Parameters.AddWithValue("@Param6", txtSupplier.Text);
            myCommand.Parameters.AddWithValue("@Param7", txtDesc.Text);
            myCommand.ExecuteNonQuery();
            con.Close();
        }
    }
}
