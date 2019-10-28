using System;
using System.Text.RegularExpressions;

namespace BusinessLogic
{
    public static class Validator
    {
        /// <summary>
        /// Determines if string is a valid Social Security number
        /// </summary>
        /// <param name="ssn"></param>
        /// <returns></returns>
        public static bool IsSsn(string ssn)
        {
            // use regular expression to strip out non-numerics except dash
            ssn = KeepOnlyDashesAndNumbers(ssn);

            if (ssn.Length == 11) // expecting 9 numbers and 2 dashes
            {
                if (ssn.Substring(3,1) == "-" && ssn.Substring(6,1) == "-")
                {   // dashes must be in the right places

                    // Regex again to strip dashes
                    ssn = KeepOnlyNumbers(ssn);
                    if (ssn.Length == 9)
                    {   // now we're sure it's 9 numbers in the correct format
                        return true;
                    }
                    return false;
                }
                return false; // dashes in the wrong place
            }
            if (ssn.Length == 9) // expecting numbers only
            {
                ssn = KeepOnlyNumbers(ssn);
                return true;
            }
            return false;
        }

        private static string KeepOnlyNumbers (string str)
        {
            str = Regex.Replace(str, @"[^0-9]", "");
            return str;
        }

        private static string KeepOnlyDashesAndNumbers(string str)
        {
            str = Regex.Replace(str, @"[^-0-9]", "");
            return str;
        }

        /// <summary>
        /// Checks if a number is within range
        /// </summary>
        /// <param name="numToTest">The number to test</param>
        /// <param name="minValue">The minimum INCLUSIVE range</param>
        /// <param name="maxValue">The maximum INCLUSIVE range</param>
        /// <returns></returns>
        public static bool IsWithinRange(int numToTest, int minValue, int maxValue)
        {
            throw new NotImplementedException();
        }
    }
}
