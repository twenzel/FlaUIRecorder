using FlaUI.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlaUIRecorder.CodeProvider.Common
{
    public class CodeProviderArguments
    {
        /// <summary>
        /// Automation root of the target application
        /// </summary>
        public AutomationBase Automation { get; set; }

        /// <summary>
        /// Instance of the target process
        /// </summary>
        public Process TargetProcess { get; set; }
    }
}
