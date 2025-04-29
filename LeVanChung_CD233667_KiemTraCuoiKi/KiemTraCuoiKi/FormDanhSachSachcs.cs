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
    public partial class FormDanhSachSachcs : Form
    {
        String conStr = "Data Source=CHUNGLE\\SQLEXPRESS;Initial Catalog=QuanLyNhaSach;Integrated Security=True";
        public FormDanhSachSachcs()
        {
            InitializeComponent();
            loadTheLoai();
        }
        private void FormDanhSachSachcs_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        public void loaddata()
        {
            SqlConnection conn = new SqlConnection(conStr);
            try
            {
                conn.Open();
                string query = @"SELECT s.Id, s.TenSach, s.Gia, s.SoLuong, s.MoTa, t.TenTheLoai 
                         FROM Sach s
                         INNER JOIN TheLoai t ON s.TheLoaiId = t.Id";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSach.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu sách : " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenSach.Text) ||
                string.IsNullOrWhiteSpace(txtGia.Text) ||
                string.IsNullOrWhiteSpace(txtSoLuong.Text) ||
                cbbTheLoai.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            SqlConnection conn = new SqlConnection(conStr);
            try
            {
                conn.Open();
                string insert = @"INSERT INTO Sach(TenSach, Gia, SoLuong, MoTa, TheLoaiId) 
                      VALUES (@tenSach, @gia, @soLuong, @moTa, @theLoaiId)";
                SqlParameter[] p =
                {
                    new SqlParameter("@tenSach", txtTenSach.Text),
                    new SqlParameter("@gia", txtGia.Text),
                    new SqlParameter("@soLuong", txtSoLuong.Text),
                    new SqlParameter("@moTa", txtMoTa.Text),
                    new SqlParameter("@theLoaiId", cbbTheLoai.SelectedValue)

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

        public void loadTheLoai()
        {
            SqlConnection conn = new SqlConnection(conStr);
            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TheLoai", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbbTheLoai.DataSource = dt;
                cbbTheLoai.DisplayMember = "TenTheLoai";
                cbbTheLoai.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải thể loại sách: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSach.Rows[e.RowIndex];

                txtID.Text = row.Cells["Id"].Value.ToString();
                txtTenSach.Text = row.Cells["TenSach"].Value.ToString();
                txtGia.Text = row.Cells["Gia"].Value.ToString();
                txtSoLuong.Text = row.Cells["SoLuong"].Value.ToString();
                txtMoTa.Text = row.Cells["MoTa"].Value.ToString();

                string tenTheLoai = row.Cells["TenTheLoai"].Value.ToString();
                cbbTheLoai.SelectedIndex = cbbTheLoai.FindStringExact(tenTheLoai);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Vui lòng chọn sách cần cập nhật.");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có muốn cập nhật dữ liệu không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(conStr))
                {
                    try
                    {
                        conn.Open();

                        string updateQuery = @"UPDATE Sach SET 
                                        TenSach = @tenSach, 
                                        Gia = @gia, 
                                        SoLuong = @soLuong, 
                                        MoTa = @moTa, 
                                        TheLoaiId = @theLoaiId
                                        WHERE Id = @id";

                        SqlCommand cmd = new SqlCommand(updateQuery, conn);
                        cmd.Parameters.AddWithValue("@id", txtID.Text);
                        cmd.Parameters.AddWithValue("@tenSach", txtTenSach.Text);
                        cmd.Parameters.AddWithValue("@gia", txtGia.Text);
                        cmd.Parameters.AddWithValue("@soLuong", txtSoLuong.Text);
                        cmd.Parameters.AddWithValue("@moTa", txtMoTa.Text);
                        cmd.Parameters.AddWithValue("@theLoaiId", cbbTheLoai.SelectedValue);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cập nhật sách thành công!");

                        loaddata();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi cập nhật: " + ex.Message);
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Vui lòng chọn sách để xóa.");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có muốn xoá dữ liệu?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(conStr))
                {
                    try
                    {
                        conn.Open();
                        string deleteQuery = "DELETE FROM Sach WHERE Id = @id";

                        SqlCommand cmd = new SqlCommand(deleteQuery, conn);
                        cmd.Parameters.AddWithValue("@id", txtID.Text);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Xóa sách thành công!");

                        loaddata();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa sách: " + ex.Message);
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

                    string query = @"SELECT s.Id, s.TenSach, s.Gia, s.SoLuong, s.MoTa, t.TenTheLoai
                             FROM Sach s
                             INNER JOIN TheLoai t ON s.TheLoaiId = t.Id";

                    if (!string.IsNullOrEmpty(keyword))
                    {
                        query += " WHERE s.TenSach LIKE @keyword";
                    }

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);

                    if (!string.IsNullOrEmpty(keyword))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                    }

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvSach.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tìm kiếm sách: " + ex.Message);
                }
            }
        }
    }
}
