using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM_Movie.Model
{
    public class User
    {
        //사용자 고유번호
        private int userSeq;
        public int _userSeq
        {
            get
            {
                return userSeq;
            }
            set
            {
                userSeq = _userSeq;
            }
        }
        //사용자 이름
        private string userName;
        public string _userName
        {
            get
            {
                return userName;
            }
            set
            {
                userName = _userName;
            }
        }
        //사용자 생일
        private DateTime userBirthday;
        public DateTime _userBirthday
        {
            get
            {
                return userBirthday;
            }
            set
            {
                userBirthday = _userBirthday;
            }
        }
        //아이디
        private string userId;
        public string _userId
        {
            get
            {
                return userId;
            }
            set
            {
                userId = _userId;
            }
        }
        //비밀번호
        private string userPassword;
        public string _userPassword
        {
            get
            {
                return userPassword;
            }
            set
            {
                userPassword = _userPassword;
            }
        }
        //별명
        private string userNickname;
        public string _userNickname
        {
            get
            {
                return userNickname;
            }
            set
            {
                userNickname = _userNickname;
            }
        }
        //이메일
        private string userEmail;
        public string _userEmail
        {
            get
            {
                return userEmail;
            }
            set
            {
                userEmail = _userEmail;
            }
        }
        //전화번호
        private string userPhone;
        public string _userPhone
        {
            get
            {
                return userPhone;
            }
            set
            {
                userPhone = _userPhone;
            }
        }
        //주소
        private string userAddress;
        public string _userAddress
        {
            get
            {
                return userAddress;
            } set
            {
                userAddress = _userAddress;
            }
        }
        //장르 고유번호
        private int genreSeq;
        public int _genreSeq
        {
            get
            {
                return genreSeq;
            }
            set
            {
                genreSeq = _genreSeq;
            }
        }
        //맴버쉽 고유번호
        private int memberShipSeq;
        public int _memberShipSeq
        {
            get
            {
                return memberShipSeq;
            }
            set
            {
                memberShipSeq = _memberShipSeq;
            }
        }

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

        public User(User user)
        {
            this.userSeq = user.userSeq;
            this.userName = user.userName;
            this.userBirthday = user.userBirthday;
            this.userId = user.userId;
            this.userPassword = user.userPassword;
            this.userNickname = user.userNickname;
            this.userEmail = user.userEmail;
            this.userPhone = user.userPhone;
            this.userAddress = user.userAddress;
            this.genreSeq = user.genreSeq;
            this.memberShipSeq = user.memberShipSeq;
        }

    }
}
