using Reneiski_Homework1.Lecture5;
using WorkerNamespace;

namespace Reneiski_Homework1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Zavod Belaz = new Zavod(new Worker(), "Belaz", "The best of the best!");
            Belaz.Engineer = new Worker();
            
            Belaz.Engineer.NewEmployee();
            Belaz.Engineer.GetWorker();
            Belaz.Engineer.workOfMechanic();

            Zavod MAZ = new Zavod(new Worker(), 120, "Remontniy Ceh");
            MAZ.Building = new Worker();

            MAZ.Building.NumberOfWorkers();
            MAZ.Building.WorkerByPosition();
        }
    }
}
