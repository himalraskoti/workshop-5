using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class Printer
    {
        // Method 1: Print a string message
        public void Print(string message)
        {
            Console.WriteLine("Message: " + message);
        }

        // Method 2: Print an integer number
        public void Print(int number)
        {
            Console.WriteLine("Number: " + number);
        }

        // Method 3: Print a message multiple times
        public void Print(string message, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{i + 1}. {message}");
            }
        }
    }

}
