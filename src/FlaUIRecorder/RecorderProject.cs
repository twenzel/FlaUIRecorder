using FlaUI.Core;
using FlaUIRecorder.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlaUIRecorder
{
    [Serializable]
    public class RecorderProject
    {
        /// <summary>
        /// Automation type (UIA 2 or 3)
        /// </summary>
        public AutomationType AutomationType { get; set; }

        /// <summary>
        /// The executable of the target application
        /// </summary>
        public string Executable { get; set; }

        /// <summary>
        /// The arguments of the target application
        /// </summary>
        public string Arguments { get; set; }

        /// <summary>
        /// The name of the process used
        /// </summary>
        public string ProcessName { get; set; }

        /// <summary>
        /// The recorded sessions
        /// </summary>
        public List<RecordSession> Sessions { get; set; } = new List<RecordSession>();

        /// <summary>
        /// Used codeprovider
        /// </summary>
        public string CodeProvider { get; set; }

        internal bool IsDirty { get; set; }

        internal string FileName { get; set; } 
    }
}
