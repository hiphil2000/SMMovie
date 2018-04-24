using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM_Movie.Model
{
    class Genre
    {
        Dictionary<string, int> genreDic = new Dictionary<string, int>();
        ArrayList genreNames = new ArrayList();

        public Genre()
        {
            genreDic.Add("액션", 1);
            genreNames.Add("액션");
            genreDic.Add("SF", 2);
            genreNames.Add("SF");
            genreDic.Add("코미디", 2);
            genreNames.Add("코미디");
            genreDic.Add("스릴러", 2);
            genreNames.Add("스릴러");
            genreDic.Add("전쟁", 2);
            genreNames.Add("전쟁");
            genreDic.Add("스포츠", 2);
            genreNames.Add("스포츠");
            genreDic.Add("판타지", 2);
            genreNames.Add("판타지");
            genreDic.Add("음악", 2);
            genreNames.Add("음악");
            genreDic.Add("멜로", 2);
            genreNames.Add("멜로");
        }

        public int getGenreSeq(string genreName)
        {
            return genreDic[genreName];
        }

        public DataTable getGenreList()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("genreSeq");
            dt.Columns.Add("genreName");
            for (int i = 0; i < genreDic.Count; i++)
            {
                dt.Rows.Add(genreDic[genreNames[i].ToString()], genreNames[i].ToString());
            }
            return dt;
        }
    }
}
