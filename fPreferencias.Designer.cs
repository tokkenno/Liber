namespace Liber
{
    partial class fPreferencias
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
            this.components = new System.ComponentModel.Container();
            this.tcPreferencias = new System.Windows.Forms.TabControl();
            this.tpPrefBasic = new System.Windows.Forms.TabPage();
            this.gbOthers = new System.Windows.Forms.GroupBox();
            this.cbDynamicSearch = new System.Windows.Forms.CheckBox();
            this.gbLang = new System.Windows.Forms.GroupBox();
            this.cbLang = new System.Windows.Forms.ComboBox();
            this.gbFormat = new System.Windows.Forms.GroupBox();
            this.cbFormat = new System.Windows.Forms.ComboBox();
            this.gbActionsBasic = new System.Windows.Forms.GroupBox();
            this.bRestartStat = new System.Windows.Forms.Button();
            this.bChangePassword = new System.Windows.Forms.Button();
            this.tpAdvPref = new System.Windows.Forms.TabPage();
            this.gbDatabaseInfo = new System.Windows.Forms.GroupBox();
            this.lBookSize = new System.Windows.Forms.Label();
            this.lCoversSize = new System.Windows.Forms.Label();
            this.gbActions = new System.Windows.Forms.GroupBox();
            this.bCompactDatabase = new System.Windows.Forms.Button();
            this.gbDownloads = new System.Windows.Forms.GroupBox();
            this.cbDownloads = new System.Windows.Forms.CheckBox();
            this.gbDebug = new System.Windows.Forms.GroupBox();
            this.cbConsoleDebug = new System.Windows.Forms.CheckBox();
            this.cbFileDebug = new System.Windows.Forms.CheckBox();
            this.flpButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.bCancel = new System.Windows.Forms.Button();
            this.bOk = new System.Windows.Forms.Button();
            this.pPrincipal = new System.Windows.Forms.Panel();
            this.pPref = new System.Windows.Forms.Panel();
            this.line1 = new PSLibrary.Controls.Line();
            this.tTips = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bRegisAdmin = new System.Windows.Forms.Button();
            this.tcPreferencias.SuspendLayout();
            this.tpPrefBasic.SuspendLayout();
            this.gbOthers.SuspendLayout();
            this.gbLang.SuspendLayout();
            this.gbFormat.SuspendLayout();
            this.gbActionsBasic.SuspendLayout();
            this.tpAdvPref.SuspendLayout();
            this.gbDatabaseInfo.SuspendLayout();
            this.gbActions.SuspendLayout();
            this.gbDownloads.SuspendLayout();
            this.gbDebug.SuspendLayout();
            this.flpButtons.SuspendLayout();
            this.pPrincipal.SuspendLayout();
            this.pPref.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcPreferencias
            // 
            this.tcPreferencias.Controls.Add(this.tpPrefBasic);
            this.tcPreferencias.Controls.Add(this.tpAdvPref);
            this.tcPreferencias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcPreferencias.HotTrack = true;
            this.tcPreferencias.Location = new System.Drawing.Point(7, 7);
            this.tcPreferencias.Margin = new System.Windows.Forms.Padding(5);
            this.tcPreferencias.Name = "tcPreferencias";
            this.tcPreferencias.SelectedIndex = 0;
            this.tcPreferencias.Size = new System.Drawing.Size(387, 156);
            this.tcPreferencias.TabIndex = 0;
            // 
            // tpPrefBasic
            // 
            this.tpPrefBasic.Controls.Add(this.gbOthers);
            this.tpPrefBasic.Controls.Add(this.gbLang);
            this.tpPrefBasic.Controls.Add(this.gbFormat);
            this.tpPrefBasic.Controls.Add(this.gbActionsBasic);
            this.tpPrefBasic.Location = new System.Drawing.Point(4, 22);
            this.tpPrefBasic.Name = "tpPrefBasic";
            this.tpPrefBasic.Padding = new System.Windows.Forms.Padding(3);
            this.tpPrefBasic.Size = new System.Drawing.Size(379, 130);
            this.tpPrefBasic.TabIndex = 0;
            this.tpPrefBasic.Text = "BASIC PREFERENCES";
            this.tpPrefBasic.UseVisualStyleBackColor = true;
            // 
            // gbOthers
            // 
            this.gbOthers.Controls.Add(this.cbDynamicSearch);
            this.gbOthers.Location = new System.Drawing.Point(164, 84);
            this.gbOthers.Name = "gbOthers";
            this.gbOthers.Size = new System.Drawing.Size(206, 40);
            this.gbOthers.TabIndex = 3;
            this.gbOthers.TabStop = false;
            this.gbOthers.Text = "OTHER";
            // 
            // cbDynamicSearch
            // 
            this.cbDynamicSearch.AutoSize = true;
            this.cbDynamicSearch.Location = new System.Drawing.Point(6, 17);
            this.cbDynamicSearch.Name = "cbDynamicSearch";
            this.cbDynamicSearch.Size = new System.Drawing.Size(122, 17);
            this.cbDynamicSearch.TabIndex = 0;
            this.cbDynamicSearch.Text = "DYNAMIC SEARCH";
            this.cbDynamicSearch.UseVisualStyleBackColor = true;
            // 
            // gbLang
            // 
            this.gbLang.Controls.Add(this.cbLang);
            this.gbLang.Location = new System.Drawing.Point(6, 78);
            this.gbLang.Name = "gbLang";
            this.gbLang.Size = new System.Drawing.Size(152, 46);
            this.gbLang.TabIndex = 2;
            this.gbLang.TabStop = false;
            this.gbLang.Text = "PREDEF. LANG";
            // 
            // cbLang
            // 
            this.cbLang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbLang.FormattingEnabled = true;
            this.cbLang.Location = new System.Drawing.Point(3, 16);
            this.cbLang.Name = "cbLang";
            this.cbLang.Size = new System.Drawing.Size(146, 21);
            this.cbLang.TabIndex = 0;
            // 
            // gbFormat
            // 
            this.gbFormat.Controls.Add(this.cbFormat);
            this.gbFormat.Location = new System.Drawing.Point(6, 6);
            this.gbFormat.Name = "gbFormat";
            this.gbFormat.Size = new System.Drawing.Size(152, 46);
            this.gbFormat.TabIndex = 1;
            this.gbFormat.TabStop = false;
            this.gbFormat.Text = "PREDEF. FORMAT";
            // 
            // cbFormat
            // 
            this.cbFormat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbFormat.FormattingEnabled = true;
            this.cbFormat.Location = new System.Drawing.Point(3, 16);
            this.cbFormat.Name = "cbFormat";
            this.cbFormat.Size = new System.Drawing.Size(146, 21);
            this.cbFormat.TabIndex = 0;
            // 
            // gbActionsBasic
            // 
            this.gbActionsBasic.Controls.Add(this.bRestartStat);
            this.gbActionsBasic.Controls.Add(this.bChangePassword);
            this.gbActionsBasic.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbActionsBasic.Location = new System.Drawing.Point(164, 3);
            this.gbActionsBasic.Name = "gbActionsBasic";
            this.gbActionsBasic.Size = new System.Drawing.Size(206, 77);
            this.gbActionsBasic.TabIndex = 0;
            this.gbActionsBasic.TabStop = false;
            this.gbActionsBasic.Text = "ACTIONS";
            // 
            // bRestartStat
            // 
            this.bRestartStat.Location = new System.Drawing.Point(6, 48);
            this.bRestartStat.Name = "bRestartStat";
            this.bRestartStat.Size = new System.Drawing.Size(194, 23);
            this.bRestartStat.TabIndex = 1;
            this.bRestartStat.Text = "RESTART STATISTICS";
            this.bRestartStat.UseVisualStyleBackColor = true;
            this.bRestartStat.Click += new System.EventHandler(this.bRestartStat_Click);
            // 
            // bChangePassword
            // 
            this.bChangePassword.Location = new System.Drawing.Point(6, 19);
            this.bChangePassword.Name = "bChangePassword";
            this.bChangePassword.Size = new System.Drawing.Size(194, 23);
            this.bChangePassword.TabIndex = 0;
            this.bChangePassword.Text = "CHANGE PASSWORD";
            this.bChangePassword.UseVisualStyleBackColor = true;
            this.bChangePassword.Click += new System.EventHandler(this.bChangePassword_Click);
            // 
            // tpAdvPref
            // 
            this.tpAdvPref.Controls.Add(this.gbDatabaseInfo);
            this.tpAdvPref.Controls.Add(this.gbActions);
            this.tpAdvPref.Controls.Add(this.gbDownloads);
            this.tpAdvPref.Controls.Add(this.gbDebug);
            this.tpAdvPref.Location = new System.Drawing.Point(4, 22);
            this.tpAdvPref.Name = "tpAdvPref";
            this.tpAdvPref.Padding = new System.Windows.Forms.Padding(3);
            this.tpAdvPref.Size = new System.Drawing.Size(379, 130);
            this.tpAdvPref.TabIndex = 1;
            this.tpAdvPref.Text = "ADVANCED PREFERENCES";
            this.tpAdvPref.UseVisualStyleBackColor = true;
            // 
            // gbDatabaseInfo
            // 
            this.gbDatabaseInfo.Controls.Add(this.lBookSize);
            this.gbDatabaseInfo.Controls.Add(this.lCoversSize);
            this.gbDatabaseInfo.Location = new System.Drawing.Point(189, 55);
            this.gbDatabaseInfo.Name = "gbDatabaseInfo";
            this.gbDatabaseInfo.Size = new System.Drawing.Size(177, 71);
            this.gbDatabaseInfo.TabIndex = 3;
            this.gbDatabaseInfo.TabStop = false;
            this.gbDatabaseInfo.Text = "DATABASE INFO";
            // 
            // lBookSize
            // 
            this.lBookSize.AutoSize = true;
            this.lBookSize.Location = new System.Drawing.Point(7, 46);
            this.lBookSize.Name = "lBookSize";
            this.lBookSize.Size = new System.Drawing.Size(64, 13);
            this.lBookSize.TabIndex = 1;
            this.lBookSize.Text = "BOOK SIZE";
            // 
            // lCoversSize
            // 
            this.lCoversSize.AutoSize = true;
            this.lCoversSize.Location = new System.Drawing.Point(7, 22);
            this.lCoversSize.Name = "lCoversSize";
            this.lCoversSize.Size = new System.Drawing.Size(78, 13);
            this.lCoversSize.TabIndex = 0;
            this.lCoversSize.Text = "COVERS SIZE";
            // 
            // gbActions
            // 
            this.gbActions.Controls.Add(this.bCompactDatabase);
            this.gbActions.Location = new System.Drawing.Point(6, 77);
            this.gbActions.Name = "gbActions";
            this.gbActions.Size = new System.Drawing.Size(177, 49);
            this.gbActions.TabIndex = 2;
            this.gbActions.TabStop = false;
            this.gbActions.Text = "ACTIONS";
            // 
            // bCompactDatabase
            // 
            this.bCompactDatabase.Location = new System.Drawing.Point(6, 19);
            this.bCompactDatabase.Name = "bCompactDatabase";
            this.bCompactDatabase.Size = new System.Drawing.Size(165, 23);
            this.bCompactDatabase.TabIndex = 0;
            this.bCompactDatabase.Text = "COMPACT DATABASE";
            this.bCompactDatabase.UseVisualStyleBackColor = true;
            this.bCompactDatabase.Click += new System.EventHandler(this.bCompactDatabase_Click);
            // 
            // gbDownloads
            // 
            this.gbDownloads.Controls.Add(this.cbDownloads);
            this.gbDownloads.Location = new System.Drawing.Point(189, 6);
            this.gbDownloads.Name = "gbDownloads";
            this.gbDownloads.Size = new System.Drawing.Size(177, 43);
            this.gbDownloads.TabIndex = 2;
            this.gbDownloads.TabStop = false;
            this.gbDownloads.Text = "DOWNLOADS";
            // 
            // cbDownloads
            // 
            this.cbDownloads.AutoSize = true;
            this.cbDownloads.Location = new System.Drawing.Point(6, 19);
            this.cbDownloads.Name = "cbDownloads";
            this.cbDownloads.Size = new System.Drawing.Size(138, 17);
            this.cbDownloads.TabIndex = 2;
            this.cbDownloads.Text = "ALLOW DOWNLOADS";
            this.cbDownloads.UseVisualStyleBackColor = true;
            // 
            // gbDebug
            // 
            this.gbDebug.Controls.Add(this.cbConsoleDebug);
            this.gbDebug.Controls.Add(this.cbFileDebug);
            this.gbDebug.Location = new System.Drawing.Point(6, 6);
            this.gbDebug.Name = "gbDebug";
            this.gbDebug.Size = new System.Drawing.Size(177, 65);
            this.gbDebug.TabIndex = 1;
            this.gbDebug.TabStop = false;
            this.gbDebug.Text = "DEBUG";
            // 
            // cbConsoleDebug
            // 
            this.cbConsoleDebug.AutoSize = true;
            this.cbConsoleDebug.Location = new System.Drawing.Point(6, 42);
            this.cbConsoleDebug.Name = "cbConsoleDebug";
            this.cbConsoleDebug.Size = new System.Drawing.Size(118, 17);
            this.cbConsoleDebug.TabIndex = 1;
            this.cbConsoleDebug.Text = "CONSOLE DEBUG";
            this.cbConsoleDebug.UseVisualStyleBackColor = true;
            // 
            // cbFileDebug
            // 
            this.cbFileDebug.AutoSize = true;
            this.cbFileDebug.Location = new System.Drawing.Point(6, 19);
            this.cbFileDebug.Name = "cbFileDebug";
            this.cbFileDebug.Size = new System.Drawing.Size(89, 17);
            this.cbFileDebug.TabIndex = 0;
            this.cbFileDebug.Text = "FILE DEBUG";
            this.cbFileDebug.UseVisualStyleBackColor = true;
            // 
            // flpButtons
            // 
            this.flpButtons.Controls.Add(this.bCancel);
            this.flpButtons.Controls.Add(this.bOk);
            this.flpButtons.Controls.Add(this.panel1);
            this.flpButtons.Controls.Add(this.bRegisAdmin);
            this.flpButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpButtons.Location = new System.Drawing.Point(0, 171);
            this.flpButtons.Name = "flpButtons";
            this.flpButtons.Padding = new System.Windows.Forms.Padding(3);
            this.flpButtons.Size = new System.Drawing.Size(401, 35);
            this.flpButtons.TabIndex = 1;
            // 
            // bCancel
            // 
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Location = new System.Drawing.Point(317, 6);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 0;
            this.bCancel.Text = "CANCEL";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bOk
            // 
            this.bOk.Location = new System.Drawing.Point(236, 6);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(75, 23);
            this.bOk.TabIndex = 1;
            this.bOk.Text = "ACCEPT";
            this.bOk.UseVisualStyleBackColor = true;
            this.bOk.Click += new System.EventHandler(this.bOk_Click);
            // 
            // pPrincipal
            // 
            this.pPrincipal.Controls.Add(this.pPref);
            this.pPrincipal.Controls.Add(this.line1);
            this.pPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pPrincipal.Name = "pPrincipal";
            this.pPrincipal.Size = new System.Drawing.Size(401, 171);
            this.pPrincipal.TabIndex = 2;
            // 
            // pPref
            // 
            this.pPref.Controls.Add(this.tcPreferencias);
            this.pPref.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPref.Location = new System.Drawing.Point(0, 0);
            this.pPref.Name = "pPref";
            this.pPref.Padding = new System.Windows.Forms.Padding(7);
            this.pPref.Size = new System.Drawing.Size(401, 170);
            this.pPref.TabIndex = 3;
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.line1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.line1.Location = new System.Drawing.Point(0, 170);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(401, 1);
            this.line1.TabIndex = 2;
            // 
            // tTips
            // 
            this.tTips.AutoPopDelay = 25000;
            this.tTips.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tTips.InitialDelay = 500;
            this.tTips.IsBalloon = true;
            this.tTips.ReshowDelay = 100;
            this.tTips.ShowAlways = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(143, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(87, 23);
            this.panel1.TabIndex = 2;
            // 
            // bRegisAdmin
            // 
            this.bRegisAdmin.Location = new System.Drawing.Point(6, 6);
            this.bRegisAdmin.Name = "bRegisAdmin";
            this.bRegisAdmin.Size = new System.Drawing.Size(131, 23);
            this.bRegisAdmin.TabIndex = 3;
            this.bRegisAdmin.Text = "REGISTER ADMIN";
            this.bRegisAdmin.UseVisualStyleBackColor = true;
            this.bRegisAdmin.Click += new System.EventHandler(this.bRegisAdmin_Click);
            // 
            // fPreferencias
            // 
            this.AcceptButton = this.bOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bCancel;
            this.ClientSize = new System.Drawing.Size(401, 206);
            this.Controls.Add(this.pPrincipal);
            this.Controls.Add(this.flpButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fPreferencias";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "fPreferencias";
            this.TopMost = true;
            this.tcPreferencias.ResumeLayout(false);
            this.tpPrefBasic.ResumeLayout(false);
            this.gbOthers.ResumeLayout(false);
            this.gbOthers.PerformLayout();
            this.gbLang.ResumeLayout(false);
            this.gbFormat.ResumeLayout(false);
            this.gbActionsBasic.ResumeLayout(false);
            this.tpAdvPref.ResumeLayout(false);
            this.gbDatabaseInfo.ResumeLayout(false);
            this.gbDatabaseInfo.PerformLayout();
            this.gbActions.ResumeLayout(false);
            this.gbDownloads.ResumeLayout(false);
            this.gbDownloads.PerformLayout();
            this.gbDebug.ResumeLayout(false);
            this.gbDebug.PerformLayout();
            this.flpButtons.ResumeLayout(false);
            this.pPrincipal.ResumeLayout(false);
            this.pPref.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcPreferencias;
        private System.Windows.Forms.TabPage tpPrefBasic;
        private System.Windows.Forms.TabPage tpAdvPref;
        private System.Windows.Forms.FlowLayoutPanel flpButtons;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bOk;
        private System.Windows.Forms.Panel pPrincipal;
        private PSLibrary.Controls.Line line1;
        private System.Windows.Forms.Panel pPref;
        private System.Windows.Forms.GroupBox gbDebug;
        private System.Windows.Forms.CheckBox cbConsoleDebug;
        private System.Windows.Forms.CheckBox cbFileDebug;
        private System.Windows.Forms.GroupBox gbFormat;
        private System.Windows.Forms.ComboBox cbFormat;
        private System.Windows.Forms.GroupBox gbActionsBasic;
        private System.Windows.Forms.Button bRestartStat;
        private System.Windows.Forms.Button bChangePassword;
        private System.Windows.Forms.GroupBox gbDatabaseInfo;
        private System.Windows.Forms.Label lBookSize;
        private System.Windows.Forms.Label lCoversSize;
        private System.Windows.Forms.GroupBox gbActions;
        private System.Windows.Forms.Button bCompactDatabase;
        private System.Windows.Forms.GroupBox gbDownloads;
        private System.Windows.Forms.CheckBox cbDownloads;
        private System.Windows.Forms.GroupBox gbOthers;
        private System.Windows.Forms.CheckBox cbDynamicSearch;
        private System.Windows.Forms.GroupBox gbLang;
        private System.Windows.Forms.ComboBox cbLang;
        private System.Windows.Forms.ToolTip tTips;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bRegisAdmin;
    }
}