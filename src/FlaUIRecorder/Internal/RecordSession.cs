using FlaUI.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlaUIRecorder.Internal
{
    [Serializable]
    [DebuggerDisplay("{Code}")]
    public class RecordSession
    {
        /// <summary>
        /// Start time of the record session
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Generated code
        /// </summary>
        public string Code { get; set; }

        public override string ToString()
        {
            return StartTime.ToString();
        }

        public override int GetHashCode()
        {
            return StartTime.GetHashCode();
        }
    }
}
