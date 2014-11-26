using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using PSLibrary.Debug;
using System.Xml.Linq;

namespace Liber
{
    public static class Preferences
    {
        private static Boolean isLoad = false;
        private static Boolean consoledebug;
        private static Boolean filedebug;
        private static Boolean allowdownloads;

        public static void Load()
        {
            if (!File.Exists("./" + "config.xml"))
            {
                createPrefDefaults();
            }

            ReadConf("./" + "config.xml");

            isLoad = true;
        }

        private static void ReadConf(String file)
        {
            try
            {
                XmlDocument xmldoc = new XmlDocument();
                xmldoc.Load(file);

                XmlNodeList Configuration = xmldoc.GetElementsByTagName("Configuration");

                foreach (XmlElement nodo in Configuration)
                {
                    try
                    {
                        XmlNodeList xCD = nodo.GetElementsByTagName("ConsoleDebug");
                        consoledebug = System.Convert.ToBoolean(xCD[0].InnerText);
                    }
                    catch { }

                    try
                    {
                        XmlNodeList xFD = nodo.GetElementsByTagName("FileDebug");
                        filedebug = System.Convert.ToBoolean(xFD[0].InnerText);
                    }
                    catch { }

                    try
                    {
                        XmlNodeList xAD = nodo.GetElementsByTagName("AllowDownloads");
                        allowdownloads = System.Convert.ToBoolean(xAD[0].InnerText);
                    }
                    catch { }
                }
            }
            catch
            {
                Debug.AddError("Error while load configuration archive.");
            }
        }

        private static void createPrefDefaults()
        {
            consoledebug = false;
            filedebug = false;
            allowdownloads = true;

            Save();
        }

        public static Boolean Save()
        {
            try
            {
                File.Delete("./" + "config.xml");

                XDocument miXML = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XElement("Configuration",
                    new XElement("ConsoleDebug", consoledebug),
                    new XElement("AllowDownloads", allowdownloads),
                    new XElement("FileDebug", filedebug))
                );

                miXML.Save("./config.xml");

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static Boolean CONSOLEDEBUG
        {
            get 
            {
                if (!isLoad)
                    Load();
                return consoledebug; 
            }
            set
            {
                consoledebug = value;
            }
        }

        public static Boolean FILEDEBUG
        {
            get
            {
                if (!isLoad)
                    Load();
                return filedebug;
            }
            set
            {
                filedebug = value;
            }
        }

        public static Boolean ALLOWDOWNLOADS
        {
            get
            {
                if (!isLoad)
                    Load();
                return allowdownloads;
            }
            set
            {
                allowdownloads = value;
            }
        }
    }
}
