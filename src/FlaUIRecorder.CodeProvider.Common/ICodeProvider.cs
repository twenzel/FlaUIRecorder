using FlaUI.Core.AutomationElements.Infrastructure;
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
        /// Adds a new comment to the code
        /// </summary>
        /// <param name=""></param>
        void AddComment(string comment);

        /// <summary>
        /// Will be called when the a left mouse click occured
        /// </summary>
        /// <param name="element"></param>
        void Click(AutomationElement element);

        /// <summary>
        /// Will be called when the a right mouse click occured
        /// </summary>
        /// <param name="element"></param>
        void RightClick(AutomationElement element);

        /// <summary>
        /// Generate the final code
        /// </summary>
        /// <returns></returns>
        string Generate();
    }
}
