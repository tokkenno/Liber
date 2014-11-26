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
    public partial class fPreferencias : Form
    {
        private li_user actualUser;

        private String newPassword = String.Empty;

        public fPreferencias(li_user user)
        {
            InitializeComponent();

            this.actualUser = user;

            if (this.actualUser.typeu == "simpleuser")
            {
                this.tcPreferencias.TabPages.Remove(this.tpAdvPref);
                this.bRegisAdmin.Visible = false;
            }
            else
            {
                LoadAdminPref();
            }

            LoadUserPref();

            setText();
        }

        private void setText()
        {
            this.Text = g11n.getTranslateString("Preferences");

            this.tpAdvPref.Text = g11n.getTranslateString("Advanced preferences");
            this.gbDebug.Text = g11n.getTranslateString("Debug Options");
            this.cbFileDebug.Text = g11n.getTranslateString("Save Debug File");
            this.cbConsoleDebug.Text = g11n.getTranslateString("Show Debug Console");
            this.gbActions.Text = g11n.getTranslateString("Actions");
            this.bCompactDatabase.Text = g11n.getTranslateString("Compact Database");
            this.bRegisAdmin.Text = g11n.getTranslateString("Registrate Admin");
            this.gbDownloads.Text = g11n.getTranslateString("Downloads");
            this.cbDownloads.Text = g11n.getTranslateString("Allow the Downloads");
            this.gbDatabaseInfo.Text = g11n.getTranslateString("Database Size");

            this.tpPrefBasic.Text = g11n.getTranslateString("Basic preferences");
            this.gbFormat.Text = g11n.getTranslateString("Predefinied Format");
            this.gbLang.Text = g11n.getTranslateString("Predefinied Language");
            this.gbActionsBasic.Text = g11n.getTranslateString("Actions");
            this.bChangePassword.Text = g11n.getTranslateString("Change Password");
            this.bRestartStat.Text = g11n.getTranslateString("Restore User Statistics");
            this.gbOthers.Text = g11n.getTranslateString("Other Preferences");
            this.cbDynamicSearch.Text = g11n.getTranslateString("Dynamic Search");

            this.tTips.SetToolTip(this.gbFormat, g11n.getTranslateString("Preferred format to view books."));
            this.tTips.SetToolTip(this.cbFormat, g11n.getTranslateString("Preferred format to view books."));
            this.tTips.SetToolTip(this.bRestartStat, g11n.getTranslateString("Restart the count readings and puntuation for all books."));
            this.tTips.SetToolTip(this.cbDynamicSearch, g11n.getTranslateString("Liber will find the books while you type."));
            this.tTips.SetToolTip(this.bCompactDatabase, g11n.getTranslateString("Liber will check incoherences in database and will fix it."));

            this.bOk.Text = g11n.getTranslateString("Accept");
            this.bCancel.Text = g11n.getTranslateString("Cancel");
        }

        private void LoadAdminPref()
        {
            this.cbConsoleDebug.Checked = Preferences.CONSOLEDEBUG;
            this.cbFileDebug.Checked = Preferences.FILEDEBUG;
            this.cbDownloads.Checked = Preferences.ALLOWDOWNLOADS;

            String tamanhoImg = (Math.Round((double)(PSLibrary.Utils.IO.DirectoryInfo.CalculateFolderSize("./db/img") / 1024) / 1024, 2)).ToString();
            String tamanhoFiles = (Math.Round((double)(PSLibrary.Utils.IO.DirectoryInfo.CalculateFolderSize("./db/files") / 1024) / 1024, 2)).ToString();

            this.lCoversSize.Text = g11n.getTranslateString("Covers size:") + " " + tamanhoImg + " Mb";
            this.lBookSize.Text = g11n.getTranslateString("Books size:") + " " + tamanhoFiles + " Mb";
        }

        private void LoadUserPref()
        {
            li_basic_preferences bPref = dbgestor.preferences.getPreferencesByDNI(actualUser.DNI);

            this.cbFormat.Items.Clear();
            for (Int32 i = 0; i < constants.formats.Length; i++)
            {
                this.cbFormat.Items.Add(constants.formats[i]);

                if (bPref.US_formatp == constants.formats[i])
                    this.cbFormat.SelectedIndex = i;
            }

            this.cbLang.Items.Clear();
            this.cbLang.Items.Add(g11n.getTranslateString("Predefined"));
            if (bPref.US_lang == null)
                this.cbLang.SelectedIndex = 0;
            for (Int32 i = 0; i < constants.langs.Length; i++)
            {
                this.cbLang.Items.Add(constants.langsString[i]);

                if (bPref.US_lang != null)
                    if (bPref.US_lang == Enum.GetName(typeof(g11n.Languages), constants.langs[i]))
                        this.cbFormat.SelectedIndex = i + 1;
            }

            this.cbDynamicSearch.Checked = bPref.US_dinamics;
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            // Guardamos preferencias avanzadas
            if (this.actualUser.typeu != "simpleuser")
            {
                Preferences.CONSOLEDEBUG = this.cbConsoleDebug.Checked;
                Preferences.FILEDEBUG = this.cbFileDebug.Checked;
                Preferences.ALLOWDOWNLOADS = this.cbDownloads.Checked;
                Preferences.Save();
            }

            // Guardamos preferencias básicas
            li_basic_preferences bPref = dbgestor.preferences.getPreferencesByDNI(actualUser.DNI);

            bPref.US_formatp = constants.formats[this.cbFormat.SelectedIndex];
            bPref.US_dinamics = this.cbDynamicSearch.Checked;

            if (this.cbLang.SelectedIndex == 0)
                bPref.US_lang = null;
            else
                bPref.US_lang = Enum.GetName(typeof(g11n.Languages), constants.langs[this.cbLang.SelectedIndex - 1]);

            dbgestor.preferences.modPreferences(bPref);

            // Cambiamos la contraseña si se requiere
            if (newPassword != String.Empty)
            {
                actualUser.passwd = newPassword;
                dbgestor.user.modUser(actualUser);
            }

            this.Close();
        }

        private void bCompactDatabase_Click(object sender, EventArgs e)
        {
            dbgestor.compactor.CleanDatabase();
            LoadAdminPref();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bChangePassword_Click(object sender, EventArgs e)
        {
            new fChangePass(actualUser, this).ShowDialog();
        }

        public String NEWPASSWORD
        {
            set { this.newPassword = value; }
        }

        private void bRestartStat_Click(object sender, EventArgs e)
        {
            if (dbgestor.statistic.delBookByDNI(actualUser.DNI))
                MessageBox.Show(g11n.getTranslateString("User Statistic has been restarted successfully."), g11n.getTranslateString("User Statistic"), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bRegisAdmin_Click(object sender, EventArgs e)
        {
            new fRegistro(false, false).ShowDialog();
        }
    }
}
