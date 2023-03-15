using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Polymorphism
{
    public class MethodOverLoading
    {
        public void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public void Add(double x, double y)
        {
            Console.WriteLine(x + y);
        }
        public void Add(string x, string y)
        {
            Console.WriteLine(x + y);
        }
       
    }
}
