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

        private DatabaseHelper db = new DatabaseHelper();

        private string selectedMaDG = "";

        public frm_DocGia()
        {
            InitializeComponent();
        }

        // =========================================================
        // FORM LOAD
        // =========================================================
        private void frm_DocGia_Load(object sender, EventArgs e)
        {
            LoadCombobox();
            LoadData();

            txt_matkhau.UseSystemPasswordChar = true;
            chk_trangthai.Checked = true;

            dgv_taikhoandocgia.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgv_taikhoandocgia.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgv_taikhoandocgia.MultiSelect = false;
        }

        // =========================================================
        // LOAD COMBOBOX ĐỘC GIẢ
        // =========================================================
        private void LoadCombobox()
        {
            try
            {
                string sql = @"
                    SELECT MaDocGia, HoTen
                    FROM DocGia
                    ORDER BY HoTen";

                DataTable dt = db.ExecuteQuery(sql);

                cbo_docgia.DataSource = null;

                if (dt != null && dt.Rows.Count > 0)
                {
                    cbo_docgia.DataSource = dt;
                    cbo_docgia.DisplayMember = "HoTen";
                    cbo_docgia.ValueMember = "MaDocGia";
                    cbo_docgia.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi tải danh sách độc giả:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // LOAD DANH SÁCH TÀI KHOẢN
        // =========================================================
        private void LoadData()
        {
            try
            {
                string sql = @"
                    SELECT
                        tk.MaDocGia,
                        dg.HoTen AS TenDocGia,
                        tk.TenDangNhap,
                        CASE
                            WHEN tk.TrangThai = 1 THEN N'Đang hoạt động'
                            ELSE N'Đã khóa'
                        END AS TrangThai
                    FROM TaiKhoanDocGia tk
                    INNER JOIN DocGia dg
                        ON tk.MaDocGia = dg.MaDocGia
                    ORDER BY dg.HoTen";

                dgv_taikhoandocgia.DataSource =
                    db.ExecuteQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi tải danh sách tài khoản:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // TẠO TÀI KHOẢN
        // =========================================================
        private void btn_taotaikhoan_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra độc giả
                if (cbo_docgia.SelectedValue == null)
                {
                    MessageBox.Show(
                        "Vui lòng chọn độc giả!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // Kiểm tra tên đăng nhập
                string tenDangNhap =
                    txt_tendangnhap.Text.Trim();

                if (string.IsNullOrWhiteSpace(tenDangNhap))
                {
                    MessageBox.Show(
                        "Vui lòng nhập tên đăng nhập!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txt_tendangnhap.Focus();
                    return;
                }

                string maDG =
                    cbo_docgia.SelectedValue.ToString();

                // =================================================
                // KIỂM TRA ĐỘC GIẢ ĐÃ CÓ TÀI KHOẢN CHƯA
                // =================================================
                string sqlCheckMaDG = @"
                    SELECT COUNT(*)
                    FROM TaiKhoanDocGia
                    WHERE MaDocGia = @MaDG";

                SqlParameter[] checkMaDG =
                {
                    new SqlParameter("@MaDG", maDG)
                };

                DataTable dtCheck =
                    db.ExecuteQuery(
                        sqlCheckMaDG,
                        checkMaDG);

                if (dtCheck != null &&
                    dtCheck.Rows.Count > 0 &&
                    Convert.ToInt32(dtCheck.Rows[0][0]) > 0)
                {
                    MessageBox.Show(
                        "Độc giả này đã có tài khoản!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // =================================================
                // KIỂM TRA TÊN ĐĂNG NHẬP
                // =================================================
                string sqlCheckUser = @"
                    SELECT COUNT(*)
                    FROM TaiKhoanDocGia
                    WHERE TenDangNhap = @TenDN";

                SqlParameter[] checkUser =
                {
                    new SqlParameter("@TenDN", tenDangNhap)
                };

                DataTable dtUser =
                    db.ExecuteQuery(
                        sqlCheckUser,
                        checkUser);

                if (dtUser != null &&
                    dtUser.Rows.Count > 0 &&
                    Convert.ToInt32(dtUser.Rows[0][0]) > 0)
                {
                    MessageBox.Show(
                        "Tên đăng nhập đã tồn tại!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txt_tendangnhap.Focus();
                    return;
                }

                // =================================================
                // TẠO TÀI KHOẢN
                // =================================================
                string sql = @"
                    INSERT INTO TaiKhoanDocGia
                    (
                        MaDocGia,
                        TenDangNhap,
                        MatKhau,
                        TrangThai
                    )
                    VALUES
                    (
                        @MaDG,
                        @TenDN,
                        @MK,
                        @TT
                    )";

                SqlParameter[] pars =
                {
                    new SqlParameter("@MaDG", maDG),
                    new SqlParameter("@TenDN", tenDangNhap),
                    new SqlParameter("@MK", "123456"),
                    new SqlParameter(
                        "@TT",
                        chk_trangthai.Checked ? 1 : 0)
                };

                int result =
                    db.ExecuteNonQuery(sql, pars);

                if (result > 0)
                {
                    MessageBox.Show(
                        "Tạo tài khoản thành công!\n\n" +
                        "Tên đăng nhập: " + tenDangNhap + "\n" +
                        "Mật khẩu mặc định: 123456",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LoadData();
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi tạo tài khoản:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // ĐỔI MẬT KHẨU
        // =========================================================
        private void btn_doimatkhau_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(selectedMaDG))
                {
                    MessageBox.Show(
                        "Vui lòng chọn tài khoản cần đổi mật khẩu!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                string matKhauMoi =
                    txt_matkhau.Text.Trim();

                if (string.IsNullOrWhiteSpace(matKhauMoi))
                {
                    MessageBox.Show(
                        "Vui lòng nhập mật khẩu mới!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txt_matkhau.Focus();
                    return;
                }

                if (matKhauMoi.Length < 6)
                {
                    MessageBox.Show(
                        "Mật khẩu phải có ít nhất 6 ký tự!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txt_matkhau.Focus();
                    return;
                }

                string sql = @"
                    UPDATE TaiKhoanDocGia
                    SET MatKhau = @MK
                    WHERE MaDocGia = @MaDG";

                SqlParameter[] pars =
                {
                    new SqlParameter("@MaDG", selectedMaDG),
                    new SqlParameter("@MK", matKhauMoi)
                };

                int result =
                    db.ExecuteNonQuery(sql, pars);

                if (result > 0)
                {
                    MessageBox.Show(
                        "Đổi mật khẩu thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    txt_matkhau.Clear();
                    LoadData();
                }
                else
                {
                    MessageBox.Show(
                        "Không tìm thấy tài khoản!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi đổi mật khẩu:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // CLICK DATAGRIDVIEW
        // =========================================================
        private void dgv_taikhoandocgia_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                    return;

                DataGridViewRow r =
                    dgv_taikhoandocgia.Rows[e.RowIndex];

                if (r.Cells["MaDocGia"].Value != null)
                {
                    selectedMaDG =
                        r.Cells["MaDocGia"]
                         .Value
                         .ToString();
                }

                if (r.Cells["TenDangNhap"].Value != null)
                {
                    txt_tendangnhap.Text =
                        r.Cells["TenDangNhap"]
                         .Value
                         .ToString();
                }

                // Vì DataGridView đang hiển thị
                // "Đang hoạt động"/"Đã khóa"
                // nên xử lý trạng thái bằng chuỗi.
                if (r.Cells["TrangThai"].Value != null)
                {
                    string trangThai =
                        r.Cells["TrangThai"]
                         .Value
                         .ToString();

                    chk_trangthai.Checked =
                        trangThai == "Đang hoạt động";
                }

                txt_matkhau.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi chọn tài khoản:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // LÀM MỚI FORM
        // =========================================================
        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            ClearForm();

            LoadCombobox();
            LoadData();
        }

        // =========================================================
        // XÓA DỮ LIỆU NHẬP
        // =========================================================
        private void ClearForm()
        {
            selectedMaDG = "";

            txt_tendangnhap.Clear();
            txt_matkhau.Clear();

            chk_trangthai.Checked = true;

            if (cbo_docgia.Items.Count > 0)
                cbo_docgia.SelectedIndex = 0;

            txt_tendangnhap.Focus();
        }
    }
}
