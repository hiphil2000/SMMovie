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
        class ButtonGeneric <Pic, Pa, La, Uc, Hi>
        {
            public Pic buttonIcon;
            public Pa buttonPanel;
            public La buttonTitle;
            public Uc buttonPage;
            public Hi highLight;

            public ButtonGeneric()
            {
            }

            public ButtonGeneric(Pic buttonIcon, Pa buttonPanel, La buttonTitle, Uc buttonPage, Hi highLight)
            {
                this.buttonIcon = buttonIcon;
                this.buttonPanel = buttonPanel;
                this.buttonTitle = buttonTitle;
                this.buttonPage = buttonPage;
                this.highLight = highLight;
            }
        }


        Model.User currentUser;
        Point mousePos = new Point();
        bool menuState = false;
        Dictionary<PictureBox, Panel> buttonDictionary = new Dictionary<PictureBox, Panel>();
        Dictionary<PictureBox, ButtonGeneric<PictureBox, Panel, Label, UserControl, Panel>> buttonGeneric
            = new Dictionary<PictureBox, ButtonGeneric<PictureBox, Panel, Label, UserControl, Panel>>();
        PictureBox currentPage;
        
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
            menuButtonIcon.MouseClick += openMenu;
            buttonDictionary.Add(menuButtonIcon, menuButtonPane);
            closeButtonIcon.MouseEnter += buttonFocus;
            closeButtonIcon.MouseLeave += buttonLostFocus;
            closeButtonIcon.MouseClick += exitApp;
            buttonDictionary.Add(closeButtonIcon, closeButtonPane);
            recoverButtonIcon.MouseEnter += buttonFocus;
            recoverButtonIcon.MouseLeave += buttonLostFocus;
            recoverButtonIcon.MouseClick += recoverApp;
            buttonDictionary.Add(recoverButtonIcon, recoverButtonPane);
            minButtonIcon.MouseEnter += buttonFocus;
            minButtonIcon.MouseLeave += buttonLostFocus;
            minButtonIcon.MouseClick += minimizeApp;
            buttonDictionary.Add(minButtonIcon, minButtonPane);
            homeMenuIcon.MouseEnter += buttonFocus;
            homeMenuIcon.MouseLeave += buttonLostFocus;
            homeMenuIcon.MouseClick += openPage;
            buttonDictionary.Add(homeMenuIcon, homeMenuPane);
            buttonGeneric.Add(homeMenuIcon, new ButtonGeneric<PictureBox, Panel, Label, UserControl, Panel>(homeMenuIcon, homeMenuPane, homeMenuLabel, mainPanel1, homeMenuHighLight));
            movieMenuIcon.MouseEnter += buttonFocus;
            movieMenuIcon.MouseLeave += buttonLostFocus;
            movieMenuIcon.MouseClick += openPage;
            buttonDictionary.Add(movieMenuIcon, movieMenuPane);
            buttonGeneric.Add(movieMenuIcon, new ButtonGeneric<PictureBox, Panel, Label, UserControl, Panel>(movieMenuIcon, movieMenuPane, movieMenuLabel, movieSearch1, movieButtonHighLight));
            userButtonIcon.MouseEnter += buttonFocus;
            userButtonIcon.MouseLeave += buttonLostFocus;
            userButtonIcon.MouseClick += openPage;
            buttonDictionary.Add(userButtonIcon, userButtonPane);
            buttonGeneric.Add(userButtonIcon, new ButtonGeneric<PictureBox, Panel, Label, UserControl, Panel>(userButtonIcon, userButtonPane, userButtonLabel, mainPanel1, userButtonHighLight));
            settingButtonIcon.MouseEnter += buttonFocus;
            settingButtonIcon.MouseLeave += buttonLostFocus;
            settingButtonIcon.MouseClick += openPage;
            buttonDictionary.Add(settingButtonIcon, settingButtonPane);
            buttonGeneric.Add(settingButtonIcon, new ButtonGeneric<PictureBox, Panel, Label, UserControl, Panel>(settingButtonIcon, settingButtonPane, settingButtonLabel, mainPanel1, settingButtonHighLight));

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

                movieSearch1.Size = new Size(this.Width - 52, this.Height - 78);
                mainPanel1.Size = new Size(this.Width - 52, this.Height - 78);
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

                movieSearch1.Size = new Size(this.Width - 48, this.Height - 74);
                mainPanel1.Size = new Size(this.Width - 48, this.Height - 74);

                mainPanel1.Size = this.Size;

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
            Color color = Color.FromArgb(50,255,255,255);
            PictureBox pic = (PictureBox)sender;
            buttonDictionary[pic].BackColor = color;

        }

        private void buttonLostFocus(object sender, EventArgs e)
        {
            Color color = Color.FromArgb(0, 0, 0, 0);
            PictureBox pic = (PictureBox)sender;
            buttonDictionary[pic].BackColor = color;
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

        private void openPage(object sender, EventArgs e)
        {
            if(sender == null)
            {
                mainPanel1.Visible = true;
                titleLabel.Text = homeMenuLabel.Text;
                title.Text = homeMenuLabel.Text;
                homeMenuHighLight.BackColor = Color.FromArgb(255, 0, 0);
                currentPage = homeMenuIcon;
                return;
            }

            PictureBox pic = (PictureBox) sender;
            Panel pane = buttonDictionary[pic];
            ButtonGeneric<PictureBox, Panel, Label, UserControl, Panel> button = buttonGeneric[pic];

            if (title.Equals(button.buttonTitle.Text))
                return;

            title.Text = button.buttonTitle.Text;
            titleLabel.Text = button.buttonTitle.Text;
            buttonGeneric[currentPage].highLight.BackColor = Color.Transparent;
            buttonGeneric[currentPage].buttonPage.Visible = false;
            currentPage = button.buttonIcon;
            button.highLight.BackColor = Color.Red;
            button.buttonPage.Visible = true;


            
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

        private void userSettingIcon_Click(object sender, EventArgs e)
        {
            if(currentUser == null)
            {
                login login = new login();
                login.ShowDialog();
            }
        }

        private void mainPanel1_Load(object sender, EventArgs e)
        {

        }
    }
}
