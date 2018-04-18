using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SM_Movie
{
    public partial class MainPanel : UserControl
    {
        public MainPanel()
        {
            InitializeComponent();
            //  FirstPage.Parent = Mainbar1;
        }

        private void MainPanel_Load(object sender, EventArgs e)
        {
            //Utils.ImgurUtil imgur = new Utils.ImgurUtil();
            //imgur.uploadImage(BestMoviePanel1.BackgroundImage);
        }

        private void MainPanel_Resize(object sender, EventArgs e)
        {
            onpanel.Size = this.Size;
            mainMovieIcon.Location = new Point(0, 0);
            mainMovieIconBack.Width = this.Width / 3 * 2;
            mainMovieSummaryBack.Location = new Point(this.Width / 3 * 2, 0);
            mainMovieSummaryBack.Width = this.Width / 3;
            mainMovieSummaryContent.Width = mainMovieSummaryBack.Width;
            mainMovieSummaryTitle.Width = mainMovieSummaryBack.Width;

            BestMovieFlow.Size = new Size(this.Width, this.Height - 274);
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
