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
            string connectionString = "Data Source=EMT03;Initial Catalog=master;Integrated Security=True;Pooling=False";
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

        public void register(User user)
        {
            try
            {
                String sql = "INSERT INTO userTbl(userName, userBirthday, userId, userPassword, userNickname, userEmail, userPhone, userAddress, genreSeq, memberShipSeq) " +
                    "VALUES(:userName, CONVERT(datetime, :userBirthday, 102), :userId, :userPassword, :userEmail, :userPhone, :userAddress, :genreSeq, :memberShipSeq)";
                SqlCommand com = new SqlCommand(sql, conn);
                com.Parameters.AddWithValue(":userName", user._userName);
                com.Parameters.AddWithValue(":userBirthday", user._userBirthday);
                com.Parameters.AddWithValue(":userId", user._userId);
                com.Parameters.AddWithValue(":userPassword", user._userPassword);
                com.Parameters.AddWithValue(":userNickname", user._userNickname);
                com.Parameters.AddWithValue(":userEmail", user._userEmail);
                com.Parameters.AddWithValue(":userPhone", user._userPhone);
                com.Parameters.AddWithValue(":userAddress", user._userAddress);
                com.Parameters.AddWithValue(":genreSeq", user._genreSeq);
                com.Parameters.AddWithValue(":memberShipSeq", user._memberShipSeq);

                conn.Open();
                com.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);

            }
            finally
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

        public DataTable getMovieList()
        {
            try
            {
                String sql = "SELECT movieSeq '영화 고유번호', movieTitle '영화 제목', movieDirector '영화 감독', movieMainActor '영화 주역', movieAgeLimit '관람가', " +
                            "movieRunningTime '상영시간', CONVERT(varchar, movieReleaseDate, 102) '영화 개봉일', movieTrailer '영화 트레일러', moviePoster '영화 포스터', movieSummary '영화 줄거리', genreName '영화 장르' " +
                            "FROM movieTbl mt, genreTbl gt" +
                            "WHERE mt.genreSeq = gt.genreSeq";
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

        public void getMainData()
        {
            try
            {
                string sql = "";
                conn.Open();
                SqlCommand scom = new SqlCommand(sql, conn);
                SqlDataReader sdr = scom.ExecuteReader();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }

        public void updateUserList(DataTable tableViewData)
        {
            try
            {
                //변경사항 (추가됨)
                
                DataTable addedData = tableViewData.GetChanges(DataRowState.Added);
                DataTable removedData = tableViewData.GetChanges(DataRowState.Deleted);
                DataTable changedData = tableViewData.GetChanges(DataRowState.Modified);
                MemberShip mem = new MemberShip();
                Genre gen = new Genre();
                conn.Open();

                //추가데이터 처리
                if (addedData != null)
                {
                    string sql = "INSERT INTO userTbl(userName, userBirthday, userId, userPassword, userNickname, userEmail, userPhone, userAddress, genreSeq, memberShipSeq) ";
                    foreach (DataRow dr in addedData.Rows)
                    {
                        string userName = dr["회원 이름"].ToString();
                        string userBirthday = dr["회원 생일"].ToString();
                        string userId = dr["아이디"].ToString();
                        string userPassword = dr["비밀번호"].ToString();
                        string userNickname = dr["회원 별명"].ToString();
                        string userEmail = dr["회원 이메일"].ToString();
                        string userPhone = dr["회원 전화번호"].ToString();
                        string userAddress = dr["회원 주소"].ToString();
                        int genreSeq = gen.getGenreSeq(dr["회원 선호장르"].ToString());
                        int memberShipSeq = mem.getMemberShipSeq(dr["회원 등급"].ToString());

                        string values = "VALUES(':userName', CONVERT(datetime, ':userBirthday', 102), ':userId', ':userPassword', ':userNickname', 'userEmail', 'userPhone', " +
                            "':userAddress', :genreSeq, :memberShipSeq), ";
                        values = values.Replace(":userName", userName).Replace(":userBirthday", userBirthday).Replace(":userId", userId).Replace(":userPassword", userPassword)
                        .Replace(":userNickname", userNickname).Replace(":userEmail", userEmail).Replace(":userPhone", userPhone).Replace(":userAddress", userAddress).Replace(":genreSeq", genreSeq.ToString())
                        .Replace(":memberShipSeq", memberShipSeq.ToString());
                        sql += values;
                    }
                    sql.TrimEnd();
                    sql = sql.Substring(0, sql.Length - 2);
                    SqlCommand com = new SqlCommand(sql, conn);
                    com.ExecuteNonQuery();
                }

                if(removedData != null)
                {
                    string sql = "DELETE FROM userTbl WHERE ";
                    foreach (DataRow dr in removedData.Rows)
                    {
                        string userSeq = dr["회원 고유번호"].ToString();
                        string deleteValue = "userSeq = " + userSeq + " OR ";
                        sql += deleteValue;
                    }
                    sql.TrimEnd();
                    sql = sql.Substring(0, sql.Length - 3);
                    SqlCommand com = new SqlCommand(sql, conn);
                    com.ExecuteNonQuery();
                }

                if(changedData != null)
                {                    
                    foreach (DataRow dr in changedData.Rows)
                    {
                        string sql = "UPDATE userTbl SET userName = ':userName',  userBirthday = CONVERT(datetime, ':userBirthday', 102), userId = :userId, userPassword = :userPassword, " +
                        "userNickname = :userNickname, userEmail = :userEmail, userPhone = :userPhone, userAddress = :userAddress, genreSeq = :genreSeq, memberShipSeq = :memberShipSeq " +
                        "WHERE userSeq = :userSeq";
                        SqlCommand com = new SqlCommand(sql, conn);
                        string userSeq = dr["회원 고유번호"].ToString();
                        string userName = dr["회원 이름"].ToString();
                        string userBirthday = dr["회원 생일"].ToString();
                        string userId = dr["아이디"].ToString();
                        string userPassword = dr["비밀번호"].ToString();
                        string userNickname = dr["회원 별명"].ToString();
                        string userEmail = dr["회원 이메일"].ToString();
                        string userPhone = dr["회원 전화번호"].ToString();
                        string userAddress = dr["회원 주소"].ToString();
                        int genreSeq = gen.getGenreSeq(dr["회원 선호장르"].ToString());
                        int memberShipSeq = mem.getMemberShipSeq(dr["회원 등급"].ToString());

                        com.Parameters.AddWithValue(":userName", userName);
                        com.Parameters.AddWithValue(":userBirthday", userBirthday);
                        com.Parameters.AddWithValue(":userId", userId);
                        com.Parameters.AddWithValue(":userPassword", userPassword);
                        com.Parameters.AddWithValue(":userNickname", userNickname);
                        com.Parameters.AddWithValue(":userEmail", userEmail);
                        com.Parameters.AddWithValue(":userPhone", userPhone);
                        com.Parameters.AddWithValue(":userAddress", userAddress);
                        com.Parameters.AddWithValue(":userSeq", userSeq);
                        com.Parameters.AddWithValue(":genreSeq", genreSeq);
                        com.Parameters.AddWithValue(":memberShipSeq", memberShipSeq);

                        com.ExecuteNonQuery();
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }
    }
}
