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


namespace oPatcher
{
    public partial class editEntry : Form
    {

        public string entryFile;
        public List<string> modListEdit = new List<string>();
        public string selectedMod;
        public string selectedModFile;
        public string selectedModArtist;
        public string selectedModTitle;
        public string selectedModCod;

        AppPaths paths = new AppPaths();

        public Boolean checkModFile(string file, string modName)
        {
            string path = paths.mods + modName + "\\" + file;
            if (System.IO.File.Exists(path))
            {
                lbl_stats.BackColor = System.Drawing.Color.Lime;
                lbl_stats.Text = "Found";
                btn_apply.Enabled = true;
                return true;
            }
            else
            {
                lbl_stats.BackColor = System.Drawing.Color.Red;
                lbl_stats.Text = "Not Found";
                btn_apply.Enabled = false;
                return false;
            }
        }

        public void CheckEntry()
        {
            ///Check if the mod is working
            if (checkModFile(entryFile, selectedMod))
            {

                
                //retrive metadata from file
                
                txt_file.Text = paths.mods + selectedMod + "\\" + entryFile;
                var meta = TagLib.File.Create(@txt_file.Text);
                var tag = meta.Tag;

                txt_title.Text = tag.Title;
                foreach(string artist in tag.Performers)
                {
                    txt_artist.Text = artist + "; ";
                }




            }
            else
            {
                //set metadata to defaults messages
                txt_artist.Text = "Artist not found";
                txt_title.Text = "Title of the music not found";
                txt_file.Text = "File not found";

                if (cbx_modlist.SelectedIndex == 0) btn_apply.Enabled = true;
            }
        }

        public editEntry()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

   
        private void editEntry_Load(object sender, EventArgs e)
        {

            ///Put things in list selector combobox for mod

            cbx_modlist.DataSource = modListEdit;
            cbx_modlist.Text = selectedMod;
            CheckEntry();
        }

        private void cbx_modlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedMod = cbx_modlist.Text;
            CheckEntry();
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            int code = Int16.Parse(selectedModCod);
            if (cbx_modlist.SelectedIndex != 0) filemoddedTableAdapter.UpdateModded(selectedMod , code);
            else if (!checkModFile(entryFile, selectedMod)) filemoddedTableAdapter.UpdateModded("", code);
            filemoddedTableAdapter.Update(filelistDBDataSet1);
           
            this.Close();
        }
    }
}
