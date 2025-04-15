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

namespace BaiTapTongHop1
{
    public partial class FormDangNhap : Form
    {
        String conStr = "Data Source=CHUNGLE\\SQLEXPRESS;Initial Catalog=ThuongMaiDienTu;Integrated Security=True";
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(conStr);
            try
            {
                conn.Open();
                Boolean isSuccess = false;
                while (true)
                {
                    SqlCommand cmd = new SqlCommand("select * from DangNhap", conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        if (reader["TenDangNhap"].ToString().Trim() == txtTenDN.Text && reader["MatKhau"].ToString().Trim() == txtMatKhau.Text)
                        {
                            MessageBox.Show("Đăng nhập thành công");
                            this.Close();
                            isSuccess = true;
                            break;
                        }
                    }
                    reader.Close();
                    if (isSuccess)
                    {
                        break;
                    }
                    MessageBox.Show("Đăng nhập thất bại");
                    txtTenDN.Clear();
                    txtMatKhau.Clear();
                    txtTenDN.Focus();
                    break;
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
 
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("bạn có muốn thoát không", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
