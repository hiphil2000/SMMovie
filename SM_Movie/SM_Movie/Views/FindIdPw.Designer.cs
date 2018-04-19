namespace SM_Movie
{
    partial class FindIdPw
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
            this.FindLable = new System.Windows.Forms.Label();
            this.FindPWDpanel = new System.Windows.Forms.Panel();
            this.FindButtonPW = new System.Windows.Forms.Button();
            this.SearchID = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.closeButtonPane = new System.Windows.Forms.Panel();
            this.closeButtonIcon = new System.Windows.Forms.PictureBox();
            this.FindIdPanel = new System.Windows.Forms.Panel();
            this.FindButtonID = new System.Windows.Forms.Button();
            this.SearchPhoneNum = new System.Windows.Forms.TextBox();
            this.PhoneNum = new System.Windows.Forms.Label();
            this.SearchName = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.FindId = new System.Windows.Forms.Label();
            this.IDFind = new System.Windows.Forms.Button();
            this.FindPanel = new System.Windows.Forms.Panel();
            this.PwFind = new System.Windows.Forms.Button();
            this.FindPWDpanel.SuspendLayout();
            this.closeButtonPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButtonIcon)).BeginInit();
            this.FindIdPanel.SuspendLayout();
            this.FindPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FindLable
            // 
            this.FindLable.AutoSize = true;
            this.FindLable.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FindLable.Location = new System.Drawing.Point(0, 0);
            this.FindLable.Name = "FindLable";
            this.FindLable.Size = new System.Drawing.Size(307, 29);
            this.FindLable.TabIndex = 0;
            this.FindLable.Text = "아이디/패스워드 찾기";
            // 
            // FindPWDpanel
            // 
            this.FindPWDpanel.Controls.Add(this.FindButtonPW);
            this.FindPWDpanel.Controls.Add(this.SearchID);
            this.FindPWDpanel.Controls.Add(this.ID);
            this.FindPWDpanel.Controls.Add(this.label1);
            this.FindPWDpanel.Location = new System.Drawing.Point(7, 274);
            this.FindPWDpanel.Name = "FindPWDpanel";
            this.FindPWDpanel.Size = new System.Drawing.Size(747, 258);
            this.FindPWDpanel.TabIndex = 2;
            // 
            // FindButtonPW
            // 
            this.FindButtonPW.Location = new System.Drawing.Point(302, 203);
            this.FindButtonPW.Name = "FindButtonPW";
            this.FindButtonPW.Size = new System.Drawing.Size(108, 23);
            this.FindButtonPW.TabIndex = 11;
            this.FindButtonPW.Text = "찾기";
            this.FindButtonPW.UseVisualStyleBackColor = true;
            // 
            // SearchID
            // 
            this.SearchID.Location = new System.Drawing.Point(216, 88);
            this.SearchID.Name = "SearchID";
            this.SearchID.Size = new System.Drawing.Size(278, 21);
            this.SearchID.TabIndex = 8;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ID.Location = new System.Drawing.Point(122, 91);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(89, 16);
            this.ID.TabIndex = 7;
            this.ID.Text = "아이디    :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "패스워드 찾기";
            // 
            // closeButtonPane
            // 
            this.closeButtonPane.Controls.Add(this.closeButtonIcon);
            this.closeButtonPane.Location = new System.Drawing.Point(710, 0);
            this.closeButtonPane.Margin = new System.Windows.Forms.Padding(0);
            this.closeButtonPane.Name = "closeButtonPane";
            this.closeButtonPane.Size = new System.Drawing.Size(40, 26);
            this.closeButtonPane.TabIndex = 11;
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
            this.closeButtonIcon.Click += new System.EventHandler(this.closeButtonIcon_Click);
            // 
            // FindIdPanel
            // 
            this.FindIdPanel.Controls.Add(this.FindButtonID);
            this.FindIdPanel.Controls.Add(this.SearchPhoneNum);
            this.FindIdPanel.Controls.Add(this.PhoneNum);
            this.FindIdPanel.Controls.Add(this.SearchName);
            this.FindIdPanel.Controls.Add(this.name);
            this.FindIdPanel.Controls.Add(this.FindId);
            this.FindIdPanel.Location = new System.Drawing.Point(7, 274);
            this.FindIdPanel.Name = "FindIdPanel";
            this.FindIdPanel.Size = new System.Drawing.Size(747, 258);
            this.FindIdPanel.TabIndex = 1;
            this.FindIdPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.FindIdPanel_Paint);
            // 
            // FindButtonID
            // 
            this.FindButtonID.Location = new System.Drawing.Point(302, 203);
            this.FindButtonID.Name = "FindButtonID";
            this.FindButtonID.Size = new System.Drawing.Size(108, 23);
            this.FindButtonID.TabIndex = 6;
            this.FindButtonID.Text = "찾기";
            this.FindButtonID.UseVisualStyleBackColor = true;
            // 
            // SearchPhoneNum
            // 
            this.SearchPhoneNum.Location = new System.Drawing.Point(216, 133);
            this.SearchPhoneNum.Name = "SearchPhoneNum";
            this.SearchPhoneNum.Size = new System.Drawing.Size(278, 21);
            this.SearchPhoneNum.TabIndex = 5;
            // 
            // PhoneNum
            // 
            this.PhoneNum.AutoSize = true;
            this.PhoneNum.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PhoneNum.Location = new System.Drawing.Point(122, 137);
            this.PhoneNum.Name = "PhoneNum";
            this.PhoneNum.Size = new System.Drawing.Size(88, 16);
            this.PhoneNum.TabIndex = 4;
            this.PhoneNum.Text = "전화번호 :";
            // 
            // SearchName
            // 
            this.SearchName.Location = new System.Drawing.Point(216, 88);
            this.SearchName.Name = "SearchName";
            this.SearchName.Size = new System.Drawing.Size(278, 21);
            this.SearchName.TabIndex = 3;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.name.Location = new System.Drawing.Point(122, 91);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(90, 16);
            this.name.TabIndex = 1;
            this.name.Text = "이름       :";
            // 
            // FindId
            // 
            this.FindId.AutoSize = true;
            this.FindId.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FindId.Location = new System.Drawing.Point(0, 3);
            this.FindId.Name = "FindId";
            this.FindId.Size = new System.Drawing.Size(128, 21);
            this.FindId.TabIndex = 0;
            this.FindId.Text = "아이디 찾기";
            // 
            // IDFind
            // 
            this.IDFind.BackColor = System.Drawing.Color.Red;
            this.IDFind.FlatAppearance.BorderSize = 0;
            this.IDFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IDFind.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.IDFind.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IDFind.Location = new System.Drawing.Point(7, 220);
            this.IDFind.Name = "IDFind";
            this.IDFind.Size = new System.Drawing.Size(369, 48);
            this.IDFind.TabIndex = 14;
            this.IDFind.Text = " 아이디 찾기";
            this.IDFind.UseCompatibleTextRendering = true;
            this.IDFind.UseVisualStyleBackColor = false;
            // 
            // FindPanel
            // 
            this.FindPanel.Controls.Add(this.FindPWDpanel);
            this.FindPanel.Controls.Add(this.PwFind);
            this.FindPanel.Controls.Add(this.IDFind);
            this.FindPanel.Controls.Add(this.FindIdPanel);
            this.FindPanel.Controls.Add(this.closeButtonPane);
            this.FindPanel.Controls.Add(this.FindLable);
            this.FindPanel.Location = new System.Drawing.Point(3, 3);
            this.FindPanel.Name = "FindPanel";
            this.FindPanel.Size = new System.Drawing.Size(761, 541);
            this.FindPanel.TabIndex = 0;
            // 
            // PwFind
            // 
            this.PwFind.BackColor = System.Drawing.Color.Red;
            this.PwFind.FlatAppearance.BorderSize = 0;
            this.PwFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PwFind.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PwFind.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PwFind.Location = new System.Drawing.Point(384, 220);
            this.PwFind.Name = "PwFind";
            this.PwFind.Size = new System.Drawing.Size(369, 48);
            this.PwFind.TabIndex = 15;
            this.PwFind.Text = " 비밀번호 찾기";
            this.PwFind.UseCompatibleTextRendering = true;
            this.PwFind.UseVisualStyleBackColor = false;
            // 
            // FindIdPw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.FindPanel);
            this.Name = "FindIdPw";
            this.Size = new System.Drawing.Size(767, 547);
            this.FindPWDpanel.ResumeLayout(false);
            this.FindPWDpanel.PerformLayout();
            this.closeButtonPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeButtonIcon)).EndInit();
            this.FindIdPanel.ResumeLayout(false);
            this.FindIdPanel.PerformLayout();
            this.FindPanel.ResumeLayout(false);
            this.FindPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label FindLable;
        private System.Windows.Forms.Panel FindPWDpanel;
        private System.Windows.Forms.Button FindButtonPW;
        private System.Windows.Forms.TextBox SearchID;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel closeButtonPane;
        private System.Windows.Forms.PictureBox closeButtonIcon;
        private System.Windows.Forms.Panel FindIdPanel;
        private System.Windows.Forms.Button FindButtonID;
        private System.Windows.Forms.TextBox SearchPhoneNum;
        private System.Windows.Forms.Label PhoneNum;
        private System.Windows.Forms.TextBox SearchName;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label FindId;
        private System.Windows.Forms.Button IDFind;
        private System.Windows.Forms.Panel FindPanel;
        private System.Windows.Forms.Button PwFind;
    }
}
