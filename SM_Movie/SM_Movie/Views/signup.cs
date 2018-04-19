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
    public partial class signup : UserControl
    {
		login login;

		Dictionary<string, ButtonInfo> buttonDictionary = new Dictionary<string, ButtonInfo>();

		public signup()
        {
            InitializeComponent();
			buttonDictionary.Add("closeButton", new ButtonInfo(closeButtonIcon, closeButtonPane));
		}

		private void buttonFocus(object sender, EventArgs e)
		{
			Color color = Color.FromArgb(125, 255, 0, 0);
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

		private void genreSeq_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

		public void setLogin(login login)
		{
			this.login = login;
		}

		private void closeButtonIcon_Click(object sender, EventArgs e)
		{
			login.Dispose();
		}
	}
}
