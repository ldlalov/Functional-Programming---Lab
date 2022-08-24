using System;
using System.Linq;

namespace _05._Filter_By_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Person[] people = new Person[count];
            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split(", ");
                Person newPerson = new Person(input[0], int.Parse(input[1]));
                people[i] = newPerson;
            }
            string filther = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string view = Console.ReadLine();
            Func<Person, bool> Selected = SelectedPersons(filther, age);
            Action<Person> Print = WriteResult(view);
            foreach (var person in people)
            {
                if (Selected(person))
                {
                    Print(person);  
                }
            }
        }
        static Action<Person> WriteResult(string view)
            {
            switch (view)
            {
                case "name": return person => Console.WriteLine(person.Name);
                case "age": return person => Console.WriteLine(person.Age);
                case "name age": return person => Console.WriteLine($"{person.Name} - {person.Age}");
                default:return null;
            }
        }
            static Func<Person,bool> SelectedPersons(string filther,int age)
            {
            switch (filther)
            {
                case "younger": return person => person.Age < age;
                case "older": return person => person.Age >= age;
                default: return null;
            }
        }
    }
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
