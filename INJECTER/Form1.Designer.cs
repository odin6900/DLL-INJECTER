namespace INJECTER
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panelHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelSubtitle = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2CircleButton();
            this.panelBase = new Guna.UI2.WinForms.Guna2Panel();
            this.panelLeft = new Guna.UI2.WinForms.Guna2Panel();
            this.labelProcessSect = new System.Windows.Forms.Label();
            this.cardProcess = new Guna.UI2.WinForms.Guna2Panel();
            this.labelProcessName = new System.Windows.Forms.Label();
            this.ProcessName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSetProcess = new Guna.UI2.WinForms.Guna2Button();
            this.labelDllSect = new System.Windows.Forms.Label();
            this.cardDll = new Guna.UI2.WinForms.Guna2Panel();
            this.listBoxDLLs = new System.Windows.Forms.ListBox();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.btnBrowse = new Guna.UI2.WinForms.Guna2Button();
            this.panelRight = new Guna.UI2.WinForms.Guna2Panel();
            this.labelLogSect = new System.Windows.Forms.Label();
            this.cardLog = new Guna.UI2.WinForms.Guna2Panel();
            this.Sta = new System.Windows.Forms.RichTextBox();
            this.btnClearLogs = new Guna.UI2.WinForms.Guna2Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.btnInject = new Guna.UI2.WinForms.Guna2Button();
            this.panelHeader.SuspendLayout();
            this.panelBase.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.cardProcess.SuspendLayout();
            this.cardDll.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.cardLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // dragControl
            // 
            this.dragControl.DockIndicatorTransparencyValue = 1D;
            this.dragControl.DragStartTransparencyValue = 1D;
            this.dragControl.TargetControl = this.panelHeader;
            this.dragControl.TransparentWhileDrag = false;
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.labelTitle);
            this.panelHeader.Controls.Add(this.labelSubtitle);
            this.panelHeader.Controls.Add(this.btnClose);
            this.panelHeader.Controls.Add(this.btnMinimize);
            this.panelHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(202)))), ((int)(((byte)(177)))));
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(820, 60);
            this.panelHeader.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(18, 7);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(360, 28);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "⚡  DLL INJECTOR";
            // 
            // labelSubtitle
            // 
            this.labelSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.labelSubtitle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labelSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelSubtitle.Location = new System.Drawing.Point(20, 36);
            this.labelSubtitle.Name = "labelSubtitle";
            this.labelSubtitle.Size = new System.Drawing.Size(300, 16);
            this.labelSubtitle.TabIndex = 1;
            this.labelSubtitle.Text = "PREMIUM INJECTION TOOL  •  v2.0";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(784, 19);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(22, 22);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "✕";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(150)))), ((int)(((byte)(20)))));
            this.btnMinimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(50)))));
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.btnMinimize.Location = new System.Drawing.Point(756, 19);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(22, 22);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.Text = "─";
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // panelBase
            // 
            this.panelBase.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(202)))), ((int)(((byte)(177)))));
            this.panelBase.BorderRadius = 10;
            this.panelBase.BorderThickness = 2;
            this.panelBase.Controls.Add(this.panelHeader);
            this.panelBase.Controls.Add(this.panelLeft);
            this.panelBase.Controls.Add(this.panelRight);
            this.panelBase.Controls.Add(this.btnInject);
            this.panelBase.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(208)))));
            this.panelBase.Location = new System.Drawing.Point(0, 0);
            this.panelBase.Name = "panelBase";
            this.panelBase.Size = new System.Drawing.Size(820, 554);
            this.panelBase.TabIndex = 0;
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.labelProcessSect);
            this.panelLeft.Controls.Add(this.cardProcess);
            this.panelLeft.Controls.Add(this.labelDllSect);
            this.panelLeft.Controls.Add(this.cardDll);
            this.panelLeft.Controls.Add(this.btnRefresh);
            this.panelLeft.Controls.Add(this.btnBrowse);
            this.panelLeft.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(208)))));
            this.panelLeft.Location = new System.Drawing.Point(0, 60);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(410, 446);
            this.panelLeft.TabIndex = 1;
            // 
            // labelProcessSect
            // 
            this.labelProcessSect.BackColor = System.Drawing.Color.Transparent;
            this.labelProcessSect.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.labelProcessSect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(202)))), ((int)(((byte)(177)))));
            this.labelProcessSect.Location = new System.Drawing.Point(16, 14);
            this.labelProcessSect.Name = "labelProcessSect";
            this.labelProcessSect.Size = new System.Drawing.Size(200, 15);
            this.labelProcessSect.TabIndex = 0;
            this.labelProcessSect.Text = "TARGET PROCESS";
            // 
            // cardProcess
            // 
            this.cardProcess.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(202)))), ((int)(((byte)(177)))));
            this.cardProcess.BorderRadius = 8;
            this.cardProcess.BorderThickness = 1;
            this.cardProcess.Controls.Add(this.labelProcessName);
            this.cardProcess.Controls.Add(this.ProcessName);
            this.cardProcess.Controls.Add(this.btnSetProcess);
            this.cardProcess.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(231)))), ((int)(((byte)(185)))));
            this.cardProcess.Location = new System.Drawing.Point(16, 32);
            this.cardProcess.Name = "cardProcess";
            this.cardProcess.Size = new System.Drawing.Size(382, 54);
            this.cardProcess.TabIndex = 1;
            // 
            // labelProcessName
            // 
            this.labelProcessName.BackColor = System.Drawing.Color.Transparent;
            this.labelProcessName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelProcessName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.labelProcessName.Location = new System.Drawing.Point(10, 17);
            this.labelProcessName.Name = "labelProcessName";
            this.labelProcessName.Size = new System.Drawing.Size(58, 18);
            this.labelProcessName.TabIndex = 0;
            this.labelProcessName.Text = "Process:";
            // 
            // ProcessName
            // 
            this.ProcessName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(202)))), ((int)(((byte)(177)))));
            this.ProcessName.BorderRadius = 6;
            this.ProcessName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProcessName.DefaultText = "HD-Player";
            this.ProcessName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(208)))));
            this.ProcessName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ProcessName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(55)))));
            this.ProcessName.Location = new System.Drawing.Point(72, 12);
            this.ProcessName.Name = "ProcessName";
            this.ProcessName.PlaceholderText = "e.g. HD-Player";
            this.ProcessName.SelectedText = "";
            this.ProcessName.Size = new System.Drawing.Size(188, 32);
            this.ProcessName.TabIndex = 1;
            // 
            // btnSetProcess
            // 
            this.btnSetProcess.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(202)))), ((int)(((byte)(177)))));
            this.btnSetProcess.BorderRadius = 6;
            this.btnSetProcess.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(231)))), ((int)(((byte)(210)))));
            this.btnSetProcess.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSetProcess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(55)))));
            this.btnSetProcess.Location = new System.Drawing.Point(270, 11);
            this.btnSetProcess.Name = "btnSetProcess";
            this.btnSetProcess.Size = new System.Drawing.Size(103, 32);
            this.btnSetProcess.TabIndex = 2;
            this.btnSetProcess.Text = "Set Process";
            this.btnSetProcess.Click += new System.EventHandler(this.btnSetProcess_Click);
            // 
            // labelDllSect
            // 
            this.labelDllSect.BackColor = System.Drawing.Color.Transparent;
            this.labelDllSect.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.labelDllSect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(202)))), ((int)(((byte)(177)))));
            this.labelDllSect.Location = new System.Drawing.Point(16, 98);
            this.labelDllSect.Name = "labelDllSect";
            this.labelDllSect.Size = new System.Drawing.Size(200, 15);
            this.labelDllSect.TabIndex = 2;
            this.labelDllSect.Text = "AVAILABLE DLLs";
            // 
            // cardDll
            // 
            this.cardDll.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(202)))), ((int)(((byte)(177)))));
            this.cardDll.BorderRadius = 8;
            this.cardDll.BorderThickness = 1;
            this.cardDll.Controls.Add(this.listBoxDLLs);
            this.cardDll.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(231)))), ((int)(((byte)(185)))));
            this.cardDll.Location = new System.Drawing.Point(16, 116);
            this.cardDll.Name = "cardDll";
            this.cardDll.Size = new System.Drawing.Size(382, 264);
            this.cardDll.TabIndex = 3;
            // 
            // listBoxDLLs
            // 
            this.listBoxDLLs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(208)))));
            this.listBoxDLLs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxDLLs.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.listBoxDLLs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(55)))));
            this.listBoxDLLs.ItemHeight = 15;
            this.listBoxDLLs.Location = new System.Drawing.Point(6, 6);
            this.listBoxDLLs.Name = "listBoxDLLs";
            this.listBoxDLLs.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxDLLs.Size = new System.Drawing.Size(370, 240);
            this.listBoxDLLs.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(231)))), ((int)(((byte)(210)))));
            this.btnRefresh.BorderRadius = 8;
            this.btnRefresh.BorderThickness = 1;
            this.btnRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(231)))), ((int)(((byte)(185)))));
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.btnRefresh.Location = new System.Drawing.Point(16, 392);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(125, 36);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "⟳  Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(202)))), ((int)(((byte)(177)))));
            this.btnBrowse.BorderRadius = 8;
            this.btnBrowse.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(231)))), ((int)(((byte)(210)))));
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBrowse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(55)))));
            this.btnBrowse.Location = new System.Drawing.Point(152, 392);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(125, 36);
            this.btnBrowse.TabIndex = 5;
            this.btnBrowse.Text = "📁  Browse";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.labelLogSect);
            this.panelRight.Controls.Add(this.cardLog);
            this.panelRight.Controls.Add(this.btnClearLogs);
            this.panelRight.Controls.Add(this.labelInfo);
            this.panelRight.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(208)))));
            this.panelRight.Location = new System.Drawing.Point(410, 60);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(410, 446);
            this.panelRight.TabIndex = 2;
            // 
            // labelLogSect
            // 
            this.labelLogSect.BackColor = System.Drawing.Color.Transparent;
            this.labelLogSect.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.labelLogSect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(202)))), ((int)(((byte)(177)))));
            this.labelLogSect.Location = new System.Drawing.Point(14, 14);
            this.labelLogSect.Name = "labelLogSect";
            this.labelLogSect.Size = new System.Drawing.Size(200, 15);
            this.labelLogSect.TabIndex = 0;
            this.labelLogSect.Text = "INJECTION LOGS";
            // 
            // cardLog
            // 
            this.cardLog.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(202)))), ((int)(((byte)(177)))));
            this.cardLog.BorderRadius = 8;
            this.cardLog.BorderThickness = 1;
            this.cardLog.Controls.Add(this.Sta);
            this.cardLog.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(231)))), ((int)(((byte)(185)))));
            this.cardLog.Location = new System.Drawing.Point(14, 32);
            this.cardLog.Name = "cardLog";
            this.cardLog.Size = new System.Drawing.Size(384, 320);
            this.cardLog.TabIndex = 1;
            // 
            // Sta
            // 
            this.Sta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(250)))), ((int)(((byte)(232)))));
            this.Sta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Sta.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.Sta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(55)))));
            this.Sta.Location = new System.Drawing.Point(6, 6);
            this.Sta.Name = "Sta";
            this.Sta.ReadOnly = true;
            this.Sta.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.Sta.Size = new System.Drawing.Size(372, 308);
            this.Sta.TabIndex = 0;
            this.Sta.Text = "[System Ready]\n";
            // 
            // btnClearLogs
            // 
            this.btnClearLogs.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(150)))), ((int)(((byte)(100)))));
            this.btnClearLogs.BorderRadius = 8;
            this.btnClearLogs.BorderThickness = 1;
            this.btnClearLogs.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(200)))), ((int)(((byte)(150)))));
            this.btnClearLogs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClearLogs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(80)))), ((int)(((byte)(40)))));
            this.btnClearLogs.Location = new System.Drawing.Point(240, 362);
            this.btnClearLogs.Name = "btnClearLogs";
            this.btnClearLogs.Size = new System.Drawing.Size(158, 36);
            this.btnClearLogs.TabIndex = 2;
            this.btnClearLogs.Text = "✕  Clear Logs";
            this.btnClearLogs.Click += new System.EventHandler(this.btnClearLogs_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelInfo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.labelInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.labelInfo.Location = new System.Drawing.Point(14, 368);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(220, 56);
            this.labelInfo.TabIndex = 3;
            this.labelInfo.Text = "① Select target process\r\n② Add / browse DLL(s)\r\n③ Click INJECT";
            // 
            // btnInject
            // 
            this.btnInject.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(184)))), ((int)(((byte)(158)))));
            this.btnInject.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(202)))), ((int)(((byte)(177)))));
            this.btnInject.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnInject.ForeColor = System.Drawing.Color.White;
            this.btnInject.Location = new System.Drawing.Point(0, 506);
            this.btnInject.Name = "btnInject";
            this.btnInject.Size = new System.Drawing.Size(820, 48);
            this.btnInject.TabIndex = 3;
            this.btnInject.Text = "⚡   INJECT";
            this.btnInject.Click += new System.EventHandler(this.btnInject_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(820, 554);
            this.Controls.Add(this.panelBase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DLL Injector";
            this.panelHeader.ResumeLayout(false);
            this.panelBase.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.cardProcess.ResumeLayout(false);
            this.cardDll.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.cardLog.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        // ── Field declarations ─────────────────────────────────────────────
        private Guna.UI2.WinForms.Guna2DragControl  dragControl;
        private Guna.UI2.WinForms.Guna2Panel        panelBase;
        private Guna.UI2.WinForms.Guna2Panel        panelHeader;
        private Guna.UI2.WinForms.Guna2CircleButton btnClose;
        private Guna.UI2.WinForms.Guna2CircleButton btnMinimize;
        private System.Windows.Forms.Label          labelTitle;
        private System.Windows.Forms.Label          labelSubtitle;
        private Guna.UI2.WinForms.Guna2Panel        panelLeft;
        private System.Windows.Forms.Label          labelProcessSect;
        private Guna.UI2.WinForms.Guna2Panel        cardProcess;
        private System.Windows.Forms.Label          labelProcessName;
        public  Guna.UI2.WinForms.Guna2TextBox      ProcessName;
        private Guna.UI2.WinForms.Guna2Button       btnSetProcess;
        private System.Windows.Forms.Label          labelDllSect;
        private Guna.UI2.WinForms.Guna2Panel        cardDll;
        private System.Windows.Forms.ListBox        listBoxDLLs;
        private Guna.UI2.WinForms.Guna2Button       btnRefresh;
        private Guna.UI2.WinForms.Guna2Button       btnBrowse;
        private Guna.UI2.WinForms.Guna2Panel        panelRight;
        private System.Windows.Forms.Label          labelLogSect;
        private Guna.UI2.WinForms.Guna2Panel        cardLog;
        public  System.Windows.Forms.RichTextBox    Sta;
        private Guna.UI2.WinForms.Guna2Button       btnClearLogs;
        private Guna.UI2.WinForms.Guna2Button       btnInject;
        private System.Windows.Forms.Label          labelInfo;
    }
}
