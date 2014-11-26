using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using PSLibrary.Debug;

namespace Liber.dbgestor
{
    public static class saga
    {
        private static LiberDBDataContext DB = new LiberDBDataContext();

        public static String[] saga_list = new String[] { "none", "trilogy", "enciclopedy", "volumes", "newspaper", "magazine", "course" };

        public static Boolean addSaga(li_saga saga)
        {
            try
            {
                DB.li_saga.InsertOnSubmit(saga);
                DB.SubmitChanges();
                return true;
            }
            catch
            {
                Debug.AddWarning("SQL Error => In function dbgestor.saga.addSaga");
                return false;
            }
        }

        public static ArrayList listSaga()
        {
            ArrayList lista = new ArrayList();

            try
            {
                var vSaga = DB.ExecuteQuery<li_saga>("select * from liber.li_saga");

                foreach (var m in vSaga)
                {
                    lista.Add(m);
                }
            }
            catch
            {
                Debug.AddWarning("SQL Error => In function dbgestor.saga.listSaga");
            }

            return lista;
        }

        public static li_saga getSagaByID(String ID)
        {
            ArrayList lista = new ArrayList();

            try
            {
                var vSaga = DB.ExecuteQuery<li_saga>("select * from liber.li_saga where ID_saga = " + ID);

                foreach (var m in vSaga)
                {
                    return m;
                }
            }
            catch
            {
                Debug.AddWarning("SQL Error => In function dbgestor.saga.getSagaByID");
            }

            return null;
        }

        public static String newID()
        {
            Random r = new Random();
            String num = r.Next(9999999).ToString();

            foreach (li_saga boo in listSaga())
            {
                if (boo.ID_saga == num)
                {
                    return newID();
                }
            }

            return num;
        }
    }
}
