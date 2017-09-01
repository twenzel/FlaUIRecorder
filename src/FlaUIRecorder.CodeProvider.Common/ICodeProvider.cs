using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlaUIRecorder.CodeProvider.Common
{
    public interface ICodeProvider
    {
        /// <summary>
        /// Gets the name of the Code provider
        /// </summary>
        string Name { get; }
    }
}
