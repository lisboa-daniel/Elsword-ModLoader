namespace oPatcher
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnPlay = new System.Windows.Forms.Button();
            this.lstMods = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModEnable = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eraseAllModsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMods = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.filemodded = new System.Windows.Forms.DataGridView();
            this.file = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filemoddedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filelistDBDataSet1 = new oPatcher.filelistDBDataSet1();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showOPatcherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableModsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filemoddedTableAdapter = new oPatcher.filelistDBDataSet1TableAdapters.filemoddedTableAdapter();
            this.tableAdapterManager = new oPatcher.filelistDBDataSet1TableAdapters.TableAdapterManager();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filemodded)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filemoddedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filelistDBDataSet1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.Location = new System.Drawing.Point(12, 229);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(221, 51);
            this.btnPlay.TabIndex = 10;
            this.btnPlay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            this.btnPlay.MouseLeave += new System.EventHandler(this.btnPlay_MouseLeave);
            this.btnPlay.MouseHover += new System.EventHandler(this.btnPlay_MouseHover);
            // 
            // lstMods
            // 
            this.lstMods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.lstMods.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstMods.Font = new System.Drawing.Font("Blambot Pro Lite", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMods.FormattingEnabled = true;
            this.lstMods.ItemHeight = 15;
            this.lstMods.Location = new System.Drawing.Point(12, 63);
            this.lstMods.Name = "lstMods";
            this.lstMods.Size = new System.Drawing.Size(221, 105);
            this.lstMods.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Blambot Pro Lite", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mods Enabled:";
            // 
            // btnModEnable
            // 
            this.btnModEnable.BackColor = System.Drawing.Color.Transparent;
            this.btnModEnable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnModEnable.FlatAppearance.BorderSize = 0;
            this.btnModEnable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnModEnable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnModEnable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModEnable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnModEnable.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnModEnable.Image = ((System.Drawing.Image)(resources.GetObject("btnModEnable.Image")));
            this.btnModEnable.Location = new System.Drawing.Point(161, 30);
            this.btnModEnable.Name = "btnModEnable";
            this.btnModEnable.Size = new System.Drawing.Size(75, 32);
            this.btnModEnable.TabIndex = 7;
            this.btnModEnable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnModEnable.UseVisualStyleBackColor = false;
            this.btnModEnable.Click += new System.EventHandler(this.btnModEnable_Click);
            this.btnModEnable.MouseEnter += new System.EventHandler(this.btnModEnable_MouseEnter);
            this.btnModEnable.MouseLeave += new System.EventHandler(this.btnModEnable_MouseLeave);
            this.btnModEnable.MouseHover += new System.EventHandler(this.btnModEnable_MouseHover_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.menuStrip1.Font = new System.Drawing.Font("Blambot Pro Lite", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.actionsToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(246, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.restartToolStripMenuItem.Text = "Reboot";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eraseAllModsToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // eraseAllModsToolStripMenuItem
            // 
            this.eraseAllModsToolStripMenuItem.Name = "eraseAllModsToolStripMenuItem";
            this.eraseAllModsToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.eraseAllModsToolStripMenuItem.Text = "Erase all mods";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // btnMods
            // 
            this.btnMods.BackColor = System.Drawing.Color.Transparent;
            this.btnMods.FlatAppearance.BorderSize = 0;
            this.btnMods.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnMods.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMods.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMods.Image = global::oPatcher.Properties.Resources.btn_managemods1;
            this.btnMods.Location = new System.Drawing.Point(12, 190);
            this.btnMods.Name = "btnMods";
            this.btnMods.Size = new System.Drawing.Size(221, 46);
            this.btnMods.TabIndex = 11;
            this.btnMods.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMods.UseVisualStyleBackColor = false;
            this.btnMods.Click += new System.EventHandler(this.btnMods_Click);
            this.btnMods.MouseLeave += new System.EventHandler(this.btnMods_MouseLeave);
            this.btnMods.MouseHover += new System.EventHandler(this.btnMods_MouseHover);
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.Transparent;
            this.btnApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApply.FlatAppearance.BorderSize = 0;
            this.btnApply.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnApply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnApply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Image = global::oPatcher.Properties.Resources.btn_apply;
            this.btnApply.Location = new System.Drawing.Point(9, 278);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(224, 40);
            this.btnApply.TabIndex = 12;
            this.btnApply.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            this.btnApply.MouseLeave += new System.EventHandler(this.btnApply_MouseLeave);
            this.btnApply.MouseHover += new System.EventHandler(this.btnApply_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // filemodded
            // 
            this.filemodded.AutoGenerateColumns = false;
            this.filemodded.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filemodded.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.file,
            this.mod});
            this.filemodded.DataSource = this.filemoddedBindingSource;
            this.filemodded.Location = new System.Drawing.Point(271, 76);
            this.filemodded.Name = "filemodded";
            this.filemodded.Size = new System.Drawing.Size(342, 220);
            this.filemodded.TabIndex = 14;
            // 
            // file
            // 
            this.file.DataPropertyName = "File";
            this.file.HeaderText = "File";
            this.file.Name = "file";
            // 
            // mod
            // 
            this.mod.DataPropertyName = "Modded";
            this.mod.HeaderText = "Modded";
            this.mod.Name = "mod";
            // 
            // filemoddedBindingSource
            // 
            this.filemoddedBindingSource.DataMember = "filemodded";
            this.filemoddedBindingSource.DataSource = this.filelistDBDataSet1;
            // 
            // filelistDBDataSet1
            // 
            this.filelistDBDataSet1.DataSetName = "filelistDBDataSet1";
            this.filelistDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "ElsOrigin Patcher";
            this.notifyIcon.Click += new System.EventHandler(this.notifyIcon_Click);
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showOPatcherToolStripMenuItem,
            this.disableModsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(154, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // showOPatcherToolStripMenuItem
            // 
            this.showOPatcherToolStripMenuItem.Name = "showOPatcherToolStripMenuItem";
            this.showOPatcherToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.showOPatcherToolStripMenuItem.Text = "Show oPatcher";
            // 
            // disableModsToolStripMenuItem
            // 
            this.disableModsToolStripMenuItem.Name = "disableModsToolStripMenuItem";
            this.disableModsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.disableModsToolStripMenuItem.Text = "Enable Mods";
            this.disableModsToolStripMenuItem.Click += new System.EventHandler(this.disableModsToolStripMenuItem_Click);
            // 
            // filemoddedTableAdapter
            // 
            this.filemoddedTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.filemoddedTableAdapter = this.filemoddedTableAdapter;
            this.tableAdapterManager.UpdateOrder = oPatcher.filelistDBDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::oPatcher.Properties.Resources.home_bg1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(246, 353);
            this.Controls.Add(this.filemodded);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnMods);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lstMods);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnModEnable);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ElsOrigin Patcher";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Enter += new System.EventHandler(this.Form1_Enter);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filemodded)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filemoddedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filelistDBDataSet1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.ListBox lstMods;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModEnable;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eraseAllModsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnMods;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label label2;
        private filelistDBDataSet1 filelistDBDataSet1;
        private System.Windows.Forms.BindingSource filemoddedBindingSource;
        private filelistDBDataSet1TableAdapters.filemoddedTableAdapter filemoddedTableAdapter;
        private filelistDBDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView filemodded;
        private System.Windows.Forms.DataGridViewTextBoxColumn file;
        private System.Windows.Forms.DataGridViewTextBoxColumn mod;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showOPatcherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disableModsToolStripMenuItem;
    }
}

