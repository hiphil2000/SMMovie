using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SM_Movie.Model
{
    public class ButtonInfo
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
}
