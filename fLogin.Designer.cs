namespace Liber
{
    partial class fLogin
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lUsername = new System.Windows.Forms.Label();
            this.bExit = new System.Windows.Forms.Button();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.pTitleInfo = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.line1 = new PSLibrary.Controls.Line();
            this.lTitleInfoDesc = new System.Windows.Forms.Label();
            this.lTitleInfo = new System.Windows.Forms.Label();
            this.lPassword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.pButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.bInit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.pLogin = new System.Windows.Forms.Panel();
            this.line2 = new PSLibrary.Controls.Line();
            this.lCreateAc = new System.Windows.Forms.LinkLabel();
            this.pTitleInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pButtons.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lUsername
            // 
            this.lUsername.AutoSize = true;
            this.lUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUsername.Location = new System.Drawing.Point(14, 20);
            this.lUsername.Name = "lUsername";
            this.lUsername.Size = new System.Drawing.Size(41, 15);
            this.lUsername.TabIndex = 0;
            this.lUsername.Text = "USER";
            // 
            // bExit
            // 
            this.bExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bExit.Location = new System.Drawing.Point(300, 8);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(75, 23);
            this.bExit.TabIndex = 1;
            this.bExit.Text = "EXIT";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // tbUsername
            // 
            this.tbUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.tbUsername.Location = new System.Drawing.Point(147, 19);
            this.tbUsername.MaxLength = 22;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(231, 20);
            this.tbUsername.TabIndex = 2;
            this.tbUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pTitleInfo
            // 
            this.pTitleInfo.BackColor = System.Drawing.Color.White;
            this.pTitleInfo.Controls.Add(this.pbLogo);
            this.pTitleInfo.Controls.Add(this.line1);
            this.pTitleInfo.Controls.Add(this.lTitleInfoDesc);
            this.pTitleInfo.Controls.Add(this.lTitleInfo);
            this.pTitleInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTitleInfo.Location = new System.Drawing.Point(0, 0);
            this.pTitleInfo.Name = "pTitleInfo";
            this.pTitleInfo.Size = new System.Drawing.Size(388, 70);
            this.pTitleInfo.TabIndex = 3;
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbLogo.Image = global::Liber.Properties.Resources.logo_64;
            this.pbLogo.Location = new System.Drawing.Point(3, 3);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(64, 64);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 3;
            this.pbLogo.TabStop = false;
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.line1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.line1.Location = new System.Drawing.Point(0, 69);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(388, 1);
            this.line1.TabIndex = 2;
            // 
            // lTitleInfoDesc
            // 
            this.lTitleInfoDesc.AutoSize = true;
            this.lTitleInfoDesc.Location = new System.Drawing.Point(84, 31);
            this.lTitleInfoDesc.Name = "lTitleInfoDesc";
            this.lTitleInfoDesc.Size = new System.Drawing.Size(141, 13);
            this.lTitleInfoDesc.TabIndex = 1;
            this.lTitleInfoDesc.Text = "TITLE INFO DESCRIPTION";
            // 
            // lTitleInfo
            // 
            this.lTitleInfo.AutoSize = true;
            this.lTitleInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitleInfo.Location = new System.Drawing.Point(73, 9);
            this.lTitleInfo.Name = "lTitleInfo";
            this.lTitleInfo.Size = new System.Drawing.Size(75, 13);
            this.lTitleInfo.TabIndex = 0;
            this.lTitleInfo.Text = "TITLE INFO";
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPassword.Location = new System.Drawing.Point(14, 46);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(76, 15);
            this.lPassword.TabIndex = 4;
            this.lPassword.Text = "PASSWORD";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(147, 45);
            this.tbPassword.MaxLength = 22;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(231, 20);
            this.tbPassword.TabIndex = 5;
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // pButtons
            // 
            this.pButtons.Controls.Add(this.bExit);
            this.pButtons.Controls.Add(this.bInit);
            this.pButtons.Controls.Add(this.panel1);
            this.pButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pButtons.Location = new System.Drawing.Point(0, 181);
            this.pButtons.Name = "pButtons";
            this.pButtons.Padding = new System.Windows.Forms.Padding(5);
            this.pButtons.Size = new System.Drawing.Size(388, 38);
            this.pButtons.TabIndex = 6;
            // 
            // bInit
            // 
            this.bInit.Location = new System.Drawing.Point(219, 8);
            this.bInit.Name = "bInit";
            this.bInit.Size = new System.Drawing.Size(75, 23);
            this.bInit.TabIndex = 2;
            this.bInit.Text = "INIT";
            this.bInit.UseVisualStyleBackColor = true;
            this.bInit.Click += new System.EventHandler(this.bInit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbLanguage);
            this.panel1.Location = new System.Drawing.Point(12, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 23);
            this.panel1.TabIndex = 3;
            // 
            // cbLanguage
            // 
            this.cbLanguage.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.Location = new System.Drawing.Point(0, 0);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(117, 21);
            this.cbLanguage.TabIndex = 3;
            this.cbLanguage.SelectedIndexChanged += new System.EventHandler(this.cbLanguage_SelectedIndexChanged);
            // 
            // pLogin
            // 
            this.pLogin.Controls.Add(this.lCreateAc);
            this.pLogin.Controls.Add(this.line2);
            this.pLogin.Controls.Add(this.lUsername);
            this.pLogin.Controls.Add(this.tbUsername);
            this.pLogin.Controls.Add(this.tbPassword);
            this.pLogin.Controls.Add(this.lPassword);
            this.pLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pLogin.Location = new System.Drawing.Point(0, 70);
            this.pLogin.Name = "pLogin";
            this.pLogin.Size = new System.Drawing.Size(388, 111);
            this.pLogin.TabIndex = 7;
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.line2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.line2.Location = new System.Drawing.Point(0, 110);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(388, 1);
            this.line2.TabIndex = 6;
            // 
            // lCreateAc
            // 
            this.lCreateAc.AutoSize = true;
            this.lCreateAc.Location = new System.Drawing.Point(14, 95);
            this.lCreateAc.Name = "lCreateAc";
            this.lCreateAc.Size = new System.Drawing.Size(105, 13);
            this.lCreateAc.TabIndex = 7;
            this.lCreateAc.TabStop = true;
            this.lCreateAc.Text = "CREATE ACCOUNT";
            this.lCreateAc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lCreateAc_LinkClicked);
            // 
            // fLogin
            // 
            this.AcceptButton = this.bInit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bExit;
            this.ClientSize = new System.Drawing.Size(388, 219);
            this.Controls.Add(this.pLogin);
            this.Controls.Add(this.pButtons);
            this.Controls.Add(this.pTitleInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.pTitleInfo.ResumeLayout(false);
            this.pTitleInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pButtons.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pLogin.ResumeLayout(false);
            this.pLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lUsername;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Panel pTitleInfo;
        private PSLibrary.Controls.Line line1;
        private System.Windows.Forms.Label lTitleInfoDesc;
        private System.Windows.Forms.Label lTitleInfo;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.FlowLayoutPanel pButtons;
        private System.Windows.Forms.Button bInit;
        private System.Windows.Forms.Panel pLogin;
        private PSLibrary.Controls.Line line2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbLanguage;
        private System.Windows.Forms.LinkLabel lCreateAc;
    }
}

