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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ElectronicSupermarket;Integrated Security=True");
        clsDatabase db = new clsDatabase();

        public void getCusData()
        {
            try
            {
                con.Close();
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_getDSCUSTOMER", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();
                dgvCus.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtCusName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtCusPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCusCreate_Click(object sender, EventArgs e)
        {
            addCustomer addCus = new addCustomer();
            addCus.Show();
        }

        private void dgvCus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCus.SelectedRows.Count > 0)
            {
                txtCusID.Text = dgvCus.SelectedCells[0].Value.ToString();
                txtCusName.Text = dgvCus.SelectedCells[1].Value.ToString();
                txtCusEmail.Text = dgvCus.SelectedCells[2].Value.ToString();
                txtCusPhone.Text = dgvCus.SelectedCells[3].Value.ToString();
                dtbCus.Text = dgvCus.SelectedCells[4].Value.ToString();
                txtCusAddress.Text = dgvCus.SelectedCells[5].Value.ToString();
            }
        }

        private void CustomerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnEmpCan_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCusRef_Click(object sender, EventArgs e)
        {
            getCusData();
        }

        private void btnCusDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want delete the Customer info?", "Delete Waning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_XoaCustomer", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@cus_id", txtCusID.Text));
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Customer delete successful!!");
                }
                con.Close();
            }
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            getCusData();
        }

        private void btnCusSearch_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_searchCustomerID", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@cus_id", txtCusSearch.Text));
            if ((string)cmd.ExecuteScalar() == txtCusSearch.Text)
            {
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                dgvCus.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Invalid product ID!");
                txtCusSearch.Focus();
            }
            con.Close();
        }

        private void btnCusUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want update the product info?", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                con.Open();
                if (txtCusName.Text != "" || txtCusID.Text != "")
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("sp_SuaCustomer", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@cus_id", txtCusID.Text));
                        cmd.Parameters.Add(new SqlParameter("@cus_name", txtCusName.Text));
                        cmd.Parameters.Add(new SqlParameter("@cus_email", txtCusEmail.Text));
                        cmd.Parameters.Add(new SqlParameter("@cus_phone", txtCusPhone.Text));
                        cmd.Parameters.Add(new SqlParameter("@cus_date", dtbCus.Text));
                        cmd.Parameters.Add(new SqlParameter("@cus_address", txtCusAddress));
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Customer updated successful!!!");
                            con.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Customer name is blank!!! Can not update customer infomation!!!");
                }
            }
        }
    }
}
