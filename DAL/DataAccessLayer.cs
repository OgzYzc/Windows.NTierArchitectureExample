using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;

namespace DAL
{
    public class DataAccessLayer
    {
        SqlConnection cn = null;
        public int ExecuteNonQuery(string cmdtext, SqlParameter[] p = null)
        {
            try
            {
                using (cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(cmdtext, cn))
                    {
                        if (p != null)
                        {
                            cmd.Parameters.AddRange(p);
                        }
                        OpenConnection();
                        return cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        void OpenConnection()
        {
            if (cn != null && cn.State != System.Data.ConnectionState.Open)
            {
                cn.Open();
            }
        }

        public DataTable MyDataTable(string cmdtext, SqlParameter[] p = null)
        {
            using (cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(cmdtext, cn);
                if (p != null)
                {
                    da.SelectCommand.Parameters.AddRange(p);
                }
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
