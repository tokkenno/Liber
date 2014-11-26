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
    public partial class fRegistro : Form
    {
        public fRegistro()
        {
            InitializeComponent();

            this.Icon = Properties.Resources.icon;

            setText();
        }

        public fRegistro(Boolean user, Boolean first)
        {
            InitializeComponent();

            this.Icon = Properties.Resources.icon;

            setText();

            if (first)
            {
                this.cbPermissions.SelectedIndex = 1;
                this.cbPermissions.Enabled = false;
                this.bCloseApp.Visible = true;
                this.lTitleInfoDesc.Text = g11n.getTranslateString("Register the first admin user to use this system.");
            }
            else
            {
                if (user)
                {
                    this.cbPermissions.SelectedIndex = 0;
                    this.cbPermissions.Enabled = false;
                    this.lTitleInfoDesc.Text = g11n.getTranslateString("Register an user to use this system.");
                }
                else
                {
                    this.cbPermissions.SelectedIndex = 1;
                    this.cbPermissions.Enabled = false;
                    this.lTitleInfoDesc.Text = g11n.getTranslateString("Register an admin user to use this system.");
                }
            }
        }

        private void setText()
        {
            this.Text = "Liber - " + g11n.getTranslateString("Registration");
            this.lTitleInfo.Text = g11n.getTranslateString("User Registration");
            this.lTitleInfoDesc.Text = g11n.getTranslateString("Register a new user to use this system.");
            this.lReqFields.Text = g11n.getTranslateString("Required fields");
            this.bCreate.Text = g11n.getTranslateString("Create");
            this.bClose.Text = g11n.getTranslateString("Close");
            this.bCloseApp.Text = g11n.getTranslateString("Close Application");
            this.lNickname.Text = g11n.getTranslateString("Nickname:");
            this.lPassword.Text = g11n.getTranslateString("Password:");
            this.lDNI.Text = g11n.getTranslateString("DNI:");
            this.lFirstName.Text = g11n.getTranslateString("First Name:");
            this.lLastName.Text = g11n.getTranslateString("Last Name:");
            this.lEmail.Text = g11n.getTranslateString("Email:");
            this.lPhone.Text = g11n.getTranslateString("Phone:");
            this.lBirthDay.Text = g11n.getTranslateString("Birthday:");
            this.lAddress.Text = g11n.getTranslateString("Address:");
            this.lPermissions.Text = g11n.getTranslateString("Permissions:");

            this.cbPermissions.Items.Clear();
            this.cbPermissions.Items.Add(g11n.getTranslateString("User"));
            this.cbPermissions.Items.Add(g11n.getTranslateString("Administrator"));
            this.cbPermissions.SelectedIndex = 0;
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KeyPress_ON(object sender, KeyPressEventArgs e)
        {
            PSLibrary.Utils.EventReply.KeyPress_EventReply.OnlyNumbers(sender, e);
        }

        private void KeyPress_OL(object sender, KeyPressEventArgs e)
        {
            PSLibrary.Utils.EventReply.KeyPress_EventReply.OnlyLetters(sender, e);
        }

        private void bCreate_Click(object sender, EventArgs e)
        {
            if (this.tbNickname.Text.Length < 6)
            {
                MessageBox.Show(g11n.getTranslateString("Nickname is incorrect. They should have at least 6 characters."), g11n.getTranslateString("Validating Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (li_user usr in dbgestor.user.listUser())
            {
                if (usr.nickname == this.tbNickname.Text)
                {
                    MessageBox.Show(g11n.getTranslateString("The nickname alredy registered in."), g11n.getTranslateString("Validating Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (this.tbPassword.Text.Length < 6)
            {
                MessageBox.Show(g11n.getTranslateString("Password is incorrect. They should have at least 6 characters."), g11n.getTranslateString("Validating Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.tbDNI.Text.Length != 8)
            {
                MessageBox.Show(g11n.getTranslateString("The DNI is incorrect. They should have 8 digits."), g11n.getTranslateString("Validating Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.tbFirstName.Text.Length < 2)
            {
                MessageBox.Show(g11n.getTranslateString("Firstname is incorrect. They should have at least 2 characters."), g11n.getTranslateString("Validating Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!PSLibrary.Utils.CheckCodes.EMAIL.IsValidEmail(this.tbEmail.Text))
            {
                MessageBox.Show(g11n.getTranslateString("Email is incorrect."), g11n.getTranslateString("Validating Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            li_user pp = new li_user();
            pp.DNI = this.tbDNI.Text;
            pp.firstname = this.tbFirstName.Text;
            if (this.tbLastName.Text.Length > 0)
                pp.lastname = this.tbLastName.Text;
            else
                pp.lastname = null;
            if (this.dtBirthDay.Text.Length > 0)
                pp.birthday = this.dtBirthDay.Value;
            else
                pp.birthday = null;
            pp.email = this.tbEmail.Text;
            if (this.tbAddress.Text.Length > 0)
                pp.direction = this.tbAddress.Text;
            else
                pp.direction = null;
            if (this.tbPhone.Text.Length == 8)
                pp.phone = this.tbAddress.Text;
            else
                pp.phone = null;
            if (this.cbPermissions.SelectedIndex == 0)
                pp.typeu = "simpleuser";
            else
                pp.typeu = "administrator";
            pp.nickname = this.tbNickname.Text.ToLower();
            pp.passwd = this.tbPassword.Text;

            if (dbgestor.user.addUser(pp))
                if (dbgestor.preferences.initPreferences(pp))
                    this.Close();
            return;
        }

        private void bCloseApp_Click(object sender, EventArgs e)
        {
            Debug.Close();
            Application.Exit();
        }

        private void tbDNI_TextChanged(object sender, EventArgs e)
        {
            if (this.tbDNI.Text.Length == 8)
                this.tbDNILetter.Text = PSLibrary.Utils.CheckCodes.DNI.GetLetter(this.tbDNI.Text).ToString();
            else
                this.tbDNILetter.Text = String.Empty;
        }
    }
}
