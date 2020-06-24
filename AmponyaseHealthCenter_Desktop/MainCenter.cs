using System.Data;
using System.Data.SqlClient;

namespace AmponyaseHealthCenter_Desktop
{
    class MainCenter:DBConnection
    {
       
       
        int i;
        string a;
        public bool InsertQuery(string query)
        {
            SqlConnection con = new SqlConnection(GetConn());
           
               
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                con.Open();
                i = cmd.ExecuteNonQuery();
                con.Close();
            }
            if (i > 0)
            {
                return true;

            }
            else
            {
                return false;
            }

          
        }

        public bool UpdateQuery(string query)
        {
            SqlConnection con = new SqlConnection(GetConn());
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                con.Open();
                i = cmd.ExecuteNonQuery();
                con.Close();
            }
            if (i > 0)
            {
                return true;

            }
            else
            {
                return false;
            }


        }
        public bool DeleteQuery(string query)
        {
            SqlConnection con = new SqlConnection(GetConn());


            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                con.Open();
                i = cmd.ExecuteNonQuery();
                con.Close();
            }
            if (i > 0)
            {
                return true;

            }
            else
            {
                return false;
            }


        }

        public object LoadDGV(string query)
        {
            SqlConnection con = new SqlConnection(GetConn());

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }

        public object FillCombos(string query)
        {
            SqlConnection con = new SqlConnection(GetConn());
            con.Open();
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
                return dt;
            }
        }

        public bool UserLogin(string username,string password)
        {
            SqlConnection con = new SqlConnection(GetConn());
            SqlDataReader dr;
            string sql = "select * from Users where username ='" + username + "' and password ='" + DataCipher.Encrypt(password) + "'";
           
            using(SqlCommand cmd = new SqlCommand(sql,con))
            {
                con.Open();
                dr = cmd.ExecuteReader();
             
                if(dr.Read())
                {

                    con.Close();
                    return true;

                    
                }
                else
                {
                    con.Close();
                    return false;
                }
            }

          
        }

        public string GetUserStaffNumber(string username, string password)
        {
            SqlConnection con = new SqlConnection(GetConn());
            SqlDataReader dr;
            string sql = "select Staffno from Users where username ='" + username + "' and password ='" + DataCipher.Encrypt(password) + "'";
            con.Open();

            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    a = dr["Staffno"].ToString();
                }

            }

            dr.Close();
            con.Close();

            return a;
        }
    }
}
