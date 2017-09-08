using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlaUIRecorder.CodeProvider.Common
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class CodeProviderNameAttribute : Attribute
    {
        public CodeProviderNameAttribute(string name) => Name = name;

        /// <summary>
        /// Gets the name of the provider
        /// </summary>
        public string Name { get; private set; }
    }
}
