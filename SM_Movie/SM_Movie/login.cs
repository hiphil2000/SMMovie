using SM_Movie.Model;
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

		internal void loginAttempt(string id, string password)
		{
            User user = db.loginAttempt(id, password);
            if (user != null)
            {
                MessageBox.Show("로그인에 성공했습니다.\n환영합니다 [" + user._userName + "]님.", "로그인 성공");
                main.setCurrentUser(user);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("로그인에 실패했습니다.\n데이터를 다시 한번 확인해보십시오.", "로그인 실패");
            }
            
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

        public Utils.DBUtil getDBUtil()
        {
            return db;
        }
	}
}
