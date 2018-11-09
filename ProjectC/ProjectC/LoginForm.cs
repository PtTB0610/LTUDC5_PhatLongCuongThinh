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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        string userType;
        bool flag = false;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=ElectronicSupermarket;Integrated Security=True");
            //SqlDataAdapter sda = new SqlDataAdapter("SELECT usertype FROM WHERE username = '" + txtUsername.Text + "' and password = '" + txtPassword.Text + "'", con);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            SqlCommand cmd = new SqlCommand("SELECT * FROM [USER] WHERE USER_NAME = '" + txtUsername.Text + "' and USER_PASS = '" + txtPassword.Text + "'", con);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read() == true)
            {
                this.Close();
                userType = (string)sdr["USER_TYPE"];
                flag = true;
                clsFormProvider.mainF.Show();
                //this.Hide();
                //MainForm mF = new MainForm((string)sdr["user_type"]);
                //mF.Show(this);
            }
            else MessageBox.Show("Wrong username or password!!! Please reenter ", "Login error", MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        public string getUserType() {
            return userType;
        }

        public bool getFlag()
        {
            return flag;
        }
        private void btnExitLogin_Click(object sender, EventArgs e)
        {            
            DialogResult result = MessageBox.Show("Are you sure you want to exit the program?", "Exit Confirmation", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                //this.Close();
                Application.Exit();
            }
        }
    }
}
