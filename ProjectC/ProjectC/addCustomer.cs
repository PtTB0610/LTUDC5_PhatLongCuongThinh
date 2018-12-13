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
    public partial class addCustomer : Form
    {
        public addCustomer()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Tao CSDL
        /// </summary>
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ElectronicSupermarket;Integrated Security=True");
        clsDatabase db = new clsDatabase();

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
        /// Kiem Tra Phim Nhan Chi cho phep nhap chu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCusName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
        /// <summary>
        /// Tao Customer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            con.Open();
            if (txtCusID.Text != "" && txtCusName.Text != "")
            {
                try
                {
                    //Ket noi CSDL
                    SqlCommand cmd = new SqlCommand("sp_addCUSTOMER", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@cus_id", txtCusID.Text));
                    cmd.Parameters.Add(new SqlParameter("@cus_name", txtCusName.Text));
                    cmd.Parameters.Add(new SqlParameter("@cus_email", txtCusEmail.Text));
                    cmd.Parameters.Add(new SqlParameter("@cus_phone", txtCusPhone.Text));
                    cmd.Parameters.Add(new SqlParameter("@cus_date", dtbCus.Value));
                    cmd.Parameters.Add(new SqlParameter("@cus_address", txtCusAddress.Text));

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Add CUSTOMER successful");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Add CUSTOMER unsuccessful");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("CUSTOMER ID or CUSTOMER name is blank!!! Can not add new CUSTOMER!!!");
            }
            con.Close();
        }
    }
}
