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
        //Tạo đường dẫn database
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ElectronicSupermarket;Integrated Security=True");

        /// <summary>
        /// Chức năng Update
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtUserPass.Text != "")//Thực hiện khi ô password không rỗng
            {
                try
                {
                    con.Open();//Mở kết nối
                    SqlCommand cmd = new SqlCommand("SP_SUAUSER", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    //Truyền dữ liệu cho stored procedure
                    cmd.Parameters.Add(new SqlParameter("@U_NAME", txtUserName.Text));
                    cmd.Parameters.Add(new SqlParameter("@U_PASS", txtUserPass.Text));
                    cmd.Parameters.Add(new SqlParameter("@U_TYPE", clsFormProvider.mainF.getUserType()));
                    if (cmd.ExecuteNonQuery() > 0)//SQL chạy thành công
                    {
                        //Thông báo cập nhật password thành công
                        MessageBox.Show("Account password update successfull!!!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();//Đóng kết nối
                }
            }
            else {
                //Thông báo ô password rỗng không cập nhật được
                MessageBox.Show("The Password is blank. Not enough infomation to update!!!");
            }
        }
        /// <summary>
        /// Thông báo khi đóng form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close account info?", "Close Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Load form lần đầu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserForm_Load(object sender, EventArgs e)
        {
            //Đổ dữ liệu vào các control và đóng ô username
            txtUserName.Text = clsFormProvider.mainF.getUserName();
            txtUserPass.Text = clsFormProvider.mainF.getUserPass();
            txtUserName.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
