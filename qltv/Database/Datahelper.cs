using System;
using System.Data;
using System.Data.SqlClient;

namespace QLThuVien.Database
{
    public class DatabaseHelper
    {
        private string strConn = @"Data Source=.;Initial Catalog=QuanLyThuVien;Integrated Security=True";

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