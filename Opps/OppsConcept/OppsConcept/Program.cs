using OppsConcept.Encapsulation;
using System;
namespace OppsConcept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Opps Concept");
            Console.WriteLine("Enter the Options: ");
            int options = Convert.ToInt32(Console.ReadLine());
            switch(options)
            {
                case 1:
                    Person person = new Person();
                    Console.WriteLine("Enter the Name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter the Age: ");
                    int age = Convert.ToInt32(Console.ReadLine());
                    person.setName(name);
                    person.getName(name);
                    person.setAge(age);
                    person.getAge(age);
                    break;
            }
        }
    }
}
