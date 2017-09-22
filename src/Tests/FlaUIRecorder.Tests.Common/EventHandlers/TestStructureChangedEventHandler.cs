
using System;
using FlaUI.Core;
using FlaUI.Core.AutomationElements.Infrastructure;
using FlaUI.Core.Definitions;
using FlaUI.Core.EventHandlers;
using UIA = System.Windows.Automation;
namespace FlaUIRecorder.Tests.Common.EventHandlers
{

    public class TestStructureChangedEventHandler : StructureChangedEventHandlerBase
    {
        public UIA.StructureChangedEventHandler EventHandler { get; private set; }

        public TestStructureChangedEventHandler(AutomationBase automation, Action<AutomationElement, StructureChangeType, int[]> callAction) : base(automation, callAction)
        {
            EventHandler = HandleStructureChangedEvent;
        }

        private void HandleStructureChangedEvent(object sender, UIA.StructureChangedEventArgs structureChangedEventArgs)
        {
            var basicAutomationElement = new TestBasicAutomationElement((TestAutomation)Automation, (UIA.AutomationElement)sender);
            var senderElement = new AutomationElement(basicAutomationElement);
            HandleStructureChangedEvent(senderElement, (StructureChangeType)structureChangedEventArgs.StructureChangeType, structureChangedEventArgs.GetRuntimeId());
        }
    }
}
