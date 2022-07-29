using System;
using System.IO;

namespace fileio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // write to file use the StreamWriter object
            //StreamWriter writer = new StreamWriter("file.txt", true);

            string thisstring = "hello this";
            int iteration=0;

            StreamReader reader = new StreamReader("file.txt");

            string str="";
            while (!reader.EndOfStream)
            {
                str += reader.ReadLine();
                Console.WriteLine($"{iteration++}  {str}");
            }
            reader.Close();



            // // loop it
            // int iteration=1;
            // foreach (var letter in thisstring)
            // {
            //     writer.WriteLine($"{iteration}  {thisstring}");    
            // }
            // writer.Close();




            // //loop it
            // for (int i = 0; i < thisstring.Length; i++)
            // {
            //     //writer.Write(thisstring);
            //     writer.WriteLine(thisstring);
            // }
            // writer.Close();


            // writer.WriteLine(thisstring);
            // writer.Close();

        }
    }
}
