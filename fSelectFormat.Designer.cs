namespace Liber
{
    partial class fSelectFormat
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bCancel = new System.Windows.Forms.Button();
            this.bAccept = new System.Windows.Forms.Button();
            this.gbInformation = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbSelectFormat = new System.Windows.Forms.ComboBox();
            this.lInfo = new System.Windows.Forms.TextBox();
            this.pBack.SuspendLayout();
            this.pPrin.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.gbInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pBack
            // 
            this.pBack.Controls.Add(this.pPrin);
            this.pBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBack.Location = new System.Drawing.Point(0, 0);
            this.pBack.Name = "pBack";
            this.pBack.Padding = new System.Windows.Forms.Padding(12);
            this.pBack.Size = new System.Drawing.Size(350, 94);
            this.pBack.TabIndex = 5;
            // 
            // pPrin
            // 
            this.pPrin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pPrin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pPrin.Controls.Add(this.gbInformation);
            this.pPrin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPrin.Location = new System.Drawing.Point(12, 12);
            this.pPrin.Name = "pPrin";
            this.pPrin.Padding = new System.Windows.Forms.Padding(3);
            this.pPrin.Size = new System.Drawing.Size(326, 70);
            this.pPrin.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.bCancel);
            this.flowLayoutPanel1.Controls.Add(this.bAccept);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.cbSelectFormat);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 94);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(350, 36);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(264, 7);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 0;
            this.bCancel.Text = "CANCEL";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bAccept
            // 
            this.bAccept.Location = new System.Drawing.Point(183, 7);
            this.bAccept.Name = "bAccept";
            this.bAccept.Size = new System.Drawing.Size(75, 23);
            this.bAccept.TabIndex = 1;
            this.bAccept.Text = "ACCEPT";
            this.bAccept.UseVisualStyleBackColor = true;
            this.bAccept.Click += new System.EventHandler(this.bAccept_Click);
            // 
            // gbInformation
            // 
            this.gbInformation.Controls.Add(this.lInfo);
            this.gbInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbInformation.Location = new System.Drawing.Point(3, 3);
            this.gbInformation.Name = "gbInformation";
            this.gbInformation.Size = new System.Drawing.Size(318, 62);
            this.gbInformation.TabIndex = 0;
            this.gbInformation.TabStop = false;
            this.gbInformation.Text = "INFO";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(139, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(38, 22);
            this.panel1.TabIndex = 2;
            // 
            // cbSelectFormat
            // 
            this.cbSelectFormat.FormattingEnabled = true;
            this.cbSelectFormat.Location = new System.Drawing.Point(12, 7);
            this.cbSelectFormat.Name = "cbSelectFormat";
            this.cbSelectFormat.Size = new System.Drawing.Size(121, 21);
            this.cbSelectFormat.TabIndex = 3;
            // 
            // lInfo
            // 
            this.lInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lInfo.Location = new System.Drawing.Point(3, 16);
            this.lInfo.Multiline = true;
            this.lInfo.Name = "lInfo";
            this.lInfo.Size = new System.Drawing.Size(312, 43);
            this.lInfo.TabIndex = 0;
            // 
            // fSelectFormat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 130);
            this.Controls.Add(this.pBack);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fSelectFormat";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SELECT FORMAT";
            this.pBack.ResumeLayout(false);
            this.pPrin.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.gbInformation.ResumeLayout(false);
            this.gbInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pBack;
        private System.Windows.Forms.Panel pPrin;
        private System.Windows.Forms.GroupBox gbInformation;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bAccept;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbSelectFormat;
        private System.Windows.Forms.TextBox lInfo;
    }
}