using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlaUIRecorder.Extensions
{
    public static class ExceptionsExtensions
    {
        /// <summary>
        /// Formats the stack trace.
        /// </summary>
        /// <param name="ex">The ex.</param>
        /// <param name="separator">The separator.</param>
        /// <returns>Formatted stack trace message.</returns>
        public static string FormatStackTrace(this Exception ex, string separator)
        {
            var ret = new StringBuilder();

            for (var e = ex; null != e; e = e.InnerException)
            {
                if (ret.Length > 0)
                    ret.Append(separator);

                if (string.IsNullOrEmpty(e.StackTrace))
                    continue;

                // Reverse the stack trace
                var parts = e.StackTrace.Split('\n');

                for (var i = 0; i < parts.Length; i++)
                    parts[i] = parts[i].Trim('\r');

                Array.Reverse(parts);

                ret.Append(string.Join(Environment.NewLine, parts));
            }

            return ret.ToString();
        }

        /// <summary>
        /// Extract all inner exception messages.
        /// </summary>
        /// <param name="ex">The ex.</param>
        /// <returns></returns>
        public static string FormatStackTrace(this Exception ex)
        {
            return FormatStackTrace(ex,
                                    Environment.NewLine + "---[ Start of Inner Exception ]---" +
                                    Environment.NewLine);
        }

        /// <summary>
        /// Extract all inner exception messages.
        /// </summary>
        /// <param name="ex">The ex.</param>
        /// <returns></returns>
        public static string ErrorString(this Exception ex)
        {
            return ErrorString(ex, Environment.NewLine);
        }

        /// <summary>
        /// Extract all inner exception messages.
        /// </summary>
        /// <param name="ex">The ex.</param>
        /// <param name="separator">The separator.</param>
        /// <returns>Inner exception message.</returns>
        public static string ErrorString(this Exception ex, string separator)
        {
            string ret = ex.Message;

            try
            {
                if (null != ex.InnerException)
                {
                    ret += separator;
                    ret += ErrorString(ex.InnerException, separator);
                }
            }
            catch
            {
                // Silent fail
            }

            return ret;
        }
    }
}
