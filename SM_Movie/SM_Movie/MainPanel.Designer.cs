namespace SM_Movie
{
    partial class MainPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPanel));
            this.onpanel = new System.Windows.Forms.Panel();
            this.mainMovieSummaryBack = new System.Windows.Forms.Panel();
            this.mainMovieSummaryContent = new System.Windows.Forms.Label();
            this.mainMovieSummaryTitle = new System.Windows.Forms.Label();
            this.mainMovieIconBack = new System.Windows.Forms.Panel();
            this.mainMovieIcon = new System.Windows.Forms.PictureBox();
            this.BestMovieFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.BestMoviePanel1 = new System.Windows.Forms.Panel();
            this.movieTileSummary = new System.Windows.Forms.Label();
            this.movieTileDirector = new System.Windows.Forms.Label();
            this.movieTileTitle = new System.Windows.Forms.Label();
            this.BestMoviePanel4 = new System.Windows.Forms.Panel();
            this.BestMoviedirector4 = new System.Windows.Forms.Label();
            this.BestMovieTitle4 = new System.Windows.Forms.Label();
            this.BestMoviePicture4 = new System.Windows.Forms.PictureBox();
            this.mainMovieControlPanel = new System.Windows.Forms.Panel();
            this.onpanel.SuspendLayout();
            this.mainMovieSummaryBack.SuspendLayout();
            this.mainMovieIconBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainMovieIcon)).BeginInit();
            this.BestMovieFlow.SuspendLayout();
            this.BestMoviePanel1.SuspendLayout();
            this.BestMoviePanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BestMoviePicture4)).BeginInit();
            this.SuspendLayout();
            // 
            // onpanel
            // 
            this.onpanel.Controls.Add(this.mainMovieSummaryBack);
            this.onpanel.Controls.Add(this.mainMovieIconBack);
            this.onpanel.Location = new System.Drawing.Point(0, 0);
            this.onpanel.Margin = new System.Windows.Forms.Padding(0);
            this.onpanel.Name = "onpanel";
            this.onpanel.Size = new System.Drawing.Size(911, 247);
            this.onpanel.TabIndex = 13;
            // 
            // mainMovieSummaryBack
            // 
            this.mainMovieSummaryBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mainMovieSummaryBack.Controls.Add(this.mainMovieSummaryContent);
            this.mainMovieSummaryBack.Controls.Add(this.mainMovieSummaryTitle);
            this.mainMovieSummaryBack.Location = new System.Drawing.Point(617, 0);
            this.mainMovieSummaryBack.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.mainMovieSummaryBack.Name = "mainMovieSummaryBack";
            this.mainMovieSummaryBack.Size = new System.Drawing.Size(294, 244);
            this.mainMovieSummaryBack.TabIndex = 20;
            // 
            // mainMovieSummaryContent
            // 
            this.mainMovieSummaryContent.Font = new System.Drawing.Font("맑은 고딕 Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mainMovieSummaryContent.Location = new System.Drawing.Point(10, 98);
            this.mainMovieSummaryContent.Name = "mainMovieSummaryContent";
            this.mainMovieSummaryContent.Size = new System.Drawing.Size(267, 146);
            this.mainMovieSummaryContent.TabIndex = 18;
            this.mainMovieSummaryContent.Text = "램 레이지wlwlwlwlwlwlwlwllwlwlwl";
            // 
            // mainMovieSummaryTitle
            // 
            this.mainMovieSummaryTitle.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Bold);
            this.mainMovieSummaryTitle.Location = new System.Drawing.Point(3, 14);
            this.mainMovieSummaryTitle.Name = "mainMovieSummaryTitle";
            this.mainMovieSummaryTitle.Size = new System.Drawing.Size(288, 84);
            this.mainMovieSummaryTitle.TabIndex = 17;
            this.mainMovieSummaryTitle.Text = "램 레이지wlwlwlwlwlwlwlwllwlwlwl";
            // 
            // mainMovieIconBack
            // 
            this.mainMovieIconBack.BackColor = System.Drawing.Color.Black;
            this.mainMovieIconBack.Controls.Add(this.mainMovieIcon);
            this.mainMovieIconBack.Location = new System.Drawing.Point(0, 0);
            this.mainMovieIconBack.Margin = new System.Windows.Forms.Padding(0);
            this.mainMovieIconBack.Name = "mainMovieIconBack";
            this.mainMovieIconBack.Size = new System.Drawing.Size(617, 244);
            this.mainMovieIconBack.TabIndex = 19;
            // 
            // mainMovieIcon
            // 
            this.mainMovieIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainMovieIcon.Image = ((System.Drawing.Image)(resources.GetObject("mainMovieIcon.Image")));
            this.mainMovieIcon.Location = new System.Drawing.Point(0, 0);
            this.mainMovieIcon.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.mainMovieIcon.Name = "mainMovieIcon";
            this.mainMovieIcon.Size = new System.Drawing.Size(617, 244);
            this.mainMovieIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainMovieIcon.TabIndex = 11;
            this.mainMovieIcon.TabStop = false;
            // 
            // BestMovieFlow
            // 
            this.BestMovieFlow.AutoScroll = true;
            this.BestMovieFlow.Controls.Add(this.BestMoviePanel1);
            this.BestMovieFlow.Controls.Add(this.BestMoviePanel4);
            this.BestMovieFlow.Location = new System.Drawing.Point(0, 274);
            this.BestMovieFlow.Margin = new System.Windows.Forms.Padding(0);
            this.BestMovieFlow.Name = "BestMovieFlow";
            this.BestMovieFlow.Padding = new System.Windows.Forms.Padding(3);
            this.BestMovieFlow.Size = new System.Drawing.Size(911, 426);
            this.BestMovieFlow.TabIndex = 15;
            // 
            // BestMoviePanel1
            // 
            this.BestMoviePanel1.BackgroundImage = global::SM_Movie.Properties.Resources.minimize;
            this.BestMoviePanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BestMoviePanel1.Controls.Add(this.movieTileSummary);
            this.BestMoviePanel1.Controls.Add(this.movieTileDirector);
            this.BestMoviePanel1.Controls.Add(this.movieTileTitle);
            this.BestMoviePanel1.Location = new System.Drawing.Point(6, 6);
            this.BestMoviePanel1.Name = "BestMoviePanel1";
            this.BestMoviePanel1.Size = new System.Drawing.Size(199, 295);
            this.BestMoviePanel1.TabIndex = 19;
            // 
            // movieTileSummary
            // 
            this.movieTileSummary.BackColor = System.Drawing.Color.Transparent;
            this.movieTileSummary.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.movieTileSummary.Location = new System.Drawing.Point(19, 264);
            this.movieTileSummary.Name = "movieTileSummary";
            this.movieTileSummary.Size = new System.Drawing.Size(168, 85);
            this.movieTileSummary.TabIndex = 9;
            this.movieTileSummary.Text = "스티븐 스필버그";
            this.movieTileSummary.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // movieTileDirector
            // 
            this.movieTileDirector.BackColor = System.Drawing.Color.Transparent;
            this.movieTileDirector.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.movieTileDirector.Location = new System.Drawing.Point(19, 245);
            this.movieTileDirector.Name = "movieTileDirector";
            this.movieTileDirector.Size = new System.Drawing.Size(168, 19);
            this.movieTileDirector.TabIndex = 8;
            this.movieTileDirector.Text = "스티븐 스필버그";
            this.movieTileDirector.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // movieTileTitle
            // 
            this.movieTileTitle.BackColor = System.Drawing.Color.Transparent;
            this.movieTileTitle.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.movieTileTitle.Location = new System.Drawing.Point(17, 217);
            this.movieTileTitle.Name = "movieTileTitle";
            this.movieTileTitle.Size = new System.Drawing.Size(168, 28);
            this.movieTileTitle.TabIndex = 7;
            this.movieTileTitle.Text = "레디 플레이어 원";
            this.movieTileTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BestMoviePanel4
            // 
            this.BestMoviePanel4.Controls.Add(this.BestMoviedirector4);
            this.BestMoviePanel4.Controls.Add(this.BestMovieTitle4);
            this.BestMoviePanel4.Controls.Add(this.BestMoviePicture4);
            this.BestMoviePanel4.Location = new System.Drawing.Point(233, 28);
            this.BestMoviePanel4.Margin = new System.Windows.Forms.Padding(25);
            this.BestMoviePanel4.Name = "BestMoviePanel4";
            this.BestMoviePanel4.Size = new System.Drawing.Size(174, 270);
            this.BestMoviePanel4.TabIndex = 22;
            // 
            // BestMoviedirector4
            // 
            this.BestMoviedirector4.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BestMoviedirector4.Location = new System.Drawing.Point(3, 220);
            this.BestMoviedirector4.Name = "BestMoviedirector4";
            this.BestMoviedirector4.Size = new System.Drawing.Size(168, 13);
            this.BestMoviedirector4.TabIndex = 8;
            this.BestMoviedirector4.Text = "스티븐 스필버그";
            this.BestMoviedirector4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BestMovieTitle4
            // 
            this.BestMovieTitle4.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BestMovieTitle4.Location = new System.Drawing.Point(3, 192);
            this.BestMovieTitle4.Name = "BestMovieTitle4";
            this.BestMovieTitle4.Size = new System.Drawing.Size(168, 19);
            this.BestMovieTitle4.TabIndex = 7;
            this.BestMovieTitle4.Text = "레디 플레이어 원";
            this.BestMovieTitle4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BestMoviePicture4
            // 
            this.BestMoviePicture4.Location = new System.Drawing.Point(0, 0);
            this.BestMoviePicture4.Margin = new System.Windows.Forms.Padding(0);
            this.BestMoviePicture4.Name = "BestMoviePicture4";
            this.BestMoviePicture4.Size = new System.Drawing.Size(174, 182);
            this.BestMoviePicture4.TabIndex = 6;
            this.BestMoviePicture4.TabStop = false;
            // 
            // mainMovieControlPanel
            // 
            this.mainMovieControlPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainMovieControlPanel.Location = new System.Drawing.Point(0, 250);
            this.mainMovieControlPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainMovieControlPanel.Name = "mainMovieControlPanel";
            this.mainMovieControlPanel.Size = new System.Drawing.Size(911, 24);
            this.mainMovieControlPanel.TabIndex = 12;
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.BestMovieFlow);
            this.Controls.Add(this.onpanel);
            this.Controls.Add(this.mainMovieControlPanel);
            this.Name = "MainPanel";
            this.Size = new System.Drawing.Size(911, 700);
            this.Load += new System.EventHandler(this.MainPanel_Load);
            this.Resize += new System.EventHandler(this.MainPanel_Resize);
            this.onpanel.ResumeLayout(false);
            this.mainMovieSummaryBack.ResumeLayout(false);
            this.mainMovieIconBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainMovieIcon)).EndInit();
            this.BestMovieFlow.ResumeLayout(false);
            this.BestMoviePanel1.ResumeLayout(false);
            this.BestMoviePanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BestMoviePicture4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel onpanel;
        private System.Windows.Forms.FlowLayoutPanel BestMovieFlow;
        private System.Windows.Forms.Panel mainMovieIconBack;
        private System.Windows.Forms.PictureBox mainMovieIcon;
        private System.Windows.Forms.Panel mainMovieSummaryBack;
        private System.Windows.Forms.Label mainMovieSummaryTitle;
        private System.Windows.Forms.Label mainMovieSummaryContent;
        private System.Windows.Forms.Panel mainMovieControlPanel;
        private System.Windows.Forms.Panel BestMoviePanel1;
        private System.Windows.Forms.Label movieTileDirector;
        private System.Windows.Forms.Label movieTileTitle;
        private System.Windows.Forms.Panel BestMoviePanel4;
        private System.Windows.Forms.Label BestMoviedirector4;
        private System.Windows.Forms.Label BestMovieTitle4;
        private System.Windows.Forms.PictureBox BestMoviePicture4;
        private System.Windows.Forms.Label movieTileSummary;
    }
}
