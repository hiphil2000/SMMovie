using SM_Movie.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;

namespace SM_Movie
{
    public partial class Main : Form
    {
        private User currentUser;
        private string currentPage;
        private Point mousePos = new Point();
        private bool menuState = false;
        private Color themeColor;
        public Color _themeColor
        {
            get { return themeColor; }
        }

        Dictionary<string, ButtonInfo> buttonInfoDic = new Dictionary<string, ButtonInfo>();

        public Main()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            settingPanel.setMain(this);
            this.HorizontalScroll.Visible = false;
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

            buttonInfoDic.Add("menuButton", new ButtonInfo(menuButtonIcon, menuButtonPane));
            buttonInfoDic.Add("minButton", new ButtonInfo(minButtonIcon, minButtonPane));
            buttonInfoDic.Add("recoverButton", new ButtonInfo(recoverButtonIcon, recoverButtonPane));
            buttonInfoDic.Add("closeButton", new ButtonInfo(closeButtonIcon, closeButtonPane));

            buttonInfoDic.Add("homeButton", new ButtonInfo(homeButtonIcon, homeButtonPane, homeButtonLabel, mainPanel, homeButtonHighLight));
            buttonInfoDic.Add("movieButton", new ButtonInfo(movieButtonIcon, movieButtonPane, movieButtonLabel, movieSearch, movieButtonHighLight));
            buttonInfoDic.Add("userButton", new ButtonInfo(userButtonIcon, userButtonPane, userButtonLabel, mainPanel, userButtonHighLight));
            buttonInfoDic.Add("settingButton", new ButtonInfo(settingButtonIcon, settingButtonPane, settingButtonLabel, settingPanel, settingButtonHighLight));
			buttonInfoDic.Add("adminButton", new ButtonInfo(adminButtonIcon, adminButtonPane, adminButtonLabel, adminPanel, adminButtonHighLight));
            

            themeColor = Utils.StyleUtil.getWindowsThemeColor();
            setColors();
            openPage(null, new EventArgs());
            mainPanel.setMain(this);
            adminPanel.setMain(this);
        }

        private void setBestData()
        {

        }

        public void setThemeColor(Color color)
        {
            this.themeColor = color;
            setColors();
        }

        private void setColors()
        {
            taskBar.BackColor = themeColor;
            menuButtonBack.BackColor = themeColor;
            if(currentPage!= null)
                buttonInfoDic[currentPage].Get_buttonHighLight().BackColor = themeColor;
        }

        public void resize()
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                taskBar.Width = this.Width - 4;
                taskBar.Location = new Point(2, 2);
                buttonFlow.Location = new Point(this.Width - buttonFlow.Width, 0);
                menuTitle.Location = new Point(50, 28);
                mainPane.Width = this.Width - 52;
                menuTitle.Width = this.Width - 52;
                mainPane.Height = this.Height - taskBar.Height - menuTitle.Height  - 4;
                mainPane.Location = new Point(50, taskBar.Height + menuTitle.Height + 2);
                menuPane.Location = new Point(2, 28);

                menuFlowWrap.Height = this.Height - taskBar.Height - menuButtonBack.Height;
                menuFlowWrap.Location = new Point(2, 74);

                menuBarFlow.Height = this.Height - menuButtonPane.Height - taskBar.Height - commonUserMenuFlow.Height - 2;

                commonUserMenuFlow.Location = new Point(0, menuBarFlow.Location.Y + menuBarFlow.Height);

