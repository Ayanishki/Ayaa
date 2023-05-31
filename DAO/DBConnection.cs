using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
namespace DAO
{
    public class DBConnection
    {
        protected SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FK281Q8\SQLEXPRESS;Initial Catalog=Quanlybansach;Integrated Security=True");
        public object SqlScalar(string sql)
        {
            object data = 0;
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FK281Q8\SQLEXPRESS;Initial Catalog=Quanlybansach;Integrated Security=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                data = cmd.ExecuteScalar();
                con.Close();
            }
            return data;
        }
    }

}
