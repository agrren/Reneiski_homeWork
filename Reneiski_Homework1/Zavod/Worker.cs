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

        public Worker() : base(null, null, 0)
        {
        }

        public override void ShowPersonInfo()
        {
            base.ShowPersonInfo();
        }

        public override ref string ShowPersonLastName()
        {
            return ref base.ShowPersonLastName();
        }

        //public string ShowWorkerLastName()
        //{
        //    return base.ShowPersonLastName();
        //}

        public override ref string ShowPersonFirstName()
        {
            return ref base.ShowPersonFirstName();
        }

        public override ref int ShowPersonAge()
        {
            return ref base.ShowPersonAge();
        }

        public ref string PositionInfo()
        {
            return ref position;
        }

        public void ShowWorkerName()
        {            
            Console.WriteLine($"Name: {ShowPersonFirstName()} {ShowPersonLastName()}");            
        }

        public void ShowWorkerAge()
        {
            Console.WriteLine($"Age: {ShowPersonAge()}");
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
