using System;
using System.Collections.Generic;

using FlaUI.Core.AutomationElements.Infrastructure;
using FlaUI.Core;
using System.Diagnostics;
using FlaUI.Core.AutomationElements;

namespace FlaUIRecorder.CodeProvider.Common
{
    public abstract class CodeProviderCore : ICodeProvider
    {
        public AutomationBase Automation { get; private set; }
        public ITreeWalker TreeWalker { get; private set; }
        public AutomationElement RootElement { get; private set; }
        public Process TargetProcess { get; private set; }

        private Window _mainWindow;

        public CodeProviderCore(CodeProviderArguments args)
        {
            Automation = args.Automation;
            TargetProcess = args.TargetProcess;

            RootElement = FindTargetApplicationRoot(args.TargetProcess.Id);

            // Initialize TreeWalker
            TreeWalker = Automation.TreeWalkerFactory.GetControlViewWalker();
        }

        protected Window GetMainWindow()
        {
            if (_mainWindow == null)
            {
                IntPtr mainWindowHandle = TargetProcess.MainWindowHandle;

                if (mainWindowHandle == IntPtr.Zero)
                    return null;

                _mainWindow = Automation.FromHandle(mainWindowHandle).AsWindow();
            }

            return _mainWindow;
        }

        protected List<AutomationElement> GetElementPathToRoot(AutomationElement obj)
        {
            var pathToRoot = new List<AutomationElement>();
            while (obj != null)
            {
                // Break on circular relationship (should not happen?)
                if (pathToRoot.Contains(obj) || obj.Equals(RootElement)) { break; }

                pathToRoot.Add(obj);
                try
                {
                    obj = TreeWalker.GetParent(obj);
                }
                catch (Exception ex)
                {
                    // TODO: Log
                    Console.WriteLine($"Exception: {ex.Message}");
                }
            }

            return pathToRoot;
        }

        protected AutomationElement GetParentOrMainWindow(AutomationElement element)
        {
            AutomationElement parent = null;

            try
            {
                parent = TreeWalker.GetParent(element);
            }
            catch (Exception ex)
            {
                // TODO: Log
                Console.WriteLine($"Exception: {ex.Message}");
            }

            if (parent == null)
                parent = GetMainWindow();

            return parent;
        }

        private AutomationElement FindTargetApplicationRoot(int targetProcessId)
        {
            var element = Automation.GetDesktop();
            var root = element.FindFirstChild(c => c.ByProcessId(targetProcessId));

            return root;
        }

        /// <summary>
        /// Adds a new comment to the code
        /// </summary>
        /// <param name=""></param>
        public abstract void AddComment(string comment);

        /// <summary>
        /// Will be called when the a left mouse click occured
        /// </summary>
        /// <param name="element"></param>
        public abstract void Click(AutomationElement element);

        /// <summary>
        /// Will be called when the a right mouse click occured
        /// </summary>
        /// <param name="element"></param>
        public abstract void RightClick(AutomationElement element);

        /// <summary>
        /// Generate the final code
        /// </summary>
        /// <returns></returns>
        public abstract string Generate();
    }
}
