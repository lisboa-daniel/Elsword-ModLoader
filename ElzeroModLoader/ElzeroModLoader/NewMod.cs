using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElzeroModLoader {
    public partial class NewMod : Form {

        public bool changed = false;
        public NewMod() {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) {
            if (changed)
            {
                DialogResult msg = MessageBox.Show("Didn't saved. Are you sure you want close anyway?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (msg == DialogResult.Yes)
                {
                    Close();
                }
            } 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            changed = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            changed = true;
        }
    }
}
