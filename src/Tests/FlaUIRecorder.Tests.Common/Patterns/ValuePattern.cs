using FlaUI.Core;
using FlaUI.Core.Identifiers;
using FlaUI.Core.Patterns;
using FlaUI.UIA2.Identifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIA = System.Windows.Automation;


namespace FlaUIRecorder.Tests.Common.Patterns
{
    public class ValuePattern : ValuePatternBase<NativeValuePattern>
    {
        public static readonly PatternId Pattern = PatternId.Register(AutomationType.UIA2, UIA.ValuePattern.Pattern.Id, "Value", AutomationObjectIds.IsValuePatternAvailableProperty);
        public static readonly PropertyId IsReadOnlyProperty = PropertyId.Register(AutomationType.UIA2, UIA.ValuePattern.IsReadOnlyProperty.Id, "IsReadOnly");
        public static readonly PropertyId ValueProperty = PropertyId.Register(AutomationType.UIA2, UIA.ValuePattern.ValueProperty.Id, "Value");

        public ValuePattern(TestBasicAutomationElement basicAutomationElement, NativeValuePattern nativePattern) : base(basicAutomationElement, nativePattern)
        {
        }

        /// <inheritdoc />
        public override void SetValue(string value)
        {
            ((TestBasicAutomationElement)BasicAutomationElement).SetPropertyValue(13, value);
        }
    }

    public class ValuePatternProperties : IValuePatternProperties
    {
        public PropertyId IsReadOnly => ValuePattern.IsReadOnlyProperty;

        public PropertyId Value => ValuePattern.ValueProperty;
    }

    public class NativeValuePattern
    {
        public static NativeValuePattern Instance { get; private set; } = new NativeValuePattern();
    }
}
