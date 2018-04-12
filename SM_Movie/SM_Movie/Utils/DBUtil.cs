using Oracle.DataAccess.Client;
using SM_Movie.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM_Movie.Utils
{
    class DBUtil
    {
        private OracleConnection conn { get; }

        /// <summary>
        /// DB 유틸 생성자, DB Connection 생성함.
        /// </summary>
        public DBUtil()
        {
            try
            {
                string oradb = "Data Source=YPC;User Id=system;Password=1234;Integrated Security=no;";

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
                string sql = "SELECT id FROM userTbl WHERE userId = :userId AND userPassword = :userPassword";
                using (OracleCommand cmd = new OracleCommand())
                {
                    cmd.CommandText = sql;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Parameters.Add(new OracleParameter("userId", userId));
                    cmd.Parameters.Add(new OracleParameter("userPassword", userPassword));

                    using (OracleDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                            return true;
                        else
                            return false;
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
