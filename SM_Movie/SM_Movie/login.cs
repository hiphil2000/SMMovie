using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SM_Movie
{
    public partial class login : Form
    {

        Point mousePos = new Point();
        Utils.DBUtil db;
        private Main main;

        public login()
        {
            InitializeComponent();

            db = new Utils.DBUtil();
        }

        #region formMove
        private void setMousePos(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && this.WindowState == FormWindowState.Normal)
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
        }
        #endregion


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void setMain(Main main)
        {
            this.main = main;
        }
    }
}
