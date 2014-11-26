using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using PSLibrary.Debug;

namespace Liber.dbgestor
{
    public static class rss
    {
        private static LiberDBDataContext DB = new LiberDBDataContext();

        public static Boolean addRss(li_rss rss)
        {
            try
            {
                DB.li_rss.InsertOnSubmit(rss);
                DB.SubmitChanges();
                return true;
            }
            catch
            {
                Debug.AddWarning("SQL Error => In function dbgestor.rss.addRss");
                return false;
            }
        }

        public static ArrayList listRss()
        {
            ArrayList lista = new ArrayList();

            try
            {
                var vRss = DB.ExecuteQuery<li_rss>("select * from liber.li_rss");

                foreach (var m in vRss)
                {
                    lista.Add(m);
                }
            }
            catch
            {
                Debug.AddWarning("SQL Error => In function dbgestor.rss.listRss");
            }

            return lista;
        }

        public static ArrayList listRssByDNI(String DNI)
        {
            ArrayList lista = new ArrayList();

            try
            {
                var vRss = DB.ExecuteQuery<li_rss>("select * from liber.li_rss");

                foreach (var m in vRss)
                {
                    if (m.DNI == DNI)
                        lista.Add(m);
                }
            }
            catch
            {
                Debug.AddWarning("SQL Error => In function dbgestor.rss.listRssByDNI");
            }

            return lista;
        }

        public static String newID()
        {
            Random r = new Random();
            String num = r.Next(9999999).ToString();

            foreach (li_rss boo in listRss())
            {
                if (boo.ID_rss == num)
                {
                    return newID();
                }
            }

            return num;
        }

        public static Boolean delRssByDNI(String DNI)
        {
            Boolean op = true;

            foreach (li_statistics st in listRssByDNI(DNI))
            {
                try
                {
                    DB.li_statistics.DeleteOnSubmit(st);
                    DB.SubmitChanges();
                }
                catch
                {
                    Debug.AddWarning("SQL Error => In function dbgestor.rss.delRssByDNI");
                    op = false;
                }
            }

            return op;
        }
    }
}
