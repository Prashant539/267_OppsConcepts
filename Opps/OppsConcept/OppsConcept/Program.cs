using OppsConcept.Abstraction;
using OppsConcept.Encapsulation;
using OppsConcept.ObjectAndClass;
using OppsConcept.Polymorphism;
using System;
namespace OppsConcept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Opps Concept");
            Console.WriteLine("Enter the Options: ");
            Console.WriteLine("1:Encapsulation\n2:Abstraction\n3:Inheritance\n4:Polymorphism\n5:ObjectAndClass");
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
                case 3:
                    Child child = new Child();
                    child.Add(10, 20);
                    child.Sub(20, 10);
                    break;
                case 4:
                    MethodOverLoading methodOverLoading = new MethodOverLoading();
                    methodOverLoading.Add(10, 20);
                    methodOverLoading.Add(20.22, 23.34);
                    methodOverLoading.Add("Prash", "ant");
                    LoadChild loadChild = new LoadChild();
                   // loadChild.Show();
                    loadChild.Test();
                    break;
                case 5:
                    Student student = new Student(); //creating an object of Student  
                    student.id = 101;
                    student.name = "Prashant";
                    Console.WriteLine(student.id);
                    Console.WriteLine(student.name);
                    break;


                    
                
            }
        }
    }
}
