namespace SM_Movie.Views
{
    partial class SearchCinema
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
            this.Info = new System.Windows.Forms.Panel();
            this.NameLabel = new System.Windows.Forms.Label();
            this.birthLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.PwLabel = new System.Windows.Forms.Label();
            this.NickLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.CallLabel = new System.Windows.Forms.Label();
            this.AddrLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.MembershipLabel = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.userBirthday = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.userPassword = new System.Windows.Forms.TextBox();
            this.userNickname = new System.Windows.Forms.TextBox();
            this.userEmail = new System.Windows.Forms.TextBox();
            this.userPhone = new System.Windows.Forms.TextBox();
            this.userAddress = new System.Windows.Forms.TextBox();
            this.genreSeq = new System.Windows.Forms.TextBox();
            this.memberShipSeq = new System.Windows.Forms.TextBox();
            this.Myinfo = new System.Windows.Forms.Label();
            this.Changinginformation = new System.Windows.Forms.Button();
            this.closeButtonPane = new System.Windows.Forms.Panel();
            this.closeButtonIcon = new System.Windows.Forms.PictureBox();
            this.BookingInformation = new System.Windows.Forms.Button();
            this.UserInfo = new System.Windows.Forms.Panel();
            this.Info.SuspendLayout();
            this.closeButtonPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButtonIcon)).BeginInit();
            this.UserInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // Info
            // 
            this.Info.Controls.Add(this.UserInfo);
            this.Info.Controls.Add(this.BookingInformation);
            this.Info.Controls.Add(this.closeButtonPane);
            this.Info.Controls.Add(this.Changinginformation);
            this.Info.Controls.Add(this.Myinfo);
            this.Info.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.Info.Location = new System.Drawing.Point(3, 3);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(750, 770);
            this.Info.TabIndex = 0;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NameLabel.Location = new System.Drawing.Point(73, 76);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(100, 16);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "사용자 명  :";
            // 
            // birthLabel
            // 
            this.birthLabel.AutoSize = true;
            this.birthLabel.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.birthLabel.Location = new System.Drawing.Point(73, 112);
            this.birthLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.birthLabel.Name = "birthLabel";
            this.birthLabel.Size = new System.Drawing.Size(100, 16);
            this.birthLabel.TabIndex = 1;
            this.birthLabel.Text = "생년월일   :";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(73, 148);
            this.IdLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(101, 16);
            this.IdLabel.TabIndex = 2;
            this.IdLabel.Text = "아이디      :";
            // 
            // PwLabel
            // 
            this.PwLabel.AutoSize = true;
            this.PwLabel.Location = new System.Drawing.Point(73, 184);
            this.PwLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.PwLabel.Name = "PwLabel";
            this.PwLabel.Size = new System.Drawing.Size(100, 16);
            this.PwLabel.TabIndex = 3;
            this.PwLabel.Text = "비밀번호   :";
            // 
            // NickLabel
            // 
            this.NickLabel.AutoSize = true;
            this.NickLabel.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.NickLabel.Location = new System.Drawing.Point(73, 220);
            this.NickLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.NickLabel.Name = "NickLabel";
            this.NickLabel.Size = new System.Drawing.Size(102, 16);
            this.NickLabel.TabIndex = 4;
            this.NickLabel.Text = "별명         :";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.EmailLabel.Location = new System.Drawing.Point(73, 256);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(95, 16);
            this.EmailLabel.TabIndex = 5;
            this.EmailLabel.Text = "이메일     :";
            // 
            // CallLabel
            // 
            this.CallLabel.AutoSize = true;
            this.CallLabel.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CallLabel.Location = new System.Drawing.Point(73, 292);
            this.CallLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.CallLabel.Name = "CallLabel";
            this.CallLabel.Size = new System.Drawing.Size(94, 16);
            this.CallLabel.TabIndex = 6;
            this.CallLabel.Text = "전화번호  :";
            // 
            // AddrLabel
            // 
            this.AddrLabel.AutoSize = true;
            this.AddrLabel.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AddrLabel.Location = new System.Drawing.Point(73, 328);
            this.AddrLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.AddrLabel.Name = "AddrLabel";
            this.AddrLabel.Size = new System.Drawing.Size(90, 16);
            this.AddrLabel.TabIndex = 7;
            this.AddrLabel.Text = "주소       :";
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.genreLabel.Location = new System.Drawing.Point(73, 364);
            this.genreLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(94, 16);
            this.genreLabel.TabIndex = 8;
            this.genreLabel.Text = "취향장르  :";
            // 
            // MembershipLabel
            // 
            this.MembershipLabel.AutoSize = true;
            this.MembershipLabel.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MembershipLabel.Location = new System.Drawing.Point(73, 400);
            this.MembershipLabel.Name = "MembershipLabel";
            this.MembershipLabel.Size = new System.Drawing.Size(88, 16);
            this.MembershipLabel.TabIndex = 9;
            this.MembershipLabel.Text = "고객등급 :";
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(192, 69);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(212, 26);
            this.userName.TabIndex = 0;
            // 
            // userBirthday
            // 
            this.userBirthday.Location = new System.Drawing.Point(192, 109);
            this.userBirthday.Name = "userBirthday";
            this.userBirthday.Size = new System.Drawing.Size(212, 26);
            this.userBirthday.TabIndex = 10;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(192, 141);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(212, 26);
            this.id.TabIndex = 11;
            // 
            // userPassword
            // 
            this.userPassword.Location = new System.Drawing.Point(192, 178);
            this.userPassword.Name = "userPassword";
            this.userPassword.Size = new System.Drawing.Size(212, 26);
            this.userPassword.TabIndex = 12;
            // 
            // userNickname
            // 
            this.userNickname.Location = new System.Drawing.Point(192, 214);
            this.userNickname.Name = "userNickname";
            this.userNickname.Size = new System.Drawing.Size(212, 26);
            this.userNickname.TabIndex = 13;
            // 
            // userEmail
            // 
            this.userEmail.Location = new System.Drawing.Point(192, 253);
            this.userEmail.Name = "userEmail";
            this.userEmail.Size = new System.Drawing.Size(212, 26);
            this.userEmail.TabIndex = 14;
            // 
            // userPhone
            // 
            this.userPhone.Location = new System.Drawing.Point(192, 285);
            this.userPhone.Name = "userPhone";
            this.userPhone.Size = new System.Drawing.Size(212, 26);
            this.userPhone.TabIndex = 15;
            // 
            // userAddress
            // 
            this.userAddress.Location = new System.Drawing.Point(192, 321);
            this.userAddress.Name = "userAddress";
            this.userAddress.Size = new System.Drawing.Size(212, 26);
            this.userAddress.TabIndex = 16;
            // 
            // genreSeq
            // 
            this.genreSeq.Location = new System.Drawing.Point(192, 358);
            this.genreSeq.Name = "genreSeq";
            this.genreSeq.Size = new System.Drawing.Size(212, 26);
            this.genreSeq.TabIndex = 17;
            // 
            // memberShipSeq
            // 
            this.memberShipSeq.Location = new System.Drawing.Point(192, 394);
            this.memberShipSeq.Name = "memberShipSeq";
            this.memberShipSeq.Size = new System.Drawing.Size(212, 26);
            this.memberShipSeq.TabIndex = 18;
            // 
            // Myinfo
            // 
            this.Myinfo.AutoSize = true;
            this.Myinfo.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Myinfo.Location = new System.Drawing.Point(3, 0);
            this.Myinfo.Name = "Myinfo";
            this.Myinfo.Size = new System.Drawing.Size(114, 29);
            this.Myinfo.TabIndex = 19;
            this.Myinfo.Text = "내 정보";
            // 
            // Changinginformation
            // 
            this.Changinginformation.Location = new System.Drawing.Point(375, 666);
            this.Changinginformation.Name = "Changinginformation";
            this.Changinginformation.Size = new System.Drawing.Size(268, 49);
            this.Changinginformation.TabIndex = 20;
            this.Changinginformation.Text = "수정";
            this.Changinginformation.UseVisualStyleBackColor = true;
            // 
            // closeButtonPane
            // 
            this.closeButtonPane.Controls.Add(this.closeButtonIcon);
            this.closeButtonPane.Location = new System.Drawing.Point(701, 0);
            this.closeButtonPane.Margin = new System.Windows.Forms.Padding(0);
            this.closeButtonPane.Name = "closeButtonPane";
            this.closeButtonPane.Size = new System.Drawing.Size(40, 26);
            this.closeButtonPane.TabIndex = 21;
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
            // BookingInformation
            // 
            this.BookingInformation.Location = new System.Drawing.Point(101, 666);
            this.BookingInformation.Name = "BookingInformation";
            this.BookingInformation.Size = new System.Drawing.Size(268, 49);
            this.BookingInformation.TabIndex = 22;
            this.BookingInformation.Text = "내 예매 정보";
            this.BookingInformation.UseVisualStyleBackColor = true;
            // 
            // UserInfo
            // 
            this.UserInfo.Controls.Add(this.EmailLabel);
            this.UserInfo.Controls.Add(this.NameLabel);
            this.UserInfo.Controls.Add(this.birthLabel);
            this.UserInfo.Controls.Add(this.IdLabel);
            this.UserInfo.Controls.Add(this.PwLabel);
            this.UserInfo.Controls.Add(this.memberShipSeq);
            this.UserInfo.Controls.Add(this.NickLabel);
            this.UserInfo.Controls.Add(this.genreSeq);
            this.UserInfo.Controls.Add(this.CallLabel);
            this.UserInfo.Controls.Add(this.userAddress);
            this.UserInfo.Controls.Add(this.AddrLabel);
            this.UserInfo.Controls.Add(this.userPhone);
            this.UserInfo.Controls.Add(this.genreLabel);
            this.UserInfo.Controls.Add(this.userEmail);
            this.UserInfo.Controls.Add(this.MembershipLabel);
            this.UserInfo.Controls.Add(this.userNickname);
            this.UserInfo.Controls.Add(this.userName);
            this.UserInfo.Controls.Add(this.userPassword);
            this.UserInfo.Controls.Add(this.userBirthday);
            this.UserInfo.Controls.Add(this.id);
            this.UserInfo.Location = new System.Drawing.Point(161, 98);
            this.UserInfo.Name = "UserInfo";
            this.UserInfo.Size = new System.Drawing.Size(441, 513);
            this.UserInfo.TabIndex = 23;
            // 
            // SearchCinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.Info);
            this.Name = "SearchCinema";
            this.Size = new System.Drawing.Size(756, 776);
            this.Info.ResumeLayout(false);
            this.Info.PerformLayout();
            this.closeButtonPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeButtonIcon)).EndInit();
            this.UserInfo.ResumeLayout(false);
            this.UserInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Info;
        private System.Windows.Forms.TextBox memberShipSeq;
        private System.Windows.Forms.TextBox genreSeq;
        private System.Windows.Forms.TextBox userAddress;
        private System.Windows.Forms.TextBox userPhone;
        private System.Windows.Forms.TextBox userEmail;
        private System.Windows.Forms.TextBox userNickname;
        private System.Windows.Forms.TextBox userPassword;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox userBirthday;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Label MembershipLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label AddrLabel;
        private System.Windows.Forms.Label CallLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label NickLabel;
        private System.Windows.Forms.Label PwLabel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label birthLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button Changinginformation;
        private System.Windows.Forms.Label Myinfo;
        private System.Windows.Forms.Button BookingInformation;
        private System.Windows.Forms.Panel closeButtonPane;
        private System.Windows.Forms.PictureBox closeButtonIcon;
        private System.Windows.Forms.Panel UserInfo;
    }
}
