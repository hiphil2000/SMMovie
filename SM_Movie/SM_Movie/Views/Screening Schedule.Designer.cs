namespace SM_Movie.Views
{
    partial class Screening_Schedule
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
            this.ScreeningSchedulePane = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.DayPane = new System.Windows.Forms.Panel();
            this.MondayBtn = new System.Windows.Forms.Button();
            this.TuesdayBtn = new System.Windows.Forms.Button();
            this.WednesdayBtn = new System.Windows.Forms.Button();
            this.ThursdayBtn = new System.Windows.Forms.Button();
            this.FridayBtn = new System.Windows.Forms.Button();
            this.Saturdaybtn = new System.Windows.Forms.Button();
            this.Sundaybtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ScreeningSchedulePane.SuspendLayout();
            this.DayPane.SuspendLayout();
            this.SuspendLayout();
            // 
            // ScreeningSchedulePane
            // 
            this.ScreeningSchedulePane.Controls.Add(this.panel1);
            this.ScreeningSchedulePane.Controls.Add(this.DayPane);
            this.ScreeningSchedulePane.Controls.Add(this.label1);
            this.ScreeningSchedulePane.Location = new System.Drawing.Point(3, 3);
            this.ScreeningSchedulePane.Name = "ScreeningSchedulePane";
            this.ScreeningSchedulePane.Size = new System.Drawing.Size(1014, 184);
            this.ScreeningSchedulePane.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "상영 시간표";
            // 
            // DayPane
            // 
            this.DayPane.Controls.Add(this.Sundaybtn);
            this.DayPane.Controls.Add(this.Saturdaybtn);
            this.DayPane.Controls.Add(this.FridayBtn);
            this.DayPane.Controls.Add(this.ThursdayBtn);
            this.DayPane.Controls.Add(this.WednesdayBtn);
            this.DayPane.Controls.Add(this.TuesdayBtn);
            this.DayPane.Controls.Add(this.MondayBtn);
            this.DayPane.Location = new System.Drawing.Point(101, 62);
            this.DayPane.Name = "DayPane";
            this.DayPane.Size = new System.Drawing.Size(790, 100);
            this.DayPane.TabIndex = 1;
            // 
            // MondayBtn
            // 
            this.MondayBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.MondayBtn.FlatAppearance.BorderSize = 0;
            this.MondayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MondayBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MondayBtn.Location = new System.Drawing.Point(3, 3);
            this.MondayBtn.Name = "MondayBtn";
            this.MondayBtn.Size = new System.Drawing.Size(107, 94);
            this.MondayBtn.TabIndex = 10;
            this.MondayBtn.Text = " 월";
            this.MondayBtn.UseCompatibleTextRendering = true;
            this.MondayBtn.UseVisualStyleBackColor = false;
            // 
            // TuesdayBtn
            // 
            this.TuesdayBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TuesdayBtn.FlatAppearance.BorderSize = 0;
            this.TuesdayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TuesdayBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TuesdayBtn.Location = new System.Drawing.Point(116, 3);
            this.TuesdayBtn.Name = "TuesdayBtn";
            this.TuesdayBtn.Size = new System.Drawing.Size(107, 94);
            this.TuesdayBtn.TabIndex = 11;
            this.TuesdayBtn.Text = " 화";
            this.TuesdayBtn.UseCompatibleTextRendering = true;
            this.TuesdayBtn.UseVisualStyleBackColor = false;
            // 
            // WednesdayBtn
            // 
            this.WednesdayBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.WednesdayBtn.FlatAppearance.BorderSize = 0;
            this.WednesdayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WednesdayBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.WednesdayBtn.Location = new System.Drawing.Point(229, 3);
            this.WednesdayBtn.Name = "WednesdayBtn";
            this.WednesdayBtn.Size = new System.Drawing.Size(107, 94);
            this.WednesdayBtn.TabIndex = 12;
            this.WednesdayBtn.Text = " 수";
            this.WednesdayBtn.UseCompatibleTextRendering = true;
            this.WednesdayBtn.UseVisualStyleBackColor = false;
            // 
            // ThursdayBtn
            // 
            this.ThursdayBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ThursdayBtn.FlatAppearance.BorderSize = 0;
            this.ThursdayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThursdayBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ThursdayBtn.Location = new System.Drawing.Point(342, 3);
            this.ThursdayBtn.Name = "ThursdayBtn";
            this.ThursdayBtn.Size = new System.Drawing.Size(107, 94);
            this.ThursdayBtn.TabIndex = 13;
            this.ThursdayBtn.Text = " 목";
            this.ThursdayBtn.UseCompatibleTextRendering = true;
            this.ThursdayBtn.UseVisualStyleBackColor = false;
            // 
            // FridayBtn
            // 
            this.FridayBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.FridayBtn.FlatAppearance.BorderSize = 0;
            this.FridayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FridayBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FridayBtn.Location = new System.Drawing.Point(454, 3);
            this.FridayBtn.Name = "FridayBtn";
            this.FridayBtn.Size = new System.Drawing.Size(107, 94);
            this.FridayBtn.TabIndex = 14;
            this.FridayBtn.Text = " 금";
            this.FridayBtn.UseCompatibleTextRendering = true;
            this.FridayBtn.UseVisualStyleBackColor = false;
            // 
            // Saturdaybtn
            // 
            this.Saturdaybtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Saturdaybtn.FlatAppearance.BorderSize = 0;
            this.Saturdaybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Saturdaybtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Saturdaybtn.Location = new System.Drawing.Point(567, 3);
            this.Saturdaybtn.Name = "Saturdaybtn";
            this.Saturdaybtn.Size = new System.Drawing.Size(107, 94);
            this.Saturdaybtn.TabIndex = 15;
            this.Saturdaybtn.Text = " 토";
            this.Saturdaybtn.UseCompatibleTextRendering = true;
            this.Saturdaybtn.UseVisualStyleBackColor = false;
            // 
            // Sundaybtn
            // 
            this.Sundaybtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Sundaybtn.FlatAppearance.BorderSize = 0;
            this.Sundaybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sundaybtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Sundaybtn.Location = new System.Drawing.Point(680, 3);
            this.Sundaybtn.Name = "Sundaybtn";
            this.Sundaybtn.Size = new System.Drawing.Size(107, 94);
            this.Sundaybtn.TabIndex = 16;
            this.Sundaybtn.Text = " 일";
            this.Sundaybtn.UseCompatibleTextRendering = true;
            this.Sundaybtn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 180);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 483);
            this.panel1.TabIndex = 2;
            // 
            // Screening_Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ScreeningSchedulePane);
            this.Name = "Screening_Schedule";
            this.Size = new System.Drawing.Size(1020, 666);
            this.ScreeningSchedulePane.ResumeLayout(false);
            this.ScreeningSchedulePane.PerformLayout();
            this.DayPane.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ScreeningSchedulePane;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel DayPane;
        private System.Windows.Forms.Button Sundaybtn;
        private System.Windows.Forms.Button Saturdaybtn;
        private System.Windows.Forms.Button FridayBtn;
        private System.Windows.Forms.Button ThursdayBtn;
        private System.Windows.Forms.Button WednesdayBtn;
        private System.Windows.Forms.Button TuesdayBtn;
        private System.Windows.Forms.Button MondayBtn;
        private System.Windows.Forms.Panel panel1;
    }
}
