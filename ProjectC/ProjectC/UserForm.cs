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
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtUserPass.Text != "")
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SP_SUAUSER", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@U_NAME", txtUserName.Text));
                    cmd.Parameters.Add(new SqlParameter("@U_PASS", txtUserPass.Text));
                    cmd.Parameters.Add(new SqlParameter("@U_TYPE", clsFormProvider.mainF.getUserType()));
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Account password update successfull!!!");
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
                MessageBox.Show("The Password is blank. Not enough infomation to update!!!");
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

        private void UserForm_Load(object sender, EventArgs e)
        {
            txtUserName.Text = clsFormProvider.mainF.getUserName();
            txtUserPass.Text = clsFormProvider.mainF.getUserPass();
            txtUserName.Enabled = false;
        }
    }
}
