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

		Dictionary<string, LnbButtonInfo> buttonDictionary = new Dictionary<string, LnbButtonInfo>();
		Utils.DBUtil db;

		bool editOnUserTbl;

		public admin()
		{
			InitializeComponent();

			buttonDictionary.Add("userSetting", new LnbButtonInfo(userSettingPanel, userSettingLabel, userSettingContents));
			buttonDictionary.Add("movieSetting", new LnbButtonInfo(movieSettingPanel, movieSettingLabel, userSettingContents));

			
			userTbl.ScrollBars = ScrollBars.Both;

			db = new Utils.DBUtil();

			//수정필요
			refreshData("userTbl");
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
		}

		public void refreshData(string table)
		{
			DataGridView tab;
			switch(table)
			{
				case "userTbl":
					tab = userTbl;
					tab.DataSource = db.getUserList();
					break;
				default:
					return;
			}
			tab.Rows[0].Frozen = false;
			tab.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.ColumnHeader);
			tab.FirstDisplayedScrollingRowIndex = userTbl.RowCount - 1;
		}

		private void dataEdited(object sender, DataGridViewCellEventArgs e)
		{
			switch(((Control)sender).Name)
			{
				case "userTbl":
					editOnUserTbl = true;
					break;
			}

			if(userTbl.Visible == true && editOnUserTbl)
			{
				dataUpdateButton.Enabled = true;
			}
		}

		private void dataRevmoeButton_Click(object sender, EventArgs e)
		{

		}

		private void dataUpdateButton_Click(object sender, EventArgs e)
		{

		}

		private void dataInsertButton_Click(object sender, EventArgs e)
		{
			int lastSeq = db.getLastSeq("userTbl");
			if(lastSeq == -1)
			{
				return;
			}
			userTbl.Rows.Add(lastSeq, null, null, null, null, null, null, null, null, null);
		}

		private void dataRefreshButton_Click(object sender, EventArgs e)
		{
			refreshData("userTbl");
		}
	}
}
