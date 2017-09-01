using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlaUI.Core;
using FlaUIRecorder.CodeProvider.Common;
using FlaUI.Core.AutomationElements.Infrastructure;

namespace FlaUIRecorder.Internal
{
    public class Recorder
    {
        private readonly AutomationBase _automation;
        private readonly ICodeProvider _codeProvider;
        private HoverMode _hoverMode;
        private FocusTrackingMode _focusTrackingMode;
        private ITreeWalker _treeWalker;
        private AutomationElement _rootElement;

        /// <summary>
        /// Gets the current state of the recorder
        /// </summary>
        public RecorderState State { get; private set; }

        public Recorder(AutomationType automationType, ICodeProvider codeProvider, int targetProcessId)
        {
            _automation = automationType == AutomationType.UIA2 ? (AutomationBase)new FlaUI.UIA2.UIA2Automation() : new FlaUI.UIA3.UIA3Automation();   
            _rootElement = FindTargetApplicationRoot(targetProcessId);

            _codeProvider = codeProvider;
            State = RecorderState.Paused;

            // Initialize hover
            _hoverMode = new HoverMode(_automation, targetProcessId);
            //_hoverMode.ElementHovered += ElementToSelectChanged;

            // Initialize focus tracking
            _focusTrackingMode = new FocusTrackingMode(_automation, targetProcessId);
            _focusTrackingMode.ElementFocused += ElementToSelectChanged;

            // Initialize TreeWalker
            _treeWalker = _automation.TreeWalkerFactory.GetControlViewWalker();
        }

        private AutomationElement FindTargetApplicationRoot(int targetProcessId)
        {
            var element = _automation.GetDesktop();
            var root = element.FindFirstChild(c => c.ByProcessId(targetProcessId));

            return root;
        }

        /// <summary>
        /// Starts or resumes the recording
        /// </summary>
        public void Record()
        {
            State = RecorderState.Recording;
            _hoverMode.Start();
            _focusTrackingMode.Start();
        }

        public void Pause()
        {
            State = RecorderState.Paused;
            _hoverMode.Stop();
            _focusTrackingMode.Stop();
        }

        /// <summary>
        /// Adds a comment to the recoded session
        /// </summary>
        /// <param name="comment"></param>
        public void AddComment(string comment)
        {

        }

        public string GenerateCode()
        {
            return "";
        }

        private void ElementToSelectChanged(AutomationElement obj)
        {
            var pathToRoot = GetElementPathToRoot(obj);
        }

        private Stack<AutomationElement> GetElementPathToRoot(AutomationElement obj)
        {
            var pathToRoot = new Stack<AutomationElement>();
            while (obj != null)
            {
                // Break on circular relationship (should not happen?)
                if (pathToRoot.Contains(obj) || obj.Equals(_rootElement)) { break; }

                pathToRoot.Push(obj);
                try
                {
                    obj = _treeWalker.GetParent(obj);
                }
                catch (Exception ex)
                {
                    // TODO: Log
                    Console.WriteLine($"Exception: {ex.Message}");
                }
            }

            return pathToRoot;
        }
    }
}
