using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PSLibrary.G11N;

namespace Liber
{
    public partial class fChangePass : Form
    {
        private li_user usr;
        private fPreferencias fPref;

        public fChangePass(li_user usr, fPreferencias fPref)
        {
            InitializeComponent();

            this.usr = usr;
            this.fPref = fPref;

            setText();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bAccept_Click(object sender, EventArgs e)
        {
            if (this.tbOldPass.Text.Length == 0 || (this.tbNewPass.Text.Length == 0 && this.tbReNewPass.Text.Length == 0))
                return;

            if (this.tbOldPass.Text.Length < 6 || usr.passwd != this.tbOldPass.Text)
            {
                MessageBox.Show(g11n.getTranslateString("The old password is incorrect."), g11n.getTranslateString("Password Error"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (this.tbNewPass.Text != this.tbReNewPass.Text)
            {
                MessageBox.Show(g11n.getTranslateString("New passwords do not match."), g11n.getTranslateString("Password Error"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (this.tbNewPass.Text.Length < 6)
            {
                MessageBox.Show(g11n.getTranslateString("New passwords are too short."), g11n.getTranslateString("Password Error"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            fPref.NEWPASSWORD = this.tbNewPass.Text;
            MessageBox.Show(g11n.getTranslateString("Password has been changed successfully."), g11n.getTranslateString("Password correct"), MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void setText()
        {
            this.Text = g11n.getTranslateString("Change Password");

            this.lOldPass.Text = g11n.getTranslateString("Old Password:");
            this.lNewPass.Text = g11n.getTranslateString("New Password:");
            this.lReNewPass.Text = g11n.getTranslateString("Retype Password:");

            this.bAccept.Text = g11n.getTranslateString("Accept");
            this.bCancel.Text = g11n.getTranslateString("Cancel");
        }
    }
}
