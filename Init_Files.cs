using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using PSLibrary.Debug;

namespace Liber
{
    public static class Init_Files
    {
        public static void CheckandCreate()
        {
            // Comprobamos los idiomas
            if (!Directory.Exists("./lang"))
            {
                Directory.CreateDirectory("./lang");
                Debug.AddInformative("Folder ~/lang has been created");

                // Y descomprimir los idiomas
            }

            // Comprobamos la ayuda
            if (!Directory.Exists("./help"))
            {
                Directory.CreateDirectory("./help");
                Debug.AddInformative("Folder ~/help has been created");

                // Y descomprimir las ayudas
            }

            // Comprobamos las carpetas de la base de datos
            if (!Directory.Exists("./db"))
            {
                Directory.CreateDirectory("./db");
                Debug.AddInformative("Folder ~/db has been created");
            }

            if (!Directory.Exists("./db/files"))
            {
                Directory.CreateDirectory("./db/files");
                Debug.AddInformative("Folder ~/db/files has been created");
            }
            if (!Directory.Exists("./db/img"))
            {
                Directory.CreateDirectory("./db/img");
                Debug.AddInformative("Folder ~/db/img has been created");
            }
        }
    }
}
