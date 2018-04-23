using SM_Movie.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SM_Movie.Model
{
    class MovieInfo
    {
        private Panel bestMoviePanel;
        public Panel _bestMoviePanel
        {
            get
            {
                return bestMoviePanel;
            }
            set
            {
                bestMoviePanel = _bestMoviePanel;
            }
        }
        private Panel bestMovieContentBack;
        public Panel _bestMovieContentBack
        {
            get
            {
                return bestMovieContentBack;
            }
            set
            {
                bestMovieContentBack = _bestMovieContentBack;
            }
        }
        private Label bestMovieTitle;
        public Label _bestMovieTitle
        {
            get
            {
                return bestMovieTitle;
            }
            set
            {
                bestMovieTitle = _bestMovieTitle;
            }
        }
        private Label bestMovieDirector;
        public Label _bestMovieDirector
        {
            get
            {
                return bestMovieDirector;
            }
            set
            {
                bestMovieDirector = _bestMovieDirector;
            }
        }
        private Label bestMovieSummary;
        public Label _bestMovieSummary
        {
            get
            {
                return bestMovieSummary;
            }
            set
            {
                bestMovieSummary = _bestMovieSummary;
            }
        }

        private Movie movie;
        public Movie _movie
        {
            get
            {
                return movie;
            }
            set
            {
                movie = _movie;
            }
        }

        public MovieInfo() : this(null, null, null, null, null, null)
        {

        }

        public MovieInfo(Panel bestMoviePanel, Panel bestMovieContentBack, Label bestMovieTitle, Label bestMovieDirector, Label bestMovieSummary, Movie movie)
        {
            this.bestMoviePanel = bestMoviePanel;
            this.bestMovieContentBack = bestMovieContentBack;
            this.bestMovieTitle = bestMovieTitle;
            this.bestMovieDirector = bestMovieDirector;
            this.bestMovieSummary = bestMovieSummary;
            this.movie = movie;
        }
    }
}
