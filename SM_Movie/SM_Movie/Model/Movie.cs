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
        private int movieSeq;
        public int _movieSeq
        {
            get{ return movieSeq; }
            set { movieSeq = _movieSeq; }
        }
        //영화 제목
        private string movieTitle;
        public string _movieTitle
        {
            get { return movieTitle; }
            set { movieTitle = _movieTitle; }
        }
        //영화 감독
        private string movieDirector;
        public string _movieDirector
        {
            get { return movieDirector; }
            set { movieDirector = _movieDirector; }
        }
        //영화 주연
        private string movieMainActor;
        public string _movieMainActor
        {
            get { return movieMainActor; }
            set { movieMainActor = _movieMainActor; }
        }
        //영화 관람가
        private int movieAgeLimit;
        public int _movieAgeLimit
        {
            get { return movieAgeLimit; }
            set { movieAgeLimit = _movieAgeLimit; }
        }
        //영화 상영시간
        private int movieRunningTime;
        public int _movieRunningTime
        {
            get { return movieRunningTime; }
            set { movieRunningTime = _movieRunningTime; }
        }
        //영화 개봉일
        private DateTime movieReleaseDate;
        public DateTime _movieReleaseDate
        {
            get { return movieReleaseDate; }
            set { movieReleaseDate = _movieReleaseDate; }
        }
        //영화 트레일려 영상 주소
        private string movieTrailer;
        public string _movieTrailer
        {
            get { return movieTrailer; }
            set { movieTrailer = _movieTrailer; }
        }
        //영화 줄거리
        private string movieSummary;
        public string _movieSummary
        {
            get { return movieSummary; }
            set { movieSummary = _movieSummary; }
        }
        //영화 포스터 주소
        private string moviePoster;
        public string _moviePoster
        {
            get { return moviePoster; }
            set { moviePoster = _moviePoster; }
        }
        //장르 고유번호
        private int genreSeq;
        public int _genreseq
        {
            get { return genreSeq; }
            set { genreSeq = _movieSeq; }
        }

        
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
        ///  <param name="movieAgeLimit">영화 줄거리</param>
        ///  <param name="genreSeq">장르 고유번호</param>
        /// 
        public Movie(int movieSeq, string movieTitle, string movieDirector, string movieMainActor, int movieAgeLimit, int movieRunningTime, DateTime movieReleaseDate,
            string movieTrailer, string moviePoster, string movieSummary, int genreSeq)
        {
            this.movieSeq = movieSeq;
            this.movieTitle = movieTitle;
            this.movieMainActor = movieMainActor;
            this.movieAgeLimit = movieAgeLimit;
            this.movieRunningTime = movieRunningTime;
            this.movieReleaseDate = movieReleaseDate;
            this.movieTrailer = movieTrailer;
            this.moviePoster = moviePoster;
            this.movieSummary = movieSummary;
            this.genreSeq = genreSeq;

        }
    }
}
