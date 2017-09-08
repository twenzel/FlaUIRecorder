using FlaUI.Core;
using FlaUI.Core.AutomationElements.Infrastructure;
using FlaUI.Core.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace FlaUIRecorder.Internal.Worker
{
    /// <summary>
    /// Worker to highlight the current hovered ui element
    /// </summary>
    public class HoverWorker : IRecordWorker
    {
        private readonly AutomationBase _automation;
        private readonly Timer _dispatcherTimer;
        private AutomationElement _currentHoveredElement;
        private readonly int _targetProcessId;

        public event EventHandler<AutomationElement> ElementHovered;

        public HoverWorker(AutomationBase automation, int targetProcessId)
        {
            _automation = automation;
            _dispatcherTimer = new Timer(500);
            _dispatcherTimer.Elapsed += DispatcherTimerTick;
            _targetProcessId = targetProcessId;
        }

        public void Dispose()
        {
            Pause();
        }

        public void Start()
        {
            _currentHoveredElement = null;
            _dispatcherTimer.Start();
        }

        public void Pause()
        {
            _currentHoveredElement = null;
            _dispatcherTimer.Stop();
        }

        private void DispatcherTimerTick(object sender, EventArgs e)
        {
            var screenPos = Mouse.Position;
            try
            {
                var hoveredElement = _automation.FromPoint(screenPos);

                if (hoveredElement != null && hoveredElement.Properties.ProcessId != _targetProcessId)
                    return;

                if (!Equals(_currentHoveredElement, hoveredElement))
                {
                    _currentHoveredElement = hoveredElement;
                    ElementHovered?.Invoke(this, hoveredElement);
                    HighlightElement(hoveredElement);
                }
            }
            catch
            {
                _currentHoveredElement = null;
            }
        }

        public static void HighlightElement(AutomationElement automationElement)
        {
            Task.Run(() =>
            {
                try
                {
                    automationElement.DrawHighlight(false, Color.Red, 1000);
                }
                catch{ }
            }
            );
        }
    }
}
