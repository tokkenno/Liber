using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using PSLibrary.Debug;

namespace Liber.dbgestor
{
    public static class author
    {
        private static LiberDBDataContext DB = new LiberDBDataContext();

        public static Boolean addAuthor(li_author author)
        {
            try
            {
                DB.li_author.InsertOnSubmit(author);
                DB.SubmitChanges();
                return true;
            }
            catch
            {
                Debug.AddWarning("SQL Error => In function dbgestor.author.addAuthor");
                return false;
            }
        }

        public static String newID()
        {
            Random r = new Random();
            String num = r.Next(9999999).ToString();

            foreach (li_author boo in listAuthor())
            {
                if (boo.ID_author == num)
                {
                    return newID();
                }
            }

            return num;
        }

        public static ArrayList listAuthor()
        {
            ArrayList lista = new ArrayList();

            try
            {
                var vAuthor = DB.ExecuteQuery<li_author>("select * from liber.li_author");

                foreach (var m in vAuthor)
                {
                    lista.Add(m);
                }
            }
            catch
            {
                Debug.AddWarning("SQL Error => In function dbgestor.author.listAuthor");
            }

            return lista;
        }

        public static Boolean delAuthorByID(String ID_Author)
        {
            Boolean op = true;

            try
            {
                DB.li_author.DeleteOnSubmit(getAuthorByID(ID_Author));
                DB.SubmitChanges();
            }
            catch
            {
                Debug.AddWarning("SQL Error => In function dbgestor.author.delAuthorByID");
                op = false;
            }

            return op;
        }

        public static li_author getAuthorByID(String ID)
        {
            try
            {
                var vUser = DB.ExecuteQuery<li_author>("select * from liber.li_author where ID_author = " + ID);

                foreach (li_author au in vUser)
                {
                    return au;
                }
            }
            catch
            {
                Debug.AddWarning("SQL Error => In function dbgestor.author.getAuthorByID for ID-" + ID); 
            }

            return null;
        }

        public static Boolean modAuthor(li_author author)
        {
            try
            {
                IQueryable<li_author> cust = from c in DB.li_author where c.ID_author == author.ID_author select c;

                if (cust.Count() == 1)
                {
                    cust.First().ID_author = author.ID_author;
                    cust.First().firstname = author.firstname;
                    cust.First().lastname = author.lastname;
                    cust.First().birthdate = author.birthdate;
                    cust.First().deathdate = author.deathdate;
                    DB.SubmitChanges();
                }

                return true;
            }
            catch
            {
                Debug.AddWarning("SQL Error => In function dbgestor.author.modAuthor");
                return false;
            }
        }
    }
}
