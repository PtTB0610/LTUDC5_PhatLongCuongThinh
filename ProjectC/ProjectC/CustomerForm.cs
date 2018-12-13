/*
Name: Le Nguyen Hoa Long
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

namespace ProjectC
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Ket noi CSDL
        /// </summary>
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ElectronicSupermarket;Integrated Security=True");
        clsDatabase db = new clsDatabase();
        /// <summary>
        /// Lay Du lieu
        /// </summary>
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
        /// <summary>
        /// Kiem Tra Phim Nhan Chi cho phep nhap Chu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCusName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
        /// <summary>
        /// Kiem Tra Phim Nhan Chi cho phep nhap so
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCusPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// Tao Customer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCusCreate_Click(object sender, EventArgs e)
        {
            addCustomer addCus = new addCustomer();
            addCus.Show();
        }
        /// <summary>
        /// Click du lieu hien tren form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Thoat form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        /// <summary>
        /// dong form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEmpCan_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Lay lai du lieu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCusRef_Click(object sender, EventArgs e)
        {
            getCusData();
        }
        /// <summary>
        /// Xoa du lieu Customer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Khi chay form load du lieu len dgv
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            getCusData();
        }
        /// <summary>
        /// Tim kiem customer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Cap nhat du lieu Customer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                        cmd.Parameters.Add(new SqlParameter("@cus_date", dtbCus.Value));
                        cmd.Parameters.Add(new SqlParameter("@cus_address", txtCusAddress.Text));
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

        private void dgvCus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
