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
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ElectronicSupermarket;Integrated Security=True");
        private void SupplierForm_Load(object sender, EventArgs e)
        {
            getSupplierData();
            dgvData.Columns[5].Visible = false;
        }

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

        private void txtSupplierID_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtSupplierID.Text != "")
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_searchSupplierbyID", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@S_ID", txtSupplierID.Text));
                    if (cmd.ExecuteScalar() != null && (int)cmd.ExecuteScalar() == Convert.ToInt32(txtSupplierID.Text))
                    {
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

        private void txtSupName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '\b' || e.KeyChar == ' '))
            {
                e.Handled = true;
            }
        }

        private void txtSupName_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtSupName.Text != "")
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_searchSupplierbyName", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@S_NAME", txtSupName.Text));
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read()) {
                        if (txtSupName.Text == reader["SUPPLIER_NAME"].ToString())
                        {
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

        private void txtSearchID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '\b'))
            {
                e.Handled = true;
            }
        }

        private void txtSupPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '\b'))
            {
                e.Handled = true;
            }
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAddNew.Enabled = false;
            txtSupplierID.Enabled = false;
            btnUpdate.Enabled = true;
            txtSearchID.Clear();
            if (dgvData.SelectedRows.Count > 0) {
                txtSupplierID.Text = dgvData.SelectedCells[0].Value.ToString();
                txtSupName.Text = dgvData.SelectedCells[1].Value.ToString();
                txtSupAddress.Text = dgvData.SelectedCells[2].Value.ToString();
                txtSupPhone.Text = dgvData.SelectedCells[3].Value.ToString();
                txtSupEmail.Text = dgvData.SelectedCells[4].Value.ToString();
                cboSubStatus.Text = dgvData.SelectedCells[5].Value.ToString();
            }
        }

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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtSupplierID.Clear();
            txtSupName.Clear();
            txtSupAddress.Clear();
            txtSupPhone.Clear();
            txtSupEmail.Clear();
            cboSubStatus.Text = "";
            try
            {
                if (txtSearchID.Text != "")
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_searchSupplierbyID", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@S_ID", txtSearchID.Text));
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
                        txtSupplierID.Enabled = false;
                        btnAddNew.Enabled = false;
                        btnUpdate.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Invalid Supplier ID!!!");
                    }
                }
                else {
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

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (txtSupplierID.Text != "" && txtSupName.Text != "" && cboSubStatus.Text != "")
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SP_THEMSUPPLIER", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@S_ID", txtSupplierID.Text));
                    cmd.Parameters.Add(new SqlParameter("@S_NAME", txtSupName.Text));
                    cmd.Parameters.Add(new SqlParameter("@S_PHONE", txtSupPhone.Text));
                    cmd.Parameters.Add(new SqlParameter("@S_EMAIL", txtSupEmail.Text));
                    cmd.Parameters.Add(new SqlParameter("@S_ADDRESS", txtSupAddress.Text));
                    cmd.Parameters.Add(new SqlParameter("@S_STATUS", cboSubStatus.Text));
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Supplier added successful!!!");
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
                MessageBox.Show("Supplier ID, Supplier name or Supplier status is blank!!! Please check again!!!");
            }
        }
    }
}
