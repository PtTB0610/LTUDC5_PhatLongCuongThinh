﻿/*
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
    public partial class PAYMENT : Form
    {
        public PAYMENT()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Ket noi CSDL
        /// </summary>
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ElectronicSupermarket;Integrated Security=True");
        clsDatabase db = new clsDatabase();
        /// <summary>
        /// Tao Payment tren form addPayment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPayCreate_Click(object sender, EventArgs e)
        {
            addPayment addPay = new addPayment();
            addPay.Show();
        }
        /// <summary>
        /// Kiem Tra Phim Nhan Chi cho phep so va cho phep ki tu .
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPayDis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// Click chon du lieu 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (!dgvPay.Rows[dgvPay.CurrentCell.RowIndex].IsNewRow)
                {
                    if (dgvPay.SelectedRows.Count > 0)
                    {
                        txtPayID.Text = dgvPay.SelectedCells[0].Value.ToString();
                        txtPayName.Text = dgvPay.SelectedCells[1].Value.ToString();
                        txtPayDis.Text = dgvPay.SelectedCells[2].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Dong form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PAYMENT_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        /// <summary>
        /// Thoat form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Xoa phuong thuc payment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPayDel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want delete the Employee info?", "Delete Waning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_XoaPAYMENT", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@pay_id", txtPayID.Text));
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Payment delete successful!!");
                }
                con.Close();
            }
        }
        /// <summary>
        /// Lay Du lieu Payment
        /// </summary>
        public void getPayData()
        {
            try
            {
                con.Close();
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_getPAYMENT", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();
                dgvPay.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Cap Nhat payment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPayUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want update the Employee info?", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                con.Open();
                if (txtPayName.Text != "")
                {
                    try
                    {

                        SqlCommand cmd = new SqlCommand("sp_SuaPAYMENT", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@pay_id", txtPayID.Text));
                        cmd.Parameters.Add(new SqlParameter("@pay_name", txtPayName.Text));
                        cmd.Parameters.Add(new SqlParameter("@discount", txtPayDis.Text));
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
        /// Load Du lieu payment khi mo form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PAYMENT_Load(object sender, EventArgs e)
        {
            getPayData();
        }
        /// <summary>
        /// Click chon du lieu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (!dgvPay.Rows[dgvPay.CurrentCell.RowIndex].IsNewRow)
                {
                    if (dgvPay.SelectedRows.Count > 0)
                    {
                        txtPayID.Text = dgvPay.SelectedCells[0].Value.ToString();
                        txtPayName.Text = dgvPay.SelectedCells[1].Value.ToString();
                        txtPayDis.Text = dgvPay.SelectedCells[2].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Lay lai du lieu 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPayRef_Click(object sender, EventArgs e)
        {
            getPayData();
        }
    }
}
