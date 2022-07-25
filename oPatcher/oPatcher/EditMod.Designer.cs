namespace oPatcher
{
    partial class EditMod
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.filelistDataGridView = new System.Windows.Forms.DataGridView();
            this.checkModded = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fileColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.DataGridViewButtonColumn();
            this.filelistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filelistDBDataSet = new oPatcher.filelistDBDataSet();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkModded2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fileColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtModname = new System.Windows.Forms.TextBox();
            this.filelistTableAdapter = new oPatcher.filelistDBDataSetTableAdapters.filelistTableAdapter();
            this.tableAdapterManager = new oPatcher.filelistDBDataSetTableAdapters.TableAdapterManager();
            this.filelistTableAdapter1 = new oPatcher.filelistDBDataSetTableAdapters.filelistTableAdapter();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.filelistDBDataSet1 = new oPatcher.filelistDBDataSet1();
            this.filemoddedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filemoddedTableAdapter = new oPatcher.filelistDBDataSet1TableAdapters.filemoddedTableAdapter();
            this.openFIle = new System.Windows.Forms.OpenFileDialog();
            this.process1 = new System.Diagnostics.Process();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filelistDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filelistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filelistDBDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filelistDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filemoddedBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(20, 52);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1146, 419);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.filelistDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Size = new System.Drawing.Size(1138, 391);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "[BGM] ALL";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // filelistDataGridView
            // 
            this.filelistDataGridView.AllowUserToAddRows = false;
            this.filelistDataGridView.AllowUserToDeleteRows = false;
            this.filelistDataGridView.AutoGenerateColumns = false;
            this.filelistDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filelistDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkModded,
            this.fileColumn,
            this.dataGridViewTextBoxColumn3,
            this.btnAdd});
            this.filelistDataGridView.DataSource = this.filelistBindingSource;
            this.filelistDataGridView.Location = new System.Drawing.Point(-48, 0);
            this.filelistDataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.filelistDataGridView.MultiSelect = false;
            this.filelistDataGridView.Name = "filelistDataGridView";
            this.filelistDataGridView.ReadOnly = true;
            this.filelistDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.filelistDataGridView.Size = new System.Drawing.Size(1188, 393);
            this.filelistDataGridView.TabIndex = 0;
            this.filelistDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.filelistDataGridView_CellContentClick);
            // 
            // checkModded
            // 
            this.checkModded.HeaderText = "Mod";
            this.checkModded.Name = "checkModded";
            this.checkModded.ReadOnly = true;
            this.checkModded.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.checkModded.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.checkModded.Width = 40;
            // 
            // fileColumn
            // 
            this.fileColumn.DataPropertyName = "File";
            this.fileColumn.HeaderText = "File";
            this.fileColumn.Name = "fileColumn";
            this.fileColumn.ReadOnly = true;
            this.fileColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.fileColumn.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn3.HeaderText = "Description";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // btnAdd
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.DefaultCellStyle = dataGridViewCellStyle3;
            this.btnAdd.HeaderText = "";
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ReadOnly = true;
            this.btnAdd.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btnAdd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnAdd.Text = "...";
            this.btnAdd.UseColumnTextForButtonValue = true;
            this.btnAdd.Width = 50;
            // 
            // filelistBindingSource
            // 
            this.filelistBindingSource.DataMember = "filelist";
            this.filelistBindingSource.DataSource = this.filelistDBDataSet;
            // 
            // filelistDBDataSet
            // 
            this.filelistDBDataSet.DataSetName = "filelistDBDataSet";
            this.filelistDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Size = new System.Drawing.Size(1138, 393);
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
            this.checkModded2,
            this.fileColumn2,
            this.dataGridViewTextBoxColumn4,
            this.btnAdd2});
            this.dataGridView1.DataSource = this.filelistBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-48, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(1188, 393);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // checkModded2
            // 
            this.checkModded2.HeaderText = "Mod";
            this.checkModded2.Name = "checkModded2";
            this.checkModded2.ReadOnly = true;
            this.checkModded2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.checkModded2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.checkModded2.Width = 40;
            // 
            // fileColumn2
            // 
            this.fileColumn2.DataPropertyName = "File";
            this.fileColumn2.HeaderText = "File";
            this.fileColumn2.Name = "fileColumn2";
            this.fileColumn2.ReadOnly = true;
            this.fileColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.fileColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn4.HeaderText = "Description";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // btnAdd2
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.btnAdd2.DefaultCellStyle = dataGridViewCellStyle4;
            this.btnAdd2.HeaderText = "";
            this.btnAdd2.Name = "btnAdd2";
            this.btnAdd2.ReadOnly = true;
            this.btnAdd2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btnAdd2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnAdd2.Text = "...";
            this.btnAdd2.UseColumnTextForButtonValue = true;
            this.btnAdd2.Width = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // txtModname
            // 
            this.txtModname.Location = new System.Drawing.Point(87, 22);
            this.txtModname.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtModname.Name = "txtModname";
            this.txtModname.Size = new System.Drawing.Size(1070, 24);
            this.txtModname.TabIndex = 2;
            this.txtModname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // filelistTableAdapter
            // 
            this.filelistTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.filelistTableAdapter = this.filelistTableAdapter;
            this.tableAdapterManager.UpdateOrder = oPatcher.filelistDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // filelistTableAdapter1
            // 
            this.filelistTableAdapter1.ClearBeforeFill = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(932, 479);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(112, 27);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1053, 479);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 27);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // filelistDBDataSet1
            // 
            this.filelistDBDataSet1.DataSetName = "filelistDBDataSet1";
            this.filelistDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filemoddedBindingSource
            // 
            this.filemoddedBindingSource.DataMember = "filemodded";
            this.filemoddedBindingSource.DataSource = this.filelistDBDataSet1;
            // 
            // filemoddedTableAdapter
            // 
            this.filemoddedTableAdapter.ClearBeforeFill = true;
            // 
            // openFIle
            // 
            this.openFIle.Filter = "Audio Files|*.wav;*.mp3;*.m4a;*.ogg";
            this.openFIle.FileOk += new System.ComponentModel.CancelEventHandler(this.openFIle_FileOk);
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            this.process1.Exited += new System.EventHandler(this.process1_Exited);
            // 
            // EditMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::oPatcher.Properties.Resources.default_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1174, 519);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtModname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Blambot Pro Lite", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "EditMod";
            this.Text = "EditMod";
            this.Load += new System.EventHandler(this.EditMod_Load);
            this.Enter += new System.EventHandler(this.EditMod_Enter);
            this.Leave += new System.EventHandler(this.EditMod_Leave);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.filelistDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filelistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filelistDBDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filelistDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filemoddedBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtModname;
        private filelistDBDataSet filelistDBDataSet;
        private System.Windows.Forms.BindingSource filelistBindingSource;
        private filelistDBDataSetTableAdapters.filelistTableAdapter filelistTableAdapter;
        private filelistDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView filelistDataGridView;
        private filelistDBDataSetTableAdapters.filelistTableAdapter filelistTableAdapter1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.BindingSource filemoddedBindingSource;
        private filelistDBDataSet1 filelistDBDataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private filelistDBDataSet1TableAdapters.filemoddedTableAdapter filemoddedTableAdapter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkModded;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewButtonColumn btnAdd;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkModded2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewButtonColumn btnAdd2;
        private System.Windows.Forms.OpenFileDialog openFIle;
        private System.Diagnostics.Process process1;
    }
}