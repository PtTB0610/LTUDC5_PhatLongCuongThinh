/*
Name: Nguyen Tuan Cuong
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
    public partial class BillForm : Form
    {
        public BillForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Ket noi CSDL
        /// </summary>
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ElectronicSupermarket;Integrated Security=True");
        clsDatabase db = new clsDatabase();
        /// <summary>
        /// Lay du lieu tu sql
        /// </summary>
        public void getBillData()
        {
            try
            {
                con.Close();
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_LayDSBILL", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();
                dgvBill.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Hien Du lieu tren form khi mo form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BillForm_Load(object sender, EventArgs e)
        {
            getBillData();
        }
        
        private void txtTimMaHoaDon_TextChanged(object sender, EventArgs e)
        {}
        /// <summary>
        /// Kiem Tra Phim Nhan Chi cho phep nhap So
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = true;
            //}
        }
        /// <summary>
        /// Kiem Tra Phim Nhan Chi cho phep nhap chu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTenKhach_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
        /// <summary>
        /// Kiem Tra Phim Nhan Chi cho phep nhap chu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTenNhanVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtTenHang_TextChanged(object sender, EventArgs e)
        {}
        
        private void txtMaHoaDon_KeyPress(object sender, KeyPressEventArgs e)
        {
           // e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        /// <summary>
        /// Click lay du lieu form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvBill.SelectedRows.Count > 0)
                {
                    txtMaHoaDon.Text = dgvBill.SelectedCells[0].Value.ToString();
                    dtgDate.Text = dgvBill.SelectedCells[1].Value.ToString();
                    txtMaKhachHang.Text = dgvBill.SelectedCells[2].Value.ToString();
                    txtMaHang.Text = dgvBill.SelectedCells[3].Value.ToString();
                    txtMaNhanVien.Text = dgvBill.SelectedCells[4].Value.ToString();
                    txtMaThanhToan.Text = dgvBill.SelectedCells[5].Value.ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Dong form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BillForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHuyHoaDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        { }

        private void label3_Click(object sender, EventArgs e)
        { }

        private void dgvBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {         }
        /// <summary>
        /// Tao Bill tren form addBill
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            addBill addBill = new addBill();
            addBill.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            getBillData();
        }
        /// <summary>
        /// Xoa Bill
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want delete the Bill info?", "Delete Waning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_XoaDSBILL", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@billID", txtMaHoaDon.Text));
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Bill delete successful!!");
                }
                con.Close();
            }
        }

        private void txtMaHoaDon_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
