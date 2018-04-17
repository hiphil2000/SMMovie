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

namespace SM_Movie
{
    public partial class Main : Form
    {

        class ButtonInfo
        {
            private PictureBox buttonIcon;
            public PictureBox Get_buttonIcon()
            { return buttonIcon; }
            public void Set_buttonIcon(PictureBox value)
            { buttonIcon = Get_buttonIcon(); }

            private Panel buttonPanel;
            public Panel Get_buttonPanel()
            { return buttonPanel; ; }
            public void Set_buttonPanel(Panel value)
            { buttonPanel = value; }

            private Label buttonTitle;
            public Label Get_buttonTitle()
            { return buttonTitle; }
            public void Set_buttonTitle(Label value)
            { buttonTitle = value; }

            private UserControl buttonBindPage;
            public UserControl Get_buttonBindPage()
            { return buttonBindPage; }
            public void Set_buttonBindPage(UserControl value)
            { buttonBindPage = value; }

            private Panel buttonHighLight;
            public Panel Get_buttonHighLight()
            { return buttonHighLight; }
            public void Set_buttonHighLight(Panel value)
            { buttonHighLight = value; }

            ButtonInfo()
            {

            }
            
            public ButtonInfo(PictureBox buttonIcon, Panel buttonPanel)
            {
                this.buttonIcon = buttonIcon;
                this.buttonPanel = buttonPanel;
            }

            public ButtonInfo(PictureBox buttonIcon, Panel buttonPanel, Label buttonTitle, UserControl buttonBindPage, Panel buttonHighLight)
                : this(buttonIcon, buttonPanel)
            {
                this.buttonTitle = buttonTitle;
                this.buttonHighLight = buttonHighLight;
                this.buttonBindPage = buttonBindPage;
            }
        }


        Model.User currentUser;
        string currentPage;
        Point mousePos = new Point();
        bool menuState = false;

        Dictionary<string, ButtonInfo> buttonInfoDic = new Dictionary<string, ButtonInfo>();

        //Dictionary<string, Panel> buttonDictionary = new Dictionary<string, Panel>();
        //Dictionary<string, ButtonGeneric<PictureBox, Panel, Label, UserControl, Panel>> buttonGeneric
        //    = new Dictionary<string, ButtonGeneric<PictureBox, Panel, Label, UserControl, Panel>>();
        
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

            buttonInfoDic.Add("menuButton", new ButtonInfo(menuButtonIcon, menuButtonPane));
            buttonInfoDic.Add("minButton", new ButtonInfo(minButtonIcon, minButtonPane));
            buttonInfoDic.Add("recoverButton", new ButtonInfo(recoverButtonIcon, recoverButtonPane));
            buttonInfoDic.Add("closeButton", new ButtonInfo(closeButtonIcon, closeButtonPane));

            buttonInfoDic.Add("homeButton", new ButtonInfo(homeButtonIcon, homeButtonPane, homeButtonLabel, mainPanel, homeButtonHighLight));
            buttonInfoDic.Add("movieButton", new ButtonInfo(movieButtonIcon, movieButtonPane, movieButtonLabel, movieSearch, movieButtonHighLight));
            buttonInfoDic.Add("userButton", new ButtonInfo(userButtonIcon, userButtonPane, userButtonLabel, mainPanel, userButtonHighLight));
            buttonInfoDic.Add("settingButton", new ButtonInfo(settingButtonIcon, settingButtonPane, settingButtonLabel, settingPanel, settingButtonHighLight));

            //buttonDictionary.Add("menuButton", menuButtonPane);
            //buttonDictionary.Add("closeButton", closeButtonPane);
            //buttonDictionary.Add("recoverButton", recoverButtonPane);
            //buttonDictionary.Add("minButton", minButtonPane);
            //buttonDictionary.Add("homeMenu", homeMenuPane);
            //buttonGeneric.Add("homeMenu", new ButtonGeneric<PictureBox, Panel, Label, UserControl, Panel>(homeMenuIcon, homeMenuPane, homeMenuLabel, mainPanel, homeMenuHighLight));
            //buttonDictionary.Add("movieMenu", movieMenuPane);
            //buttonGeneric.Add("movieMenu", new ButtonGeneric<PictureBox, Panel, Label, UserControl, Panel>(movieMenuIcon, movieMenuPane, movieMenuLabel, movieSearch, movieButtonHighLight));
            //buttonDictionary.Add("userButton", userButtonPane);
            //buttonGeneric.Add("userButton", new ButtonGeneric<PictureBox, Panel, Label, UserControl, Panel>(userButtonIcon, userButtonPane, userButtonLabel, mainPanel, userButtonHighLight));
            //buttonDictionary.Add("settingButton", settingButtonPane);
            //buttonGeneric.Add("settingButton", new ButtonGeneric<PictureBox, Panel, Label, UserControl, Panel>(settingButtonIcon, settingButtonPane, settingButtonLabel, mainPanel, settingButtonHighLight));

