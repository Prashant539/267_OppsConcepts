using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Encapsulation
{
    public class Person
    {
        private string Name;
        private int Age;
        public void setName(string name)
        {
            if(name.Length>3)
            {
                this.Name = Name;
            }
            else
            {
                Console.WriteLine("Enter the Correct name");
            }
        }
        public string getName(string Name)
        {
            return Name;
        }
        public void setAge(int Age)
        {
            if(Age > 0)
            {
                this.Age = Age;
            }
            else
            {
                Console.WriteLine("Enter the coreect age");
            }
        }
        public int getAge(int age)
        {
            return Age;
        }
    }
}
