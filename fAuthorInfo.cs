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
    public partial class fAuthorInfo : Form
    {
        private li_author autor;

        public fAuthorInfo(li_author author, Boolean isAdministrator)
        {
            InitializeComponent();

            this.autor = author;

            if (!isAdministrator)
            {
                this.tbFisrtName.ReadOnly = true;
                this.tbLastName.ReadOnly = true;
                this.dtpBirthdate.Enabled = false;
                this.dtpDeadDate.Enabled = false;
                this.bAccept.Enabled = false;
            }

            setText();
            loadData();
        }

        private void setText()
        {
            this.Text = "Liber - " + g11n.getTranslateString("Edit author");
            this.lName.Text = g11n.getTranslateString("First Name:");
            this.lLastName.Text = g11n.getTranslateString("Last Name:");
            this.lBirthDate.Text = g11n.getTranslateString("Birthdate:");
            this.lDeadDate.Text = g11n.getTranslateString("Dead Date:");
            this.gbAuthorInfo.Text = g11n.getTranslateString("Author Info");
            this.bAccept.Text = g11n.getTranslateString("Accept");
            this.bCancel.Text = g11n.getTranslateString("Cancel");
        }

        private void loadData()
        {
            if (this.autor != null)
            {
                this.tbFisrtName.Text = autor.firstname;
                this.tbLastName.Text = autor.lastname;
                if (autor.birthdate != null)
                    this.dtpBirthdate.Value = autor.birthdate.Value;
                if (autor.deathdate != null)
                    this.dtpDeadDate.Value = autor.deathdate.Value;
            }
            else
            {
                MessageBox.Show(g11n.getTranslateString("Author Info Formulary - Load Error"), g11n.getTranslateString("Error - Load Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bAccept_Click(object sender, EventArgs e)
        {
            li_author aux = new li_author();
            aux.ID_author = autor.ID_author;

            if (this.tbFisrtName.Text == String.Empty || this.tbLastName.Text == String.Empty)
            {
                MessageBox.Show(g11n.getTranslateString("You must insert Firstname and Lastname."), g11n.getTranslateString("Error - Check Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            aux.firstname = this.tbFisrtName.Text;
            aux.lastname = this.tbLastName.Text;
            aux.deathdate = this.dtpDeadDate.Value;
            aux.birthdate = this.dtpBirthdate.Value;

            if (dbgestor.author.modAuthor(aux))
            {
                MessageBox.Show(g11n.getTranslateString("Author modified correctly."), g11n.getTranslateString("Info - Author modified"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show(g11n.getTranslateString("Error while author has been modified."), g11n.getTranslateString("Error - Modified Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
