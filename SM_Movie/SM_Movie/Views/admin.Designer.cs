namespace SM_Movie.Views
{
	partial class admin
	{
		/// <summary> 
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region 구성 요소 디자이너에서 생성한 코드

		/// <summary> 
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
            this.adminLnb = new System.Windows.Forms.FlowLayoutPanel();
            this.userSettingPanel = new System.Windows.Forms.Panel();
            this.userSettingLabel = new System.Windows.Forms.Label();
            this.movieSettingPanel = new System.Windows.Forms.Panel();
            this.movieSettingLabel = new System.Windows.Forms.Label();
            this.cinemaSettingPanel = new System.Windows.Forms.Panel();
            this.cinemaSettingLabel = new System.Windows.Forms.Label();
            this.lnbContentPanel = new System.Windows.Forms.Panel();
            this.dataButtonFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.dataRefreshButton = new System.Windows.Forms.Button();
            this.dataUpdateButton = new System.Windows.Forms.Button();
            this.dataRemoveButton = new System.Windows.Forms.Button();
            this.dataTablePanel = new System.Windows.Forms.Panel();
            this.tableView = new System.Windows.Forms.DataGridView();
            this.adminLnb.SuspendLayout();
            this.userSettingPanel.SuspendLayout();
            this.movieSettingPanel.SuspendLayout();
            this.cinemaSettingPanel.SuspendLayout();
            this.lnbContentPanel.SuspendLayout();
            this.dataButtonFlow.SuspendLayout();
            this.dataTablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableView)).BeginInit();
            this.SuspendLayout();
            // 
            // adminLnb
            // 
            this.adminLnb.Controls.Add(this.userSettingPanel);
            this.adminLnb.Controls.Add(this.movieSettingPanel);
            this.adminLnb.Controls.Add(this.cinemaSettingPanel);
            this.adminLnb.Dock = System.Windows.Forms.DockStyle.Top;
            this.adminLnb.Location = new System.Drawing.Point(0, 0);
            this.adminLnb.Margin = new System.Windows.Forms.Padding(0);
            this.adminLnb.Name = "adminLnb";
            this.adminLnb.Size = new System.Drawing.Size(935, 48);
            this.adminLnb.TabIndex = 0;
            this.adminLnb.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // userSettingPanel
            // 
            this.userSettingPanel.Controls.Add(this.userSettingLabel);
            this.userSettingPanel.Location = new System.Drawing.Point(0, 0);
            this.userSettingPanel.Margin = new System.Windows.Forms.Padding(0);
            this.userSettingPanel.Name = "userSettingPanel";
            this.userSettingPanel.Size = new System.Drawing.Size(100, 48);
            this.userSettingPanel.TabIndex = 1;
            // 
            // userSettingLabel
            // 
            this.userSettingLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userSettingLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userSettingLabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userSettingLabel.Location = new System.Drawing.Point(0, 0);
            this.userSettingLabel.Name = "userSettingLabel";
            this.userSettingLabel.Size = new System.Drawing.Size(100, 48);
            this.userSettingLabel.TabIndex = 0;
            this.userSettingLabel.Text = "회원 관리";
            this.userSettingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.userSettingLabel.Click += new System.EventHandler(this.openPage);
            this.userSettingLabel.MouseEnter += new System.EventHandler(this.buttonFocus);
            this.userSettingLabel.MouseLeave += new System.EventHandler(this.buttonLostFocus);
            // 
            // movieSettingPanel
            // 
            this.movieSettingPanel.Controls.Add(this.movieSettingLabel);
            this.movieSettingPanel.Location = new System.Drawing.Point(100, 0);
            this.movieSettingPanel.Margin = new System.Windows.Forms.Padding(0);
            this.movieSettingPanel.Name = "movieSettingPanel";
            this.movieSettingPanel.Size = new System.Drawing.Size(100, 48);
            this.movieSettingPanel.TabIndex = 2;
            // 
            // movieSettingLabel
            // 
            this.movieSettingLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.movieSettingLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.movieSettingLabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.movieSettingLabel.Location = new System.Drawing.Point(0, 0);
            this.movieSettingLabel.Name = "movieSettingLabel";
            this.movieSettingLabel.Size = new System.Drawing.Size(100, 48);
            this.movieSettingLabel.TabIndex = 0;
            this.movieSettingLabel.Text = "영화 관리";
            this.movieSettingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.movieSettingLabel.Click += new System.EventHandler(this.openPage);
            this.movieSettingLabel.MouseEnter += new System.EventHandler(this.buttonFocus);
            this.movieSettingLabel.MouseLeave += new System.EventHandler(this.buttonLostFocus);
            // 
            // cinemaSettingPanel
            // 
            this.cinemaSettingPanel.Controls.Add(this.cinemaSettingLabel);
            this.cinemaSettingPanel.Location = new System.Drawing.Point(200, 0);
            this.cinemaSettingPanel.Margin = new System.Windows.Forms.Padding(0);
            this.cinemaSettingPanel.Name = "cinemaSettingPanel";
            this.cinemaSettingPanel.Size = new System.Drawing.Size(100, 48);
            this.cinemaSettingPanel.TabIndex = 2;
            // 
            // cinemaSettingLabel
            // 
            this.cinemaSettingLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cinemaSettingLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cinemaSettingLabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cinemaSettingLabel.Location = new System.Drawing.Point(0, 0);
            this.cinemaSettingLabel.Name = "cinemaSettingLabel";
            this.cinemaSettingLabel.Size = new System.Drawing.Size(100, 48);
            this.cinemaSettingLabel.TabIndex = 0;
            this.cinemaSettingLabel.Text = "상영관 관리";
            this.cinemaSettingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lnbContentPanel
            // 
            this.lnbContentPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lnbContentPanel.Controls.Add(this.dataButtonFlow);
            this.lnbContentPanel.Controls.Add(this.dataTablePanel);
            this.lnbContentPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lnbContentPanel.Location = new System.Drawing.Point(0, 48);
            this.lnbContentPanel.Margin = new System.Windows.Forms.Padding(0);
            this.lnbContentPanel.Name = "lnbContentPanel";
            this.lnbContentPanel.Size = new System.Drawing.Size(935, 481);
            this.lnbContentPanel.TabIndex = 1;
            // 
            // dataButtonFlow
            // 
            this.dataButtonFlow.Controls.Add(this.dataRefreshButton);
            this.dataButtonFlow.Controls.Add(this.dataUpdateButton);
            this.dataButtonFlow.Controls.Add(this.dataRemoveButton);
            this.dataButtonFlow.Location = new System.Drawing.Point(556, 6);
            this.dataButtonFlow.Margin = new System.Windows.Forms.Padding(0);
            this.dataButtonFlow.Name = "dataButtonFlow";
            this.dataButtonFlow.Size = new System.Drawing.Size(375, 43);
            this.dataButtonFlow.TabIndex = 6;
            // 
            // dataRefreshButton
            // 
            this.dataRefreshButton.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dataRefreshButton.Location = new System.Drawing.Point(3, 3);
            this.dataRefreshButton.Name = "dataRefreshButton";
            this.dataRefreshButton.Size = new System.Drawing.Size(119, 37);
            this.dataRefreshButton.TabIndex = 3;
            this.dataRefreshButton.Text = "데이터 새로고침";
            this.dataRefreshButton.UseVisualStyleBackColor = true;
            // 
            // dataUpdateButton
            // 
            this.dataUpdateButton.Enabled = false;
            this.dataUpdateButton.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dataUpdateButton.Location = new System.Drawing.Point(128, 3);
            this.dataUpdateButton.Name = "dataUpdateButton";
            this.dataUpdateButton.Size = new System.Drawing.Size(119, 37);
            this.dataUpdateButton.TabIndex = 5;
            this.dataUpdateButton.Text = "변경사항 적용";
            this.dataUpdateButton.UseVisualStyleBackColor = true;
            this.dataUpdateButton.Click += new System.EventHandler(this.dataUpdateButton_Click);
            // 
            // dataRemoveButton
            // 
            this.dataRemoveButton.Enabled = false;
            this.dataRemoveButton.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dataRemoveButton.Location = new System.Drawing.Point(253, 3);
            this.dataRemoveButton.Name = "dataRemoveButton";
            this.dataRemoveButton.Size = new System.Drawing.Size(119, 37);
            this.dataRemoveButton.TabIndex = 6;
            this.dataRemoveButton.Text = "데이터 삭제";
            this.dataRemoveButton.UseVisualStyleBackColor = true;
            this.dataRemoveButton.Click += new System.EventHandler(this.dataRevmoeButton_Click);
            // 
            // dataTablePanel
            // 
            this.dataTablePanel.AutoScroll = true;
            this.dataTablePanel.Controls.Add(this.tableView);
            this.dataTablePanel.Location = new System.Drawing.Point(3, 52);
            this.dataTablePanel.Name = "dataTablePanel";
            this.dataTablePanel.Size = new System.Drawing.Size(928, 423);
            this.dataTablePanel.TabIndex = 5;
            // 
            // tableView
            // 
            this.tableView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.tableView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.tableView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableView.Location = new System.Drawing.Point(0, 0);
            this.tableView.Name = "tableView";
            this.tableView.RowTemplate.Height = 23;
            this.tableView.Size = new System.Drawing.Size(928, 423);
            this.tableView.TabIndex = 0;
            this.tableView.DataMemberChanged += new System.EventHandler(this.tableView_DataMemberChanged);
            this.tableView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataEdited);
            this.tableView.SelectionChanged += new System.EventHandler(this.tableView_SelectionChanged);
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lnbContentPanel);
            this.Controls.Add(this.adminLnb);
            this.Name = "admin";
            this.Size = new System.Drawing.Size(935, 529);
            this.Resize += new System.EventHandler(this.admin_Resize);
            this.adminLnb.ResumeLayout(false);
            this.userSettingPanel.ResumeLayout(false);
            this.movieSettingPanel.ResumeLayout(false);
            this.cinemaSettingPanel.ResumeLayout(false);
            this.lnbContentPanel.ResumeLayout(false);
            this.dataButtonFlow.ResumeLayout(false);
            this.dataTablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableView)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel adminLnb;
		private System.Windows.Forms.Label userSettingLabel;
		private System.Windows.Forms.Panel userSettingPanel;
		private System.Windows.Forms.Panel movieSettingPanel;
		private System.Windows.Forms.Label movieSettingLabel;
		private System.Windows.Forms.Panel cinemaSettingPanel;
		private System.Windows.Forms.Label cinemaSettingLabel;
		private System.Windows.Forms.Panel lnbContentPanel;
        private System.Windows.Forms.FlowLayoutPanel dataButtonFlow;
        private System.Windows.Forms.Button dataRefreshButton;
        private System.Windows.Forms.Button dataUpdateButton;
        private System.Windows.Forms.Button dataRemoveButton;
        private System.Windows.Forms.Panel dataTablePanel;
        private System.Windows.Forms.DataGridView tableView;
    }
}
