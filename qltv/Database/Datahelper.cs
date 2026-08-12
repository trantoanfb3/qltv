using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qltv.Database
{
    internal class Datahelper
    {
        // Chuỗi kết nối đến SQL Server (Hãy thay đổi Server Name và Database Name cho đúng)
        private string strConn = @"Data Source=.;Initial Catalog=QuanLyThuVien;Integrated Security=True";

        // 1. Hàm thực thi truy vấn lấy dữ liệu về (SELECT) -> Trả về DataTable
        public DataTable ExecuteQuery(string sql, SqlParameter[] pars = null)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (pars != null) cmd.Parameters.AddRange(pars);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        // 2. Hàm thực thi lệnh thêm/sửa/xóa (INSERT, UPDATE, DELETE) -> Trả về số dòng bị tác động
        public int ExecuteNonQuery(string sql, SqlParameter[] pars = null)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (pars != null) cmd.Parameters.AddRange(pars);
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        // 3. Hàm lấy về 1 giá trị đơn lẻ (COUNT, MAX, SCOPE_IDENTITY,...)
        public object ExecuteScalar(string sql, SqlParameter[] pars = null)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (pars != null) cmd.Parameters.AddRange(pars);
                    return cmd.ExecuteScalar();
                }
            }
        }
    }
}
