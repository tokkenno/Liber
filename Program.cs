using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PSLibrary.G11N;
using PSLibrary.Debug;

namespace Liber
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            g11n.Init(g11n.Languages.EN, g11n.Countries.US);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new fInit());
            Debug.Close();
        }
    }
}
