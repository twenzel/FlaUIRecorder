using System;
using System.Linq;
using System.Text;

using FlaUI.Core.AutomationElements.Infrastructure;
using FlaUIRecorder.CodeProvider.Common;
using FlaUIRecorder.CodeProvider.Common.Internals;

namespace FlaUIRecorder.CodeProvider.PowerShell
{
    [CodeProviderName("PowerShell")]
    public class CodeProvider : CodeProviderCore
    {
        private readonly StringBuilder _builder = new StringBuilder();
        private readonly VariableList _existingVariables = new VariableList();

        public CodeProvider(CodeProviderArguments args)
            : base(args)
        {
            var executable = args?.TargetProcess?.MainModule.FileName;
            _builder.AppendLine(AddPowerShellHeader(executable));

            _existingVariables.Add("window", GetMainWindow());
            _existingVariables.Add("desktop", Automation.GetDesktop());
        }

        public override void AddComment(string comment)
        {
            if (!string.IsNullOrWhiteSpace(comment))
                _builder.AppendLine($"# {comment}");
        }

        public override void Click(AutomationElement element)
        {
            System.Diagnostics.Debug.WriteLine("CodeProvider click " + element.ToString());

            var variable = BuildPathToParent(element);
            _builder.AppendLine($"${variable.Name}.Click()");

            if (element.IsMenuItem())
                _builder.AppendLine("# Wait a bit for the animation \r\nStart-Sleep -m 500");
        }

        public override void RightClick(AutomationElement element)
        {
            var variable = BuildPathToParent(element);
            _builder.AppendLine($"${variable.Name}.RightClick()");

            if (element.IsMenuItem())
                _builder.AppendLine("# Wait a bit for the animation \r\nStart-Sleep -m 500");
        }

        public override string Generate()
        {
            _builder.AppendLine(AddPowerShellFooter());

            return _builder.ToString();
        }

        private Variable BuildPathToParent(AutomationElement element)
        {
            var parent = GetParentOrMainWindow(element);

            var parentVariable = _existingVariables.Find(parent) ?? BuildPathToParent(parent);

            var variableName = CreateVariableName(element);

            if (element.Properties.AutomationId.TryGetValue(out var automationId) && !string.IsNullOrEmpty(automationId))
            {
                _builder.Append($"${variableName} = ${parentVariable.Name}.FindFirstDescendant($uia.ConditionFactory.ByAutomationId(\"{automationId}\"))");
            }
            else if (element.Properties.Name.TryGetValue(out var name) && !string.IsNullOrEmpty(name))
            {
                _builder.Append($"${variableName} = ${parentVariable.Name}.FindFirstChild($uia.ConditionFactory.ByName(\"{name}\"))");
            }
            else if (element.Properties.ControlType.TryGetValue(out var controlType))
            {
                _builder.Append($"${variableName} = ${parentVariable.Name}.FindFirstChild($uia.ConditionFactory.ByControlType([FlaUI.Core.Definitions.ControlType]::{controlType}))");
            }

            _builder.AppendLine(string.Empty);

            return _existingVariables.Add(variableName, element);
        }

        private string CreateVariableName(AutomationElement element)
        {
            var elementName = element.GetVariableName();

            if (!element.Properties.AutomationId.TryGetValue(out var itemIdentifyer) || string.IsNullOrEmpty(itemIdentifyer))
                itemIdentifyer = "_" + GetVariableIdentifier(elementName);

            return elementName + itemIdentifyer;
        }

        private string GetVariableIdentifier(string variableName)
        {
            var amount = _existingVariables.Count(v => v.Name.StartsWith(variableName, StringComparison.OrdinalIgnoreCase) && v.Name.Length > variableName.Length && Char.IsDigit(v.Name[variableName.Length]));

            return (amount + 1).ToString();
        }

        private string AddPowerShellHeader(string executable)
        {
            const string ExecutableTemplate = "<Path to executable>";
            if (string.IsNullOrEmpty(executable)) executable = ExecutableTemplate;

            var retVal =    @"Add-Type -Path '<Path to>\FlaUI.Core.dll'" + Environment.NewLine
                         +  @"Add-Type -Path '<Path to>\FlaUI.UIA3.dll'" + Environment.NewLine
                         + $@"$app = [FlaUI.Core.Application]::Launch('{executable}')" + Environment.NewLine
                         +  @"$uia = New-Object FlaUI.UIA3.UIA3Automation" + Environment.NewLine
                         +  @"$window = $app.GetMainWindow($uia)" + Environment.NewLine
                         +  @"# --------- [ real test starts here ] ---------" + Environment.NewLine
                         + Environment.NewLine;
            return retVal;
        }

        private string AddPowerShellFooter()
        {
            // Wait some seconds and dispose all components

            var retVal = Environment.NewLine + Environment.NewLine
                         + @"# --------- [ real test ends here ] ---------" + Environment.NewLine
                         + @"Start-Sleep -m 3000" + Environment.NewLine
                         + @"$uia.Dispose()" + Environment.NewLine
                         + @"$app.Dispose()";

            return retVal;
        }
    }
}
