using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            //Writes line explaining program
            Console.WriteLine("This program will reverse what you wish to enter, type something below");
            //Stores input to string
            String userInput = Console.ReadLine();
            //Convert string into array
            char[] chaArray = userInput.ToCharArray();
            //Reverse Array Contents
            Array.Reverse(chaArray);
            //Writes each character to line in a for loop
            foreach (char userInputChar in chaArray)
            {
                Console.Write(userInputChar);
            }
            //Shows text and keeps console open
          //  Console.ReadLine();
        }
    
    }
}
