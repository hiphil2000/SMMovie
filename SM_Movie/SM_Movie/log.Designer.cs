namespace SM_Movie
{
    partial class log
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(log));
            this.panel1 = new System.Windows.Forms.Panel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.closeButtonPane = new System.Windows.Forms.Panel();
            this.closeButtonIcon = new System.Windows.Forms.PictureBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.userPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SkipLogin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.rightPanel.SuspendLayout();
            this.closeButtonPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButtonIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.leftPanel);
            this.panel1.Controls.Add(this.rightPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 515);
            this.panel1.TabIndex = 1;
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.Red;
            this.leftPanel.Controls.Add(this.logo);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(212, 515);
            this.leftPanel.TabIndex = 5;
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(12, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(192, 59);
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.SystemColors.Window;
            this.rightPanel.Controls.Add(this.SkipLogin);
            this.rightPanel.Controls.Add(this.closeButtonPane);
            this.rightPanel.Controls.Add(this.linkLabel2);
            this.rightPanel.Controls.Add(this.linkLabel1);
            this.rightPanel.Controls.Add(this.button1);
            this.rightPanel.Controls.Add(this.userPassword);
            this.rightPanel.Controls.Add(this.label3);
            this.rightPanel.Controls.Add(this.label2);
            this.rightPanel.Controls.Add(this.userId);
            this.rightPanel.Controls.Add(this.label1);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(212, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(326, 515);
            this.rightPanel.TabIndex = 4;
            // 
            // closeButtonPane
            // 
            this.closeButtonPane.Controls.Add(this.closeButtonIcon);
            this.closeButtonPane.Location = new System.Drawing.Point(277, 0);
            this.closeButtonPane.Margin = new System.Windows.Forms.Padding(0);
            this.closeButtonPane.Name = "closeButtonPane";
            this.closeButtonPane.Size = new System.Drawing.Size(40, 26);
            this.closeButtonPane.TabIndex = 10;
            // 
            // closeButtonIcon
            // 
            this.closeButtonIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButtonIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.closeButtonIcon.Image = global::SM_Movie.Properties.Resources.exit;
            this.closeButtonIcon.Location = new System.Drawing.Point(0, 0);
            this.closeButtonIcon.Margin = new System.Windows.Forms.Padding(0);
            this.closeButtonIcon.Name = "closeButtonIcon";
            this.closeButtonIcon.Size = new System.Drawing.Size(40, 26);
            this.closeButtonIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeButtonIcon.TabIndex = 1;
            this.closeButtonIcon.TabStop = false;
            this.closeButtonIcon.Click += new System.EventHandler(this.exitApp);
            this.closeButtonIcon.MouseEnter += new System.EventHandler(this.buttonFocus);
            this.closeButtonIcon.MouseLeave += new System.EventHandler(this.buttonLostFocus);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkColor = System.Drawing.Color.Black;
            this.linkLabel2.Location = new System.Drawing.Point(145, 369);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(123, 12);
            this.linkLabel2.TabIndex = 8;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "아이디/비밀번호 찾기";
            this.linkLabel2.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(86, 369);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(53, 12);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "회원가입";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(50, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "로그인";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // userPassword
            // 
            this.userPassword.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userPassword.Location = new System.Drawing.Point(50, 256);
            this.userPassword.Name = "userPassword";
            this.userPassword.PasswordChar = '●';
            this.userPassword.Size = new System.Drawing.Size(218, 29);
            this.userPassword.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(46, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(46, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID";
            // 
            // userId
            // 
            this.userId.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userId.Location = new System.Drawing.Point(50, 159);
            this.userId.Name = "userId";
            this.userId.Size = new System.Drawing.Size(218, 29);
            this.userId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "로그인";
            // 
            // SkipLogin
            // 
            this.SkipLogin.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold);
            this.SkipLogin.Location = new System.Drawing.Point(50, 337);
            this.SkipLogin.Name = "SkipLogin";
            this.SkipLogin.Size = new System.Drawing.Size(218, 29);
            this.SkipLogin.TabIndex = 11;
            this.SkipLogin.Text = "로그인 건너뛰기";
            this.SkipLogin.UseVisualStyleBackColor = true;
            // 
            // log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.panel1);
            this.Name = "log";
            this.Size = new System.Drawing.Size(538, 515);
            this.panel1.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            this.closeButtonPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeButtonIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel closeButtonPane;
        private System.Windows.Forms.PictureBox closeButtonIcon;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox userPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SkipLogin;
    }
}
