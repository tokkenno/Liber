using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using PSLibrary.Debug;

namespace Liber.dbgestor
{
    public static class preferences
    {
        private static LiberDBDataContext DB = new LiberDBDataContext();

        public static Boolean initPreferences(li_user user)
        {
            li_basic_preferences bPref = new li_basic_preferences();
            bPref.ID_preferences = newID();
            bPref.DNI = user.DNI;
            bPref.US_lang = null;
            bPref.US_formatp = "PDF";
            bPref.US_dinamics = false;

            try
            {
                DB.li_basic_preferences.InsertOnSubmit(bPref);
                DB.SubmitChanges();
                return true;
            }
            catch
            {
                Debug.AddWarning("SQL Error => In function dbgestor.preferences.initPreferences");
                return false;
            }
        }

        public static Boolean modPreferences(li_basic_preferences pref)
        {
            try
            {
                IQueryable<li_basic_preferences> cust = from c in DB.li_basic_preferences where c.ID_preferences == pref.ID_preferences select c;

                if (cust.Count() > 0)
                {
                    cust.First().ID_preferences = pref.ID_preferences;
                    cust.First().DNI = pref.DNI;
                    cust.First().US_lang = pref.US_lang;
                    cust.First().US_formatp = pref.US_formatp;
                    cust.First().US_dinamics = pref.US_dinamics;
                    DB.SubmitChanges();
                }

                return true;
            }
            catch
            {
                Debug.AddWarning("SQL Error => In function dbgestor.preferences.modPreferences");
                return false;
            }
        }

        public static ArrayList listPreferences()
        {
            ArrayList lista = new ArrayList();

            try
            {
                var vAuthor = DB.ExecuteQuery<li_basic_preferences>("select * from liber.li_basic_preferences");

                foreach (var m in vAuthor)
                {
                    lista.Add(m);
                }
            }
            catch
            {
                Debug.AddWarning("SQL Error => In function dbgestor.preferences.listPreferences");
            }

            return lista;
        }

        public static li_basic_preferences getPreferencesByDNI(String DNI)
        {
            try
            {
                var vUser = DB.ExecuteQuery<li_basic_preferences>("select * from liber.li_basic_preferences where DNI = " + DNI);

                foreach (li_basic_preferences au in vUser)
                {
                    return au;
                }
            }
            catch
            {
                Debug.AddWarning("SQL Error => In function dbgestor.preferences.getPreferencesByDNI for DNI-" + DNI);
            }

            return null;
        }

        public static String newID()
        {
            Random r = new Random();
            String num = r.Next(9999999).ToString();

            foreach (li_basic_preferences boo in listPreferences())
            {
                if (boo.ID_preferences == num)
                {
                    return newID();
                }
            }

            return num;
        }

    }
}
