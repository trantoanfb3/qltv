using System;
using System.Data;
using System.Data.SqlClient;

namespace QLThuVien.Database
{
    public class DatabaseHelper
    {
        private readonly string connectionString =
            @"Data Source=TONTD;Initial Catalog=qltvs;Integrated Security=True;TrustServerCertificate=True";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public DataTable ExecuteQuery(
            string sql,
            CommandType commandType = CommandType.Text,
            params SqlParameter[] parameters)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = commandType;

                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                adapter.Fill(dt);
            }

            return dt;
        }

        public int ExecuteNonQuery(
            string sql,
            CommandType commandType = CommandType.Text,
            params SqlParameter[] parameters)
        {
            using (SqlConnection conn = GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.CommandType = commandType;

                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                conn.Open();

                return cmd.ExecuteNonQuery();
            }
        }

        public object ExecuteScalar(
            string sql,
            CommandType commandType = CommandType.Text,
            params SqlParameter[] parameters)
        {
            using (SqlConnection conn = GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.CommandType = commandType;

                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                conn.Open();

                return cmd.ExecuteScalar();
            }
        }

        public SqlDataReader ExecuteReader(
            string sql,
            CommandType commandType = CommandType.Text,
            params SqlParameter[] parameters)
        {
            SqlConnection conn = GetConnection();

            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = commandType;

                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                conn.Open();

                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch
            {
                conn.Dispose();
                throw;
            }
        }
    }
}