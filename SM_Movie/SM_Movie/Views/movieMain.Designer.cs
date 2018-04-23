namespace SM_Movie.Views
{
    partial class movieMain
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.movieCollectionPanel = new System.Windows.Forms.Panel();
            this.movieCollectionTitle = new System.Windows.Forms.Label();
            this.movieCollectionFlowBack = new System.Windows.Forms.Panel();
            this.movieCollectionFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.movieCollectionPanel.SuspendLayout();
            this.movieCollectionFlowBack.SuspendLayout();
            this.movieCollectionFlow.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.movieCollectionPanel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(738, 637);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // movieCollectionPanel
            // 
            this.movieCollectionPanel.Controls.Add(this.movieCollectionFlowBack);
            this.movieCollectionPanel.Controls.Add(this.movieCollectionTitle);
            this.movieCollectionPanel.Location = new System.Drawing.Point(0, 0);
            this.movieCollectionPanel.Margin = new System.Windows.Forms.Padding(0);
            this.movieCollectionPanel.Name = "movieCollectionPanel";
            this.movieCollectionPanel.Size = new System.Drawing.Size(738, 377);
            this.movieCollectionPanel.TabIndex = 1;
            // 
            // movieCollectionTitle
            // 
            this.movieCollectionTitle.AutoSize = true;
            this.movieCollectionTitle.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.movieCollectionTitle.Location = new System.Drawing.Point(3, 12);
            this.movieCollectionTitle.Name = "movieCollectionTitle";
            this.movieCollectionTitle.Size = new System.Drawing.Size(211, 40);
            this.movieCollectionTitle.TabIndex = 0;
            this.movieCollectionTitle.Text = "요즘 뜨는 영화";
            // 
            // movieCollectionFlowBack
            // 
            this.movieCollectionFlowBack.AutoScroll = true;
            this.movieCollectionFlowBack.Controls.Add(this.movieCollectionFlow);
            this.movieCollectionFlowBack.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.movieCollectionFlowBack.Location = new System.Drawing.Point(0, 65);
            this.movieCollectionFlowBack.Margin = new System.Windows.Forms.Padding(0);
            this.movieCollectionFlowBack.Name = "movieCollectionFlowBack";
            this.movieCollectionFlowBack.Size = new System.Drawing.Size(738, 312);
            this.movieCollectionFlowBack.TabIndex = 3;
            // 
            // movieCollectionFlow
            // 
            this.movieCollectionFlow.AutoSize = true;
            this.movieCollectionFlow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.movieCollectionFlow.BackColor = System.Drawing.Color.Transparent;
            this.movieCollectionFlow.Controls.Add(this.panel2);
            this.movieCollectionFlow.Location = new System.Drawing.Point(0, 0);
            this.movieCollectionFlow.Margin = new System.Windows.Forms.Padding(0);
            this.movieCollectionFlow.Name = "movieCollectionFlow";
            this.movieCollectionFlow.Size = new System.Drawing.Size(210, 295);
            this.movieCollectionFlow.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(20, 20);
            this.panel2.Margin = new System.Windows.Forms.Padding(20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 255);
            this.panel2.TabIndex = 3;
            // 
            // movieMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "movieMain";
            this.Size = new System.Drawing.Size(738, 637);
            this.Resize += new System.EventHandler(this.movieMain_Resize);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.movieCollectionPanel.ResumeLayout(false);
            this.movieCollectionPanel.PerformLayout();
            this.movieCollectionFlowBack.ResumeLayout(false);
            this.movieCollectionFlowBack.PerformLayout();
            this.movieCollectionFlow.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel movieCollectionPanel;
        private System.Windows.Forms.Label movieCollectionTitle;
        private System.Windows.Forms.Panel movieCollectionFlowBack;
        private System.Windows.Forms.FlowLayoutPanel movieCollectionFlow;
        private System.Windows.Forms.Panel panel2;
    }
}
