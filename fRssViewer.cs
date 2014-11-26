using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PSLibrary.G11N;

namespace Liber
{
    public partial class fRssViewer : Form
    {
        li_user actualUser;

        public fRssViewer(li_user usuario)
        {
            InitializeComponent();

            this.Icon = Properties.Resources.icon;

            this.actualUser = usuario;

            setText();
            LoadDat();
        }

        private void LoadDat()
        {
            foreach (li_rss lRss in dbgestor.rss.listRssByDNI(actualUser.DNI))
            {
                try
                {
                    Uri Url = new Uri(lRss.link);
                    this.rssReader.Items.Add(new PSLibrary.Apps.RSSItems.Rss(lRss.name, Url));
                }
                catch
                {
                    // Si existe algun error al crear el objeto Rss, es porque el link está mal, así que borra el registro.
                    dbgestor.rss.delRssByDNI(lRss.DNI);
                }
            }

            this.rssReader.UpdateTreeView();
        }

        private void setText()
        {
            this.Text = "Liber - " + g11n.getTranslateString("Rss Manager");

            this.bClose.Text = g11n.getTranslateString("Close");
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            foreach (PSLibrary.Apps.RSSItems.Rss lRss in this.rssReader.Items)
            {
                Boolean exist = false;

                foreach (li_rss dbRss in dbgestor.rss.listRssByDNI(actualUser.DNI))
                {
                    if (dbRss.link == lRss.Url.ToString())
                    {
                        exist = true;
                        break;
                    }
                }

                if (!exist)
                {
                    li_rss newaux = new li_rss();
                    newaux.DNI = actualUser.DNI;
                    newaux.ID_rss = dbgestor.rss.newID();
                    newaux.link = lRss.Url.ToString();
                    newaux.name = lRss.Name;

                    dbgestor.rss.addRss(newaux);
                }
            }

            this.Close();
        }
    }
}
