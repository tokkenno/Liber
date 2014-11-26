using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using PSLibrary.G11N;

namespace Liber
{
    public partial class fMetadata : Form
    {
        private li_books actualBook;

        private Image portadaImg = null;

        public fMetadata(li_books actualBook)
        {
            this.actualBook = actualBook;

            InitializeComponent();

            foreach (li_author au in dbgestor.author.listAuthor())
            {
                this.tbAuthor.AutoCompleteCustomSource.Add(au.lastname + ", " + au.firstname);
            }

            foreach (li_saga sag in dbgestor.saga.listSaga())
            {
                this.tbSaga.AutoCompleteCustomSource.Add(sag.name);
            }

            setText();
            loadForms();
        }

        private void loadForms()
        {
            if (actualBook != null)
            {
                this.tbID.Text = actualBook.ID_book;
                this.tbTitle.Text = actualBook.title;
                this.tbAuthor.Text = dbgestor.author.getAuthorByID(actualBook.ID_author).lastname + ", " + dbgestor.author.getAuthorByID(actualBook.ID_author).firstname;
                this.tbSaga.Text = dbgestor.saga.getSagaByID(actualBook.ID_saga).name;

                if (actualBook.genre != null)
                {
                    for (Int32 i = 0; i < dbgestor.books.genre_list.Length; i++)
                    {
                        if (dbgestor.books.genre_list[i] == actualBook.genre)
                        {
                            this.cbGenre.SelectedIndex = i;
                        }
                    }
                }

                if (dbgestor.saga.getSagaByID(actualBook.ID_saga).typep != null)
                {
                    for (Int32 i = 0; i < dbgestor.saga.saga_list.Length; i++)
                    {
                        if (dbgestor.saga.saga_list[i] == dbgestor.saga.getSagaByID(actualBook.ID_saga).typep)
                        {
                            this.cbSagaType.SelectedIndex = i;
                        }
                    }
                }

                this.tbSinopsis.Text = actualBook.sinopsis;

                try
                {
                    this.pbCover.Image = Image.FromFile("./db/img/" + actualBook.portada);
                }
                catch { }
            }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Multiselect = false;
            of.Filter = "Imagenes|*.jpg;*.jpeg;*.gif;*.png";
            of.Title = "Escoge una caratula para el libro.";

            if (of.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    this.portadaImg = PSLibrary.Utils.Image.Operations.Resize(new Bitmap(of.FileName), 192, 255);
                    this.pbCover.Image = this.portadaImg;
                }
                catch
                {
                    MessageBox.Show("Image file is damage.", "Error - Cover", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bDel_Click(object sender, EventArgs e)
        {
            this.portadaImg = null;
            this.pbCover.Image = Properties.Resources.default_cover;
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bAccept_Click(object sender, EventArgs e)
        {
            li_books changeBook = new li_books();
            changeBook.ID_book = this.actualBook.ID_book;

            // Cambiamos el titulo
            if (actualBook.title != this.tbTitle.Text)
            {
                if (this.tbTitle.Text != String.Empty)
                    changeBook.title = this.tbTitle.Text;
                else
                    changeBook.title = this.actualBook.title;
            }
            else
                changeBook.title = this.actualBook.title;

            // Cambiamos el autor
            String actualAuthor_firstname = dbgestor.author.getAuthorByID(this.actualBook.ID_author).firstname;
            if (actualAuthor_firstname == null)
                actualAuthor_firstname = String.Empty;
            String actualAuthor_lastname = dbgestor.author.getAuthorByID(this.actualBook.ID_author).lastname;
            if (actualAuthor_lastname == null)
                actualAuthor_lastname = String.Empty;

            if (actualAuthor_lastname + ", " + actualAuthor_firstname != this.tbAuthor.Text)
            {
                if (this.tbTitle.Text != String.Empty)
                {
                    li_author aut = new li_author();
                    aut.ID_author = dbgestor.author.newID();

                    if (this.tbAuthor.Text.Contains(','))
                    {
                        String tempFirst = this.tbAuthor.Text.Substring(this.tbAuthor.Text.IndexOf(',') + 1).Trim();
                        String tempLast = this.tbAuthor.Text.Substring(0, this.tbAuthor.Text.IndexOf(',')).Trim();

                        if (tempFirst.Length > 18)
                            tempFirst = tempFirst.Substring(0, 18);
                        if (tempLast.Length > 18)
                            tempLast = tempLast.Substring(0, 18);

                        aut.firstname = tempFirst;
                        aut.lastname = tempLast;
                    }
                    else
                    {
                        if (this.tbAuthor.Text.Length > 18)
                            aut.firstname = this.tbAuthor.Text.Substring(0, 18);
                        else
                            aut.firstname = this.tbAuthor.Text;
                        aut.lastname = String.Empty;
                    }

                    // No borramos el autor anterior
                    dbgestor.author.addAuthor(aut);
                    changeBook.ID_author = aut.ID_author;
                }
                else
                    changeBook.ID_author = this.actualBook.ID_author;
            }
            else
                changeBook.ID_author = this.actualBook.ID_author;

            // Cambiamos la saga
            String actualSagaName = dbgestor.saga.getSagaByID(this.actualBook.ID_saga).name;
            if (actualSagaName == null)
                actualSagaName = String.Empty;
            
            if (this.tbSaga.Text != actualSagaName)
            {
                if (this.tbSaga.Text != String.Empty)
                {
                    li_saga sag = new li_saga();
                    sag.ID_saga = dbgestor.saga.newID();

                    sag.name = this.tbSaga.Text;
                    sag.typep = dbgestor.saga.saga_list[this.cbSagaType.SelectedIndex];

                    // No borramos la saga anterior
                    dbgestor.saga.addSaga(sag);
                    changeBook.ID_saga = sag.ID_saga;
                }
                else
                    changeBook.ID_saga = this.actualBook.ID_saga;
            }
            else
                changeBook.ID_saga = this.actualBook.ID_saga;

            // Cambiamos el genero
            if (this.actualBook.genre != dbgestor.books.genre_list[this.cbGenre.SelectedIndex])
            {
                changeBook.genre = dbgestor.books.genre_list[this.cbGenre.SelectedIndex];
            }
            else
                changeBook.genre = this.actualBook.genre;

            // Cambiamos la sinopsis
            if (this.tbSinopsis.Text != this.actualBook.sinopsis)
            {
                changeBook.sinopsis = this.tbSinopsis.Text;
            }
            else
                changeBook.sinopsis = this.actualBook.sinopsis;

            // Intentamos copiar la imagen y borrar la anterior
            if (portadaImg != null)
            {
                try
                {
                    if (actualBook.portada != null)
                    {
                        if (actualBook.portada != String.Empty)
                        {
                            File.Delete("./db/img/" + actualBook.portada);
                        }
                    }

                    portadaImg.Save("./db/img/" + actualBook.ID_book + ".png", System.Drawing.Imaging.ImageFormat.Png);
                    changeBook.portada = actualBook.ID_book + ".png";
                }
                catch
                {
                    MessageBox.Show(g11n.getTranslateString("Book cover has not been modified. I/O Error while save the image"), g11n.getTranslateString("Error - Book cover not modified"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    changeBook.portada = null;
                }
            }
            else
                changeBook.portada = this.actualBook.portada;

            // Hacemos los cambios
            if (dbgestor.books.modBook(changeBook))
            {
                MessageBox.Show(g11n.getTranslateString("Book Info modified correctly."), g11n.getTranslateString("Info - Book Info modified"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show(g11n.getTranslateString("Book information has not been modified."), g11n.getTranslateString("Error - Book Info not modified"), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void setText()
        {
            this.Text = "Liber - " + g11n.getTranslateString("Change Metadata");
            this.gbMetadata.Text = g11n.getTranslateString("Book Metadata");
            this.gbCover.Text = g11n.getTranslateString("Cover");
            this.lID.Text = g11n.getTranslateString("Book ID:");
            this.lTitle.Text = g11n.getTranslateString("Title:");
            this.lAuthor.Text = g11n.getTranslateString("Author:");
            this.lSaga.Text = g11n.getTranslateString("Saga:");
            this.lSagaType.Text = g11n.getTranslateString("Saga Type:");
            this.lGenre.Text = g11n.getTranslateString("Genre:");
            this.lSinopsis.Text = g11n.getTranslateString("Sinopsis:");
            this.bAccept.Text = g11n.getTranslateString("Accept");
            this.bCancel.Text = g11n.getTranslateString("Cancel");

            this.cbGenre.Items.Clear();
            for (Int32 i = 0; i < dbgestor.books.genre_list.Length; i++)
            {
                this.cbGenre.Items.Add(g11n.getTranslateString(dbgestor.books.genre_list[i]));
            }
            this.cbGenre.SelectedIndex = 0;

            this.cbSagaType.Items.Clear();
            for (Int32 i = 0; i < dbgestor.saga.saga_list.Length; i++)
            {
                this.cbSagaType.Items.Add(g11n.getTranslateString(dbgestor.saga.saga_list[i]));
            }
            this.cbSagaType.SelectedIndex = 0;
        }
    }
}
