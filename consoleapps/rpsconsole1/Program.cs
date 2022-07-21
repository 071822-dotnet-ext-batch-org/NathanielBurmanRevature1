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

            int a,b,c,x,y;
            a = 700;
            b = a;
            c = b++;
            //b = a + b * c;


            c = a >= 100 ? b : c / 10; // this is a ternerary operator
            Console.WriteLine($"c => {c}");
            if(a>= 100){ // this is the same as above
                c = b;
            }
            else{
                c = c / 10;
            }
            Console.WriteLine($"c => {c}");


            x = 5;
            y = 6;
            //z = 7;

            if( y > x ){
                Console.WriteLine("y is greater than x");
            }
            else if(y == x){
                Console.WriteLine("x is equal to y");
            }
            else{
                Console.WriteLine("x is greater than y");
            }

            string s = "string literal";
            char l = s[s.Length - 1];
            Console.WriteLine($"s => {l}");
        }

        static void tryCatch(){
            int c = 10;
            char[] myCharArr = new char[]{'f','2','d'};
            try
            {
                Console.WriteLine($"s => {myCharArr[3]}"); // this will cause exception
                Console.WriteLine($"c => {++c}"); // this will not output
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine($"The out of range exception occured. {ex.Message}");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"The out of range exception occured. {ex.Message}");
            }
            Console.WriteLine($"c => {c}"); // this will output
        }

        static void doLoops(){
            string s = "string literal";
            char l = s[s.Length - 1];

            // iterate over each index
            for(int i=0; i<s.Length; i++){
                //Console.WriteLine($"c => {s[i]}");
                Console.Write($"{s[i]}");
            }
            Console.WriteLine();

            foreach(char thisChar in s){
                Console.Write($".{thisChar}");
            }
            Console.WriteLine();

            int wloop = 0;
            while(wloop<10){
                Console.WriteLine($"hello");
                wloop++;
            }
            Console.WriteLine();

            do
            {
                Console.WriteLine($"hello");
                wloop--;
            } while(wloop>0);


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
            tryCatch();
            doLoops();
        }

        
    }
}
