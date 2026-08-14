using qltv.Models;
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
using System.Security.Cryptography;
using System.Text;
namespace qltv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //khai báo chuỗi kết nối 
        string strconn = "Data Source=TONTD;Initial Catalog=qltvs;Integrated Security=True;TrustServerCertificate=True";
        //khai báo đối tượng kết nối 
        SqlConnection conn = null;
        //Đối tượng vận chuyển dữ liệu 
        SqlDataAdapter da = null;
        //Đối tượng hiện thị dữ liệu lên form 
        DataTable dt = null;
        SqlCommand cmd = null;  // thực thi câu lệnh SQL                  
        SqlDataReader dr = null; // đọc dữ liệu trả về từ SQL Server 
        private void btn_dn_Click(object sender, EventArgs e)
        {
            try
            {
                string tenDangNhap = txtTenDangNhap.Text.Trim();
                string matKhau = txtMatKhau.Text.Trim();

                if (string.IsNullOrWhiteSpace(tenDangNhap))
                {
                    MessageBox.Show(
                        "Vui lòng nhập tên đăng nhập.",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtTenDangNhap.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(matKhau))
                {
                    MessageBox.Show(
                        "Vui lòng nhập mật khẩu.",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtMatKhau.Focus();
                    return;
                }

                string md5Password = GetMD5(matKhau);

                SqlParameter[] parameters =
                {
            new SqlParameter("@TenDangNhap", tenDangNhap),
            new SqlParameter("@MatKhau", md5Password)
        };

                DataTable dt = db.ExecuteQuery(
                    "sp_DangNhap",
                    CommandType.StoredProcedure,
                    parameters);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "Tên đăng nhập hoặc mật khẩu không chính xác.",
                        "Đăng nhập thất bại",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    txtMatKhau.Clear();
                    txtMatKhau.Focus();
                    return;
                }

                DataRow row = dt.Rows[0];

                currentUser = new UserInfo
                {
                    TenDangNhap = row["TenDangNhap"].ToString(),
                    MaNV = row["MaNV"].ToString(),
                    HoTen = row["HoTen"].ToString(),
                    ChucVu = row["ChucVu"].ToString(),
                    QuyenHan = row["QuyenHan"].ToString(),
                    TrangThai = Convert.ToBoolean(row["TrangThai"])
                };

                this.Hide();

                frmMain main = new frmMain(currentUser);

                main.FormClosed += (s, args) =>
                {
                    this.Close();
                };

                main.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi đăng nhập:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private string GetMD5(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);

                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();

                foreach (byte b in hashBytes)
                {
                    sb.Append(b.ToString("x2"));
                }

                return sb.ToString();
            }
        }
    }
}
