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

        private void FirstPage_CheckedChanged(object sender, EventArgs e)
        {
            
            Mainbar1.Visible = true;
            Mainbar2.Visible = false;
            Mainbar3.Visible = false;

        }

        private void SecondPage_CheckedChanged(object sender, EventArgs e)
        {
            Mainbar1.Visible = false;
            Mainbar2.Visible = true;
            Mainbar3.Visible = false;
        }
        private void ThirdPage_CheckedChanged(object sender, EventArgs e)
        {

            Mainbar2.Visible = false;
            Mainbar3.Visible = true;
        }
        private void FifthPage_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FourthPage_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MainPanel_Load(object sender, EventArgs e)
        {

        }

        private void fistmoviename_TextChanged(object sender, EventArgs e)
        {

        }

        private void BestMovieFLPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
