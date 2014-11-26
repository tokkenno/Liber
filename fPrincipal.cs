using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Diagnostics;
using PSLibrary.G11N;

namespace Liber
{
    public partial class fPrincipal : Form
    {
        private li_user actualUser;

        private Boolean searchActive = false;

        public fPrincipal(li_user user)
        {
            InitializeComponent();

            this.Icon = Properties.Resources.icon;

            this.actualUser = user;

            if (dbgestor.preferences.getPreferencesByDNI(actualUser.DNI).US_lang != null)
            {
                for (Int32 i = 0; i < constants.langs.Length; i++)
                {
                    if (Enum.GetName(typeof(g11n.Languages), constants.langs[i]) == dbgestor.preferences.getPreferencesByDNI(actualUser.DNI).US_lang)
                    {
                        g11n.ChangeLanguage(constants.langs[i]);
                    }
                }
            }

            if (this.actualUser.typeu == "simpleuser")
            {
                this.bAdd.Enabled = false;
                this.bEdit.Enabled = false;
                this.bDel.Enabled = false;
                this.tsmiAddFormat.Enabled = false;
                this.tsmiDelete.Enabled = false;
                this.tsmiEditMetadata.Enabled = false;
            }

            this.tsmiDownload.Enabled = Preferences.ALLOWDOWNLOADS;

            tbSearch.ForeColor = Color.Gray;

            setText();
            LoadData();
        }

        private void bPreferences_Click(object sender, EventArgs e)
        {
            new fPreferencias(this.actualUser).ShowDialog();
            this.tsmiDownload.Enabled = Preferences.ALLOWDOWNLOADS;
        }

        private void bHelp_Click(object sender, EventArgs e)
        {
            new PSLibrary.Dialogs.DialogHelpHTML("titulo", "./help/index.html", "http://proyectsource.tk", Properties.Resources.icon).ShowDialog();
        }

        private void bAbout_Click(object sender, EventArgs e)
        {
            Uri web = null;

            try
            {
                web = new Uri("http://proyectsource.tk");
            }
            catch 
            {
                PSLibrary.Debug.Debug.AddError("Error while create Uri to about dialog.");
            }

            new PSLibrary.Dialogs.DialogAbout("", "Liber", "0.1", "Ebook Administrator", "GNU GPL v3", "Proyect Source", web, Properties.Resources.logo_128, Properties.Resources.icon).ShowDialog();
        }

        private DataTable ObtenerDatos()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ID");
            dt.Columns.Add("Titulo");
            dt.Columns.Add("Autor");
            dt.Columns.Add("Saga");
            dt.Columns.Add("Genero");

            DataRow row;

            foreach (li_books book in dbgestor.books.listBooks())
            {
                row = dt.NewRow();
                row["ID"] = book.ID_book;
                row["Titulo"] = book.title;
                row["Autor"] = dbgestor.author.getAuthorByID(book.ID_author).lastname + ", " + dbgestor.author.getAuthorByID(book.ID_author).firstname;
                row["Saga"] = dbgestor.saga.getSagaByID(book.ID_saga).name;
                row["Genero"] = book.genre;
                dt.Rows.Add(row);
            }

            return dt;
        }

        private DataTable ObtenerDatos(String search, Boolean byAuthor)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ID");
            dt.Columns.Add("Titulo");
            dt.Columns.Add("Autor");
            dt.Columns.Add("Saga");
            dt.Columns.Add("Genero");

            DataRow row;

