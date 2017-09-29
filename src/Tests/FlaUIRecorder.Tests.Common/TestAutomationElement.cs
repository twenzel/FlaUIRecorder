using FlaUI.Core.AutomationElements.Infrastructure;
using FlaUI.Core.Identifiers;
using FlaUI.UIA2.Identifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;

namespace FlaUIRecorder.Tests.Common
{
    public class TestAutomationElement
    {
        private Dictionary<Int32, object> propertyValues = new Dictionary<Int32, object>();
        private System.Windows.Automation.AutomationElement nativeElement;

        public TestAutomationElement()
        {
            Name = "";
            ControlType = FlaUI.Core.Definitions.ControlType.Custom;
        }

        public TestAutomationElement(System.Windows.Automation.AutomationElement nativeElement) : this()
        {
            this.nativeElement = nativeElement;
        }

        public string Name
        {
            get { return propertyValues[AutomationObjectIds.NameProperty.Id] as string; }
            set { propertyValues[AutomationObjectIds.NameProperty.Id] = value; }
        }

        public FlaUI.Core.Definitions.ControlType ControlType
        {
            get { return (FlaUI.Core.Definitions.ControlType)FlaUI.UIA2.Converters.ControlTypeConverter.ToControlType(propertyValues[AutomationObjectIds.ControlTypeProperty.Id]); }
            set { propertyValues[AutomationObjectIds.ControlTypeProperty.Id] = FlaUI.UIA2.Converters.ControlTypeConverter.ToControlTypeNative(value); }
        }

        /// <summary>
        /// Sets a property value.
        /// </summary>
        /// <param name="propertyId">The Id of the property. e.g. "AutomationObjectIds.NameProperty.Id"</param>        
        /// <param name="value">The value of the property</param>
        public void SetPropertyValue(int propertyId, object value)
        {
            propertyValues[propertyId] = value;
        }

        public object GetPropertyValue(AutomationProperty property, bool ignoreDefaultValue)
        {
            if (propertyValues.TryGetValue(property.Id, out var value))
                return value;
            //else if (ignoreDefaultValue)
            return GetDefaultValue(property);
        }

        private object GetDefaultValue(AutomationProperty property)
        {
            if (property.Id == AutomationObjectIds.ControlTypeProperty.Id)
                return FlaUI.Core.Definitions.ControlType.Button;

            return null;
        }

        internal object GetPattern(AutomationPattern pattern)
        {
            throw new NotImplementedException();
        }
    }
}
