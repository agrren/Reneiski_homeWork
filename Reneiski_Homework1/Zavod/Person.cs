using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerNamespace
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public virtual void ShowPersonInfo()
        {
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(age);
        }

        public virtual ref string ShowPersonLastName()
        {
            return ref lastName;
        }

        public virtual ref string ShowPersonFirstName()
        {
            return ref firstName;
        }

        public virtual ref int ShowPersonAge()
        {
            return ref age;
        }
    }
}
