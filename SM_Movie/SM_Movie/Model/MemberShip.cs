using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace SM_Movie.Model
{
    class MemberShip
    {
        Dictionary<string, int> memberShipDic = new Dictionary<string,int>();
        ArrayList memberShipNames = new ArrayList();

        public MemberShip()
        {
            memberShipDic.Add("관리자", 1);
            memberShipNames.Add("관리자");
            memberShipDic.Add("VIP", 2);
            memberShipNames.Add("VIP");
            memberShipDic.Add("A등급 회원", 3);
            memberShipNames.Add("A등급 회원");
            memberShipDic.Add("B등급 회원", 4);
            memberShipNames.Add("B등급 회원");
            memberShipDic.Add("C등급 회원", 5);
            memberShipNames.Add("C등급 회원");
        }

        public int getMemberShipSeq(string memberShipName)
        {
            return memberShipDic[memberShipName];
        }

        public DataTable getMemeberShipList()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("memberShipSeq");
            dt.Columns.Add("memberShipName");
            for (int i = 0; i < memberShipDic.Count; i++)
            {
                dt.Rows.Add(memberShipDic[memberShipNames[i].ToString()], memberShipNames[i].ToString());
            }
            return dt;
        }
    }

}