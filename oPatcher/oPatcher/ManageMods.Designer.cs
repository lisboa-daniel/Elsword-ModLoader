namespace oPatcher
{
    partial class ManageMods
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lstModlist = new System.Windows.Forms.ComboBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.filemoddedDataGridView = new System.Windows.Forms.DataGridView();
            this.filemoddedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filelistDBDataSet1 = new oPatcher.filelistDBDataSet1();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.modsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modListFinalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modListFinal = new oPatcher.modListFinal();
            this.filemoddedTableAdapter = new oPatcher.filelistDBDataSet1TableAdapters.filemoddedTableAdapter();
            this.tableAdapterManager = new oPatcher.filelistDBDataSet1TableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingModlist = new System.Windows.Forms.BindingSource(this.components);
            this.modlstDBDataSet = new oPatcher.modlstDBDataSet();
            this.modsTableAdapter = new oPatcher.modListFinalTableAdapters.modsTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileDataGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moddedDataGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnlisten = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAdd2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.code2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileDataGridColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moddedDataGridColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnlisten2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAdd = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filemoddedDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filemoddedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filelistDBDataSet1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modListFinalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modListFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingModlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modlstDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lstModlist
            // 
            this.lstModlist.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lstModlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstModlist.ForeColor = System.Drawing.SystemColors.Info;
            this.lstModlist.FormattingEnabled = true;
            this.lstModlist.Location = new System.Drawing.Point(18, 14);
            this.lstModlist.Margin = new System.Windows.Forms.Padding(4);
            this.lstModlist.Name = "lstModlist";
            this.lstModlist.Size = new System.Drawing.Size(430, 23);
            this.lstModlist.TabIndex = 2;
            this.lstModlist.SelectedIndexChanged += new System.EventHandler(this.lstModlist_SelectedIndexChanged);
            this.lstModlist.DataSourceChanged += new System.EventHandler(this.lstModlist_DataSourceChanged);
            // 
            // btnApply
            // 
            this.btnApply.Enabled = false;
            this.btnApply.Location = new System.Drawing.Point(474, 14);
            this.btnApply.Margin = new System.Windows.Forms.Padding(4);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(112, 26);
            this.btnApply.TabIndex = 3;
            this.btnApply.Text = "Apply for all";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(595, 14);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(112, 26);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(18, 47);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(883, 304);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.filemoddedDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(875, 276);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "[BGM] ALL";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // filemoddedDataGridView
            // 
            this.filemoddedDataGridView.AllowUserToAddRows = false;
            this.filemoddedDataGridView.AllowUserToDeleteRows = false;
            this.filemoddedDataGridView.AutoGenerateColumns = false;
            this.filemoddedDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.filemoddedDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.filemoddedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filemoddedDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code2,
            this.FileDataGridColumn2,
            this.descriptionDataGridColumn2,
            this.moddedDataGridColumn2,
            this.btnlisten2,
            this.btnAdd});
            this.filemoddedDataGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.filemoddedDataGridView.DataSource = this.filemoddedBindingSource;
            this.filemoddedDataGridView.Location = new System.Drawing.Point(-43, -2);
            this.filemoddedDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.filemoddedDataGridView.MultiSelect = false;
            this.filemoddedDataGridView.Name = "filemoddedDataGridView";
            this.filemoddedDataGridView.ReadOnly = true;
            this.filemoddedDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.filemoddedDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.filemoddedDataGridView.ShowCellErrors = false;
            this.filemoddedDataGridView.ShowCellToolTips = false;
            this.filemoddedDataGridView.ShowEditingIcon = false;
            this.filemoddedDataGridView.ShowRowErrors = false;
            this.filemoddedDataGridView.Size = new System.Drawing.Size(922, 274);
            this.filemoddedDataGridView.TabIndex = 2;
            this.filemoddedDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.filemoddedDataGridView_CellContentClick);
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(875, 276);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "[BGM] PvP";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code,
            this.FileDataGridColumn,
            this.descriptionDataGridColumn,
            this.moddedDataGridColumn,
            this.btnlisten,
            this.btnAdd2});
            this.dataGridView1.DataSource = this.filemoddedBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-43, -2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(922, 274);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // modsBindingSource
            // 
            this.modsBindingSource.DataMember = "mods";
            this.modsBindingSource.DataSource = this.modListFinalBindingSource;
            // 
            // modListFinalBindingSource
            // 
            this.modListFinalBindingSource.DataSource = this.modListFinal;
            this.modListFinalBindingSource.Position = 0;
            // 
            // modListFinal
            // 
            this.modListFinal.DataSetName = "modListFinal";
            this.modListFinal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1002, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // bindingModlist
            // 
            this.bindingModlist.DataSource = this.modlstDBDataSet;
            this.bindingModlist.Position = 0;
            // 
            // modlstDBDataSet
            // 
            this.modlstDBDataSet.DataSetName = "modlstDBDataSet";
            this.modlstDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // modsTableAdapter
            // 
            this.modsTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1002, 164);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // btn_edit
            // 
            this.btn_edit.Enabled = false;
            this.btn_edit.Location = new System.Drawing.Point(717, 14);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(112, 26);
            this.btn_edit.TabIndex = 8;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(768, 358);
            this.btn_OK.Margin = new System.Windows.Forms.Padding(4);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(112, 26);
            this.btn_OK.TabIndex = 9;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // code
            // 
            this.code.DataPropertyName = "Código";
            this.code.HeaderText = "   ";
            this.code.Name = "code";
            this.code.ReadOnly = true;
            this.code.Visible = false;
            this.code.Width = 45;
            // 
            // FileDataGridColumn
            // 
            this.FileDataGridColumn.DataPropertyName = "File";
            this.FileDataGridColumn.HeaderText = "File";
            this.FileDataGridColumn.Name = "FileDataGridColumn";
            this.FileDataGridColumn.ReadOnly = true;
            this.FileDataGridColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // descriptionDataGridColumn
            // 
            this.descriptionDataGridColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridColumn.DataPropertyName = "Description";
            this.descriptionDataGridColumn.FillWeight = 248.2759F;
            this.descriptionDataGridColumn.HeaderText = "Description";
            this.descriptionDataGridColumn.Name = "descriptionDataGridColumn";
            this.descriptionDataGridColumn.ReadOnly = true;
            // 
            // moddedDataGridColumn
            // 
            this.moddedDataGridColumn.DataPropertyName = "Modded";
            this.moddedDataGridColumn.FillWeight = 10.55594F;
            this.moddedDataGridColumn.HeaderText = "Modded";
            this.moddedDataGridColumn.Name = "moddedDataGridColumn";
            this.moddedDataGridColumn.ReadOnly = true;
            // 
            // btnlisten
            // 
            this.btnlisten.HeaderText = "";
            this.btnlisten.Name = "btnlisten";
            this.btnlisten.ReadOnly = true;
            this.btnlisten.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnlisten.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnlisten.Text = ">";
            this.btnlisten.UseColumnTextForButtonValue = true;
            this.btnlisten.Width = 35;
            // 
            // btnAdd2
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.btnAdd2.DefaultCellStyle = dataGridViewCellStyle2;
            this.btnAdd2.FillWeight = 41.16819F;
            this.btnAdd2.HeaderText = "    ";
            this.btnAdd2.Name = "btnAdd2";
            this.btnAdd2.ReadOnly = true;
            this.btnAdd2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnAdd2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnAdd2.Text = "+";
            this.btnAdd2.UseColumnTextForButtonValue = true;
            this.btnAdd2.Width = 40;
            // 
            // code2
            // 
            this.code2.DataPropertyName = "Código";
            this.code2.HeaderText = "";
            this.code2.Name = "code2";
            this.code2.ReadOnly = true;
            this.code2.Visible = false;
            // 
            // FileDataGridColumn2
            // 
            this.FileDataGridColumn2.DataPropertyName = "File";
            this.FileDataGridColumn2.HeaderText = "File";
            this.FileDataGridColumn2.Name = "FileDataGridColumn2";
            this.FileDataGridColumn2.ReadOnly = true;
            // 
            // descriptionDataGridColumn2
            // 
            this.descriptionDataGridColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridColumn2.DataPropertyName = "Description";
            this.descriptionDataGridColumn2.HeaderText = "Description";
            this.descriptionDataGridColumn2.Name = "descriptionDataGridColumn2";
            this.descriptionDataGridColumn2.ReadOnly = true;
            // 
            // moddedDataGridColumn2
            // 
            this.moddedDataGridColumn2.DataPropertyName = "Modded";
            this.moddedDataGridColumn2.HeaderText = "Modded";
            this.moddedDataGridColumn2.Name = "moddedDataGridColumn2";
            this.moddedDataGridColumn2.ReadOnly = true;
            // 
            // btnlisten2
            // 
            this.btnlisten2.HeaderText = "";
            this.btnlisten2.Name = "btnlisten2";
            this.btnlisten2.ReadOnly = true;
            this.btnlisten2.Text = ">";
            this.btnlisten2.UseColumnTextForButtonValue = true;
            this.btnlisten2.Width = 35;
            // 
            // btnAdd
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.DefaultCellStyle = dataGridViewCellStyle1;
            this.btnAdd.HeaderText = "";
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ReadOnly = true;
            this.btnAdd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnAdd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnAdd.Text = "+";
            this.btnAdd.UseColumnTextForButtonValue = true;
            this.btnAdd.Width = 40;
            // 
            // ManageMods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::oPatcher.Properties.Resources.default_bg;
            this.ClientSize = new System.Drawing.Size(904, 390);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.lstModlist);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Blambot Pro Lite", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(920, 429);
            this.MinimumSize = new System.Drawing.Size(920, 429);
            this.Name = "ManageMods";
            this.Text = "Manage Mods";
            this.Activated += new System.EventHandler(this.ManageMods_Activated);
            this.Load += new System.EventHandler(this.ManageMods_Load);
            this.Enter += new System.EventHandler(this.ManageMods_Enter);
            this.Leave += new System.EventHandler(this.ManageMods_Leave);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.filemoddedDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filemoddedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filelistDBDataSet1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modListFinalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modListFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingModlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modlstDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox lstModlist;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private filelistDBDataSet1 filelistDBDataSet1;
        private System.Windows.Forms.BindingSource filemoddedBindingSource;
        private filelistDBDataSet1TableAdapters.filemoddedTableAdapter filemoddedTableAdapter;
        private filelistDBDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView filemoddedDataGridView;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingModlist;
        private modlstDBDataSet modlstDBDataSet;
        private System.Windows.Forms.Label label1;
        private modListFinal modListFinal;
        private System.Windows.Forms.BindingSource modListFinalBindingSource;
        private System.Windows.Forms.BindingSource modsBindingSource;
        private modListFinalTableAdapters.modsTableAdapter modsTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileDataGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moddedDataGridColumn;
        private System.Windows.Forms.DataGridViewButtonColumn btnlisten;
        private System.Windows.Forms.DataGridViewButtonColumn btnAdd2;
        private System.Windows.Forms.DataGridViewTextBoxColumn code2;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileDataGridColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn moddedDataGridColumn2;
        private System.Windows.Forms.DataGridViewButtonColumn btnlisten2;
        private System.Windows.Forms.DataGridViewButtonColumn btnAdd;
    }
}