namespace ElzeroModLoader
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tp0 = new System.Windows.Forms.TabPage();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnModFolder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMods = new System.Windows.Forms.TextBox();
            this.tp1 = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtModRepository = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tp0.SuspendLayout();
            this.tp1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Game Location";
            // 
            // button1
            // 
            this.button1.Image = global::ElzeroModLoader.Properties.Resources.folder_search_outline__1_;
            this.button1.Location = new System.Drawing.Point(334, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 32);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tp0);
            this.tabControl.Controls.Add(this.tp1);
            this.tabControl.Location = new System.Drawing.Point(1, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(403, 348);
            this.tabControl.TabIndex = 3;
            // 
            // tp0
            // 
            this.tp0.Controls.Add(this.lblStatus);
            this.tp0.Controls.Add(this.btnModFolder);
            this.tp0.Controls.Add(this.label2);
            this.tp0.Controls.Add(this.txtMods);
            this.tp0.Controls.Add(this.button1);
            this.tp0.Controls.Add(this.label1);
            this.tp0.Location = new System.Drawing.Point(4, 24);
            this.tp0.Name = "tp0";
            this.tp0.Padding = new System.Windows.Forms.Padding(3);
            this.tp0.Size = new System.Drawing.Size(395, 320);
            this.tp0.TabIndex = 0;
            this.tp0.Text = "Main Settings";
            this.tp0.UseVisualStyleBackColor = true;
            this.tp0.Click += new System.EventHandler(this.tp0_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.ForeColor = System.Drawing.Color.Green;
            this.lblStatus.Location = new System.Drawing.Point(7, 108);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(380, 76);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // btnModFolder
            // 
            this.btnModFolder.Image = ((System.Drawing.Image)(resources.GetObject("btnModFolder.Image")));
            this.btnModFolder.Location = new System.Drawing.Point(336, 76);
            this.btnModFolder.Name = "btnModFolder";
            this.btnModFolder.Size = new System.Drawing.Size(53, 32);
            this.btnModFolder.TabIndex = 5;
            this.btnModFolder.UseVisualStyleBackColor = true;
            this.btnModFolder.Visible = false;
            this.btnModFolder.Click += new System.EventHandler(this.btnModFolder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mods Folder";
            // 
            // txtMods
            // 
            this.txtMods.Enabled = false;
            this.txtMods.Location = new System.Drawing.Point(7, 82);
            this.txtMods.Name = "txtMods";
            this.txtMods.Size = new System.Drawing.Size(320, 23);
            this.txtMods.TabIndex = 3;
            this.txtMods.TextChanged += new System.EventHandler(this.txtMods_TextChanged);
            // 
            // tp1
            // 
            this.tp1.Controls.Add(this.checkBox1);
            this.tp1.Controls.Add(this.button2);
            this.tp1.Controls.Add(this.label3);
            this.tp1.Controls.Add(this.txtModRepository);
            this.tp1.Location = new System.Drawing.Point(4, 24);
            this.tp1.Name = "tp1";
            this.tp1.Padding = new System.Windows.Forms.Padding(3);
            this.tp1.Size = new System.Drawing.Size(395, 320);
            this.tp1.TabIndex = 1;
            this.tp1.Text = "User Settings";
            this.tp1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(7, 59);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(112, 19);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Use default path";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Image = global::ElzeroModLoader.Properties.Resources.folder_search_outline__1_;
            this.button2.Location = new System.Drawing.Point(334, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 32);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mods Repository Location";
            // 
            // txtModRepository
            // 
            this.txtModRepository.Enabled = false;
            this.txtModRepository.Location = new System.Drawing.Point(7, 30);
            this.txtModRepository.Name = "txtModRepository";
            this.txtModRepository.Size = new System.Drawing.Size(320, 23);
            this.txtModRepository.TabIndex = 3;
            // 
            // btnApply
            // 
            this.btnApply.Enabled = false;
            this.btnApply.Location = new System.Drawing.Point(248, 366);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 8;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(329, 366);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "OK";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 401);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.tabControl);
            this.MaximumSize = new System.Drawing.Size(420, 440);
            this.MinimumSize = new System.Drawing.Size(420, 440);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosed);
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tp0.ResumeLayout(false);
            this.tp0.PerformLayout();
            this.tp1.ResumeLayout(false);
            this.tp1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Label label1;
        private Button button1;
        private TabControl tabControl;
        private TabPage tp0;
        private TabPage tp1;
        private Label lblStatus;
        private Button btnModFolder;
        private Label label2;
        private TextBox txtMods;
        private Button btnApply;
        private Button btnCancel;
        private CheckBox checkBox1;
        private Button button2;
        private Label label3;
        private TextBox txtModRepository;
    }
}