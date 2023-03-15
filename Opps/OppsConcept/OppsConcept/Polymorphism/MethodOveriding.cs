using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Polymorphism
{
    public class LoadParent
    {
        public virtual void Test() //Overridable
        {
            Console.WriteLine("Parent's Test Method is Called");
        }
    }
    public class LoadChild : LoadParent
    {
      //Overriding parent's Test method in child class
        public override void Test()
        {
            Console.WriteLine("Child's Test Method is called");
        }
    }
}
