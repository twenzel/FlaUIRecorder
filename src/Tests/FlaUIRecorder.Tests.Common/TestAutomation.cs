using FlaUI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlaUI.Core.AutomationElements.Infrastructure;
using FlaUI.Core.EventHandlers;
using FlaUI.Core.Shapes;
using UIA = System.Windows.Automation;

namespace FlaUIRecorder.Tests.Common
{
    public class TestAutomation : AutomationBase
    {
        public TestAutomation() : base(new TestPropertyLibray(), new TestEventLibrary(), new TestPatternLibrary())
        {
        }

        public override ITreeWalkerFactory TreeWalkerFactory => throw new NotImplementedException();

        public override AutomationType AutomationType => AutomationType.UIA2;

        public override object NotSupportedValue => System.Windows.Automation.AutomationElementIdentifiers.NotSupported;

        public override bool Compare(AutomationElement element1, AutomationElement element2)
        {
            throw new NotImplementedException();
        }

        public override AutomationElement FocusedElement()
        {
            throw new NotImplementedException();
        }

        public override AutomationElement FromHandle(IntPtr hwnd)
        {
            throw new NotImplementedException();
        }

        public override AutomationElement FromPoint(Point point)
        {
            throw new NotImplementedException();
        }

        public override AutomationElement GetDesktop()
        {
            throw new NotImplementedException();
        }

        public override IAutomationFocusChangedEventHandler RegisterFocusChangedEvent(Action<AutomationElement> action)
        {
            throw new NotImplementedException();
        }

        public override void UnregisterAllEvents()
        {
            throw new NotImplementedException();
        }

        public override void UnRegisterFocusChangedEvent(IAutomationFocusChangedEventHandler eventHandler)
        {
            throw new NotImplementedException();
        }

        public AutomationElement WrapNativeElement(UIA.AutomationElement nativeElement)
        {
            return nativeElement == null ? null : new AutomationElement(new TestBasicAutomationElement(this, nativeElement));
        }
    }
}
