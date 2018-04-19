using SM_Movie.Model;
using System;
using System.Collections.Generic;
using System.Data;
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

		public DataTable getUserList()
		{
			try
			{
				String sql = "SELECT userSeq '회원 고유번호', userName '회원 이름', CONVERT(varchar, userBirthday, 102) as '회원 생일', userId '아이디', userPassword '비밀번호', userNickname '회원 별명', "+
							"userEmail '회원 이메일', userPhone '회원 전화번호', userAddress '회원 주소', gt.genreName '회원 선호장르', mt.memberShipName '회원 등급' "+
							"FROM userTbl ut, genreTbl gt, memberShipTbl mt "+
							"WHERE ut.genreSeq = gt.genreSeq AND ut.memberShipSeq = mt.memberShipSeq";
				conn.Open();

				SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
				SqlCommandBuilder scb = new SqlCommandBuilder(sda);

				DataTable dt = new DataTable();
				dt.Locale = System.Globalization.CultureInfo.InvariantCulture;
				sda.Fill(dt);
				return dt;
			}
			catch (Exception e)
			{
				Console.WriteLine(e.StackTrace);
				return null;
			}
			finally
			{
				if (conn != null)
					conn.Close();
			}
		}

		public int getLastSeq(string table)
		{
			try
			{
				string sql = "SELECT IDNET_CURRENT('"+table+"')";
				conn.Open();
				SqlCommand scom = new SqlCommand(sql, conn);
				SqlDataReader sdr = scom.ExecuteReader();

				if(sdr.Read())
				{
					return sdr.GetInt32(0);
				}

				return -1;
			}
			catch (Exception e)
			{
				Console.WriteLine(e.StackTrace);
				return -1;
			}
			finally
			{
				if (conn != null)
					conn.Close();
			}
		}
    }
}
