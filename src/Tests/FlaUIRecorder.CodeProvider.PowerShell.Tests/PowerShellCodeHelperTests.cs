using FlaUIRecorder.Tests.Common;
using FluentAssertions;
using NUnit.Framework;

namespace FlaUIRecorder.CodeProvider.PowerShell.Tests
{
    [TestFixture]
    public class PowerShellCodeHelperTests
    {
        [Test]
        public void Generates_Valid_VariableNames()
        {
            var name = new ElementBuilder().CreateMenuItem().WithName("search").Build().GetVariableName();
            name.Should().Be("searchMenuItem");

            name = new ElementBuilder().CreateMenuItem().WithName("? .-(_search+*'´`;:<>|@#!\"§$%&/()={[]}\\").Build().GetVariableName();
            name.Should().Be("_searchMenuItem");
        }
    }
}
