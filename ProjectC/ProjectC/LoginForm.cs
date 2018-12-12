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
        //Khai báo biến
        string userType;//loại user
        bool flag = false;//cờ kiểm trả
        /// <summary>
        /// Chức năng đăng nhập
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //kết nối db
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ElectronicSupermarket;Integrated Security=True");
            con.Open();//Mở kết nối
            SqlCommand cmd = new SqlCommand("sp_searchUserbyName", con);//Tạo SqlCommand, truyền Stored Procedure và đường dẫn database
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@U_NAME", txtUsername.Text));
            if (cmd.ExecuteScalar() != null/*Tìm thấy username trong database*/) {
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);//đổ dữ liệu vào DataTable
                con.Close();//Đóng kết nối
                //Kiểm tra dữ liệu nhập ở textbox có trùng với trong bảng đổ ra từ database
                if (dt.Rows[0]["USER_NAME"].ToString() == txtUsername.Text && dt.Rows[0]["USER_PASS"].ToString() == txtPassword.Text)
                {
                    this.Close();//Đóng Form Login
                    userType = (string)dt.Rows[0]["USER_TYPE"];
                    flag = true;//Tìm thấy và login được
                    clsFormProvider.mainF.setUserName((string)dt.Rows[0]["USER_NAME"]);//Lưu username
                    clsFormProvider.mainF.setUserPass((string)dt.Rows[0]["USER_PASS"]);//Lưu password
                    clsFormProvider.mainF.Show();//Mở MainForm
                }
            }
            if (!flag)//Không tìm thấy username trong database
            {
                //Xuất thông báo sai username hoặc password
                MessageBox.Show("Wrong username or password!!! Please reenter ", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Lấy usertype
        /// </summary>
        /// <returns>trả về chuỗi</returns>
        public string getUserType() {
            return userType;
        }

        /// <summary>
        /// Lấy cờ kiểm tra
        /// </summary>
        /// <returns>trả về true hoặc false</returns>
        public bool getFlag()
        {
            return flag;
        }

        /// <summary>
        /// Chức năng thoát
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExitLogin_Click(object sender, EventArgs e)
        {          
            //Thông báo xác nhận trước khi thoát
            DialogResult result = MessageBox.Show("Are you sure you want to exit the program?", "Exit Confirmation", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)//Người dùng chọn yes thoát chương trình
            {
                Application.Exit();
            }
        }
    }
}
