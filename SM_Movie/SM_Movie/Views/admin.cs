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
        bool currentPageEdited;
        int currentSeq;

		public admin()
		{
			InitializeComponent();

			buttonDictionary.Add("userSetting", new LnbButtonInfo(userSettingPanel, userSettingLabel, "userTbl"));
            buttonDictionary.Add("movieSetting", new LnbButtonInfo(movieSettingPanel, movieSettingLabel, "movieTbl"));

            tableView.ScrollBars = ScrollBars.Both;

            if(db == null)
			    db = new Utils.DBUtil();
            currentPage = "userSetting";
			//수정필요
			refreshData();

            currentSeq = db.getLastSeq("userTbl");
		}

		private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{
		}

		private void buttonFocus(object sender, EventArgs e)
		{
			Control con = (Control)sender;
			string name = con.Name.Split(new[] { "Label", "Panel" }, StringSplitOptions.None)[0];
            if (name.Equals(currentPage))
                return;
			buttonDictionary[name]._LnbLabel.Font = new Font(buttonDictionary[name]._LnbLabel.Font.FontFamily, 12, FontStyle.Bold);

		}

		private void buttonLostFocus(object sender, EventArgs e)
		{
			Control con = (Control)sender;
			string name = con.Name.Split(new[] { "Label", "Panel" }, StringSplitOptions.None)[0];
            if (name.Equals(currentPage))
                return;
            buttonDictionary[name]._LnbLabel.Font = new Font(buttonDictionary[name]._LnbLabel.Font.FontFamily, 12, FontStyle.Regular);
		}

        private void openPage(object sender, EventArgs e)
        {
            Control con = (Control)sender;
            string name = con.Name.Split(new[] { "Label", "Panel" }, StringSplitOptions.None)[0];
            buttonDictionary[currentPage]._LnbLabel.Font = new Font(buttonDictionary[name]._LnbLabel.Font.FontFamily, 12, FontStyle.Regular);
            currentPage = name;
            buttonDictionary[name]._LnbLabel.Font = new Font(buttonDictionary[name]._LnbLabel.Font.FontFamily, 12, FontStyle.Bold);
            refreshData();
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
            tableView.DataSource = null;
            tableView.Rows.Clear();
            
            if (currentPage.Equals("userSetting"))
            {
                DataTable dt = db.getUserList();
                tableView.DataSource = dt;
            }
		}

		private void dataEdited(object sender, DataGridViewCellEventArgs e)
        {
            currentPageEdited = true;
            dataUpdateButton.Enabled = currentPageEdited;
		}

		private void dataRevmoeButton_Click(object sender, EventArgs e)
		{
            int selectedCellCount =
                tableView.GetCellCount(DataGridViewElementStates.Selected);

            if(selectedCellCount > 0 && tableView.RowCount > 1)
            {
                if(MessageBox.Show("선택하신 항목을 삭제하시겠습니까?", "알림", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int rowindex = tableView.CurrentCell.RowIndex;
                    tableView.Rows.RemoveAt(rowindex);
                    if (tableView.RowCount > 1)
                    {
                        dataRemoveButton.Enabled = true;
                    }
                    else
                    {
                        dataRemoveButton.Enabled = false;
                    }
                    currentPageEdited = true;
                    dataUpdateButton.Enabled = true;
                }
            }
		}

		private void dataUpdateButton_Click(object sender, EventArgs e)
		{
            db.updateUserList((DataTable)tableView.DataSource);
		}

        private void tableView_SelectionChanged(object sender, EventArgs e)
        {
            int selectedCellCount =
                tableView.GetCellCount(DataGridViewElementStates.Selected);
            if(selectedCellCount > 0)
            {
                dataRemoveButton.Enabled = true;
            }
            else
            {
                dataRemoveButton.Enabled = false;
            }
        }

        private void tableView_DataMemberChanged(object sender, EventArgs e)
        {

        }

        private void tableView_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            
        }
    }
}
