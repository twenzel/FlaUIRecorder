using FlaUI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlaUI.Core.AutomationElements.Infrastructure;
using FlaUI.Core.Patterns;

namespace FlaUIRecorder.Tests.Common
{
    public class TestEventLibrary : IEventLibrary
    {
        public IAutomationElementEvents Element => throw new NotImplementedException();

        public IDragPatternEvents Drag => throw new NotImplementedException();

        public IDropTargetPatternEvents DropTarget => throw new NotImplementedException();

        public IInvokePatternEvents Invoke => throw new NotImplementedException();

        public ISelectionItemPatternEvents SelectionItem => throw new NotImplementedException();

        public ISelectionPatternEvents Selection => throw new NotImplementedException();

        public ISynchronizedInputPatternEvents SynchronizedInput => throw new NotImplementedException();

        public ITextEditPatternEvents TextEdit => throw new NotImplementedException();

        public ITextPatternEvents Text => throw new NotImplementedException();

        public IWindowPatternEvents Window => throw new NotImplementedException();
    }
}
