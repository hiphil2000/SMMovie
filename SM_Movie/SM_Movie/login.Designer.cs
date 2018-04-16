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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.rightPanel = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.logo = new System.Windows.Forms.PictureBox();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.userId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userPassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.closeButtonPane = new System.Windows.Forms.Panel();
            this.closeButtonIcon = new System.Windows.Forms.PictureBox();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.leftPanel.SuspendLayout();
            this.closeButtonPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButtonIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.SystemColors.Window;
            this.rightPanel.Controls.Add(this.closeButtonPane);
            this.rightPanel.Controls.Add(this.linkLabel3);
            this.rightPanel.Controls.Add(this.linkLabel2);
            this.rightPanel.Controls.Add(this.linkLabel1);
            this.rightPanel.Controls.Add(this.button1);
            this.rightPanel.Controls.Add(this.userPassword);
            this.rightPanel.Controls.Add(this.label3);
            this.rightPanel.Controls.Add(this.label2);
            this.rightPanel.Controls.Add(this.userId);
            this.rightPanel.Controls.Add(this.label1);
            this.rightPanel.Location = new System.Drawing.Point(212, 2);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(324, 511);
            this.rightPanel.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(12, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(192, 59);
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.Red;
            this.leftPanel.Controls.Add(this.logo);
            this.leftPanel.Location = new System.Drawing.Point(2, 2);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(212, 511);
            this.leftPanel.TabIndex = 3;
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
            // userId
            // 
            this.userId.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userId.Location = new System.Drawing.Point(50, 159);
            this.userId.Name = "userId";
            this.userId.Size = new System.Drawing.Size(218, 29);
            this.userId.TabIndex = 1;
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
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            // userPassword
            // 
            this.userPassword.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userPassword.Location = new System.Drawing.Point(50, 256);
            this.userPassword.Name = "userPassword";
            this.userPassword.PasswordChar = '●';
            this.userPassword.Size = new System.Drawing.Size(218, 29);
            this.userPassword.TabIndex = 5;
            this.userPassword.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
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
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(48, 351);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(53, 12);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "회원가입";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkColor = System.Drawing.Color.Black;
            this.linkLabel2.Location = new System.Drawing.Point(48, 379);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(123, 12);
            this.linkLabel2.TabIndex = 8;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "아이디/비밀번호 찾기";
            this.linkLabel2.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.LinkColor = System.Drawing.Color.Black;
            this.linkLabel3.Location = new System.Drawing.Point(48, 409);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(93, 12);
            this.linkLabel3.TabIndex = 9;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "로그인 건너뛰기";
            this.linkLabel3.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
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
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(538, 515);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.rightPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.leftPanel.ResumeLayout(false);
            this.closeButtonPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeButtonIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox userPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel closeButtonPane;
        private System.Windows.Forms.PictureBox closeButtonIcon;
    }
}

