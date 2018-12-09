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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ElectronicSupermarket;Integrated Security=True");
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != "" && txtUserPass.Text != "")
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SP_THEMDSUSER", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@U_NAME", txtUserName.Text));
                    cmd.Parameters.Add(new SqlParameter("@U_PASS", txtUserPass.Text));
                    cmd.Parameters.Add(new SqlParameter("@U_TYPE", cboUserType.Text));
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("User register successfull!!!");
                        txtUserName.Clear();
                        txtUserPass.Clear();
                        cboUserType.SelectedText = "";
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
            else {
                MessageBox.Show("The Username or Password is blank. Not enough infomation to create a new user!!!");
            }
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtUserName.Text != "")
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_searchUserbyName", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@U_NAME", txtUserName.Text));
                    if ((string)cmd.ExecuteScalar() == txtUserName.Text)
                    {
                        MessageBox.Show("This Username is already used!!! Please try different Username!!!");
                        txtUserName.Clear();
                        txtUserName.Focus();
                    }
                    con.Close();
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

        private void UserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
