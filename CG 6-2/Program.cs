using System;

namespace CG_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Create a program that converts a normal sentence input by the user into 
            all upper case and prints the value to the console.
            */

            string mySentence = "I am a kickass coder girl ";
            
            mySentence = mySentence.ToUpper();
            Console.WriteLine(mySentence);
            Console.ReadLine();

            
            
        }
         
    }
}
