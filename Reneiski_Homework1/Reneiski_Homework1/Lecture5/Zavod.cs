using WorkerNamespace;
using Reneiski_Homework1;

namespace Reneiski_Homework1.Lecture5
{
    public class Zavod
    {
        private Worker[] workers = new Worker[4];
        private Worker? Engineer;
        
        public string Name;
        public string Description;

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

        public void GetWorkerInfo()
        {
            Console.WriteLine();
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
            string ln = Console.ReadLine();
            
            for (int i = 0; i < workers.Length; i++)
            {                    
                if (ln == workers[i].lastName)
                {
                    workers[i].ShowWorkerName();
                    break;
                }
            }
        }

        public void ShowEmployeeAgeInfo()
        {
            Console.WriteLine("Type Last Name");
            string ln = Console.ReadLine();

            for (int i = 0; i < workers.Length; i++)
            {
                if (ln == workers[i].lastName)
                {
                    workers[i].ShowWorkerAge();
                    break;
                }
            }
        }

        public void ShowEmployeePositionInfo()
        {
            Console.WriteLine("Type Last Name");
            string ln = Console.ReadLine();

            for (int i = 0; i < workers.Length; i++)
            {
                if (ln == workers[i].lastName)
                {
                    workers[i].ShowWorkerPosition();
                    break;
                }
            }
        }
    }
}
