using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using PSLibrary.Debug;

namespace Liber.dbgestor
{
    public static class statistic
    {
        private static LiberDBDataContext DB = new LiberDBDataContext();

        public static ArrayList listStatistic()
        {
            ArrayList lista = new ArrayList();

            try
            {
                var vSta = DB.ExecuteQuery<li_statistics>("select * from liber.li_statistics");

                foreach (var m in vSta)
                {
                    lista.Add(m);
                }
            }
            catch
            {
                Debug.AddWarning("SQL Error => In function dbgestor.statistic.listStatistic");
            }

            return lista;
        }

        public static ArrayList listStatisticByDNI(String DNI)
        {
            ArrayList lista = new ArrayList();

            try
            {
                var vSta = DB.ExecuteQuery<li_statistics>("select * from liber.li_statistics");

                foreach (var m in vSta)
                {
                    if (m.DNI == DNI)
                        lista.Add(m);
                }
            }
            catch
            {
                Debug.AddWarning("SQL Error => In function dbgestor.statistic.listStatisticByDNI");
            }

            return lista;
        }

        public static Boolean delBookByDNI(String DNI)
        {
            Boolean op = true;

            foreach (li_statistics st in listStatisticByDNI(DNI))
            {
                try
                {
                    DB.li_statistics.DeleteOnSubmit(st);
                    DB.SubmitChanges();
                }
                catch
                {
                    Debug.AddWarning("SQL Error => In function dbgestor.statistics.delBookByDNI");
                    op = false;
                }
            }

            return op;
        }
    }
}
