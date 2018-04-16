using SM_Movie.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;

namespace SM_Movie.Utils
{
    class DBUtil
    {
        private OracleConnection conn { get; set; }

        /// <summary>
        /// DB 유틸 생성자, DB Connection 생성함.
        /// </summary>
        public DBUtil()
        {
            try
            {
                string oradb = "Data Source=XE;user Id=system;Password=1234;";

                conn = new OracleConnection(oradb);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
        
        /// <summary>
        /// 로그인 시도 메소드
        /// </summary>
        /// <param name="userId">사용자 아이디</param>
        /// <param name="userPassword">사용자 비밀번호</param>
        /// <returns>로그인 성공여부</returns>
        public bool LoginAttempt(string userId, string userPassword)
        {
            try
            {
                conn.Open();
                string sql = "SELECT userId FROM userTbl WHERE userId = :userId AND userPassword = :userPassword";

                OracleCommand cmd = new OracleCommand(sql, conn);

                cmd.Parameters.AddWithValue("userId", userId);
                cmd.Parameters.AddWithValue("userPassword", userPassword);

                OracleDataReader dr = cmd.ExecuteReader();
                dr.Read();
                string st = dr.GetString(0);
                return false;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                return false;
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }
    }
}
