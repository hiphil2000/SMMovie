using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SM_Movie.Model
{
    class MemberShip
    {
        Dictionary<string, int> memberShipDic = new Dictionary<string,int>();

        public MemberShip()
        {
            memberShipDic.Add("관리자", 1);
            memberShipDic.Add("VIP", 2);
            memberShipDic.Add("A등급 회원", 3);
            memberShipDic.Add("B등급 회원", 4);
            memberShipDic.Add("C등급 회원", 5);
        }

        public int getMemberShipSeq(string memberShipName)
        {
            return memberShipDic[memberShipName];
        }
    }

}