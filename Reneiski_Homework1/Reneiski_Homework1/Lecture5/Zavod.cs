using WorkerNamespace;

namespace Reneiski_Homework1.Lecture5
{
    public class Zavod
    {
        private Worker[] workers = new Worker[4];
        private Worker? Engineer;
        
        private string Name;
        private string Description;

        public Zavod(Worker? engineer, string name, string description)
        {
            Engineer = engineer;
            Name = name;
            Description = description;
        }

        public void SetEngineer(Worker worker)
        {
            Engineer = worker;
        }

        public void SetWorker(Worker workerToAdd)
        {
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i] == null)
                {
                    workers[i] = workerToAdd;
                    break;
                }
            }            
        }

        public void ShowAllEmployeeInfo()
        {
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i] != null)
                {
                    workers[i].ShowWorkerInfo();
                }
            }            
        }

        public void ShowEmployeeNameInfo()
        {
            Console.WriteLine("Type Last Name");
            string lastname = Console.ReadLine();
            
            for (int i = 0; i < workers.Length; i++)
            {                    
                if (lastname == workers[i].ShowPersonLastName())
                {
                    workers[i].ShowWorkerName();
                    break;
                }
            }
        }

        public void ShowEmployeeAgeInfo()
        {
            Console.WriteLine("Type Last Name");
            string lastname = Console.ReadLine();

            for (int i = 0; i < workers.Length; i++)
            {
                if (lastname == workers[i].ShowPersonLastName())
                {
                    workers[i].ShowWorkerAge();
                    break;
                }
            }
        }

        public void ShowEmployeePositionInfo()
        {
            Console.WriteLine("Type Last Name");
            string lastname = Console.ReadLine();

            for (int i = 0; i < workers.Length; i++)
            {
                if (lastname == workers[i].ShowPersonLastName())
                {
                    workers[i].ShowWorkerPosition();
                    break;
                }
            }
        }

        public void ShowEmployeeNumber()
        {
            int numberOfEmployees = 0;

            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i] == null)
                {
                    break;
                }
                
                numberOfEmployees = i+1;                
            }

            Console.WriteLine($"Number of employee: {numberOfEmployees}");
        }

        public void ShowEmployeeByPosition()
        {
            Console.WriteLine("Type Position");
            string lastname = Console.ReadLine();

            for (int i = 0; i < workers.Length; i++)
            {
                if (lastname == workers[i]?.PositionInfo())
                {
                    workers[i]?.ShowWorkerInfo();
                }                
            }
        }

        public void ShowEmployeeWork()
        {
            Console.WriteLine("Type Last Name");
            string lastname = Console.ReadLine();
            
            for (int i = 0; i < workers.Length; i++)
            {
                if (lastname == workers[i].ShowPersonLastName())
                {
                    workers[i].ShowWorkerWork();
                    break;
                }
            }
        }
    }
}
