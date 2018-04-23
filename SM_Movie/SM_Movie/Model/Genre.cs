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
            genreDic.Add("장르1", 1);
            genreNames.Add("장르1");
            genreDic.Add("장르2", 2);
            genreNames.Add("장르2");
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
