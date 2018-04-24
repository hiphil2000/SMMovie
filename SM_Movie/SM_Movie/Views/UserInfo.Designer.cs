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
            this.UserInfo = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.memberShipSeq = new System.Windows.Forms.ComboBox();
            this.userBirthday = new System.Windows.Forms.DateTimePicker();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.userAddress = new System.Windows.Forms.TextBox();
            this.CallLabel = new System.Windows.Forms.Label();
            this.userPhone = new System.Windows.Forms.TextBox();
            this.AddrLabel = new System.Windows.Forms.Label();
            this.userEmail = new System.Windows.Forms.TextBox();
            this.genreLabel = new System.Windows.Forms.Label();
            this.userNickname = new System.Windows.Forms.TextBox();
            this.MembershipLabel = new System.Windows.Forms.Label();
            this.userPassword = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.PwLabel = new System.Windows.Forms.Label();
            this.NickLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.birthLabel = new System.Windows.Forms.Label();
            this.genreSeq = new System.Windows.Forms.ComboBox();
            this.BookingInformation = new System.Windows.Forms.Button();
            this.Changinginformation = new System.Windows.Forms.Button();
            this.Info.SuspendLayout();
            this.UserInfo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Info
            // 
            this.Info.Controls.Add(this.UserInfo);
            this.Info.Controls.Add(this.BookingInformation);
            this.Info.Controls.Add(this.Changinginformation);
            this.Info.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.Info.Location = new System.Drawing.Point(3, 3);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(750, 770);
            this.Info.TabIndex = 0;
            // 
            // UserInfo
            // 
            this.UserInfo.Controls.Add(this.tableLayoutPanel1);
            this.UserInfo.Location = new System.Drawing.Point(161, 75);
            this.UserInfo.Name = "UserInfo";
            this.UserInfo.Size = new System.Drawing.Size(441, 513);
            this.UserInfo.TabIndex = 23;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel1.Controls.Add(this.memberShipSeq, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.userBirthday, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.EmailLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.NameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.userAddress, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.CallLabel, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.userPhone, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.AddrLabel, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.userEmail, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.genreLabel, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.userNickname, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.MembershipLabel, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.userPassword, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.userName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.id, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.PwLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.NickLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.IdLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.birthLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.genreSeq, 1, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(441, 513);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // memberShipSeq
            // 
            this.memberShipSeq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memberShipSeq.Font = new System.Drawing.Font("맑은 고딕", 14.25F);
            this.memberShipSeq.FormattingEnabled = true;
            this.memberShipSeq.Location = new System.Drawing.Point(150, 462);
            this.memberShipSeq.Name = "memberShipSeq";
            this.memberShipSeq.Size = new System.Drawing.Size(288, 33);
            this.memberShipSeq.TabIndex = 26;
            // 
            // userBirthday
            // 
            this.userBirthday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userBirthday.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userBirthday.Location = new System.Drawing.Point(150, 54);
            this.userBirthday.Name = "userBirthday";
            this.userBirthday.Size = new System.Drawing.Size(288, 33);
            this.userBirthday.TabIndex = 24;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmailLabel.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EmailLabel.Location = new System.Drawing.Point(3, 255);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(141, 31);
            this.EmailLabel.TabIndex = 5;
            this.EmailLabel.Text = "이메일 :";
            this.EmailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameLabel.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NameLabel.Location = new System.Drawing.Point(3, 0);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(141, 31);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "사용자 명 :";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // userAddress
            // 
            this.userAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userAddress.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userAddress.Location = new System.Drawing.Point(150, 360);
            this.userAddress.Name = "userAddress";
            this.userAddress.Size = new System.Drawing.Size(288, 33);
            this.userAddress.TabIndex = 16;
            // 
            // CallLabel
            // 
            this.CallLabel.AutoSize = true;
            this.CallLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CallLabel.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CallLabel.Location = new System.Drawing.Point(3, 306);
            this.CallLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.CallLabel.Name = "CallLabel";
            this.CallLabel.Size = new System.Drawing.Size(141, 31);
            this.CallLabel.TabIndex = 6;
            this.CallLabel.Text = "전화번호 :";
            this.CallLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // userPhone
            // 
            this.userPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userPhone.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userPhone.Location = new System.Drawing.Point(150, 309);
            this.userPhone.Name = "userPhone";
            this.userPhone.Size = new System.Drawing.Size(288, 33);
            this.userPhone.TabIndex = 15;
            // 
            // AddrLabel
            // 
            this.AddrLabel.AutoSize = true;
            this.AddrLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddrLabel.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AddrLabel.Location = new System.Drawing.Point(3, 357);
            this.AddrLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.AddrLabel.Name = "AddrLabel";
            this.AddrLabel.Size = new System.Drawing.Size(141, 31);
            this.AddrLabel.TabIndex = 7;
            this.AddrLabel.Text = "주소 :";
            this.AddrLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // userEmail
            // 
            this.userEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userEmail.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userEmail.Location = new System.Drawing.Point(150, 258);
            this.userEmail.Name = "userEmail";
            this.userEmail.Size = new System.Drawing.Size(288, 33);
            this.userEmail.TabIndex = 14;
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.genreLabel.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.genreLabel.Location = new System.Drawing.Point(3, 408);
            this.genreLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(141, 31);
            this.genreLabel.TabIndex = 8;
            this.genreLabel.Text = "취향장르 :";
            this.genreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // userNickname
            // 
            this.userNickname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userNickname.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userNickname.Location = new System.Drawing.Point(150, 207);
            this.userNickname.Name = "userNickname";
            this.userNickname.Size = new System.Drawing.Size(288, 33);
            this.userNickname.TabIndex = 13;
            // 
            // MembershipLabel
            // 
            this.MembershipLabel.AutoSize = true;
            this.MembershipLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MembershipLabel.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MembershipLabel.Location = new System.Drawing.Point(3, 459);
            this.MembershipLabel.Name = "MembershipLabel";
            this.MembershipLabel.Size = new System.Drawing.Size(141, 54);
            this.MembershipLabel.TabIndex = 9;
            this.MembershipLabel.Text = "고객등급 :";
            this.MembershipLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // userPassword
            // 
            this.userPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userPassword.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userPassword.Location = new System.Drawing.Point(150, 156);
            this.userPassword.Name = "userPassword";
            this.userPassword.Size = new System.Drawing.Size(288, 33);
            this.userPassword.TabIndex = 12;
            // 
            // userName
            // 
            this.userName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userName.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userName.Location = new System.Drawing.Point(150, 3);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(288, 33);
            this.userName.TabIndex = 0;
            // 
            // id
            // 
            this.id.Dock = System.Windows.Forms.DockStyle.Fill;
            this.id.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.id.Location = new System.Drawing.Point(150, 105);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(288, 33);
            this.id.TabIndex = 11;
            // 
            // PwLabel
            // 
            this.PwLabel.AutoSize = true;
            this.PwLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PwLabel.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PwLabel.Location = new System.Drawing.Point(3, 153);
            this.PwLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.PwLabel.Name = "PwLabel";
            this.PwLabel.Size = new System.Drawing.Size(141, 31);
            this.PwLabel.TabIndex = 3;
            this.PwLabel.Text = "비밀번호 :";
            this.PwLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NickLabel
            // 
            this.NickLabel.AutoSize = true;
            this.NickLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NickLabel.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NickLabel.Location = new System.Drawing.Point(3, 204);
            this.NickLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.NickLabel.Name = "NickLabel";
            this.NickLabel.Size = new System.Drawing.Size(141, 31);
            this.NickLabel.TabIndex = 4;
            this.NickLabel.Text = "별명 :";
            this.NickLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IdLabel.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.IdLabel.Location = new System.Drawing.Point(3, 102);
            this.IdLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(141, 31);
            this.IdLabel.TabIndex = 2;
            this.IdLabel.Text = "아이디 :";
            this.IdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // birthLabel
            // 
            this.birthLabel.AutoSize = true;
            this.birthLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.birthLabel.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.birthLabel.Location = new System.Drawing.Point(3, 51);
            this.birthLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.birthLabel.Name = "birthLabel";
            this.birthLabel.Size = new System.Drawing.Size(141, 31);
            this.birthLabel.TabIndex = 1;
            this.birthLabel.Text = "생년월일 :";
            this.birthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // genreSeq
            // 
            this.genreSeq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.genreSeq.Font = new System.Drawing.Font("맑은 고딕", 14.25F);
            this.genreSeq.FormattingEnabled = true;
            this.genreSeq.Location = new System.Drawing.Point(150, 411);
            this.genreSeq.Name = "genreSeq";
            this.genreSeq.Size = new System.Drawing.Size(288, 33);
            this.genreSeq.TabIndex = 25;
            // 
            // BookingInformation
            // 
            this.BookingInformation.Location = new System.Drawing.Point(101, 643);
            this.BookingInformation.Name = "BookingInformation";
            this.BookingInformation.Size = new System.Drawing.Size(268, 49);
            this.BookingInformation.TabIndex = 22;
            this.BookingInformation.Text = "내 예매 정보";
            this.BookingInformation.UseVisualStyleBackColor = true;
            // 
            // Changinginformation
            // 
            this.Changinginformation.Location = new System.Drawing.Point(375, 643);
            this.Changinginformation.Name = "Changinginformation";
            this.Changinginformation.Size = new System.Drawing.Size(268, 49);
            this.Changinginformation.TabIndex = 20;
            this.Changinginformation.Text = "수정";
            this.Changinginformation.UseVisualStyleBackColor = true;
            this.Changinginformation.Click += new System.EventHandler(this.Changinginformation_Click);
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
            this.UserInfo.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Info;
        private System.Windows.Forms.TextBox userAddress;
        private System.Windows.Forms.TextBox userPhone;
        private System.Windows.Forms.TextBox userEmail;
        private System.Windows.Forms.TextBox userNickname;
        private System.Windows.Forms.TextBox userPassword;
        private System.Windows.Forms.TextBox id;
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
        private System.Windows.Forms.Button BookingInformation;
        private System.Windows.Forms.Panel UserInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DateTimePicker userBirthday;
        private System.Windows.Forms.ComboBox memberShipSeq;
        private System.Windows.Forms.ComboBox genreSeq;
    }
}
