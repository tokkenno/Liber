using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using PSLibrary.Debug;

namespace Liber.dbgestor
{
    public static class documents
    {
        private static LiberDBDataContext DB = new LiberDBDataContext();

        public static Boolean addDocument(li_documents docs)
        {
            try
            {
                DB.li_documents.InsertOnSubmit(docs);
                DB.SubmitChanges();
                return true;
            }
            catch
            {
                Debug.AddWarning("SQL Error => In function dbgestor.documents.addDocument");
                return false;
            }
        }

        public static ArrayList listDocuments()
        {
            ArrayList lista = new ArrayList();

            try
            {
                var vDocs = DB.ExecuteQuery<li_documents>("select * from liber.li_documents");

                foreach (var m in vDocs)
                {
                    lista.Add(m);
                }
            }
            catch
            {
                Debug.AddWarning("SQL Error => In function dbgestor.documents.listDocuments");
            }

            return lista;
        }

        public static ArrayList listDocumentsByBookID(String ID)
        {
            ArrayList lista = new ArrayList();

            try
            {
                var vDocs = DB.ExecuteQuery<li_documents>("select * from liber.li_documents");

                foreach (var m in vDocs)
                {
                    if (m.ID_book == ID)
                        lista.Add(m);
                }
            }
            catch
            {
                Debug.AddWarning("SQL Error => In function dbgestor.documents.listDocuments");
            }

            return lista;
        }

        public static li_documents getDocumentByID(String ID)
        {
            ArrayList lista = new ArrayList();

            try
            {
                var vDocs = DB.ExecuteQuery<li_documents>("select * from liber.li_documents where ID_publication = " + ID);
                return vDocs.First<li_documents>();
            }
            catch
            {
                Debug.AddWarning("SQL Error => In function dbgestor.documents.getDocumentByID");
            }

            return null;
        }

        public static String newID()
        {
            Random r = new Random();
            String num = r.Next(9999999).ToString();

            foreach (li_documents boo in listDocuments())
            {
                if (boo.ID_publication == num)
                {
                    return newID();
                }
            }

            return num;
        }
    }
}
