using System;
using System.Collections.Generic;
using System.Text;

namespace TestingSample
{
    public class Validator
    {
        ///<summary>
        ///Checks that a file name ends with .txt
        /// </summary>
        /// <param name="validExt">The file name to check</param>
        /// <returns></returns>
        public static bool IsTextFile(string validExt)
        {
            const string ValidExtension = ".txt";
            //Convert to Lowercase to avoid
            //case sensitive comparisons
            return validExt.ToLower().EndsWith(ValidExtension);

        //    if (validExt.ToLower().EndsWith(".txt"))
        //    {
        //        return true;
        //    }
        //    return false;
        }
    }
}
