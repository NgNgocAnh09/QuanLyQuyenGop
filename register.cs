using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuyenGop
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void btDKDK_Click(object sender, EventArgs e)
        {
            string username = tbTenDK.Text.Trim();
            string password = tbMatKhauDK.Text.Trim();
            string confirmPassword = tbXacNhanMK.Text.Trim();

            if (username == "" || password == "" || confirmPassword == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp.");
                return;
            }
            string connectionString = @"Data Source =.\SQLEXPRESS; Initial Catalog = BaiTapLonWinForm; Integrated Security = True"; 
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "INSERT INTO Admin (username, password) VALUES (@username, @password)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password); // nên mã hoá khi dùng thực tế

                try
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Đăng ký thành công!");
                        tbTenDK.Clear();
                        tbMatKhauDK.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Đăng ký thất bại!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối: " + ex.Message);
                }

            } 
        }

        

        private void btDNDK_Click_1(object sender, EventArgs e)
        {
            login loginForm = new login(); // tạo sẵn form Login
            loginForm.Show();
            this.Hide(); // hoặc this.Close(); nếu không muốn quay lại form này nữa
        }
    }
}
