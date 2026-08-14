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
    public partial class Kho2 : Form
    {
        private DatabaseHelper db = new DatabaseHelper();
        private int selectedId = -1;

        public Kho2()
        {

            InitializeComponent();
        }

        private void Kho2_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgv_kho2.DataSource = db.ExecuteQuery("SELECT MaKho, TenKho, ViTri, SucChua, GhiChu FROM Kho");
        }

        private void ResetForm()
        {
            selectedId = -1;
            txt_tenkho.Clear();
            txt_vitri.Clear();
            num_succhua.Value = 1000;
            txt_ghichu.Clear();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_tenkho.Text)) { MessageBox.Show("Nhập tên kho!"); return; }
            string sql = "INSERT INTO Kho (TenKho, ViTri, SucChua, GhiChu) VALUES (@Ten, @ViTri, @SucChua, @GhiChu)";
            SqlParameter[] pars = {
                new SqlParameter("@Ten", txt_tenkho.Text.Trim()),
                new SqlParameter("@ViTri", txt_vitri.Text.Trim()),
                new SqlParameter("@SucChua", (int)num_succhua.Value),
                new SqlParameter("@GhiChu", txt_ghichu.Text.Trim())
            };
            if (db.ExecuteNonQuery(sql, pars) > 0)
            {
                MessageBox.Show("Thêm kho thành công!");
                LoadData();
                ResetForm();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (selectedId == -1) return;
            string sql = "UPDATE Kho SET TenKho=@Ten, ViTri=@ViTri, SucChua=@SucChua, GhiChu=@GhiChu WHERE MaKho=@Ma";
            SqlParameter[] pars = {
                new SqlParameter("@Ten", txt_tenkho.Text.Trim()),
                new SqlParameter("@ViTri", txt_vitri.Text.Trim()),
                new SqlParameter("@SucChua", (int)num_succhua.Value),
                new SqlParameter("@GhiChu", txt_ghichu.Text.Trim()),
                new SqlParameter("@Ma", selectedId)
            };
            if (db.ExecuteNonQuery(sql, pars) > 0)
            {
                MessageBox.Show("Cập nhật kho thành công!");
                LoadData();
                ResetForm();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (selectedId == -1) return;
            if (MessageBox.Show("Xóa kho này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = "DELETE FROM Kho WHERE MaKho=@Ma";
                SqlParameter[] pars = { new SqlParameter("@Ma", selectedId) };
                if (db.ExecuteNonQuery(sql, pars) > 0)
                {
                    MessageBox.Show("Xóa kho thành công!");
                    LoadData();
                    ResetForm();
                }
            }
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            ResetForm(); 
            LoadData();
        }

        private void dgv_kho2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgv_kho2.Rows[e.RowIndex];
                selectedId = Convert.ToInt32(r.Cells["MaKho"].Value);
                txt_tenkho.Text = r.Cells["TenKho"].Value.ToString();
                txt_vitri.Text = r.Cells["ViTri"].Value?.ToString() ?? "";
                num_succhua.Value = Convert.ToDecimal(r.Cells["SucChua"].Value);
                txt_ghichu.Text = r.Cells["GhiChu"].Value?.ToString() ?? "";
            }
        }
    }
}
