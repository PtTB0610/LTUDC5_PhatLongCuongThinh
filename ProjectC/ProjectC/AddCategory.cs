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
    public partial class AddCategory : Form
    {
        public AddCategory()
        {
            InitializeComponent();
        }
        //Đường dẫn database
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ElectronicSupermarket;Integrated Security=True");
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Lấy dữ liệu từ database
        private void getCateData() {
            try
            {
                con.Close();
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_LAYTATCACATEGORY", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgvData.DataSource = dt;
                dgvData.Columns[2].Visible = false;
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
        //Load Form
        private void AddCategory_Load(object sender, EventArgs e)
        {
            getCateData();
            if (clsFormProvider.mainF.getUserType() == "User") {
                label3.Visible = false;
                cboCateStatus.Visible = false;
            }
        }
        //Sự kiện khi nhấn vào 1 ô trong Datagridview
        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
            txtCateID.Enabled = false;
            if (dgvData.SelectedRows.Count > 0) {
                txtCateID.Text = dgvData.SelectedCells[0].Value.ToString();
                txtCateName.Text = dgvData.SelectedCells[1].Value.ToString();
                cboCateStatus.Text = dgvData.SelectedCells[2].Value.ToString();
            }
        }
        //Trả form về trạng thái khi load lần đầu
        private void btnClear_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            txtCateID.Enabled = true;
            txtCateID.Clear();
            txtCateName.Clear();
            txtSearchID.Clear();
            cboCateStatus.Text = "";
        }
        //Kiểm trả ID đã có trong database chưa
        private void txtCateID_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtCateID.Text != "")
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_searchCatebyID", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@C_ID", txtCateID.Text));
                    if (cmd.ExecuteScalar() != null && (int)cmd.ExecuteScalar() == Convert.ToInt32(txtCateID.Text))
                    {
                        MessageBox.Show("This ID is already used!!! Please provide a different ID!!!");
                        txtCateID.Clear();
                        txtCateID.Focus();
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
        //Sự kiện khi tìm kiếm
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchID.Text != "")
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_searchCatebyID", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@C_ID", txtSearchID.Text));
                    if (cmd.ExecuteScalar() != null && (int)cmd.ExecuteScalar() == Convert.ToInt32(txtSearchID.Text))
                    {
                        DataTable dt = new DataTable();
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        sda.Fill(dt);
                        txtCateID.Text = dt.Rows[0]["CATEGORY_ID"].ToString();
                        txtCateName.Text = dt.Rows[0]["CATEGORY_NAME"].ToString();
                        cboCateStatus.Text = dt.Rows[0]["CATEGORY_STATUS"].ToString();
                        btnAdd.Enabled = false;
                        txtCateID.Enabled = false;
                        btnUpdate.Enabled = true;
                        txtSearchID.Clear();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want update the category?", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SP_SUACATEGORY", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@C_ID", txtCateID.Text));
                    cmd.Parameters.Add(new SqlParameter("@C_NAME", txtCateName.Text));
                    cmd.Parameters.Add(new SqlParameter("@C_STATUS", cboCateStatus.Text));
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Product update successful!!!");
                        txtCateID.Clear();
                        txtCateName.Clear();
                        cboCateStatus.SelectedText = "";
                        btnAdd.Enabled = true;
                        txtCateID.Enabled = true;
                        btnUpdate.Enabled = false;
                        getCateData();
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

        private void txtCateName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '\b' || e.KeyChar == ' '))
            {
                e.Handled = true;
            }
        }

        private void txtCateID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_THEMCATEGORY", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@C_ID",txtCateID.Text));
                cmd.Parameters.Add(new SqlParameter("@C_NAME",txtCateName.Text));
                cmd.Parameters.Add(new SqlParameter("@C_STATUS",cboCateStatus.Text));
                if (cmd.ExecuteNonQuery() > 0) {
                    MessageBox.Show("Category added successful!!!");
                    txtCateID.Clear();
                    txtCateName.Clear();
                    cboCateStatus.Text = "";
                    getCateData();
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
}
