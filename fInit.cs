using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Liber
{
    public partial class fInit : Form
    {
        public fInit()
        {
            InitializeComponent();

            this.progressBar1.Style = ProgressBarStyle.Marquee;
            this.lInit.Text = "Initiating...";

            this.tTick.Start();
        }

        private void tTick_Tick(object sender, EventArgs e)
        {
            // Hacemos una llamada a la base de datos para iniciarla ya
            // que si es la primera vez que ejecutamos el programa o hay algún
            // disco duro parado, tarda horrores en iniciar el programa. Así
            // la iniciamos mientras se muestra una pantalla de carga.
            dbgestor.books.newID();

            this.tTick.Stop();

            this.Hide();
            new fLogin().ShowDialog();
        }
    }
}
