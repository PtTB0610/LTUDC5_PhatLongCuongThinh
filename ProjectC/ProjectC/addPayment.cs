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
    public partial class addPayment : Form
    {
        public addPayment()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {}

        private void addPayment_Load(object sender, EventArgs e)
        {}

        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ElectronicSupermarket;Integrated Security=True");
        clsDatabase db = new clsDatabase();

        private void txtPayID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnPayCreate_Click(object sender, EventArgs e)
        {
            if (txtPayName.Text != "")
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_addPAYMENT", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@pay_id", txtPayID.Text));
                    cmd.Parameters.Add(new SqlParameter("@pay_name", txtPayName.Text));
                    cmd.Parameters.Add(new SqlParameter("@discount", txtPayDis.Text));
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
                MessageBox.Show("Cant Create new Payment!!!");
            }
        }
    }
}
