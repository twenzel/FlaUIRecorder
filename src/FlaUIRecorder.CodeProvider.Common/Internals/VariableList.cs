using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlaUI.Core.AutomationElements.Infrastructure;

namespace FlaUIRecorder.CodeProvider.Common.Internals
{
    public class VariableList : List<Variable>
    {
        /// <summary>
        /// Gets a variable by its name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Variable this[string name]
        {
            get
            {
                var result = this.FirstOrDefault(v => 0 == string.Compare(v.Name, name, StringComparison.OrdinalIgnoreCase));

                if (result == null)
                    throw new ArgumentException($"No variable of name '{name}' found!");

                return result;
            }
        }

        /// <summary>
        /// Adds a new variable
        /// </summary>
        /// <param name="name">The variable name</param>
        /// <param name="element">The according ui element.</param>
        public Variable Add(string name, AutomationElement element)
        {
            var result = new Variable { Name = name, Element = element };
            Add(result);

            return result;
        }

        /// <summary>
        /// Finds a variable by the given element
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public Variable Find(AutomationElement element)
        {
            // first try by automationid, because the AutomationElement.Compare does not work in every case (especially UIA3)
            if (element.Properties.AutomationId.TryGetValue(out var automationId) && !string.IsNullOrEmpty(automationId))
            {
                var result = this.FirstOrDefault(v => v.Element.Properties.AutomationId.TryGetValue(out var id) && id == automationId);

                if (result != null)
                    return result;
            }

            return this.FirstOrDefault(v => Equals(v.Element, element));
        }
    }
}
