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

namespace SM_Movie.Views
{
	public partial class admin : UserControl
	{
		private Dictionary<string, LnbButtonInfo> buttonDictionary = new Dictionary<string, LnbButtonInfo>();
        private string currentPage;
		Utils.DBUtil db;

		bool editOnUserTbl;

		public admin()
		{
			InitializeComponent();

			buttonDictionary.Add("userSetting", new LnbButtonInfo(userSettingPanel, userSettingLabel, "userTbl"));
            buttonDictionary.Add("movieSetting", new LnbButtonInfo(movieSettingPanel, movieSettingLabel, "movieTbl"));

            tableView.ScrollBars = ScrollBars.Both;

			db = new Utils.DBUtil();
            currentPage = "userSetting";
			//수정필요
			refreshData();
		}

		private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{
		}

		private void buttonFocus(object sender, EventArgs e)
		{
			Control con = (Control)sender;
			string name = con.Name.Split(new[] { "Label", "Panel" }, StringSplitOptions.None)[0];
			buttonDictionary[name]._LnbLabel.Font = new Font(buttonDictionary[name]._LnbLabel.Font.FontFamily, 12, FontStyle.Bold);

		}

		private void buttonLostFocus(object sender, EventArgs e)
		{
			Control con = (Control)sender;
			string name = con.Name.Split(new[] { "Label", "Panel" }, StringSplitOptions.None)[0];
			buttonDictionary[name]._LnbLabel.Font = new Font(buttonDictionary[name]._LnbLabel.Font.FontFamily, 12, FontStyle.Regular);
		}
		
		private void admin_Resize(object sender, EventArgs e)
		{
			adminLnb.Width = this.Width;
			lnbContentPanel.Width = this.Width;
			lnbContentPanel.Height = this.Height - 48;
			dataTablePanel.Width = this.Width - 6;
            dataTablePanel.Height = this.Height - 106;
		}

		public void refreshData()
		{
            if (currentPage.Equals("userSetting"))
            {
                DataTable dt = db.getUserList();
                tableView.DataSource = dt;
            }
		}

		private void dataEdited(object sender, DataGridViewCellEventArgs e)
		{
			
		}

		private void dataRevmoeButton_Click(object sender, EventArgs e)
		{

		}

		private void dataUpdateButton_Click(object sender, EventArgs e)
		{

		}

		private void dataInsertButton_Click(object sender, EventArgs e)
		{
			
		}

		private void dataRefreshButton_Click(object sender, EventArgs e)
		{
			refreshData();
		}
	}
}
