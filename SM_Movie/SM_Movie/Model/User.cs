using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM_Movie.Model
{
    class User
    {
        //사용자 고유번호
        private int userSeq { get; set; }
        //사용자 이름
        private string userName { get; set; }
        //사용자 생일
        private DateTime userBirthday { get; set; }
        //아이디
        private string userId { get; set; }
        //비밀번호
        private string userPassword { get; set; }
        //별명
        private string userNickname { get; set; }
        //이메일
        private string userEmail { get; set; }
        //전화번호
        private string userPhone { get; set; }
        //주소
        private string userAddress { get; set; }
        //장르 고유번호
        private int genreSeq { get; set; }
        //맴버쉽 고유번호
        private int memberShipSeq { get; set; }

        public User() : this(0, null, default(DateTime), null, null, null, null, null, null, 0, 0)
        {
            
        }

        public User(int userSeq, string userName, DateTime userBirthday, string userId, string userPassword, string userNickname,
            string userEmail, string userPhone, string userAddress, int genreSeq, int memberShipSeq)
        {
            this.userSeq = userSeq;
            this.userName = userName;
            this.userBirthday = userBirthday;
            this.userId = userId;
            this.userPassword = userPassword;
            this.userNickname = userNickname;
            this.userEmail = userEmail;
            this.userPhone = userPhone;
            this.userAddress = userAddress;
            this.genreSeq = genreSeq;
            this.memberShipSeq = memberShipSeq;
        }

    }
}
