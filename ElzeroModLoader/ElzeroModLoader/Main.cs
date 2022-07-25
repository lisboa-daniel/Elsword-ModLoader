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
    public partial class Main : Form
    {
        public MainSettings settings;
        public string cfgJson;
        public SettingsForm f = new SettingsForm();

        public List<ModPack> modList = new List<ModPack>();
        public List<string> mods = new List<string>();

        public Main()
        {
            InitializeComponent();

        }

        private void Main_Load(object sender, EventArgs e)
        {
            settings = new MainSettings();
            try
            {
                StreamReader file = File.OpenText(settings.JsonFileName);
                cfgJson = file.ReadToEnd();
                settings = JsonConvert.DeserializeObject<MainSettings>(cfgJson);
                file.Close();

                
            }
            catch(FileNotFoundException) { 
            
            
            }

            


            if (settings.GameLocation == null)
            {
                //MessageBox.Show("Game location was not set, please select a valid ELZero game location");
                
                f.settings = settings;
                f.ShowDialog();
            } else
            {
                string[] dirs;
                if (settings.CustomModsRepository != null)
                    dirs = Directory.GetDirectories(settings.CustomModsRepository);
                else dirs = Directory.GetDirectories(settings.ModsRepository);

                ModPack t = new ModPack("First Mod Pack", dirs, null);

                modList.Add(t);

                foreach(ModPack mod in modList)
                {
                    mods.Add(mod.modName);
                }

                listBox1.DataSource = mods;
            }
        }

 

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f.settings = settings;
            f.ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
            foreach(ModPack mod in modList)
            {
                if (listBox1.SelectedItem == mod.modName)
                {
                    string mods = "";
                    for(int i =0; i < mod.modFolders.Length; i++)
                    {
                        mods += "\n" + mod.modFolders[i];
                    }
                    MessageBox.Show(mods);
                }
            }
            
        }

        private void newModPackToolStripMenuItem_Click(object sender, EventArgs e) {
            NewMod f = new NewMod();
            f.ShowDialog();

        }
    }
}
