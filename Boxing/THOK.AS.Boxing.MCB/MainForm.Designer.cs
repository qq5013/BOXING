namespace THOK.AS.Boxing
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlClient = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblCaption = new System.Windows.Forms.Label();
            this.splitter = new System.Windows.Forms.Splitter();
            this.taskPane = new XPExplorerBar.TaskPane();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlMain.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskPane)).BeginInit();
            this.pnlLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlClient
            // 
            this.pnlClient.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlClient.Location = new System.Drawing.Point(0, 25);
            this.pnlClient.Name = "pnlClient";
            this.pnlClient.Size = new System.Drawing.Size(543, 474);
            this.pnlClient.TabIndex = 1;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlClient);
            this.pnlMain.Controls.Add(this.pnlTitle);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(203, 73);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(543, 499);
            this.pnlMain.TabIndex = 7;
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTitle.BackgroundImage")));
            this.pnlTitle.Controls.Add(this.lblCaption);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(543, 25);
            this.pnlTitle.TabIndex = 0;
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.BackColor = System.Drawing.Color.Transparent;
            this.lblCaption.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCaption.Location = new System.Drawing.Point(7, 7);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(33, 12);
            this.lblCaption.TabIndex = 1;
            this.lblCaption.Text = "    ";
            // 
            // splitter
            // 
            this.splitter.BackColor = System.Drawing.SystemColors.Info;
            this.splitter.Location = new System.Drawing.Point(200, 73);
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(3, 499);
            this.splitter.TabIndex = 6;
            this.splitter.TabStop = false;
            // 
            // taskPane
            // 
            this.taskPane.AutoScrollMargin = new System.Drawing.Size(12, 12);
            this.taskPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskPane.Location = new System.Drawing.Point(0, 0);
            this.taskPane.Name = "taskPane";
            this.taskPane.Size = new System.Drawing.Size(200, 499);
            this.taskPane.TabIndex = 0;
            this.taskPane.Text = "taskPane1";
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.taskPane);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 73);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(200, 499);
            this.pnlLeft.TabIndex = 5;
            // 
            // pnlTop
            // 
            this.pnlTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(746, 73);
            this.pnlTop.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 572);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.splitter);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlTop);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "天海欧康整件打票系统";
            this.pnlMain.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskPane)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlClient;
        private System.Windows.Forms.Panel pnlTitle;
        protected System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Splitter splitter;
        private XPExplorerBar.TaskPane taskPane;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlTop;
    }
}