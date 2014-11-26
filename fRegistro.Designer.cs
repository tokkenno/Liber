namespace Liber
{
    partial class fRegistro
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
            this.pTitleInfo = new System.Windows.Forms.Panel();
            this.lReqFields = new System.Windows.Forms.Label();
            this.pRequired = new System.Windows.Forms.Panel();
            this.line1 = new PSLibrary.Controls.Line();
            this.lTitleInfoDesc = new System.Windows.Forms.Label();
            this.lTitleInfo = new System.Windows.Forms.Label();
            this.pPrincipal = new System.Windows.Forms.Panel();
            this.pButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.bClose = new System.Windows.Forms.Button();
            this.bCreate = new System.Windows.Forms.Button();
            this.pSeparator = new System.Windows.Forms.Panel();
            this.bCloseApp = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lPassword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbNickname = new System.Windows.Forms.TextBox();
            this.lNickname = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.MaskedTextBox();
            this.lPermissions = new System.Windows.Forms.Label();
            this.cbPermissions = new System.Windows.Forms.ComboBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.dtBirthDay = new System.Windows.Forms.DateTimePicker();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbDNILetter = new System.Windows.Forms.TextBox();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.lAddress = new System.Windows.Forms.Label();
            this.lBirthDay = new System.Windows.Forms.Label();
            this.lPhone = new System.Windows.Forms.Label();
            this.lLastName = new System.Windows.Forms.Label();
            this.lFirstName = new System.Windows.Forms.Label();
            this.lEmail = new System.Windows.Forms.Label();
            this.lDNI = new System.Windows.Forms.Label();
            this.line2 = new PSLibrary.Controls.Line();
            this.pTitleInfo.SuspendLayout();
            this.pPrincipal.SuspendLayout();
            this.pButtons.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pTitleInfo
            // 
            this.pTitleInfo.BackColor = System.Drawing.Color.White;
            this.pTitleInfo.Controls.Add(this.lReqFields);
            this.pTitleInfo.Controls.Add(this.pRequired);
            this.pTitleInfo.Controls.Add(this.line1);
            this.pTitleInfo.Controls.Add(this.lTitleInfoDesc);
            this.pTitleInfo.Controls.Add(this.lTitleInfo);
            this.pTitleInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTitleInfo.Location = new System.Drawing.Point(0, 0);
            this.pTitleInfo.Name = "pTitleInfo";
            this.pTitleInfo.Size = new System.Drawing.Size(572, 53);
            this.pTitleInfo.TabIndex = 4;
            // 
            // lReqFields
            // 
            this.lReqFields.AutoSize = true;
            this.lReqFields.Location = new System.Drawing.Point(361, 9);
            this.lReqFields.Name = "lReqFields";
            this.lReqFields.Size = new System.Drawing.Size(104, 13);
            this.lReqFields.TabIndex = 4;
            this.lReqFields.Text = "REQUIRED FIELDS";
            // 
            // pRequired
            // 
            this.pRequired.BackColor = System.Drawing.Color.Lavender;
            this.pRequired.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pRequired.Location = new System.Drawing.Point(336, 9);
            this.pRequired.Name = "pRequired";
            this.pRequired.Size = new System.Drawing.Size(19, 13);
            this.pRequired.TabIndex = 3;
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.line1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.line1.Location = new System.Drawing.Point(0, 52);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(572, 1);
            this.line1.TabIndex = 2;
            // 
            // lTitleInfoDesc
            // 
            this.lTitleInfoDesc.AutoSize = true;
            this.lTitleInfoDesc.Location = new System.Drawing.Point(23, 31);
            this.lTitleInfoDesc.Name = "lTitleInfoDesc";
            this.lTitleInfoDesc.Size = new System.Drawing.Size(141, 13);
            this.lTitleInfoDesc.TabIndex = 1;
            this.lTitleInfoDesc.Text = "TITLE INFO DESCRIPTION";
            // 
            // lTitleInfo
            // 
            this.lTitleInfo.AutoSize = true;
            this.lTitleInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitleInfo.Location = new System.Drawing.Point(12, 9);
            this.lTitleInfo.Name = "lTitleInfo";
            this.lTitleInfo.Size = new System.Drawing.Size(75, 13);
            this.lTitleInfo.TabIndex = 0;
            this.lTitleInfo.Text = "TITLE INFO";
            // 
            // pPrincipal
            // 
            this.pPrincipal.Controls.Add(this.pButtons);
            this.pPrincipal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pPrincipal.Location = new System.Drawing.Point(0, 244);
            this.pPrincipal.Name = "pPrincipal";
            this.pPrincipal.Size = new System.Drawing.Size(572, 37);
            this.pPrincipal.TabIndex = 5;
            // 
            // pButtons
            // 
            this.pButtons.Controls.Add(this.bClose);
            this.pButtons.Controls.Add(this.bCreate);
            this.pButtons.Controls.Add(this.pSeparator);
            this.pButtons.Controls.Add(this.bCloseApp);
            this.pButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pButtons.Location = new System.Drawing.Point(0, 0);
            this.pButtons.Name = "pButtons";
            this.pButtons.Padding = new System.Windows.Forms.Padding(5);
            this.pButtons.Size = new System.Drawing.Size(572, 37);
            this.pButtons.TabIndex = 7;
            // 
            // bClose
            // 
            this.bClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bClose.Location = new System.Drawing.Point(484, 8);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(75, 23);
            this.bClose.TabIndex = 10;
            this.bClose.Text = "CLOSE";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bCreate
            // 
            this.bCreate.Location = new System.Drawing.Point(403, 8);
            this.bCreate.Name = "bCreate";
            this.bCreate.Size = new System.Drawing.Size(75, 23);
            this.bCreate.TabIndex = 9;
            this.bCreate.Text = "CREATE";
            this.bCreate.UseVisualStyleBackColor = true;
            this.bCreate.Click += new System.EventHandler(this.bCreate_Click);
            // 
            // pSeparator
            // 
            this.pSeparator.Location = new System.Drawing.Point(175, 8);
            this.pSeparator.Name = "pSeparator";
            this.pSeparator.Size = new System.Drawing.Size(222, 17);
            this.pSeparator.TabIndex = 12;
            // 
            // bCloseApp
            // 
            this.bCloseApp.Location = new System.Drawing.Point(12, 8);
            this.bCloseApp.Name = "bCloseApp";
            this.bCloseApp.Size = new System.Drawing.Size(157, 23);
            this.bCloseApp.TabIndex = 11;
            this.bCloseApp.Text = "CLOSE APPLICATION";
            this.bCloseApp.UseVisualStyleBackColor = true;
            this.bCloseApp.Visible = false;
            this.bCloseApp.Click += new System.EventHandler(this.bCloseApp_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lPassword);
            this.panel1.Controls.Add(this.tbPassword);
            this.panel1.Controls.Add(this.tbNickname);
            this.panel1.Controls.Add(this.lNickname);
            this.panel1.Controls.Add(this.tbPhone);
            this.panel1.Controls.Add(this.lPermissions);
            this.panel1.Controls.Add(this.cbPermissions);
            this.panel1.Controls.Add(this.tbAddress);
            this.panel1.Controls.Add(this.dtBirthDay);
            this.panel1.Controls.Add(this.tbEmail);
            this.panel1.Controls.Add(this.tbLastName);
            this.panel1.Controls.Add(this.tbFirstName);
            this.panel1.Controls.Add(this.tbDNILetter);
            this.panel1.Controls.Add(this.tbDNI);
            this.panel1.Controls.Add(this.lAddress);
            this.panel1.Controls.Add(this.lBirthDay);
            this.panel1.Controls.Add(this.lPhone);
            this.panel1.Controls.Add(this.lLastName);
            this.panel1.Controls.Add(this.lFirstName);
            this.panel1.Controls.Add(this.lEmail);
            this.panel1.Controls.Add(this.lDNI);
            this.panel1.Controls.Add(this.line2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 191);
            this.panel1.TabIndex = 6;
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.Location = new System.Drawing.Point(288, 19);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(70, 13);
            this.lPassword.TabIndex = 15;
            this.lPassword.Text = "PASSWORD";
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.Lavender;
            this.tbPassword.Location = new System.Drawing.Point(399, 16);
            this.tbPassword.MaxLength = 18;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(153, 20);
            this.tbPassword.TabIndex = 14;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // tbNickname
            // 
            this.tbNickname.BackColor = System.Drawing.Color.Lavender;
            this.tbNickname.Location = new System.Drawing.Point(110, 16);
            this.tbNickname.MaxLength = 18;
            this.tbNickname.Name = "tbNickname";
            this.tbNickname.Size = new System.Drawing.Size(153, 20);
            this.tbNickname.TabIndex = 13;
            // 
            // lNickname
            // 
            this.lNickname.AutoSize = true;
            this.lNickname.Location = new System.Drawing.Point(10, 19);
            this.lNickname.Name = "lNickname";
            this.lNickname.Size = new System.Drawing.Size(63, 13);
            this.lNickname.TabIndex = 12;
            this.lNickname.Text = "NICKNAME";
            // 
            // tbPhone
            // 
            this.tbPhone.Culture = new System.Globalization.CultureInfo("");
            this.tbPhone.Location = new System.Drawing.Point(399, 42);
            this.tbPhone.Mask = "(999) 00-00-00";
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(153, 20);
            this.tbPhone.TabIndex = 11;
            this.tbPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lPermissions
            // 
            this.lPermissions.AutoSize = true;
            this.lPermissions.Location = new System.Drawing.Point(83, 158);
            this.lPermissions.Name = "lPermissions";
            this.lPermissions.Size = new System.Drawing.Size(81, 13);
            this.lPermissions.TabIndex = 8;
            this.lPermissions.Text = "PERMISSIONS";
            // 
            // cbPermissions
            // 
            this.cbPermissions.FormattingEnabled = true;
            this.cbPermissions.Location = new System.Drawing.Point(198, 155);
            this.cbPermissions.Name = "cbPermissions";
            this.cbPermissions.Size = new System.Drawing.Size(121, 21);
            this.cbPermissions.TabIndex = 8;
            // 
            // tbAddress
            // 
            this.tbAddress.BackColor = System.Drawing.SystemColors.Window;
            this.tbAddress.Location = new System.Drawing.Point(399, 94);
            this.tbAddress.MaxLength = 60;
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(153, 43);
            this.tbAddress.TabIndex = 7;
            // 
            // dtBirthDay
            // 
            this.dtBirthDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBirthDay.Location = new System.Drawing.Point(399, 68);
            this.dtBirthDay.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dtBirthDay.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtBirthDay.Name = "dtBirthDay";
            this.dtBirthDay.Size = new System.Drawing.Size(153, 20);
            this.dtBirthDay.TabIndex = 6;
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.Lavender;
            this.tbEmail.Location = new System.Drawing.Point(110, 121);
            this.tbEmail.MaxLength = 25;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(153, 20);
            this.tbEmail.TabIndex = 4;
            // 
            // tbLastName
            // 
            this.tbLastName.BackColor = System.Drawing.SystemColors.Window;
            this.tbLastName.Location = new System.Drawing.Point(110, 94);
            this.tbLastName.MaxLength = 35;
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(153, 20);
            this.tbLastName.TabIndex = 3;
            this.tbLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_OL);
            // 
            // tbFirstName
            // 
            this.tbFirstName.BackColor = System.Drawing.Color.Lavender;
            this.tbFirstName.Location = new System.Drawing.Point(110, 68);
            this.tbFirstName.MaxLength = 18;
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(153, 20);
            this.tbFirstName.TabIndex = 2;
            this.tbFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_OL);
            // 
            // tbDNILetter
            // 
            this.tbDNILetter.Location = new System.Drawing.Point(248, 42);
            this.tbDNILetter.MaxLength = 1;
            this.tbDNILetter.Name = "tbDNILetter";
            this.tbDNILetter.ReadOnly = true;
            this.tbDNILetter.Size = new System.Drawing.Size(15, 20);
            this.tbDNILetter.TabIndex = 10;
            // 
            // tbDNI
            // 
            this.tbDNI.BackColor = System.Drawing.Color.Lavender;
            this.tbDNI.Location = new System.Drawing.Point(110, 42);
            this.tbDNI.MaxLength = 8;
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(132, 20);
            this.tbDNI.TabIndex = 1;
            this.tbDNI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbDNI.TextChanged += new System.EventHandler(this.tbDNI_TextChanged);
            this.tbDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_ON);
            // 
            // lAddress
            // 
            this.lAddress.AutoSize = true;
            this.lAddress.Location = new System.Drawing.Point(288, 97);
            this.lAddress.Name = "lAddress";
            this.lAddress.Size = new System.Drawing.Size(59, 13);
            this.lAddress.TabIndex = 7;
            this.lAddress.Text = "ADDRESS";
            // 
            // lBirthDay
            // 
            this.lBirthDay.AutoSize = true;
            this.lBirthDay.Location = new System.Drawing.Point(288, 71);
            this.lBirthDay.Name = "lBirthDay";
            this.lBirthDay.Size = new System.Drawing.Size(62, 13);
            this.lBirthDay.TabIndex = 6;
            this.lBirthDay.Text = "BIRTHDAY";
            // 
            // lPhone
            // 
            this.lPhone.AutoSize = true;
            this.lPhone.Location = new System.Drawing.Point(288, 45);
            this.lPhone.Name = "lPhone";
            this.lPhone.Size = new System.Drawing.Size(45, 13);
            this.lPhone.TabIndex = 5;
            this.lPhone.Text = "PHONE";
            // 
            // lLastName
            // 
            this.lLastName.AutoSize = true;
            this.lLastName.Location = new System.Drawing.Point(10, 97);
            this.lLastName.Name = "lLastName";
            this.lLastName.Size = new System.Drawing.Size(65, 13);
            this.lLastName.TabIndex = 4;
            this.lLastName.Text = "LASTNAME";
            // 
            // lFirstName
            // 
            this.lFirstName.AutoSize = true;
            this.lFirstName.Location = new System.Drawing.Point(10, 71);
            this.lFirstName.Name = "lFirstName";
            this.lFirstName.Size = new System.Drawing.Size(69, 13);
            this.lFirstName.TabIndex = 3;
            this.lFirstName.Text = "FIRSTNAME";
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Location = new System.Drawing.Point(10, 124);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(39, 13);
            this.lEmail.TabIndex = 2;
            this.lEmail.Text = "EMAIL";
            // 
            // lDNI
            // 
            this.lDNI.AutoSize = true;
            this.lDNI.Location = new System.Drawing.Point(10, 45);
            this.lDNI.Name = "lDNI";
            this.lDNI.Size = new System.Drawing.Size(26, 13);
            this.lDNI.TabIndex = 1;
            this.lDNI.Text = "DNI";
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.line2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.line2.Location = new System.Drawing.Point(0, 190);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(572, 1);
            this.line2.TabIndex = 0;
            // 
            // fRegistro
            // 
            this.AcceptButton = this.bCreate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bClose;
            this.ClientSize = new System.Drawing.Size(572, 281);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pPrincipal);
            this.Controls.Add(this.pTitleInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fRegistro";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "fRegistro";
            this.pTitleInfo.ResumeLayout(false);
            this.pTitleInfo.PerformLayout();
            this.pPrincipal.ResumeLayout(false);
            this.pButtons.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pTitleInfo;
        private PSLibrary.Controls.Line line1;
        private System.Windows.Forms.Label lTitleInfoDesc;
        private System.Windows.Forms.Label lTitleInfo;
        private System.Windows.Forms.Panel pPrincipal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel pButtons;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button bCreate;
        private PSLibrary.Controls.Line line2;
        private System.Windows.Forms.Label lReqFields;
        private System.Windows.Forms.Panel pRequired;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbDNILetter;
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.Label lPermissions;
        private System.Windows.Forms.Label lAddress;
        private System.Windows.Forms.Label lBirthDay;
        private System.Windows.Forms.Label lPhone;
        private System.Windows.Forms.Label lLastName;
        private System.Windows.Forms.Label lFirstName;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.Label lDNI;
        private System.Windows.Forms.DateTimePicker dtBirthDay;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.MaskedTextBox tbPhone;
        private System.Windows.Forms.ComboBox cbPermissions;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbNickname;
        private System.Windows.Forms.Label lNickname;
        private System.Windows.Forms.Panel pSeparator;
        private System.Windows.Forms.Button bCloseApp;
    }
}