using FlaUI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlaUIRecorder.Internal
{
    [Serializable]
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
    }
}
