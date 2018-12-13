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
    public partial class addBill : Form
    {
        public addBill()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Ket noi CSDL
        /// </summary>
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ElectronicSupermarket;Integrated Security=True");
        clsDatabase db = new clsDatabase();

        //Lấy dữ liệu của bảng Customer
        private DataTable getCustomerTable()
        {
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_getDSCUSTOMER", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            return dt;
        }

        //Lấy dữ liệu của bảng Employee
        private DataTable getEmployeeTable()
        {
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_LayDSNhanVien", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            return dt;
        }

        //Lấy dữ liệu của bảng Payment
        private DataTable getPaymentTable()
        {
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_getPAYMENT", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            return dt;
        }

        //Lấy dữ liệu của bảng Product
        private DataTable getProductTable()
        {
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("SP_LAYTATCAPRODUCT", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            return dt;
        }

        private void addBill_Load(object sender, EventArgs e)
        {
            //đổ dữ liệu vào combo box customer id
            cboCusID.DataSource = getCustomerTable();
            cboCusID.DisplayMember = "CUSTOMER_ID";
            cboCusID.ValueMember = "CUSTOMER_ID";
            //đổ dữ liệu vào combo box employee id
            cboEmpID.DataSource = getEmployeeTable();
            cboEmpID.DisplayMember = "EMPLOYEE_ID";
            cboEmpID.ValueMember = "EMPLOYEE_ID";
            //đổ dữ liệu vào combo box payment id
            cboPayID.DataSource = getPaymentTable();
            cboPayID.DisplayMember = "PAYMENT_ID";
            cboPayID.ValueMember = "PAYMENT_ID";
            //đổ dữ liệu vào combo box product id
            cboProdID.DataSource = getProductTable();
            cboProdID.DisplayMember = "PRODUCT_ID";
            cboProdID.ValueMember = "PRODUCT_ID";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Tao Bill
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtMaHoaDon.Text != "")
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_ThemDSBILL", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@billID", txtMaHoaDon.Text));
                    cmd.Parameters.Add(new SqlParameter("@billDATE", dtgDate.Value));
                    cmd.Parameters.Add(new SqlParameter("@cusID", cboCusID.Text));
                    cmd.Parameters.Add(new SqlParameter("@proID", cboProdID.Text));
                    cmd.Parameters.Add(new SqlParameter("@empID", cboEmpID.Text));
                    cmd.Parameters.Add(new SqlParameter("@payMethod", cboPayID.Text));
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Successfull!!!");
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
            else
            {
                MessageBox.Show("Cant Create new Bill!!!");
            }
        }
    }
}
