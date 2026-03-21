using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
namespace Course;
class Program
{
    class Person
    {
        //Auto-implemented properties: when no additional logic is needed in the getter and setter
        //public string Name { get; set; }
        //public int Age { get; set; }


        private string name;
        private int age;

        //Properties 
        public string Name
        {
            /*
            get 
            {
                return name;
            }
            set
            {
                name = value;
            }
             */
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


        /*public void SetName(string name) => this.name = !string.IsNullOrEmpty(name) ? name : "Invalid name";
        public string GetName() => name;
        public void SetAge(int age) => this.age = age >= 0 && age <= 150 ? age : -1;
        public int GetAge() => age;*/
        public string ReturnDetails()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }
    static void Main(string[] args)
    {
        Person person = new Person("Alice", 30);
        Console.WriteLine(person.ReturnDetails());

        Console.WriteLine($"Your name is {person.Name}, and your age is {person.Age}");


        Console.ReadLine();
    }

}
