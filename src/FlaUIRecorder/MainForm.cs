using FlaUI.Core;
using FlaUIRecorder.CodeProvider.Common;
using FlaUIRecorder.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlaUIRecorder
{
    public partial class MainForm : Form
    {
        private CodeProviderFactory _providerFactory;
        private RecorderForm _recorderForm;
        private RecorderProject _currentProject;
        private AssemblyInformationalVersionAttribute _assemblyInformationalVersionAttribute;
        private MRUManager _mruManager;

        public MainForm()
        {
            InitializeComponent();

            _assemblyInformationalVersionAttribute = Assembly.GetEntryAssembly().GetCustomAttribute(typeof(AssemblyInformationalVersionAttribute)) as AssemblyInformationalVersionAttribute;
        }

        private ICodeProvider GetCodeProvider()
        {
            return _providerFactory.GetProvider(cboCodeProvider.SelectedItem.ToString());
        }

        private AutomationType GetAutomationType()
        {
            return rdbVersionUIA2.Checked ? AutomationType.UIA2 : AutomationType.UIA3;
        }

        internal void CancelRecording()
        {
            CloseRecorderAndShowMainForm();
            _currentProject.Sessions.Remove(_currentProject.Sessions.Last());
        }

        internal void Finished(string code)
        {
            CloseRecorderAndShowMainForm();
            var recordSession = _currentProject.Sessions.Last();
            recordSession.Code = code;
            _currentProject.IsDirty = true;

            ShowRecordSession(recordSession);
        }

        private void ShowRecordSession(RecordSession recordSession)
        {
            using (var form = new CodeForm())
            {
                form.Init(recordSession);
                form.ShowDialog(this);
            }
        }

        private void CloseRecorderAndShowMainForm()
        {
            _recorderForm.Close();
            _recorderForm = null;
            WindowState = FormWindowState.Normal;
        }

        private void RefreshProcessList()
        {
            cboApplicationProcess.DataSource = Process.GetProcesses().OrderBy(p => p.ProcessName).ToArray();
            cboApplicationProcess.ValueMember = "Id";
        }

        private string GetExecutableByProcess(Process process)
        {
            string result = "";
            try
            {
                string Query = "SELECT ExecutablePath FROM Win32_Process WHERE ProcessId = " + process.Id;

                using (ManagementObjectSearcher mos = new ManagementObjectSearcher(Query))
                {
                    using (ManagementObjectCollection moc = mos.Get())
                    {
                        result = (from mo in moc.Cast<ManagementObject>() select mo["ExecutablePath"]).First().ToString();
                    }
                }
            }
            catch //(Exception ex)
            {
                //ex.HandleException();
            }

            return result;
        }

        private Process StartAndWaitForTargetApplication(string executable)
        {
            return Process.Start(executable);
        }

        private void LoadProject(string fileName)
        {
            try
            {
                using (var stream = File.OpenRead(fileName))
                {
                    var formatter = new BinaryFormatter();
                    _currentProject = (RecorderProject)formatter.Deserialize(stream);
                }

                LoadControlValuesFromProject();

                _currentProject.FileName = fileName;
                _currentProject.IsDirty = false;
                UpdateTitle();                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loading project failed.\r\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool SaveProject()
        {
            if (string.IsNullOrEmpty(_currentProject.FileName))
            {
                if (saveProjectDialog.ShowDialog(this) == DialogResult.OK)
                    return SaveProject(saveProjectDialog.FileName);
                else
                    return false;
            }
            else
            {
                return SaveProject(_currentProject.FileName);
            }
        }

        private bool SaveProject(string fileName)
        {
            if (cboCodeProvider.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose a code provider.", "Missing Provider", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            if (rdbApplicationStart.Checked && !File.Exists(txtApplicationPath.Text))
            {
                if (String.IsNullOrEmpty(txtApplicationPath.Text))
                    MessageBox.Show("Please choose a target application.", "Missing application file", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                else
                    MessageBox.Show($"The selected application ({txtApplicationPath.Text}) does not exist.", "Invalid application file", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                return false;
            }

            try
            {
                _currentProject.FileName = fileName;

                WriteControlValuesToProject();

                using (var stream = File.Create(_currentProject.FileName))
                {
                    var formatter = new BinaryFormatter();
                    formatter.Serialize(stream, _currentProject);
                }

                _currentProject.IsDirty = false;
                UpdateTitle();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        private void LoadControlValuesFromProject()
        {
            if (!String.IsNullOrEmpty(_currentProject.Executable))
                rdbApplicationStart.Checked = true;

            if (!String.IsNullOrEmpty(_currentProject.ProcessName))
            {
                var processes = (IEnumerable<Process>)cboApplicationProcess.DataSource;
                var item = processes.FirstOrDefault(p => p.ProcessName == _currentProject.ProcessName);

                if (item != null)
                {
                    cboApplicationProcess.SelectedItem = item;
                    rdbApplicationProcess.Checked = true;
                }
            }

            if (_currentProject.AutomationType == AutomationType.UIA2)
                rdbVersionUIA2.Checked = true;
            else
                rdbVersionUIA3.Checked = true;

            recorderProjectBindingSource.DataSource = _currentProject;
            //sessionsBindingSource.DataSource = _currentProject.Sessions;
        }

        private void WriteControlValuesToProject()
        {
            recorderProjectBindingSource.EndEdit();

            //_currentProject.Executable = txtApplicationPath.Text;
            _currentProject.AutomationType = GetAutomationType();

            if (rdbApplicationProcess.Checked)
            {
                var process = (Process)cboApplicationProcess.SelectedItem;
                _currentProject.Executable = GetExecutableByProcess(process);
                _currentProject.ProcessName = process.ProcessName;
            }
        }

        public static void BringProcessToFront(Process process)
        {
            IntPtr handle = process.MainWindowHandle;
            if (NativeMethods.IsIconic(handle))
            {
                NativeMethods.ShowWindow(handle, NativeMethods.SW_RESTORE);
            }

            NativeMethods.SetForegroundWindow(handle);
        }

        private void UpdateTitle()
        {
            Text = "FlaUI Recorder";

            if (_assemblyInformationalVersionAttribute != null)
            {
                Text += " v" + _assemblyInformationalVersionAttribute.InformationalVersion;
            }

            if (string.IsNullOrEmpty(_currentProject.FileName))
                Text += " - new";
            else
                Text += " - " + Path.GetFileNameWithoutExtension(_currentProject.FileName);

            if (_currentProject.IsDirty)
                Text += "*";
        }

        private void SetDirtyFlag()
        {
            if (_currentProject == null)
                return;

            _currentProject.IsDirty = true;
            UpdateTitle();
        }

        #region Form events

        private void MainForm_Load(object sender, EventArgs e)
        {
            _providerFactory = new CodeProviderFactory();
            cboCodeProvider.Items.AddRange(_providerFactory.GetAvailableProviderNames());
            if (cboCodeProvider.Items.Count > 0)
                cboCodeProvider.SelectedIndex = 0;

            RefreshProcessList();

            _currentProject = new RecorderProject();
            UpdateTitle();
            InitializeMru();
        }

        private void InitializeMru()
        {
            _mruManager = new MRUManager(mnuRecentProjects, "FlaUI Recorder", recentFileGotClicked_handler, null);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!SaveProject())
                return;

            var session = new RecordSession() { StartTime = DateTime.Now };
            _currentProject.Sessions.Add(session);
            Process process = null;

            if (rdbApplicationStart.Checked)
            {
                process = StartAndWaitForTargetApplication(_currentProject.Executable);
            }
            else
            {
                process = (Process)cboApplicationProcess.SelectedItem;
            }

            BringProcessToFront(process);

            _recorderForm = new RecorderForm();
            _recorderForm.Initialize(_currentProject.AutomationType, GetCodeProvider(), this, process.Id);
            _recorderForm.Record();
            _recorderForm.ShowInLowerRightCorner();
            this.WindowState = FormWindowState.Minimized;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnApplicationBrowse_Click(object sender, EventArgs e)
        {
            if (openApplicationDialog.ShowDialog(this) == DialogResult.OK)
                txtApplicationPath.Text = openApplicationDialog.FileName;
        }

        private void btnProcessRefresh_Click(object sender, EventArgs e)
        {
            RefreshProcessList();
        }

        private void cboApplicationProcess_Format(object sender, ListControlConvertEventArgs e)
        {
            Process item = e.ListItem as Process;
            e.Value = $"{item.ProcessName} ({item.Id})";
        }

        private void openProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!EnsureCurrentProjectIsSaved())
                return;

            if (openProjectDialog.ShowDialog(this) == DialogResult.OK)
            {
                LoadProject(openProjectDialog.FileName);
                _mruManager.AddRecentFile(openProjectDialog.FileName);
            }
        }

        private bool EnsureCurrentProjectIsSaved()
        {
            if (_currentProject.IsDirty)
            {
                var dialogResult = MessageBox.Show("The current project contains unsaved changes. Do you want to save these changes?", "Unsaved changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.OK)
                {
                    if (!SaveProject())
                        return false;
                }
                else if (dialogResult == DialogResult.Cancel)
                    return false;
            }

            return true;
        }

        private void saveProjectAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveProjectDialog.ShowDialog(this) == DialogResult.OK)
                SaveProject(saveProjectDialog.FileName);
        }

        private void recentFileGotClicked_handler(object obj, EventArgs evt)
        {
            string fileName = (obj as ToolStripItem).Text;
            if (!File.Exists(fileName))
            {
                if (MessageBox.Show($"{fileName} doesn't exist. Remove from recent workspaces?", "File not found", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    _mruManager.RemoveRecentFile(fileName);

                return;
            }

            if (!EnsureCurrentProjectIsSaved())
                return;

            LoadProject(fileName);
        }        

        private void recorderProjectBindingSource_BindingComplete(object sender, BindingCompleteEventArgs e)
        {
            if (!_currentProject.IsDirty && (e.BindingCompleteState == BindingCompleteState.Success) && e.Binding.Control.Focused)
            {
                SetDirtyFlag();
            }
        }

        private void radioButton_CheckedChanged_UpdateDirty(object sender, EventArgs e)
        {
            SetDirtyFlag();
        }

        private void recorderProjectBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            SetDirtyFlag();
        }
       
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && !EnsureCurrentProjectIsSaved())
                e.Cancel = true;
        }

        #endregion
    }
}
