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
using System.Xml.Linq;

namespace oPatcher
{
    public partial class Newmod : Form
    {
        public Newmod()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string appPath = AppContext.BaseDirectory;
        Boolean validate = false;

        private void button1_Click(object sender, EventArgs e)
        {

            Mod addmod = new Mod();
            addmod.modName = txtModname.Text;
            addmod.modPathFolder = appPath + "mods\\" + txtModname.Text;

            List<string> modFlist = new List<string>();

            XElement x = new XElement("ModList", modFlist.Select(i => new XElement("branch", i)));
            addmod.modFileList = x.ToString();

          
           
            EditMod editmod = new EditMod();

            if (!Directory.Exists(appPath + "mods")) Directory.CreateDirectory(appPath + "mods");
            if (!Directory.Exists(addmod.modPathFolder))
            {
                

                modsTableAdapter.Insert(addmod.modName, addmod.modPathFolder, addmod.modFileList);
                modsTableAdapter.Update(modListFinal);
                Directory.CreateDirectory(addmod.modPathFolder);

                editmod.modEditingName = txtModname.Text;
                this.Close();
                editmod.ShowDialog();


                
            }
            else
            {

                MessageBox.Show("Already have an mod is that name");
            }
            
            
         



            
        }

        

    

        public void Newmod_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'modListFinal.mods'. Você pode movê-la ou removê-la conforme necessário.
            this.modsTableAdapter.Fill(this.modListFinal.mods);



        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
           

        }

        private void modsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.modsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.modListFinal);

        }
    }
}
