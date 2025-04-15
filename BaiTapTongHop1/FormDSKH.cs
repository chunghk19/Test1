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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace BaiTapTongHop1
{
    public partial class FormDSKH : Form
    {
        String conStr = "Data Source=CHUNGLE\\SQLEXPRESS;Initial Catalog=ThuongMaiDienTu;Integrated Security=True";
        public FormDSKH()
        {
            InitializeComponent();
            loadLoaiKhachHang();
        }

        private void FormDSKH_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        public void loaddata()
        {
            SqlConnection conn = new SqlConnection(conStr);
            try
            {
                conn.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(@"SELECT kh.Id, kh.HoVaTen, kh.SoDienThoai, kh.DiaChi, kh.NgaySinh, lkh.TenLoaiKhachHang
                                                  FROM KhachHang kh LEFT JOIN LoaiKhachHang lkh ON kh.LoaiKhachHang = lkh.Id", conn);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
                dgvKhachHang.DataSource = dt;
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

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(conStr);
            try
            {
                conn.Open();
                string insert = "insert into KhachHang(HoVaTen, SoDienThoai, DiaChi, NgaySinh, LoaiKhachHang) " + "values(@ht, @sdt, @dc, @ns, @loaiKH)";
                SqlParameter[] p =
                {
                    new SqlParameter("@ht",txtHoTen.Text),
                    new SqlParameter("@sdt",txtSDT.Text),
                    new SqlParameter("@dc",txtDiaChi.Text),
                    new SqlParameter("@ns",dtpNgaySinh.Value.Date),
                    new SqlParameter("@loaiKH", cbnLoaiKH.SelectedValue)

                };
                SqlCommand cmd = new SqlCommand(insert, conn);
                cmd.Parameters.AddRange(p);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui vòng nhập dữ liệu hợp lệ " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            loaddata();
        }

        public void loadLoaiKhachHang()
        {
            SqlConnection conn = new SqlConnection(conStr);
            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM LoaiKhachHang", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbnLoaiKH.DataSource = dt;
                cbnLoaiKH.DisplayMember = "TenLoaiKhachHang";
                cbnLoaiKH.ValueMember = "Id";
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

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];

                txtID.Text = row.Cells["Id"].Value.ToString();
                txtHoTen.Text = row.Cells["HoVaTen"].Value.ToString();
                txtSDT.Text = row.Cells["SoDienThoai"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);


                string tenLoai = row.Cells["TenLoaiKhachHang"].Value.ToString();
                cbnLoaiKH.SelectedIndex = cbnLoaiKH.FindStringExact(tenLoai);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần cập nhật.");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có muốn cập nhật dữ liệu?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SqlConnection conn = new SqlConnection(conStr);
                try
                {

                    conn.Open();

                    string updateQuery = @"UPDATE KhachHang SET 
                                        HoVaTen = @ht, 
                                        SoDienThoai = @sdt, 
                                        DiaChi = @dc, 
                                        NgaySinh = @ns, 
                                        LoaiKhachHang = @loaiKH 
                                        WHERE Id = @id";

                    SqlCommand cmd = new SqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("@id", txtID.Text);
                    cmd.Parameters.AddWithValue("@ht", txtHoTen.Text);
                    cmd.Parameters.AddWithValue("@sdt", txtSDT.Text);
                    cmd.Parameters.AddWithValue("@dc", txtDiaChi.Text);
                    cmd.Parameters.AddWithValue("@ns", dtpNgaySinh.Value.Date);
                    cmd.Parameters.AddWithValue("@loaiKH", cbnLoaiKH.SelectedValue);

                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Cập nhật thành công!");
                    loaddata();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng để xóa.");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có muốn xóa dữ liệu?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(conStr))
                {
                    try
                    {
                        conn.Open();
                        string deleteQuery = "DELETE FROM KhachHang WHERE Id = @id";
                        SqlCommand cmd = new SqlCommand(deleteQuery, conn);
                        cmd.Parameters.AddWithValue("@id", txtID.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa thành công!");
                        loaddata();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                    }
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();

            using (SqlConnection conn = new SqlConnection(conStr))
            {
                try
                {
                    conn.Open();

                    string query = @"SELECT kh.Id, kh.HoVaTen, kh.SoDienThoai, kh.DiaChi, kh.NgaySinh, lkh.TenLoaiKhachHang
                             FROM KhachHang kh LEFT JOIN LoaiKhachHang lkh ON kh.LoaiKhachHang = lkh.Id";

                    if (!string.IsNullOrEmpty(keyword))
                    {
                        query += " WHERE kh.HoVaTen LIKE @keyword";
                    }

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    if (!string.IsNullOrEmpty(keyword))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                    }

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvKhachHang.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
                }
            }
        }
    }
}
