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
    public partial class EditMod : Form
    {
        public string modEditingName;
        string modPath;
        AppPaths paths = new AppPaths();
        string[] modFileList;
        public string fileChanged = "-1";

        public EditMod()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void filelistBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.filelistBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.filelistDBDataSet);

        }


        List<string> changedFiles = new List<string>();

        public void CheckBoxMods(DataGridView grid)
        {
            for (var i = 0; i < grid.RowCount; i++)
            {
                string filePvP = grid.Rows[i].Cells[1].Value.ToString();
                modFileList = Directory.GetFiles(modPath);
                foreach (string modFile in modFileList)
                {
                    if (Path.GetFileName(modFile).Contains(filePvP))
                    {
                        grid.Rows[i].Cells[0].Value = true;
                     
                    }
                }
            }
        }

        private void EditMod_Load(object sender, EventArgs e)
        {
         
           


            // TODO: esta linha de código carrega dados na tabela 'filelistDBDataSet.filelist'. Você pode movê-la ou removê-la conforme necessário.
            if (tabControl1.SelectedIndex == 1)
            {
                this.filelistTableAdapter.FillByPvP(this.filelistDBDataSet.filelist);
            }
            else
            {
                this.filelistTableAdapter.Fill(this.filelistDBDataSet.filelist);
            }
            this.Text = modEditingName;
            txtModname.Text = modEditingName;

            modPath = paths.mods + modEditingName;
            modFileList = Directory.GetFiles(modPath);

            for(var i = 0; i < dataGridView1.RowCount; i++)
            {
                string filePvP = dataGridView1.Rows[i].Cells["fileColumn2"].Value.ToString();
                foreach(string modFile in modFileList)
                {
                    if (Path.GetFileName(modFile).Contains(filePvP))
                    {
                        dataGridView1.Rows[i].Cells["checkModded2"].Value = true;
                        filelistDataGridView.Rows[i].Cells["checkModded"].Value = true;

                        changedFiles.Add(filePvP);
                    }
                }
            }

           


        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                this.filelistTableAdapter.Fill(this.filelistDBDataSet.filelist);
                CheckBoxMods(filelistDataGridView);
            } else
            {
                
                this.filelistTableAdapter.FillByPvP(this.filelistDBDataSet.filelist);
                CheckBoxMods(dataGridView1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                
                fileChanged = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                openFIle.ShowDialog();


            }
        }


        private void openFIle_FileOk(object sender, CancelEventArgs e)
        {

            if (!Directory.Exists(paths.root + "temp")) Directory.CreateDirectory(paths.root + "temp");

            string filePath = openFIle.FileName;
            string fileext = Path.GetExtension(filePath);
            string tempFilePath = paths.root + "temp\\" + "converttemp" + fileext;
          

            string destinationFIle;


            if (fileext != ".ogg")
            {
                DialogResult result =  MessageBox.Show("Do you want to convert the file to .ogg? (Experimental func can cause bugs)","This file isnt a .ogg file!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                
                if (result ==  DialogResult.Yes)

                {
                    File.Copy(openFIle.FileName, tempFilePath);
                    destinationFIle = fileChanged;



                    string batString = "ffmpeg -i " + "converttemp" + fileext + " " + destinationFIle;
                    File.WriteAllText(paths.root + "temp\\" + "convert.bat", batString);

                    process1.StartInfo.FileName = paths.root + "temp\\" + "convert.bat";
                    process1.StartInfo.WorkingDirectory = paths.root + "temp";
                    process1.Start();
                    process1.WaitForExit();

                    if (process1.HasExited)
                    {
                        File.GetAccessControl(paths.root + "temp\\converttemp" + fileext);
                        File.Delete(paths.root + "temp\\" + "convert.bat");

                        File.Delete(paths.root + "temp\\converttemp" + fileext);

                        File.Move(paths.root + "temp\\" + fileChanged, paths.mods + txtModname.Text + "\\" + fileChanged);
                        Directory.Delete(paths.root + "temp");
                    }
                }
                

            } else
            {
                destinationFIle = paths.mods + txtModname.Text + "\\" + fileChanged;
                if (!File.Exists(destinationFIle)) File.Copy(filePath, destinationFIle); else
                {
                    File.Delete(destinationFIle);
                    File.Copy(filePath, destinationFIle);
                }
            }


            if (tabControl1.SelectedIndex == 0) CheckBoxMods(filelistDataGridView);
            else CheckBoxMods(dataGridView1);


        }

        private void filelistDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                
                fileChanged = filelistDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                openFIle.ShowDialog();



            }
        }

        private void process1_Exited(object sender, EventArgs e)
        {
            
        }

        private void EditMod_Enter(object sender, EventArgs e)
        {
           
        }

        private void EditMod_Activate(object sender, EventArgs e)
        {
            
        }

        private void EditMod_Leave(object sender, EventArgs e)
        {

        }
    }
}
