namespace oPatcher
{
    partial class Newmod
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtModname = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.modListFinal = new oPatcher.modListFinal();
            this.modsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modsTableAdapter = new oPatcher.modListFinalTableAdapters.modsTableAdapter();
            this.tableAdapterManager = new oPatcher.modListFinalTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.modListFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // txtModname
            // 
            this.txtModname.Location = new System.Drawing.Point(12, 56);
            this.txtModname.Name = "txtModname";
            this.txtModname.Size = new System.Drawing.Size(296, 20);
            this.txtModname.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(233, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // modListFinal
            // 
            this.modListFinal.DataSetName = "modListFinal";
            this.modListFinal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // modsBindingSource
            // 
            this.modsBindingSource.DataMember = "mods";
            this.modsBindingSource.DataSource = this.modListFinal;
            // 
            // modsTableAdapter
            // 
            this.modsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.modsTableAdapter = this.modsTableAdapter;
            this.tableAdapterManager.UpdateOrder = oPatcher.modListFinalTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Newmod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 149);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtModname);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Newmod";
            this.ShowInTaskbar = false;
            this.Text = "Newmod";
            this.Load += new System.EventHandler(this.Newmod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.modListFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtModname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private modListFinal modListFinal;
        private System.Windows.Forms.BindingSource modsBindingSource;
        private modListFinalTableAdapters.modsTableAdapter modsTableAdapter;
        private modListFinalTableAdapters.TableAdapterManager tableAdapterManager;
    }
}