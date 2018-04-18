using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SM_Movie.Model;

namespace SM_Movie
{
    public partial class log : UserControl
    {
        Dictionary<string, ButtonInfo> buttonDictionary = new Dictionary<string, ButtonInfo>();

        public log()
        {
            InitializeComponent();
            buttonDictionary.Add("closeButton", new ButtonInfo(closeButtonIcon, closeButtonPane));
        }

        private void buttonFocus(object sender, EventArgs e)
        {
            Color color = Color.FromArgb(50, 255, 255, 255);
            Control con = (Control)sender;
            string name = con.Name.Split(new[] { "Label", "Icon", "HighLight" }, StringSplitOptions.None)[0];
            buttonDictionary[name].Get_buttonPanel().BackColor = color;

        }

        private void buttonLostFocus(object sender, EventArgs e)
        {
            Color color = Color.FromArgb(0, 0, 0, 0);
            Control con = (Control)sender;
            string name = con.Name.Split(new[] { "Label", "Icon", "HighLight" }, StringSplitOptions.None)[0];
            buttonDictionary[name].Get_buttonPanel().BackColor = color;
        }

        private void exitApp(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
