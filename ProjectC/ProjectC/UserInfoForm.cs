/*
Name: Bui Tien Phat
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjectC
{
    public partial class UserInfoForm : Form
    {
        public UserInfoForm()
        {
            InitializeComponent();
        }
        //Tạo đường dẫn database
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ElectronicSupermarket;Integrated Security=True");

        /// <summary>
        /// Chạy form userinfo lần đầu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserInfoForm_Load(object sender, EventArgs e)
        {
            //Đóng các control
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            //Đổ dữ liệu vào datagridview
            dgvData.DataSource = getUserTable();
            //Ẩn cột password
            dgvData.Columns[1].Visible = false;
            //usertype Manager chỉ được tạo Manager và User
            if (clsFormProvider.mainF.getUserType() == "Manager") {
                cboUserType.Items.Clear();
                cboUserType.Items.Add("Manager");
                cboUserType.Items.Add("User");
            }
        }

        //Lấy dữ liệu bảng User
        public DataTable getUserTable() {
            try { con.Close(); } catch (Exception ex) { MessageBox.Show(ex.Message); }
            try { con.Open(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            SqlCommand cmd = new SqlCommand("SP_LAYDSUSER", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            try { con.Close(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return dt;
        }

        /// <summary>
        /// Chức năng thoát
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Chức năng thêm mới user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != "" && txtUserPass.Text != "" && cboUserType.Text != "")
            {
                try
                {
                    con.Open();//mở kết nối
                    SqlCommand cmd = new SqlCommand("SP_THEMDSUSER", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    //Truyền dữ liệu cho stored procedure
                    cmd.Parameters.Add(new SqlParameter("@U_NAME", txtUserName.Text));
                    cmd.Parameters.Add(new SqlParameter("@U_PASS", txtUserPass.Text));
                    cmd.Parameters.Add(new SqlParameter("@U_TYPE", cboUserType.Text));
                    if (cmd.ExecuteNonQuery() > 0)//SQL chạy thành công
                    {
                        //Thông báo thêm thành công
                        MessageBox.Show("User register successfull!!!");
                        //Xóa dữ liệu trong các control và đổ lại datagridview
                        txtUserName.Clear();
                        txtUserPass.Clear();
                        cboUserType.SelectedText = "";
                        dgvData.DataSource = getUserTable();
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
                //Thông báo không có dữ liệu trong các control để thêm user
                MessageBox.Show("The Username, Password or User type is blank. Not enough infomation to create a new user!!!");
            }
        }

        /// <summary>
        /// Chức năng update
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != "" && txtUserPass.Text != "")//thực hiện khi name và password không rỗng
            {
                try
                {
                    //Thông báo hỏi trước khi cập nhật
                    DialogResult result = MessageBox.Show("Are you sure you want to update this user info?", "Update confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        con.Open();//Mở kết nối
                        SqlCommand cmd = new SqlCommand("SP_SUAUSER", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        //Truyền dữ liệu cho stored procedure
                        cmd.Parameters.Add(new SqlParameter("@U_NAME", txtUserName.Text));
                        cmd.Parameters.Add(new SqlParameter("@U_PASS", txtUserPass.Text));
                        cmd.Parameters.Add(new SqlParameter("@U_TYPE", cboUserType.Text));
                        if (cmd.ExecuteNonQuery() > 0)//SQL chạy thành công
                        {
                            //Thông báo cập nhật thành công
                            MessageBox.Show("Update user successful!!!");
                        }
                        if (clsFormProvider.mainF.getUserName() == txtUserName.Text)
                        {
                            clsFormProvider.mainF.setUserType(cboUserType.Text);
                            if (clsFormProvider.mainF.getUserType() == "User")
                            {
                                MessageBox.Show("Your account do not have permission to use this function. The application will be restart!!!");
                                Application.Restart();
                            }
                        }
                        //Đổ lại dữ liệu vào datagridview và đóng mở các control
                        dgvData.DataSource = getUserTable();
                        txtUserName.Clear();
                        txtUserPass.Clear();
                        cboUserType.Text = "";
                        btnAddNew.Enabled = true;
                        txtUserName.Enabled = true;
                        btnUpdate.Enabled = false;
                        btnDelete.Enabled = false;
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
                //Thông báo thiếu dữ liệu cần thiết để cập nhật
                MessageBox.Show("The Username or Password is blank. User info can not be update!!!");
            }
        }
        /// <summary>
        /// Sự kiện khi nhấn trong datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Đóng mở các control
                btnUpdate.Enabled = true;
                btnAddNew.Enabled = false;
                txtUserName.Enabled = false;               
                btnDelete.Enabled = true;
                if (!dgvData.Rows[dgvData.CurrentCell.RowIndex].IsNewRow)
                {
                    //Đổ dữ liệu vào các control
                    if (dgvData.SelectedRows.Count > 0)
                    {
                        txtUserName.Text = dgvData.SelectedCells[0].Value.ToString();
                        txtUserPass.Text = dgvData.SelectedCells[1].Value.ToString();
                        if (clsFormProvider.mainF.getUserType() == "Manager" && dgvData.SelectedCells[2].Value.ToString() == "Admin")
                        {
                            btnUpdate.Enabled = false;
                            btnDelete.Enabled = false;
                        }
                        else {
                            cboUserType.Text = dgvData.SelectedCells[2].Value.ToString();
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
        /// Kiểm tra username đã có trong database chưa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtUserName_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtUserName.Text != "")//Thực hiện khi ô username trong rỗng
                {
                    con.Open();//Mở kết nối
                    SqlCommand cmd = new SqlCommand("sp_searchUserbyName", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@U_NAME", txtUserName.Text));
                    if ((string)cmd.ExecuteScalar() == txtUserName.Text)//Tìm thấy username trong database
                    {
                        //Thông báo đã có username trong database
                        MessageBox.Show("This Username is already used!!! Please try different Username!!!");
                        txtUserName.Clear();
                        txtUserName.Focus();
                    }
                    con.Close();//Đóng kết nối
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
        /// Chức năng clear trả trạng thái các control về ban đầu 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            btnAddNew.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            txtUserName.Enabled = true;
            txtUserName.Clear();
            txtUserPass.Clear();
            cboUserType.SelectedText = "";
        }

        /// <summary>
        /// Chức năng Delete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Thông báo hỏi trước khi xóa
            DialogResult result = MessageBox.Show("Are you sure you want to delete user?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes && txtUserName.Text != "")
            {
                try
                {
                    con.Open();//Mở kết nối
                    SqlCommand cmd = new SqlCommand("SP_XOAUSER", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@U_NAME", txtUserName.Text));
                    if (cmd.ExecuteNonQuery() > 0)//SQL chạy thành công
                    {
                        //Thông báo xóa thành công
                        MessageBox.Show("User deleted!!!");
                        txtUserName.Clear();
                        txtUserPass.Clear();
                        //Đổ lại dữ liệu vào datagridview và đóng mở các control
                        dgvData.DataSource = getUserTable();
                        btnUpdate.Enabled = false;
                        btnDelete.Enabled = false;
                        btnAddNew.Enabled = true;
                        txtUserName.Enabled = true;
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

        /// <summary>
        /// Chức năng tìm kiế
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();//Mở kết nối
                SqlCommand cmd = new SqlCommand("sp_searchUserbyName", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@U_NAME",txtSearchName.Text));
                //tìm thấy username trong database
                if ((string)cmd.ExecuteScalar() == txtSearchName.Text)
                {
                    //Đóng mở và đổ dữ liệu vào các control
                    btnAddNew.Enabled = false;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    txtUserName.Enabled = false;
                    DataTable dt = new DataTable();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    txtUserName.Text = dt.Rows[0]["USER_NAME"].ToString();
                    txtUserPass.Text = dt.Rows[0]["USER_PASS"].ToString();
                    cboUserType.Text = dt.Rows[0]["USER_TYPE"].ToString();
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

        private void UserInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close?", "Close Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
