using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy.DAL
{
    class LOPDUNGCHUNG
    {
        string address = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\DEV express\QuanLy\CSDL.mdf;Integrated Security=True";

        SqlConnection sqlC;

        public LOPDUNGCHUNG()
        {
            sqlC = new SqlConnection(address);

        }

        public void Mo()
        {
            if (sqlC.State != ConnectionState.Open)
            {
                sqlC.Open();
            }
        }

        public void Dong()
        {
            if (sqlC.State != ConnectionState.Closed)
            {
                sqlC.Close();
            }
        }

        public DataTable LoadData(string sql)
        {
            SqlDataAdapter sqlD = new SqlDataAdapter(sql, sqlC);
            DataTable dt = new DataTable();
            sqlD.Fill(dt);

            return dt;
        }

        public int ExecuteNonquery(string sql)
        {
            SqlCommand sqlcommand = new SqlCommand(sql,sqlC);
            Mo();
            int ketqua = sqlcommand.ExecuteNonQuery();
            Dong();

            return ketqua;
        }

        public Object ExecuteScalar(string sql)
        {
            SqlCommand sqlcommand = new SqlCommand(sql,sqlC);
            Mo();
            Object ketqua = sqlcommand.ExecuteScalar();
            Dong();
            return ketqua;
        }
    }
}
