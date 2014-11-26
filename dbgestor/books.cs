using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data.SqlClient;
using PSLibrary.Debug;

namespace Liber.dbgestor
{
    public static class books
    {
        private static LiberDBDataContext DB = new LiberDBDataContext();

        public static String[] genre_list = new String[] { "horror", "love", "romance", "novel", "action", "fantastic", "poetry", "historical", "didactic" };

        public static Boolean addBooks(li_books book)
        {
            try
            {
                DB.li_books.InsertOnSubmit(book);
                DB.SubmitChanges();
                return true;
            }
            catch
            {
                Debug.AddWarning("SQL Error => In function dbgestor.books.addBooks");
                return false;
            }
        }

        public static ArrayList listBooks()
        {
            ArrayList lista = new ArrayList();

            try
            {
                var vUser = DB.ExecuteQuery<li_books>("select * from liber.li_books");

                foreach (var m in vUser)
                {
                    lista.Add(m);
                }
            }
            catch
            {
                Debug.AddWarning("SQL Error => In function dbgestor.books.listBooks");
            }

            return lista;
        }

        public static li_books getBookByID(String ID)
        {
            ArrayList lista = new ArrayList();

            try
            {
                var vUser = DB.ExecuteQuery<li_books>("select * from liber.li_books where ID_book = " + ID);
                
                foreach (var m in vUser)
                {
                    return m;
                }
            }
            catch
            {
                Debug.AddWarning("SQL Error => In function dbgestor.books.getBookByID"); 
            }

            return null;
        }

        public static String newID()
        {
            Random r = new Random();
            String num = r.Next(9999999).ToString();

            foreach (li_books boo in listBooks())
            {
                if (boo.ID_book == num)
                {
                    return newID();
                }
            }

            return num;
        }

        public static Boolean modBook(li_books book)
        {
            try
            {
                IQueryable<li_books> cust = from c in DB.li_books where c.ID_book == book.ID_book select c;

                if (cust.Count() == 1)
                {
                    cust.First().ID_book = book.ID_book;
                    cust.First().ID_author = book.ID_author;
                    cust.First().ID_saga = book.ID_saga;
                    cust.First().title = book.title;
                    cust.First().genre = book.genre;
                    cust.First().sinopsis = book.sinopsis;
                    cust.First().portada = book.portada;
                    DB.SubmitChanges();
                }

                return true;
            }
            catch
            {
                Debug.AddWarning("SQL Error => In function dbgestor.books.modBook"); 
                return false;
            }
        }

        public static Boolean delBook(String ID)
        {
            try
            {
                DB.li_books.DeleteOnSubmit(getBookByID(ID));
                DB.SubmitChanges();
                return true;
            }
            catch
            {
                Debug.AddWarning("SQL Error => In function dbgestor.books.delBook");
                return false;
            }
        }
    }
}
