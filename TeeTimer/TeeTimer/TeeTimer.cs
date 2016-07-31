using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace TeeTimer
{
    public partial class TeeTimer : Form
    {
        public XmlDocument db = new XmlDocument();
        public TeeTimer()
        {
            InitializeComponent();
        }

        private void TeeTimer_Load(object sender, EventArgs e)
        {
            //Initiierung
            this.db = InitDB();

            lblStatus.Text = "Version : " + typeof(TeeTimer).Assembly.GetName().Version.ToString();
            splitContainer.IsSplitterFixed = true;
            splitContainer.SplitterDistance = 250;

            var tmp = db.SelectNodes("//Lieferanten/Lieferant");
            //cbLieferant.DataSource = tmp;

        }

        private XmlDocument InitDB()
        {
            XmlDocument db = new XmlDocument();

            if (File.Exists("TeeDB.xml"))
            {
                //lade die Daten aus der xml
                db.LoadXml(File.ReadAllText("TeeDB.xml"));
            }
            else
            {
                //neue, leere Datenbank erstellen
                try
                {
                    //Leere DB erstellen
                    XmlDeclaration xmldeclaration = db.CreateXmlDeclaration("1.0", "UTF-8", null);
                    db.AppendChild(xmldeclaration);
                    XmlElement root = db.CreateElement("Datenbank");
                    root.AppendChild(db.CreateElement("Teesorten"));
                    root.AppendChild(db.CreateElement("Lieferanten"));
                    root.AppendChild(db.CreateElement("Tees"));
                    db.AppendChild(root);

                    //DB speichern
                    File.WriteAllText("TeeDB.xml", db.InnerXml);
                }
                catch (Exception exc)
                {
                    throw new Exception("Programm wird auf Grund eines Fehlers abgebrochen.");
                }
            }

            return db;
        }
    }
}
