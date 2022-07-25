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

namespace oPatcher
{
    public partial class ManageMods : Form
    {
        public ManageMods()
        {
            InitializeComponent();
        }

        private void filelistBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
        }
        Form1 home = new Form1();
 
        string appPath = AppContext.BaseDirectory;
        List<string> modList = new List<string>();
        string appSettings_string_xml;
        AppPaths paths = new AppPaths();
        
        private void ManageMods_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'modListFinal.mods'. Você pode movê-la ou removê-la conforme necessário.
            this.modsTableAdapter.Fill(this.modListFinal.mods);

            // TODO: esta linha de código carrega dados na tabela 'filelistDBDataSet1.filemodded'. Você pode movê-la ou removê-la conforme necessário.
            this.filemoddedTableAdapter.Fill(this.filelistDBDataSet1.filemodded);
            modList.Add("-- Select one mod ---");
            label1.Text = modlstDBDataSet.GetXml().ToString();
            string[] modsExists = Directory.GetDirectories(appPath + "mods");

            BindingSource bs = new BindingSource();

            foreach(string mod in modsExists)
            {
                modList.Add(new DirectoryInfo(mod).Name);
                bs.Add(new DirectoryInfo(mod).Name);
            }

            
            lstModlist.DataSource = modList;

            for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (!String.IsNullOrEmpty(dataGridView1.Rows[i].Cells["moddedDataGridColumn"].Value.ToString()))
                {
                    string item = dataGridView1.Rows[i].Cells["moddedDataGridColumn"].Value.ToString();
                    if (home.settings.activeMods.IndexOf(item) < 0) home.settings.activeMods.Add(item);
                }
            }

           
            saveSettings();

        }

        

        private void filelistDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Newmod newmod = new Newmod();
            newmod.ShowDialog();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0) this.filemoddedTableAdapter.Fill(this.filelistDBDataSet1.filemodded);
            else this.filemoddedTableAdapter.FillByPvP(this.filelistDBDataSet1.filemodded);
        }

        private void filemoddedBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.filemoddedBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.filelistDBDataSet1);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && e.ColumnIndex == 5)
            {
                ///button plus action
                editEntry editMod = new editEntry();

                if (e.RowIndex >= 0)
                {
                    editMod.entryFile = senderGrid.Rows[e.RowIndex].Cells["FileDataGridColumn"].Value.ToString();
                    editMod.Text = editMod.entryFile;
                    editMod.selectedMod = senderGrid.Rows[e.RowIndex].Cells["moddedDataGridColumn"].Value.ToString();


                }
                else editMod.entryFile = "-1";

                string code = senderGrid.Rows[e.RowIndex].Cells["code"].Value.ToString();
                editMod.selectedModCod = code;
                editMod.modListEdit = modList;



                editMod.ShowDialog();

            }


            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && e.ColumnIndex == 4)
            {
                string mod = senderGrid.Rows[e.RowIndex].Cells["moddedDataGridColumn"].Value.ToString();
                string file = senderGrid.Rows[e.RowIndex].Cells["FileDataGridColumn"].Value.ToString();
                string filepath = paths.mods + mod + "\\" + file;
                OpenWithDefaultProgram(filepath);
            }
        }

        private void lstModlist_DataSourceChanged(object sender, EventArgs e)
        {         
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ManageMods_Leave(object sender, EventArgs e)
        {

        }

        private void ManageMods_Enter(object sender, EventArgs e)
        {
          
        }

        private void ManageMods_Activated(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0) this.filemoddedTableAdapter.Fill(this.filelistDBDataSet1.filemodded);
            else this.filemoddedTableAdapter.FillByPvP(this.filelistDBDataSet1.filemodded);

            filemoddedTableAdapter.Update(filelistDBDataSet1);
            dataGridView1.Update();
            dataGridView1.Refresh();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (!String.IsNullOrEmpty(dataGridView1.Rows[i].Cells["moddedDataGridColumn"].Value.ToString()))
                {
                    string item = dataGridView1.Rows[i].Cells["moddedDataGridColumn"].Value.ToString();
                    if (home.settings.activeMods.IndexOf(item) < 0) home.settings.activeMods.Add(item);
                }
            }

            saveSettings();

        }

        private void filemoddedDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && e.ColumnIndex == 5)
            {
                ///button plus action
                editEntry editMod = new editEntry();

                if (e.RowIndex >= 0)
                {
                    editMod.entryFile = senderGrid.Rows[e.RowIndex].Cells["FileDataGridColumn2"].Value.ToString();
                    editMod.Text = editMod.entryFile;
                    editMod.selectedMod = senderGrid.Rows[e.RowIndex].Cells["moddedDataGridColumn2"].Value.ToString();
                  
                }
                else editMod.entryFile = "-1";

                string code = senderGrid.Rows[e.RowIndex].Cells["code2"].Value.ToString();

                
                editMod.selectedModCod = code;
                editMod.modListEdit = modList;



                editMod.ShowDialog();

            }

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && e.ColumnIndex == 4)
            {
                string mod = senderGrid.Rows[e.RowIndex].Cells["moddedDataGridColumn2"].Value.ToString();
                string file = senderGrid.Rows[e.RowIndex].Cells["FileDataGridColumn2"].Value.ToString();
                string filepath = paths.mods + mod + "\\" + file;
                OpenWithDefaultProgram(filepath);
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            readSettings();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (!String.IsNullOrEmpty(dataGridView1.Rows[i].Cells["FileDataGridColumn"].Value.ToString()))
                {
                    string file = dataGridView1.Rows[i].Cells["FileDataGridColumn"].Value.ToString();
                    int fileid = Int16.Parse(dataGridView1.Rows[i].Cells["code"].Value.ToString());
                    string mod = lstModlist.Text;
                    string[] filemods = Directory.GetFiles(paths.mods + mod);
                    int d = 0;
                    for (int x = 0; x < filemods.Length; x++)
                    {
                        

                        if (filemods[x].Contains(file))
                        {
                            filemoddedTableAdapter.UpdateModded(mod, fileid);
                            filemoddedTableAdapter.Update(filelistDBDataSet1);
                        }
                    }
                }
            }




            ////////update database
            dataGridView1.Update();
            dataGridView1.Refresh();
            if (tabControl1.SelectedIndex == 0) this.filemoddedTableAdapter.Fill(this.filelistDBDataSet1.filemodded);
            else this.filemoddedTableAdapter.FillByPvP(this.filelistDBDataSet1.filemodded);

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (!String.IsNullOrEmpty(dataGridView1.Rows[i].Cells["moddedDataGridColumn"].Value.ToString()))
                {
                    string item = dataGridView1.Rows[i].Cells["moddedDataGridColumn"].Value.ToString();
                    if (home.settings.activeMods.IndexOf(item) < 0) home.settings.activeMods.Add(item);
                }
            }

            saveSettings();
        }

        public static void OpenWithDefaultProgram(string path)
        {
            Process fileopener = new Process();
            fileopener.StartInfo.FileName = "explorer";
            fileopener.StartInfo.Arguments = "\"" + path + "\"";
            fileopener.Start();
        }

        public void saveSettings()
        {

            List<string> tempmod = home.settings.activeMods;
            readSettings();

            home.settings.activeMods = tempmod;

            System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(home.settings.GetType());

            using (StringWriter textWriter = new StringWriter())
            {
                x.Serialize(textWriter, home.settings);
                appSettings_string_xml = textWriter.ToString();

            }

            File.WriteAllText(appPath + "appSettings.xml", appSettings_string_xml);
        }

        public void readSettings()
        {
            XmlSerializer x = new XmlSerializer(typeof(SettingsControl));
            StreamReader reader = new StreamReader(appPath + "appSettings.xml");
            home.settings = (SettingsControl)x.Deserialize(reader);
            reader.Close();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            EditMod editmod = new EditMod();
            editmod.modEditingName = lstModlist.Text;
            editmod.ShowDialog();
        }

        private void lstModlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstModlist.SelectedIndex > 0) btn_edit.Enabled = true; else btn_edit.Enabled = false;
            btnApply.Enabled = btn_edit.Enabled;
        }
    }
}
