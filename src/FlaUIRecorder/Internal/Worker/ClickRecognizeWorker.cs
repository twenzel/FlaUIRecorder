using EventHook;
using FlaUI.Core;
using FlaUI.Core.AutomationElements.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlaUIRecorder.Internal.Worker
{
    /// <summary>
    /// Class to recognize a mouse click and raises an event with the according AutomationElement
    /// </summary>
    public class ClickRecognizeWorker : IRecordWorker
    {
        private readonly AutomationBase _automation;
        private readonly int _targetProcessId;

        public event EventHandler<AutomationElement> ElementClicked;
        public event EventHandler<AutomationElement> ElementRightClicked;

        public ClickRecognizeWorker(AutomationBase automation, int targetProcessId)
        {
            _automation = automation;
            _targetProcessId = targetProcessId;

            MouseWatcher.OnMouseInput += MouseWatcher_OnMouseInput;
        }

        public void Dispose()
        {
            Pause();
            MouseWatcher.OnMouseInput -= MouseWatcher_OnMouseInput;
        }

        public void Start()
        {
            MouseWatcher.Start();            
        }

        public void Pause()
        {
            MouseWatcher.Stop();
        }

        private void MouseWatcher_OnMouseInput(object sender, MouseEventArgs e)
        {
            if (e.Message == EventHook.Hooks.MouseMessages.WM_LBUTTONDOWN)
            {
                System.Diagnostics.Debug.WriteLine("MouseWatcher l-down");

                var hoveredElement = GetHoveredElement(e.Point);

                if (hoveredElement != null)
                    ElementClicked?.Invoke(this, hoveredElement);
            } else if (e.Message == EventHook.Hooks.MouseMessages.WM_RBUTTONDOWN)
            {
                var hoveredElement = GetHoveredElement(e.Point);

                if (hoveredElement != null)
                    ElementRightClicked?.Invoke(this, hoveredElement);
            }
        }

        private AutomationElement GetHoveredElement(EventHook.Hooks.POINT point)
        {
            var hoveredElement = _automation.FromPoint(new FlaUI.Core.Shapes.Point(point.x, point.y));

            if (hoveredElement.Properties.ProcessId != _targetProcessId)
                return null;
            else
                return hoveredElement;
        }
    }
}
