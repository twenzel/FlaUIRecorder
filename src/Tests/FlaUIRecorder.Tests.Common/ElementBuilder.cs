using FlaUI.Core.AutomationElements;
using FlaUI.Core.AutomationElements.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlaUIRecorder.Tests.Common
{
    /// <summary>
    /// Builds automation Elements used for testing
    /// </summary>
    public class ElementBuilder
    {
        private AutomationElement _element;
        private TestAutomationElement _innerElement;

        /// <summary>
        /// Creates a TextBox element
        /// </summary>
        /// <returns></returns>
        public ElementBuilder CreateTextBox()
        {
            _innerElement = new TestAutomationElement() { ControlType = FlaUI.Core.Definitions.ControlType.Text };
            _element = new TextBox(new TestBasicAutomationElement(new TestAutomation(), _innerElement));

            return this;
        }

        /// <summary>
        /// Creates a Button element
        /// </summary>
        /// <returns></returns>
        public ElementBuilder CreateButton()
        {
            _innerElement = new TestAutomationElement() { ControlType = FlaUI.Core.Definitions.ControlType.Button };
            _element = new Button(new TestBasicAutomationElement(new TestAutomation(), _innerElement));

            return this;
        }

        /// <summary>
        /// Creates a MenuItem element
        /// </summary>
        /// <returns></returns>
        public ElementBuilder CreateMenuItem()
        {
            _innerElement = new TestAutomationElement() { ControlType = FlaUI.Core.Definitions.ControlType.MenuItem };
            _element = new MenuItem(new TestBasicAutomationElement(new TestAutomation(), _innerElement));

            return this;
        }

        /// <summary>
        /// Creates a Pane element
        /// </summary>
        /// <returns></returns>
        public ElementBuilder CreatePane()
        {
            _innerElement = new TestAutomationElement() { ControlType = FlaUI.Core.Definitions.ControlType.Pane };
            _element = new MenuItem(new TestBasicAutomationElement(new TestAutomation(), _innerElement));

            return this;
        }

        /// <summary>
        /// Sets the name property
        /// </summary>
        /// <param name="name">Value of the name property</param>
        /// <returns></returns>
        public ElementBuilder WithName(string name)
        {
            _innerElement.Name = name;

            return this;
        }

        /// <summary>
        /// Sets a property value.
        /// </summary>
        /// <param name="propertyId">The Id of the property. e.g. "AutomationObjectIds.NameProperty.Id"</param>        
        /// <param name="value">The value of the property</param>
        public ElementBuilder WithPropertyValue(int propertyId, object value)
        {
            _innerElement.SetPropertyValue(propertyId, value);

            return this;
        }

        /// <summary>
        /// Builds the element
        /// </summary>
        /// <returns></returns>
        public AutomationElement Build()
        {
            return _element;
        }
    }
}
