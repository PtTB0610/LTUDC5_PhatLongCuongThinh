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
    public partial class EmployeeFORM : Form
    {
        public EmployeeFORM()
        {
            InitializeComponent();
        }

        private void EmployeeFORM_Load(object sender, EventArgs e)
        {
            getEmpData();
        }
        /// <summary>
        /// Ket noi Du lieu
        /// </summary>
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ElectronicSupermarket;Integrated Security=True");
        clsDatabase db = new clsDatabase();
        /// <summary>
        /// Lay Du lieu
        /// </summary>
        public void getEmpData()
        {
            try
            {
                con.Close();
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_LayDSNhanVien", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();
                dgvEmployee.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Click Du lieu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEmployee.SelectedCells.Count > 0)
            {
                txtEmpID.Text = dgvEmployee.SelectedCells[0].Value.ToString();
                txtEmpName.Text = dgvEmployee.SelectedCells[1].Value.ToString();
                txtEmpEmail.Text = dgvEmployee.SelectedCells[2].Value.ToString();
                txtEmpPhone.Text = dgvEmployee.SelectedCells[3].Value.ToString();
                dtBirth.Text = dgvEmployee.SelectedCells[4].Value.ToString();
                txtEmpAdd.Text = dgvEmployee.SelectedCells[5].Value.ToString();
            }
        }
        /// <summary>
        /// Kiem Tra Phim Nhan Chi cho phep nhap chu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtEmpName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtEmpPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// Tao Employee hien form add Employee
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEmpCreate_Click(object sender, EventArgs e)
        {
            addEmployee addEmp = new addEmployee();
            addEmp.Show();
        }
        /// <summary>
        /// Dong Form 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmployeeFORM_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        /// <summary>
        /// Lat lai du lieu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnrefresh_Click(object sender, EventArgs e)
        {
            getEmpData();
        }
        /// <summary>
        /// Tim Kiem Employee
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEmpSearch_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_searchEmployeeID", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@employee_id", txtEmpSearch.Text));
            if ((string)cmd.ExecuteScalar() == txtEmpSearch.Text)
            {
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                dgvEmployee.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Invalid product ID!");
                txtEmpSearch.Focus();
            }
            con.Close();
        }
        /// <summary>
        /// Cap Nhap lai Employee
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEmpUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want update the Employee info?", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                con.Open();
                if (txtEmpName.Text != "")
                {
                    try
                    {

                        SqlCommand cmd = new SqlCommand("sp_SuaThongTinNhanVien", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@employee_id", txtEmpID.Text));
                        cmd.Parameters.Add(new SqlParameter("@employee_name", txtEmpName.Text));
                        cmd.Parameters.Add(new SqlParameter("@employee_email", txtEmpEmail.Text));
                        cmd.Parameters.Add(new SqlParameter("@employee_phone", txtEmpPhone.Text));
                        cmd.Parameters.Add(new SqlParameter("@employee_date", dtBirth.Text));
                        cmd.Parameters.Add(new SqlParameter("@employee_address", txtEmpAdd));
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Employee updated successful!!!");
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
                    MessageBox.Show("Employee name is blank!!! Can not update Employee infomation!!!");
                }
            }
        }
        /// <summary>
        /// Xoa Employee
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEmpDel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want delete the Employee info?", "Delete Waning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_XoaNhanVien", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@employee_id", txtEmpID.Text));
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Employee delete successful!!");
                }
                con.Close();
            }
        }
        /// <summary>
        /// Thoat form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
