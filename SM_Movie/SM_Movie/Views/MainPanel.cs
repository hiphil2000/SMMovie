using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;
using SM_Movie.Utils;
using System.Globalization;
using System.Net;
using System.IO;
using SM_Movie.Model;

namespace SM_Movie
{
    public partial class MainPanel : UserControl
    {
        Utils.DBUtil db;
        Dictionary<int, MovieInfo> movieDic = new Dictionary<int, MovieInfo>();
        Main main;
        public MainPanel()
        {
            InitializeComponent();
            //  FirstPage.Parent = Mainbar1;
            db = new Utils.DBUtil();
            movieDic.Add(3, new MovieInfo(bestMoviePanel, bestMovieContentBack, bestMovieTitle, bestMovieDirector, bestMovieSummary, null));
        }

        private void MainPanel_Load(object sender, EventArgs e)
        {
            refreshMovieTile();
            refreshBestData();
        }

        private void refreshMovieTile()
        {
            Font font = bestMovieTitle.Font;
            //BestMovieFlow.Controls.Clear();
            movieDic.Clear();
            DataTable dt = db.getMovieList();
            if (dt != null)
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    int movieSeq = int.Parse(dt.Rows[i]["영화 고유번호"].ToString());
                    string movieTitle = dt.Rows[i]["영화 제목"].ToString();
                    string movieDirector = dt.Rows[i]["영화 감독"].ToString();
                    string movieMainActor = dt.Rows[i]["영화 주역"].ToString();
                    int movieAgeLimit = int.Parse(dt.Rows[i]["관람가"].ToString());
                    int movieRunningTime = int.Parse(dt.Rows[i]["상영시간"].ToString());
                    DateTime movieReleaseDate = DateTime.ParseExact(dt.Rows[i]["영화 개봉일"].ToString(), "yyyy.MM.dd", null);
                    string movieTrailer = dt.Rows[i]["영화 트레일러"].ToString();
                    string moviePoster = dt.Rows[i]["영화 포스터"].ToString();
                    string movieSummary = dt.Rows[i]["영화 줄거리"].ToString();
                    Genre gen = new Genre();
                    int genreSeq = gen.getGenreSeq(dt.Rows[i]["영화 장르"].ToString());
                    Movie movie = new Movie(movieSeq, movieTitle, movieDirector, movieMainActor, movieAgeLimit, movieRunningTime, movieReleaseDate, movieTrailer, moviePoster, movieSummary, genreSeq);

                    Panel bestMoviePanel = new Panel();
                    bestMoviePanel.Name = movie._movieSeq + "_Panel";
                    bestMoviePanel.Size = new Size(200, 300);
                    WebClient wc = new WebClient();
                    byte[] bytes = wc.DownloadData(movie._moviePoster);
                    MemoryStream ms = new MemoryStream(bytes);
                    bestMoviePanel.BackgroundImage = Image.FromStream(ms);
                    bestMoviePanel.BackgroundImageLayout = ImageLayout.Zoom;
                    bestMoviePanel.MouseEnter += transition_enter;
                    bestMoviePanel.MouseLeave += transition_leave;
                    bestMoviePanel.Click += openMovieInfo;

                    Panel bestMovieContentBack = new Panel();
                    bestMovieContentBack.Name = movie._movieSeq + "_ContentBack";
                    bestMovieContentBack.BackColor = Color.Transparent;
                    bestMovieContentBack.MouseEnter += transition_enter;
                    bestMovieContentBack.MouseLeave += transition_leave;
                    bestMovieContentBack.Click += openMovieInfo;

                    Label bestMovieTitle = new Label();
                    bestMovieTitle.Location = new Point(7, 200);
                    bestMovieTitle.MaximumSize = new Size(165, 0);
                    bestMovieTitle.Name = movie._movieSeq + "_Title";
                    bestMovieTitle.BackColor = Color.Transparent;
                    bestMovieTitle.Text = movie._movieTitle;
                    bestMovieTitle.Font = font;
                    bestMovieTitle.BringToFront();
                    bestMovieTitle.MouseEnter += transition_enter;
                    bestMovieTitle.MouseLeave += transition_leave;
                    bestMovieTitle.Click += openMovieInfo;

                    Label bestMovieDirector = new Label();
                    bestMovieDirector.Location = new Point(9, 235);
                    bestMovieDirector.MaximumSize = new Size(165, 0);
                    bestMovieDirector.Name = movie._movieSeq + "_Director";
                    bestMovieDirector.BackColor = Color.Transparent;
                    bestMovieDirector.Text = movie._movieDirector;
                    bestMovieDirector.Font = font;
                    bestMovieDirector.MouseEnter += transition_enter;
                    bestMovieDirector.MouseLeave += transition_leave;
                    bestMovieDirector.Click += openMovieInfo;

                    Label bestMovieSummary = new Label();
                    bestMovieSummary.Location = new Point(9, 300);
                    bestMovieSummary.MaximumSize = new Size(165, 0);
                    bestMovieSummary.ForeColor = Color.Black;
                    bestMovieSummary.Visible = true;
                    bestMovieSummary.Name = movie._movieSeq + "_Summary";
                    bestMovieSummary.BackColor = Color.Transparent;
                    bestMovieSummary.Text = movie._movieSummary;
                    bestMovieSummary.Font = font;
                    bestMovieSummary.MouseEnter += transition_enter;
                    bestMovieSummary.MouseLeave += transition_leave;
                    bestMovieSummary.Click += openMovieInfo;

                    bestMovieContentBack.Controls.Add(bestMovieTitle);
                    bestMovieContentBack.Controls.Add(bestMovieDirector);
                    bestMovieContentBack.Controls.Add(bestMovieSummary);
                    bestMoviePanel.Controls.Add(bestMovieContentBack);
                    BestMovieFlow.Controls.Add(bestMoviePanel);

                    MovieInfo movieinfo = new MovieInfo(bestMoviePanel, bestMovieContentBack, bestMovieTitle, bestMovieDirector, bestMovieSummary, movie);
                    movieDic.Add(movie._movieSeq, movieinfo);
                }
        }

