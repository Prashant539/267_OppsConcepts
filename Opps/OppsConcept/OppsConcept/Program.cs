using OppsConcept.Abstraction;
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
            Console.WriteLine("1:Encapsulation\n2:Abstraction");
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
                case 2:
                    AbsChild p = new AbsChild();
                    p.Add(10, 20);
                    p.Sub(20, 10);
                    p.Mul(10, 10);
                    p.Div(20, 10);
                    break;
            }
        }
    }
}
