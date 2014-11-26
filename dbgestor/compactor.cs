using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using PSLibrary.Debug;

namespace Liber.dbgestor
{
    public static class compactor
    {
        public static void CleanDatabase()
        {
            CleanAuthors();
            CleanBooks();
        }

        private static void CleanAuthors()
        {
            try
            {
                foreach (li_author autores in dbgestor.author.listAuthor())
                {
                    Boolean haveBook = false;

                    foreach (li_books libros in dbgestor.books.listBooks())
                    {
                        if (libros.ID_author == autores.ID_author)
                        {
                            haveBook = true;
                            break;
                        }
                    }

                    if (!haveBook)
                    {
                        dbgestor.author.delAuthorByID(autores.ID_author);
                    }
                }
            }
            catch
            {
                Debug.AddWarning("Error while CleanAuthors was cleaning the database.");
            }
        }

        private static void CleanBooks()
        {
            try
            {
                List<String> files = new List<String>();

                foreach (li_books libros in dbgestor.books.listBooks())
                {
                    foreach (li_documents docs in dbgestor.documents.listDocumentsByBookID(libros.ID_book))
                    {
                        files.Add(docs.ID_book + "_" + docs.ID_publication + docs.format_book);
                    }
                }

                String[] filesInDir = Directory.GetFiles("./db/files/");
                List<String> filesToDelete = new List<String>();

                foreach (String uri in files)
                {
                    Boolean toDelete = true;

                    for (Int32 i = 0; i < filesInDir.Length; i++)
                    {
                        if (uri == filesInDir[i])
                        {
                            toDelete = false;
                            break;
                        }
                    }

                    if (toDelete)
                        filesToDelete.Add(uri);
                }

                foreach (String fil in filesToDelete)
                {
                    File.Delete("./db/files/" + fil);
                }
            }
            catch
            {
                Debug.AddWarning("Error while CleanBooks was cleaning the database.");
            }
        }
    }
}
