using System.Data.SqlClient;

namespace KiemTraCuoiKi
{
    public partial class Form1 : Form
    {
        public String TenDangNhap { get; set; }

        String conStr = "Data Source=CHUNGLE\\SQLEXPRESS;Initial Catalog=QuanLyNhaSach;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
            FormDangNhap formDangNhap = new FormDangNhap();
            if (formDangNhap.ShowDialog() == DialogResult.OK)
            {
                this.TenDangNhap = formDangNhap.TenDangNhapShow;
            }
            else
            {
                Application.Exit();
            }
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            tssTaiKhoan.Text = "Người Dùng: " + "'" + TenDangNhap + "' " + " - ";
            loadTongSoLuongSach();
            
        }

        private void danhSáchSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDanhSachSachcs formDanhSach = new FormDanhSachSachcs();
            formDanhSach.MdiParent = this;
            formDanhSach.Show();
        }

        private void báoCáoSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBaoCao formBaoCao = new FormBaoCao();
            formBaoCao.MdiParent = this;
            formBaoCao.Show();
        }

        private void loadTongSoLuongSach()
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT SUM(SoLuong) FROM Sach";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    object result = cmd.ExecuteScalar();

                    int tongSoLuong = (result != DBNull.Value) ? Convert.ToInt32(result) : 0;

                    tssSoLuong.Text = "Tổng số lượng sách: " + tongSoLuong;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tính tổng số lượng sách: " + ex.Message);
                }
            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


    }
}