            openPage(null, new EventArgs());
        }

        public void resize()
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                taskBar.Width = this.Width - 4;
                taskBar.Location = new Point(2, 2);
                buttonFlow.Location = new Point(this.Width - buttonFlow.Width, 0);
                mainPane.Width = this.Width - 52;
                mainPane.Height = this.Height - taskBar.Height - 4;
                mainPane.Location = new Point(50, taskBar.Height + 2);
                menuPane.Location = new Point(2, 28);

                menuFlowWrap.Height = this.Height - taskBar.Height - menuButtonBack.Height;
                menuFlowWrap.Location = new Point(2, 74);

                menuBarFlow.Height = this.Height - menuButtonPane.Height - taskBar.Height - commonUserMenuFlow.Height - 2;

                commonUserMenuFlow.Location = new Point(0, menuBarFlow.Location.Y + menuBarFlow.Height);

                movieSearch.Size = new Size(this.Width - 52, this.Height - 78);
                mainPanel.Size = new Size(this.Width - 52, this.Height - 78);
                settingPanel.Size = mainPanel.Size;
                movieSearch.Size = settingPanel.Size;
                menuTitle.Width = mainPane.Width;
            }
            else
            {
                taskBar.Width = this.Width;
                taskBar.Location = new Point(0, 0);
                buttonFlow.Location = new Point(this.Width - buttonFlow.Width, 0);
                mainPane.Width = this.Width - 48;
                mainPane.Height = this.Height - taskBar.Height;
                mainPane.Location = new Point(48, taskBar.Height);
                menuPane.Location = new Point(0, 26);

                menuFlowWrap.Height = this.Height - taskBar.Height - menuButtonBack.Height;
                menuFlowWrap.Location = new Point(0, 72);

                menuBarFlow.Height = menuFlowWrap.Height - commonUserMenuFlow.Height;

                commonUserMenuFlow.Location = new Point(0, menuBarFlow.Location.Y + menuBarFlow.Height);

                movieSearch.Size = new Size(this.Width - 48, this.Height - 74);
                mainPanel.Size = new Size(this.Width - 48, this.Height - 74);

                mainPanel.Size = this.Size;
                settingPanel.Size = mainPanel.Size;
                movieSearch.Size = settingPanel.Size;
                menuTitle.Width = mainPane.Width;
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
                homeButtonHighLight.BackColor = Color.FromArgb(255, 0, 0);
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
                }
                return;
            }

            title.Text = clickedButton.Get_buttonTitle().Text;
            titleLabel.Text = clickedButton.Get_buttonTitle().Text;
            prevButton.Get_buttonHighLight().BackColor = Color.Transparent;
            prevButton.Get_buttonBindPage().Visible = false;
            clickedButton.Get_buttonHighLight().BackColor = Color.Red;
            clickedButton.Get_buttonBindPage().Visible = true;


            currentPage = name;
            
        }

        private void openMenu(object sender, EventArgs e)
        {
            if(menuState)
            {
                menuState = false;
                for (int i = menuFlowWrap.Width; i >= 48; i -= 2)
                {
                    menuFlowWrap.Width = i;
                    Thread.Sleep(1);
                }
            } else
            {
                menuState = true;
                for (int i = menuFlowWrap.Width; i <= 250; i += 2)
                {
                    menuFlowWrap.Width = i;
                    Thread.Sleep(1);
                }
            }
        }

        private void mainPane_Paint(object sender, PaintEventArgs e)
        {

        }
        private void programSettingIcon_Click(object sender, EventArgs e)
        {

        }

        private void openLogin(object sender, EventArgs e)
        {
            login login = new login();
            login.ShowDialog();
        }

        private void openMypage(object sender, EventArgs e)
        {

        }

        private void mainPanel_Load(object sender, EventArgs e)
        {

        }

        private void Main_Paint(object sender, PaintEventArgs e)
        {
            if(currentUser == null && !(userButtonLabel.Text.Equals("로그인")))
            {
                userButtonLabel.Text = "로그인";
                userButtonLabel.Click += openLogin;
                userButtonLabel.Click -= openMypage;
            } else if(currentUser != null && !(userButtonLabel.Text.Equals("마이페이지")))
            {
                userButtonLabel.Text = "마이페이지";
                userButtonLabel.Click -= openLogin;
                userButtonLabel.Click += openMypage;
            }
        }
    }
}
