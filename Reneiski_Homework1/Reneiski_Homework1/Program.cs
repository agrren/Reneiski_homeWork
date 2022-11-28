using Reneiski_Homework1.Lecture5;
using WorkerNamespace;

namespace Reneiski_Homework1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Zavod Belaz = new Zavod(new Worker(), "Belaz", "The best of the best!");
            Worker sasha = new Worker("Alex", "Ren", 41, "QA");
            Worker ivan = new Worker("Ivan", "Ivanov", 54, "Director");
            Worker semen = new Worker("Semen", "Semenov", 51, "Mechanic");

            Belaz.SetWorker(sasha);
            Belaz.SetWorker(ivan);
            Belaz.SetWorker(semen);

            Belaz.ShowAllEmployeeInfo();
            Belaz.ShowEmployeeNameInfo();
            Belaz.ShowEmployeeAgeInfo();
            Belaz.ShowEmployeePositionInfo();
        }
    }
}
