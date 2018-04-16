namespace SM_Movie
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.taskBar = new System.Windows.Forms.Panel();
            this.buttonFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.minButtonPane = new System.Windows.Forms.Panel();
            this.minButtonIcon = new System.Windows.Forms.PictureBox();
            this.recoverButtonPane = new System.Windows.Forms.Panel();
            this.recoverButtonIcon = new System.Windows.Forms.PictureBox();
            this.closeButtonPane = new System.Windows.Forms.Panel();
            this.closeButtonIcon = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.programIcon = new System.Windows.Forms.PictureBox();
            this.mainPane = new System.Windows.Forms.Panel();
            this.movieSearch1 = new SM_Movie.movieSearch();
            this.menuBarFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.homeMenuPane = new System.Windows.Forms.Panel();
            this.homeMenuLabel = new System.Windows.Forms.Label();
            this.homeMenuHighLight = new System.Windows.Forms.Panel();
            this.homeMenuIcon = new System.Windows.Forms.PictureBox();
            this.movieMenuPane = new System.Windows.Forms.Panel();
            this.movieMenuLabel = new System.Windows.Forms.Label();
            this.movieMenuHighLight = new System.Windows.Forms.Panel();
            this.movieMenuIcon = new System.Windows.Forms.PictureBox();
            this.menuTitle = new System.Windows.Forms.TableLayoutPanel();
            this.menuButtonPane = new System.Windows.Forms.Panel();
            this.menuButtonIcon = new System.Windows.Forms.PictureBox();
            this.commonUserMenuFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.userSettingPane = new System.Windows.Forms.Panel();
            this.userSettingIcon = new System.Windows.Forms.PictureBox();
            this.programSettingPane = new System.Windows.Forms.Panel();
            this.programSettingIcon = new System.Windows.Forms.PictureBox();
            this.mainPanel1 = new SM_Movie.MainPanel();
            this.taskBar.SuspendLayout();
            this.buttonFlow.SuspendLayout();
            this.minButtonPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minButtonIcon)).BeginInit();
            this.recoverButtonPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recoverButtonIcon)).BeginInit();
            this.closeButtonPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButtonIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programIcon)).BeginInit();
            this.mainPane.SuspendLayout();
            this.menuBarFlow.SuspendLayout();
            this.homeMenuPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homeMenuIcon)).BeginInit();
            this.movieMenuPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieMenuIcon)).BeginInit();
            this.menuButtonPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButtonIcon)).BeginInit();
            this.commonUserMenuFlow.SuspendLayout();
            this.userSettingPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userSettingIcon)).BeginInit();
            this.programSettingPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programSettingIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // taskBar
            // 
            this.taskBar.BackColor = System.Drawing.Color.Red;
            this.taskBar.Controls.Add(this.buttonFlow);
            this.taskBar.Controls.Add(this.title);
            this.taskBar.Controls.Add(this.programIcon);
            this.taskBar.Location = new System.Drawing.Point(2, 2);
            this.taskBar.Name = "taskBar";
            this.taskBar.Size = new System.Drawing.Size(963, 26);
            this.taskBar.TabIndex = 0;
            // 
            // buttonFlow
            // 
            this.buttonFlow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonFlow.Controls.Add(this.minButtonPane);
            this.buttonFlow.Controls.Add(this.recoverButtonPane);
            this.buttonFlow.Controls.Add(this.closeButtonPane);
            this.buttonFlow.Location = new System.Drawing.Point(842, 0);
            this.buttonFlow.Name = "buttonFlow";
            this.buttonFlow.Size = new System.Drawing.Size(120, 26);
            this.buttonFlow.TabIndex = 2;
            // 
            // minButtonPane
            // 
            this.minButtonPane.Controls.Add(this.minButtonIcon);
            this.minButtonPane.Location = new System.Drawing.Point(0, 0);
            this.minButtonPane.Margin = new System.Windows.Forms.Padding(0);
            this.minButtonPane.Name = "minButtonPane";
            this.minButtonPane.Size = new System.Drawing.Size(40, 26);
            this.minButtonPane.TabIndex = 0;
            // 
            // minButtonIcon
            // 
            this.minButtonIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minButtonIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minButtonIcon.Image = global::SM_Movie.Properties.Resources.minimize;
            this.minButtonIcon.Location = new System.Drawing.Point(0, 0);
            this.minButtonIcon.Margin = new System.Windows.Forms.Padding(0);
            this.minButtonIcon.Name = "minButtonIcon";
            this.minButtonIcon.Size = new System.Drawing.Size(40, 26);
            this.minButtonIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minButtonIcon.TabIndex = 1;
            this.minButtonIcon.TabStop = false;
            // 
            // recoverButtonPane
            // 
            this.recoverButtonPane.Controls.Add(this.recoverButtonIcon);
            this.recoverButtonPane.Location = new System.Drawing.Point(40, 0);
            this.recoverButtonPane.Margin = new System.Windows.Forms.Padding(0);
            this.recoverButtonPane.Name = "recoverButtonPane";
            this.recoverButtonPane.Size = new System.Drawing.Size(40, 26);
            this.recoverButtonPane.TabIndex = 2;
            // 
            // recoverButtonIcon
            // 
            this.recoverButtonIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.recoverButtonIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recoverButtonIcon.Image = global::SM_Movie.Properties.Resources.restore;
            this.recoverButtonIcon.Location = new System.Drawing.Point(0, 0);
            this.recoverButtonIcon.Margin = new System.Windows.Forms.Padding(0);
            this.recoverButtonIcon.Name = "recoverButtonIcon";
            this.recoverButtonIcon.Size = new System.Drawing.Size(40, 26);
            this.recoverButtonIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.recoverButtonIcon.TabIndex = 1;
            this.recoverButtonIcon.TabStop = false;
            // 
            // closeButtonPane
            // 
            this.closeButtonPane.Controls.Add(this.closeButtonIcon);
            this.closeButtonPane.Location = new System.Drawing.Point(80, 0);
            this.closeButtonPane.Margin = new System.Windows.Forms.Padding(0);
            this.closeButtonPane.Name = "closeButtonPane";
            this.closeButtonPane.Size = new System.Drawing.Size(40, 26);
            this.closeButtonPane.TabIndex = 2;
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
            // title
            // 
            this.title.Location = new System.Drawing.Point(39, 3);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(587, 23);
            this.title.TabIndex = 1;
            this.title.Text = "Main";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // programIcon
            // 
            this.programIcon.Image = global::SM_Movie.Properties.Resources.minimize;
            this.programIcon.Location = new System.Drawing.Point(10, 0);
            this.programIcon.Margin = new System.Windows.Forms.Padding(0);
            this.programIcon.Name = "programIcon";
            this.programIcon.Size = new System.Drawing.Size(26, 26);
            this.programIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.programIcon.TabIndex = 0;
            this.programIcon.TabStop = false;
            // 
            // mainPane
            // 
            this.mainPane.BackColor = System.Drawing.SystemColors.Control;
            this.mainPane.Controls.Add(this.mainPanel1);
            this.mainPane.Controls.Add(this.movieSearch1);
            this.mainPane.Controls.Add(this.menuBarFlow);
            this.mainPane.Controls.Add(this.menuTitle);
            this.mainPane.Controls.Add(this.menuButtonPane);
            this.mainPane.Controls.Add(this.commonUserMenuFlow);
            this.mainPane.Location = new System.Drawing.Point(2, 28);
            this.mainPane.Name = "mainPane";
            this.mainPane.Size = new System.Drawing.Size(963, 522);
            this.mainPane.TabIndex = 1;
            // 
            // movieSearch1
            // 
            this.movieSearch1.Location = new System.Drawing.Point(48, 48);
            this.movieSearch1.Margin = new System.Windows.Forms.Padding(0);
            this.movieSearch1.Name = "movieSearch1";
            this.movieSearch1.Size = new System.Drawing.Size(915, 474);
            this.movieSearch1.TabIndex = 4;
            this.movieSearch1.Visible = false;
            // 
            // menuBarFlow
            // 
            this.menuBarFlow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuBarFlow.Controls.Add(this.homeMenuPane);
            this.menuBarFlow.Controls.Add(this.movieMenuPane);
            this.menuBarFlow.Location = new System.Drawing.Point(0, 48);
            this.menuBarFlow.Margin = new System.Windows.Forms.Padding(0);
            this.menuBarFlow.Name = "menuBarFlow";
            this.menuBarFlow.Size = new System.Drawing.Size(48, 378);
            this.menuBarFlow.TabIndex = 0;
            // 
            // homeMenuPane
            // 
            this.homeMenuPane.Controls.Add(this.homeMenuLabel);
            this.homeMenuPane.Controls.Add(this.homeMenuHighLight);
            this.homeMenuPane.Controls.Add(this.homeMenuIcon);
            this.homeMenuPane.Location = new System.Drawing.Point(0, 0);
            this.homeMenuPane.Margin = new System.Windows.Forms.Padding(0);
            this.homeMenuPane.Name = "homeMenuPane";
            this.homeMenuPane.Size = new System.Drawing.Size(200, 48);
            this.homeMenuPane.TabIndex = 4;
            // 
            // homeMenuLabel
            // 
            this.homeMenuLabel.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.homeMenuLabel.ForeColor = System.Drawing.Color.White;
            this.homeMenuLabel.Location = new System.Drawing.Point(60, 0);
            this.homeMenuLabel.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.homeMenuLabel.Name = "homeMenuLabel";
            this.homeMenuLabel.Size = new System.Drawing.Size(139, 48);
            this.homeMenuLabel.TabIndex = 9;
            this.homeMenuLabel.Text = "홈";
            this.homeMenuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // homeMenuHighLight
            // 
            this.homeMenuHighLight.BackColor = System.Drawing.Color.Red;
            this.homeMenuHighLight.Location = new System.Drawing.Point(2, 0);
            this.homeMenuHighLight.Margin = new System.Windows.Forms.Padding(0);
            this.homeMenuHighLight.Name = "homeMenuHighLight";
            this.homeMenuHighLight.Size = new System.Drawing.Size(10, 48);
            this.homeMenuHighLight.TabIndex = 10;
            // 
            // homeMenuIcon
            // 
            this.homeMenuIcon.Image = global::SM_Movie.Properties.Resources.home;
            this.homeMenuIcon.Location = new System.Drawing.Point(2, 0);
            this.homeMenuIcon.Margin = new System.Windows.Forms.Padding(0);
            this.homeMenuIcon.Name = "homeMenuIcon";
            this.homeMenuIcon.Size = new System.Drawing.Size(48, 48);
            this.homeMenuIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.homeMenuIcon.TabIndex = 11;
            this.homeMenuIcon.TabStop = false;
            // 
            // movieMenuPane
            // 
            this.movieMenuPane.Controls.Add(this.movieMenuLabel);
            this.movieMenuPane.Controls.Add(this.movieMenuHighLight);
            this.movieMenuPane.Controls.Add(this.movieMenuIcon);
            this.movieMenuPane.Location = new System.Drawing.Point(0, 48);
            this.movieMenuPane.Margin = new System.Windows.Forms.Padding(0);
            this.movieMenuPane.Name = "movieMenuPane";
            this.movieMenuPane.Size = new System.Drawing.Size(200, 48);
            this.movieMenuPane.TabIndex = 12;
            // 
            // movieMenuLabel
            // 
            this.movieMenuLabel.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.movieMenuLabel.ForeColor = System.Drawing.Color.White;
            this.movieMenuLabel.Location = new System.Drawing.Point(60, 0);
            this.movieMenuLabel.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.movieMenuLabel.Name = "movieMenuLabel";
            this.movieMenuLabel.Size = new System.Drawing.Size(139, 48);
            this.movieMenuLabel.TabIndex = 9;
            this.movieMenuLabel.Text = "영화";
            this.movieMenuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // movieMenuHighLight
            // 
            this.movieMenuHighLight.BackColor = System.Drawing.Color.Transparent;
            this.movieMenuHighLight.Location = new System.Drawing.Point(2, 0);
            this.movieMenuHighLight.Margin = new System.Windows.Forms.Padding(0);
            this.movieMenuHighLight.Name = "movieMenuHighLight";
            this.movieMenuHighLight.Size = new System.Drawing.Size(10, 48);
            this.movieMenuHighLight.TabIndex = 10;
            // 
            // movieMenuIcon
            // 
            this.movieMenuIcon.Image = global::SM_Movie.Properties.Resources.movie;
            this.movieMenuIcon.Location = new System.Drawing.Point(2, 0);
            this.movieMenuIcon.Margin = new System.Windows.Forms.Padding(0);
            this.movieMenuIcon.Name = "movieMenuIcon";
            this.movieMenuIcon.Size = new System.Drawing.Size(48, 48);
            this.movieMenuIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.movieMenuIcon.TabIndex = 11;
            this.movieMenuIcon.TabStop = false;
            // 
            // menuTitle
            // 
            this.menuTitle.BackColor = System.Drawing.Color.White;
            this.menuTitle.ColumnCount = 1;
            this.menuTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.menuTitle.Location = new System.Drawing.Point(48, 0);
            this.menuTitle.Margin = new System.Windows.Forms.Padding(0);
            this.menuTitle.Name = "menuTitle";
            this.menuTitle.RowCount = 1;
            this.menuTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.menuTitle.Size = new System.Drawing.Size(914, 48);
            this.menuTitle.TabIndex = 2;
            // 
            // menuButtonPane
            // 
            this.menuButtonPane.BackColor = System.Drawing.Color.Red;
            this.menuButtonPane.Controls.Add(this.menuButtonIcon);
            this.menuButtonPane.Location = new System.Drawing.Point(0, 0);
            this.menuButtonPane.Margin = new System.Windows.Forms.Padding(0);
            this.menuButtonPane.Name = "menuButtonPane";
            this.menuButtonPane.Size = new System.Drawing.Size(48, 48);
            this.menuButtonPane.TabIndex = 3;
            // 
            // menuButtonIcon
            // 
            this.menuButtonIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButtonIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuButtonIcon.Image = global::SM_Movie.Properties.Resources.menu;
            this.menuButtonIcon.Location = new System.Drawing.Point(0, 0);
            this.menuButtonIcon.Margin = new System.Windows.Forms.Padding(0);
            this.menuButtonIcon.Name = "menuButtonIcon";
            this.menuButtonIcon.Size = new System.Drawing.Size(48, 48);
            this.menuButtonIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menuButtonIcon.TabIndex = 5;
            this.menuButtonIcon.TabStop = false;
            // 
            // commonUserMenuFlow
            // 
            this.commonUserMenuFlow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.commonUserMenuFlow.Controls.Add(this.userSettingPane);
            this.commonUserMenuFlow.Controls.Add(this.programSettingPane);
            this.commonUserMenuFlow.Location = new System.Drawing.Point(0, 426);
            this.commonUserMenuFlow.Margin = new System.Windows.Forms.Padding(0);
            this.commonUserMenuFlow.Name = "commonUserMenuFlow";
            this.commonUserMenuFlow.Size = new System.Drawing.Size(48, 96);
            this.commonUserMenuFlow.TabIndex = 1;
            // 
            // userSettingPane
            // 
            this.userSettingPane.BackColor = System.Drawing.Color.Transparent;
            this.userSettingPane.Controls.Add(this.userSettingIcon);
            this.userSettingPane.Location = new System.Drawing.Point(0, 0);
            this.userSettingPane.Margin = new System.Windows.Forms.Padding(0);
            this.userSettingPane.Name = "userSettingPane";
            this.userSettingPane.Size = new System.Drawing.Size(48, 48);
            this.userSettingPane.TabIndex = 4;
            // 
            // userSettingIcon
            // 
            this.userSettingIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userSettingIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userSettingIcon.Image = global::SM_Movie.Properties.Resources.user;
            this.userSettingIcon.Location = new System.Drawing.Point(0, 0);
            this.userSettingIcon.Margin = new System.Windows.Forms.Padding(0);
            this.userSettingIcon.Name = "userSettingIcon";
            this.userSettingIcon.Size = new System.Drawing.Size(48, 48);
            this.userSettingIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userSettingIcon.TabIndex = 5;
            this.userSettingIcon.TabStop = false;
            this.userSettingIcon.Click += new System.EventHandler(this.userSettingIcon_Click);
            // 
            // programSettingPane
            // 
            this.programSettingPane.Controls.Add(this.programSettingIcon);
            this.programSettingPane.Location = new System.Drawing.Point(0, 48);
            this.programSettingPane.Margin = new System.Windows.Forms.Padding(0);
            this.programSettingPane.Name = "programSettingPane";
            this.programSettingPane.Size = new System.Drawing.Size(48, 48);
            this.programSettingPane.TabIndex = 6;
            // 
            // programSettingIcon
            // 
            this.programSettingIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.programSettingIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.programSettingIcon.Image = global::SM_Movie.Properties.Resources.setting;
            this.programSettingIcon.Location = new System.Drawing.Point(0, 0);
            this.programSettingIcon.Margin = new System.Windows.Forms.Padding(0);
            this.programSettingIcon.Name = "programSettingIcon";
            this.programSettingIcon.Size = new System.Drawing.Size(48, 48);
            this.programSettingIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.programSettingIcon.TabIndex = 5;
            this.programSettingIcon.TabStop = false;
            this.programSettingIcon.Click += new System.EventHandler(this.programSettingIcon_Click);
            // 
            // mainPanel1
            // 
            this.mainPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.mainPanel1.Location = new System.Drawing.Point(48, 48);
            this.mainPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.mainPanel1.Name = "mainPanel1";
            this.mainPanel1.Size = new System.Drawing.Size(915, 474);
            this.mainPanel1.TabIndex = 5;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(967, 552);
            this.Controls.Add(this.mainPane);
            this.Controls.Add(this.taskBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.taskBar.ResumeLayout(false);
            this.buttonFlow.ResumeLayout(false);
            this.minButtonPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minButtonIcon)).EndInit();
            this.recoverButtonPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.recoverButtonIcon)).EndInit();
            this.closeButtonPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeButtonIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programIcon)).EndInit();
            this.mainPane.ResumeLayout(false);
            this.menuBarFlow.ResumeLayout(false);
            this.homeMenuPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.homeMenuIcon)).EndInit();
            this.movieMenuPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.movieMenuIcon)).EndInit();
            this.menuButtonPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menuButtonIcon)).EndInit();
            this.commonUserMenuFlow.ResumeLayout(false);
            this.userSettingPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userSettingIcon)).EndInit();
            this.programSettingPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.programSettingIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel taskBar;
        private System.Windows.Forms.PictureBox programIcon;
        private System.Windows.Forms.Panel mainPane;
        private System.Windows.Forms.FlowLayoutPanel buttonFlow;
        private System.Windows.Forms.Panel minButtonPane;
        private System.Windows.Forms.PictureBox minButtonIcon;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel recoverButtonPane;
        private System.Windows.Forms.PictureBox recoverButtonIcon;
        private System.Windows.Forms.Panel closeButtonPane;
        private System.Windows.Forms.PictureBox closeButtonIcon;
        private System.Windows.Forms.Panel menuButtonPane;
        private System.Windows.Forms.TableLayoutPanel menuTitle;
        private System.Windows.Forms.PictureBox menuButtonIcon;
        private System.Windows.Forms.FlowLayoutPanel menuBarFlow;
        private System.Windows.Forms.Panel homeMenuPane;
        private System.Windows.Forms.Label homeMenuLabel;
        private System.Windows.Forms.Panel homeMenuHighLight;
        private System.Windows.Forms.PictureBox homeMenuIcon;
        private System.Windows.Forms.Panel movieMenuPane;
        private System.Windows.Forms.Label movieMenuLabel;
        private System.Windows.Forms.Panel movieMenuHighLight;
        private System.Windows.Forms.PictureBox movieMenuIcon;
        private System.Windows.Forms.FlowLayoutPanel commonUserMenuFlow;
        private System.Windows.Forms.Panel userSettingPane;
        private System.Windows.Forms.PictureBox userSettingIcon;
        private System.Windows.Forms.Panel programSettingPane;
        private System.Windows.Forms.PictureBox programSettingIcon;
        private movieSearch movieSearch1;
        private MainPanel mainPanel1;
    }
}