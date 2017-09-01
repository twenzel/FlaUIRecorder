using FlaUI.Core;
using FlaUI.Core.AutomationElements.Infrastructure;
using FlaUI.Core.EventHandlers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlaUIRecorder.Internal
{
    public class FocusTrackingMode
    {
        private readonly AutomationBase _automation;
        private IAutomationFocusChangedEventHandler _eventHandler;
        private AutomationElement _currentFocusedElement;
        private readonly int _targetProcessId;

        public event Action<AutomationElement> ElementFocused;

        public FocusTrackingMode(AutomationBase automation, int targetProcessId)
        {
            _automation = automation;
            _targetProcessId = targetProcessId;
        }

        public void Start()
        {
            // Might give problems because inspect is registered as well.
            // MS recommends to call UIA commands on a thread outside of an UI thread.
            Task.Factory.StartNew(() => _eventHandler = _automation.RegisterFocusChangedEvent(OnFocusChanged));
        }

        public void Stop()
        {
            _automation.UnRegisterFocusChangedEvent(_eventHandler);
        }

        private void OnFocusChanged(AutomationElement automationElement)
        {            
            if (automationElement.Properties.ProcessId != _targetProcessId)            
                return;
            
            if (!Equals(_currentFocusedElement, automationElement))
            {
                _currentFocusedElement = automationElement;
                //System.Windows.Application.Current.Dispatcher.Invoke(() =>
                //{
                    ElementFocused?.Invoke(automationElement);
                //});
            }
        }
    }
}
