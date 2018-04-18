namespace SM_Movie
{
    partial class login
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.log1 = new SM_Movie.log();
            this.signup1 = new SM_Movie.signup();
            this.SuspendLayout();
            // 
            // log1
            // 
            this.log1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.log1.Location = new System.Drawing.Point(0, 0);
            this.log1.Margin = new System.Windows.Forms.Padding(0);
            this.log1.Name = "log1";
            this.log1.Size = new System.Drawing.Size(538, 515);
            this.log1.TabIndex = 0;
            this.log1.Load += new System.EventHandler(this.log1_Load);
            // 
            // signup1
            // 
            this.signup1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.signup1.Location = new System.Drawing.Point(0, 0);
            this.signup1.Name = "signup1";
            this.signup1.Size = new System.Drawing.Size(554, 900);
            this.signup1.TabIndex = 1;
            this.signup1.Visible = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(534, 515);
            this.Controls.Add(this.log1);
            this.Controls.Add(this.signup1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private log log1;
        private signup signup1;
    }
}

