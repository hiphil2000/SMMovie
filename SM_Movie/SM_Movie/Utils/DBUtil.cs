using SM_Movie.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM_Movie.Utils
{
    class DBUtil
    {
        private SqlConnection conn;

        public DBUtil()
        {
            string connectionString = "Data Source=EMT01;Initial Catalog=SM_Movie;Integrated Security=True;Pooling=False";
            conn = new SqlConnection(connectionString);
        }

        public User loginAttempt(string userId, string userPassword)
        {
            try
            {
                String sql = "SELECT userSeq, userName, userBirthday, userId, userPassword, userNickname, userEmail, userPhone, userAddress, genreSeq, memberShipSeq FROM userTbl WHERE userId = @userid AND userPassword = @userPassword";
                SqlCommand com = new SqlCommand(sql, conn);
                com.Parameters.AddWithValue("@userid", userId);
                com.Parameters.AddWithValue("@userPassword", userPassword);

                conn.Open();
                SqlDataReader sdr = com.ExecuteReader();
                if (sdr.Read())
                {
                    User user = new User(int.Parse(sdr["userSeq"].ToString()), sdr["userName"].ToString(), DateTime.Parse(sdr["userBirthday"].ToString()),
                        sdr["userId"].ToString(), sdr["userPassword"].ToString(), sdr["userNickname"].ToString(), sdr["userEmail"].ToString(),
                        sdr["userPhone"].ToString(), sdr["userAddress"].ToString(), int.Parse(sdr["genreSeq"].ToString()), int.Parse(sdr["memberShipSeq"].ToString()));
                    return user;
                }
                else
                    return null;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return null;

            } finally
            {
                if (conn != null)
                    conn.Close();

            }
            
        }
    }
}
