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
    public partial class FormBaoCao : Form
    {
        String conStr = "Data Source=CHUNGLE\\SQLEXPRESS;Initial Catalog=QuanLyNhaSach;Integrated Security=True";
        public FormBaoCao()
        {
            InitializeComponent();
        }

        private void FormBaoCao_Load(object sender, EventArgs e)
        {
            loadBaoCao();
        }
        private void loadBaoCao()
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                try
                {
                    conn.Open();

                    string query = @"SELECT s.Id, s.TenSach, s.Gia, s.SoLuong, s.MoTa, t.TenTheLoai
                             FROM Sach s
                             INNER JOIN TheLoai t ON s.TheLoaiId = t.Id
                             ORDER BY s.Gia DESC";

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
