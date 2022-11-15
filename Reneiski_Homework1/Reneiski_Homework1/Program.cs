using Reneiski_Homework1.Lecture4;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Zavod;

class Program
{
    static void Main(string[] args)
    {

        Worker work = new Worker();

        //work.GetWorker();
        //work.NumberOfWorkers();
        //work.DirectorWork();
        //work.NewEmployee();
        //work.GetWorker();
        //work.NumberOfWorkers();
        //work.workOfMechanic();
        work.WorkerByPosition();
    } 
}