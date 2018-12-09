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

        clsDatabase db = new clsDatabase();
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ElectronicSupermarket;Integrated Security=True");
        private void UserInfoForm_Load(object sender, EventArgs e)
        {
            dgvData.DataSource = getUserTable();
            dgvData.Columns[1].Visible = false;
            if (clsFormProvider.mainF.getUserType() == "Manager") {
                cboUserType.Items.Clear();
                cboUserType.Items.Add("Manager");
                cboUserType.Items.Add("User");
            }
        }

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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != "" && txtUserPass.Text != "")
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SP_THEMDSUSER", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@U_NAME", txtUserName.Text));
                    cmd.Parameters.Add(new SqlParameter("@U_PASS", txtUserPass.Text));
                    cmd.Parameters.Add(new SqlParameter("@U_TYPE", cboUserType.Text));
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("User register successfull!!!");
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
                MessageBox.Show("The Username or Password is blank. Not enough infomation to create a new user!!!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != "" && txtUserPass.Text != "")
            {
                try
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to update this user info?", "Update confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("SP_SUAUSER", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@U_NAME", txtUserName.Text));
                        cmd.Parameters.Add(new SqlParameter("@U_PASS", txtUserPass.Text));
                        cmd.Parameters.Add(new SqlParameter("@U_TYPE", cboUserType.Text));
                        if (cmd.ExecuteNonQuery() > 0)
                        {
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
                        dgvData.DataSource = getUserTable();
                        txtUserName.Clear();
                        txtUserPass.Clear();
                        cboUserType.Text = "";
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
            else {
                MessageBox.Show("The Username or Password is blank. User info can not be update!!!");
            }
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnAddNew.Enabled = false;
                txtUserName.Enabled = false;
                if (!dgvData.Rows[dgvData.CurrentCell.RowIndex].IsNewRow)
                {
                    if (dgvData.SelectedRows.Count > 0)
                    {
                        txtUserName.Text = dgvData.SelectedCells[0].Value.ToString();
                        txtUserPass.Text = dgvData.SelectedCells[1].Value.ToString();
                        cboUserType.Text = dgvData.SelectedCells[2].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtUserName.Text != "")
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_searchUserbyName", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@U_NAME", txtUserName.Text));
                    if ((string)cmd.ExecuteScalar() == txtUserName.Text)
                    {
                        MessageBox.Show("This Username is already used!!! Please try different Username!!!");
                        txtUserName.Clear();
                        txtUserName.Focus();
                    }
                    con.Close();
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            btnAddNew.Enabled = true;
            txtUserName.Enabled = true;
            txtUserName.Clear();
            txtUserPass.Clear();
            cboUserType.SelectedText = "";
        }
    }
}
