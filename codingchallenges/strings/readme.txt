main{
    console.WriteLine("please enter a string");
    string userInput1 = Console.ReadLine();
    string stringToUpperResult = StringToUpper(userInput1);
    Console.WriteLine(stringToUpperResult);

    console.WriteLine("please enter a string");
    string userInput2 = Console.ReadLine();
    string stringToLowerResult = StringToUpper(userInput2);
    Console.WriteLine(stringToLowerResult);
}

public static string StringToUpper(string userString){
    // throw new NoteImplementedException("StringToUpper not implemented");
    string r = userString.ToUpper();
    return r;
}

public static string StringToLower(string userString){
    string r = userString.ToLower();
    return r;
}



[Fact]
public void StringTrimmerReturnsString(){

}




        static void Main(string[] args)
        {
            /*
            *
            * implement the required code here and within the methods below.
            *
            */
            //when you call a method, you call it with arguments. The args values are held in a variable.
            Console.WriteLine("Input a string:");
            string sString = Console.ReadLine(); // read line
            string sUpper  = StringToUpper(sString); // pass var to method

            sString = Console.ReadLine(); // read line
            string sLower  = StringToLower(sString); // pass var to method

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