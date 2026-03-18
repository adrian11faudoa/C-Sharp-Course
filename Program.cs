using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
namespace Course;
class Program
{
    class Person
    {
        private string name;
        private int age;
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void SetName(string name) => this.name = !string.IsNullOrEmpty(name) ? name : "Invalid name";
        public string GetName() => name;
        public void SetAge(int age) => this.age = age >= 0 && age <= 150 ? age : -1;
        public int GetAge() => age;
        public string ReturnDetails()
        {
            return $"Name: {name}, Age: {age}";
        }
    }
    static void Main(string[] args)
    {
        Person person = new Person("Alice", 30);
        Console.WriteLine(person.ReturnDetails());

        person.SetName("Bob");
        Console.WriteLine($"Your name is {person.GetName()}, and your age is {person.GetAge()}");


        Console.ReadLine();
    }

}
