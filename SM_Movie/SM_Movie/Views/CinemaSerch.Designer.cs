namespace SM_Movie.Views
{
    partial class CinemaSerch
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
            this.titlePane = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CinemaSearchBox = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.searchMenuPane2 = new System.Windows.Forms.Panel();
            this.resultPane2 = new System.Windows.Forms.Panel();
            this.titlePane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlePane
            // 
            this.titlePane.Controls.Add(this.CinemaSearchBox);
            this.titlePane.Controls.Add(this.label1);
            this.titlePane.Location = new System.Drawing.Point(0, 0);
            this.titlePane.Name = "titlePane";
            this.titlePane.Size = new System.Drawing.Size(707, 113);
            this.titlePane.TabIndex = 0;
            this.titlePane.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "극장 검색하기";
            // 
            // CinemaSearchBox
            // 
            this.CinemaSearchBox.Location = new System.Drawing.Point(35, 95);
            this.CinemaSearchBox.Name = "CinemaSearchBox";
            this.CinemaSearchBox.Size = new System.Drawing.Size(643, 21);
            this.CinemaSearchBox.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.titlePane);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.resultPane2);
            this.splitContainer1.Panel2.Controls.Add(this.searchMenuPane2);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(707, 473);
            this.splitContainer1.SplitterDistance = 113;
            this.splitContainer1.TabIndex = 1;
            // 
            // searchMenuPane2
            // 
            this.searchMenuPane2.Location = new System.Drawing.Point(0, 0);
            this.searchMenuPane2.Name = "searchMenuPane2";
            this.searchMenuPane2.Size = new System.Drawing.Size(134, 356);
            this.searchMenuPane2.TabIndex = 0;
            // 
            // resultPane2
            // 
            this.resultPane2.Location = new System.Drawing.Point(136, 0);
            this.resultPane2.Name = "resultPane2";
            this.resultPane2.Size = new System.Drawing.Size(571, 356);
            this.resultPane2.TabIndex = 1;
            // 
            // CinemaSerch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.splitContainer1);
            this.Name = "CinemaSerch";
            this.Size = new System.Drawing.Size(707, 479);
            this.titlePane.ResumeLayout(false);
            this.titlePane.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titlePane;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CinemaSearchBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel searchMenuPane2;
        private System.Windows.Forms.Panel resultPane2;
    }
}
