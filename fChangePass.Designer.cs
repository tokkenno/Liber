namespace Liber
{
    partial class fChangePass
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
            this.gbChangePass = new System.Windows.Forms.GroupBox();
            this.lReNewPass = new System.Windows.Forms.Label();
            this.tbReNewPass = new System.Windows.Forms.TextBox();
            this.lNewPass = new System.Windows.Forms.Label();
            this.tbNewPass = new System.Windows.Forms.TextBox();
            this.lOldPass = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bCancel = new System.Windows.Forms.Button();
            this.bAccept = new System.Windows.Forms.Button();
            this.tbOldPass = new System.Windows.Forms.TextBox();
            this.pBack.SuspendLayout();
            this.pPrin.SuspendLayout();
            this.gbChangePass.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pBack
            // 
            this.pBack.Controls.Add(this.pPrin);
            this.pBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBack.Location = new System.Drawing.Point(0, 0);
            this.pBack.Name = "pBack";
            this.pBack.Padding = new System.Windows.Forms.Padding(12);
            this.pBack.Size = new System.Drawing.Size(399, 156);
            this.pBack.TabIndex = 5;
            // 
            // pPrin
            // 
            this.pPrin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pPrin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pPrin.Controls.Add(this.gbChangePass);
            this.pPrin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPrin.Location = new System.Drawing.Point(12, 12);
            this.pPrin.Name = "pPrin";
            this.pPrin.Size = new System.Drawing.Size(375, 132);
            this.pPrin.TabIndex = 1;
            // 
            // gbChangePass
            // 
            this.gbChangePass.Controls.Add(this.tbOldPass);
            this.gbChangePass.Controls.Add(this.lReNewPass);
            this.gbChangePass.Controls.Add(this.tbReNewPass);
            this.gbChangePass.Controls.Add(this.lNewPass);
            this.gbChangePass.Controls.Add(this.tbNewPass);
            this.gbChangePass.Controls.Add(this.lOldPass);
            this.gbChangePass.Location = new System.Drawing.Point(13, 14);
            this.gbChangePass.Name = "gbChangePass";
            this.gbChangePass.Size = new System.Drawing.Size(347, 110);
            this.gbChangePass.TabIndex = 0;
            this.gbChangePass.TabStop = false;
            this.gbChangePass.Text = "CHANGE PASSWORD";
            // 
            // lReNewPass
            // 
            this.lReNewPass.AutoSize = true;
            this.lReNewPass.Location = new System.Drawing.Point(17, 80);
            this.lReNewPass.Name = "lReNewPass";
            this.lReNewPass.Size = new System.Drawing.Size(145, 13);
            this.lReNewPass.TabIndex = 5;
            this.lReNewPass.Text = "RETYPE NEW PASSWORD";
            // 
            // tbReNewPass
            // 
            this.tbReNewPass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.tbReNewPass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbReNewPass.Location = new System.Drawing.Point(170, 77);
            this.tbReNewPass.MaxLength = 22;
            this.tbReNewPass.Name = "tbReNewPass";
            this.tbReNewPass.Size = new System.Drawing.Size(171, 20);
            this.tbReNewPass.TabIndex = 4;
            this.tbReNewPass.UseSystemPasswordChar = true;
            // 
            // lNewPass
            // 
            this.lNewPass.AutoSize = true;
            this.lNewPass.Location = new System.Drawing.Point(17, 54);
            this.lNewPass.Name = "lNewPass";
            this.lNewPass.Size = new System.Drawing.Size(99, 13);
            this.lNewPass.TabIndex = 3;
            this.lNewPass.Text = "NEW PASSWORD";
            // 
            // tbNewPass
            // 
            this.tbNewPass.Location = new System.Drawing.Point(170, 51);
            this.tbNewPass.MaxLength = 22;
            this.tbNewPass.Name = "tbNewPass";
            this.tbNewPass.Size = new System.Drawing.Size(171, 20);
            this.tbNewPass.TabIndex = 2;
            this.tbNewPass.UseSystemPasswordChar = true;
            // 
            // lOldPass
            // 
            this.lOldPass.AutoSize = true;
            this.lOldPass.Location = new System.Drawing.Point(17, 28);
            this.lOldPass.Name = "lOldPass";
            this.lOldPass.Size = new System.Drawing.Size(95, 13);
            this.lOldPass.TabIndex = 0;
            this.lOldPass.Text = "OLD PASSWORD";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.bCancel);
            this.flowLayoutPanel1.Controls.Add(this.bAccept);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 156);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(399, 36);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(313, 7);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 0;
            this.bCancel.Text = "CANCEL";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bAccept
            // 
            this.bAccept.Location = new System.Drawing.Point(232, 7);
            this.bAccept.Name = "bAccept";
            this.bAccept.Size = new System.Drawing.Size(75, 23);
            this.bAccept.TabIndex = 1;
            this.bAccept.Text = "ACCEPT";
            this.bAccept.UseVisualStyleBackColor = true;
            this.bAccept.Click += new System.EventHandler(this.bAccept_Click);
            // 
            // tbOldPass
            // 
            this.tbOldPass.Location = new System.Drawing.Point(170, 25);
            this.tbOldPass.MaxLength = 22;
            this.tbOldPass.Name = "tbOldPass";
            this.tbOldPass.Size = new System.Drawing.Size(171, 20);
            this.tbOldPass.TabIndex = 6;
            this.tbOldPass.UseSystemPasswordChar = true;
            // 
            // fChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 192);
            this.Controls.Add(this.pBack);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fChangePass";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "fChangePass";
            this.pBack.ResumeLayout(false);
            this.pPrin.ResumeLayout(false);
            this.gbChangePass.ResumeLayout(false);
            this.gbChangePass.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pBack;
        private System.Windows.Forms.Panel pPrin;
        private System.Windows.Forms.GroupBox gbChangePass;
        private System.Windows.Forms.TextBox tbOldPass;
        private System.Windows.Forms.Label lReNewPass;
        private System.Windows.Forms.TextBox tbReNewPass;
        private System.Windows.Forms.Label lNewPass;
        private System.Windows.Forms.TextBox tbNewPass;
        private System.Windows.Forms.Label lOldPass;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bAccept;
    }
}