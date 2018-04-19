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
			this.userSettingContents = new System.Windows.Forms.Panel();
			this.dataTablePanel = new System.Windows.Forms.Panel();
			this.userTbl = new System.Windows.Forms.DataGridView();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.dataRefreshButton = new System.Windows.Forms.Button();
			this.dataInsertButton = new System.Windows.Forms.Button();
			this.dataUpdateButton = new System.Windows.Forms.Button();
			this.dataRevmoeButton = new System.Windows.Forms.Button();
			this.adminLnb.SuspendLayout();
			this.userSettingPanel.SuspendLayout();
			this.movieSettingPanel.SuspendLayout();
			this.cinemaSettingPanel.SuspendLayout();
			this.lnbContentPanel.SuspendLayout();
			this.userSettingContents.SuspendLayout();
			this.dataTablePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.userTbl)).BeginInit();
			this.flowLayoutPanel1.SuspendLayout();
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
			this.lnbContentPanel.BackColor = System.Drawing.Color.White;
			this.lnbContentPanel.Controls.Add(this.userSettingContents);
			this.lnbContentPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lnbContentPanel.Location = new System.Drawing.Point(0, 48);
			this.lnbContentPanel.Margin = new System.Windows.Forms.Padding(0);
			this.lnbContentPanel.Name = "lnbContentPanel";
			this.lnbContentPanel.Size = new System.Drawing.Size(935, 481);
			this.lnbContentPanel.TabIndex = 1;
			// 
			// userSettingContents
			// 
			this.userSettingContents.Controls.Add(this.flowLayoutPanel1);
			this.userSettingContents.Controls.Add(this.dataTablePanel);
			this.userSettingContents.Dock = System.Windows.Forms.DockStyle.Fill;
			this.userSettingContents.Location = new System.Drawing.Point(0, 0);
			this.userSettingContents.Name = "userSettingContents";
			this.userSettingContents.Size = new System.Drawing.Size(935, 481);
			this.userSettingContents.TabIndex = 0;
			// 
			// dataTablePanel
			// 
			this.dataTablePanel.AutoScroll = true;
			this.dataTablePanel.Controls.Add(this.userTbl);
			this.dataTablePanel.Location = new System.Drawing.Point(4, 55);
			this.dataTablePanel.Name = "dataTablePanel";
			this.dataTablePanel.Size = new System.Drawing.Size(928, 423);
			this.dataTablePanel.TabIndex = 1;
			// 
			// userTbl
			// 
			this.userTbl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
			this.userTbl.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
			this.userTbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.userTbl.Location = new System.Drawing.Point(0, 0);
			this.userTbl.Name = "userTbl";
			this.userTbl.RowTemplate.Height = 23;
			this.userTbl.Size = new System.Drawing.Size(928, 423);
			this.userTbl.TabIndex = 0;
			this.userTbl.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataEdited);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.dataRefreshButton);
			this.flowLayoutPanel1.Controls.Add(this.dataInsertButton);
			this.flowLayoutPanel1.Controls.Add(this.dataUpdateButton);
			this.flowLayoutPanel1.Controls.Add(this.dataRevmoeButton);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(431, 9);
			this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(501, 43);
			this.flowLayoutPanel1.TabIndex = 4;
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
			// dataInsertButton
			// 
			this.dataInsertButton.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.dataInsertButton.Location = new System.Drawing.Point(128, 3);
			this.dataInsertButton.Name = "dataInsertButton";
			this.dataInsertButton.Size = new System.Drawing.Size(119, 37);
			this.dataInsertButton.TabIndex = 4;
			this.dataInsertButton.Text = "데이터 추가";
			this.dataInsertButton.UseVisualStyleBackColor = true;
			// 
			// dataUpdateButton
			// 
			this.dataUpdateButton.Enabled = false;
			this.dataUpdateButton.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.dataUpdateButton.Location = new System.Drawing.Point(253, 3);
			this.dataUpdateButton.Name = "dataUpdateButton";
			this.dataUpdateButton.Size = new System.Drawing.Size(119, 37);
			this.dataUpdateButton.TabIndex = 5;
			this.dataUpdateButton.Text = "데이터 수정";
			this.dataUpdateButton.UseVisualStyleBackColor = true;
			// 
			// dataRevmoeButton
			// 
			this.dataRevmoeButton.Enabled = false;
			this.dataRevmoeButton.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.dataRevmoeButton.Location = new System.Drawing.Point(378, 3);
			this.dataRevmoeButton.Name = "dataRevmoeButton";
			this.dataRevmoeButton.Size = new System.Drawing.Size(119, 37);
			this.dataRevmoeButton.TabIndex = 6;
			this.dataRevmoeButton.Text = "데이터 삭제";
			this.dataRevmoeButton.UseVisualStyleBackColor = true;
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
			this.userSettingContents.ResumeLayout(false);
			this.dataTablePanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.userTbl)).EndInit();
			this.flowLayoutPanel1.ResumeLayout(false);
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
		private System.Windows.Forms.Panel userSettingContents;
		private System.Windows.Forms.DataGridView userTbl;
		private System.Windows.Forms.Panel dataTablePanel;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Button dataRefreshButton;
		private System.Windows.Forms.Button dataInsertButton;
		private System.Windows.Forms.Button dataUpdateButton;
		private System.Windows.Forms.Button dataRevmoeButton;
	}
}
