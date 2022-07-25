namespace oPatcher
{
    partial class Settings
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLocate = new System.Windows.Forms.Button();
            this.txtLauncherPath = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ckb_alwaysmin = new System.Windows.Forms.CheckBox();
            this.ckb_startWithWindows = new System.Windows.Forms.CheckBox();
            this.ckb_mWhenStart = new System.Windows.Forms.CheckBox();
            this.btn_Apply = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pathElsorigin = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(387, 172);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(379, 146);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ElsOrigin";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLocate);
            this.groupBox1.Controls.Add(this.txtLauncherPath);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 77);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Launcher Location (elsorigin.exe)";
            // 
            // btnLocate
            // 
            this.btnLocate.Location = new System.Drawing.Point(332, 29);
            this.btnLocate.Name = "btnLocate";
            this.btnLocate.Size = new System.Drawing.Size(29, 23);
            this.btnLocate.TabIndex = 2;
            this.btnLocate.Text = "L";
            this.btnLocate.UseVisualStyleBackColor = true;
            this.btnLocate.Click += new System.EventHandler(this.btnLocate_Click);
            // 
            // txtLauncherPath
            // 
            this.txtLauncherPath.Location = new System.Drawing.Point(59, 31);
            this.txtLauncherPath.Name = "txtLauncherPath";
            this.txtLauncherPath.ReadOnly = true;
            this.txtLauncherPath.Size = new System.Drawing.Size(267, 20);
            this.txtLauncherPath.TabIndex = 1;
            this.txtLauncherPath.TextChanged += new System.EventHandler(this.txtLauncherPath_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::oPatcher.Properties.Resources.elsorigin48x48;
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(379, 146);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Patcher";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ckb_alwaysmin);
            this.groupBox2.Controls.Add(this.ckb_startWithWindows);
            this.groupBox2.Controls.Add(this.ckb_mWhenStart);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 134);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Patcher Preferences";
            // 
            // ckb_alwaysmin
            // 
            this.ckb_alwaysmin.AutoSize = true;
            this.ckb_alwaysmin.Location = new System.Drawing.Point(16, 78);
            this.ckb_alwaysmin.Name = "ckb_alwaysmin";
            this.ckb_alwaysmin.Size = new System.Drawing.Size(134, 17);
            this.ckb_alwaysmin.TabIndex = 2;
            this.ckb_alwaysmin.Text = "Always open minimized";
            this.ckb_alwaysmin.UseVisualStyleBackColor = true;
            this.ckb_alwaysmin.CheckedChanged += new System.EventHandler(this.ckb_alwaysmin_CheckedChanged);
            // 
            // ckb_startWithWindows
            // 
            this.ckb_startWithWindows.AutoSize = true;
            this.ckb_startWithWindows.Location = new System.Drawing.Point(16, 55);
            this.ckb_startWithWindows.Name = "ckb_startWithWindows";
            this.ckb_startWithWindows.Size = new System.Drawing.Size(164, 17);
            this.ckb_startWithWindows.TabIndex = 1;
            this.ckb_startWithWindows.Text = "Initialize when computer stars";
            this.ckb_startWithWindows.UseVisualStyleBackColor = true;
            this.ckb_startWithWindows.CheckedChanged += new System.EventHandler(this.ckb_startWithWindows_CheckedChanged);
            // 
            // ckb_mWhenStart
            // 
            this.ckb_mWhenStart.AutoSize = true;
            this.ckb_mWhenStart.Location = new System.Drawing.Point(16, 32);
            this.ckb_mWhenStart.Name = "ckb_mWhenStart";
            this.ckb_mWhenStart.Size = new System.Drawing.Size(147, 17);
            this.ckb_mWhenStart.TabIndex = 0;
            this.ckb_mWhenStart.Text = "Minimize when start game";
            this.ckb_mWhenStart.UseVisualStyleBackColor = true;
            this.ckb_mWhenStart.CheckedChanged += new System.EventHandler(this.ckb_mWhenStart_CheckedChanged);
            // 
            // btn_Apply
            // 
            this.btn_Apply.Enabled = false;
            this.btn_Apply.Location = new System.Drawing.Point(320, 186);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(75, 23);
            this.btn_Apply.TabIndex = 1;
            this.btn_Apply.Text = "Apply";
            this.btn_Apply.UseVisualStyleBackColor = true;
            this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pathElsorigin
            // 
            this.pathElsorigin.Filter = "elsorigin.exe files (elsorigin.exe)|elsorigin.exe";
            this.pathElsorigin.InitialDirectory = "C://";
            this.pathElsorigin.Title = "Select your elsorigin.exe file";
            this.pathElsorigin.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 215);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Apply);
            this.Controls.Add(this.tabControl1);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLauncherPath;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLocate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox ckb_alwaysmin;
        private System.Windows.Forms.CheckBox ckb_startWithWindows;
        private System.Windows.Forms.CheckBox ckb_mWhenStart;
        private System.Windows.Forms.Button btn_Apply;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog pathElsorigin;
    }
}