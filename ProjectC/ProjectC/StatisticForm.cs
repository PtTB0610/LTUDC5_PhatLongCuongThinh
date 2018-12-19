/*
Name: Đinh Hưng Thịnh
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
        //Tạo đường dẫn kết nối SQL
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

        /// <summary>
        /// Sự kiện khi đóng Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StatisticForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Sự kiện Form Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                        txtEMPLOYEEID.Text = dgvStatis.SelectedCells[4].Value.ToString();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtSTATISTIC_BILL.Text != "" && txtSTATISTIC_EMPLOYEE.Text != "" && txtSTATISTIC_ID.Text != "" && txtSTATISTIC_PRICE.Text != "" && txtEMPLOYEEID.Text != "")//Kiểm trả rỗng textbox ID và Name của Product trước khi thêm
            {
                try
                {
                    con.Open();//Mở kết nối
                    SqlCommand cmd = new SqlCommand("sp_ThemThongKe", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    //Truyền dữ liệu cho store procedure
                    cmd.Parameters.Add(new SqlParameter("@statistic_id", txtSTATISTIC_ID.Text));
                    cmd.Parameters.Add(new SqlParameter("@statistic_employee", txtSTATISTIC_EMPLOYEE.Text));
                    cmd.Parameters.Add(new SqlParameter("@statistic_bill", txtSTATISTIC_BILL.Text));
                    cmd.Parameters.Add(new SqlParameter("@statistic_price", txtSTATISTIC_PRICE.Text));
                    cmd.Parameters.Add(new SqlParameter("@employee_id", txtEMPLOYEEID.Text));
                    if (cmd.ExecuteNonQuery() > 0)//SQL chạy thành công 
                    {
                        MessageBox.Show("Thêm Thành Công!");//Thông báo thêm thành công
                        //Đặt lại giá trị torng các control về rỗng
                        txtSTATISTIC_ID.Clear();
                        txtSTATISTIC_EMPLOYEE.Clear();
                        txtSTATISTIC_BILL.Clear();
                        txtSTATISTIC_PRICE.Clear();
                        txtEMPLOYEEID.Clear();                        
                        
                    }
                    con.Close();//Đóng kết nối
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);//Thông báo lỗi
                    con.Close();
                }
            }
            else
            {
                //Thông báo có 1 textbox đang rỗng không thể thêm mới được
                MessageBox.Show("Còn vị trí chưa được đầy thông tin! Kiểm tra lại!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa?", "Thông Báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //Kiểm tra ô ID 
                if (txtSTATISTIC_ID.Text != "")
                {
                    con.Open();//Mở kết nối
                    SqlCommand cmd = new SqlCommand("sp_XoaThongKe", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@statistic_id", txtSTATISTIC_ID.Text));
                    if (cmd.ExecuteNonQuery() > 0) //SQL chạy thành công
                    {
                        //Thông báo xóa thành công
                        MessageBox.Show("Xóa thành công!");
                        //Xóa dữ liệu trong các control
                        txtSTATISTIC_ID.Clear();
                        txtSTATISTIC_EMPLOYEE.Clear();
                        txtSTATISTIC_BILL.Clear();
                        txtSTATISTIC_PRICE.Clear();
                        txtEMPLOYEEID.Clear();                       
                        
                    }
                    con.Close();//Đóng kết nối
                }                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getStatisData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn cập nhật thông tin?", "Thông Báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (txtSTATISTIC_ID.Text != "")
                {
                    try
                    {
                        con.Open();//Mở kết nối
                        SqlCommand cmd = new SqlCommand("sp_SuaThongKe", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        //truyền dữ liệu cho stored procedure
                        cmd.Parameters.Add(new SqlParameter("@statistic_id", txtSTATISTIC_ID.Text));
                        cmd.Parameters.Add(new SqlParameter("@statistic_employee", txtSTATISTIC_EMPLOYEE.Text));
                        cmd.Parameters.Add(new SqlParameter("@statistic_bill", txtSTATISTIC_BILL.Text));
                        cmd.Parameters.Add(new SqlParameter("@statistic_price", txtSTATISTIC_PRICE.Text));
                        cmd.Parameters.Add(new SqlParameter("@employee_id", txtEMPLOYEEID.Text));
                        if (cmd.ExecuteNonQuery() > 0)//SQL chạy thành công
                        {
                            //Thông báo cập nhật sản phẩm thành công
                            MessageBox.Show("Cập nhật thành công!!!");
                            //Xóa dữ liệu trong các control
                            txtSTATISTIC_ID.Clear();
                            txtSTATISTIC_EMPLOYEE.Clear();
                            txtSTATISTIC_BILL.Clear();
                            txtSTATISTIC_PRICE.Clear();
                            txtEMPLOYEEID.Clear();                            
                        }
                        con.Close();//Đóng kết nối
                    }
                    catch (Exception ex)
                    {
                        //Thông báo lỗi
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    //Thông báo có 1 textbox đang rỗng không thể thêm mới được
                    MessageBox.Show("Còn vị trí chưa được đầy thông tin! Kiểm tra lại!");
                }
            }
        }
    }
}
