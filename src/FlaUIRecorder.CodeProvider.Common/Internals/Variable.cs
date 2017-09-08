using FlaUI.Core.AutomationElements.Infrastructure;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlaUIRecorder.CodeProvider.Common.Internals
{
    /// <summary>
    /// Represents a variable name and its ui element
    /// </summary>
    [DebuggerDisplay("{Name} - {Element}")]
    public class Variable
    {
        /// <summary>
        /// The name of the variable
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The according ui element
        /// </summary>
        public AutomationElement Element { get; set; }
    }
}
