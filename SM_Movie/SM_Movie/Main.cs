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
    public partial class Main : Form
    {
        Point mousePos = new Point();
        
        public Main()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            resize();

            title.MouseDown += setMousePos;
            programIcon.MouseDown += setMousePos;
            taskBar.MouseDown += setMousePos;

            title.MouseMove += moveForm;
            programIcon.MouseMove += moveForm;
            taskBar.MouseMove += moveForm;

            menuButtonIcon.MouseEnter += buttonFocus;
            menuButtonIcon.MouseLeave += buttonLostFocus;
            closeButtonIcon.MouseEnter += buttonFocus;
            closeButtonIcon.MouseLeave += buttonLostFocus;
            closeButtonIcon.MouseClick += exitApp;
            recoverButtonIcon.MouseEnter += buttonFocus;
            recoverButtonIcon.MouseLeave += buttonLostFocus;
            recoverButtonIcon.MouseClick += recoverApp;
            minButtonIcon.MouseEnter += buttonFocus;
            minButtonIcon.MouseLeave += buttonLostFocus;
            minButtonIcon.MouseClick += minimizeApp;

        }

        public void resize()
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                taskBar.Width = this.Width - 4;
                taskBar.Location = new Point(2, 2);
                buttonFlow.Location = new Point(this.Width - buttonFlow.Width, 0);
                mainPane.Width = this.Width - 4;
                mainPane.Height = this.Height - taskBar.Height - 4;
                mainPane.Location = new Point(2, taskBar.Height + 2);
                menuBarFlow.Height = this.Height - menuButtonPane.Height - taskBar.Height - userSettingPane.Height;
                commonUserMenuFlow.Location = new Point(0, this.Height - commonUserMenuFlow.Height - 2);
            }
            else
            {
                taskBar.Width = this.Width;
                taskBar.Location = new Point(0, 0);
                buttonFlow.Location = new Point(this.Width - buttonFlow.Width, 0);
                mainPane.Width = this.Width;
                mainPane.Height = this.Height - taskBar.Height;
                mainPane.Location = new Point(0, taskBar.Height);
                menuBarFlow.Height = this.Height - menuButtonPane.Height - taskBar.Height - userSettingPane.Height;
                commonUserMenuFlow.Location = new Point(0, this.Height - commonUserMenuFlow.Height);
            }

        }

        //***********************************************************
        //This gives us the ability to resize the borderless from any borders instead of just the lower right corner
        protected override void WndProc(ref Message m)
        {
            const int wmNcHitTest = 0x84;
            const int htLeft = 10;
            const int htRight = 11;
            const int htTop = 12;
            const int htTopLeft = 13;
            const int htTopRight = 14;
            const int htBottom = 15;
            const int htBottomLeft = 16;
            const int htBottomRight = 17;

            if (m.Msg == wmNcHitTest)
            {
                int x = (int)(m.LParam.ToInt64() & 0xFFFF);
                int y = (int)((m.LParam.ToInt64() & 0xFFFF0000) >> 16);
                Point pt = PointToClient(new Point(x, y));
                Size clientSize = ClientSize;
                ///allow resize on the lower right corner
                if (pt.X >= clientSize.Width - 16 && pt.Y >= clientSize.Height - 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(IsMirrored ? htBottomLeft : htBottomRight);
                    return;
                }
                ///allow resize on the lower left corner
                if (pt.X <= 16 && pt.Y >= clientSize.Height - 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(IsMirrored ? htBottomRight : htBottomLeft);
                    return;
                }
                ///allow resize on the upper right corner
                if (pt.X <= 16 && pt.Y <= 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(IsMirrored ? htTopRight : htTopLeft);
                    return;
                }
                ///allow resize on the upper left corner
                if (pt.X >= clientSize.Width - 16 && pt.Y <= 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(IsMirrored ? htTopLeft : htTopRight);
                    return;
                }
                ///allow resize on the top border
                if (pt.Y <= 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(htTop);
                    return;
                }
                ///allow resize on the bottom border
                if (pt.Y >= clientSize.Height - 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(htBottom);
                    return;
                }
                ///allow resize on the left border
                if (pt.X <= 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(htLeft);
                    return;
                }
                ///allow resize on the right border
                if (pt.X >= clientSize.Width - 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(htRight);
                    return;
                }
            }
            base.WndProc(ref m);
        }
        //***********************************************************
        //***********************************************************
        //This gives us the ability to drag the borderless form to a new location
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void YOURCONTROL_MouseDown(object sender, MouseEventArgs e)
        {
            //ctrl-leftclick anywhere on the control to drag the form to a new location 
            if (e.Button == MouseButtons.Left && Control.ModifierKeys == Keys.Control)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        //***********************************************************
        //***********************************************************
        //This gives us the drop shadow behind the borderless form
        private const int CS_DROPSHADOW = 0x20000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            resize();
        }

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

        private void buttonFocus(object sender, EventArgs e)
        {
            Color color = Color.FromArgb(100,255,255,255);
            PictureBox pic = (PictureBox)sender;
            if (pic.Name.Contains("close"))
                closeButtonPane.BackColor = color;
            else if (pic.Name.Contains("recover"))
                recoverButtonPane.BackColor = color;
            else if (pic.Name.Contains("min"))
                minButtonPane.BackColor = color;
            else if (pic.Name.Contains("menu"))
                menuButtonPane.BackColor = color;

        }

        private void buttonLostFocus(object sender, EventArgs e)
        {
            Color color = Color.FromArgb(0, 0, 0, 0);
            PictureBox pic = (PictureBox)sender;
            if (pic.Name.Contains("close"))
                closeButtonPane.BackColor = color;
            else if (pic.Name.Contains("recover"))
                recoverButtonPane.BackColor = color;
            else if (pic.Name.Contains("min"))
                minButtonPane.BackColor = color;
            else if (pic.Name.Contains("menu"))
                menuButtonPane.BackColor = color;
        }

        private void exitApp(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeApp(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void recoverApp(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }
    }
}
