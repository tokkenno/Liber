namespace Liber
{
    partial class fAuthorInfo
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
            this.pBack = new System.Windows.Forms.Panel();
            this.pPrin = new System.Windows.Forms.Panel();
            this.gbAuthorInfo = new System.Windows.Forms.GroupBox();
            this.lDeadDate = new System.Windows.Forms.Label();
            this.lBirthDate = new System.Windows.Forms.Label();
            this.lLastName = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFisrtName = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.Label();
            this.pButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.bCancel = new System.Windows.Forms.Button();
            this.bAccept = new System.Windows.Forms.Button();
            this.dtpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.dtpDeadDate = new System.Windows.Forms.DateTimePicker();
            this.pBack.SuspendLayout();
            this.pPrin.SuspendLayout();
            this.gbAuthorInfo.SuspendLayout();
            this.pButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pBack
            // 
            this.pBack.Controls.Add(this.pPrin);
            this.pBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBack.Location = new System.Drawing.Point(0, 0);
            this.pBack.Name = "pBack";
            this.pBack.Padding = new System.Windows.Forms.Padding(12);
            this.pBack.Size = new System.Drawing.Size(396, 189);
            this.pBack.TabIndex = 5;
            // 
            // pPrin
            // 
            this.pPrin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pPrin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pPrin.Controls.Add(this.gbAuthorInfo);
            this.pPrin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPrin.Location = new System.Drawing.Point(12, 12);
            this.pPrin.Name = "pPrin";
            this.pPrin.Size = new System.Drawing.Size(372, 165);
            this.pPrin.TabIndex = 1;
            // 
            // gbAuthorInfo
            // 
            this.gbAuthorInfo.Controls.Add(this.dtpDeadDate);
            this.gbAuthorInfo.Controls.Add(this.dtpBirthdate);
            this.gbAuthorInfo.Controls.Add(this.lDeadDate);
            this.gbAuthorInfo.Controls.Add(this.lBirthDate);
            this.gbAuthorInfo.Controls.Add(this.lLastName);
            this.gbAuthorInfo.Controls.Add(this.tbLastName);
            this.gbAuthorInfo.Controls.Add(this.tbFisrtName);
            this.gbAuthorInfo.Controls.Add(this.lName);
            this.gbAuthorInfo.Location = new System.Drawing.Point(13, 14);
            this.gbAuthorInfo.Name = "gbAuthorInfo";
            this.gbAuthorInfo.Size = new System.Drawing.Size(342, 139);
            this.gbAuthorInfo.TabIndex = 0;
            this.gbAuthorInfo.TabStop = false;
            this.gbAuthorInfo.Text = "AUTHOR INFO";
            // 
            // lDeadDate
            // 
            this.lDeadDate.AutoSize = true;
            this.lDeadDate.Location = new System.Drawing.Point(17, 109);
            this.lDeadDate.Name = "lDeadDate";
            this.lDeadDate.Size = new System.Drawing.Size(69, 13);
            this.lDeadDate.TabIndex = 7;
            this.lDeadDate.Text = "DEAD DATE";
            // 
            // lBirthDate
            // 
            this.lBirthDate.AutoSize = true;
            this.lBirthDate.Location = new System.Drawing.Point(17, 83);
            this.lBirthDate.Name = "lBirthDate";
            this.lBirthDate.Size = new System.Drawing.Size(69, 13);
            this.lBirthDate.TabIndex = 5;
            this.lBirthDate.Text = "BIRTHDATE";
            // 
            // lLastName
            // 
            this.lLastName.AutoSize = true;
            this.lLastName.Location = new System.Drawing.Point(17, 54);
            this.lLastName.Name = "lLastName";
            this.lLastName.Size = new System.Drawing.Size(65, 13);
            this.lLastName.TabIndex = 3;
            this.lLastName.Text = "LASTNAME";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(123, 51);
            this.tbLastName.MaxLength = 60;
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(200, 20);
            this.tbLastName.TabIndex = 2;
            // 
            // tbFisrtName
            // 
            this.tbFisrtName.Location = new System.Drawing.Point(123, 25);
            this.tbFisrtName.Name = "tbFisrtName";
            this.tbFisrtName.Size = new System.Drawing.Size(200, 20);
            this.tbFisrtName.TabIndex = 1;
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(17, 28);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(38, 13);
            this.lName.TabIndex = 0;
            this.lName.Text = "NAME";
            // 
            // pButtons
            // 
            this.pButtons.Controls.Add(this.bCancel);
            this.pButtons.Controls.Add(this.bAccept);
            this.pButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pButtons.Location = new System.Drawing.Point(0, 189);
            this.pButtons.Name = "pButtons";
            this.pButtons.Padding = new System.Windows.Forms.Padding(4);
            this.pButtons.Size = new System.Drawing.Size(396, 36);
            this.pButtons.TabIndex = 4;
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(310, 7);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 0;
            this.bCancel.Text = "CANCEL";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bAccept
            // 
            this.bAccept.Location = new System.Drawing.Point(229, 7);
            this.bAccept.Name = "bAccept";
            this.bAccept.Size = new System.Drawing.Size(75, 23);
            this.bAccept.TabIndex = 1;
            this.bAccept.Text = "ACCEPT";
            this.bAccept.UseVisualStyleBackColor = true;
            this.bAccept.Click += new System.EventHandler(this.bAccept_Click);
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.Location = new System.Drawing.Point(123, 77);
            this.dtpBirthdate.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new System.Drawing.Size(200, 20);
            this.dtpBirthdate.TabIndex = 8;
            this.dtpBirthdate.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // dtpDeadDate
            // 
            this.dtpDeadDate.Location = new System.Drawing.Point(123, 103);
            this.dtpDeadDate.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dtpDeadDate.Name = "dtpDeadDate";
            this.dtpDeadDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDeadDate.TabIndex = 9;
            this.dtpDeadDate.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // fAuthorInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 225);
            this.Controls.Add(this.pBack);
            this.Controls.Add(this.pButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fAuthorInfo";
            this.ShowInTaskbar = false;
            this.Text = "TITLE";
            this.TopMost = true;
            this.pBack.ResumeLayout(false);
            this.pPrin.ResumeLayout(false);
            this.gbAuthorInfo.ResumeLayout(false);
            this.gbAuthorInfo.PerformLayout();
            this.pButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pBack;
        private System.Windows.Forms.Panel pPrin;
        private System.Windows.Forms.GroupBox gbAuthorInfo;
        private System.Windows.Forms.Label lDeadDate;
        private System.Windows.Forms.Label lBirthDate;
        private System.Windows.Forms.Label lLastName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFisrtName;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.FlowLayoutPanel pButtons;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bAccept;
        private System.Windows.Forms.DateTimePicker dtpDeadDate;
        private System.Windows.Forms.DateTimePicker dtpBirthdate;
    }
}