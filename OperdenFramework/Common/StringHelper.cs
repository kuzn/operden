using System;
using System.Collections.Generic;
using System.IO;

namespace OperdenFramework.Common
{
    public static class StringHelper
    {
        /// <summary>
        /// Indicates whether the string is null or empty (equals to "").
        /// Extension method for string type.
        /// </summary>
        /// <returns></returns>
        public static bool IsNullOrEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }

        /// <summary>
        /// Split string into lines.
        /// </summary>
        public static IEnumerable<string> GetLines(this string str)
        {
            if (str == null)
            {
                yield break;
            }

            using (StringReader sr = new StringReader(str))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    yield return line;
                }
            }
            yield break;
        }
    }
}
