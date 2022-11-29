using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace WorkerNamespace
{
    public class Worker
    {
        private string firstName;
        public string lastName;
        private int age;
        public string position;

        public Worker(string firstName, string lastName, int age, string position)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.position = position;
        }

        public Worker()
        {
        }

        public void ShowWorkerName()
        {            
            Console.WriteLine($"Name: {firstName} {lastName}");            
        }

        public void ShowWorkerAge()
        {
            Console.WriteLine($"Age: {age}");
        }

        public void ShowWorkerPosition()
        {
            Console.WriteLine($"Position: {position}");
        }

        public void ShowWorkerInfo()
        {
            Console.WriteLine("====Employee====");
            Console.WriteLine($"First Name: {firstName}");
            Console.WriteLine($"Last Name: {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Position: {position}");
        }
        
        public void ShowWorkerWork()
        {
            Console.WriteLine($"{position} works on {position}'s place!");
        }
    }
}
