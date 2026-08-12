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
    public partial class frm_DocGia : Form
    {

        private Database.Datahelper db = new Database.Datahelper();
        private string selectedMaDG = "";

        public frm_DocGia()
        {
            InitializeComponent();
        }

        private void frm_DocGia_Load(object sender, EventArgs e)
        {
            LoadCombobox();
            LoadData();
        }

        private void LoadCombobox()
        {
            cbo_docgia.DataSource = db.ExecuteQuery("SELECT MaDocGia, HoTen FROM DocGia");
            cbo_docgia.DisplayMember = "HoTen"; cbo_docgia.ValueMember = "MaDocGia";
        }

        private void LoadData()
        {
            string sql = @"
                SELECT tk.MaDocGia, dg.HoTen AS TenDocGia, tk.TenDangNhap, tk.TrangThai
                FROM TaiKhoanDocGia tk
                JOIN DocGia dg ON tk.MaDocGia = dg.MaDocGia";
            dgv_taikhoandocgia.DataSource = db.ExecuteQuery(sql);
        }

        private void btn_taotaikhoan_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO TaiKhoanDocGia (MaDocGia, TenDangNhap, MatKhau, TrangThai) VALUES (@MaDG, @TenDN, @MK, @TT)";
            SqlParameter[] pars = {
                new SqlParameter("@MaDG", cbo_docgia.SelectedValue),
                new SqlParameter("@TenDN", txt_tendangnhap.Text.Trim()),
                new SqlParameter("@MK", "123456"), // Mật khẩu mặc định
                new SqlParameter("@TT", chk_trangthai.Checked ? 1 : 0)
            };

            if (db.ExecuteNonQuery(sql, pars) > 0)
            {
                MessageBox.Show("Tạo tài khoản thành công!");
                LoadData();
            }
        }

        private void btn_doimatkhau_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedMaDG)) return;
            string sql = "UPDATE TaiKhoanDocGia SET MatKhau=@MK WHERE MaDocGia=@MaDG";
            SqlParameter[] pars = {
                new SqlParameter("@MaDG", selectedMaDG),
                new SqlParameter("@MK", txt_matkhau.Text.Trim())
            };

            if (db.ExecuteNonQuery(sql, pars) > 0)
            {
                MessageBox.Show("Đổi mật khẩu thành công!");
            }
        }

        private void dgv_taikhoandocgia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgv_taikhoandocgia.Rows[e.RowIndex];
                selectedMaDG = r.Cells["MaDocGia"].Value.ToString();
                txt_tendangnhap.Text = r.Cells["TenDangNhap"].Value.ToString();
                chk_trangthai.Checked = Convert.ToBoolean(r.Cells["TrangThai"].Value);
            }
        }
    }
}
