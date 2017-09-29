using FlaUI.Core;
using FlaUI.Core.AutomationElements.Infrastructure;
using FlaUI.Core.Definitions;
using FlaUI.Core.Identifiers;
using FlaUI.Core.Patterns;
using FlaUI.Core.Shapes;
using FlaUI.UIA2.Identifiers;
using FlaUIRecorder.Tests.Common.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIA = System.Windows.Automation;

namespace FlaUIRecorder.Tests.Common.Patterns
{
    public class TextPattern : TextPatternBase<NativeTextPattern>
    {
        public static readonly PatternId Pattern = PatternId.Register(AutomationType.UIA2, UIA.TextPattern.Pattern.Id, "Text", AutomationObjectIds.IsTextPatternAvailableProperty);
        public static readonly EventId TextChangedEvent = EventId.Register(AutomationType.UIA2, UIA.TextPattern.TextChangedEvent.Id, "TextChanged");
        public static readonly EventId TextSelectionChangedEvent = EventId.Register(AutomationType.UIA2, UIA.TextPattern.TextSelectionChangedEvent.Id, "TextSelectionChanged");

        public TextPattern(BasicAutomationElementBase basicAutomationElement, NativeTextPattern nativePattern) : base(basicAutomationElement, nativePattern)
        {
        }

        public override ITextRange DocumentRange
        {
            get
            {
                //var nativeRange = NativePattern.DocumentRange;
                //return TextRangeConverter.NativeToManaged((TestAutomation)BasicAutomationElement.Automation, nativeRange);
                throw new NotImplementedException();
            }
        }

        public override SupportedTextSelection SupportedTextSelection
        {
            get
            {
                //var nativeObject = NativePattern.SupportedTextSelection;
                //return (SupportedTextSelection)nativeObject;
                throw new NotImplementedException();
            }
        }

        public override ITextRange[] GetSelection()
        {
            //var nativeRanges = NativePattern.GetSelection();
            //return TextRangeConverter.NativeArrayToManaged((TestAutomation)BasicAutomationElement.Automation, nativeRanges);
            throw new NotImplementedException();
        }

        public override ITextRange[] GetVisibleRanges()
        {
            //var nativeRanges = NativePattern.GetVisibleRanges();
            //return TextRangeConverter.NativeArrayToManaged((TestAutomation)BasicAutomationElement.Automation, nativeRanges);
            throw new NotImplementedException();
        }

        public override ITextRange RangeFromChild(AutomationElement child)
        {
            //var nativeChild = child.ToNative();
            //var nativeRange = NativePattern.RangeFromChild(nativeChild);
            //return TextRangeConverter.NativeToManaged((TestAutomation)BasicAutomationElement.Automation, nativeRange);
            throw new NotImplementedException();
        }

        public override ITextRange RangeFromPoint(Point point)
        {
            //var nativeRange = NativePattern.RangeFromPoint(FlaUI.UIA2.Converters.ValueConverter.ToNative(point));
            //return TextRangeConverter.NativeToManaged((TestAutomation)BasicAutomationElement.Automation, nativeRange);
            throw new NotImplementedException();
        }
    }

    public class NativeTextPattern
    {
        public static NativeTextPattern Instance { get; private set; } = new NativeTextPattern();       
    }
}
