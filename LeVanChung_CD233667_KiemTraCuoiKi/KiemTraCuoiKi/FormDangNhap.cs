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

namespace KiemTraCuoiKi
{
    public partial class FormDangNhap : Form
    {
        public string TenDangNhapShow{ get; set; }

        String conStr = "Data Source=CHUNGLE\\SQLEXPRESS;Initial Catalog=QuanLyNhaSach;Integrated Security=True";
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(conStr);
            try
            {
                conn.Open();
                Boolean isSuccess = false;

                SqlCommand cmd = new SqlCommand("SELECT * FROM NguoiDung", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["TenDangNhap"].ToString().Trim() == txtTenDangNhap.Text && reader["MatKhau"].ToString().Trim() == txtMatKhau.Text)
                    {
                        MessageBox.Show("Đăng nhập thành công");

                        this.TenDangNhapShow = txtTenDangNhap.Text.Trim();
                        this.DialogResult = DialogResult.OK;

                        isSuccess = true;
                        break;
                    }
                }
                reader.Close();

                if (!isSuccess)
                {
                    MessageBox.Show("Đăng nhập thất bại");
                    txtTenDangNhap.Clear();
                    txtMatKhau.Clear();
                    txtTenDangNhap.Focus();
                }
                else
                {
                    this.Close();
                }
            }
            catch (Exception ex)
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
