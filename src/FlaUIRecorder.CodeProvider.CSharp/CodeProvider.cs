using FlaUIRecorder.CodeProvider.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlaUI.Core.AutomationElements.Infrastructure;
using FlaUI.Core;
using FlaUIRecorder.CodeProvider.Common.Internals;

namespace FlaUIRecorder.CodeProvider.CSharp
{
    [CodeProviderName("C#")]
    public class CodeProvider : CodeProviderCore
    {
        private readonly StringBuilder _builder = new StringBuilder();
        private AutomationElement _lastElement;
        private VariableList _existingVariables = new VariableList();

        public CodeProvider(CodeProviderArguments args) : base(args)
        {
            _existingVariables.Add("window", GetMainWindow());
            _existingVariables.Add("desktop", Automation.GetDesktop());
        }


        public override void AddComment(string comment)
        {
            _builder.AppendLine($"// {comment}");
        }

        public override void Click(AutomationElement element)
        {
            System.Diagnostics.Debug.WriteLine("CodeProvider click " + element.ToString());

            var variable = BuildPathToParent(element);
            _builder.AppendLine($"{variable.Name}.Click();");

            if (element.IsMenuItem())
                _builder.AppendLine("// Wait a bit for the animation \r\nSystem.Threading.Thread.Sleep(500);");
        }

        public override void RightClick(AutomationElement element)
        {
            var variable = BuildPathToParent(element);
            _builder.AppendLine($"{variable.Name}.RightClick();");

            if (element.IsMenuItem())
                _builder.AppendLine("// Wait a bit for the animation \r\nSystem.Threading.Thread.Sleep(500);");
        }

        public override string Generate()
        {
            return _builder.ToString();
        }

        #region private methods       

        private Variable BuildPathToParent(AutomationElement element)
        {
            var parent = GetParentOrMainWindow(element);

            var parentVariable = _existingVariables.Find(parent);

            if (parentVariable == null)
            {
                parentVariable = BuildPathToParent(parent);
            }

            var variableName = CreateVariableName(element);

            if (element.Properties.AutomationId.TryGetValue(out var automationId) && !string.IsNullOrEmpty(automationId))
            {
                _builder.Append($"var {variableName} = {parentVariable.Name}.FindFirstDescendant(e => e.ByAutomationId(\"{automationId}\"))");
            }
            else if (element.Properties.Name.TryGetValue(out var name) && !string.IsNullOrEmpty(name))
            {
                _builder.Append($"var {variableName} = {parentVariable.Name}.FindFirstChild(e => e.ByName(\"{name}\"))");
            }
            else if (element.Properties.ControlType.TryGetValue(out var controlType))
            {
                _builder.Append($"var {variableName} = {parentVariable.Name}.FindFirstChild(e => e.ByControlType(FlaUI.Core.Definitions.ControlType.{controlType}))");
            }

            // AsMenu(), As.Button()

            _builder.AppendLine(";");

            return _existingVariables.Add(variableName, element);
        }

        private string CreateVariableName(AutomationElement element)
        {
            string elementName = CSharpCodeHelper.GetVariableName(element);
            string itemIdentifyer;

            if (!element.Properties.AutomationId.TryGetValue(out itemIdentifyer) || string.IsNullOrEmpty(itemIdentifyer))
                itemIdentifyer = "_" + GetVariableIdentifier(elementName);

            return elementName + itemIdentifyer;
        }

        private string GetVariableIdentifier(string variableName)
        {
            var amount = _existingVariables.Count(v => v.Name.StartsWith(variableName) && v.Name.Length > variableName.Length && Char.IsDigit(v.Name[variableName.Length]));

            return (amount + 1).ToString();
        }
        #endregion
    }
}
