namespace DeployMaker
{
	partial class fmMain
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

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMain));
			this.splitContainerMain = new System.Windows.Forms.SplitContainer();
			this.lblLog = new System.Windows.Forms.Label();
			this.btnClearLog = new System.Windows.Forms.Button();
			this.btnStart = new System.Windows.Forms.Button();
			this.gbConfig = new System.Windows.Forms.GroupBox();
			this.btnTargetPathOpen = new System.Windows.Forms.Button();
			this.btnBasePathOpen = new System.Windows.Forms.Button();
			this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.flowLayoutPanelExt = new System.Windows.Forms.FlowLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.txtTargetPath = new System.Windows.Forms.TextBox();
			this.btnTargetPath = new System.Windows.Forms.Button();
			this.txtOrgPath = new System.Windows.Forms.TextBox();
			this.btnOrgPath = new System.Windows.Forms.Button();
			this.rtbLog = new System.Windows.Forms.RichTextBox();
			this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.tspbProgress = new System.Windows.Forms.ToolStripProgressBar();
			this.tsslResult = new System.Windows.Forms.ToolStripStatusLabel();
			this.label3 = new System.Windows.Forms.Label();
			this.flowLayoutPanelFolder = new System.Windows.Forms.FlowLayoutPanel();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
			this.splitContainerMain.Panel1.SuspendLayout();
			this.splitContainerMain.Panel2.SuspendLayout();
			this.splitContainerMain.SuspendLayout();
			this.gbConfig.SuspendLayout();
			this.statusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainerMain
			// 
			this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
			this.splitContainerMain.Name = "splitContainerMain";
			this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainerMain.Panel1
			// 
			this.splitContainerMain.Panel1.Controls.Add(this.lblLog);
			this.splitContainerMain.Panel1.Controls.Add(this.btnClearLog);
			this.splitContainerMain.Panel1.Controls.Add(this.btnStart);
			this.splitContainerMain.Panel1.Controls.Add(this.gbConfig);
			this.splitContainerMain.Panel1.Padding = new System.Windows.Forms.Padding(10, 10, 10, 40);
			this.splitContainerMain.Panel1MinSize = 300;
			// 
			// splitContainerMain.Panel2
			// 
			this.splitContainerMain.Panel2.Controls.Add(this.rtbLog);
			this.splitContainerMain.Panel2.Padding = new System.Windows.Forms.Padding(10);
			this.splitContainerMain.Size = new System.Drawing.Size(897, 661);
			this.splitContainerMain.SplitterDistance = 300;
			this.splitContainerMain.TabIndex = 0;
			// 
			// lblLog
			// 
			this.lblLog.AutoSize = true;
			this.lblLog.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lblLog.Location = new System.Drawing.Point(13, 272);
			this.lblLog.Name = "lblLog";
			this.lblLog.Size = new System.Drawing.Size(38, 14);
			this.lblLog.TabIndex = 3;
			this.lblLog.Text = "label3";
			// 
			// btnClearLog
			// 
			this.btnClearLog.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnClearLog.Location = new System.Drawing.Point(731, 266);
			this.btnClearLog.Name = "btnClearLog";
			this.btnClearLog.Size = new System.Drawing.Size(75, 23);
			this.btnClearLog.TabIndex = 2;
			this.btnClearLog.Text = "Clear Log";
			this.btnClearLog.UseVisualStyleBackColor = true;
			this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
			// 
			// btnStart
			// 
			this.btnStart.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnStart.Location = new System.Drawing.Point(812, 266);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 23);
			this.btnStart.TabIndex = 1;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// gbConfig
			// 
			this.gbConfig.Controls.Add(this.flowLayoutPanelFolder);
			this.gbConfig.Controls.Add(this.label3);
			this.gbConfig.Controls.Add(this.btnTargetPathOpen);
			this.gbConfig.Controls.Add(this.btnBasePathOpen);
			this.gbConfig.Controls.Add(this.dateTimePicker);
			this.gbConfig.Controls.Add(this.label2);
			this.gbConfig.Controls.Add(this.flowLayoutPanelExt);
			this.gbConfig.Controls.Add(this.label1);
			this.gbConfig.Controls.Add(this.txtTargetPath);
			this.gbConfig.Controls.Add(this.btnTargetPath);
			this.gbConfig.Controls.Add(this.txtOrgPath);
			this.gbConfig.Controls.Add(this.btnOrgPath);
			this.gbConfig.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbConfig.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.gbConfig.Location = new System.Drawing.Point(10, 10);
			this.gbConfig.Name = "gbConfig";
			this.gbConfig.Size = new System.Drawing.Size(877, 250);
			this.gbConfig.TabIndex = 0;
			this.gbConfig.TabStop = false;
			this.gbConfig.Text = "Configuration";
			// 
			// btnTargetPathOpen
			// 
			this.btnTargetPathOpen.Location = new System.Drawing.Point(840, 47);
			this.btnTargetPathOpen.Name = "btnTargetPathOpen";
			this.btnTargetPathOpen.Size = new System.Drawing.Size(28, 23);
			this.btnTargetPathOpen.TabIndex = 9;
			this.btnTargetPathOpen.Text = "...";
			this.btnTargetPathOpen.UseVisualStyleBackColor = true;
			this.btnTargetPathOpen.Click += new System.EventHandler(this.btnTargetPathOpen_Click);
			// 
			// btnBasePathOpen
			// 
			this.btnBasePathOpen.Location = new System.Drawing.Point(840, 20);
			this.btnBasePathOpen.Name = "btnBasePathOpen";
			this.btnBasePathOpen.Size = new System.Drawing.Size(28, 23);
			this.btnBasePathOpen.TabIndex = 8;
			this.btnBasePathOpen.Text = "...";
			this.btnBasePathOpen.UseVisualStyleBackColor = true;
			this.btnBasePathOpen.Click += new System.EventHandler(this.btnBasePathOpen_Click);
			// 
			// dateTimePicker
			// 
			this.dateTimePicker.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.dateTimePicker.Location = new System.Drawing.Point(122, 217);
			this.dateTimePicker.Name = "dateTimePicker";
			this.dateTimePicker.Size = new System.Drawing.Size(188, 21);
			this.dateTimePicker.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(18, 217);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 14);
			this.label2.TabIndex = 6;
			this.label2.Text = "UpdateDate";
			// 
			// flowLayoutPanelExt
			// 
			this.flowLayoutPanelExt.Location = new System.Drawing.Point(122, 80);
			this.flowLayoutPanelExt.Name = "flowLayoutPanelExt";
			this.flowLayoutPanelExt.Size = new System.Drawing.Size(319, 124);
			this.flowLayoutPanelExt.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(18, 84);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(81, 14);
			this.label1.TabIndex = 4;
			this.label1.Text = "File Extension";
			// 
			// txtTargetPath
			// 
			this.txtTargetPath.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTargetPath.Location = new System.Drawing.Point(122, 48);
			this.txtTargetPath.Name = "txtTargetPath";
			this.txtTargetPath.Size = new System.Drawing.Size(712, 22);
			this.txtTargetPath.TabIndex = 3;
			// 
			// btnTargetPath
			// 
			this.btnTargetPath.Location = new System.Drawing.Point(12, 47);
			this.btnTargetPath.Name = "btnTargetPath";
			this.btnTargetPath.Size = new System.Drawing.Size(87, 23);
			this.btnTargetPath.TabIndex = 2;
			this.btnTargetPath.Text = "Target Path";
			this.btnTargetPath.UseVisualStyleBackColor = true;
			this.btnTargetPath.Click += new System.EventHandler(this.btnTargetPath_Click);
			// 
			// txtOrgPath
			// 
			this.txtOrgPath.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtOrgPath.Location = new System.Drawing.Point(122, 21);
			this.txtOrgPath.Name = "txtOrgPath";
			this.txtOrgPath.Size = new System.Drawing.Size(712, 22);
			this.txtOrgPath.TabIndex = 1;
			// 
			// btnOrgPath
			// 
			this.btnOrgPath.Location = new System.Drawing.Point(12, 20);
			this.btnOrgPath.Name = "btnOrgPath";
			this.btnOrgPath.Size = new System.Drawing.Size(87, 23);
			this.btnOrgPath.TabIndex = 0;
			this.btnOrgPath.Text = "Base Path";
			this.btnOrgPath.UseVisualStyleBackColor = true;
			this.btnOrgPath.Click += new System.EventHandler(this.btnOrgPath_Click);
			// 
			// rtbLog
			// 
			this.rtbLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rtbLog.DetectUrls = false;
			this.rtbLog.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtbLog.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.rtbLog.ForeColor = System.Drawing.Color.Gainsboro;
			this.rtbLog.Location = new System.Drawing.Point(10, 10);
			this.rtbLog.Name = "rtbLog";
			this.rtbLog.ReadOnly = true;
			this.rtbLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.rtbLog.Size = new System.Drawing.Size(877, 337);
			this.rtbLog.TabIndex = 0;
			this.rtbLog.Text = "";
			// 
			// folderBrowserDialog
			// 
			this.folderBrowserDialog.SelectedPath = "C:\\work\\SVN\\repos-infradev\\trunk\\Solutions";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(51, 17);
			this.toolStripStatusLabel1.Text = "Status : ";
			// 
			// tsslStatus
			// 
			this.tsslStatus.Name = "tsslStatus";
			this.tsslStatus.Size = new System.Drawing.Size(39, 17);
			this.tsslStatus.Text = "Ready";
			// 
			// statusStrip
			// 
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsslStatus,
            this.tspbProgress,
            this.tsslResult});
			this.statusStrip.Location = new System.Drawing.Point(0, 639);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(897, 22);
			this.statusStrip.TabIndex = 1;
			this.statusStrip.Text = "statusStrip1";
			// 
			// tspbProgress
			// 
			this.tspbProgress.Name = "tspbProgress";
			this.tspbProgress.Size = new System.Drawing.Size(100, 16);
			this.tspbProgress.Step = 1;
			this.tspbProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			// 
			// tsslResult
			// 
			this.tsslResult.Name = "tsslResult";
			this.tsslResult.Size = new System.Drawing.Size(0, 17);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(473, 84);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(99, 14);
			this.label3.TabIndex = 10;
			this.label3.Text = "Except by Folder";
			// 
			// flowLayoutPanelFolder
			// 
			this.flowLayoutPanelFolder.Location = new System.Drawing.Point(578, 80);
			this.flowLayoutPanelFolder.Name = "flowLayoutPanelFolder";
			this.flowLayoutPanelFolder.Size = new System.Drawing.Size(256, 124);
			this.flowLayoutPanelFolder.TabIndex = 6;
			// 
			// fmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(897, 661);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.splitContainerMain);
			this.HelpButton = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(913, 700);
			this.MinimumSize = new System.Drawing.Size(913, 700);
			this.Name = "fmMain";
			this.Text = "DeployMaker";
			this.Load += new System.EventHandler(this.fmMain_Load);
			this.splitContainerMain.Panel1.ResumeLayout(false);
			this.splitContainerMain.Panel1.PerformLayout();
			this.splitContainerMain.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
			this.splitContainerMain.ResumeLayout(false);
			this.gbConfig.ResumeLayout(false);
			this.gbConfig.PerformLayout();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainerMain;
		private System.Windows.Forms.GroupBox gbConfig;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtTargetPath;
		private System.Windows.Forms.Button btnTargetPath;
		private System.Windows.Forms.TextBox txtOrgPath;
		private System.Windows.Forms.Button btnOrgPath;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelExt;
		private System.Windows.Forms.DateTimePicker dateTimePicker;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripStatusLabel tsslStatus;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.Button btnTargetPathOpen;
		private System.Windows.Forms.Button btnBasePathOpen;
		private System.Windows.Forms.RichTextBox rtbLog;
		private System.Windows.Forms.Button btnClearLog;
		private System.Windows.Forms.ToolStripProgressBar tspbProgress;
		private System.Windows.Forms.Label lblLog;
		private System.Windows.Forms.ToolStripStatusLabel tsslResult;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelFolder;
		private System.Windows.Forms.Label label3;
	}
}

