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
using System.IO;

namespace ProjectC
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        //Tạo đường dẫn kết nối database
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ElectronicSupermarket;Integrated Security=True");

        /// <summary>
        /// Sự kiện khi đóng Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Thông báo trước khi đóng form
            DialogResult result = MessageBox.Show("Are you sure you want to close this form?", "Close Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)//Người dùng chọn No không tắt form
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Sự kiện Form Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductForm_Load(object sender, EventArgs e)
        {
            //kiểm tra Usertype
            if (((MainForm)this.MdiParent).getUserType() == "User")
            {
                //Khóa trạng thái của cboProductStatus
                cboProductStatus.Visible = false;
                label9.Visible = false;
                //Đổ dữ liệu vào datagridview Product cho User
                getProductData();
                //Ẩn các cột
                dgvProduct.Columns[2].Visible = false;
                dgvProduct.Columns[3].Visible = false;
                dgvProduct.Columns[5].Visible = false;
                dgvProduct.Columns[6].Visible = false;
                dgvProduct.Columns[8].Visible = false;
            }
            else {
                //Đổ dữ liệu vào datagridview Product cho Admin và Manager
                getProductDataForAdmin();
                //Ẩn các cột
                dgvProduct.Columns[2].Visible = false;
                dgvProduct.Columns[3].Visible = false;
                dgvProduct.Columns[5].Visible = false;
                dgvProduct.Columns[6].Visible = false;
                dgvProduct.Columns[8].Visible = false;
            }
            //Đổ dữ liệu vào combobox Category
            cboCategory.DataSource = getCategoryTable();
            cboCategory.DisplayMember = "CATEGORY_NAME";
            cboCategory.ValueMember = "CATEGORY_ID";
            //Đổ dữ liệu vào combobox Supplier
            cboSupplier.DataSource = getSupplierTable();
            cboSupplier.DisplayMember = "SUPPLIER_NAME";
            cboSupplier.ValueMember = "SUPPLIER_ID";
        }
        //Đóng form
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Thêm mới product
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (txtProductID.Text != "" && txtProductName.Text != "" && txtProductPrice.Text != "")//Kiểm trả rỗng textbox ID và Name của Product trước khi thêm
            {
                try
                {
                    con.Open();//Mở kết nối
                    SqlCommand cmd = new SqlCommand("SP_THEMDSPRODUCT", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    //Truyền dữ liệu cho store procedure
                    cmd.Parameters.Add(new SqlParameter("@P_ID", txtProductID.Text));
                    cmd.Parameters.Add(new SqlParameter("@P_NAME", txtProductName.Text));
                    cmd.Parameters.Add(new SqlParameter("@P_PRICE", txtProductPrice.Text));
                    cmd.Parameters.Add(new SqlParameter("@C_ID", cboCategory.SelectedValue));
                    cmd.Parameters.Add(new SqlParameter("@P_IMAGE", filePath));
                    cmd.Parameters.Add(new SqlParameter("@P_DESC", rtfDesc.Text));
                    cmd.Parameters.Add(new SqlParameter("@S_ID", cboSupplier.SelectedValue));
                    cmd.Parameters.Add(new SqlParameter("@P_STATUS", cboProductStatus.Text));
                    cmd.Parameters.Add(new SqlParameter("@INSTOCK", txtInStock.Text));
                    if (cmd.ExecuteNonQuery() > 0)//SQL chạy thành công 
                    {
                        MessageBox.Show("Add product successful");//Thông báo thêm thành công
                        //Đặt lại giá trị torng các control về rỗng
                        txtProductID.Clear();
                        txtProductName.Clear();
                        cboCategory.SelectedValue = 1;
                        pbImage.Image = null;
                        txtProductPrice.Clear();
                        cboSupplier.SelectedValue = 1;
                        txtInStock.Clear();
                        rtfDesc.Clear();
                        cboProductStatus.SelectedText = "";
                        //Đổ lại dữ liệu vào datagridview tùy theo loại usertype
                        if (clsFormProvider.mainF.getUserType() == "User")
                        {
                            getProductData();
                        }
                        else if (clsFormProvider.mainF.getUserType() == "Admin" || clsFormProvider.mainF.getUserType() == "Manager")
                        {
                            getProductDataForAdmin();
                        }
                    }
                    con.Close();//Đóng kết nối
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);//Thông báo lỗi
                    con.Close();
                }
            }
            else {
                //Thông báotextbox ID hoặc Name của product đang rỗng không thể thêm mới được
                MessageBox.Show("Product ID or Product name is blank!!! Can not add new product!!!");
            }
        }
        //Lấy dữ liệu từ database cho usertype Admin và Manager
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
        //Lấy dữ liệu từ database cho usertype User
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
                filePath = openFileDialog1.FileName;//Lưu đường dẫn đến file hình
                pbImage.Image = Image.FromFile(@"" + filePath);//Hiện file hình trong picturebox
            }
        }
        /// <summary>
        /// Sự kiện khi nhấn chuột trong datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Mở và đóng các control
                btnAddNew.Enabled = false;//Đóng nút Add
                txtProductID.Enabled = false;//Đóng textbox ID
                btnUpdate.Enabled = true;//Mở nút Update
                btnDelete.Enabled = true;// Mở nút Delete
                if (!dgvProduct.Rows[dgvProduct.CurrentCell.RowIndex].IsNewRow)
                {
                    pbImage.Image = null;//xóa hình cũ trong picturebox
                                         //Đổ dữ liệu từ ô được nhấn chuột vào các control
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
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Chức năng tìm kiếm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                //Mở và đóng các control
                btnAddNew.Enabled = false;
                btnUpdate.Enabled = true;
                txtProductID.Enabled = false;
                pbImage.Image = null;
                bool flag = false;//cờ kiểm tra
                con.Open();//Mở kết nối
                SqlCommand cmd;
                //Kiểm tra loại user để sử dụng cmd tương ứng
                if (((MainForm)this.MdiParent).getUserType() == "User")
                {
                    string sql = "select * from PRODUCT where PRODUCT_ID = '" + txtIDtoSearch.Text + "' and PRODUCT_STATUS = 'active'";
                    cmd = new SqlCommand(sql, con);
                    cmd.CommandType = CommandType.Text;
                }
                else
                {
                    cmd = new SqlCommand("sp_searchProductbyID", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@P_ID", txtIDtoSearch.Text));
                }
                //SQL chạy thành công
                if ((string)cmd.ExecuteScalar() == txtIDtoSearch.Text)
                {
                    //Đổ dữ liệu ra bảng rồi đổ ra các control
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
                if (!flag)//Trường hợp không tìm thấy
                {
                    //Thông báo nhập sai ID 
                    MessageBox.Show("Invalid product ID!");
                    txtIDtoSearch.Focus();
                }
                con.Close();//Đóng kết nối
            }
            catch (Exception ex)
            {
                //Thông báo lỗi ngoại lệ
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Chức năng xóa sản phẩm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Thông báo hỏi trước khi xóa sản phẩm
            DialogResult result = MessageBox.Show("Are you sure you want to delete the product info?", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) {
                //Kiểm tra ô ID và trạng thái của sản phẩm
                if (txtProductID.Text != "" && cboProductStatus.Text != "inactive")
                {
                    con.Open();//Mở kết nối
                    SqlCommand cmd = new SqlCommand("SP_XOAPRODUCT", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@P_ID", txtProductID.Text));
                    if (cmd.ExecuteNonQuery() > 0)//SQL chạy thảnh công
                    {
                        //Thông báo xóa thành công
                        MessageBox.Show("Product delete successful!!");
                        //Xóa dữ liệu trong các control
                        txtProductID.Clear();
                        txtProductName.Clear();
                        cboCategory.SelectedValue = 1;
                        pbImage.Image = null;
                        txtProductPrice.Clear();
                        cboSupplier.SelectedValue = 1;
                        txtInStock.Clear();
                        rtfDesc.Clear();
                        cboProductStatus.SelectedText = "";
                        //Mở và đóng các control
                        btnUpdate.Enabled = false;
                        btnDelete.Enabled = false;
                        txtProductID.Enabled = true;
                        btnAddNew.Enabled = true;
                        //Kiểm tra loại user để đổ dữ liệu vào lại datagridview
                        if (clsFormProvider.mainF.getUserType() == "User")
                        {
                            getProductData();
                        }
                        else
                        {
                            getProductDataForAdmin();
                        }
                    }
                    con.Close();//Đóng kết nối
                }
                //Trường hợp ô ID trống hoặc sản phẩm đã inactive
                else if (txtProductID.Text != "" && cboProductStatus.Text == "inactive")
                {
                    MessageBox.Show("Product is already inactive!!");
                }
            }
        }

        //Chức năng cập nhật sản phẩm
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Thông báo hỏi trước khi cập nhật sản phẩm
            DialogResult result = MessageBox.Show("Are you sure you want to update the product info?", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) {
                if (txtProductName.Text != "")
                {
                    try
                    {
                        con.Open();//Mở kết nối
                        SqlCommand cmd = new SqlCommand("SP_SUAPRODUCT", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        //truyền dữ liệu cho stored procedure
                        cmd.Parameters.Add(new SqlParameter("@P_ID", txtProductID.Text));
                        cmd.Parameters.Add(new SqlParameter("@P_NAME", txtProductName.Text));
                        cmd.Parameters.Add(new SqlParameter("@C_ID", cboCategory.SelectedValue));
                        cmd.Parameters.Add(new SqlParameter("@P_IMAGE", filePath));
                        cmd.Parameters.Add(new SqlParameter("@P_PRICE", txtProductPrice.Text));
                        cmd.Parameters.Add(new SqlParameter("@S_ID", cboSupplier.SelectedValue));
                        cmd.Parameters.Add(new SqlParameter("@INSTOCK", Convert.ToInt32(txtInStock.Text)));
                        cmd.Parameters.Add(new SqlParameter("@P_DESC", rtfDesc.Text));
                        cmd.Parameters.Add(new SqlParameter("@P_STATUS", cboProductStatus.Text));
                        if (cmd.ExecuteNonQuery() > 0)//SQL chạy thành công
                        {
                            //Thông báo cập nhật sản phẩm thành công
                            MessageBox.Show("Product updated successful!!!");
                            //Xóa dữ liệu trong các control
                            txtProductID.Clear();
                            txtProductName.Clear();
                            cboCategory.SelectedValue = 1;
                            pbImage.Image = null;
                            txtProductPrice.Clear();
                            cboSupplier.SelectedValue = 1;
                            txtInStock.Clear();
                            rtfDesc.Clear();
                            cboProductStatus.SelectedText = "";
                            //Đóng và mở các control
                            btnUpdate.Enabled = false;
                            btnDelete.Enabled = false;
                            txtProductID.Enabled = true;
                            btnAddNew.Enabled = true;
                            //Đổ dữ liệu vào datagridview tùy vào loại user
                            if (clsFormProvider.mainF.getUserType() == "User")
                            {
                                getProductData();
                            }
                            else if (clsFormProvider.mainF.getUserType() == "Admin" || clsFormProvider.mainF.getUserType() == "Manager")
                            {
                                getProductDataForAdmin();
                            }
                        }                        
                        con.Close();//Đóng kết nối
                    }
                    catch (Exception ex)
                    {
                        //Thông báo lỗi
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    //Thông báo ô product ID trống không tìm được sản phẩm
                    MessageBox.Show("Product ID is blank!!! Can not update product infomation!!!");
                }
            }
        }

        /// <summary>
        /// Chức năng Clear dùng để trả lại trạng thái các control như khi load form lần đầu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Kiểm tra product ID đã có trong database chưa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtProductID_Leave(object sender, EventArgs e)
        {
            if (txtProductID.Text != "")
            {
                try
                {
                    con.Open();//Mở kết nối
                    SqlCommand cmd = new SqlCommand("sp_searchProductbyID", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    //Truyền dữ liệu cho store procedure
                    cmd.Parameters.Add(new SqlParameter("@P_ID", txtProductID.Text));
                    if ((string)cmd.ExecuteScalar() == txtProductID.Text)//SQL chạy thành công
                    {
                        //Thông báo ID đã được sử dụng
                        MessageBox.Show("This ID is already used!!! Please try different ID!!!");
                        txtProductID.Clear();
                        txtProductID.Focus();
                    }
                }
                catch (Exception ex)
                {
                    //Thông báo lỗi
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }
        //Kiểm tra tên sản phẩm đã có trong database chưa;
        private void txtProductName_Leave(object sender, EventArgs e)
        {
            if (txtProductName.Text != "")//Thực hiện khi ô product name không rỗng
            {
                try
                {
                    con.Open();//Mở kết nối
                    SqlCommand cmd = new SqlCommand("sp_searchProductbyName", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    //Truyền dữ liệu cho stored procedure
                    cmd.Parameters.Add(new SqlParameter("@P_NAME", txtProductName.Text));
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        //Đã có tên product trong database
                        if (txtProductName.Text == reader["PRODUCT_NAME"].ToString())
                        {
                            //Thông báo lỗi
                            MessageBox.Show("This product name is already used!!! Please try different product name!!!");
                            txtProductName.Clear();
                            txtProductName.Focus();
                            break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    //Thông báo lỗi
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        //Lấy dữ liệu của bảng category
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
        //Lấy dữ liệu của bản supplier
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

        //Kiểm tra phím bấm của ô giá sản phẩm
        private void txtProductPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Chỉ cho nhấn phím số và 1 dấu .
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

        //Kiểm tra phím bấm của ô số lượng
        private void txtInStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Chỉ cho nhấn phím số
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '\b'))
            {
                e.Handled = true;
            }
        }

        private void ProductForm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void txtProductID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
