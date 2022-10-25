using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Zadaca2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static string connectionString;
        public static string serverName;
        public static string dataBaseName;
        [STAThread]

        static void Main()
        {
            try
            {
                if (File.Exists("DataBaseInfo.xml"))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(Settings));
                    FileStream read = new FileStream("DataBaseInfo.xml", FileMode.Open, FileAccess.Read, FileShare.Read);
                    Settings s = (Settings)xs.Deserialize(read);
                    serverName = s.DataBaseServerName;
                    dataBaseName = s.DataBaseName;
                    connectionString = ($"Server= {serverName}; Database= {dataBaseName}; Integrated Security=True;");
                    read.Close();
                    
                }
                else
                {
                    MessageBox.Show("Креирајте конекција со дата база!");
                    FormFunctions form = new FormFunctions();
                    form.ShowDialog();
                }
            }
            catch
            {
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormStart());
        }
    }
}
