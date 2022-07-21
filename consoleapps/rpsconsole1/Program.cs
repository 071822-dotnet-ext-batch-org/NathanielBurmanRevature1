using System;

namespace rpsconsole1
{
    class Program
    {
        
        public static string msg(string s)
        {
            string sMsg = "hello world";
            return sMsg;
        }

        public static string msg(int i)
        {
            string sMsg;
            sMsg = "11011100";
            sMsg = "10010011";
            return sMsg;
        }
        
        static void Main(string[] args)
        {
            // write a string
            System.Console.WriteLine("Hello World!");

            // write the result of a method
            Console.WriteLine(msg('s'));

            // write the result of a method
            Console.WriteLine(msg(1));

            // a different set of parameters
            // write an integer
            Console.WriteLine(43);

            int test;
            int test2;
            test = 11111111;
            test = 11110233123000000;

        }

        
    }
}
