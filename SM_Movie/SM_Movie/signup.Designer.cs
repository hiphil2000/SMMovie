namespace SM_Movie
{
    partial class signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signup));
            this.panel1 = new System.Windows.Forms.Panel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.BackLogin = new System.Windows.Forms.LinkLabel();
            this.Login = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.IdCheck = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.userPasswordCheck = new System.Windows.Forms.TextBox();
            this.genreSeq = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.userAddress = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.userPhone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.userEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.userBirthday = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userNickname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.userPassword = new System.Windows.Forms.TextBox();
            this.userId = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.closeButtonPane = new System.Windows.Forms.Panel();
            this.closeButtonIcon = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 900);
            this.panel1.TabIndex = 1;
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.Red;
            this.leftPanel.Controls.Add(this.logo);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(210, 900);
            this.leftPanel.TabIndex = 6;
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.SystemColors.Window;
            this.rightPanel.Controls.Add(this.closeButtonPane);
            this.rightPanel.Controls.Add(this.BackLogin);
            this.rightPanel.Controls.Add(this.Login);
            this.rightPanel.Controls.Add(this.button1);
            this.rightPanel.Controls.Add(this.IdCheck);
            this.rightPanel.Controls.Add(this.label13);
            this.rightPanel.Controls.Add(this.userPasswordCheck);
            this.rightPanel.Controls.Add(this.genreSeq);
            this.rightPanel.Controls.Add(this.label12);
            this.rightPanel.Controls.Add(this.label11);
            this.rightPanel.Controls.Add(this.userAddress);
            this.rightPanel.Controls.Add(this.label10);
            this.rightPanel.Controls.Add(this.userPhone);
            this.rightPanel.Controls.Add(this.label9);
            this.rightPanel.Controls.Add(this.userEmail);
            this.rightPanel.Controls.Add(this.label8);
            this.rightPanel.Controls.Add(this.userBirthday);
            this.rightPanel.Controls.Add(this.label6);
            this.rightPanel.Controls.Add(this.label4);
            this.rightPanel.Controls.Add(this.label3);
            this.rightPanel.Controls.Add(this.userNickname);
            this.rightPanel.Controls.Add(this.label5);
            this.rightPanel.Controls.Add(this.userPassword);
            this.rightPanel.Controls.Add(this.userId);
            this.rightPanel.Controls.Add(this.userName);
            this.rightPanel.Controls.Add(this.label2);
            this.rightPanel.Controls.Add(this.label1);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(210, 0);
            this.rightPanel.Margin = new System.Windows.Forms.Padding(0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(344, 900);
            this.rightPanel.TabIndex = 5;
            // 
            // BackLogin
            // 
            this.BackLogin.AutoSize = true;
            this.BackLogin.LinkColor = System.Drawing.Color.Black;
            this.BackLogin.Location = new System.Drawing.Point(177, 743);
            this.BackLogin.Name = "BackLogin";
            this.BackLogin.Size = new System.Drawing.Size(53, 12);
            this.BackLogin.TabIndex = 30;
            this.BackLogin.TabStop = true;
            this.BackLogin.Text = "뒤로가기";
            this.BackLogin.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.LinkColor = System.Drawing.Color.Black;
            this.Login.Location = new System.Drawing.Point(130, 743);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(41, 12);
            this.Login.TabIndex = 29;
            this.Login.TabStop = true;
            this.Login.Text = "로그인";
            this.Login.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(15, 702);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 29);
            this.button1.TabIndex = 28;
            this.button1.Text = "회원가입";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // IdCheck
            // 
            this.IdCheck.Location = new System.Drawing.Point(234, 163);
            this.IdCheck.Name = "IdCheck";
            this.IdCheck.Size = new System.Drawing.Size(77, 30);
            this.IdCheck.TabIndex = 27;
            this.IdCheck.Text = "중복확인";
            this.IdCheck.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(11, 262);
            this.label13.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "비밀번호 확인";
            // 
            // userPasswordCheck
            // 
            this.userPasswordCheck.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userPasswordCheck.Location = new System.Drawing.Point(14, 283);
            this.userPasswordCheck.Name = "userPasswordCheck";
            this.userPasswordCheck.PasswordChar = '●';
            this.userPasswordCheck.Size = new System.Drawing.Size(218, 30);
            this.userPasswordCheck.TabIndex = 25;
            // 
            // genreSeq
            // 
            this.genreSeq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genreSeq.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.genreSeq.FormattingEnabled = true;
            this.genreSeq.Location = new System.Drawing.Point(15, 664);
            this.genreSeq.Name = "genreSeq";
            this.genreSeq.Size = new System.Drawing.Size(218, 28);
            this.genreSeq.TabIndex = 24;
            this.genreSeq.SelectedIndexChanged += new System.EventHandler(this.genreSeq_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(12, 643);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "취향 장르";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(12, 578);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "주소";
            // 
            // userAddress
            // 
            this.userAddress.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userAddress.Location = new System.Drawing.Point(15, 599);
            this.userAddress.Name = "userAddress";
            this.userAddress.Size = new System.Drawing.Size(218, 30);
            this.userAddress.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(12, 512);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "전화번호";
            // 
            // userPhone
            // 
            this.userPhone.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userPhone.Location = new System.Drawing.Point(15, 533);
            this.userPhone.Name = "userPhone";
            this.userPhone.Size = new System.Drawing.Size(218, 30);
            this.userPhone.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(12, 445);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "이메일";
            // 
            // userEmail
            // 
            this.userEmail.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userEmail.Location = new System.Drawing.Point(15, 466);
            this.userEmail.Name = "userEmail";
            this.userEmail.Size = new System.Drawing.Size(218, 30);
            this.userEmail.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(11, 379);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "생년월일";
            // 
            // userBirthday
            // 
            this.userBirthday.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userBirthday.Location = new System.Drawing.Point(15, 400);
            this.userBirthday.Name = "userBirthday";
            this.userBirthday.Size = new System.Drawing.Size(218, 30);
            this.userBirthday.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(12, 321);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "별명";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(12, 202);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "비밀번호";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(12, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "아이디";
            // 
            // userNickname
            // 
            this.userNickname.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userNickname.Location = new System.Drawing.Point(15, 338);
            this.userNickname.Name = "userNickname";
            this.userNickname.Size = new System.Drawing.Size(218, 30);
            this.userNickname.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(11, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 7;
            // 
            // userPassword
            // 
            this.userPassword.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userPassword.Location = new System.Drawing.Point(15, 223);
            this.userPassword.Name = "userPassword";
            this.userPassword.PasswordChar = '●';
            this.userPassword.Size = new System.Drawing.Size(218, 30);
            this.userPassword.TabIndex = 6;
            // 
            // userId
            // 
            this.userId.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userId.Location = new System.Drawing.Point(15, 162);
            this.userId.Name = "userId";
            this.userId.Size = new System.Drawing.Size(218, 30);
            this.userId.TabIndex = 4;
            // 
            // userName
            // 
            this.userName.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userName.Location = new System.Drawing.Point(14, 98);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(218, 30);
            this.userName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(11, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "이름";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "회원가입";
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
            // closeButtonPane
            // 
            this.closeButtonPane.Controls.Add(this.closeButtonIcon);
            this.closeButtonPane.Location = new System.Drawing.Point(294, 0);
            this.closeButtonPane.Margin = new System.Windows.Forms.Padding(0);
            this.closeButtonPane.Name = "closeButtonPane";
            this.closeButtonPane.Size = new System.Drawing.Size(40, 26);
            this.closeButtonPane.TabIndex = 31;
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
            // signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.panel1);
            this.Name = "signup";
            this.Size = new System.Drawing.Size(554, 900);
            this.panel1.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.closeButtonPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeButtonIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.LinkLabel BackLogin;
        private System.Windows.Forms.LinkLabel Login;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button IdCheck;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox userPasswordCheck;
        private System.Windows.Forms.ComboBox genreSeq;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox userAddress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox userPhone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox userEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox userBirthday;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userNickname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox userPassword;
        private System.Windows.Forms.TextBox userId;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel closeButtonPane;
        private System.Windows.Forms.PictureBox closeButtonIcon;
    }
}
