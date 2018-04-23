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
            this.mainMovie = new System.Windows.Forms.Panel();
            this.mainMovieSummaryBack = new System.Windows.Forms.Panel();
            this.mainMovieSummaryContent = new System.Windows.Forms.Label();
            this.mainMovieSummaryTitle = new System.Windows.Forms.Label();
            this.mainMovieIconBack = new System.Windows.Forms.Panel();
            this.mainMovieIcon = new System.Windows.Forms.PictureBox();
            this.BestMovieFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.bestMoviePanel = new System.Windows.Forms.Panel();
            this.bestMovieContentBack = new System.Windows.Forms.Panel();
            this.bestMovieSummary = new System.Windows.Forms.Label();
            this.bestMovieTitle = new System.Windows.Forms.Label();
            this.bestMovieDirector = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mainMovieControlPanel = new System.Windows.Forms.Panel();
            this.mainControlFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.mainMovie.SuspendLayout();
            this.mainMovieSummaryBack.SuspendLayout();
            this.mainMovieIconBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainMovieIcon)).BeginInit();
            this.BestMovieFlow.SuspendLayout();
            this.bestMoviePanel.SuspendLayout();
            this.bestMovieContentBack.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.mainMovieControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMovie
            // 
            this.mainMovie.Controls.Add(this.mainMovieSummaryBack);
            this.mainMovie.Controls.Add(this.mainMovieIconBack);
            this.mainMovie.Location = new System.Drawing.Point(0, 0);
            this.mainMovie.Margin = new System.Windows.Forms.Padding(0);
            this.mainMovie.Name = "mainMovie";
            this.mainMovie.Size = new System.Drawing.Size(911, 247);
            this.mainMovie.TabIndex = 13;
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
            this.mainMovieIconBack.Size = new System.Drawing.Size(617, 247);
            this.mainMovieIconBack.TabIndex = 19;
            // 
            // mainMovieIcon
            // 
            this.mainMovieIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainMovieIcon.Image = ((System.Drawing.Image)(resources.GetObject("mainMovieIcon.Image")));
            this.mainMovieIcon.Location = new System.Drawing.Point(0, 0);
            this.mainMovieIcon.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.mainMovieIcon.Name = "mainMovieIcon";
            this.mainMovieIcon.Size = new System.Drawing.Size(617, 247);
            this.mainMovieIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainMovieIcon.TabIndex = 11;
            this.mainMovieIcon.TabStop = false;
            // 
            // BestMovieFlow
            // 
            this.BestMovieFlow.Controls.Add(this.bestMoviePanel);
            this.BestMovieFlow.Controls.Add(this.panel1);
            this.BestMovieFlow.Controls.Add(this.panel3);
            this.BestMovieFlow.Location = new System.Drawing.Point(0, 274);
            this.BestMovieFlow.Margin = new System.Windows.Forms.Padding(0);
            this.BestMovieFlow.Name = "BestMovieFlow";
            this.BestMovieFlow.Padding = new System.Windows.Forms.Padding(3);
            this.BestMovieFlow.Size = new System.Drawing.Size(911, 426);
            this.BestMovieFlow.TabIndex = 15;
            // 
            // bestMoviePanel
            // 
            this.bestMoviePanel.BackgroundImage = global::SM_Movie.Properties.Resources.minimize;
            this.bestMoviePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bestMoviePanel.Controls.Add(this.bestMovieContentBack);
            this.bestMoviePanel.Location = new System.Drawing.Point(6, 6);
            this.bestMoviePanel.Name = "bestMoviePanel";
            this.bestMoviePanel.Size = new System.Drawing.Size(199, 295);
            this.bestMoviePanel.TabIndex = 19;
            // 
            // bestMovieContentBack
            // 
            this.bestMovieContentBack.BackColor = System.Drawing.Color.Transparent;
            this.bestMovieContentBack.Controls.Add(this.bestMovieSummary);
            this.bestMovieContentBack.Controls.Add(this.bestMovieTitle);
            this.bestMovieContentBack.Controls.Add(this.bestMovieDirector);
            this.bestMovieContentBack.Location = new System.Drawing.Point(10, 10);
            this.bestMovieContentBack.Margin = new System.Windows.Forms.Padding(10);
            this.bestMovieContentBack.Name = "bestMovieContentBack";
            this.bestMovieContentBack.Size = new System.Drawing.Size(179, 275);
            this.bestMovieContentBack.TabIndex = 10;
            // 
            // bestMovieSummary
            // 
            this.bestMovieSummary.AutoSize = true;
            this.bestMovieSummary.BackColor = System.Drawing.Color.Transparent;
            this.bestMovieSummary.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bestMovieSummary.Location = new System.Drawing.Point(9, 300);
            this.bestMovieSummary.MaximumSize = new System.Drawing.Size(165, 0);
            this.bestMovieSummary.Name = "bestMovieSummary";
            this.bestMovieSummary.Size = new System.Drawing.Size(163, 75);
            this.bestMovieSummary.TabIndex = 9;
            this.bestMovieSummary.Text = "줄거리줄거리줄거리줄거리줄거리줄거리줄거리줄거리줄거리줄거리줄거리줄거리줄거리줄거리줄거리줄거리줄거리줄거리줄거리줄거리";
            // 
            // bestMovieTitle
            // 
            this.bestMovieTitle.BackColor = System.Drawing.Color.Transparent;
            this.bestMovieTitle.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bestMovieTitle.Location = new System.Drawing.Point(7, 200);
            this.bestMovieTitle.Name = "bestMovieTitle";
            this.bestMovieTitle.Size = new System.Drawing.Size(168, 28);
            this.bestMovieTitle.TabIndex = 7;
            this.bestMovieTitle.Text = "레디 플레이어 원";
            this.bestMovieTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bestMovieDirector
            // 
            this.bestMovieDirector.BackColor = System.Drawing.Color.Transparent;
            this.bestMovieDirector.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bestMovieDirector.Location = new System.Drawing.Point(9, 235);
            this.bestMovieDirector.Name = "bestMovieDirector";
            this.bestMovieDirector.Size = new System.Drawing.Size(168, 19);
            this.bestMovieDirector.TabIndex = 8;
            this.bestMovieDirector.Text = "스티븐 스필버그";
            this.bestMovieDirector.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::SM_Movie.Properties.Resources.minimize;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(211, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 295);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(10, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(179, 275);
            this.panel2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(9, 300);
            this.label1.MaximumSize = new System.Drawing.Size(165, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 75);
            this.label1.TabIndex = 9;
            this.label1.Text = "줄거리줄거리줄거리줄거리줄거리줄거리줄거리줄거리줄거리줄거리줄거리줄거리줄거리줄거리줄거리줄거리줄거리줄거리줄거리줄거리";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(7, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "레디 플레이어 원";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(9, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "스티븐 스필버그";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::SM_Movie.Properties.Resources.minimize;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(416, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(199, 295);
            this.panel3.TabIndex = 21;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(10, 10);
            this.panel4.Margin = new System.Windows.Forms.Padding(10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(179, 275);
            this.panel4.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(9, 300);
            this.label4.MaximumSize = new System.Drawing.Size(165, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 75);
            this.label4.TabIndex = 9;
            this.label4.Text = "줄거리줄거리줄거리줄거리줄거리줄거리줄거리줄거리줄거리줄거리줄거리줄거리줄거리줄거리줄거리줄거리줄거리줄거리줄거리줄거리";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(7, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "레디 플레이어 원";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(9, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "스티븐 스필버그";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mainMovieControlPanel
            // 
            this.mainMovieControlPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainMovieControlPanel.Controls.Add(this.mainControlFlow);
            this.mainMovieControlPanel.Location = new System.Drawing.Point(0, 250);
            this.mainMovieControlPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainMovieControlPanel.Name = "mainMovieControlPanel";
            this.mainMovieControlPanel.Size = new System.Drawing.Size(911, 24);
            this.mainMovieControlPanel.TabIndex = 12;
            // 
            // mainControlFlow
            // 
            this.mainControlFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainControlFlow.Location = new System.Drawing.Point(0, 0);
            this.mainControlFlow.Name = "mainControlFlow";
            this.mainControlFlow.Size = new System.Drawing.Size(911, 24);
            this.mainControlFlow.TabIndex = 0;
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.BestMovieFlow);
            this.Controls.Add(this.mainMovie);
            this.Controls.Add(this.mainMovieControlPanel);
            this.Name = "MainPanel";
            this.Size = new System.Drawing.Size(911, 700);
            this.Load += new System.EventHandler(this.MainPanel_Load);
            this.Resize += new System.EventHandler(this.MainPanel_Resize);
            this.mainMovie.ResumeLayout(false);
            this.mainMovieSummaryBack.ResumeLayout(false);
            this.mainMovieIconBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainMovieIcon)).EndInit();
            this.BestMovieFlow.ResumeLayout(false);
            this.bestMoviePanel.ResumeLayout(false);
            this.bestMovieContentBack.ResumeLayout(false);
            this.bestMovieContentBack.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.mainMovieControlPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel mainMovie;
        private System.Windows.Forms.FlowLayoutPanel BestMovieFlow;
        private System.Windows.Forms.Panel mainMovieIconBack;
        private System.Windows.Forms.PictureBox mainMovieIcon;
        private System.Windows.Forms.Panel mainMovieSummaryBack;
        private System.Windows.Forms.Label mainMovieSummaryTitle;
        private System.Windows.Forms.Label mainMovieSummaryContent;
        private System.Windows.Forms.Panel mainMovieControlPanel;
        private System.Windows.Forms.Panel bestMoviePanel;
        private System.Windows.Forms.Label bestMovieDirector;
        private System.Windows.Forms.Label bestMovieTitle;
        private System.Windows.Forms.Label bestMovieSummary;
        private System.Windows.Forms.Panel bestMovieContentBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel mainControlFlow;
    }
}
