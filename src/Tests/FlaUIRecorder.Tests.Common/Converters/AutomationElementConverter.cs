using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlaUI.Core;
using FlaUI.Core.AutomationElements.Infrastructure;
using UIA = System.Windows.Automation;

namespace FlaUIRecorder.Tests.Common.Converters
{
    public static class AutomationElementConverter
    {
        public static AutomationElement[] NativeArrayToManaged(AutomationBase automation, object nativeElements)
        {
            if (nativeElements == null)
            {
                return new AutomationElement[0];
            }
            var uia2Automation = (TestAutomation)automation;
            var nativeElementsCollection = nativeElements as UIA.AutomationElementCollection;
            if (nativeElementsCollection != null)
            {
                var retArray = new AutomationElement[nativeElementsCollection.Count];
                for (var i = 0; i < nativeElementsCollection.Count; i++)
                {
                    var nativeElement = nativeElementsCollection[i];
                    var automationElement = uia2Automation.WrapNativeElement(nativeElement);
                    retArray[i] = automationElement;
                }
                return retArray;
            }
            var nativeElementsArray = nativeElements as UIA.AutomationElement[];
            if (nativeElementsArray != null)
            {
                return nativeElementsArray.Select(uia2Automation.WrapNativeElement).ToArray();
            }
            throw new ArgumentException("Input is neither an AutomationElementCollection nor an AutomationElement[]", nameof(nativeElements));
        }

        public static AutomationElement NativeToManaged(AutomationBase automation, object nativeElement)
        {
            var uia2Automation = (TestAutomation)automation;
            return uia2Automation.WrapNativeElement((UIA.AutomationElement)nativeElement);
        }

        public static UIA.AutomationElement ToNative(this AutomationElement automationElement)
        {
            throw new NotImplementedException();
            //if (automationElement == null)
            //{
            //    return null;
            //}
            //var basicElement = automationElement.BasicAutomationElement as TestBasicAutomationElement;
            //if (basicElement == null)
            //{
            //    throw new Exception("Element is not an TestUI element");
            //}
            //return basicElement.NativeElement;
        }
    }
}
