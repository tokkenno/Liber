using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using PSLibrary.Debug;

namespace Liber.dbgestor
{
    public static class user
    {
        private static LiberDBDataContext DB = new LiberDBDataContext();

        public static Boolean addUser(li_user user)
        {
            try
            {
                DB.li_user.InsertOnSubmit(user);
                DB.SubmitChanges();
                return true;
            }
            catch
            {
                Debug.AddWarning("SQL Error => In function dbgestor.user.addUser");
                return false;
            }
        }

        public static ArrayList listUser()
        {
            ArrayList lista = new ArrayList();

            try
            {
                var vUser = DB.ExecuteQuery<li_user>("select * from liber.li_user");

                foreach (var m in vUser)
                {
                    lista.Add(m);
                }
            }
            catch
            {
                Debug.AddWarning("SQL Error => In function dbgestor.user.listUser");
            }

            return lista;
        }

        public static Int32 numUser()
        {
            Int32 num = 0;

            try
            {
                var vUser = DB.ExecuteQuery<li_user>("select * from liber.li_user");

                foreach (var m in vUser)
                {
                    num++;
                }

                return num;
            }
            catch
            {
                Debug.AddWarning("SQL Error => In function dbgestor.user.numUser");
                return -1;
            }
        }

        public static Int32 numAdmin()
        {
            Int32 num = 0;

            try
            {
                var vUser = DB.ExecuteQuery<li_user>("select * from liber.li_user");

                foreach (var m in vUser)
                {
                    if (m.typeu == "administrator")
                        num++;
                }

                return num;
            }
            catch
            {
                Debug.AddWarning("SQL Error => In function dbgestor.user.numAdmin");
                return -1;
            }
        }

        public static Boolean modUser(li_user user)
        {
            try
            {
                IQueryable<li_user> cust = from c in DB.li_user where c.DNI == user.DNI select c;

                if (cust.Count() == 1)
                {
                    cust.First().DNI = user.DNI;
                    cust.First().firstname = user.firstname;
                    cust.First().lastname = user.lastname;
                    cust.First().birthday = user.birthday;
                    cust.First().email = user.email;
                    cust.First().passwd = user.passwd;
                    cust.First().direction = user.direction;
                    cust.First().phone = user.phone;
                    cust.First().typeu = user.typeu;
                    cust.First().nickname = user.nickname;
                    DB.SubmitChanges();
                }

                return true;
            }
            catch
            {
                Debug.AddWarning("SQL Error => In function dbgestor.user.modUser");
                return false;
            }
        }
    }
}
