using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM_Movie.Utils
{
    class Movie
    {
        //영화 고유번호
        private int movieSeq{ get; set; }
        //영화 제목
        private string movieTitle{ get; set; }
        //영화 감독
        private string movieDirector{ get; set; }
        //영화 주연
        private string movieMainActor{ get; set; }
        //영화 관람가
        private int movieAgeLimit{ get; set; }
        //영화 상영시간
        private int movieRunningTime{ get; set; }
        //영화 개봉일
        private DateTime movieReleaseDate{ get; set; }
        //영화 트레일려 영상 주소
        private string movieTrailer{ get; set; }
        //영화 포스터 주소
        private string moviePoster{ get; set; }
        //장르 고유번호
        private int genreSeq{ get; set; }

        
        ///  <summary>
        ///  빈 영화 모델 생성자 
        ///  </summary> 
        /// 
        public Movie()
        {

        }

        
        ///  <summary>
        ///  기본 영화 생성자
        ///  </summary>
        ///  <param name="movieSeq">영화 고유번호</param>
        ///  <param name="movieTrailer">트레일러 영상 주소</param>
        ///  <param name="movieTitle">영화 제목</param>
        ///  <param name="movieRunningTime">영화 상영시간</param>
        ///  <param name="movieReleaseDate">영화 개봉일</param>
        ///  <param name="moviePoster">영화 포스터 주소</param>
        ///  <param name="movieMainActor">영화 주연 (두 명 이상의 주연일 경우, ','를 통해 구분하여 표현함.)</param>
        ///  <param name="movieDirector">영화 감독</param>
        ///  <param name="movieAgeLimit">영화 관람가</param>
        ///  <param name="genreSeq">장르 고유번호</param>
        /// 
        public Movie(int movieSeq, string movieTitle, string movieDirector, string movieMainActor, int movieAgeLimit, int movieRunningTime, DateTime movieReleaseDate,
            string movieTrailer, string moviePoster, int genreSeq)
        {
            this.movieSeq = movieSeq;
            this.movieTitle = movieTitle;
            this.movieMainActor = movieMainActor;
            this.movieAgeLimit = movieAgeLimit;
            this.movieRunningTime = movieRunningTime;
            this.movieReleaseDate = movieReleaseDate;
            this.movieTrailer = movieTrailer;
            this.moviePoster = moviePoster;
            this.genreSeq = genreSeq;

        }
    }
}
