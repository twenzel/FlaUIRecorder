using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlaUIRecorder.Internal.Worker
{
    interface IRecordWorker : IDisposable
    {
        /// <summary>
        /// Will be called when the recorder gets started/resumed
        /// </summary>
        void Start();

        /// <summary>
        /// Will be called when the recorder gets paused
        /// </summary>
        void Pause();
    }
}
