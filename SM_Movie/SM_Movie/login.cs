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

        public login()
        {
            InitializeComponent();

            db = new Utils.DBUtil();

            leftPanel.MouseDown += setMousePos;
            leftPanel.MouseMove += moveForm;
            rightPanel.MouseDown += setMousePos;
            rightPanel.MouseMove += moveForm;
            logo.MouseDown += setMousePos;
            logo.MouseMove += moveForm;
            closeButtonIcon.MouseEnter += buttonFocus;
            closeButtonIcon.MouseLeave += buttonLostFocus;
            closeButtonIcon.MouseClick += close;
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

        #region buttonFocus
        private void buttonFocus(object sender, EventArgs e)
        {
            Color color = Color.FromArgb(100, 255, 0, 0);
            PictureBox pic = (PictureBox)sender;
            if (pic.Name.Contains("close"))
                closeButtonPane.BackColor = color;

        }

        private void buttonLostFocus(object sender, EventArgs e)
        {
            Color color = Color.FromArgb(0, 0, 0, 0);
            PictureBox pic = (PictureBox)sender;
            if (pic.Name.Contains("close"))
                closeButtonPane.BackColor = color;
        }

        private void exitApp(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        private void close(object sender, EventArgs e)
        {
            this.Close();
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
            if(db.LoginAttempt(userId.Text, userPassword.Text))
            {
                MessageBox.Show("성공");
            } else
            {
                MessageBox.Show("실패");
            }
        }
    }
}
