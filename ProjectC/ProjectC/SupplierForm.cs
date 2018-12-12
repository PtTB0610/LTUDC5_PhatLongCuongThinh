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
    public partial class SupplierForm : Form
    {
        public SupplierForm()
        {
            InitializeComponent();
        }
        //Tạo kết nối database
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ElectronicSupermarket;Integrated Security=True");
        /// <summary>
        /// Load Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SupplierForm_Load(object sender, EventArgs e)
        {
            //Đổ dữ liệu
            getSupplierData();
            //Ẩn cột
            dgvData.Columns[5].Visible = false;
        }
        /// <summary>
        /// Sự kiện đóng form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Lấy dữ liệu supplier từ database
        private void getSupplierData() {
            try
            {
                con.Close();
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_LAYTATCASUPPLIER", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgvData.DataSource = dt;
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
        //Chỉ cho phép nhập số
        private void txtSupplierID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '\b'))
            {
                e.Handled = true;
            }
        }
        //Kiểm tra ID đã có trong database
        private void txtSupplierID_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtSupplierID.Text != "")//Thực hiện khi textbox ID không rỗng
                {
                    con.Open();//Mở kết nối
                    SqlCommand cmd = new SqlCommand("sp_searchSupplierbyID", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@S_ID", txtSupplierID.Text));
                    //SQL chạy tìm thấy ID trong database
                    if (cmd.ExecuteScalar() != null && (int)cmd.ExecuteScalar() == Convert.ToInt32(txtSupplierID.Text))
                    {
                        //Thông báo đã có ID trong database
                        MessageBox.Show("This ID is already used!!! Please provide a different ID!!!");
                        txtSupplierID.Clear();
                        txtSupplierID.Focus();
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
        //Kiểm tra phím nhấn của ô Supplier Name
        private void txtSupName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Chỉ cho phép nhập chữ và dấu cách
            if (!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '\b' || e.KeyChar == ' '))
            {
                e.Handled = true;
            }
        }
        //Kiểm tra tên đã có trong database chưa
        private void txtSupName_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtSupName.Text != "")//Thực hiện khi ô supplier name khác rỗng
                {
                    con.Open();//Mở kết nối
                    SqlCommand cmd = new SqlCommand("sp_searchSupplierbyName", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@S_NAME", txtSupName.Text));
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read()) {
                        //Tìm thấy tên supplier trong database
                        if (txtSupName.Text == reader["SUPPLIER_NAME"].ToString())
                        {
                            //Thông báo lỗi
                            MessageBox.Show("This product name is already used!!! Please try different product name!!!");
                            txtSupName.Clear();
                            txtSupName.Focus();
                            break;
                        }
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
        //Kiểm tra phím bấm của ô tìm kiếm
        private void txtSearchID_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Chỉ cho nhập số
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '\b'))
            {
                e.Handled = true;
            }
        }
        //Kiểm tra phím bấm của ô số đt
        private void txtSupPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Chỉ cho nhập số
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '\b'))
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// Sự kiện khi nhấn trong datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Đóng và mở các control
            btnAddNew.Enabled = false;
            txtSupplierID.Enabled = false;
            btnUpdate.Enabled = true;
            txtSearchID.Clear();
            //Đổ dữ liệu vào các control
            if (dgvData.SelectedRows.Count > 0) {
                txtSupplierID.Text = dgvData.SelectedCells[0].Value.ToString();
                txtSupName.Text = dgvData.SelectedCells[1].Value.ToString();
                txtSupAddress.Text = dgvData.SelectedCells[2].Value.ToString();
                txtSupPhone.Text = dgvData.SelectedCells[3].Value.ToString();
                txtSupEmail.Text = dgvData.SelectedCells[4].Value.ToString();
                cboSubStatus.Text = dgvData.SelectedCells[5].Value.ToString();
            }
        }
        /// <summary>
        /// Chức năng Clear, trả trạng thái của các control về ban đầu khi load form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSupplierID.Clear();
            txtSupName.Clear();
            txtSupAddress.Clear();
            txtSupPhone.Clear();
            txtSupEmail.Clear();
            txtSearchID.Clear();
            cboSubStatus.Text = "";
            txtSupplierID.Enabled = true;
            btnAddNew.Enabled = true;
            btnUpdate.Enabled = false;
        }
        /// <summary>
        /// Chức năng tìm kiếm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Xóa dữ liệu cũ còn trong các control
            txtSupplierID.Clear();
            txtSupName.Clear();
            txtSupAddress.Clear();
            txtSupPhone.Clear();
            txtSupEmail.Clear();
            cboSubStatus.Text = "";
            try
            {
                if (txtSearchID.Text != "")//Thực hiện khi ô tìm kiếm khác rỗng
                {
                    con.Open();//Mở kết nối
                    SqlCommand cmd = new SqlCommand("sp_searchSupplierbyID", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@S_ID", txtSearchID.Text));
                    //Tìm thấy supplier trong database và đổ dữ liệu vào các control
                    if (cmd.ExecuteScalar() != null && (int)cmd.ExecuteScalar() == Convert.ToInt32(txtSearchID.Text))
                    {
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        txtSupplierID.Text = dt.Rows[0]["SUPPLIER_ID"].ToString();
                        txtSupName.Text = dt.Rows[0]["SUPPLIER_NAME"].ToString();
                        txtSupAddress.Text = dt.Rows[0]["SUPPLIER_ADDRESS"].ToString();
                        txtSupPhone.Text = dt.Rows[0]["SUPPLIER_PHONE"].ToString();
                        txtSupEmail.Text = dt.Rows[0]["SUPPLIER_EMAIL"].ToString();
                        cboSubStatus.Text = dt.Rows[0]["SUPPLIER_STATUS"].ToString();
                        //Đóng và mở các control
                        txtSupplierID.Enabled = false;
                        btnAddNew.Enabled = false;
                        btnUpdate.Enabled = true;
                    }
                    else
                    {
                        //Thông báo không có ID trong database
                        MessageBox.Show("Invalid Supplier ID!!!");
                    }
                }
                else {
                    //Thông báo ô ID tìm kiếm rỗng
                    MessageBox.Show("No supplier ID provided!!!");
                    txtSearchID.Focus();
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

        /// <summary>
        /// Chức năng thêm mới
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (txtSupplierID.Text != "" && txtSupName.Text != "" && cboSubStatus.Text != "")//kiểm tra các control cần thiết không rỗng
            {
                try
                {
                    con.Open();//Mở kết nối
                    SqlCommand cmd = new SqlCommand("SP_THEMSUPPLIER", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    //Truyền dữ liệu cho stored procedure
                    cmd.Parameters.Add(new SqlParameter("@S_ID", txtSupplierID.Text));
                    cmd.Parameters.Add(new SqlParameter("@S_NAME", txtSupName.Text));
                    cmd.Parameters.Add(new SqlParameter("@S_PHONE", txtSupPhone.Text));
                    cmd.Parameters.Add(new SqlParameter("@S_EMAIL", txtSupEmail.Text));
                    cmd.Parameters.Add(new SqlParameter("@S_ADDRESS", txtSupAddress.Text));
                    cmd.Parameters.Add(new SqlParameter("@S_STATUS", cboSubStatus.Text));
                    if (cmd.ExecuteNonQuery() > 0)//SQL chạy thành công
                    {
                        //Thông báo thêm thành công
                        MessageBox.Show("Supplier added successful!!!");
                        //Xóa dữ liệu trong các control và đổ lại vào datagridview
                        txtSupplierID.Clear();
                        txtSupName.Clear();
                        txtSupPhone.Clear();
                        txtSupEmail.Clear();
                        txtSupAddress.Clear();
                        cboSubStatus.Text = "";
                        getSupplierData();
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
            else {
                //Thông báo các ô cần thiết thiếu dữ liệu
                MessageBox.Show("Supplier ID, Supplier name or Supplier status is blank!!! Please check again!!!");
            }
        }

        private void SupplierForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close?", "Close Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
