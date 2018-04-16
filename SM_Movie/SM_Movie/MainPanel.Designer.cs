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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPanel));
            this.Mainbar1image = new System.Windows.Forms.PictureBox();
            this.Mainbar2image = new System.Windows.Forms.PictureBox();
            this.Mainbar3image = new System.Windows.Forms.PictureBox();
            this.underpanel = new System.Windows.Forms.Panel();
            this.Notice = new System.Windows.Forms.Button();
            this.FourthPage = new System.Windows.Forms.RadioButton();
            this.ThirdPage = new System.Windows.Forms.RadioButton();
            this.SecondPage = new System.Windows.Forms.RadioButton();
            this.FifthPage = new System.Windows.Forms.RadioButton();
            this.FirstPage = new System.Windows.Forms.RadioButton();
            this.NewMovie = new System.Windows.Forms.Button();
            this.onpanel = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.secondmoviename = new System.Windows.Forms.TextBox();
            this.Mainbar1 = new System.Windows.Forms.Panel();
            this.Mainbar2 = new System.Windows.Forms.Panel();
            this.Mainbar3 = new System.Windows.Forms.Panel();
            this.Thirdmoviename = new System.Windows.Forms.TextBox();
            this.fistmoviename = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Mainbar1image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mainbar2image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mainbar3image)).BeginInit();
            this.underpanel.SuspendLayout();
            this.onpanel.SuspendLayout();
            this.Mainbar1.SuspendLayout();
            this.Mainbar2.SuspendLayout();
            this.Mainbar3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mainbar1image
            // 
            this.Mainbar1image.BackColor = System.Drawing.Color.Transparent;
            this.Mainbar1image.ErrorImage = null;
            this.Mainbar1image.Image = ((System.Drawing.Image)(resources.GetObject("Mainbar1image.Image")));
            this.Mainbar1image.Location = new System.Drawing.Point(3, 3);
            this.Mainbar1image.Name = "Mainbar1image";
            this.Mainbar1image.Size = new System.Drawing.Size(242, 216);
            this.Mainbar1image.TabIndex = 9;
            this.Mainbar1image.TabStop = false;
            this.Mainbar1image.Click += new System.EventHandler(this.FirstPage_CheckedChanged);
            // 
            // Mainbar2image
            // 
            this.Mainbar2image.Image = ((System.Drawing.Image)(resources.GetObject("Mainbar2image.Image")));
            this.Mainbar2image.Location = new System.Drawing.Point(3, 6);
            this.Mainbar2image.Name = "Mainbar2image";
            this.Mainbar2image.Size = new System.Drawing.Size(242, 216);
            this.Mainbar2image.TabIndex = 10;
            this.Mainbar2image.TabStop = false;
            this.Mainbar2image.Click += new System.EventHandler(this.SecondPage_CheckedChanged);
            // 
            // Mainbar3image
            // 
            this.Mainbar3image.Image = ((System.Drawing.Image)(resources.GetObject("Mainbar3image.Image")));
            this.Mainbar3image.Location = new System.Drawing.Point(3, 3);
            this.Mainbar3image.Name = "Mainbar3image";
            this.Mainbar3image.Size = new System.Drawing.Size(242, 216);
            this.Mainbar3image.TabIndex = 11;
            this.Mainbar3image.TabStop = false;
            this.Mainbar3image.Click += new System.EventHandler(this.ThirdPage_CheckedChanged);
            // 
            // underpanel
            // 
            this.underpanel.Controls.Add(this.FourthPage);
            this.underpanel.Controls.Add(this.Notice);
            this.underpanel.Controls.Add(this.ThirdPage);
            this.underpanel.Controls.Add(this.NewMovie);
            this.underpanel.Controls.Add(this.SecondPage);
            this.underpanel.Controls.Add(this.FifthPage);
            this.underpanel.Controls.Add(this.FirstPage);
            this.underpanel.Location = new System.Drawing.Point(3, 267);
            this.underpanel.Name = "underpanel";
            this.underpanel.Size = new System.Drawing.Size(905, 156);
            this.underpanel.TabIndex = 12;
            // 
            // Notice
            // 
            this.Notice.Location = new System.Drawing.Point(384, 41);
            this.Notice.Name = "Notice";
            this.Notice.Size = new System.Drawing.Size(78, 28);
            this.Notice.TabIndex = 15;
            this.Notice.Text = "공지사항";
            this.Notice.UseVisualStyleBackColor = true;
            // 
            // FourthPage
            // 
            this.FourthPage.AutoSize = true;
            this.FourthPage.Location = new System.Drawing.Point(468, 22);
            this.FourthPage.Name = "FourthPage";
            this.FourthPage.Size = new System.Drawing.Size(14, 13);
            this.FourthPage.TabIndex = 14;
            this.FourthPage.UseVisualStyleBackColor = true;
            // 
            // ThirdPage
            // 
            this.ThirdPage.AutoSize = true;
            this.ThirdPage.Location = new System.Drawing.Point(448, 22);
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
            this.SecondPage.Location = new System.Drawing.Point(428, 22);
            this.SecondPage.Name = "SecondPage";
            this.SecondPage.Size = new System.Drawing.Size(14, 13);
            this.SecondPage.TabIndex = 12;
            this.SecondPage.UseVisualStyleBackColor = false;
            this.SecondPage.CheckedChanged += new System.EventHandler(this.SecondPage_CheckedChanged);
            // 
            // FifthPage
            // 
            this.FifthPage.AutoSize = true;
            this.FifthPage.Location = new System.Drawing.Point(488, 22);
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
            this.FirstPage.Location = new System.Drawing.Point(408, 22);
            this.FirstPage.Name = "FirstPage";
            this.FirstPage.Size = new System.Drawing.Size(14, 13);
            this.FirstPage.TabIndex = 10;
            this.FirstPage.TabStop = true;
            this.FirstPage.UseVisualStyleBackColor = false;
            this.FirstPage.CheckedChanged += new System.EventHandler(this.FirstPage_CheckedChanged);
            // 
            // NewMovie
            // 
            this.NewMovie.Location = new System.Drawing.Point(310, 41);
            this.NewMovie.Name = "NewMovie";
            this.NewMovie.Size = new System.Drawing.Size(78, 28);
            this.NewMovie.TabIndex = 9;
            this.NewMovie.Text = "최신개봉작";
            this.NewMovie.UseVisualStyleBackColor = true;
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // secondmoviename
            // 
            this.secondmoviename.Location = new System.Drawing.Point(251, 3);
            this.secondmoviename.Name = "secondmoviename";
            this.secondmoviename.Size = new System.Drawing.Size(100, 21);
            this.secondmoviename.TabIndex = 13;
            this.secondmoviename.Text = "램 레이지";
            this.secondmoviename.Click += new System.EventHandler(this.ThirdPage_CheckedChanged);
            // 
            // Mainbar1
            // 
            this.Mainbar1.Controls.Add(this.fistmoviename);
            this.Mainbar1.Controls.Add(this.Mainbar1image);
            this.Mainbar1.Location = new System.Drawing.Point(0, 0);
            this.Mainbar1.Name = "Mainbar1";
            this.Mainbar1.Size = new System.Drawing.Size(518, 222);
            this.Mainbar1.TabIndex = 14;
            // 
            // Mainbar2
            // 
            this.Mainbar2.Controls.Add(this.Thirdmoviename);
            this.Mainbar2.Controls.Add(this.Mainbar2image);
            this.Mainbar2.Location = new System.Drawing.Point(3, 3);
            this.Mainbar2.Name = "Mainbar2";
            this.Mainbar2.Size = new System.Drawing.Size(518, 222);
            this.Mainbar2.TabIndex = 16;
            this.Mainbar2.Visible = false;
            this.Mainbar2.Click += new System.EventHandler(this.SecondPage_CheckedChanged);
            // 
            // Mainbar3
            // 
            this.Mainbar3.Controls.Add(this.Mainbar3image);
            this.Mainbar3.Controls.Add(this.secondmoviename);
            this.Mainbar3.Location = new System.Drawing.Point(3, 3);
            this.Mainbar3.Name = "Mainbar3";
            this.Mainbar3.Size = new System.Drawing.Size(518, 222);
            this.Mainbar3.TabIndex = 18;
            this.Mainbar3.Visible = false;
            this.Mainbar3.Click += new System.EventHandler(this.ThirdPage_CheckedChanged);
            // 
            // Thirdmoviename
            // 
            this.Thirdmoviename.Location = new System.Drawing.Point(251, 6);
            this.Thirdmoviename.Name = "Thirdmoviename";
            this.Thirdmoviename.Size = new System.Drawing.Size(181, 21);
            this.Thirdmoviename.TabIndex = 14;
            this.Thirdmoviename.Text = "어벤져스";
            this.Thirdmoviename.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // fistmoviename
            // 
            this.fistmoviename.AutoSize = true;
            this.fistmoviename.Location = new System.Drawing.Point(254, 9);
            this.fistmoviename.Name = "fistmoviename";
            this.fistmoviename.Size = new System.Drawing.Size(173, 12);
            this.fistmoviename.TabIndex = 13;
            this.fistmoviename.Text = "베를린 필하모닉 유로파 콘서트";
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.onpanel);
            this.Controls.Add(this.underpanel);
            this.Name = "MainPanel";
            this.Size = new System.Drawing.Size(911, 426);
            this.Load += new System.EventHandler(this.MainPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Mainbar1image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mainbar2image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mainbar3image)).EndInit();
            this.underpanel.ResumeLayout(false);
            this.underpanel.PerformLayout();
            this.onpanel.ResumeLayout(false);
            this.Mainbar1.ResumeLayout(false);
            this.Mainbar1.PerformLayout();
            this.Mainbar2.ResumeLayout(false);
            this.Mainbar2.PerformLayout();
            this.Mainbar3.ResumeLayout(false);
            this.Mainbar3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox Mainbar1image;
        private System.Windows.Forms.PictureBox Mainbar2image;
        private System.Windows.Forms.PictureBox Mainbar3image;
        private System.Windows.Forms.Panel underpanel;
        private System.Windows.Forms.Button Notice;
        private System.Windows.Forms.RadioButton FourthPage;
        private System.Windows.Forms.RadioButton ThirdPage;
        private System.Windows.Forms.RadioButton SecondPage;
        private System.Windows.Forms.RadioButton FifthPage;
        private System.Windows.Forms.RadioButton FirstPage;
        private System.Windows.Forms.Button NewMovie;
        private System.Windows.Forms.Panel onpanel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox secondmoviename;
        private System.Windows.Forms.Panel Mainbar2;
        private System.Windows.Forms.Panel Mainbar1;
        private System.Windows.Forms.Panel Mainbar3;
        private System.Windows.Forms.TextBox Thirdmoviename;
        private System.Windows.Forms.Label fistmoviename;
    }
}
