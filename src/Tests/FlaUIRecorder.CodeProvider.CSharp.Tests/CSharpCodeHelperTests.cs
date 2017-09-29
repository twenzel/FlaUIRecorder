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
            var name = CSharpCodeHelper.GetVariableName(new ElementBuilder().CreateMenuItem().WithName("search").Build());
            name.Should().Be("searchMenuItem");

            name = CSharpCodeHelper.GetVariableName(new ElementBuilder().CreateMenuItem().WithName("? .-(_search+*'´`;:<>|@#!\"§$%&/()={[]}\\").Build());
            name.Should().Be("_searchMenuItem");
        }


        [Test]
        public void AnyTest()
        {
            var element = new ElementBuilder().CreateTextBox().WithName("search").Build().AsTextBox();
            element.Text = "no";

            var t = element.Text;

        }
    }
}
