using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace WorkerNamespace
{
    public class Worker
    {
        private string firstName = "";
        private string lastName = "";
        private string age = "";
        private string position = "";

        private bool vacationDirector = true;

        public string[,] workers = new string[4, 4]
        {
            { "55", "Ivan", "Ivanov", "Director" },
            { "45", "Maria", "Petrova", "Accountant" },
            { "63", "Petr", "Sidorov", "Mechanic" },
            { "0", "0", "0", "Accountant" }
        };

        public void GetWorker()
        {
            for (int i = 0; i < workers.GetLength(0); i++)
            {
                Console.WriteLine(" ");

                for (int j = 0; j < workers.GetLength(1) && workers[i, j] != "0"; j++)
                {
                    Console.WriteLine(workers[i, j]);
                }
            }
        }

        public void NewEmployee()
        {
            Console.WriteLine("Type Employee's: Age");
            workers[3, 0] = Console.ReadLine();
            Console.WriteLine("Type Employee's: First Name");
            workers[3, 1] = Console.ReadLine();
            Console.WriteLine("Type Employee's: Last Name");
            workers[3, 2] = Console.ReadLine();
            Console.WriteLine("Type Employee's: Position");
            workers[3, 3] = Console.ReadLine();
        }

        public void NumberOfWorkers()
        {
            if (workers[3, 0] != "0")
            {
                Console.WriteLine($"Number of workers is {workers.GetLength(0)}");
            }
            else Console.WriteLine($"Number of workers is {workers.GetLength(0) - 1}");
        }

        public void workOfMechanic()
        {
            Console.WriteLine("Is Director on vacation? - true or false");
            vacationDirector = bool.Parse(Console.ReadLine());

            if (vacationDirector == true)
            {
                Console.WriteLine($"Mechanic is drunken");
            }
            else Console.WriteLine($"Mechanic is working hard");
        }

        public void WorkerByPosition()
        {
            string position = Console.ReadLine();
            
            for (int i = 0; i < workers.GetLength(0); i++)
            {
                Console.WriteLine(" ");
                
                for (int j = 0; j < workers.GetLength(1) && workers[i, 3] == position; j++)
                {
                    Console.WriteLine(workers[i, j]);
                }
            }
        }
    }
}
