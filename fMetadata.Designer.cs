namespace Liber
{
    partial class fMetadata
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
            this.gbMetadata = new System.Windows.Forms.GroupBox();
            this.cbSagaType = new System.Windows.Forms.ComboBox();
            this.lSagaType = new System.Windows.Forms.Label();
            this.tbSinopsis = new System.Windows.Forms.TextBox();
            this.lSinopsis = new System.Windows.Forms.Label();
            this.cbGenre = new System.Windows.Forms.ComboBox();
            this.lGenre = new System.Windows.Forms.Label();
            this.lSaga = new System.Windows.Forms.Label();
            this.tbSaga = new System.Windows.Forms.TextBox();
            this.lAuthor = new System.Windows.Forms.Label();
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.lTitle = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.lID = new System.Windows.Forms.Label();
            this.pPrin = new System.Windows.Forms.Panel();
            this.gbCover = new System.Windows.Forms.GroupBox();
            this.bDel = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.pbCover = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bCancel = new System.Windows.Forms.Button();
            this.bAccept = new System.Windows.Forms.Button();
            this.pBack = new System.Windows.Forms.Panel();
            this.gbMetadata.SuspendLayout();
            this.pPrin.SuspendLayout();
            this.gbCover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.pBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMetadata
            // 
            this.gbMetadata.Controls.Add(this.cbSagaType);
            this.gbMetadata.Controls.Add(this.lSagaType);
            this.gbMetadata.Controls.Add(this.tbSinopsis);
            this.gbMetadata.Controls.Add(this.lSinopsis);
            this.gbMetadata.Controls.Add(this.cbGenre);
            this.gbMetadata.Controls.Add(this.lGenre);
            this.gbMetadata.Controls.Add(this.lSaga);
            this.gbMetadata.Controls.Add(this.tbSaga);
            this.gbMetadata.Controls.Add(this.lAuthor);
            this.gbMetadata.Controls.Add(this.tbAuthor);
            this.gbMetadata.Controls.Add(this.lTitle);
            this.gbMetadata.Controls.Add(this.tbTitle);
            this.gbMetadata.Controls.Add(this.tbID);
            this.gbMetadata.Controls.Add(this.lID);
            this.gbMetadata.Location = new System.Drawing.Point(13, 14);
            this.gbMetadata.Name = "gbMetadata";
            this.gbMetadata.Size = new System.Drawing.Size(333, 280);
            this.gbMetadata.TabIndex = 0;
            this.gbMetadata.TabStop = false;
            this.gbMetadata.Text = "METADATA";
            // 
            // cbSagaType
            // 
            this.cbSagaType.FormattingEnabled = true;
            this.cbSagaType.Location = new System.Drawing.Point(106, 128);
            this.cbSagaType.Name = "cbSagaType";
            this.cbSagaType.Size = new System.Drawing.Size(209, 21);
            this.cbSagaType.TabIndex = 14;
            // 
            // lSagaType
            // 
            this.lSagaType.AutoSize = true;
            this.lSagaType.Location = new System.Drawing.Point(17, 132);
            this.lSagaType.Name = "lSagaType";
            this.lSagaType.Size = new System.Drawing.Size(64, 13);
            this.lSagaType.TabIndex = 13;
            this.lSagaType.Text = "SAGATYPE";
            // 
            // tbSinopsis
            // 
            this.tbSinopsis.Location = new System.Drawing.Point(106, 182);
            this.tbSinopsis.MaxLength = 240;
            this.tbSinopsis.Multiline = true;
            this.tbSinopsis.Name = "tbSinopsis";
            this.tbSinopsis.Size = new System.Drawing.Size(209, 76);
            this.tbSinopsis.TabIndex = 11;
            // 
            // lSinopsis
            // 
            this.lSinopsis.AutoSize = true;
            this.lSinopsis.Location = new System.Drawing.Point(17, 185);
            this.lSinopsis.Name = "lSinopsis";
            this.lSinopsis.Size = new System.Drawing.Size(57, 13);
            this.lSinopsis.TabIndex = 10;
            this.lSinopsis.Text = "SINOPSIS";
            // 
            // cbGenre
            // 
            this.cbGenre.FormattingEnabled = true;
            this.cbGenre.Location = new System.Drawing.Point(106, 155);
            this.cbGenre.Name = "cbGenre";
            this.cbGenre.Size = new System.Drawing.Size(209, 21);
            this.cbGenre.TabIndex = 9;
            // 
            // lGenre
            // 
            this.lGenre.AutoSize = true;
            this.lGenre.Location = new System.Drawing.Point(17, 158);
            this.lGenre.Name = "lGenre";
            this.lGenre.Size = new System.Drawing.Size(45, 13);
            this.lGenre.TabIndex = 8;
            this.lGenre.Text = "GENRE";
            // 
            // lSaga
            // 
            this.lSaga.AutoSize = true;
            this.lSaga.Location = new System.Drawing.Point(17, 106);
            this.lSaga.Name = "lSaga";
            this.lSaga.Size = new System.Drawing.Size(36, 13);
            this.lSaga.TabIndex = 7;
            this.lSaga.Text = "SAGA";
            // 
            // tbSaga
            // 
            this.tbSaga.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.tbSaga.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbSaga.Location = new System.Drawing.Point(106, 103);
            this.tbSaga.MaxLength = 80;
            this.tbSaga.Name = "tbSaga";
            this.tbSaga.Size = new System.Drawing.Size(209, 20);
            this.tbSaga.TabIndex = 6;
            // 
            // lAuthor
            // 
            this.lAuthor.AutoSize = true;
            this.lAuthor.Location = new System.Drawing.Point(17, 80);
            this.lAuthor.Name = "lAuthor";
            this.lAuthor.Size = new System.Drawing.Size(53, 13);
            this.lAuthor.TabIndex = 5;
            this.lAuthor.Text = "AUTHOR";
            // 
            // tbAuthor
            // 
            this.tbAuthor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.tbAuthor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbAuthor.Location = new System.Drawing.Point(106, 77);
            this.tbAuthor.MaxLength = 54;
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.Size = new System.Drawing.Size(209, 20);
            this.tbAuthor.TabIndex = 4;
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Location = new System.Drawing.Point(17, 54);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(37, 13);
            this.lTitle.TabIndex = 3;
            this.lTitle.Text = "TITLE";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(106, 51);
            this.tbTitle.MaxLength = 60;
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(209, 20);
            this.tbTitle.TabIndex = 2;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(106, 25);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(209, 20);
            this.tbID.TabIndex = 1;
            // 
            // lID
            // 
            this.lID.AutoSize = true;
            this.lID.Location = new System.Drawing.Point(17, 28);
            this.lID.Name = "lID";
            this.lID.Size = new System.Drawing.Size(18, 13);
            this.lID.TabIndex = 0;
            this.lID.Text = "ID";
            // 
            // pPrin
            // 
            this.pPrin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pPrin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pPrin.Controls.Add(this.gbCover);
            this.pPrin.Controls.Add(this.gbMetadata);
            this.pPrin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPrin.Location = new System.Drawing.Point(12, 12);
            this.pPrin.Name = "pPrin";
            this.pPrin.Size = new System.Drawing.Size(606, 307);
            this.pPrin.TabIndex = 1;
            // 
            // gbCover
            // 
            this.gbCover.Controls.Add(this.bDel);
            this.gbCover.Controls.Add(this.bAdd);
            this.gbCover.Controls.Add(this.pbCover);
            this.gbCover.Location = new System.Drawing.Point(352, 14);
            this.gbCover.Name = "gbCover";
            this.gbCover.Size = new System.Drawing.Size(240, 280);
            this.gbCover.TabIndex = 1;
            this.gbCover.TabStop = false;
            this.gbCover.Text = "COVER";
            // 
            // bDel
            // 
            this.bDel.Location = new System.Drawing.Point(204, 242);
            this.bDel.Name = "bDel";
            this.bDel.Size = new System.Drawing.Size(32, 32);
            this.bDel.TabIndex = 2;
            this.bDel.Text = "-";
            this.bDel.UseVisualStyleBackColor = true;
            this.bDel.Click += new System.EventHandler(this.bDel_Click);
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(204, 204);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(32, 32);
            this.bAdd.TabIndex = 1;
            this.bAdd.Text = "+";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // pbCover
            // 
            this.pbCover.Image = global::Liber.Properties.Resources.default_cover;
            this.pbCover.Location = new System.Drawing.Point(6, 19);
            this.pbCover.Name = "pbCover";
            this.pbCover.Size = new System.Drawing.Size(192, 255);
            this.pbCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCover.TabIndex = 0;
            this.pbCover.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.bCancel);
            this.flowLayoutPanel1.Controls.Add(this.bAccept);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 331);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(630, 36);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(544, 7);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 0;
            this.bCancel.Text = "CANCEL";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bAccept
            // 
            this.bAccept.Location = new System.Drawing.Point(463, 7);
            this.bAccept.Name = "bAccept";
            this.bAccept.Size = new System.Drawing.Size(75, 23);
            this.bAccept.TabIndex = 1;
            this.bAccept.Text = "ACCEPT";
            this.bAccept.UseVisualStyleBackColor = true;
            this.bAccept.Click += new System.EventHandler(this.bAccept_Click);
            // 
            // pBack
            // 
            this.pBack.Controls.Add(this.pPrin);
            this.pBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBack.Location = new System.Drawing.Point(0, 0);
            this.pBack.Name = "pBack";
            this.pBack.Padding = new System.Windows.Forms.Padding(12);
            this.pBack.Size = new System.Drawing.Size(630, 331);
            this.pBack.TabIndex = 3;
            // 
            // fMetadata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 367);
            this.Controls.Add(this.pBack);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fMetadata";
            this.ShowInTaskbar = false;
            this.Text = "TITLE";
            this.TopMost = true;
            this.gbMetadata.ResumeLayout(false);
            this.gbMetadata.PerformLayout();
            this.pPrin.ResumeLayout(false);
            this.gbCover.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pBack.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMetadata;
        private System.Windows.Forms.Panel pPrin;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bAccept;
        private System.Windows.Forms.Panel pBack;
        private System.Windows.Forms.TextBox tbAuthor;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label lID;
        private System.Windows.Forms.Label lSaga;
        private System.Windows.Forms.TextBox tbSaga;
        private System.Windows.Forms.Label lAuthor;
        private System.Windows.Forms.ComboBox cbSagaType;
        private System.Windows.Forms.Label lSagaType;
        private System.Windows.Forms.TextBox tbSinopsis;
        private System.Windows.Forms.Label lSinopsis;
        private System.Windows.Forms.ComboBox cbGenre;
        private System.Windows.Forms.Label lGenre;
        private System.Windows.Forms.GroupBox gbCover;
        private System.Windows.Forms.Button bDel;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.PictureBox pbCover;
    }
}