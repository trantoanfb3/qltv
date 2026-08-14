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
    public partial class frm_DocGia2 : Form
    {
        private DatabaseHelper db = new DatabaseHelper();
        public frm_DocGia2()
        {
            InitializeComponent();
        }

        private void DocGia2_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgv_taikhoandocgia.DataSource = db.ExecuteQuery("SELECT MaDocGia, HoTen, NgaySinh, GioiTinh, DienThoai, Email, NgayTaoThe FROM DocGia");
        }

        private void ResetForm()
        {
            txt_madocgia.Enabled = true;
            txt_madocgia.Clear();
            txt_hovaten.Clear();
            dtp_ngaysinh.Value = DateTime.Now;
            rdo_nam.Checked = true;
            txt_dienthoai.Clear();
            txt_email.Clear();
            dtp_ngaytao.Value = DateTime.Now;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_madocgia.Text) || string.IsNullOrWhiteSpace(txt_hovaten.Text)) return;
            string sql = @"INSERT INTO DocGia (MaDocGia, HoTen, NgaySinh, GioiTinh, DienThoai, Email, NgayTaoThe) 
                           VALUES (@Ma, @Ten, @NS, @GT, @DT, @Email, @NgayTao)";
            SqlParameter[] pars = {
                new SqlParameter("@Ma", txt_madocgia.Text.Trim()),
                new SqlParameter("@Ten", txt_hovaten.Text.Trim()),
                new SqlParameter("@NS", dtp_ngaysinh.Value),
                new SqlParameter("@GT", rdo_nam.Checked ? "Nam" : "Nữ"),
                new SqlParameter("@DT", txt_dienthoai.Text.Trim()),
                new SqlParameter("@Email", txt_email.Text.Trim()),
                new SqlParameter("@NgayTao", dtp_ngaytao.Value)
            };
            if (db.ExecuteNonQuery(sql, pars) > 0) { MessageBox.Show("Thêm thành công!"); LoadData(); ResetForm(); }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (txt_madocgia.Enabled) return;
            string sql = @"UPDATE DocGia SET HoTen=@Ten, NgaySinh=@NS, GioiTinh=@GT, DienThoai=@DT, Email=@Email WHERE MaDocGia=@Ma";
            SqlParameter[] pars = {
                new SqlParameter("@Ten", txt_hovaten.Text.Trim()),
                new SqlParameter("@NS", dtp_ngaysinh.Value),
                new SqlParameter("@GT", rdo_nam.Checked ? "Nam" : "Nữ"),
                new SqlParameter("@DT", txt_dienthoai.Text.Trim()),
                new SqlParameter("@Email", txt_email.Text.Trim()),
                new SqlParameter("@Ma", txt_madocgia.Text.Trim())
            };
            if (db.ExecuteNonQuery(sql, pars) > 0) { MessageBox.Show("Sửa thành công!"); LoadData(); ResetForm(); }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txt_madocgia.Enabled) return;
            if (MessageBox.Show("Xóa độc giả này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = "DELETE FROM DocGia WHERE MaDocGia=@Ma";
                SqlParameter[] pars = { new SqlParameter("@Ma", txt_madocgia.Text.Trim()) };
                if (db.ExecuteNonQuery(sql, pars) > 0) { LoadData(); ResetForm(); }
            }
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            ResetForm(); 
            LoadData();
        }

        private void dgv_taikhoandocgia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_taikhoandocgia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgv_taikhoandocgia.Rows[e.RowIndex];
                txt_madocgia.Text = r.Cells["MaDocGia"].Value.ToString();
                txt_madocgia.Enabled = false;
                txt_hovaten.Text = r.Cells["HoTen"].Value.ToString();
                dtp_ngaysinh.Value = Convert.ToDateTime(r.Cells["NgaySinh"].Value);
                if (r.Cells["GioiTinh"].Value.ToString() == "Nam") rdo_nam.Checked = true; else rdo_nu.Checked = true;
                txt_dienthoai.Text = r.Cells["DienThoai"].Value?.ToString() ?? "";
                txt_email.Text = r.Cells["Email"].Value?.ToString() ?? "";
                dtp_ngaytao.Value = Convert.ToDateTime(r.Cells["NgayTaoThe"].Value);
            }
        }
    }
}
