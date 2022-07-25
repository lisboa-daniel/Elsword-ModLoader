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
using System.Xml;
using System.Xml.Serialization;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace oPatcher
{
    public partial class Form1 : Form
    {

        public Boolean modsEnabled = true;
        public Boolean applied = false;

        public Form1()
        {
            InitializeComponent();
        }

        public SettingsControl settings = new SettingsControl();
        string appPath = AppContext.BaseDirectory;
        AppPaths paths = new AppPaths();
        List<string> modList = new List<string>();
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'filelistDBDataSet1.filemodded'. Você pode movê-la ou removê-la conforme necessário.
            this.filemoddedTableAdapter.Fill(this.filelistDBDataSet1.filemodded);


            if (!File.Exists(appPath + "appSettings.xml"))
            {
                settings.launcherPath = "";
                settings.minWhenStart = true;
                settings.startMinimized = false;
                settings.startWithWindows = false;
                string appSettings_string_xml;

                System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(settings.GetType());
                
                using(StringWriter textWriter = new StringWriter())
                {
                    x.Serialize(textWriter, settings);
                    appSettings_string_xml = textWriter.ToString();

                }

                File.WriteAllText(appPath + "appSettings.xml", appSettings_string_xml);
                
            } else
            {
                readSettings();
            }

            if (Directory.Exists(appPath + "mods"))
            {
                modList = settings.activeMods;
                lstMods.DataSource = modList;
            }

            notifyIcon.Visible = true;

        }

        private void btnMods_Click(object sender, EventArgs e)
        {
            ManageMods managemods = new ManageMods();
            managemods.ShowDialog();
        }

        private void btnModEnable_Click(object sender, EventArgs e)
        {
            modsEnabled = !modsEnabled;
            if (modsEnabled)
            {
                //btnModEnable.Text = "ON";
              
                //btnPlay.Text = "Apply and Play";
                btnModEnable.Image = oPatcher.Properties.Resources.btn_stats_off;
                btnPlay.Image = oPatcher.Properties.Resources.btn_play_off;
            } else
            {
                //btnModEnable.Text = "OFF";
               
                //btnPlay.Text = "Play without Mods";
                btnModEnable.Image = oPatcher.Properties.Resources.btn_stats_on;
                btnPlay.Image = oPatcher.Properties.Resources.btn_play;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings settings_form = new Settings();
            settings_form.settings_options = settings;
            settings_form.ShowDialog();
        }

        private void Form1_Enter(object sender, EventArgs e)
        {
            readSettings();

            if (Directory.Exists(appPath + "mods"))
            {
                modList = settings.activeMods;
                lstMods.DataSource = modList;
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            this.filemoddedTableAdapter.Fill(this.filelistDBDataSet1.filemodded);

            readSettings();

            if (Directory.Exists(appPath + "mods"))
            {
                modList = settings.activeMods;
                lstMods.DataSource = modList;
            }
        }

        public void readSettings()
        {
            XmlSerializer x = new XmlSerializer(typeof(SettingsControl));
            StreamReader reader = new StreamReader(appPath + "appSettings.xml");
            settings = (SettingsControl)x.Deserialize(reader);
            reader.Close();
        }


        public class MemoryRead
        {
            const int PROCESS_WM_READ = 0x0010;

            [DllImport("kernel32.dll")]
            public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

            [DllImport("kernel32.dll")]
            public static extern bool ReadProcessMemory(int hProcess, int lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);

            public static string Main(int value)
            {

                Process process = Process.GetProcessesByName("elsorigin")[0];
                IntPtr processHandle = OpenProcess(PROCESS_WM_READ, false, process.Id);

                int bytesRead = 0;
                byte[] buffer = new byte[12 * 8]; //'Hello World!' takes 12*2 bytes because of Unicode 

                // 0x0046A3B8 is the address where I found the string, replace it with what you found
                ReadProcessMemory((int)processHandle, value, buffer, buffer.Length, ref bytesRead);

                return (Encoding.Unicode.GetString(buffer) + " (" + bytesRead.ToString() + "bytes)");


            }
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {

            

             Process[] pname = Process.GetProcessesByName("elsorigin");

            if (pname.Length > 0)
            {
                label2.Text = "Launcher is running";
                label2.Text = MemoryRead.Main(0x00525A04);
            }

            


        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (!applied)
            {


                if (!Directory.Exists(paths.cache))
                {

                    Directory.CreateDirectory(paths.cache);
                }

                Boolean verify = false;
                List<string> ocurrences = new List<string>();

                foreach (string mod in lstMods.Items)
                {


                    for (int i = 0; i < filemodded.Rows.Count; i++)
                    {
                        string filemod = ""; string filetoMoveName = "";
                        if (filemodded.Rows[i].Cells["mod"].Value != null) filemod = filemodded.Rows[i].Cells["mod"].Value.ToString();
                        if (filemodded.Rows[i].Cells["file"].Value != null) filetoMoveName = filemodded.Rows[i].Cells["file"].Value.ToString();

                        if (filemod != "" && filemod != null)
                        {
                            if (filemod == mod)
                            {
                                if (File.Exists(settings.launcherPath.TrimEnd("elsorigin.exe".ToCharArray()) + "data\\" + "music" + "\\" + filetoMoveName))
                                {
                                    File.Move(settings.launcherPath.TrimEnd("elsorigin.exe".ToCharArray()) + "data\\" + "music" + "\\" + filetoMoveName
                                   , paths.cache + filetoMoveName);

                                    File.Move(paths.mods + mod + "\\" + filetoMoveName, settings.launcherPath.TrimEnd("elsorigin.exe".ToCharArray()) + "data\\" + "music" + "\\" + filetoMoveName);
                                    verify = true;
                                }
                                else
                                {
                                    MessageBox.Show("The file " + filetoMoveName + " doesnt exist in the game folder! in the path: " + settings.launcherPath.TrimEnd("elsorigin.exe".ToCharArray()) + "data\\" + "music" + "\\" + filetoMoveName);
                                    ocurrences.Add(filetoMoveName);
                                }

                            }
                        }
                    }

                }

                if (verify)
                {
                    this.Hide();
                    contextMenuStrip1.Items[1].Text = "Disable Mods";
                    notifyIcon.Visible = true;

                    if (ocurrences.Count == 0)
                    {

                        notifyIcon.BalloonTipTitle = "gPatcher Status";
                        notifyIcon.BalloonTipText = "Mods Applied Succefully!";
                        notifyIcon.BalloonTipIcon = ToolTipIcon.Info;

                        notifyIcon.ShowBalloonTip(10);
                    }
                    else
                    {

                        string errors = "";
                        foreach (string error in ocurrences)
                        {
                            errors += error + "\n ";
                        }

                        notifyIcon.BalloonTipTitle = "gPatcher Status";
                        notifyIcon.BalloonTipText = "Mods Applied with theses ocurrences: \n" + errors;
                        notifyIcon.BalloonTipIcon = ToolTipIcon.Warning;

                        notifyIcon.ShowBalloonTip(10);
                    }
                    applied = true;
                   

                }
                else
                {
                    MessageBox.Show("Cannot apply any file to game directory", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                foreach (string mod in lstMods.Items)
                {
                    for (int i = 0; i < filemodded.Rows.Count; i++)
                    {
                        string filemod = ""; string filetoMoveName = "";
                        if (filemodded.Rows[i].Cells["mod"].Value != null) filemod = filemodded.Rows[i].Cells["mod"].Value.ToString();
                        if (filemodded.Rows[i].Cells["file"].Value != null) filetoMoveName = filemodded.Rows[i].Cells["file"].Value.ToString();

                        if (filemod != "" && filemod != null)
                        {
                            if (filemod == mod)
                            {
                                File.Move(settings.launcherPath.TrimEnd("elsorigin.exe".ToCharArray()) + "data\\" + "music" + "\\" + filetoMoveName
                                    , paths.mods + mod + "\\" + filetoMoveName);

                                File.Move(paths.cache + filetoMoveName,
                                    settings.launcherPath.TrimEnd("elsorigin.exe".ToCharArray()) + "data\\" + "music" + "\\" + filetoMoveName);
                            }
                        }
                    }
                }

                applied = false;
                btnApply.Image = oPatcher.Properties.Resources.btn_apply_off;
            }
        }

        private void filemoddedBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.filemoddedBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.filelistDBDataSet1);

        }

        private void notifyIcon_Click(object sender, EventArgs e)
        {
           
          
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void disableModsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (disableModsToolStripMenuItem.Text == "Disable Mods")
            {

            } else
            {

            }
        }

        private void btnModEnable_MouseEnter(object sender, EventArgs e)
        {
            


        }

        private void btnModEnable_MouseHover(object sender, EventArgs e)
        {
            if (modsEnabled) btnModEnable.Image = oPatcher.Properties.Resources.btn_stats_on_hilight;
            else btnModEnable.Image = oPatcher.Properties.Resources.btn_stats_off_hilight;




        }

        private void btnMods_MouseHover(object sender, EventArgs e)
        {
            btnMods.Image = oPatcher.Properties.Resources.btn_managemods_hilight;
        }

        private void btnApply_MouseHover(object sender, EventArgs e)
        {
            if (!applied) btnApply.Image = oPatcher.Properties.Resources.btn_apply_hilight;
            else btnApply.Image = oPatcher.Properties.Resources.disable_mods_0_hilight;

           
        }

        private void btnModEnable_MouseHover_1(object sender, EventArgs e)
        {
            
        }

        private void btnModEnable_MouseLeave(object sender, EventArgs e)
        {
            if (modsEnabled) btnModEnable.Image = oPatcher.Properties.Resources.btn_stats_on;
            else btnModEnable.Image = oPatcher.Properties.Resources.btn_stats_off;
        }

        private void btnMods_MouseLeave(object sender, EventArgs e)
        {
            btnMods.Image = oPatcher.Properties.Resources.btn_managemods;
        }

        private void btnPlay_MouseLeave(object sender, EventArgs e)
        {
            if (modsEnabled) btnPlay.Image = oPatcher.Properties.Resources.btn_play;
            else btnModEnable.Image = oPatcher.Properties.Resources.btn_play_off;
        }

        private void btnApply_MouseLeave(object sender, EventArgs e)
        {
            if (!applied) btnApply.Image = oPatcher.Properties.Resources.btn_apply;
            else btnApply.Image = oPatcher.Properties.Resources.disable_mods_0;
        }

        private void btnPlay_MouseHover(object sender, EventArgs e)
        {
            if (modsEnabled) btnPlay.Image = oPatcher.Properties.Resources.btn_play_hilight;
            else btnModEnable.Image = oPatcher.Properties.Resources.btn_play_off_hilight;
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            notifyIcon.Visible = false;
            this.Show();
        }
    }
}