                // 13 = 스크롤바 너비
                int pageWidth;
                if (mainPane.VerticalScroll.Visible == true )
                    pageWidth = this.Width - 52 - 17;
                else
                    pageWidth = this.Width - 52;
                movieSearch.Width = pageWidth;
                mainPanel.Width = pageWidth;
                settingPanel.Width = pageWidth;
                movieSearch.Width = pageWidth;
                adminPanel.Width = pageWidth;
            }
            else
            {
                taskBar.Width = this.Width;
                taskBar.Location = new Point(0, 0);
                buttonFlow.Location = new Point(this.Width - buttonFlow.Width, 0);
                menuTitle.Location = new Point(48, 26);
                mainPane.Width = this.Width - 48;
                menuTitle.Width = this.Width - 48;
                mainPane.Height = this.Height - taskBar.Height - menuTitle.Height;
                mainPane.Location = new Point(48, taskBar.Height + menuTitle.Height);
                menuPane.Location = new Point(0, 26);

                menuFlowWrap.Height = this.Height - taskBar.Height - menuButtonBack.Height;
                menuFlowWrap.Location = new Point(0, 72);

                menuBarFlow.Height = menuFlowWrap.Height - commonUserMenuFlow.Height;

                commonUserMenuFlow.Location = new Point(0, menuBarFlow.Location.Y + menuBarFlow.Height);

                // 13 = 스크롤바 너비
                int pageWidth;
                if (mainPane.VerticalScroll.Visible == true)
                    pageWidth = this.Width - 52 - 17;
                else
                    pageWidth = this.Width - 52;
                movieSearch.Width = pageWidth;
                mainPanel.Width = pageWidth;
                settingPanel.Width = pageWidth;
                movieSearch.Width = pageWidth;
                adminPanel.Width = pageWidth;
            }

        }



        #region formResize

        

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

        #endregion

        private void Main_Resize(object sender, EventArgs e)
        {
            resize();
        }

        private void setMousePos(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
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
            } else if (e.Button == MouseButtons.Left && this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.Location = new Point(this.Location.X + (e.X - mousePos.X), this.Location.Y + (e.Y - mousePos.Y));
            }
        }

        private void buttonFocus(object sender, EventArgs e)
        {
            Color color = Color.FromArgb(50,255,255,255);
            Control con = (Control)sender;
            string name = con.Name.Split(new[] { "Label", "Icon", "HighLight" }, StringSplitOptions.None)[0];
            buttonInfoDic[name].Get_buttonPanel().BackColor = color;


        }

        private void buttonLostFocus(object sender, EventArgs e)
        {
            Color color = Color.FromArgb(0, 0, 0, 0);
            Control con = (Control)sender;
            string name = con.Name.Split(new[] { "Label", "Icon", "HighLight" }, StringSplitOptions.None)[0];
            buttonInfoDic[name].Get_buttonPanel().BackColor = color;
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
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void openPage(object sender, EventArgs e)
        {
            if(sender == null)
            {
                mainPanel.Visible = true;
                titleLabel.Text = homeButtonLabel.Text;
                title.Text = homeButtonLabel.Text;
                homeButtonHighLight.BackColor = themeColor;
                currentPage = "homeButton";
                return;
            }

            
            Control con = (Control) sender;
            string name = con.Name.Split(new[] { "Label", "Icon", "HighLight" }, StringSplitOptions.None)[0];
            ButtonInfo clickedButton = buttonInfoDic[name];
            ButtonInfo prevButton = buttonInfoDic[currentPage];

            if (clickedButton.Get_buttonTitle().Equals(prevButton.Get_buttonTitle()))
                return;

            if(name.Equals("userButton"))
            {
                if(currentUser == null)
                {
                    openLogin(sender, e);
                    return;
                }
            }

            title.Text = clickedButton.Get_buttonTitle().Text;
            titleLabel.Text = clickedButton.Get_buttonTitle().Text;
            prevButton.Get_buttonHighLight().BackColor = Color.Transparent;
            prevButton.Get_buttonBindPage().Visible = false;
            clickedButton.Get_buttonHighLight().BackColor = themeColor;
            clickedButton.Get_buttonBindPage().Visible = true;


            currentPage = name;
            
        }

        private void openMenu(object sender, EventArgs e)
        {
            if(menuState)
            {
                menuState = false;
                Transition.run(menuFlowWrap, "Width", 48, new TransitionType_EaseInEaseOut(150));
                Transition.run(homeButtonPane, "Width", 48, new TransitionType_EaseInEaseOut(150));
            } else
            {
                menuState = true;
                Transition.run(menuFlowWrap, "Width", 250, new TransitionType_EaseInEaseOut(150));
                Transition.run(homeButtonPane, "Width", 250, new TransitionType_EaseInEaseOut(150));
            }
        }

        private void openLogin(object sender, EventArgs e)
        {
            login login = new login();
            login.setMain(this);
            login.ShowDialog();
        }

        public void setCurrentUser(User user)
        {
            this.currentUser = user;
            setUserButton();

        }

        public User getCurrentUser()
        {
            return currentUser;
        }

		private void openMyPage(object sender, EventArgs e)
		{

		}

        private void setUserButton()
        {
            if(currentUser != null && currentUser._memberShipSeq == 1)
            {
                buttonInfoDic["adminButton"].Get_buttonPanel().Visible = true;
            }

            if (currentUser == null && !(userButtonLabel.Text.Equals("로그인")))
            {
                userButtonLabel.Text = "로그인";
                userButtonLabel.Click += openLogin;
                userButtonLabel.Click -= openMyPage;
            }
            else if (currentUser != null && !(userButtonLabel.Text.Equals("마이페이지")))
            {
                userButtonLabel.Text = "마이페이지";
                userButtonLabel.Click -= openLogin;
                userButtonLabel.Click += openMyPage;
            }
        }

		private void adminPanel_VisibleChanged(object sender, EventArgs e)
		{
			adminPanel.refreshData();
		}

	}
}
