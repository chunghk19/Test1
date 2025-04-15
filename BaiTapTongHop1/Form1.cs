using System.Data.SqlClient;
namespace BaiTapTongHop1
{
    public partial class Form1 : Form
    {
        String conStr = "Data Source=CHUNGLE\\SQLEXPRESS;Initial Catalog=ThuongMaiDienTu;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
            FormDangNhap formDangNhap = new FormDangNhap();
            formDangNhap.ShowDialog();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void danhSáchKhácHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDSKH formDSKH = new FormDSKH();
            formDSKH.MdiParent = this;
            formDSKH.Show();

        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBaoCao formBaoCao = new FormBaoCao();
            formBaoCao.MdiParent = this;
            formBaoCao.Show();
        }

        //private void btnThoat_Click(object sender, EventArgs e)
        //{
        //    DialogResult rs = MessageBox.Show("bạn có muốn thoát không", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //    if (rs == DialogResult.Yes)
        //    {
        //        Application.Exit();
        //    }
        //}

        //private void btnDangNhap_Click(object sender, EventArgs e)
        //{
        //    SqlConnection conn = new SqlConnection(conStr);
        //    conn.Open();
        //    Boolean isSuccess = false;
        //    while (true)
        //    {
        //        SqlCommand cmd = new SqlCommand("select * from dangnhap", conn);
        //        SqlDataReader reader = cmd.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            if (reader["TenDangNhap"].ToString().Trim() == txtTenDangNhap.Text && reader["MatKhau"].ToString().Trim() == txtMatKhau.Text)
        //            {
        //                MessageBox.Show("Đăng nhập thành công");
        //                this.Close();
        //                isSuccess = true;
        //                break;
        //            }
        //        }
        //        reader.Close();
        //        if (isSuccess) { break; }
        //        MessageBox.Show("Đăng nhập thất bại");
        //        txtTenDangNhap.Clear();
        //        txtMatKhau.Clear();
        //        txtTenDangNhap.Focus();
        //        break;
        //    }
        //    conn.Close();

        //}
    }
}