        private void refreshBestData()
        {
            DataTable dt = db.getBestMovie(5);
            if(dt == null)
            {
                mainMovieIconBack.BackColor = Color.Gray;
                mainMovieIcon.Image = Properties.Resources.logo;
                mainMovieSummaryTitle.Text = "SM_Movie";
                mainMovieSummaryContent.Text = "SM_Movie에 오신걸 환영합니다!";
            }
        }

        private void transition_enter(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            string movieSeq = control.Name.Split('_')[0];
            MovieInfo movie = movieDic[int.Parse(movieSeq)];

            Transition.run(movie._bestMoviePanel, "BackColor", Color.FromArgb(50, 0, 0, 0), new TransitionType_EaseInEaseOut(250));
            Transition.run(movie._bestMovieTitle, "Top", 150, new TransitionType_EaseInEaseOut(250));
            Transition.run(movie._bestMovieDirector, "Top", 175, new TransitionType_EaseInEaseOut(250));
            Transition.run(movie._bestMovieSummary, "Top", 200, new TransitionType_EaseInEaseOut(250));
            Transition.run(movie._bestMovieContentBack, "BackColor", Color.FromArgb(100, 255, 255, 255), new TransitionType_EaseInEaseOut(250));
        }

        

        private void transition_leave(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            string movieSeq = control.Name.Split('_')[0];
            MovieInfo movie = movieDic[int.Parse(movieSeq)];

            Transition.run(movie._bestMoviePanel, "BackColor", Color.FromArgb(0, 0, 0, 0), new TransitionType_EaseInEaseOut(250));
            Transition.run(movie._bestMovieTitle, "Top", 200, new TransitionType_EaseInEaseOut(250));
            Transition.run(movie._bestMovieDirector, "Top", 235, new TransitionType_EaseInEaseOut(250));
            Transition.run(movie._bestMovieSummary, "Top", 300, new TransitionType_EaseInEaseOut(250));
            Transition.run(movie._bestMovieContentBack, "BackColor", Color.FromArgb(0, 255, 255, 255), new TransitionType_EaseInEaseOut(250));
        }

        private void trnsti(object sender, EventArgs e)
        {
            Transition.run(bestMoviePanel, "BackColor", Color.FromArgb(50, 0, 0, 0), new TransitionType_EaseInEaseOut(250));
            Transition.run(bestMovieTitle, "Top", 150, new TransitionType_EaseInEaseOut(250));
            Transition.run(bestMovieDirector, "Top", 175, new TransitionType_EaseInEaseOut(250));
            Transition.run(bestMovieSummary, "Top", 200, new TransitionType_EaseInEaseOut(250));
            Transition.run(bestMovieContentBack, "BackColor", Color.FromArgb(100, 255, 255, 255), new TransitionType_EaseInEaseOut(250));
        }

        private void trnsti2(object sender, EventArgs e)
        {
            Transition.run(bestMoviePanel, "BackColor", Color.FromArgb(0, 0, 0, 0), new TransitionType_EaseInEaseOut(250));
            Transition.run(bestMovieTitle, "Top", 200, new TransitionType_EaseInEaseOut(250));
            Transition.run(bestMovieDirector, "Top", 235, new TransitionType_EaseInEaseOut(250));
            Transition.run(bestMovieSummary, "Top", 300, new TransitionType_EaseInEaseOut(250));
            Transition.run(bestMovieContentBack, "BackColor", Color.FromArgb(0, 255, 255, 255), new TransitionType_EaseInEaseOut(250));
        }

        public void setMain(Main main)
        {
            this.main = main;
        }

        private void openMovieInfo(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            string movieSeq = control.Name.Split('_')[0];
            Movie movie = movieDic[int.Parse(movieSeq)]._movie;

            movieInfoWIndow movieinfo = new movieInfoWIndow(movie, main);
            movieinfo.ShowDialog();
        }

        private void MainPanel_Resize(object sender, EventArgs e)
        {
            //mainMovie.Size = this.Size;
            //mainMovieIcon.Location = new Point(0, 0);
            //mainMovieIconBack.Width = this.Width / 3 * 2;
            //mainMovieSummaryBack.Location = new Point(this.Width / 3 * 2, 0);
            //mainMovieSummaryBack.Width = this.Width / 3;
            //mainMovieSummaryContent.Width = mainMovieSummaryBack.Width;
            //mainMovieSummaryTitle.Width = mainMovieSummaryBack.Width;

            //BestMovieFlow.Size = new Size(this.Width, this.Height - 274);

            mainMovie.Width = this.Width;
            mainMovieIconBack.Location = new Point(0, 0);
            mainMovieIconBack.Width = this.Width / 3 * 2;
            mainMovieSummaryBack.Location = new Point(mainMovieIconBack.Width, 0);
            mainMovieSummaryBack.Width = this.Width / 3;
            mainMovieSummaryContent.Width = mainMovieSummaryBack.Width;
            mainMovieSummaryTitle.Width = mainMovieSummaryBack.Width;
            
        }

    }
}
