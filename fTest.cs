using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PSLibrary.Debug;

namespace Liber
{
    public partial class fTest : Form
    {
        public fTest()
        {
            // Poner a false para ocultar la consola de debug
            Debug.ShowGUI = true;
            // Poner a false para no escribir el archivo de debug
            Debug.ShowFile = true;

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            li_user pp = new li_user();
            pp.DNI = "32432458";
            pp.firstname = "juan";
            pp.lastname = "lopez";
            pp.birthday = null;
            pp.email = "falso@gmail.com";
            pp.direction = "calle falsa 123";
            pp.phone = "988288882";
            pp.typeu = "administrator";
            pp.nickname = "exekiel";
            pp.passwd = "qwer4321";

            if (!dbgestor.user.addUser(pp))
                Debug.AddError("Usuario test_admin no añadido.");
            dbgestor.preferences.initPreferences(pp);
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            li_user pp = new li_user();
            pp.DNI = "32435460";
            pp.firstname = "juano";
            pp.lastname = "lopezo";
            pp.birthday = null;
            pp.email = "falsote@gmail.com";
            pp.direction = "calle falsa 123";
            pp.phone = "988288882";
            pp.typeu = "simpleuser";
            pp.nickname = "exekill";
            pp.passwd = "qwer43";

            if (!dbgestor.user.addUser(pp))
                Debug.AddError("Usuario test_user no añadido.");
            dbgestor.preferences.initPreferences(pp);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            li_saga saga = new li_saga();
            saga.ID_saga = "5555555";
            saga.name = "El señor";
            saga.typep = "trilogy";
            if (!dbgestor.saga.addSaga(saga))
                Debug.AddError("Error al añadir saga .El señor de los anillos.");

            li_author autor = new li_author();
            autor.ID_author = "4444444";
            autor.firstname = "J.R.";
            autor.lastname = "Tolkien";
            if (!dbgestor.author.addAuthor(autor))
                Debug.AddError("Error al añadir autor .Tolkien.");

            li_books pp = new li_books();
            pp.ID_book = "6546546";
            pp.ID_author = autor.ID_author;
            pp.ID_saga = saga.ID_saga;
            pp.title = "Las dos torres";
            if (!dbgestor.books.addBooks(pp))
                Debug.AddError("Error al añadir el libro .Las dos torres.");

            li_books pi = new li_books();
            pi.ID_book = "6546547";
            pi.ID_author = autor.ID_author;
            pi.ID_saga = saga.ID_saga;
            pi.title = "El retorno del rey";
            if (!dbgestor.books.addBooks(pi))
                Debug.AddError("Error al añadir el libro .El retorno del rey.");
        }
    }
}
