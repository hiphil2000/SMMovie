using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SM_Movie.Views
{
    public partial class movieMain : UserControl
    {
        public movieMain()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void movieMain_Resize(object sender, EventArgs e)
        {
            movieCollectionPanel.Width = this.Width;
        }
    }
}
