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
            log1.setColor(main._themeColor);
            signup1.setColor(main._themeColor);
        }

        private void log1_Load(object sender, EventArgs e)
        {
			log1.setLogin(this);
        }

		private void signup1_Load(object sender, EventArgs e)
		{
			signup1.setLogin(this);
		}

		internal void openSignup()
		{
			log1.Visible = false;
			signup1.Visible = true;
            this.Size = signup1.Size;
		}

		internal void loginAttempt()
		{
			throw new NotImplementedException();
		}

		internal void openPage(string pageName)
		{
			switch(pageName)
			{
				case "signUp":
					openSignup();
				break;
				case "login":
					openLogin();
				break;
			}
		}

		private void openLogin()
		{
			log1.Visible = true;
			signup1.Visible = false;
            this.Size = log1.Size;
		}
	}
}
