using System;

namespace exercise_01_start
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print a piece of text on a single new line...
            Console.WriteLine("Hello CSSE1!");
            // Aggregate 2 string through the Format function.
            String outputText = String.Format("{0}{1}","This is your first exercise of... ","CSSE1!");
            // Print out the string with the total value.
            Console.WriteLine(outputText);
            // Print out a string without taking a new line.
            Console.Write("Press a key to exit this console application!");
            // Do a read operation so the console application will keep waiting.
            Console.ReadLine();
            // The end of the console application...
        }
    }
}
