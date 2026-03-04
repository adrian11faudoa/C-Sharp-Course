using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
namespace Course;
class Program
{
    static void Main(string[] args)
    {
        bool looping = true;
        while (looping)
        {
            try
            {
                Console.Write("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num);

                looping = false;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Please enter a number smaller than 2 billion");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please only enter numbers");
            }
            catch (Exception) // catch all exceptions
            {
                Console.WriteLine("Something has went wrong");
            }
        }

        Console.WriteLine("Goodbye!");

        Console.ReadLine();
    }

}
