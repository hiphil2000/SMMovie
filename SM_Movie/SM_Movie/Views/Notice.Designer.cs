namespace SM_Movie.Views
{
    partial class Notice
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
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchPane = new System.Windows.Forms.Panel();
            this.noticePage1 = new System.Windows.Forms.Button();
            this.ViewWindowPane = new System.Windows.Forms.Panel();
            this.noticeSeqLabel = new System.Windows.Forms.Label();
            this.noticeTitleLabel = new System.Windows.Forms.Label();
            this.noticeDateLabel = new System.Windows.Forms.Label();
            this.noticeViewCountLabel = new System.Windows.Forms.Label();
            this.noticePage2 = new System.Windows.Forms.Button();
            this.noticePage3 = new System.Windows.Forms.Button();
            this.noticePage4 = new System.Windows.Forms.Button();
            this.noticePage5 = new System.Windows.Forms.Button();
            this.noticeContentLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.noticePosts = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SearchPane.SuspendLayout();
            this.ViewWindowPane.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.noticePosts.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(6, 99);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(193, 21);
            this.SearchBox.TabIndex = 0;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(205, 99);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(60, 21);
            this.SearchBtn.TabIndex = 1;
            this.SearchBtn.Text = "검색";
            this.SearchBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "공지";
            // 
            // SearchPane
            // 
            this.SearchPane.Controls.Add(this.SearchBox);
            this.SearchPane.Controls.Add(this.label1);
            this.SearchPane.Controls.Add(this.SearchBtn);
            this.SearchPane.Location = new System.Drawing.Point(3, 0);
            this.SearchPane.Name = "SearchPane";
            this.SearchPane.Size = new System.Drawing.Size(912, 144);
            this.SearchPane.TabIndex = 3;
            // 
            // noticePage1
            // 
            this.noticePage1.Location = new System.Drawing.Point(390, 435);
            this.noticePage1.Name = "noticePage1";
            this.noticePage1.Size = new System.Drawing.Size(22, 22);
            this.noticePage1.TabIndex = 4;
            this.noticePage1.Text = "1";
            this.noticePage1.UseVisualStyleBackColor = true;
            // 
            // ViewWindowPane
            // 
            this.ViewWindowPane.Controls.Add(this.flowLayoutPanel1);
            this.ViewWindowPane.Controls.Add(this.noticeContentLabel);
            this.ViewWindowPane.Controls.Add(this.noticePage5);
            this.ViewWindowPane.Controls.Add(this.noticePage4);
            this.ViewWindowPane.Controls.Add(this.noticePage3);
            this.ViewWindowPane.Controls.Add(this.noticePage2);
            this.ViewWindowPane.Controls.Add(this.noticeViewCountLabel);
            this.ViewWindowPane.Controls.Add(this.noticeDateLabel);
            this.ViewWindowPane.Controls.Add(this.noticeTitleLabel);
            this.ViewWindowPane.Controls.Add(this.noticeSeqLabel);
            this.ViewWindowPane.Controls.Add(this.noticePage1);
            this.ViewWindowPane.Location = new System.Drawing.Point(3, 150);
            this.ViewWindowPane.Name = "ViewWindowPane";
            this.ViewWindowPane.Size = new System.Drawing.Size(912, 459);
            this.ViewWindowPane.TabIndex = 5;
            // 
            // noticeSeqLabel
            // 
            this.noticeSeqLabel.AutoSize = true;
            this.noticeSeqLabel.Location = new System.Drawing.Point(8, 10);
            this.noticeSeqLabel.Name = "noticeSeqLabel";
            this.noticeSeqLabel.Size = new System.Drawing.Size(29, 12);
            this.noticeSeqLabel.TabIndex = 5;
            this.noticeSeqLabel.Text = "번호";
            // 
            // noticeTitleLabel
            // 
            this.noticeTitleLabel.AutoSize = true;
            this.noticeTitleLabel.Location = new System.Drawing.Point(92, 10);
            this.noticeTitleLabel.Name = "noticeTitleLabel";
            this.noticeTitleLabel.Size = new System.Drawing.Size(29, 12);
            this.noticeTitleLabel.TabIndex = 6;
            this.noticeTitleLabel.Text = "제목";
            // 
            // noticeDateLabel
            // 
            this.noticeDateLabel.AutoSize = true;
            this.noticeDateLabel.Location = new System.Drawing.Point(709, 10);
            this.noticeDateLabel.Name = "noticeDateLabel";
            this.noticeDateLabel.Size = new System.Drawing.Size(41, 12);
            this.noticeDateLabel.TabIndex = 8;
            this.noticeDateLabel.Text = "작성일";
            // 
            // noticeViewCountLabel
            // 
            this.noticeViewCountLabel.AutoSize = true;
            this.noticeViewCountLabel.Location = new System.Drawing.Point(855, 10);
            this.noticeViewCountLabel.Name = "noticeViewCountLabel";
            this.noticeViewCountLabel.Size = new System.Drawing.Size(41, 12);
            this.noticeViewCountLabel.TabIndex = 9;
            this.noticeViewCountLabel.Text = "조회수";
            this.noticeViewCountLabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // noticePage2
            // 
            this.noticePage2.Location = new System.Drawing.Point(418, 435);
            this.noticePage2.Name = "noticePage2";
            this.noticePage2.Size = new System.Drawing.Size(22, 22);
            this.noticePage2.TabIndex = 10;
            this.noticePage2.Text = "2";
            this.noticePage2.UseVisualStyleBackColor = true;
            // 
            // noticePage3
            // 
            this.noticePage3.Location = new System.Drawing.Point(446, 435);
            this.noticePage3.Name = "noticePage3";
            this.noticePage3.Size = new System.Drawing.Size(22, 22);
            this.noticePage3.TabIndex = 11;
            this.noticePage3.Text = "3";
            this.noticePage3.UseVisualStyleBackColor = true;
            // 
            // noticePage4
            // 
            this.noticePage4.Location = new System.Drawing.Point(474, 435);
            this.noticePage4.Name = "noticePage4";
            this.noticePage4.Size = new System.Drawing.Size(22, 22);
            this.noticePage4.TabIndex = 12;
            this.noticePage4.Text = "4";
            this.noticePage4.UseVisualStyleBackColor = true;
            // 
            // noticePage5
            // 
            this.noticePage5.Location = new System.Drawing.Point(502, 435);
            this.noticePage5.Name = "noticePage5";
            this.noticePage5.Size = new System.Drawing.Size(22, 22);
            this.noticePage5.TabIndex = 13;
            this.noticePage5.Text = "5";
            this.noticePage5.UseVisualStyleBackColor = true;
            // 
            // noticeContentLabel
            // 
            this.noticeContentLabel.AutoSize = true;
            this.noticeContentLabel.Location = new System.Drawing.Point(287, 10);
            this.noticeContentLabel.Name = "noticeContentLabel";
            this.noticeContentLabel.Size = new System.Drawing.Size(29, 12);
            this.noticeContentLabel.TabIndex = 14;
            this.noticeContentLabel.Text = "내용";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.noticePosts);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 25);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(906, 404);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // noticePosts
            // 
            this.noticePosts.Controls.Add(this.label6);
            this.noticePosts.Controls.Add(this.label5);
            this.noticePosts.Controls.Add(this.label4);
            this.noticePosts.Controls.Add(this.label3);
            this.noticePosts.Controls.Add(this.label2);
            this.noticePosts.Location = new System.Drawing.Point(3, 3);
            this.noticePosts.Name = "noticePosts";
            this.noticePosts.Size = new System.Drawing.Size(903, 31);
            this.noticePosts.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(703, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(852, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "label6";
            // 
            // Notice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ViewWindowPane);
            this.Controls.Add(this.SearchPane);
            this.Name = "Notice";
            this.Size = new System.Drawing.Size(918, 612);
            this.SearchPane.ResumeLayout(false);
            this.SearchPane.PerformLayout();
            this.ViewWindowPane.ResumeLayout(false);
            this.ViewWindowPane.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.noticePosts.ResumeLayout(false);
            this.noticePosts.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Panel SearchPane;
        private System.Windows.Forms.Button noticePage1;
        private System.Windows.Forms.Panel ViewWindowPane;
        private System.Windows.Forms.Label noticeContentLabel;
        private System.Windows.Forms.Button noticePage5;
        private System.Windows.Forms.Button noticePage4;
        private System.Windows.Forms.Button noticePage3;
        private System.Windows.Forms.Button noticePage2;
        private System.Windows.Forms.Label noticeViewCountLabel;
        public System.Windows.Forms.Label noticeDateLabel;
        private System.Windows.Forms.Label noticeTitleLabel;
        private System.Windows.Forms.Label noticeSeqLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel noticePosts;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
