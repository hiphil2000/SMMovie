using SM_Movie.Model;
using SM_Movie.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SM_Movie
{
    public partial class movieInfoWIndow : Form
    {

        private Point mousePos = new Point();
        Dictionary<string, ButtonInfo> buttonInfoDic = new Dictionary<string, ButtonInfo>();

        public movieInfoWIndow() : this(null, null) { }
        public movieInfoWIndow(Movie movie, Main main)
        {
            InitializeComponent();
            if(movie != null)
            {
                mediaPlayer.URL = movie._movieTrailer;
                movieTitle.Text = movie._movieTitle;
                movieReleaseDate.Text =  movie._movieReleaseDate.ToString("yyyy.MM.dd");
                movieDirector.Text = movie._movieDirector;
                movieAgeLimit.Text = movie._movieAgeLimit.ToString() + "세 이상 관람가";
                genreName.Text = movie._genreseq.ToString();
                movieRunningTime.Text = movie._movieRunningTime.ToString() + "분";
                WebClient wc = new WebClient();
                byte[] bytes = wc.DownloadData(movie._moviePoster);
                MemoryStream ms = new MemoryStream(bytes);
                moviePoster.Image = Image.FromStream(ms);
                Summary.Text = movie._movieSummary;
            }

            if(main.getCurrentUser() != null)
            {
                userNickname.Text = main.getCurrentUser()._userNickname;
            }
            else
            {
                reviewTitle.Enabled = false;
                reviewContent.Enabled = false;
                reviewinsert.Enabled = false;
            }

            buttonInfoDic.Add("closeButton", new ButtonInfo(closeButtonIcon, closeButtonPane));
            taskbar.MouseDown += setMousePos;
            taskbar.MouseMove += moveForm;

            if(main != null)
            {
                taskbar.BackColor = main._themeColor;
            }
        }



        private void closeButtonIcon_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void setMousePos(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mousePos.X = e.X;
                mousePos.Y = e.Y;
            }
        }

        private void moveForm(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && this.WindowState == FormWindowState.Normal)
            {
                this.Location = new Point(this.Location.X + (e.X - mousePos.X), this.Location.Y + (e.Y - mousePos.Y));
            }
            else if (e.Button == MouseButtons.Left && this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.Location = new Point(this.Location.X + (e.X - mousePos.X), this.Location.Y + (e.Y - mousePos.Y));
            }
        }

        private void buttonFocus(object sender, EventArgs e)
        {
            Color color = Color.FromArgb(50, 255, 255, 255);
            Control con = (Control)sender;
            string name = con.Name.Split(new[] { "Label", "Icon", "HighLight" }, StringSplitOptions.None)[0];
            buttonInfoDic[name].Get_buttonPanel().BackColor = color;
        }

        private void buttonLostFocus(object sender, EventArgs e)
        {
            Color color = Color.FromArgb(0, 0, 0, 0);
            Control con = (Control)sender;
            string name = con.Name.Split(new[] { "Label", "Icon", "HighLight" }, StringSplitOptions.None)[0];
            buttonInfoDic[name].Get_buttonPanel().BackColor = color;
        }
    }
}
