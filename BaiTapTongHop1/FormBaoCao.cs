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
    public partial class FormBaoCao : Form
    {
        string conStr = "Data Source=CHUNGLE\\SQLEXPRESS;Initial Catalog=ThuongMaiDienTu;Integrated Security=True";
        public FormBaoCao()
        {
            InitializeComponent();
            LoadBaoCao();
        }

        private void FormBaoCao_Load(object sender, EventArgs e)
        {

        }
        private void LoadBaoCao()
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                try
                {
                    conn.Open();

                    string query = @"
                            SELECT 
                            kh.Id, 
                            kh.HoVaTen, 
                            kh.NgaySinh,
                            DATEDIFF(YEAR, kh.NgaySinh, GETDATE()) AS Tuoi,
                            kh.SoDienThoai,
                            kh.DiaChi,
                            lkh.TenLoaiKhachHang
                            FROM KhachHang kh
                            LEFT JOIN LoaiKhachHang lkh ON kh.LoaiKhachHang = lkh.Id
                            ORDER BY DATEDIFF(YEAR, kh.NgaySinh, GETDATE()) DESC";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvBaoCao.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải báo cáo: " + ex.Message);
                }
            }
        }
    
}
}
