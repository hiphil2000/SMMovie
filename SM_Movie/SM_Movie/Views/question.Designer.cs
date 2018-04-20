namespace SM_Movie.Views
{
    partial class question
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(question));
            this.panel1 = new System.Windows.Forms.Panel();
            this.settinglabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PrivacyOk = new System.Windows.Forms.RadioButton();
            this.PrivacyDonot = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.userSeq = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.qnaTitle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.qnaContent = new System.Windows.Forms.TextBox();
            this.insertquestion = new System.Windows.Forms.Button();
            this.closeButtonPane = new System.Windows.Forms.Panel();
            this.closeButtonIcon = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.closeButtonPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButtonIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.closeButtonPane);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.settinglabel);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1156, 279);
            this.panel1.TabIndex = 0;
            // 
            // settinglabel
            // 
            this.settinglabel.AutoSize = true;
            this.settinglabel.Font = new System.Drawing.Font("굴림", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.settinglabel.Location = new System.Drawing.Point(3, 0);
            this.settinglabel.Name = "settinglabel";
            this.settinglabel.Size = new System.Drawing.Size(189, 37);
            this.settinglabel.TabIndex = 1;
            this.settinglabel.Text = "1 : 1 문의";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(997, 144);
            this.label1.TabIndex = 2;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.PrivacyDonot);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.PrivacyOk);
            this.panel2.Location = new System.Drawing.Point(10, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1109, 223);
            this.panel2.TabIndex = 3;
            // 
            // PrivacyOk
            // 
            this.PrivacyOk.AutoSize = true;
            this.PrivacyOk.Location = new System.Drawing.Point(923, 201);
            this.PrivacyOk.Name = "PrivacyOk";
            this.PrivacyOk.Size = new System.Drawing.Size(59, 16);
            this.PrivacyOk.TabIndex = 4;
            this.PrivacyOk.TabStop = true;
            this.PrivacyOk.Text = "동의함";
            this.PrivacyOk.UseVisualStyleBackColor = true;
            this.PrivacyOk.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // PrivacyDonot
            // 
            this.PrivacyDonot.AutoSize = true;
            this.PrivacyDonot.Location = new System.Drawing.Point(1007, 201);
            this.PrivacyDonot.Name = "PrivacyDonot";
            this.PrivacyDonot.Size = new System.Drawing.Size(99, 16);
            this.PrivacyDonot.TabIndex = 5;
            this.PrivacyDonot.TabStop = true;
            this.PrivacyDonot.Text = "동의하지 않음";
            this.PrivacyDonot.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "개인정보 수집에 동의하십니까? ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(583, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "* 원활한 서비스 이용을 위한 최소한의 개인정보이므로 동의하지 않을 경우 서비스를 이용하실 수 없습니다.";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.insertquestion);
            this.panel3.Controls.Add(this.qnaContent);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.qnaTitle);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.userSeq);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(0, 286);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1156, 296);
            this.panel3.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(11, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "이름   :";
            // 
            // userSeq
            // 
            this.userSeq.Location = new System.Drawing.Point(92, 13);
            this.userSeq.Name = "userSeq";
            this.userSeq.Size = new System.Drawing.Size(100, 21);
            this.userSeq.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(11, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "제목   :";
            // 
            // qnaTitle
            // 
            this.qnaTitle.Location = new System.Drawing.Point(92, 45);
            this.qnaTitle.Name = "qnaTitle";
            this.qnaTitle.Size = new System.Drawing.Size(963, 21);
            this.qnaTitle.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(11, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "내용   :";
            // 
            // qnaContent
            // 
            this.qnaContent.Location = new System.Drawing.Point(92, 100);
            this.qnaContent.Name = "qnaContent";
            this.qnaContent.Size = new System.Drawing.Size(963, 21);
            this.qnaContent.TabIndex = 12;
            // 
            // insertquestion
            // 
            this.insertquestion.Location = new System.Drawing.Point(528, 262);
            this.insertquestion.Name = "insertquestion";
            this.insertquestion.Size = new System.Drawing.Size(100, 31);
            this.insertquestion.TabIndex = 13;
            this.insertquestion.Text = "등록";
            this.insertquestion.UseVisualStyleBackColor = true;
            // 
            // closeButtonPane
            // 
            this.closeButtonPane.Controls.Add(this.closeButtonIcon);
            this.closeButtonPane.Location = new System.Drawing.Point(1108, 0);
            this.closeButtonPane.Margin = new System.Windows.Forms.Padding(0);
            this.closeButtonPane.Name = "closeButtonPane";
            this.closeButtonPane.Size = new System.Drawing.Size(40, 26);
            this.closeButtonPane.TabIndex = 32;
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
            // question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "question";
            this.Size = new System.Drawing.Size(1156, 585);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.closeButtonPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeButtonIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton PrivacyDonot;
        private System.Windows.Forms.RadioButton PrivacyOk;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label settinglabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox userSeq;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button insertquestion;
        private System.Windows.Forms.TextBox qnaContent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox qnaTitle;
        private System.Windows.Forms.Panel closeButtonPane;
        private System.Windows.Forms.PictureBox closeButtonIcon;
    }
}
