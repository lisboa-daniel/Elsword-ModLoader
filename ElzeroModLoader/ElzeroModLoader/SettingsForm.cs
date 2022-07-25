using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ElzeroModLoader
{
    public partial class SettingsForm : Form
    {

        public MainSettings settings;
        public bool SettingChanged = false;

        //public MainSettings settings; 
        private void SettingsForm_Load(object sender, EventArgs e)
        {

            SettingsStatusUpdate();
            
            SettingChanged = false;
            btnApply.Enabled = false;

            if (settings.CustomModsRepository != null)
            {
                checkBox1.Enabled = true;
                checkBox1.Checked = false;

            }
        }
        public string[] SettingsCheck(string directory)
        {
            string[] checks = new string[3];

            if ((directory != null) && (directory != "")){
                foreach (string files in Directory.GetDirectories(directory))
                {
                    if (files == directory + "\\mods")
                    {
                        checks[1] = files;
                        break;
                    }
                }

                foreach (string files in Directory.GetFiles(directory))
                {
                    if (files.Contains(directory + "\\ELZeroLauncher.exe"))
                    {
                        checks[0] = directory;
                        break;
                    }
                }
            }

            return checks;
        }

        public void SettingsStatusUpdate() {

           
            btnApply.Enabled = true;
            string[] checking = SettingsCheck(settings.GameLocation);
            SettingChanged = true;

            settings.GameLocation = checking[0];
            settings.ModFolderLocation = checking[1];

            if (settings.CustomModsRepository == null)
            {
                txtModRepository.Text = settings.ModsRepository;
            } else
            {
                txtModRepository.Text = settings.CustomModsRepository;
            }


            if (settings.GameLocation != null){
                txtGameLocation.Text = settings.GameLocation;
            } else
            {
                DialogResult msg = MessageBox.Show("Please selected a valid ELZero instalation folder.", "Not valid path",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (settings.ModFolderLocation != null)
            {
                btnModFolder.Visible = false;
                txtMods.Text = settings.ModFolderLocation;
                lblStatus.Text = "\n * mods folder was succeful located!";
                lblStatus.ForeColor = Color.Green;
            }
            else
            {
                btnModFolder.Visible = true;
                lblStatus.Text = "\n * mods folder was NOT located, click button to create or check your game location again.";
                lblStatus.ForeColor = Color.Red;
            }
        }

        public void ApplySettings() {
            JsonSerializer json = new JsonSerializer();
            string jsonString = JsonConvert.SerializeObject(settings, Formatting.Indented);
            File.WriteAllTextAsync(settings.JsonFileName, jsonString);
            btnApply.Enabled = false;
            SettingChanged = false;

        }

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_FormClosed(object sender, FormClosingEventArgs e)
        {
           if (SettingChanged){
                DialogResult msg = MessageBox.Show("Changes not saved detected, apply and close?", "Warning",
                MessageBoxButtons.YesNoCancel,MessageBoxIcon.Warning);
                e.Cancel = (msg == DialogResult.Cancel);
                if (msg == DialogResult.Yes)
                {
                    ApplySettings();
                }
            }
        }

        private void txtMods_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnModFolder_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(settings.GameLocation)){
                if (!Directory.Exists(settings.GameLocation + "\\mods")){
                    Directory.CreateDirectory(settings.GameLocation + "\\mods");
                }
            }

            SettingsStatusUpdate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dirDialog = new FolderBrowserDialog();
            dirDialog.ShowDialog();
            settings.GameLocation = dirDialog.SelectedPath;



            SettingsStatusUpdate();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            ApplySettings();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void tp0_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {

            if (checkBox1.Checked)
            {
                checkBox1.Enabled = false;
                settings.CustomModsRepository = null;
            }
            
            SettingsStatusUpdate();
        }

        private void button2_Click(object sender, EventArgs e) {
            
            checkBox1.Checked = false;
            checkBox1.Enabled = true;

            FolderBrowserDialog dirDialog = new FolderBrowserDialog();
            
            dirDialog.ShowDialog();
            settings.CustomModsRepository = dirDialog.SelectedPath;
            SettingsStatusUpdate();
        }
    }
}
