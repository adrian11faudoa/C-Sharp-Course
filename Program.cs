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

        public string Name
        {
            get => name;
            set => name = !string.IsNullOrEmpty(value) ? value : "Invalid name";
        }
        public int Age
        {
            get => age;
            set => age = value >= 0 && value <= 150 ? value : -1;
        }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        /*public string ReturnDetails()
        {
            return $"Name: {Name}, Age: {Age}";
        }*/
        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";

        }
        public override bool Equals(object obj)
        {
            if (obj is Person)
            {
                Person person = obj as Person;
                return Name.Equals(person.Name) && Age == person.Age;
            }
            return false;
        }
    }
    static void Main(string[] args)
    {
        Person person = new Person("Alice", 30);
        //Console.WriteLine(person.ReturnDetails());
        //Console.WriteLine(person.ToString());
        Console.WriteLine(person);

        Person test = new Person("Alice", 30);

        if (person.Equals(test))
        {
            Console.WriteLine("Same");
        }
        else
        {
            Console.WriteLine("Not Same");
        }

        Console.ReadLine();
    }

}
