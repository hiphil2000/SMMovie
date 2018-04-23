using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SM_Movie.Utils;

namespace SM_Movie
{
    public partial class Movieinformation : UserControl
    {
        private Movie movie;

        public Movieinformation() : this(null) { }
        public Movieinformation(Movie movie)
        {
            InitializeComponent();
            this.movie = movie;
            if(movie != null)
                mediaPlayer.URL = movie._movieTrailer;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void closeButtonIcon_Click(object sender, EventArgs e)
        {

        }
    }
}
