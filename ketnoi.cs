using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PJ_For_Wang_Test
{
    class ketnoi
    {
        string con_str = "Data Source=VTH-LAPTOP\\SQLEXPRESS2012;Initial Catalog=QLTX;Integrated Security=True";
        public DataSet laydulieu(string query, string table_name)
        {
            try
            {
                SqlConnection conn = new SqlConnection(con_str);
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, table_name);
                return ds;
            }
            catch { }
            return null;

        }
        public bool thucthi(string query)
        {
            try
            {
                SqlConnection conn = new SqlConnection(con_str);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                int sl = cmd.ExecuteNonQuery();
                conn.Close();
                return sl > 0;
            }
            catch
            { }
            return false;
        }
    }
}
