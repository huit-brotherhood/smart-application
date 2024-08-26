using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomConnection
{
    public class SqlClass
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd;
        SqlDataReader reader;
        public SqlClass()
        {

        }
        public SqlClass(string server,string nameDatbase)
        {
            string constr = "Data Source="+server+";Initial Catalog="+nameDatbase+";Integrated Security=True";
            Con.ConnectionString = constr;
            Con.Open();
            Cmd = Con.CreateCommand();
        }
        public void CreateConnection(string pConnectionString)
        {
            Con.ConnectionString = pConnectionString;
            Con.Open();
            Cmd = Con.CreateCommand();
        }
        public bool TestConnection()
        {
            if (Con.State == ConnectionState.Open)
                return true;
            return false;
        }

        public DataTable getDatatable(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, Con);
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }

        }
        public int ExcuteNonQuery(string sql)
        {
            open();
            SqlCommand cmd = new SqlCommand(sql, Con);
            int kq = cmd.ExecuteNonQuery();
            close();
            return kq;
        }
        public SqlDataReader ExcuteQuery(string sql)
        {
            open();
            SqlCommand cmd = new SqlCommand(sql, Con);
            SqlDataReader rd = cmd.ExecuteReader();
            return rd;
        }

        public object ExcuteScalar(string sql)
        {
            open();
            SqlCommand cmd = new SqlCommand(sql, Con);
            object kq = cmd.ExecuteScalar();
            close();
            return kq;
        }
        public int UpdateData(string sql, DataTable dt)
        {

            SqlDataAdapter da = new SqlDataAdapter(sql, Con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            int kt = da.Update(dt);
            return kt;
        }

        public void open()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Cmd.Parameters.Clear();
                Con.Open();
            }
        }

        public void close()
        {
            if (Con.State == ConnectionState.Open)
                Con.Close();
        }

        public SqlConnection Con
        {
            get { return con; }
            set { con = value; }
        }

        public SqlCommand Cmd
        {
            get { return cmd; }
            set { cmd = value; }
        }

        public SqlDataReader Reader
        {
            get { return reader; }
            set { reader = value; }
        }



    }

}
