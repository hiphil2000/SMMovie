using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SM_Movie.View;
using SM_Movie.Presenter;


namespace SM_Movie
{
    public partial class login : Form,ILogin
    {
        string ILogin.userId
        {
            get
            {
                return userId.Text;
            }
            set
            {
                userId.Text = value;
            }
        }
        string ILogin.userPassword
        {
            get
            {
                return userPassword.Text;
            }
            set
            {
                userPassword.Text = value;
            }
        }

        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginPresenter presenter = new LoginPresenter(this);
            Utils.DBUtil db = new Utils.DBUtil();
            if (presenter.LoginAttempt())
            {
                MessageBox.Show("성공");
            } else
            {
                MessageBox.Show("실패");
            }
        }
    }
}
