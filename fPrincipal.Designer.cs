namespace Liber
{
    partial class fPrincipal
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
            this.bAdd = new System.Windows.Forms.Button();
            this.pMenu = new System.Windows.Forms.Panel();
            this.bAbout = new System.Windows.Forms.Button();
            this.bHelp = new System.Windows.Forms.Button();
            this.bRSS = new System.Windows.Forms.Button();
            this.bShow = new System.Windows.Forms.Button();
            this.bPreferences = new System.Windows.Forms.Button();
            this.bDel = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.pSearch = new System.Windows.Forms.Panel();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.pPrincipal = new System.Windows.Forms.Panel();
            this.lvBooks = new System.Windows.Forms.ListView();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAuthor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSaga = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGenero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pInfo = new System.Windows.Forms.Panel();
            this.tb_I = new System.Windows.Forms.TextBox();
            this.pbCover = new System.Windows.Forms.PictureBox();
            this.cmsBooks = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiRead = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReadAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiEditMetadata = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAuthorInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tTips = new System.Windows.Forms.ToolTip(this.components);
            this.line5 = new PSLibrary.Controls.Line();
            this.line3 = new PSLibrary.Controls.Line();
            this.line4 = new PSLibrary.Controls.Line();
            this.pList = new System.Windows.Forms.Panel();
            this.tsmiDownload = new System.Windows.Forms.ToolStripMenuItem();
            this.pMenu.SuspendLayout();
            this.pSearch.SuspendLayout();
            this.pPrincipal.SuspendLayout();
            this.pInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).BeginInit();
            this.cmsBooks.SuspendLayout();
            this.pList.SuspendLayout();
            this.SuspendLayout();
            // 
            // bAdd
            // 
            this.bAdd.BackgroundImage = global::Liber.Properties.Resources.menu_add_64;
            this.bAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bAdd.Location = new System.Drawing.Point(3, 3);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(64, 64);
            this.bAdd.TabIndex = 0;
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // pMenu
            // 
            this.pMenu.Controls.Add(this.line5);
            this.pMenu.Controls.Add(this.line3);
            this.pMenu.Controls.Add(this.bAbout);
            this.pMenu.Controls.Add(this.bHelp);
            this.pMenu.Controls.Add(this.line4);
            this.pMenu.Controls.Add(this.bRSS);
            this.pMenu.Controls.Add(this.bShow);
            this.pMenu.Controls.Add(this.bPreferences);
            this.pMenu.Controls.Add(this.bDel);
            this.pMenu.Controls.Add(this.bEdit);
            this.pMenu.Controls.Add(this.bAdd);
            this.pMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pMenu.Location = new System.Drawing.Point(0, 0);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(69, 562);
            this.pMenu.TabIndex = 1;
            // 
            // bAbout
            // 
            this.bAbout.BackgroundImage = global::Liber.Properties.Resources.logo_64;
            this.bAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bAbout.Location = new System.Drawing.Point(3, 491);
            this.bAbout.Name = "bAbout";
            this.bAbout.Size = new System.Drawing.Size(64, 64);
            this.bAbout.TabIndex = 11;
            this.bAbout.UseVisualStyleBackColor = true;
            this.bAbout.Click += new System.EventHandler(this.bAbout_Click);
            // 
            // bHelp
            // 
            this.bHelp.BackgroundImage = global::Liber.Properties.Resources.menu_help_64;
            this.bHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bHelp.Location = new System.Drawing.Point(3, 427);
            this.bHelp.Name = "bHelp";
            this.bHelp.Size = new System.Drawing.Size(64, 64);
            this.bHelp.TabIndex = 10;
            this.bHelp.UseVisualStyleBackColor = true;
            this.bHelp.Click += new System.EventHandler(this.bHelp_Click);
            // 
            // bRSS
            // 
            this.bRSS.BackgroundImage = global::Liber.Properties.Resources.menu_rss_64;
            this.bRSS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bRSS.Location = new System.Drawing.Point(3, 285);
            this.bRSS.Name = "bRSS";
            this.bRSS.Size = new System.Drawing.Size(64, 64);
            this.bRSS.TabIndex = 6;
            this.bRSS.UseVisualStyleBackColor = true;
            this.bRSS.Click += new System.EventHandler(this.bRSS_Click);
            // 
            // bShow
            // 
            this.bShow.BackgroundImage = global::Liber.Properties.Resources.menu_view_64;
            this.bShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bShow.Location = new System.Drawing.Point(3, 208);
            this.bShow.Name = "bShow";
            this.bShow.Size = new System.Drawing.Size(64, 64);
            this.bShow.TabIndex = 5;
            this.bShow.UseVisualStyleBackColor = true;
            this.bShow.Click += new System.EventHandler(this.bShow_Click);
            // 
            // bPreferences
            // 
            this.bPreferences.BackgroundImage = global::Liber.Properties.Resources.menu_preferences_64;
            this.bPreferences.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bPreferences.Location = new System.Drawing.Point(3, 362);
            this.bPreferences.Name = "bPreferences";
            this.bPreferences.Size = new System.Drawing.Size(64, 64);
            this.bPreferences.TabIndex = 4;
            this.bPreferences.UseVisualStyleBackColor = true;
            this.bPreferences.Click += new System.EventHandler(this.bPreferences_Click);
            // 
            // bDel
            // 
            this.bDel.BackgroundImage = global::Liber.Properties.Resources.menu_delete_64;
            this.bDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bDel.FlatAppearance.BorderSize = 0;
            this.bDel.Location = new System.Drawing.Point(3, 131);
            this.bDel.Name = "bDel";
            this.bDel.Size = new System.Drawing.Size(64, 64);
            this.bDel.TabIndex = 3;
            this.bDel.UseVisualStyleBackColor = true;
            this.bDel.Click += new System.EventHandler(this.bDel_Click);
            // 
            // bEdit
            // 
            this.bEdit.BackgroundImage = global::Liber.Properties.Resources.menu_edit_64;
            this.bEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bEdit.Location = new System.Drawing.Point(3, 67);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(64, 64);
            this.bEdit.TabIndex = 2;
            this.bEdit.UseVisualStyleBackColor = true;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // pSearch
            // 
            this.pSearch.Controls.Add(this.tbSearch);
            this.pSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pSearch.Location = new System.Drawing.Point(6, 509);
            this.pSearch.Name = "pSearch";
            this.pSearch.Size = new System.Drawing.Size(150, 31);
            this.pSearch.TabIndex = 12;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(3, 6);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(144, 20);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            this.tbSearch.Enter += new System.EventHandler(this.tbSearch_Enter);
            this.tbSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearch_KeyPress);
            this.tbSearch.Leave += new System.EventHandler(this.tbSearch_Leave);
            // 
            // pPrincipal
            // 
            this.pPrincipal.Controls.Add(this.pList);
            this.pPrincipal.Controls.Add(this.pInfo);
            this.pPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPrincipal.Location = new System.Drawing.Point(69, 0);
            this.pPrincipal.Name = "pPrincipal";
            this.pPrincipal.Padding = new System.Windows.Forms.Padding(8);
            this.pPrincipal.Size = new System.Drawing.Size(735, 562);
            this.pPrincipal.TabIndex = 3;
            // 
            // lvBooks
            // 
            this.lvBooks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chTitle,
            this.chAuthor,
            this.chSaga,
            this.chGenero});
            this.lvBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvBooks.FullRowSelect = true;
            this.lvBooks.Location = new System.Drawing.Point(0, 0);
            this.lvBooks.MultiSelect = false;
            this.lvBooks.Name = "lvBooks";
            this.lvBooks.Size = new System.Drawing.Size(557, 546);
            this.lvBooks.TabIndex = 0;
            this.lvBooks.UseCompatibleStateImageBehavior = false;
            this.lvBooks.View = System.Windows.Forms.View.Details;
            this.lvBooks.SelectedIndexChanged += new System.EventHandler(this.lvBooks_SelectedIndexChanged);
            this.lvBooks.DoubleClick += new System.EventHandler(this.lvBooks_DoubleClick);
            this.lvBooks.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvBooks_MouseClick);
            // 
            // chID
            // 
            this.chID.Text = "ID";
            // 
            // chTitle
            // 
            this.chTitle.Text = "TITLE";
            this.chTitle.Width = 97;
            // 
            // chAuthor
            // 
            this.chAuthor.Text = "AUTHOR";
            this.chAuthor.Width = 106;
            // 
            // chSaga
            // 
            this.chSaga.Text = "SAGA";
            this.chSaga.Width = 67;
            // 
            // chGenero
            // 
            this.chGenero.Text = "GENRE";
            // 
            // pInfo
            // 
            this.pInfo.Controls.Add(this.tb_I);
            this.pInfo.Controls.Add(this.pSearch);
            this.pInfo.Controls.Add(this.pbCover);
            this.pInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pInfo.Location = new System.Drawing.Point(565, 8);
            this.pInfo.Name = "pInfo";
            this.pInfo.Padding = new System.Windows.Forms.Padding(6);
            this.pInfo.Size = new System.Drawing.Size(162, 546);
            this.pInfo.TabIndex = 0;
            // 
            // tb_I
            // 
            this.tb_I.BackColor = System.Drawing.SystemColors.Control;
            this.tb_I.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_I.CausesValidation = false;
            this.tb_I.Cursor = System.Windows.Forms.Cursors.Default;
            this.tb_I.Location = new System.Drawing.Point(9, 226);
            this.tb_I.Multiline = true;
            this.tb_I.Name = "tb_I";
            this.tb_I.ReadOnly = true;
            this.tb_I.Size = new System.Drawing.Size(150, 206);
            this.tb_I.TabIndex = 13;
            this.tb_I.TabStop = false;
            // 
            // pbCover
            // 
            this.pbCover.Image = global::Liber.Properties.Resources.default_cover;
            this.pbCover.Location = new System.Drawing.Point(9, 6);
            this.pbCover.Name = "pbCover";
            this.pbCover.Size = new System.Drawing.Size(150, 200);
            this.pbCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCover.TabIndex = 0;
            this.pbCover.TabStop = false;
            // 
            // cmsBooks
            // 
            this.cmsBooks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRead,
            this.tsmiReadAs,
            this.tsmiDownload,
            this.toolStripSeparator2,
            this.tsmiEditMetadata,
            this.tsmiAddFormat,
            this.tsmiAuthorInfo,
            this.toolStripSeparator1,
            this.tsmiDelete});
            this.cmsBooks.Name = "cmsBooks";
            this.cmsBooks.Size = new System.Drawing.Size(165, 192);
            // 
            // tsmiRead
            // 
            this.tsmiRead.Name = "tsmiRead";
            this.tsmiRead.Size = new System.Drawing.Size(164, 22);
            this.tsmiRead.Text = "READ";
            this.tsmiRead.Click += new System.EventHandler(this.bShow_Click);
            // 
            // tsmiReadAs
            // 
            this.tsmiReadAs.Name = "tsmiReadAs";
            this.tsmiReadAs.Size = new System.Drawing.Size(164, 22);
            this.tsmiReadAs.Text = "READ AS";
            this.tsmiReadAs.Click += new System.EventHandler(this.tsmiReadAs_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(161, 6);
            // 
            // tsmiEditMetadata
            // 
            this.tsmiEditMetadata.Name = "tsmiEditMetadata";
            this.tsmiEditMetadata.Size = new System.Drawing.Size(164, 22);
            this.tsmiEditMetadata.Text = "EDIT METADATA";
            this.tsmiEditMetadata.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // tsmiAddFormat
            // 
            this.tsmiAddFormat.Name = "tsmiAddFormat";
            this.tsmiAddFormat.Size = new System.Drawing.Size(164, 22);
            this.tsmiAddFormat.Text = "ADD FORMAT";
            this.tsmiAddFormat.Click += new System.EventHandler(this.tsmiAddFormat_Click);
            // 
            // tsmiAuthorInfo
            // 
            this.tsmiAuthorInfo.Name = "tsmiAuthorInfo";
            this.tsmiAuthorInfo.Size = new System.Drawing.Size(164, 22);
            this.tsmiAuthorInfo.Text = "AUTHOR INFO";
            this.tsmiAuthorInfo.Click += new System.EventHandler(this.tsmiAuthorInfo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(161, 6);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(164, 22);
            this.tsmiDelete.Text = "DELETE";
            this.tsmiDelete.Click += new System.EventHandler(this.bDel_Click);
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
            // line5
            // 
            this.line5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.line5.Location = new System.Drawing.Point(3, 355);
            this.line5.Name = "line5";
            this.line5.Size = new System.Drawing.Size(64, 1);
            this.line5.TabIndex = 14;
            // 
            // line3
            // 
            this.line3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.line3.Location = new System.Drawing.Point(3, 278);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(64, 1);
            this.line3.TabIndex = 13;
            // 
            // line4
            // 
            this.line4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.line4.Location = new System.Drawing.Point(3, 201);
            this.line4.Name = "line4";
            this.line4.Size = new System.Drawing.Size(64, 1);
            this.line4.TabIndex = 7;
            // 
            // pList
            // 
            this.pList.Controls.Add(this.lvBooks);
            this.pList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pList.Location = new System.Drawing.Point(8, 8);
            this.pList.Name = "pList";
            this.pList.Size = new System.Drawing.Size(557, 546);
            this.pList.TabIndex = 1;
            // 
            // tsmiDownload
            // 
            this.tsmiDownload.Name = "tsmiDownload";
            this.tsmiDownload.Size = new System.Drawing.Size(164, 22);
            this.tsmiDownload.Text = "DOWNLOADS";
            this.tsmiDownload.Click += new System.EventHandler(this.tsmiDownload_Click);
            // 
            // fPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 562);
            this.Controls.Add(this.pPrincipal);
            this.Controls.Add(this.pMenu);
            this.MinimumSize = new System.Drawing.Size(820, 600);
            this.Name = "fPrincipal";
            this.Text = "fPrincipal";
            this.pMenu.ResumeLayout(false);
            this.pSearch.ResumeLayout(false);
            this.pSearch.PerformLayout();
            this.pPrincipal.ResumeLayout(false);
            this.pInfo.ResumeLayout(false);
            this.pInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).EndInit();
            this.cmsBooks.ResumeLayout(false);
            this.pList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.Panel pPrincipal;
        private System.Windows.Forms.Panel pInfo;
        private System.Windows.Forms.PictureBox pbCover;
        private System.Windows.Forms.Button bRSS;
        private System.Windows.Forms.Button bShow;
        private System.Windows.Forms.Button bPreferences;
        private System.Windows.Forms.Button bDel;
        private System.Windows.Forms.Button bEdit;
        private PSLibrary.Controls.Line line4;
        private System.Windows.Forms.Button bAbout;
        private System.Windows.Forms.Button bHelp;
        private System.Windows.Forms.Panel pSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.ListView lvBooks;
        private System.Windows.Forms.ColumnHeader chTitle;
        private System.Windows.Forms.ColumnHeader chAuthor;
        private System.Windows.Forms.ColumnHeader chSaga;
        private PSLibrary.Controls.Line line5;
        private PSLibrary.Controls.Line line3;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chGenero;
        private System.Windows.Forms.ContextMenuStrip cmsBooks;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditMetadata;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmiRead;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiAuthorInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddFormat;
        private System.Windows.Forms.ToolTip tTips;
        private System.Windows.Forms.TextBox tb_I;
        private System.Windows.Forms.ToolStripMenuItem tsmiReadAs;
        private System.Windows.Forms.Panel pList;
        private System.Windows.Forms.ToolStripMenuItem tsmiDownload;
    }
}