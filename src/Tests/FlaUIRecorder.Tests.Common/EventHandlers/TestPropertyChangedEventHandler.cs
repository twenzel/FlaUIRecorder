
using System;
using FlaUI.Core;
using FlaUI.Core.AutomationElements.Infrastructure;
using FlaUI.Core.EventHandlers;
using FlaUI.Core.Identifiers;
using UIA = System.Windows.Automation;

namespace FlaUIRecorder.Tests.Common.EventHandlers
{

    public class TestPropertyChangedEventHandler : PropertyChangedEventHandlerBase
    {
        public UIA.AutomationPropertyChangedEventHandler EventHandler { get; private set; }

        public TestPropertyChangedEventHandler(AutomationBase automation, Action<AutomationElement, PropertyId, object> callAction) : base(automation, callAction)
        {
            EventHandler = HandlePropertyChangedEvent;
        }

        private void HandlePropertyChangedEvent(object sender, UIA.AutomationPropertyChangedEventArgs automationPropertyChangedEventArgs)
        {
            var basicAutomationElement = new TestBasicAutomationElement((TestAutomation)Automation, (UIA.AutomationElement)sender);
            var senderElement = new AutomationElement(basicAutomationElement);
            var propertyId = PropertyId.Find(Automation.AutomationType, automationPropertyChangedEventArgs.Property.Id);
            HandlePropertyChangedEvent(senderElement, propertyId, automationPropertyChangedEventArgs.NewValue);
        }
    }
}
