namespace SM_Movie
{
    partial class Movieinformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Movieinformation));
            this.MovieContents = new System.Windows.Forms.Panel();
            this.genreSeq = new System.Windows.Forms.Label();
            this.movieRunningTime = new System.Windows.Forms.Label();
            this.movieReleaseDate = new System.Windows.Forms.Label();
            this.movieDirector = new System.Windows.Forms.Label();
            this.movieAgeLimit = new System.Windows.Forms.Label();
            this.movieMainActor = new System.Windows.Forms.Label();
            this.movieTitle = new System.Windows.Forms.Label();
            this.underscore = new System.Windows.Forms.PictureBox();
            this.Summary = new System.Windows.Forms.Label();
            this.MovieSummary = new System.Windows.Forms.Label();
            this.moviePoster = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MovieContents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.underscore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviePoster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MovieContents
            // 
            this.MovieContents.BackColor = System.Drawing.SystemColors.Window;
            this.MovieContents.Controls.Add(this.genreSeq);
            this.MovieContents.Controls.Add(this.movieRunningTime);
            this.MovieContents.Controls.Add(this.movieReleaseDate);
            this.MovieContents.Controls.Add(this.movieDirector);
            this.MovieContents.Controls.Add(this.movieAgeLimit);
            this.MovieContents.Controls.Add(this.movieMainActor);
            this.MovieContents.Controls.Add(this.movieTitle);
            this.MovieContents.Controls.Add(this.underscore);
            this.MovieContents.Controls.Add(this.Summary);
            this.MovieContents.Controls.Add(this.MovieSummary);
            this.MovieContents.Controls.Add(this.moviePoster);
            this.MovieContents.Controls.Add(this.pictureBox1);
            this.MovieContents.Location = new System.Drawing.Point(3, 3);
            this.MovieContents.Name = "MovieContents";
            this.MovieContents.Size = new System.Drawing.Size(897, 647);
            this.MovieContents.TabIndex = 0;
            // 
            // genreSeq
            // 
            this.genreSeq.AutoSize = true;
            this.genreSeq.Location = new System.Drawing.Point(279, 224);
            this.genreSeq.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.genreSeq.Name = "genreSeq";
            this.genreSeq.Size = new System.Drawing.Size(41, 12);
            this.genreSeq.TabIndex = 6;
            this.genreSeq.Text = "장르  :";
            // 
            // movieRunningTime
            // 
            this.movieRunningTime.AutoSize = true;
            this.movieRunningTime.Location = new System.Drawing.Point(275, 246);
            this.movieRunningTime.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.movieRunningTime.Name = "movieRunningTime";
            this.movieRunningTime.Size = new System.Drawing.Size(65, 12);
            this.movieRunningTime.TabIndex = 8;
            this.movieRunningTime.Text = "상영시간  :";
            // 
            // movieReleaseDate
            // 
            this.movieReleaseDate.AutoSize = true;
            this.movieReleaseDate.Location = new System.Drawing.Point(279, 136);
            this.movieReleaseDate.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.movieReleaseDate.Name = "movieReleaseDate";
            this.movieReleaseDate.Size = new System.Drawing.Size(53, 12);
            this.movieReleaseDate.TabIndex = 7;
            this.movieReleaseDate.Text = "개봉일  :";
            // 
            // movieDirector
            // 
            this.movieDirector.AutoSize = true;
            this.movieDirector.Location = new System.Drawing.Point(279, 158);
            this.movieDirector.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.movieDirector.Name = "movieDirector";
            this.movieDirector.Size = new System.Drawing.Size(41, 12);
            this.movieDirector.TabIndex = 3;
            this.movieDirector.Text = "감독  :";
            // 
            // movieAgeLimit
            // 
            this.movieAgeLimit.AutoSize = true;
            this.movieAgeLimit.Location = new System.Drawing.Point(279, 202);
            this.movieAgeLimit.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.movieAgeLimit.Name = "movieAgeLimit";
            this.movieAgeLimit.Size = new System.Drawing.Size(53, 12);
            this.movieAgeLimit.TabIndex = 5;
            this.movieAgeLimit.Text = "관람가  :";
            // 
            // movieMainActor
            // 
            this.movieMainActor.AutoSize = true;
            this.movieMainActor.Location = new System.Drawing.Point(279, 180);
            this.movieMainActor.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.movieMainActor.Name = "movieMainActor";
            this.movieMainActor.Size = new System.Drawing.Size(41, 12);
            this.movieMainActor.TabIndex = 4;
            this.movieMainActor.Text = "배우  :";
            // 
            // movieTitle
            // 
            this.movieTitle.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.movieTitle.Location = new System.Drawing.Point(277, 52);
            this.movieTitle.Name = "movieTitle";
            this.movieTitle.Size = new System.Drawing.Size(576, 23);
            this.movieTitle.TabIndex = 1;
            this.movieTitle.Text = "영화 제목";
            // 
            // underscore
            // 
            this.underscore.BackColor = System.Drawing.Color.Transparent;
            this.underscore.Image = global::SM_Movie.Properties.Resources.underscore;
            this.underscore.Location = new System.Drawing.Point(277, 27);
            this.underscore.Name = "underscore";
            this.underscore.Size = new System.Drawing.Size(591, 106);
            this.underscore.TabIndex = 10;
            this.underscore.TabStop = false;
            // 
            // Summary
            // 
            this.Summary.AutoSize = true;
            this.Summary.Location = new System.Drawing.Point(15, 439);
            this.Summary.Name = "Summary";
            this.Summary.Size = new System.Drawing.Size(73, 12);
            this.Summary.TabIndex = 9;
            this.Summary.Text = "사라진 20분 ";
            // 
            // MovieSummary
            // 
            this.MovieSummary.AutoSize = true;
            this.MovieSummary.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MovieSummary.Location = new System.Drawing.Point(15, 403);
            this.MovieSummary.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.MovieSummary.Name = "MovieSummary";
            this.MovieSummary.Size = new System.Drawing.Size(59, 16);
            this.MovieSummary.TabIndex = 2;
            this.MovieSummary.Text = "줄거리";
            // 
            // moviePoster
            // 
            this.moviePoster.Image = ((System.Drawing.Image)(resources.GetObject("moviePoster.Image")));
            this.moviePoster.Location = new System.Drawing.Point(32, 52);
            this.moviePoster.Name = "moviePoster";
            this.moviePoster.Size = new System.Drawing.Size(225, 318);
            this.moviePoster.TabIndex = 0;
            this.moviePoster.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SM_Movie.Properties.Resources.underscore;
            this.pictureBox1.Location = new System.Drawing.Point(277, 291);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(591, 106);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Movieinformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MovieContents);
            this.Name = "Movieinformation";
            this.Size = new System.Drawing.Size(903, 653);
            this.MovieContents.ResumeLayout(false);
            this.MovieContents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.underscore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviePoster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MovieContents;
        private System.Windows.Forms.PictureBox moviePoster;
        private System.Windows.Forms.Label movieTitle;
        private System.Windows.Forms.Label MovieSummary;
        private System.Windows.Forms.Label movieReleaseDate;
        private System.Windows.Forms.Label genreSeq;
        private System.Windows.Forms.Label movieAgeLimit;
        private System.Windows.Forms.Label movieMainActor;
        private System.Windows.Forms.Label movieDirector;
        private System.Windows.Forms.Label movieRunningTime;
        private System.Windows.Forms.Label Summary;
        private System.Windows.Forms.PictureBox underscore;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
