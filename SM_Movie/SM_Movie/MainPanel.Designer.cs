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
            this.underpanel = new System.Windows.Forms.Panel();
            this.FourthPage = new System.Windows.Forms.RadioButton();
            this.ThirdPage = new System.Windows.Forms.RadioButton();
            this.SecondPage = new System.Windows.Forms.RadioButton();
            this.FifthPage = new System.Windows.Forms.RadioButton();
            this.FirstPage = new System.Windows.Forms.RadioButton();
            this.onpanel = new System.Windows.Forms.Panel();
            this.Mainbar1 = new System.Windows.Forms.Panel();
            this.fistmoviename = new System.Windows.Forms.Label();
            this.Mainbar1image = new System.Windows.Forms.PictureBox();
            this.Mainbar2 = new System.Windows.Forms.Panel();
            this.Thirdmoviename = new System.Windows.Forms.Label();
            this.Mainbar2image = new System.Windows.Forms.PictureBox();
            this.Mainbar3 = new System.Windows.Forms.Panel();
            this.secondmoviename = new System.Windows.Forms.Label();
            this.Mainbar3image = new System.Windows.Forms.PictureBox();
            this.BestMovieFLPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BestMoviePanel1 = new System.Windows.Forms.Panel();
            this.BestMoviedirector1 = new System.Windows.Forms.Label();
            this.BestMovieTitle1 = new System.Windows.Forms.Label();
            this.BestMoviePicture1 = new System.Windows.Forms.PictureBox();
            this.BestMoviePanel2 = new System.Windows.Forms.Panel();
            this.BestMoviedirector2 = new System.Windows.Forms.Label();
            this.BestMovieTitle2 = new System.Windows.Forms.Label();
            this.BestMoviePicture2 = new System.Windows.Forms.PictureBox();
            this.BestMoviePanel3 = new System.Windows.Forms.Panel();
            this.BestMoviedirector3 = new System.Windows.Forms.Label();
            this.BestMovieTitle3 = new System.Windows.Forms.Label();
            this.BestMoviePicture3 = new System.Windows.Forms.PictureBox();
            this.BestMoviePanel4 = new System.Windows.Forms.Panel();
            this.BestMoviedirector4 = new System.Windows.Forms.Label();
            this.BestMovieTitle4 = new System.Windows.Forms.Label();
            this.BestMoviePicture4 = new System.Windows.Forms.PictureBox();
            this.underpanel.SuspendLayout();
            this.onpanel.SuspendLayout();
            this.Mainbar1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mainbar1image)).BeginInit();
            this.Mainbar2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mainbar2image)).BeginInit();
            this.Mainbar3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mainbar3image)).BeginInit();
            this.BestMovieFLPanel1.SuspendLayout();
            this.BestMoviePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BestMoviePicture1)).BeginInit();
            this.BestMoviePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BestMoviePicture2)).BeginInit();
            this.BestMoviePanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BestMoviePicture3)).BeginInit();
            this.BestMoviePanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BestMoviePicture4)).BeginInit();
            this.SuspendLayout();
            // 
            // underpanel
            // 
            this.underpanel.Controls.Add(this.FourthPage);
            this.underpanel.Controls.Add(this.ThirdPage);
            this.underpanel.Controls.Add(this.SecondPage);
            this.underpanel.Controls.Add(this.FifthPage);
            this.underpanel.Controls.Add(this.FirstPage);
            this.underpanel.Location = new System.Drawing.Point(3, 262);
            this.underpanel.Name = "underpanel";
            this.underpanel.Size = new System.Drawing.Size(905, 24);
            this.underpanel.TabIndex = 12;
            // 
            // FourthPage
            // 
            this.FourthPage.AutoSize = true;
            this.FourthPage.Location = new System.Drawing.Point(466, 3);
            this.FourthPage.Name = "FourthPage";
            this.FourthPage.Size = new System.Drawing.Size(14, 13);
            this.FourthPage.TabIndex = 14;
            this.FourthPage.UseVisualStyleBackColor = true;
            // 
            // ThirdPage
            // 
            this.ThirdPage.AutoSize = true;
            this.ThirdPage.Location = new System.Drawing.Point(446, 3);
            this.ThirdPage.Name = "ThirdPage";
            this.ThirdPage.Size = new System.Drawing.Size(14, 13);
            this.ThirdPage.TabIndex = 13;
            this.ThirdPage.UseVisualStyleBackColor = true;
            this.ThirdPage.CheckedChanged += new System.EventHandler(this.ThirdPage_CheckedChanged);
            // 
            // SecondPage
            // 
            this.SecondPage.AutoSize = true;
            this.SecondPage.BackColor = System.Drawing.Color.Transparent;
            this.SecondPage.Location = new System.Drawing.Point(426, 3);
            this.SecondPage.Name = "SecondPage";
            this.SecondPage.Size = new System.Drawing.Size(14, 13);
            this.SecondPage.TabIndex = 12;
            this.SecondPage.UseVisualStyleBackColor = false;
            this.SecondPage.CheckedChanged += new System.EventHandler(this.SecondPage_CheckedChanged);
            // 
            // FifthPage
            // 
            this.FifthPage.AutoSize = true;
            this.FifthPage.Location = new System.Drawing.Point(486, 3);
            this.FifthPage.Name = "FifthPage";
            this.FifthPage.Size = new System.Drawing.Size(14, 13);
            this.FifthPage.TabIndex = 11;
            this.FifthPage.UseVisualStyleBackColor = true;
            // 
            // FirstPage
            // 
            this.FirstPage.AutoSize = true;
            this.FirstPage.BackColor = System.Drawing.Color.Transparent;
            this.FirstPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FirstPage.Checked = true;
            this.FirstPage.Location = new System.Drawing.Point(406, 3);
            this.FirstPage.Name = "FirstPage";
            this.FirstPage.Size = new System.Drawing.Size(14, 13);
            this.FirstPage.TabIndex = 10;
            this.FirstPage.TabStop = true;
            this.FirstPage.UseVisualStyleBackColor = false;
            this.FirstPage.CheckedChanged += new System.EventHandler(this.FirstPage_CheckedChanged);
            // 
            // onpanel
            // 
            this.onpanel.Controls.Add(this.Mainbar1);
            this.onpanel.Controls.Add(this.Mainbar2);
            this.onpanel.Controls.Add(this.Mainbar3);
            this.onpanel.Location = new System.Drawing.Point(3, 3);
            this.onpanel.Name = "onpanel";
            this.onpanel.Size = new System.Drawing.Size(905, 258);
            this.onpanel.TabIndex = 13;
            // 
            // Mainbar1
            // 
            this.Mainbar1.Controls.Add(this.fistmoviename);
            this.Mainbar1.Controls.Add(this.Mainbar1image);
            this.Mainbar1.Location = new System.Drawing.Point(3, 3);
            this.Mainbar1.Name = "Mainbar1";
            this.Mainbar1.Size = new System.Drawing.Size(900, 250);
            this.Mainbar1.TabIndex = 14;
            // 
            // fistmoviename
            // 
            this.fistmoviename.AutoSize = true;
            this.fistmoviename.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Bold);
            this.fistmoviename.Location = new System.Drawing.Point(359, 1);
            this.fistmoviename.Name = "fistmoviename";
            this.fistmoviename.Size = new System.Drawing.Size(436, 29);
            this.fistmoviename.TabIndex = 13;
            this.fistmoviename.Text = "베를린 필하모닉 유로파 콘서트";
            // 
            // Mainbar1image
            // 
            this.Mainbar1image.BackColor = System.Drawing.Color.Transparent;
            this.Mainbar1image.ErrorImage = null;
            this.Mainbar1image.Image = ((System.Drawing.Image)(resources.GetObject("Mainbar1image.Image")));
            this.Mainbar1image.Location = new System.Drawing.Point(3, 3);
            this.Mainbar1image.Name = "Mainbar1image";
            this.Mainbar1image.Size = new System.Drawing.Size(251, 244);
            this.Mainbar1image.TabIndex = 9;
            this.Mainbar1image.TabStop = false;
            this.Mainbar1image.Click += new System.EventHandler(this.FirstPage_CheckedChanged);
            // 
            // Mainbar2
            // 
            this.Mainbar2.Controls.Add(this.Thirdmoviename);
            this.Mainbar2.Controls.Add(this.Mainbar2image);
            this.Mainbar2.Location = new System.Drawing.Point(3, 3);
            this.Mainbar2.Name = "Mainbar2";
            this.Mainbar2.Size = new System.Drawing.Size(900, 250);
            this.Mainbar2.TabIndex = 16;
            this.Mainbar2.Visible = false;
            this.Mainbar2.Click += new System.EventHandler(this.SecondPage_CheckedChanged);
            // 
            // Thirdmoviename
            // 
            this.Thirdmoviename.AutoSize = true;
            this.Thirdmoviename.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Thirdmoviename.Location = new System.Drawing.Point(506, 3);
            this.Thirdmoviename.Name = "Thirdmoviename";
            this.Thirdmoviename.Size = new System.Drawing.Size(133, 29);
            this.Thirdmoviename.TabIndex = 15;
            this.Thirdmoviename.Text = "어벤져스";
            // 
            // Mainbar2image
            // 
            this.Mainbar2image.Image = ((System.Drawing.Image)(resources.GetObject("Mainbar2image.Image")));
            this.Mainbar2image.Location = new System.Drawing.Point(3, 6);
            this.Mainbar2image.Name = "Mainbar2image";
            this.Mainbar2image.Size = new System.Drawing.Size(251, 244);
            this.Mainbar2image.TabIndex = 10;
            this.Mainbar2image.TabStop = false;
            this.Mainbar2image.Click += new System.EventHandler(this.SecondPage_CheckedChanged);
            // 
            // Mainbar3
            // 
            this.Mainbar3.Controls.Add(this.secondmoviename);
            this.Mainbar3.Controls.Add(this.Mainbar3image);
            this.Mainbar3.Location = new System.Drawing.Point(3, 3);
            this.Mainbar3.Name = "Mainbar3";
            this.Mainbar3.Size = new System.Drawing.Size(900, 250);
            this.Mainbar3.TabIndex = 18;
            this.Mainbar3.Visible = false;
            this.Mainbar3.Click += new System.EventHandler(this.ThirdPage_CheckedChanged);
            // 
            // secondmoviename
            // 
            this.secondmoviename.AutoSize = true;
            this.secondmoviename.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Bold);
            this.secondmoviename.Location = new System.Drawing.Point(509, 3);
            this.secondmoviename.Name = "secondmoviename";
            this.secondmoviename.Size = new System.Drawing.Size(144, 29);
            this.secondmoviename.TabIndex = 17;
            this.secondmoviename.Text = "램 레이지";
            // 
            // Mainbar3image
            // 
            this.Mainbar3image.Image = ((System.Drawing.Image)(resources.GetObject("Mainbar3image.Image")));
            this.Mainbar3image.Location = new System.Drawing.Point(3, 3);
            this.Mainbar3image.Name = "Mainbar3image";
            this.Mainbar3image.Size = new System.Drawing.Size(251, 244);
            this.Mainbar3image.TabIndex = 11;
            this.Mainbar3image.TabStop = false;
            this.Mainbar3image.Click += new System.EventHandler(this.ThirdPage_CheckedChanged);
            // 
            // BestMovieFLPanel1
            // 
            this.BestMovieFLPanel1.Controls.Add(this.BestMoviePanel1);
            this.BestMovieFLPanel1.Controls.Add(this.BestMoviePanel2);
            this.BestMovieFLPanel1.Controls.Add(this.BestMoviePanel3);
            this.BestMovieFLPanel1.Controls.Add(this.BestMoviePanel4);
            this.BestMovieFLPanel1.Location = new System.Drawing.Point(3, 289);
            this.BestMovieFLPanel1.Name = "BestMovieFLPanel1";
            this.BestMovieFLPanel1.Size = new System.Drawing.Size(903, 411);
            this.BestMovieFLPanel1.TabIndex = 15;
            // 
            // BestMoviePanel1
            // 
            this.BestMoviePanel1.Controls.Add(this.BestMoviedirector1);
            this.BestMoviePanel1.Controls.Add(this.BestMovieTitle1);
            this.BestMoviePanel1.Controls.Add(this.BestMoviePicture1);
            this.BestMoviePanel1.Location = new System.Drawing.Point(25, 25);
            this.BestMoviePanel1.Margin = new System.Windows.Forms.Padding(25);
            this.BestMoviePanel1.Name = "BestMoviePanel1";
            this.BestMoviePanel1.Size = new System.Drawing.Size(174, 270);
            this.BestMoviePanel1.TabIndex = 19;
            this.BestMoviePanel1.Visible = false;
            // 
            // BestMoviedirector1
            // 
            this.BestMoviedirector1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BestMoviedirector1.Location = new System.Drawing.Point(3, 220);
            this.BestMoviedirector1.Name = "BestMoviedirector1";
            this.BestMoviedirector1.Size = new System.Drawing.Size(168, 13);
            this.BestMoviedirector1.TabIndex = 8;
            this.BestMoviedirector1.Text = "스티븐 스필버그";
            this.BestMoviedirector1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BestMovieTitle1
            // 
            this.BestMovieTitle1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BestMovieTitle1.Location = new System.Drawing.Point(3, 192);
            this.BestMovieTitle1.Name = "BestMovieTitle1";
            this.BestMovieTitle1.Size = new System.Drawing.Size(168, 19);
            this.BestMovieTitle1.TabIndex = 7;
            this.BestMovieTitle1.Text = "레디 플레이어 원";
            this.BestMovieTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BestMoviePicture1
            // 
            this.BestMoviePicture1.Location = new System.Drawing.Point(20, 3);
            this.BestMoviePicture1.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.BestMoviePicture1.Name = "BestMoviePicture1";
            this.BestMoviePicture1.Size = new System.Drawing.Size(134, 179);
            this.BestMoviePicture1.TabIndex = 6;
            this.BestMoviePicture1.TabStop = false;
            // 
            // BestMoviePanel2
            // 
            this.BestMoviePanel2.Controls.Add(this.BestMoviedirector2);
            this.BestMoviePanel2.Controls.Add(this.BestMovieTitle2);
            this.BestMoviePanel2.Controls.Add(this.BestMoviePicture2);
            this.BestMoviePanel2.Location = new System.Drawing.Point(249, 25);
            this.BestMoviePanel2.Margin = new System.Windows.Forms.Padding(25);
            this.BestMoviePanel2.Name = "BestMoviePanel2";
            this.BestMoviePanel2.Size = new System.Drawing.Size(174, 270);
            this.BestMoviePanel2.TabIndex = 20;
            this.BestMoviePanel2.Visible = false;
            // 
            // BestMoviedirector2
            // 
            this.BestMoviedirector2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BestMoviedirector2.Location = new System.Drawing.Point(3, 220);
            this.BestMoviedirector2.Name = "BestMoviedirector2";
            this.BestMoviedirector2.Size = new System.Drawing.Size(168, 13);
            this.BestMoviedirector2.TabIndex = 8;
            this.BestMoviedirector2.Text = "스티븐 스필버그";
            this.BestMoviedirector2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BestMovieTitle2
            // 
            this.BestMovieTitle2.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BestMovieTitle2.Location = new System.Drawing.Point(3, 192);
            this.BestMovieTitle2.Name = "BestMovieTitle2";
            this.BestMovieTitle2.Size = new System.Drawing.Size(168, 19);
            this.BestMovieTitle2.TabIndex = 7;
            this.BestMovieTitle2.Text = "레디 플레이어 원";
            this.BestMovieTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BestMoviePicture2
            // 
            this.BestMoviePicture2.Location = new System.Drawing.Point(20, 3);
            this.BestMoviePicture2.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.BestMoviePicture2.Name = "BestMoviePicture2";
            this.BestMoviePicture2.Size = new System.Drawing.Size(134, 179);
            this.BestMoviePicture2.TabIndex = 6;
            this.BestMoviePicture2.TabStop = false;
            // 
            // BestMoviePanel3
            // 
            this.BestMoviePanel3.Controls.Add(this.BestMoviedirector3);
            this.BestMoviePanel3.Controls.Add(this.BestMovieTitle3);
            this.BestMoviePanel3.Controls.Add(this.BestMoviePicture3);
            this.BestMoviePanel3.Location = new System.Drawing.Point(473, 25);
            this.BestMoviePanel3.Margin = new System.Windows.Forms.Padding(25);
            this.BestMoviePanel3.Name = "BestMoviePanel3";
            this.BestMoviePanel3.Size = new System.Drawing.Size(174, 270);
            this.BestMoviePanel3.TabIndex = 21;
            this.BestMoviePanel3.Visible = false;
            // 
            // BestMoviedirector3
            // 
            this.BestMoviedirector3.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BestMoviedirector3.Location = new System.Drawing.Point(3, 220);
            this.BestMoviedirector3.Name = "BestMoviedirector3";
            this.BestMoviedirector3.Size = new System.Drawing.Size(168, 13);
            this.BestMoviedirector3.TabIndex = 8;
            this.BestMoviedirector3.Text = "스티븐 스필버그";
            this.BestMoviedirector3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BestMovieTitle3
            // 
            this.BestMovieTitle3.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BestMovieTitle3.Location = new System.Drawing.Point(3, 192);
            this.BestMovieTitle3.Name = "BestMovieTitle3";
            this.BestMovieTitle3.Size = new System.Drawing.Size(168, 19);
            this.BestMovieTitle3.TabIndex = 7;
            this.BestMovieTitle3.Text = "레디 플레이어 원";
            this.BestMovieTitle3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BestMoviePicture3
            // 
            this.BestMoviePicture3.Location = new System.Drawing.Point(20, 3);
            this.BestMoviePicture3.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.BestMoviePicture3.Name = "BestMoviePicture3";
            this.BestMoviePicture3.Size = new System.Drawing.Size(134, 179);
            this.BestMoviePicture3.TabIndex = 6;
            this.BestMoviePicture3.TabStop = false;
            // 
            // BestMoviePanel4
            // 
            this.BestMoviePanel4.Controls.Add(this.BestMoviedirector4);
            this.BestMoviePanel4.Controls.Add(this.BestMovieTitle4);
            this.BestMoviePanel4.Controls.Add(this.BestMoviePicture4);
            this.BestMoviePanel4.Location = new System.Drawing.Point(697, 25);
            this.BestMoviePanel4.Margin = new System.Windows.Forms.Padding(25);
            this.BestMoviePanel4.Name = "BestMoviePanel4";
            this.BestMoviePanel4.Size = new System.Drawing.Size(174, 270);
            this.BestMoviePanel4.TabIndex = 22;
            this.BestMoviePanel4.Visible = false;
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
            this.BestMoviePicture4.Location = new System.Drawing.Point(20, 3);
            this.BestMoviePicture4.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.BestMoviePicture4.Name = "BestMoviePicture4";
            this.BestMoviePicture4.Size = new System.Drawing.Size(134, 179);
            this.BestMoviePicture4.TabIndex = 6;
            this.BestMoviePicture4.TabStop = false;
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.BestMovieFLPanel1);
            this.Controls.Add(this.onpanel);
            this.Controls.Add(this.underpanel);
            this.Name = "MainPanel";
            this.Size = new System.Drawing.Size(911, 700);
            this.Load += new System.EventHandler(this.MainPanel_Load);
            this.underpanel.ResumeLayout(false);
            this.underpanel.PerformLayout();
            this.onpanel.ResumeLayout(false);
            this.Mainbar1.ResumeLayout(false);
            this.Mainbar1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mainbar1image)).EndInit();
            this.Mainbar2.ResumeLayout(false);
            this.Mainbar2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mainbar2image)).EndInit();
            this.Mainbar3.ResumeLayout(false);
            this.Mainbar3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mainbar3image)).EndInit();
            this.BestMovieFLPanel1.ResumeLayout(false);
            this.BestMoviePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BestMoviePicture1)).EndInit();
            this.BestMoviePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BestMoviePicture2)).EndInit();
            this.BestMoviePanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BestMoviePicture3)).EndInit();
            this.BestMoviePanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BestMoviePicture4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox Mainbar1image;
        private System.Windows.Forms.PictureBox Mainbar2image;
        private System.Windows.Forms.PictureBox Mainbar3image;
        private System.Windows.Forms.Panel underpanel;
        private System.Windows.Forms.RadioButton FourthPage;
        private System.Windows.Forms.RadioButton ThirdPage;
        private System.Windows.Forms.RadioButton SecondPage;
        private System.Windows.Forms.RadioButton FifthPage;
        private System.Windows.Forms.RadioButton FirstPage;
        private System.Windows.Forms.Panel onpanel;
        private System.Windows.Forms.Panel Mainbar2;
        private System.Windows.Forms.Panel Mainbar1;
        private System.Windows.Forms.Panel Mainbar3;
        private System.Windows.Forms.Label fistmoviename;
        private System.Windows.Forms.Label Thirdmoviename;
        private System.Windows.Forms.Label secondmoviename;
        private System.Windows.Forms.FlowLayoutPanel BestMovieFLPanel1;
        private System.Windows.Forms.Panel BestMoviePanel1;
        private System.Windows.Forms.Label BestMoviedirector1;
        private System.Windows.Forms.Label BestMovieTitle1;
        private System.Windows.Forms.PictureBox BestMoviePicture1;
        private System.Windows.Forms.Panel BestMoviePanel2;
        private System.Windows.Forms.Label BestMoviedirector2;
        private System.Windows.Forms.Label BestMovieTitle2;
        private System.Windows.Forms.PictureBox BestMoviePicture2;
        private System.Windows.Forms.Panel BestMoviePanel3;
        private System.Windows.Forms.Label BestMoviedirector3;
        private System.Windows.Forms.Label BestMovieTitle3;
        private System.Windows.Forms.PictureBox BestMoviePicture3;
        private System.Windows.Forms.Panel BestMoviePanel4;
        private System.Windows.Forms.Label BestMoviedirector4;
        private System.Windows.Forms.Label BestMovieTitle4;
        private System.Windows.Forms.PictureBox BestMoviePicture4;
    }
}
