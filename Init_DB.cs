using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PSLibrary.Debug;

namespace Liber
{
    public static class Init_DB
    {
        public static void CheckandCreate()
        {
            if (dbgestor.author.getAuthorByID("0000000") == null)
            {
                li_author author = new li_author();
                author.ID_author = "0000000";
                author.firstname = "";
                author.lastname = "";

                dbgestor.author.addAuthor(author);
                Debug.AddInformative("Added null author to the database");
            }

            if (dbgestor.author.getAuthorByID("9999999") == null)
            {
                li_author author = new li_author();
                author.ID_author = "9999999";
                author.firstname = "Anonymous";
                author.lastname = "";

                dbgestor.author.addAuthor(author);
                Debug.AddInformative("Added anonymous author to the database");
            }

            if (dbgestor.saga.getSagaByID("0000000") == null)
            {
                li_saga saga = new li_saga();
                saga.ID_saga = "0000000";
                saga.name = "";
                saga.typep = "none";

                dbgestor.saga.addSaga(saga);
                Debug.AddInformative("Added empty saga to the database");
            }
        }
    }
}
