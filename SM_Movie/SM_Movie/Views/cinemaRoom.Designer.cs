namespace SM_Movie.Views
{
    partial class cinemaRoom
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeButtonPane = new System.Windows.Forms.Panel();
            this.closeButtonIcon = new System.Windows.Forms.PictureBox();
            this.CinemaRoomsetting = new System.Windows.Forms.Panel();
            this.GoReservation = new System.Windows.Forms.Button();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.ComboBox();
            this.CityLabel = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.ComboBox();
            this.CinemaRoomLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.closeButtonPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButtonIcon)).BeginInit();
            this.CinemaRoomsetting.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.closeButtonPane);
            this.panel1.Controls.Add(this.CinemaRoomsetting);
            this.panel1.Controls.Add(this.CinemaRoomLabel);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 499);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // closeButtonPane
            // 
            this.closeButtonPane.Controls.Add(this.closeButtonIcon);
            this.closeButtonPane.Location = new System.Drawing.Point(998, 0);
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
            // CinemaRoomsetting
            // 
            this.CinemaRoomsetting.Controls.Add(this.GoReservation);
            this.CinemaRoomsetting.Controls.Add(this.AddressLabel);
            this.CinemaRoomsetting.Controls.Add(this.address);
            this.CinemaRoomsetting.Controls.Add(this.CityLabel);
            this.CinemaRoomsetting.Controls.Add(this.city);
            this.CinemaRoomsetting.Location = new System.Drawing.Point(182, 118);
            this.CinemaRoomsetting.Name = "CinemaRoomsetting";
            this.CinemaRoomsetting.Size = new System.Drawing.Size(549, 98);
            this.CinemaRoomsetting.TabIndex = 26;
            // 
            // GoReservation
            // 
            this.GoReservation.Location = new System.Drawing.Point(369, 39);
            this.GoReservation.Name = "GoReservation";
            this.GoReservation.Size = new System.Drawing.Size(153, 28);
            this.GoReservation.TabIndex = 29;
            this.GoReservation.Text = "좌석선택";
            this.GoReservation.UseVisualStyleBackColor = true;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AddressLabel.Location = new System.Drawing.Point(242, 15);
            this.AddressLabel.Margin = new System.Windows.Forms.Padding(115, 0, 3, 0);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(54, 21);
            this.AddressLabel.TabIndex = 28;
            this.AddressLabel.Text = "지역";
            // 
            // address
            // 
            this.address.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.address.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.address.FormattingEnabled = true;
            this.address.Location = new System.Drawing.Point(193, 39);
            this.address.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(153, 28);
            this.address.TabIndex = 27;
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CityLabel.Location = new System.Drawing.Point(60, 15);
            this.CityLabel.Margin = new System.Windows.Forms.Padding(60, 0, 3, 0);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(64, 21);
            this.CityLabel.TabIndex = 26;
            this.CityLabel.Text = "시/도";
            // 
            // city
            // 
            this.city.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.city.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.city.FormattingEnabled = true;
            this.city.Location = new System.Drawing.Point(17, 39);
            this.city.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(153, 28);
            this.city.TabIndex = 25;
            // 
            // CinemaRoomLabel
            // 
            this.CinemaRoomLabel.BackColor = System.Drawing.Color.Transparent;
            this.CinemaRoomLabel.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CinemaRoomLabel.Location = new System.Drawing.Point(-4, 0);
            this.CinemaRoomLabel.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.CinemaRoomLabel.Name = "CinemaRoomLabel";
            this.CinemaRoomLabel.Size = new System.Drawing.Size(176, 24);
            this.CinemaRoomLabel.TabIndex = 2;
            this.CinemaRoomLabel.Text = "상영관 선택";
            this.CinemaRoomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(859, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(40, 26);
            this.panel2.TabIndex = 33;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::SM_Movie.Properties.Resources.exit;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // cinemaRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "cinemaRoom";
            this.Size = new System.Drawing.Size(915, 505);
            this.panel1.ResumeLayout(false);
            this.closeButtonPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeButtonIcon)).EndInit();
            this.CinemaRoomsetting.ResumeLayout(false);
            this.CinemaRoomsetting.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CinemaRoomLabel;
        private System.Windows.Forms.Panel CinemaRoomsetting;
        private System.Windows.Forms.ComboBox city;
        private System.Windows.Forms.Button GoReservation;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.ComboBox address;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.Panel closeButtonPane;
        private System.Windows.Forms.PictureBox closeButtonIcon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
