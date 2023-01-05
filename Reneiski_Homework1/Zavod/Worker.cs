namespace WorkerNamespace
{
    public class Worker : Person
    {
        private string position;

        public Worker(string firstName, string lastName, int age, string position)
            : base(firstName, lastName, age)
        {
            this.position = position;
        }

        public Worker() : base()
        {
        }

        public override void ShowPersonInfo()
        {
            base.ShowPersonInfo();
        }

        public override string GetPersonLastName()
        {
            return base.GetPersonLastName();
        }

        public override string GetPersonFirstName()
        {
            return base.GetPersonFirstName();
        }

        public override int GetPersonAge()
        {
            return base.GetPersonAge();
        }

        public ref string PositionInfo()
        {
            return ref position;
        }

        public void ShowWorkerName()
        {            
            Console.WriteLine($"Name: {GetPersonFirstName()} {GetPersonLastName()}");            
        }

        public void ShowWorkerAge()
        {
            Console.WriteLine($"Age: {GetPersonAge()}");
        }

        public void ShowWorkerPosition()
        {
            Console.WriteLine($"Position: {position}");
        }

        public void ShowWorkerInfo()
        {
            Console.WriteLine("====Employee====");
            ShowWorkerName();
            ShowWorkerAge();
            ShowWorkerPosition();
        }
        
        public void ShowWorkerWork()
        {
            Console.WriteLine($"{position} works on {position}'s place!");
        }
    }
}