            foreach (li_books book in dbgestor.books.listBooks())
            {
                if (byAuthor)
                {
                    // Busqueda por el nombre del autor
                    if ((dbgestor.author.getAuthorByID(book.ID_author).firstname + ", " + dbgestor.author.getAuthorByID(book.ID_author).lastname).Contains(search))
                    {
                        row = dt.NewRow();
                        row["ID"] = book.ID_book;
                        row["Titulo"] = book.title;
                        row["Autor"] = dbgestor.author.getAuthorByID(book.ID_author).lastname + ", " + dbgestor.author.getAuthorByID(book.ID_author).firstname;
                        row["Saga"] = dbgestor.saga.getSagaByID(book.ID_saga).name;
                        row["Genero"] = book.genre;
                        dt.Rows.Add(row);
                    }
                }
                else
                {
                    // Busqueda por titulo
                    if (book.title.Contains(search))
                    {
                        row = dt.NewRow();
                        row["ID"] = book.ID_book;
                        row["Titulo"] = book.title;
                        row["Autor"] = dbgestor.author.getAuthorByID(book.ID_author).lastname + ", " + dbgestor.author.getAuthorByID(book.ID_author).firstname;
                        row["Saga"] = dbgestor.saga.getSagaByID(book.ID_saga).name;
                        row["Genero"] = book.genre;
                        dt.Rows.Add(row);
                    }
                }
            }

