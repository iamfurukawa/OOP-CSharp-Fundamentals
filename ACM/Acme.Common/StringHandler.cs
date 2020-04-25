using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Common
{
    public static class StringHandler
    {
        /// <summary>
        /// Insers spaces before each capital letter in a string.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string InsertSpaces(this string source)
        {
            if (string.IsNullOrWhiteSpace(source)) return string.Empty;

            string output = string.Empty;
            foreach(char letter in source)
            {
                if (char.IsUpper(letter))
                {
                    output = output.Trim() + " ";
                }
                output += letter;
            }

            return output.Trim();
        }
    }
}
