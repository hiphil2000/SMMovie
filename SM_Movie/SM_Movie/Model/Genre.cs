using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM_Movie.Model
{
    class Genre
    {
        Dictionary<string, int> genreDic = new Dictionary<string, int>();

        public Genre()
        {
            genreDic.Add("장르1", 1);
            genreDic.Add("장르2", 2);
        }

        public int getGenreSeq(string genreName)
        {
            return genreDic[genreName];
        }
    }
}
