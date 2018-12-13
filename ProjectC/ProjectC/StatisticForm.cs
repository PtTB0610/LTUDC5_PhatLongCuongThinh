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
    public partial class StatisticForm : Form
    {
        public StatisticForm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ElectronicSupermarket;Integrated Security=True");
        clsDatabase db = new clsDatabase();

        public void getStatisData()
        {
            try
            {
                con.Close();
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_LayDSThongKe", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();
                dgvStatis.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {}

        private void txtSTATISTIC_PRICE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void StatisticForm_Load(object sender, EventArgs e)
        {
            getStatisData();
        }

        private void StatisticForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void dgvStatis_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (!dgvStatis.Rows[dgvStatis.CurrentCell.RowIndex].IsNewRow)
                {
                    if (dgvStatis.SelectedRows.Count > 0)
                    {
                        txtSTATISTIC_ID.Text = dgvStatis.SelectedCells[0].Value.ToString();
                        txtSTATISTIC_EMPLOYEE.Text = dgvStatis.SelectedCells[1].Value.ToString();
                        txtSTATISTIC_BILL.Text = dgvStatis.SelectedCells[2].Value.ToString();
                        txtSTATISTIC_PRICE.Text = dgvStatis.SelectedCells[3].Value.ToString();
                        USER_ID.Text = dgvStatis.SelectedCells[4].Value.ToString();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
