using System;
using System.Text.RegularExpressions;

using FlaUI.Core.AutomationElements.Infrastructure;

namespace FlaUIRecorder.CodeProvider.PowerShell
{
    public static class PowerShellCodeHelper
    {
        public static string GetVariableName(this AutomationElement element)
        {
            if (null == element)
                throw new ArgumentNullException(nameof(element));

            string controlTypeName;

            if (element.Properties.Name.TryGetValue(out var elementName) && !string.IsNullOrEmpty(elementName))
                elementName = Char.ToLower(elementName[0]) + elementName.Substring(1); // to camel case
            else
                elementName = "unkown";

            elementName = Regex.Replace(elementName, "[^\\d\\w_]", "");

            if (element.Properties.ControlType.TryGetValue(out var controlType))
                controlTypeName = controlType.ToString();
            else
                controlTypeName = "Item";

            return elementName + controlTypeName;
        }
    }
}
