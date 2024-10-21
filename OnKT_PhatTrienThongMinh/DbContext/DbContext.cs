using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomConnection
{
    public class DbContext
    {
        SqlConnection con = new SqlConnection();
        SqlCommand command;
        SqlDataReader reader;

        public DbContext()
        {

        }
        public DbContext(string server, string namedatabase)
        {
            string constr = "Data Source = " + server + "; Initial Catalog = " + namedatabase + "; Integrated Security = True";
            con.ConnectionString = constr;
            con.Open();
            command = con.CreateCommand();
        }
        public void CreateConnection(string pConnection)
        {
            con.ConnectionString = pConnection;
            con.Open();
            command = con.CreateCommand();
        }
        public bool TestConnection()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                return true;
            }
            return false;
        }
        public void open()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                command.Parameters.Clear();
                con.Open();
            }
        }
        public void close()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
        public int ExcuseNonQuery(string sql)
        {
            open();
            SqlCommand cmd = new SqlCommand(sql, con);
            int kq = cmd.ExecuteNonQuery();
            close();
            return kq;
        }
        public object ExucseScalar(string sql)
        {
            open();
            SqlCommand cmd = new SqlCommand(sql, con);
            object kq = cmd.ExecuteScalar();
            close();
            return kq;
        }
        public DataTable GetDataTable(string sql)
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                da.Fill(dataTable);
                return dataTable;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
