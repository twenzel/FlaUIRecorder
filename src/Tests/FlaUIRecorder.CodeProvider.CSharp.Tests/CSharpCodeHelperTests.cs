using FlaUI.Core.AutomationElements;
using FlaUI.Core.AutomationElements.Infrastructure;
using FlaUI.Core.Definitions;
using FlaUIRecorder.Tests.Common;
using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlaUIRecorder.CodeProvider.CSharp.Tests
{
    [TestFixture]
    public class CSharpCodeHelperTests
    {
        [Test]
        public void Generates_Valid_VariableNames()
        {
            var name = CSharpCodeHelper.GetVariableName(CreateElement("search", ControlType.MenuItem));
            name.Should().Be("searchMenuItem");

            name = CSharpCodeHelper.GetVariableName(CreateElement("? .-(_search+*'´`;:<>|@#!\"§$%&/()={[]}\\", ControlType.MenuItem));
            name.Should().Be("_searchMenuItem");
        }

        private AutomationElement CreateElement(string name, ControlType controlType)
        {
            return new TextBox(new TestBasicAutomationElement(new TestAutomation(), new TestAutomationElement { Name = name, ControlType = controlType}));
        }
    }
}