            return dt;
        }

        private void LoadData()
        {
            DataTable dt;

            this.lvBooks.Items.Clear();

            dt = ObtenerDatos();

            // Comprobar si hay un autor seleccionado
            if (this.tbSearch.Text == String.Empty || !searchActive)
            {
                dt = ObtenerDatos();
            }
            else
            {
                dt = ObtenerDatos(this.tbSearch.Text, false);
            }

            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(row["ID"]));
                item.SubItems.Add(Convert.ToString(row["Titulo"]));
                item.SubItems.Add(Convert.ToString(row["Autor"]));
                item.SubItems.Add(Convert.ToString(row["Saga"]));
                item.SubItems.Add(Convert.ToString(row["Genero"]));

                this.lvBooks.Items.Add(item);
            }
        }

        private void lvBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String info = String.Empty;
                String popup = String.Empty;

                // Cargamos el libro seleccionado
                li_books book = dbgestor.books.getBookByID(this.lvBooks.SelectedItems[0].SubItems[0].Text);

                // Añadimos ID
                popup += g11n.getTranslateString("Book ID:") + " " + book.ID_book + Environment.NewLine;

                // Añadimos el Titulo
                popup += g11n.getTranslateString("Title:") + " " + book.title + Environment.NewLine;
                info += g11n.getTranslateString("Title:") + Environment.NewLine + "   " + book.title + Environment.NewLine + Environment.NewLine;

                // Añadimos el autor (Si es distinto al registro 0000000 que representa el estado sin autor)(El registro 9999999 representa al autor anonimo)
                if (book.ID_author != "0000000")
                {
                    if (book.ID_author != "9999999")
                    {
                        popup += g11n.getTranslateString("Author:") + " " + g11n.getTranslateString("Anonymous") + Environment.NewLine;
                        info += g11n.getTranslateString("Author:") + Environment.NewLine + "   " + g11n.getTranslateString("Anonymous") + Environment.NewLine + Environment.NewLine;
                    }
                    else
                    {
                        li_author autor = dbgestor.author.getAuthorByID(book.ID_author);

                        popup += g11n.getTranslateString("Author:") + " " + autor.lastname + ", " + autor.firstname + Environment.NewLine;
                        info += g11n.getTranslateString("Author:") + Environment.NewLine + "   " + autor.lastname + ", " + autor.firstname + Environment.NewLine + Environment.NewLine;
                    }
                }

                // Añadimos la saga (Si es distinta al registro 0000000 que representa el estado sin saga)
                if (book.ID_saga != "0000000")
                {
                    li_saga saga = dbgestor.saga.getSagaByID(book.ID_saga);

                    popup += g11n.getTranslateString("Saga:") + " " + saga.name + Environment.NewLine;
                    info += g11n.getTranslateString("Saga:") + Environment.NewLine + "   " + saga.name + Environment.NewLine + Environment.NewLine;
                }

                if (book.genre != null)
                {
                    if (book.genre != String.Empty)
                    {
                        popup += g11n.getTranslateString("genre:") + " " + book.genre + Environment.NewLine;
                    }
                }

                if (book.sinopsis != null)
                {
                    if (book.sinopsis != String.Empty)
                    {
                        info += g11n.getTranslateString("Sinopsis:") + Environment.NewLine + "   " + book.sinopsis;
                    }
                }

                if (book.portada != null)
                {
                    if (book.portada != String.Empty)
                    {
                        try
                        {
                            this.pbCover.Image = Image.FromFile("./db/img/" + book.portada);
                        }
                        catch
                        {
                            PSLibrary.Debug.Debug.AddError("Error while load image in fPrincipal->pbCover.");
                        }
                    }
                }

                this.tb_I.Text = info;
                this.tTips.SetToolTip(this.tb_I, popup);
                this.tTips.SetToolTip(this.pbCover, popup);
            }
            catch { }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Multiselect = false;
            of.Filter = "Documentos|*.pdf;*.doc;*.docx;*.odf;*.txt";

            if (of.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    // Creamos un registro de libro (li_books) y documento (li_documents) nuevos.
                    li_books newBook = new li_books();
                    newBook.ID_book = dbgestor.books.newID();
                    newBook.ID_author = "0000000";
                    newBook.ID_saga = "0000000";

                    li_documents newDocument = new li_documents();
                    newDocument.ID_publication = dbgestor.documents.newID();

                    // Creamos una clase FileInfo para trabajar con informacion del fichero
                    FileInfo fileBook = new FileInfo(of.FileName);

                    // Copiamos el archivo a la carpeta del programa
                    File.Copy(of.FileName, "./db/files/" + newBook.ID_book + "_" + newDocument.ID_publication + fileBook.Extension);

                    // Cargamos su información en el registro li_documento
                    newDocument.ID_book = newBook.ID_book;
                    newDocument.path_book = newBook.ID_book + "_" + newDocument.ID_publication + fileBook.Extension;
                    if (fileBook.Extension.Length > 5)
                        newDocument.format_book = fileBook.Extension.Substring(0, 5).ToUpper();
                    else
                        newDocument.format_book = fileBook.Extension.ToUpper();

                    // Usamos el nombre del archivo como titulo provisional
                    newBook.title = fileBook.Name.Substring(0, fileBook.Name.LastIndexOf('.'));

                    // Añadimos los registros a la base de datos
                    if (dbgestor.books.addBooks(newBook))
                        if (dbgestor.documents.addDocument(newDocument))
                            MessageBox.Show("Book added to Liber.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Error while Liber has registering the file in database.", "Error - DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("Error while Liber has registering the book in database.", "Error - DB", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // reCargamos la lista del formulario principal
                    LoadData();

                }
                catch
                {
                    MessageBox.Show("Error while Liber has copying the file.", "Error - I/O", MessageBoxButtons.OK , MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void lvBooks_DoubleClick(object sender, EventArgs e)
        {
            bShow_Click(sender, e);
        }

        private void lvBooks_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.cmsBooks.Show(this.PointToScreen(e.Location));
            }
        }

        private void bDel_Click(object sender, EventArgs e)
        {
            if (this.lvBooks.SelectedItems.Count > 0)
            {
                // Borramos los archivos asociados
                foreach (li_documents docs in dbgestor.documents.listDocumentsByBookID(this.lvBooks.SelectedItems[0].Text))
                {
                    try
                    {
                        File.Delete("./db/files/" + docs.path_book);
                    }
                    catch {}
                }
                
                // Borramos la caratula si existe
                try
                {
                    File.Delete("./db/img/" + dbgestor.books.getBookByID(this.lvBooks.SelectedItems[0].Text).portada);
                }
                catch {}

                dbgestor.books.delBook(this.lvBooks.SelectedItems[0].Text);
                LoadData();
            }
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            if (this.lvBooks.SelectedItems.Count > 0)
            {
                if (dbgestor.books.getBookByID(this.lvBooks.SelectedItems[0].Text) != null)
                {
                    new fMetadata(dbgestor.books.getBookByID(this.lvBooks.SelectedItems[0].Text)).ShowDialog();
                    LoadData();
                }
            }
        }

        private void tsmiAuthorInfo_Click(object sender, EventArgs e)
        {
            if (this.lvBooks.SelectedItems.Count > 0)
            {
                if (actualUser.typeu == "administrator")
                {
                    new fAuthorInfo(dbgestor.author.getAuthorByID(dbgestor.books.getBookByID(this.lvBooks.SelectedItems[0].Text).ID_author), true).ShowDialog();
                }
                else
                {
                    new fAuthorInfo(dbgestor.author.getAuthorByID(dbgestor.books.getBookByID(this.lvBooks.SelectedItems[0].Text).ID_author), false).ShowDialog();
                }
            }
        }

        private void bShow_Click(object sender, EventArgs e)
        {
            if (this.lvBooks.SelectedItems.Count > 0)
            {
                ArrayList aux = dbgestor.documents.listDocumentsByBookID(this.lvBooks.SelectedItems[0].Text);

                if (aux.Count == 0)
                {
                    MessageBox.Show("There is no document in the database for this record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (aux.Count == 1)
                {
                    try
                    {
                        foreach (li_documents docs in aux)
                        {
                            ProcessStartInfo psi = new ProcessStartInfo(new FileInfo("./db/files/" + docs.path_book).FullName);
                            Process p = Process.Start(psi);
                            return;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("File not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return;
                }

                if (aux.Count > 1)
                {
                    // Comprueba si hay preferencias para este libro
                    new fSelectFormat(this.lvBooks.SelectedItems[0].Text).ShowDialog();
                }
            }
        }

        private void tsmiAddFormat_Click(object sender, EventArgs e)
        {
            if (this.lvBooks.SelectedItems.Count > 0)
            {
                OpenFileDialog of = new OpenFileDialog();
                of.Multiselect = false;
                of.Filter = "Documentos|*.pdf;*.doc;*.docx;*.odf;*.txt";

                if (of.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    try
                    {
                        li_documents newDocument = new li_documents();
                        newDocument.ID_publication = dbgestor.documents.newID();
                        newDocument.ID_book = this.lvBooks.SelectedItems[0].Text;

                        // Creamos una clase FileInfo para trabajar con informacion del fichero
                        FileInfo fileBook = new FileInfo(of.FileName);

                        // Comprobamos que el formato no se haya usado ya
                        foreach (li_documents docs in dbgestor.documents.listDocumentsByBookID(this.lvBooks.SelectedItems[0].Text))
                        {
                            if (fileBook.Extension.Length > 5)
                            {
                                if (docs.format_book == fileBook.Extension.Substring(0, 5).ToUpper())
                                {
                                    MessageBox.Show("Tthis format is already registered.", "Error - DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                            else
                            {
                                if (docs.format_book == fileBook.Extension.ToUpper())
                                {
                                    MessageBox.Show("Tthis format is already registered.", "Error - DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                        }

                        // Copiamos el archivo a la carpeta del programa
                        File.Copy(of.FileName, "./db/files/" + this.lvBooks.SelectedItems[0].Text + "_" + newDocument.ID_publication + fileBook.Extension);

                        // Cargamos su información en el registro li_documento
                        newDocument.path_book = this.lvBooks.SelectedItems[0].Text + "_" + newDocument.ID_publication + fileBook.Extension;
                        if (fileBook.Extension.Length > 5)
                            newDocument.format_book = fileBook.Extension.Substring(0, 5).ToUpper();
                        else
                            newDocument.format_book = fileBook.Extension.ToUpper();

                        // Añadimos los registros a la base de datos
                        if (dbgestor.documents.addDocument(newDocument))
                            MessageBox.Show("Book added to Liber.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Error while Liber has registering the file in database.", "Error - DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    {
                        MessageBox.Show("Error while Liber has copying the file.", "Error - I/O", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (dbgestor.preferences.getPreferencesByDNI(actualUser.DNI).US_dinamics)
            {
                if (tbSearch.Text != String.Empty && tbSearch.ForeColor == Color.Black)
                {
                    searchActive = true;
                }
                else
                {
                    searchActive = false;
                }

                LoadData();
            }
        }

        private void tbSearch_Enter(object sender, EventArgs e)
        {
            if (tbSearch.ForeColor != Color.Black)
            {
                tbSearch.ForeColor = Color.Black;
                tbSearch.Text = String.Empty;
            }
        }

        private void tbSearch_Leave(object sender, EventArgs e)
        {
            if (tbSearch.Text == String.Empty)
            {
                tbSearch.ForeColor = Color.Gray;
                tbSearch.Text = g11n.getTranslateString("Search...");
                LoadData();
            }
        }

        private void setText()
        {
            this.Text = "Liber - " + g11n.getTranslateString("eBook Manager");
            this.tbSearch.Text = g11n.getTranslateString("Search...");
            this.tTips.SetToolTip(this.bAdd, g11n.getTranslateString("Add new book..."));
            this.tTips.SetToolTip(this.bEdit, g11n.getTranslateString("Edit the metadata of selected book."));
            this.tTips.SetToolTip(this.bDel, g11n.getTranslateString("Delete selected book."));
            this.tTips.SetToolTip(this.bShow, g11n.getTranslateString("Open the selected book in the default viewer."));
            this.tTips.SetToolTip(this.bRSS, g11n.getTranslateString("Show the RSS news."));
            this.tTips.SetToolTip(this.bPreferences, g11n.getTranslateString("Open preferences."));
            this.tTips.SetToolTip(this.bHelp, g11n.getTranslateString("Show the Help."));
            this.tTips.SetToolTip(this.bAbout, g11n.getTranslateString("About..."));
            this.tTips.SetToolTip(this.tbSearch, g11n.getTranslateString("Search a book by its title."));
            this.tsmiAddFormat.Text = g11n.getTranslateString("Add format...");
            this.tsmiAuthorInfo.Text = g11n.getTranslateString("Author info");
            this.tsmiDelete.Text = g11n.getTranslateString("Delete");
            this.tsmiDownload.Text = g11n.getTranslateString("Download book");
            this.tsmiEditMetadata.Text = g11n.getTranslateString("Change book info");
            this.tsmiRead.Text = g11n.getTranslateString("Read book");
            this.tsmiReadAs.Text = g11n.getTranslateString("Read book in format...");
        }

        private void tsmiReadAs_Click(object sender, EventArgs e)
        {
            if (this.lvBooks.SelectedItems.Count > 0)
            {
                ArrayList aux = dbgestor.documents.listDocumentsByBookID(this.lvBooks.SelectedItems[0].Text);

                if (aux.Count == 0)
                {
                    MessageBox.Show("There is no document in the database for this record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (aux.Count == 1)
                {
                    try
                    {
                        foreach (li_documents docs in aux)
                        {
                            ProcessStartInfo psi = new ProcessStartInfo(new FileInfo("./db/files/" + docs.path_book).FullName);
                            Process p = Process.Start(psi);
                            return;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("File not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return;
                }

                if (aux.Count > 1)
                {
                    new fSelectFormat(this.lvBooks.SelectedItems[0].Text).ShowDialog();
                }
            }
        }

        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;

                if (tbSearch.Text != String.Empty && tbSearch.ForeColor == Color.Black)
                {
                    searchActive = true;
                }
                else
                {
                    searchActive = false;
                }

                LoadData();
            }
        }

        private void bRSS_Click(object sender, EventArgs e)
        {
            new fRssViewer(this.actualUser).ShowDialog();
        }

        private void tsmiDownload_Click(object sender, EventArgs e)
        {
            if (this.lvBooks.SelectedItems.Count > 0)
            {
                ArrayList aux = dbgestor.documents.listDocumentsByBookID(this.lvBooks.SelectedItems[0].Text);

                if (aux.Count == 0)
                {
                    MessageBox.Show("There is no document in the database for this record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (aux.Count > 0)
                {
                    try
                    {
                        SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                        String filter = String.Empty;
                        foreach (li_documents boo in aux)
                        {
                            switch (boo.format_book)
                            {
                                case ".PDF":
                                    if (filter != String.Empty)
                                        filter += '|';
                                    filter += "Adobe Pdf|*.pdf";
                                    break;
                                case ".DOC":
                                    if (filter != String.Empty)
                                        filter += '|';
                                    filter += "Microsoft Word|*.doc";
                                    break;
                                case ".DOCX":
                                    if (filter != String.Empty)
                                        filter += '|';
                                    filter += "Microsoft Word 2007|*.docx";
                                    break;
                                case ".ODT":
                                    if (filter != String.Empty)
                                        filter += '|';
                                    filter += "Open Text Document|*.odt";
                                    break;
                                case ".TXT":
                                    if (filter != String.Empty)
                                        filter += '|';
                                    filter += "Text File|*.txt";
                                    break;
                            }
                        }

                        saveFileDialog1.Filter = filter;
                        saveFileDialog1.ShowDialog();

                        if(saveFileDialog1.FileName != "")
                        {
                            switch (saveFileDialog1.FilterIndex)
                            {
                                case 1:
                                    try
                                    {
                                        foreach (li_documents boo in aux)
                                        {
                                            if (boo.format_book == ".PDF")
                                            {
                                                File.Copy("./db/files/" + boo.ID_book + "_" + boo.ID_publication + ".pdf", saveFileDialog1.FileName, true);
                                                return;
                                            }
                                        }
                                    }
                                    catch
                                    {
                                        MessageBox.Show("I/O error while save file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    break;
                                case 2:
                                    try
                                    {
                                        foreach (li_documents boo in aux)
                                        {
                                            if (boo.format_book == ".DOC")
                                            {
                                                File.Copy("./db/files/" + boo.ID_book + "_" + boo.ID_publication + ".doc", saveFileDialog1.FileName, true);
                                                return;
                                            }
                                        }
                                    }
                                    catch
                                    {
                                        MessageBox.Show("I/O error while save file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    break;
                                case 3:
                                    try
                                    {
                                        foreach (li_documents boo in aux)
                                        {
                                            if (boo.format_book == ".DOCX")
                                            {
                                                File.Copy("./db/files/" + boo.ID_book + "_" + boo.ID_publication + ".docx", saveFileDialog1.FileName, true);
                                                return;
                                            }
                                        }
                                    }
                                    catch
                                    {
                                        MessageBox.Show("I/O error while save file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    break;
                                case 4:
                                    try
                                    {
                                        foreach (li_documents boo in aux)
                                        {
                                            if (boo.format_book == ".ODT")
                                            {
                                                File.Copy("./db/files/" + boo.ID_book + "_" + boo.ID_publication + ".odt", saveFileDialog1.FileName, true);
                                                return;
                                            }
                                        }
                                    }
                                    catch
                                    {
                                        MessageBox.Show("I/O error while save file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    break;
                                case 5:
                                    try
                                    {
                                        foreach (li_documents boo in aux)
                                        {
                                            if (boo.format_book == ".TXT")
                                            {
                                                File.Copy("./db/files/" + boo.ID_book + "_" + boo.ID_publication + ".txt", saveFileDialog1.FileName, true);
                                                return;
                                            }
                                        }
                                    }
                                    catch
                                    {
                                        MessageBox.Show("I/O error while save file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    break;
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("File not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return;
                }
            }
        }
    }
}
