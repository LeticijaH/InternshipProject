using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Xml;

namespace Zadaca2
{
    public class Settings
    {
        private string _dataBaseName;
        private string _dataBaseServerName;
        public string DataBaseName { get { return _dataBaseName; } set { _dataBaseName = value; } }
        public string DataBaseServerName { get { return _dataBaseServerName; } set { _dataBaseServerName = value; } }

        public void SaveInXml(Settings s, string fileName)
        {
            if (File.Exists(fileName))
            {
                XmlSerializer xs = new XmlSerializer(typeof(Settings));
                using(StreamWriter sw = new StreamWriter("DataBaseInfo.xml"))
                {
                    xs.Serialize(sw, s);
                }
            }
            else 
            {
                XmlSerializer xml = new XmlSerializer(typeof(Settings));
                TextWriter tw = new StreamWriter(fileName, false);
                xml.Serialize(tw, s);
                tw.Close();
            }
        }
    }
}
