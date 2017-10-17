namespace FlaUIRecorder
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.rdbVersionUIA2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbVersionUIA3 = new System.Windows.Forms.RadioButton();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboCodeProvider = new System.Windows.Forms.ComboBox();
            this.recorderProjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRecentProjects = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtApplicationArgs = new System.Windows.Forms.TextBox();
            this.lblApplicationArgs = new System.Windows.Forms.Label();
            this.cboApplicationProcess = new System.Windows.Forms.ComboBox();
            this.btnApplicationBrowse = new System.Windows.Forms.Button();
            this.btnProcessRefresh = new System.Windows.Forms.Button();
            this.txtApplicationPath = new System.Windows.Forms.TextBox();
            this.rdbApplicationProcess = new System.Windows.Forms.RadioButton();
            this.rdbApplicationStart = new System.Windows.Forms.RadioButton();
            this.openApplicationDialog = new System.Windows.Forms.OpenFileDialog();
            this.openProjectDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveProjectDialog = new System.Windows.Forms.SaveFileDialog();
            this.lstSessions = new System.Windows.Forms.ListBox();
            this.sessionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recorderProjectBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sessionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbVersionUIA2
            // 
            this.rdbVersionUIA2.AutoSize = true;
            this.rdbVersionUIA2.Location = new System.Drawing.Point(6, 19);
            this.rdbVersionUIA2.Name = "rdbVersionUIA2";
            this.rdbVersionUIA2.Size = new System.Drawing.Size(97, 17);
            this.rdbVersionUIA2.TabIndex = 0;
            this.rdbVersionUIA2.Text = "UIA2 Managed";
            this.rdbVersionUIA2.UseVisualStyleBackColor = true;
            this.rdbVersionUIA2.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged_UpdateDirty);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbVersionUIA3);
            this.groupBox1.Controls.Add(this.rdbVersionUIA2);
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(131, 71);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "UIA Version";
            // 
            // rdbVersionUIA3
            // 
            this.rdbVersionUIA3.AutoSize = true;
            this.rdbVersionUIA3.Checked = true;
            this.rdbVersionUIA3.Location = new System.Drawing.Point(6, 42);
            this.rdbVersionUIA3.Name = "rdbVersionUIA3";
            this.rdbVersionUIA3.Size = new System.Drawing.Size(85, 17);
            this.rdbVersionUIA3.TabIndex = 1;
            this.rdbVersionUIA3.TabStop = true;
            this.rdbVersionUIA3.Text = "UIA3 Interop";
            this.rdbVersionUIA3.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 236);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(85, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start recording";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.cboCodeProvider);
            this.groupBox2.Location = new System.Drawing.Point(149, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 71);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Code provider";
            // 
            // cboCodeProvider
            // 
            this.cboCodeProvider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCodeProvider.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.recorderProjectBindingSource, "CodeProvider", true));
            this.cboCodeProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodeProvider.FormattingEnabled = true;
            this.cboCodeProvider.Location = new System.Drawing.Point(6, 19);
            this.cboCodeProvider.Name = "cboCodeProvider";
            this.cboCodeProvider.Size = new System.Drawing.Size(290, 21);
            this.cboCodeProvider.TabIndex = 0;
            // 
            // recorderProjectBindingSource
            // 
            this.recorderProjectBindingSource.DataSource = typeof(FlaUIRecorder.RecorderProject);
            this.recorderProjectBindingSource.BindingComplete += new System.Windows.Forms.BindingCompleteEventHandler(this.recorderProjectBindingSource_BindingComplete);
            this.recorderProjectBindingSource.CurrentItemChanged += new System.EventHandler(this.recorderProjectBindingSource_CurrentItemChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(602, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpen,
            this.mnuSave,
            this.mnuSaveAs,
            this.mnuRecentProjects,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "&File";
            // 
            // mnuOpen
            // 
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuOpen.Size = new System.Drawing.Size(186, 22);
            this.mnuOpen.Text = "Open project";
            this.mnuOpen.Click += new System.EventHandler(this.openProjectToolStripMenuItem_Click);
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuSave.Size = new System.Drawing.Size(186, 22);
            this.mnuSave.Text = "Save project";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // mnuSaveAs
            // 
            this.mnuSaveAs.Name = "mnuSaveAs";
            this.mnuSaveAs.Size = new System.Drawing.Size(186, 22);
            this.mnuSaveAs.Text = "Save project as...";
            this.mnuSaveAs.Click += new System.EventHandler(this.mnuSaveAs_Click);
            // 
            // mnuRecentProjects
            // 
            this.mnuRecentProjects.Name = "mnuRecentProjects";
            this.mnuRecentProjects.Size = new System.Drawing.Size(186, 22);
            this.mnuRecentProjects.Text = "Recent projects";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(183, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txtApplicationArgs);
            this.groupBox3.Controls.Add(this.lblApplicationArgs);
            this.groupBox3.Controls.Add(this.cboApplicationProcess);
            this.groupBox3.Controls.Add(this.btnApplicationBrowse);
            this.groupBox3.Controls.Add(this.btnProcessRefresh);
            this.groupBox3.Controls.Add(this.txtApplicationPath);
            this.groupBox3.Controls.Add(this.rdbApplicationProcess);
            this.groupBox3.Controls.Add(this.rdbApplicationStart);
            this.groupBox3.Location = new System.Drawing.Point(12, 107);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(439, 113);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Target application";
            // 
            // txtApplicationArgs
            // 
            this.txtApplicationArgs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recorderProjectBindingSource, "Arguments", true));
            this.txtApplicationArgs.Location = new System.Drawing.Point(83, 45);
            this.txtApplicationArgs.Name = "txtApplicationArgs";
            this.txtApplicationArgs.Size = new System.Drawing.Size(317, 20);
            this.txtApplicationArgs.TabIndex = 5;
            // 
            // lblApplicationArgs
            // 
            this.lblApplicationArgs.AutoSize = true;
            this.lblApplicationArgs.Location = new System.Drawing.Point(25, 49);
            this.lblApplicationArgs.Name = "lblApplicationArgs";
            this.lblApplicationArgs.Size = new System.Drawing.Size(31, 13);
            this.lblApplicationArgs.TabIndex = 8;
            this.lblApplicationArgs.Text = "Args:";
            // 
            // cboApplicationProcess
            // 
            this.cboApplicationProcess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboApplicationProcess.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboApplicationProcess.FormattingEnabled = true;
            this.cboApplicationProcess.Location = new System.Drawing.Point(83, 73);
            this.cboApplicationProcess.Name = "cboApplicationProcess";
            this.cboApplicationProcess.Size = new System.Drawing.Size(317, 21);
            this.cboApplicationProcess.TabIndex = 6;
            this.cboApplicationProcess.SelectedIndexChanged += new System.EventHandler(this.radioButton_CheckedChanged_UpdateDirty);
            this.cboApplicationProcess.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cboApplicationProcess_Format);
            // 
            // btnApplicationBrowse
            // 
            this.btnApplicationBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApplicationBrowse.Location = new System.Drawing.Point(406, 16);
            this.btnApplicationBrowse.Name = "btnApplicationBrowse";
            this.btnApplicationBrowse.Size = new System.Drawing.Size(27, 24);
            this.btnApplicationBrowse.TabIndex = 7;
            this.btnApplicationBrowse.Text = "...";
            this.btnApplicationBrowse.UseVisualStyleBackColor = true;
            this.btnApplicationBrowse.Click += new System.EventHandler(this.btnApplicationBrowse_Click);
            // 
            // btnProcessRefresh
            // 
            this.btnProcessRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcessRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnProcessRefresh.Image")));
            this.btnProcessRefresh.Location = new System.Drawing.Point(406, 71);
            this.btnProcessRefresh.Name = "btnProcessRefresh";
            this.btnProcessRefresh.Size = new System.Drawing.Size(27, 24);
            this.btnProcessRefresh.TabIndex = 7;
            this.btnProcessRefresh.UseVisualStyleBackColor = true;
            this.btnProcessRefresh.Click += new System.EventHandler(this.btnProcessRefresh_Click);
            // 
            // txtApplicationPath
            // 
            this.txtApplicationPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApplicationPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recorderProjectBindingSource, "Executable", true));
            this.txtApplicationPath.Location = new System.Drawing.Point(83, 19);
            this.txtApplicationPath.Name = "txtApplicationPath";
            this.txtApplicationPath.Size = new System.Drawing.Size(317, 20);
            this.txtApplicationPath.TabIndex = 4;
            this.txtApplicationPath.TextChanged += new System.EventHandler(this.radioButton_CheckedChanged_UpdateDirty);
            // 
            // rdbApplicationProcess
            // 
            this.rdbApplicationProcess.AutoSize = true;
            this.rdbApplicationProcess.Location = new System.Drawing.Point(6, 74);
            this.rdbApplicationProcess.Name = "rdbApplicationProcess";
            this.rdbApplicationProcess.Size = new System.Drawing.Size(66, 17);
            this.rdbApplicationProcess.TabIndex = 3;
            this.rdbApplicationProcess.Text = "Process:";
            this.rdbApplicationProcess.UseVisualStyleBackColor = true;
            // 
            // rdbApplicationStart
            // 
            this.rdbApplicationStart.AutoSize = true;
            this.rdbApplicationStart.Checked = true;
            this.rdbApplicationStart.Location = new System.Drawing.Point(6, 20);
            this.rdbApplicationStart.Name = "rdbApplicationStart";
            this.rdbApplicationStart.Size = new System.Drawing.Size(50, 17);
            this.rdbApplicationStart.TabIndex = 2;
            this.rdbApplicationStart.TabStop = true;
            this.rdbApplicationStart.Text = "Path:";
            this.rdbApplicationStart.UseVisualStyleBackColor = true;
            this.rdbApplicationStart.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged_UpdateDirty);
            // 
            // openApplicationDialog
            // 
            this.openApplicationDialog.FileName = "*.exe";
            this.openApplicationDialog.Filter = "Applications (*.exe)|*.exe";
            this.openApplicationDialog.Title = "Choose target application";
            // 
            // openProjectDialog
            // 
            this.openProjectDialog.FileName = "*.urp";
            this.openProjectDialog.Filter = "FlaUI Recorder projects (*.urp)|*.urp";
            this.openProjectDialog.Title = "Open an existing project";
            // 
            // saveProjectDialog
            // 
            this.saveProjectDialog.DefaultExt = "*.urp";
            this.saveProjectDialog.Filter = "FlaUI Recorder projects (*.urp)|*.urp";
            this.saveProjectDialog.Title = "Save recorder project";
            // 
            // lstSessions
            // 
            this.lstSessions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lstSessions.DataSource = this.sessionsBindingSource;
            this.lstSessions.FormattingEnabled = true;
            this.lstSessions.Location = new System.Drawing.Point(457, 50);
            this.lstSessions.Name = "lstSessions";
            this.lstSessions.Size = new System.Drawing.Size(133, 212);
            this.lstSessions.TabIndex = 6;
            this.lstSessions.DoubleClick += new System.EventHandler(this.lstSessions_DoubleClick);
            // 
            // sessionsBindingSource
            // 
            this.sessionsBindingSource.DataMember = "Sessions";
            this.sessionsBindingSource.DataSource = this.recorderProjectBindingSource;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(457, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Recorded sessions";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 271);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstSessions);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlaUI - Recorder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.recorderProjectBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sessionsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbVersionUIA2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbVersionUIA3;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboCodeProvider;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnProcessRefresh;
        private System.Windows.Forms.ComboBox cboApplicationProcess;
        private System.Windows.Forms.TextBox txtApplicationPath;
        private System.Windows.Forms.RadioButton rdbApplicationProcess;
        private System.Windows.Forms.RadioButton rdbApplicationStart;
        private System.Windows.Forms.Button btnApplicationBrowse;
        private System.Windows.Forms.OpenFileDialog openApplicationDialog;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveAs;
        private System.Windows.Forms.OpenFileDialog openProjectDialog;
        private System.Windows.Forms.SaveFileDialog saveProjectDialog;
        private System.Windows.Forms.ListBox lstSessions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource recorderProjectBindingSource;
        private System.Windows.Forms.BindingSource sessionsBindingSource;
        private System.Windows.Forms.ToolStripMenuItem mnuRecentProjects;
        private System.Windows.Forms.Label lblApplicationArgs;
        private System.Windows.Forms.TextBox txtApplicationArgs;
    }
}

