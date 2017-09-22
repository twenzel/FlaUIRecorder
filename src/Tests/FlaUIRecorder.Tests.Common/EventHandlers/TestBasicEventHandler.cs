using FlaUI.Core;
using FlaUI.Core.AutomationElements.Infrastructure;
using FlaUI.Core.EventHandlers;
using FlaUI.Core.Identifiers;
using UIA = System.Windows.Automation;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlaUIRecorder.Tests.Common.EventHandlers
{    
    public class TestBasicEventHandler : BasicEventHandlerBase
    {
        public UIA.AutomationEventHandler EventHandler { get; private set; }

        public TestBasicEventHandler(AutomationBase automation, Action<AutomationElement, EventId> callAction) : base(automation, callAction)
        {
            EventHandler = HandleAutomationEvent;
        }

        private void HandleAutomationEvent(object sender, UIA.AutomationEventArgs automationEventArgs)
        {
            var basicAutomationElement = new TestBasicAutomationElement((TestAutomation)Automation, (UIA.AutomationElement)sender);
            var senderElement = new AutomationElement(basicAutomationElement);
            var @event = EventId.Find(AutomationType.UIA2, automationEventArgs.EventId.Id);
            HandleAutomationEvent(senderElement, @event);
        }
    }
}
