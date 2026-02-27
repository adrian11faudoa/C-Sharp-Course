using System;
using System.Collections.Generic;
namespace Course;
class Program
{
    //static string name = "Aba"; Global variable

    static void Main(string[] args)
    {
        Console.Title = $"{ReturnName()} - {ReturnAge()}";
        PrintIntro();


        Console.ReadLine();

    }

    static string ReturnName()
    {
        return "Aba";
    }
    static int ReturnAge()
    {
        return 23;
    }

    static void PrintIntro()
    {
        string name = ReturnName();
        int age = ReturnAge(); 
        string output = $"Hello my name is {name} and my age is {age}";
        Console.WriteLine(output);
        //Console.WriteLine($"Hello my name is {ReturnName()} and my age is {ReturnAge()}");
    }

}
