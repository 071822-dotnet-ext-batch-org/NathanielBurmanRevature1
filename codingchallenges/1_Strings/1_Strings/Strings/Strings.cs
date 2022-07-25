using System;

namespace StringManipulationChallenge
{
    public class Program
    {
        static void Main(string[] args)
        {
            //flags
            bool bUpper = false;
            bool bLower = false;
            bool bConcat= false;
            bool bSub   = true;
            bool bTrim  = false;
            bool bSearchChar = false;

            /*
            *
            * implement the required code here and within the methods below.
            *
            */
            //when you call a method, you call it with arguments. The args values are held in a variable.
            
            Console.WriteLine("Input a string:");
            string sString = Console.ReadLine(); // read line

            if(bUpper)
            {
            string sUpper  = StringToUpper(sString); // pass var to method
            Console.WriteLine($"upper: {sUpper}");
            }

            if(bLower)
            {
            //sString = Console.ReadLine(); // read line
            string sLower  = StringToLower(sString); // pass var to method
            Console.WriteLine($"lower: {sLower}");
            }

            if(bTrim)
            {
            //Console.WriteLine("Input a string with spaces:");
            //sString = Console.ReadLine(); // read line
            string sTrim  = StringTrim(sString); // pass var to method
            Console.WriteLine($"trim: {sTrim}");
            }

            if(bSub)
            {
            // substring
            Console.WriteLine("SubString: Input a string: ");
            sString     = Console.ReadLine(); // read line

            Console.WriteLine("Char number (input a int):");
            string sParse = Console.ReadLine();
            int iIndex  = Int32.Parse(sParse); // read line
            Console.WriteLine(iIndex);
            int iLength = sString.Length;
            iLength = iLength - iIndex;
            Console.WriteLine(iLength);
            string sValue      = StringSubstring(sString, iIndex, iLength);
            Console.WriteLine($"StringSubstring: {sValue}");
            }

            if(bSearchChar)
            {
            // SearchChar
            Console.WriteLine("Search Char: Input a string: ");
            sString     = Console.ReadLine(); // read line
            Console.WriteLine("Char you want to know index of:");
            char cChar = Console.ReadLine()[0]; // read line
            //char cChar = sChar[0];
            int iValue      = SearchChar(sString, cChar);
            Console.WriteLine($"SearchChar: {iValue}");
            }

            if(bConcat)
            {
            // concatenate
            Console.WriteLine("first name:");
            string sFName = Console.ReadLine(); // read line
            Console.WriteLine("last name:");
            string sLName = Console.ReadLine(); // read line
            string sValue = ConcatNames(sFName, sLName);
            Console.WriteLine($"Concat: {sValue}");
            }
        }

        /// <summary>
        /// This method has one string parameter and will: 
        /// 1) change the string to all upper case and 
        /// 2) return the new string.
        /// </summary>
        /// <param name="usersString"></param>
        /// <returns></returns>
        public static string StringToUpper(string usersString)// the method itself has 'parameters'
        {
            // throw new NotImplementedException("StringToUpper method not implemented.");
            return usersString.ToUpper();
        }

        /// <summary>
        /// This method has one string parameter and will:
        /// 1) change the string to all lower case,
        /// 2) return the new string into the 'lowerCaseString' variable
        /// </summary>
        /// <param name="usersString"></param>
        /// <returns></returns>       
        public static string StringToLower(string usersString)
        {
            //throw new NotImplementedException("StringToLower method not implemented.");
            return usersString.ToLower();
        }

        /// <summary>
        /// This method has one string parameter and will:
        /// 1) trim the whitespace from before and after the string, and
        /// 2) return the new string.
        /// HINT: When getting input from the user (you are the user), try inputting "   a string with whitespace   " to see how the whitespace is trimmed.
        /// </summary>
        /// <param name="usersStringWithWhiteSpace"></param>
        /// <returns></returns>
        public static string StringTrim(string usersStringWithWhiteSpace)
        {
            return usersStringWithWhiteSpace.Trim();
            //throw new NotImplementedException("StringTrim method not implemented.");
        }

        /// <summary>
        /// This method has three parameters, one string and two integers. It will:
        /// 1) get the substring based on the first integer element and the length 
        /// of the substring desired.
        /// 2) return the substring.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="firstElement"></param>
        /// <param name="lastElement"></param>
        /// <returns></returns>
        public static string StringSubstring(string x, int firstElement, int lengthOfSubsring)
        {
            //throw new NotImplementedException("StringSubstring method not implemented.");
            string sValue = x.Substring(firstElement,lengthOfSubsring);
            return sValue;
        }

        /// <summary>
        /// This method has two parameters, one string and one char. It will:
        /// 1) search the string parameter for first occurrance of the char parameter and
        /// 2) return the index of the char.
        /// HINT: Think about how StringTrim() (above) would be useful in this situation
        /// when getting the char from the user. 
        /// </summary>
        /// <param name="userInputString"></param>
        /// <param name="charUserWants"></param>
        /// <returns></returns>
        public static int SearchChar(string userInputString, char charUserWants)
        {
            //throw new NotImplementedException("SearchChar method not implemented.");
            //throw new NotImplementedException("StringSubstring method not implemented.");
            int iValue = userInputString.IndexOf(charUserWants);;
            return iValue;
        }

        /// <summary>
        /// This method has two string parameters. It will:
        /// 1) concatenate the two strings with a space between them.
        /// 2) return the new string.
        /// HINT: You will need to get the users first and last name in the 
        /// main method and send them as arguments.
        /// </summary>
        /// <param name="fName"></param>
        /// <param name="lName"></param>
        /// <returns></returns>
        public static string ConcatNames(string fName, string lName)
        {
            //throw new NotImplementedException("ConcatNames method not implemented.");
            //string sValue = ($"{fName} {lName}");
            string sValue = (fName + " " + lName);
            return sValue;
        }
    }//end of program
}
