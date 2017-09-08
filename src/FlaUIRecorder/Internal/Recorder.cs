using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlaUI.Core;
using FlaUIRecorder.CodeProvider.Common;
using FlaUI.Core.AutomationElements.Infrastructure;
using FlaUIRecorder.Internal.Worker;
using System.Diagnostics;

namespace FlaUIRecorder.Internal
{
    public class Recorder : IDisposable
    {
        private readonly AutomationBase _automation;
        private readonly ICodeProvider _codeProvider;
        private List<IRecordWorker> _workers = new List<IRecordWorker>();  
               

        /// <summary>
        /// Gets the current state of the recorder
        /// </summary>
        public RecorderState State { get; private set; }

        public Recorder(AutomationType automationType, CodeProviderFactory codeProviderFactory, string codeProviderName, Process targetProcess)
        {
            _automation = automationType == AutomationType.UIA2 ? (AutomationBase)new FlaUI.UIA2.UIA2Automation() : new FlaUI.UIA3.UIA3Automation();                          
            _codeProvider = CreateCodeProvider(codeProviderFactory, codeProviderName, targetProcess);
            State = RecorderState.Paused;

            // Initialize workers
            _workers.Add(new HoverWorker(_automation, targetProcess.Id));
            var click = new ClickRecognizeWorker(_automation, targetProcess.Id);
            click.ElementClicked += Click_ElementClicked;
            click.ElementRightClicked += Click_ElementRightClicked;
            _workers.Add(click);            
        }

        private ICodeProvider CreateCodeProvider(CodeProviderFactory codeProviderFactory, string codeProviderName, Process targetProcess)
        {
            var args = new CodeProviderArguments()
            {
                Automation = _automation,
                TargetProcess = targetProcess
            };

            return codeProviderFactory.CreateProvider(codeProviderName, args);
        }

        public void Dispose()
        {
            _workers.ForEach(w => w.Dispose());
        }

        /// <summary>
        /// Starts or resumes the recording
        /// </summary>
        public void Record()
        {
            State = RecorderState.Recording;
            _workers.ForEach(w => w.Start());
        }

        public void Pause()
        {
            State = RecorderState.Paused;
            _workers.ForEach(w => w.Pause());
        }

        /// <summary>
        /// Adds a comment to the recoded session
        /// </summary>
        /// <param name="comment"></param>
        public void AddComment(string comment)
        {
            _codeProvider.AddComment(comment);
        }

        public string GenerateCode()
        {
            return _codeProvider.Generate();
        }

        private void Click_ElementRightClicked(object sender, AutomationElement e)
        {
            _codeProvider.RightClick(e);
        }

        private void Click_ElementClicked(object sender, AutomationElement e)
        {           
            _codeProvider.Click(e);
        }        
    }
}
