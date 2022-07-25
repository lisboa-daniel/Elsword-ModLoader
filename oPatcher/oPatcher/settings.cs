using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace oPatcher
{
    public partial class Settings : Form
    {
        public SettingsControl settings_options = new SettingsControl();
        public string workerDirectory;
        public string musicDirectory;
        string appPath = AppContext.BaseDirectory;

        

        public Settings()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }   

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            txtLauncherPath.Text = settings_options.launcherPath;
            ckb_alwaysmin.Checked = settings_options.startMinimized;
            ckb_mWhenStart.Checked = settings_options.minWhenStart;
            ckb_startWithWindows.Checked = settings_options.startWithWindows;
        }

        private void btn_Apply_Click(object sender, EventArgs e)
        {
            string appSettings_string_xml;

            System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(settings_options.GetType());

            using (StringWriter textWriter = new StringWriter())
            {
                x.Serialize(textWriter, settings_options);
                appSettings_string_xml = textWriter.ToString();

            }

            File.WriteAllText(appPath + "appSettings.xml", appSettings_string_xml);

            btn_Apply.Enabled = false;
        }

        private void ckb_mWhenStart_CheckedChanged(object sender, EventArgs e)
        {
            btn_Apply.Enabled = true;
       
            settings_options.minWhenStart = ckb_mWhenStart.Checked;
          
        }

        private void ckb_startWithWindows_CheckedChanged(object sender, EventArgs e)
        {
            btn_Apply.Enabled = true;
            settings_options.startWithWindows = ckb_startWithWindows.Checked;
            
        }

        private void ckb_alwaysmin_CheckedChanged(object sender, EventArgs e)
        {
            btn_Apply.Enabled = true;
            settings_options.startMinimized = ckb_alwaysmin.Checked;
        }

        private void txtLauncherPath_TextChanged(object sender, EventArgs e)
        {
            btn_Apply.Enabled = true;
            
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string fileString = pathElsorigin.FileName.ToString();
            string fileName = "elsorigin.exe";
            workerDirectory = fileString.TrimEnd(fileName.ToCharArray());
            musicDirectory = workerDirectory + "data\\music";
            txtLauncherPath.Text = fileString;
            settings_options.launcherPath = txtLauncherPath.Text;
        }

        private void btnLocate_Click(object sender, EventArgs e)
        {
            pathElsorigin.ShowDialog();
        }
    }
}
