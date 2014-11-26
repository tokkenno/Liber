using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PSLibrary.G11N;
using System.Collections;
using System.Diagnostics;
using System.IO;

namespace Liber
{
    public partial class fSelectFormat : Form
    {
        private ArrayList listBooks;

        public fSelectFormat(String Book_ID)
        {
            InitializeComponent();

            this.Icon = Properties.Resources.icon;

            SetText();

            // Añadimos los formatos al comboBox
            listBooks = dbgestor.documents.listDocumentsByBookID(Book_ID);
            this.cbSelectFormat.Items.Clear();

            foreach (li_documents docs in listBooks)
            {
                this.cbSelectFormat.Items.Add(docs.format_book);
            }

            this.cbSelectFormat.SelectedIndex = 0;
        }

        private void SetText()
        {
            this.Text = g11n.getTranslateString("Select Format:");
            this.gbInformation.Text = g11n.getTranslateString("Information:");
            this.lInfo.Text = g11n.getTranslateString("This book has more of a file stored in the database.") + Environment.NewLine + g11n.getTranslateString("Select the format in which you want to see.");
            this.bAccept.Text = g11n.getTranslateString("Accept");
            this.bCancel.Text = g11n.getTranslateString("Cancel");
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bAccept_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (li_documents docs in listBooks)
                {
                    if (cbSelectFormat.SelectedItem.ToString() == docs.format_book)
                    {
                        ProcessStartInfo psi = new ProcessStartInfo(new FileInfo("./db/files/" + docs.path_book).FullName);
                        Process p = Process.Start(psi);
                        this.Close();
                        return;
                    }
                }
            }
            catch { }

            MessageBox.Show("File not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
    }
}
