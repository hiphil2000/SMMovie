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
        Dictionary<int, MovieInfo> movieDic = new Dictionary<int, MovieInfo>();
        public MainPanel()
        {
            InitializeComponent();
            //  FirstPage.Parent = Mainbar1;
        }

        private void MainPanel_Load(object sender, EventArgs e)
        {
            Utils.DBUtil db = new Utils.DBUtil();
            Font font = bestMovieTitle.Font;
            BestMovieFlow.Controls.Clear();
            DataTable dt = db.getMovieList();
            if(dt != null)
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                    Movie movie = new Movie(int.Parse(dt.Rows[i]["영화 고유번호"].ToString()), dt.Rows[i]["영화 제목"].ToString(), dt.Rows[i]["영화 감독"].ToString(), dt.Rows[i]["영화 주역"].ToString(),
                    int.Parse(dt.Rows[i]["관람가"].ToString()), int.Parse(dt.Rows[i]["상영시간"].ToString()), DateTime.ParseExact(dt.Rows[i]["영화 개봉일"].ToString(), "yyyy.MM.dd", null),
                    dt.Rows[i]["영화 트레일러"].ToString(), dt.Rows[i]["영화 포스터"].ToString(), dt.Rows[i]["영화 줄거리"].ToString(), int.Parse(dt.Rows[i]["영화 장르"].ToString()));
                    
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

                    Panel bestMovieContentBack = new Panel();
                    bestMovieContentBack.Name = movie._movieSeq + "_ContentBack";
                    bestMovieContentBack.BackColor = Color.Transparent;
                    bestMovieContentBack.MouseEnter += transition_enter;
                    bestMovieContentBack.MouseLeave += transition_leave;

                    Label bestMovieTitle = new Label();
                    bestMovieTitle.Name = movie._movieSeq + "_Title";
                    bestMovieTitle.BackColor = Color.Transparent;
                    bestMovieTitle.Text = movie._movieTitle;
                    bestMovieTitle.Font = font;
                    bestMovieTitle.MouseEnter += transition_enter;
                    bestMovieTitle.MouseLeave += transition_leave;

                    Label bestMovieDirector = new Label();
                    bestMovieDirector.Name = movie._movieSeq + "_Director";
                    bestMovieDirector.BackColor = Color.Transparent;
                    bestMovieDirector.Text = movie._movieDirector;
                    bestMovieDirector.Font = font;
                    bestMovieDirector.MouseEnter += transition_enter;
                    bestMovieDirector.MouseLeave += transition_leave;

                    Label bestMovieSummary = new Label();
                    bestMovieSummary.Name = movie._movieSeq + "_Summary";
                    bestMovieSummary.BackColor = Color.Transparent;
                    bestMovieSummary.Text = movie._movieSummary;
                    bestMovieSummary.Font = font;
                    bestMovieSummary.MouseEnter += transition_enter;
                    bestMovieSummary.MouseLeave += transition_leave;

                    MovieInfo movieinfo = new MovieInfo(bestMoviePanel, bestMovieContentBack, bestMovieTitle, bestMovieDirector, bestMovieSummary, movie);
                    movieDic.Add(movie._movieSeq, movieinfo);
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
