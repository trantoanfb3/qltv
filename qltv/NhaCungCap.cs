using QLThuVien.Database;
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

namespace qltv
{
    public partial class NhaCungCap : Form
    {
        private DatabaseHelper db = new DatabaseHelper();
        private int selectedId = -1;

        public NhaCungCap()
        {
            InitializeComponent();
        }

        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgv_ncc.DataSource = db.ExecuteQuery("SELECT MaNCC, TenNCC, DiaChi, DienThoai, Email FROM NhaCungCap");
        }

        private void ResetForm()
        {
            selectedId = -1;
            txt_mancc.Clear();
            txt_tenncc.Clear();
            txt_diachi.Clear();
            txt_dienthoai.Clear();
            txt_email.Clear();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_tenncc.Text)) { MessageBox.Show("Nhập tên NCC!"); return; }
            string sql = "INSERT INTO NhaCungCap (TenNCC, DiaChi, DienThoai, Email) VALUES (@Ten, @DiaChi, @DT, @Email)";
            SqlParameter[] pars = {
                new SqlParameter("@Ten", txt_tenncc.Text.Trim()),
                new SqlParameter("@DiaChi", txt_diachi.Text.Trim()),
                new SqlParameter("@DT", txt_dienthoai.Text.Trim()),
                new SqlParameter("@Email", txt_email    .Text.Trim())
            };
            if (db.ExecuteNonQuery(sql, pars) > 0)
            {
                MessageBox.Show("Thêm thành công!");
                LoadData();
                ResetForm();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (selectedId == -1) return;
            string sql = "UPDATE NhaCungCap SET TenNCC=@Ten, DiaChi=@DiaChi, DienThoai=@DT, Email=@Email WHERE MaNCC=@Ma";
            SqlParameter[] pars = {
                new SqlParameter("@Ten", txt_tenncc.Text.Trim()),
                new SqlParameter("@DiaChi", txt_diachi.Text.Trim()),
                new SqlParameter("@DT", txt_dienthoai.Text.Trim()),
                new SqlParameter("@Email", txt_email.Text.Trim()),
                new SqlParameter("@Ma", selectedId)
            };
            if (db.ExecuteNonQuery(sql, pars) > 0)
            {
                MessageBox.Show("Cập nhật thành công!");
                LoadData();
                ResetForm();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (selectedId == -1) return;
            if (MessageBox.Show("Xóa nhà cung cấp này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = "DELETE FROM NhaCungCap WHERE MaNCC=@Ma";
                SqlParameter[] pars = { new SqlParameter("@Ma", selectedId) };
                if (db.ExecuteNonQuery(sql, pars) > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadData();
                    ResetForm();
                }
            }
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            ResetForm(); LoadData();
        }

        private void dgv_ncc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgv_ncc.Rows[e.RowIndex];
                selectedId = Convert.ToInt32(r.Cells["MaNCC"].Value);
                txt_mancc.Text = selectedId.ToString();
                txt_tenncc.Text = r.Cells["TenNCC"].Value.ToString();
                txt_diachi.Text = r.Cells["DiaChi"].Value?.ToString() ?? "";
                txt_dienthoai.Text = r.Cells["DienThoai"].Value?.ToString() ?? "";
                txt_email.Text = r.Cells["Email"].Value?.ToString() ?? "";
            }
        }
    }
}
