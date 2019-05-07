using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced_Class4
{
    
    public static class Extensions
    {
        public static bool IsPalindrom <T>( this T value)
        {
            string forwards = value.ToString().ToLower();

            StringBuilder cleanString = new StringBuilder();
            foreach (var character in forwards)
            {
                if (Char.IsLetterOrDigit(character))
                    cleanString.Append(character);
            }
            forwards = cleanString.ToString();

            char[] chars = forwards.ToCharArray();
            Array.Reverse(chars);

            string backwards = new string(chars);
            return forwards == backwards;
        }
    }
}
