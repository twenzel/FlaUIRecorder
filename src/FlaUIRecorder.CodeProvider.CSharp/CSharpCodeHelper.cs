using FlaUI.Core.AutomationElements.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FlaUIRecorder.CodeProvider.CSharp
{
    public static class CSharpCodeHelper
    {
        public static string GetVariableName(this AutomationElement element)
        {
            string controlTypeName;
            string elementName;

            if (element.Properties.Name.TryGetValue(out elementName) && !string.IsNullOrEmpty(elementName))
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
