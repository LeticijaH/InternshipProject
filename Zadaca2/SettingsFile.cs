using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Zadaca2
{
    public partial class SettingsFileForm : Form
    {
        public SettingsFileForm()
        {
            InitializeComponent();
        }
        
        private void btSettingsFileCreate_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    if(string.IsNullOrEmpty(tbDataBaseName.Text)||string.IsNullOrEmpty(tbServerName.Text))
                    {
                        MessageBox.Show("Пополнете ги правилно празните полиња!");
                        return;
                    }
                }
                catch
                {
                }
                Settings settings = new Settings();
                settings.DataBaseName = tbDataBaseName.Text;
                settings.DataBaseServerName = tbServerName.Text;

               
                settings.SaveInXml(settings, "DataBaseInfo.xml");
                
                MessageBox.Show("Успешно е зачуван фајлот со името на серверот и дата базата!\n" +
                    "За да биде успешно поврзувањето со дата базата стартувајте ја програмата!");

                Application.Exit();
            }
            catch
            {
                MessageBox.Show("Има проблем со поврзување со дата база!");
            }
        }
    }
}
