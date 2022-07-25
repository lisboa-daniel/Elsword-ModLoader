namespace oPatcher
{
    partial class editEntry
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
            this.cbx_modlist = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_file = new System.Windows.Forms.TextBox();
            this.txt_artist = new System.Windows.Forms.TextBox();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.lbl_artist = new System.Windows.Forms.Label();
            this.lbl_file = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_stats = new System.Windows.Forms.Label();
            this.btn_apply = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.filemoddedTableAdapter = new oPatcher.filelistDBDataSet1TableAdapters.filemoddedTableAdapter();
            this.filelistDBDataSet1 = new oPatcher.filelistDBDataSet1();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filelistDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx_modlist
            // 
            this.cbx_modlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_modlist.FormattingEnabled = true;
            this.cbx_modlist.Location = new System.Drawing.Point(12, 44);
            this.cbx_modlist.Name = "cbx_modlist";
            this.cbx_modlist.Size = new System.Drawing.Size(169, 24);
            this.cbx_modlist.TabIndex = 0;
            this.cbx_modlist.SelectedIndexChanged += new System.EventHandler(this.cbx_modlist_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select one mod";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbl_title.Location = new System.Drawing.Point(11, 25);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(40, 17);
            this.lbl_title.TabIndex = 2;
            this.lbl_title.Text = "Title";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txt_file);
            this.groupBox1.Controls.Add(this.txt_artist);
            this.groupBox1.Controls.Add(this.txt_title);
            this.groupBox1.Controls.Add(this.lbl_artist);
            this.groupBox1.Controls.Add(this.lbl_file);
            this.groupBox1.Controls.Add(this.lbl_title);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox1.Location = new System.Drawing.Point(15, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Music info";
            // 
            // txt_file
            // 
            this.txt_file.BackColor = System.Drawing.Color.White;
            this.txt_file.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_file.Location = new System.Drawing.Point(63, 74);
            this.txt_file.Name = "txt_file";
            this.txt_file.ReadOnly = true;
            this.txt_file.Size = new System.Drawing.Size(341, 23);
            this.txt_file.TabIndex = 7;
            // 
            // txt_artist
            // 
            this.txt_artist.BackColor = System.Drawing.Color.White;
            this.txt_artist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_artist.Location = new System.Drawing.Point(63, 48);
            this.txt_artist.Name = "txt_artist";
            this.txt_artist.ReadOnly = true;
            this.txt_artist.Size = new System.Drawing.Size(341, 23);
            this.txt_artist.TabIndex = 6;
            this.txt_artist.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_title
            // 
            this.txt_title.BackColor = System.Drawing.Color.White;
            this.txt_title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_title.Location = new System.Drawing.Point(63, 22);
            this.txt_title.Name = "txt_title";
            this.txt_title.ReadOnly = true;
            this.txt_title.Size = new System.Drawing.Size(341, 23);
            this.txt_title.TabIndex = 5;
            // 
            // lbl_artist
            // 
            this.lbl_artist.AutoSize = true;
            this.lbl_artist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_artist.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbl_artist.Location = new System.Drawing.Point(11, 51);
            this.lbl_artist.Name = "lbl_artist";
            this.lbl_artist.Size = new System.Drawing.Size(46, 17);
            this.lbl_artist.TabIndex = 4;
            this.lbl_artist.Text = "Artist";
            // 
            // lbl_file
            // 
            this.lbl_file.AutoSize = true;
            this.lbl_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_file.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbl_file.Location = new System.Drawing.Point(11, 74);
            this.lbl_file.Name = "lbl_file";
            this.lbl_file.Size = new System.Drawing.Size(34, 17);
            this.lbl_file.TabIndex = 3;
            this.lbl_file.Text = "File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(290, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mod Status:";
            // 
            // lbl_stats
            // 
            this.lbl_stats.AutoSize = true;
            this.lbl_stats.BackColor = System.Drawing.Color.Lime;
            this.lbl_stats.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stats.Location = new System.Drawing.Point(311, 40);
            this.lbl_stats.Name = "lbl_stats";
            this.lbl_stats.Size = new System.Drawing.Size(73, 26);
            this.lbl_stats.TabIndex = 5;
            this.lbl_stats.Text = "Found";
            // 
            // btn_apply
            // 
            this.btn_apply.BackColor = System.Drawing.Color.Transparent;
            this.btn_apply.Enabled = false;
            this.btn_apply.FlatAppearance.BorderColor = System.Drawing.Color.Chartreuse;
            this.btn_apply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.btn_apply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_apply.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_apply.Location = new System.Drawing.Point(251, 188);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(75, 33);
            this.btn_apply.TabIndex = 6;
            this.btn_apply.Text = "Apply";
            this.btn_apply.UseVisualStyleBackColor = false;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(332, 188);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 33);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // filemoddedTableAdapter
            // 
            this.filemoddedTableAdapter.ClearBeforeFill = true;
            // 
            // filelistDBDataSet1
            // 
            this.filelistDBDataSet1.DataSetName = "filelistDBDataSet1";
            this.filelistDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // editEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::oPatcher.Properties.Resources.bg0;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(437, 242);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.lbl_stats);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_modlist);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(453, 281);
            this.Name = "editEntry";
            this.Text = "editEntry";
            this.Load += new System.EventHandler(this.editEntry_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filelistDBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_modlist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_file;
        private System.Windows.Forms.TextBox txt_artist;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.Label lbl_artist;
        private System.Windows.Forms.Label lbl_file;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_stats;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.Button btn_cancel;
        private filelistDBDataSet1TableAdapters.filemoddedTableAdapter filemoddedTableAdapter;
        private filelistDBDataSet1 filelistDBDataSet1;
    }
}