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
using System.Xml.Serialization;

namespace Zadaca2
{
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }
       
      
        private void btNajava_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormNajava formNajava = new FormNajava();
            formNajava.ShowDialog();
        }

        private void btRegistracija_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegistracija formRegistracija = new FormRegistracija();
            formRegistracija.ShowDialog();
        }

        private void btSettings_Click(object sender, EventArgs e)
        {
            SettingsFileForm settingsFile = new SettingsFileForm();
            settingsFile.ShowDialog();
        }

        private void FormStart_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
