using FlaUI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIA = System.Windows.Automation;

namespace FlaUIRecorder.Tests.Common.Converters
{
    public static class TextRangeConverter
    {
        public static ITextRange[] NativeArrayToManaged(TestAutomation automation, UIA.Text.TextPatternRange[] nativeElements)
        {
            if (nativeElements == null)
            {
                return new ITextRange[0];
            }
            return nativeElements.Select(r => (ITextRange)NativeToManaged(automation, r)).ToArray();
        }

        public static TestTextRange NativeToManaged(TestAutomation automation, UIA.Text.TextPatternRange nativeElement)
        {
            return nativeElement == null ? null : new TestTextRange(automation, nativeElement);
        }
    }
}
