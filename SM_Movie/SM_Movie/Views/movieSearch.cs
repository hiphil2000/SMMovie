﻿using System;
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
    public partial class movieSearch : UserControl
    {
        public movieSearch()
        {
            InitializeComponent();
        }

        private void movieSearch_SizeChanged(object sender, EventArgs e)
        {
            searchBox.Width = this.Width - 64;
            splitContainer1.SplitterDistance = 150;
            splitContainer2.SplitterDistance = 200;
        }
    }
}
