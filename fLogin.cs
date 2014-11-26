using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PSLibrary.G11N;
using PSLibrary.Debug;

namespace Liber
{
    public partial class fLogin : Form
    {
        private Int32 selected = 0;

        public fLogin()
        {
            // Poner a false para ocultar la consola de debug
            Debug.ShowGUI = Preferences.CONSOLEDEBUG;
            // Poner a false para no escribir el archivo de debug
            Debug.ShowFile = Preferences.FILEDEBUG;

            Init_DB.CheckandCreate();
            Init_Files.CheckandCreate();

            InitializeComponent();

            this.Icon = Properties.Resources.icon;

            setText();

            while (dbgestor.user.numAdmin() == 0)
            {
                new fRegistro(false, true).ShowDialog();
            }
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bInit_Click(object sender, EventArgs e)
        {
            Boolean correct = false;
            li_user usuario = null;

            foreach (li_user usr in dbgestor.user.listUser())
            {
                if (usr.nickname == this.tbUsername.Text)
                {
                    if (usr.passwd == this.tbPassword.Text)
                    {
                        correct = true;
                        usuario = usr;
                        break;
                    }
                }
            }

            if (correct)
            {
                this.Hide();
                new fPrincipal(usuario).ShowDialog();
                this.tbPassword.Text = String.Empty;
                this.Show();
            }
            else
            {
                MessageBox.Show(g11n.getTranslateString("User or Password is incorrect."), g11n.getTranslateString("Login Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setText()
        {
            this.Text = "Liber - " + g11n.getTranslateString("Sign In");
            this.lTitleInfo.Text = g11n.getTranslateString("Sign In to Liber");
            this.lTitleInfoDesc.Text = g11n.getTranslateString("Enter your username and your password.");
            this.lUsername.Text = g11n.getTranslateString("Username:");
            this.lPassword.Text = g11n.getTranslateString("Password:");
            this.lCreateAc.Text = g11n.getTranslateString("Create acount");
            this.bInit.Text = g11n.getTranslateString("Init");
            this.bExit.Text = g11n.getTranslateString("Exit");

            this.cbLanguage.Items.Clear();
            for (Int32 i = 0; i < constants.langs.Length; i++)
            {
                this.cbLanguage.Items.Add(g11n.getTranslateString(constants.langsString[i]));
            }
            this.cbLanguage.SelectedIndex = selected;
        }

        private void cbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLanguage.SelectedIndex == selected)
                return;

            selected = cbLanguage.SelectedIndex;

            g11n.ChangeLanguage(constants.langs[this.cbLanguage.SelectedIndex]);

            setText();
        }

        private void lCreateAc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new fRegistro(true, false).ShowDialog();
        }
    }
}
