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
        
        public static void play(){
            int myint = 1+3;
            Console.WriteLine(Math.Pow(100,2));
            Console.WriteLine(100*2);
            Console.WriteLine($"the mod is      => {100%6}");
            Console.WriteLine($"the division is => {101/10}");

            Console.WriteLine($"myint++ => {myint++}"); // hit var then inc
            Console.WriteLine($"myint   => {myint}"); // prints the increased var
            Console.WriteLine($"myint++ => {++myint}"); // inc var then print
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

            play();

        }

        
    }
}
