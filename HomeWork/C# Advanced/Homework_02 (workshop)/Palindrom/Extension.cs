using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced_Class4
{
    
    public static class Extensions
    {
        public static bool CheckStringForPalindrom (string value)
        {

            bool IsPalindrom = true;
            //to remove characters that are not letter or number
            for (int i = 0; i < value.Length; i++)
            {
                bool IsletterOrNumber = Char.IsDigit(value[i]) || Char.IsLetter(value[i]);

                if ((!IsletterOrNumber) || (value[i] == ' '))
                {
                    // to erase char and to move the counter back
                    value = value.Remove(i, 1);
                    i--;
                }
            }

            // to check if string is palindrom
            for (int i = 0; i < value.Length / 2; i++)
            {
                if (value[i] != value[(value.Length - 1) - i])
                {
                    IsPalindrom = false;
                }
            }
            return IsPalindrom;
        }
        
        public static bool IsPalindrom (this string value)
        {
            value = value.ToLower();

            bool IsPalindrom = CheckStringForPalindrom(value);
            return IsPalindrom;
        }


        public static bool IsPalindrom(this double value)
        {
            
            string stringValue = value.ToString();
            stringValue = stringValue.ToLower();

            bool IsPalindrom = CheckStringForPalindrom(stringValue);
            return IsPalindrom;
        }

        public static bool IsPalindrom(this int value)
        {
            string stringValue = value.ToString();
            stringValue = stringValue.ToLower();

            bool IsPalindrom = CheckStringForPalindrom(stringValue);
            return IsPalindrom;
        }

        public static bool IsPalindrom(this long value)
        {
            string stringValue = value.ToString();
            stringValue = stringValue.ToLower();

            bool IsPalindrom = CheckStringForPalindrom(stringValue);
            return IsPalindrom;
        }
    }
}
