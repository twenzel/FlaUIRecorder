using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlaUI.Core;
using FlaUIRecorder.CodeProvider.Common;
using FlaUIRecorder.Internal;
using System.Diagnostics;

namespace FlaUIRecorder
{
    public partial class RecorderForm : Form
    {
        private Recorder _recorder;
        private MainForm _mainForm;

        public object RecorderState { get; private set; }

        public RecorderForm()
        {
            InitializeComponent();
        }

        public void Initialize(AutomationType automationType, CodeProviderFactory codeProviderFactory, string codeProviderName, MainForm mainForm, Process targetProcess)
        {
            _recorder = new Recorder(automationType, codeProviderFactory, codeProviderName, targetProcess);
            _mainForm = mainForm;
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            _recorder.Dispose();
            _mainForm = null;
        }

        public void ShowInLowerRightCorner()
        {
            Show();
            LocateInLowerRightCorner();
        }

        private void LocateInLowerRightCorner()
        {
            var bounds = Screen.PrimaryScreen.WorkingArea;
            this.Location = new Point(bounds.Right - (this.Width + 5), bounds.Bottom - (this.Height + 5));
        }

        public void Record()
        {
            _recorder.Record();
            this.toolTip1.SetToolTip(this.btnPausePlay, "Pause the recording");
            btnPausePlay.ImageIndex = 0;
            UpdateTitle();
        }

        public void Pause()
        {
            _recorder.Pause();
            this.toolTip1.SetToolTip(this.btnPausePlay, "Resumes the recording");
            btnPausePlay.ImageIndex = 1;
            UpdateTitle();
        }

        private void UpdateTitle()
        {
            Text = "FlaUI Recorder - " + _recorder.State.ToString();
        }

        #region Form events

        private void btnAddComment_Click(object sender, EventArgs e)
        {
            var resumeRecording = false;

            if (_recorder.State == Internal.RecorderState.Recording)
            {
                Pause();
                resumeRecording = true;
            }

            using (var form = new CommentForm())
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    _recorder.AddComment(form.Comment);
                }
            }

            if (resumeRecording)
                Record();
        }

        private void btnPausePlay_Click(object sender, EventArgs e)
        {
            if (_recorder.State == Internal.RecorderState.Paused)
                Record();
            else
                Pause();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _mainForm.CancelRecording();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            _mainForm.Finished(_recorder.GenerateCode());
        }
        #endregion
    }
}
