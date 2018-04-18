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
            this.FindPanel = new System.Windows.Forms.Panel();
            this.FindIdPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.SearchPhoneNum = new System.Windows.Forms.TextBox();
            this.PhoneNum = new System.Windows.Forms.Label();
            this.SearchName = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.FindId = new System.Windows.Forms.Label();
            this.FindLable = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SearchID = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.closeButtonPane = new System.Windows.Forms.Panel();
            this.closeButtonIcon = new System.Windows.Forms.PictureBox();
            this.FindPanel.SuspendLayout();
            this.FindIdPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.closeButtonPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButtonIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // FindPanel
            // 
            this.FindPanel.Controls.Add(this.closeButtonPane);
            this.FindPanel.Controls.Add(this.panel1);
            this.FindPanel.Controls.Add(this.FindIdPanel);
            this.FindPanel.Controls.Add(this.FindLable);
            this.FindPanel.Location = new System.Drawing.Point(3, 3);
            this.FindPanel.Name = "FindPanel";
            this.FindPanel.Size = new System.Drawing.Size(761, 541);
            this.FindPanel.TabIndex = 0;
            // 
            // FindIdPanel
            // 
            this.FindIdPanel.Controls.Add(this.button1);
            this.FindIdPanel.Controls.Add(this.SearchPhoneNum);
            this.FindIdPanel.Controls.Add(this.PhoneNum);
            this.FindIdPanel.Controls.Add(this.SearchName);
            this.FindIdPanel.Controls.Add(this.name);
            this.FindIdPanel.Controls.Add(this.FindId);
            this.FindIdPanel.Location = new System.Drawing.Point(5, 89);
            this.FindIdPanel.Name = "FindIdPanel";
            this.FindIdPanel.Size = new System.Drawing.Size(756, 258);
            this.FindIdPanel.TabIndex = 1;
            this.FindIdPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.FindIdPanel_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(302, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.SearchID);
            this.panel1.Controls.Add(this.ID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 353);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 258);
            this.panel1.TabIndex = 2;
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(314, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // SearchID
            // 
            this.SearchID.Location = new System.Drawing.Point(287, 61);
            this.SearchID.Name = "SearchID";
            this.SearchID.Size = new System.Drawing.Size(278, 21);
            this.SearchID.TabIndex = 8;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ID.Location = new System.Drawing.Point(192, 64);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(89, 16);
            this.ID.TabIndex = 7;
            this.ID.Text = "아이디    :";
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
            // 
            // FindIdPw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FindPanel);
            this.Name = "FindIdPw";
            this.Size = new System.Drawing.Size(767, 547);
            this.FindPanel.ResumeLayout(false);
            this.FindPanel.PerformLayout();
            this.FindIdPanel.ResumeLayout(false);
            this.FindIdPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.closeButtonPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeButtonIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FindPanel;
        private System.Windows.Forms.Panel FindIdPanel;
        private System.Windows.Forms.Label FindId;
        private System.Windows.Forms.Label FindLable;
        private System.Windows.Forms.TextBox SearchPhoneNum;
        private System.Windows.Forms.Label PhoneNum;
        private System.Windows.Forms.TextBox SearchName;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox SearchID;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel closeButtonPane;
        private System.Windows.Forms.PictureBox closeButtonIcon;
    }
}
