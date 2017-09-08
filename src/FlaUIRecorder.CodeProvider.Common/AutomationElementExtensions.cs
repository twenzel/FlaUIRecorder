using FlaUI.Core.AutomationElements.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlaUIRecorder.CodeProvider
{
    public static class AutomationElementExtensions
    {
        /// <summary>
        /// Determines whether the element is the requested type.
        /// </summary>
        /// <param name="element">The element to check.</param>
        /// <param name="typeToCheck">The control type to check agains.</param>
        /// <returns></returns>
        public static bool IsControlType(this AutomationElement element, FlaUI.Core.Definitions.ControlType typeToCheck)
        {
            if (element.Properties.ControlType.TryGetValue(out var type))
                return type == typeToCheck;
            else
                return false;
        }

        /// <summary>
        /// Determines whether this element is a menu Item
        /// </summary>
        /// <param name="element">The item to check</param>
        /// <returns></returns>
        public static bool IsMenuItem(this AutomationElement element)
        {
            return IsControlType(element, FlaUI.Core.Definitions.ControlType.MenuItem);
        }

    }
}
