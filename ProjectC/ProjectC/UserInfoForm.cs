using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjectC
{
    public partial class UserInfoForm : Form
    {
        public UserInfoForm()
        {
            InitializeComponent();
        }

        //private void UserInfoForm_Load(object sender, EventArgs e)
        //{
        //    SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ElectronicSupermarket;Integrated Security=True");
        //    SqlDataAdapter sda = new SqlDataAdapter("SP_TIMUSERBANGID '" + labelUserID.Text + "'", con);
        //    DataTable dt = new DataTable();
        //    sda.Fill(dt);
        //    DataRow dr = dt.Rows[0];
        //    txtUserName.Text = (string)dr["USER_NAME"];
        //    txtUserPass.Text = (string)dr["USER_PASS"];
        //    txtStatus.Text = (string)dr["USER_STATUS"];
        //    txtUserType.Text = (string)dr["USER_TYPE"];
        //}
    }
}
